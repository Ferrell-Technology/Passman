using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Passman.Models;
using Passman.Resources;

namespace Passman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<ICredential> list = new List<ICredential>();
        private BackgroundWorker getIconsWorker = null;
        private bool hasChanged = false;
        private void Form1_Load(object sender, EventArgs e)
        {         
            // check for internet connectivity:
            Internal.CheckForInternetConnection();
            if (Internal.Internet)
            {
                // Get saved passwords from the database:
                list = Resources.MySql.GetAll();
                // Get locally saved credentials:

            }
            else
            {
                // Get locally saved credentials:

            }

            getIconsWorker = new BackgroundWorker();
            getIconsWorker.DoWork += GetIconsWorker_DoWork;          

            foreach (ICredential credential in list)
            {
                SiteListView.Items.Add(new ListViewItem(credential.Website));
            }
            if (list.Count > 0)
            {
                getIconsWorker.RunWorkerAsync();
                SiteListView.Items[0].Selected = true;
                SiteListView.Select();
            }
            //ModifyTextboxListeners(true);
            
        }
        private void ModifyTextboxListeners(bool register)
        {
            if (register)
            {
                Type.TextChanged += Textboxes_TextChanged;
                Website.TextChanged += Textboxes_TextChanged;
                Username.TextChanged += Textboxes_TextChanged;
                Password.TextChanged += Textboxes_TextChanged;
                Notes.TextChanged += Textboxes_TextChanged;
            }
            else
            {
                Type.TextChanged -= Textboxes_TextChanged;
                Website.TextChanged -= Textboxes_TextChanged;
                Username.TextChanged -= Textboxes_TextChanged;
                Password.TextChanged -= Textboxes_TextChanged;
                Notes.TextChanged -= Textboxes_TextChanged;
            }          
        }
        private void GetIconsWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            AssignIcons(Internal.Internet);
        }
        public void AssignIcons(bool online)
        {
            SiteListView.SmallImageList.Images.Clear();
            int len = 0;
            this.SiteListView.Invoke((MethodInvoker)delegate 
            { 
                len = SiteListView.Items.Count;
            });
            for (int i = 0; i < len; i++)
            {
                string text = "";
                this.SiteListView.Invoke((MethodInvoker)delegate
                {
                    text = SiteListView.Items[i].Text;
                });
                Image image = Imaging.GetIcon(text);
                if (image == null)
                {
                    if (online)
                    {
                        Image img = Imaging.GetFavIcon(text);
                        //if (img == null) { img = Image.FromFile("world-icon.png"); }
                        this.SiteListView.Invoke((MethodInvoker)delegate
                        {
                            SiteListView.SmallImageList.Images.Add(img);
                            SiteListView.Items[i].ImageIndex = SiteListView.SmallImageList.Images.Count - 1;
                        });
                        Imaging.SaveImage(text, img);
                    }
                    else
                    {
                        this.SiteListView.Invoke((MethodInvoker)delegate
                        {
                            SiteListView.SmallImageList.Images.Add(Image.FromFile(Imaging.GlobeIconPath));
                            SiteListView.Items[i].ImageIndex = SiteListView.SmallImageList.Images.Count - 1;
                        });
                    }
                }
                else
                {
                    this.SiteListView.Invoke((MethodInvoker)delegate
                    {
                        SiteListView.SmallImageList.Images.Add(image);
                        SiteListView.Items[i].ImageIndex = SiteListView.SmallImageList.Images.Count - 1;
                    });
                }
            }           
        }       
        private void ShowPasswordBtn_MouseDown(object sender, MouseEventArgs e)
        {
            Password.UseSystemPasswordChar = false;
        }
        private void ShowPasswordBtn_MouseUp(object sender, MouseEventArgs e)
        {
            Password.UseSystemPasswordChar = true;
        }
        private void SiteListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (SiteListView.SelectedItems.Count > 0)
            {
                if (hasChanged)
                {
                    DialogResult result = MessageBox.Show("Do you want to save your changes?", "Passman", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        SaveBtn_Click(sender, e);
                    }
                    hasChanged = false;
                }
                ModifyTextboxListeners(false);
                ItemDetails.Text = "Details - " + SiteListView.SelectedItems[0].Text;
                ItemDetails.Visible = true;
                SaveBtn.Enabled = false;
                SaveBtn.Text = "Save";
                ICredential credential = list[SiteListView.SelectedIndices[0]];
                Type.SelectedItem = credential.Type.ToString();
                if (credential.Type == CredentialType.Standard)
                    Website.Enabled = false;
                Website.Text = credential.Website;
                Username.Text = credential.Username;
                Password.Text = credential.Password;
                Notes.Text = credential.Notes;
                CheckPasswordStrength();
                ModifyTextboxListeners(true);
            }
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Type.SelectedItem = null;
            Website.Text = "";
            Username.Text = "";
            Password.Text = "";
            Notes.Text = "";
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveBtn.Enabled = false;
            SaveBtn.Text = "Saving...";
            ICredential credential = null;
            Enum.TryParse(Type.GetItemText(Type.SelectedItem), out CredentialType type);
            switch (type)
            {
                case CredentialType.Standard:
                    credential = new StandardCredential
                    {
                        Username = Username.Text,
                        Password = Password.Text,
                        Notes = Notes.Text,
                    };
                    break;
                case CredentialType.Website:
                    credential = new WebsiteCredential
                    {
                        Website = Website.Text,
                        Username = Username.Text,
                        Password = Password.Text,
                        Notes = Notes.Text,
                    };
                    break;
            }
            // check if credential exists by checking if any items are selected in the SiteListView:
            if (SiteListView.SelectedItems.Count > 0)
            {
                credential.Id = list[SiteListView.Items.IndexOf(SiteListView.SelectedItems[SiteListView.SelectedItems.Count - 1])].Id;
                list[SiteListView.SelectedIndices[0]] = credential;
                Resources.MySql.Update(credential);
                SaveBtn.Enabled = false;
                hasChanged = false;
            }
            else
            {
                Resources.MySql.Add(credential);
                AddToListView(credential);
                AssignIcons(Internal.Internet);
            }
            SaveBtn.Text = "Saved!";
        }
        private void Textboxes_TextChanged(object sender, EventArgs e)
        {
            SaveBtn.Enabled = true;
            SaveBtn.Text = "Save";
            hasChanged = true;
            if ((TextBox)sender == Password)
            {
                CheckPasswordStrength();
            }
        }
        private void AddToListView(ICredential credential)
        {
            if (SiteListView.SelectedItems.Count > 0)
            {
                int indexToAdd = SiteListView.Items.IndexOf(SiteListView.SelectedItems[SiteListView.SelectedItems.Count - 1]) + 1;
                list.Insert(indexToAdd, credential);
                SiteListView.Items.Insert(indexToAdd, credential.ToString());
            }
            else
            {
                list.Add(credential);
                SiteListView.Items.Add(credential.ToString());
            }
        }
        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Type.SelectedItem.ToString() == CredentialType.Standard.ToString())
            {
                Website.Enabled = false;
            }
            else if (Type.SelectedItem.ToString() == CredentialType.Website.ToString())
            {
                Website.Enabled = true;
            }
        }
        private void SiteListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem focusedItem = SiteListView.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    SiteItemContextMenu.Show(Cursor.Position);
                }
                else
                {
                    SiteContextMenu.Show(Cursor.Position);
                }
            }
        }
        private void CheckPasswordStrength()
        {
            Security.PasswordStrength score = Security.PasswordCheck.GetPasswordStrength(Password.Text);
            switch (score)
            {
                case Security.PasswordStrength.Blank:
                    PasswordStrength.Text = "Blank";
                    PasswordStrength.ForeColor = Color.DarkRed;
                    break;
                case Security.PasswordStrength.VeryWeak:
                    PasswordStrength.Text = "Very Weak";
                    PasswordStrength.ForeColor = Color.Red;
                    break;
                case Security.PasswordStrength.Weak:
                    PasswordStrength.Text = "Weak";
                    PasswordStrength.ForeColor = Color.Red;
                    break;
                case Security.PasswordStrength.Medium:
                    PasswordStrength.Text = "Medium";
                    PasswordStrength.ForeColor = Color.FromArgb(255, 140, 0);
                    break;
                case Security.PasswordStrength.Strong:
                    PasswordStrength.Text = "Strong";
                    PasswordStrength.ForeColor = Color.FromArgb(46, 139, 87);
                    break;
                case Security.PasswordStrength.VeryStrong:
                    PasswordStrength.Text = "Very Strong";
                    PasswordStrength.ForeColor = Color.Green;
                    break;
            }
        }
    }
}
