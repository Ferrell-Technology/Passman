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

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Credential> list = new List<Credential>();
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

            BackgroundWorker getIconsWorker = new BackgroundWorker();
            getIconsWorker.DoWork += GetIconsWorker_DoWork;          

            foreach (Credential credential in list)
            {
                SiteListView.Items.Add(new ListViewItem(credential.Website));
            }

            if (list.Count > 0)
            {
                getIconsWorker.RunWorkerAsync();
            }
            
            Password.Text = "testValue";
        }
        private void GetIconsWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            AssignIcons(Internal.Internet);
        }
        public void AssignIcons(bool online)
        {
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
    }
}
