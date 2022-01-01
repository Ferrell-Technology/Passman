namespace Passman
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.credentialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCredentialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPassmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteImages = new System.Windows.Forms.ImageList(this.components);
            this.Username = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.ShowPasswordBtn = new System.Windows.Forms.Button();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.Website = new System.Windows.Forms.TextBox();
            this.WebsiteLbl = new System.Windows.Forms.Label();
            this.SiteListView = new Passman.CustomListView();
            this.ItemDetails = new System.Windows.Forms.GroupBox();
            this.Type = new System.Windows.Forms.ComboBox();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.TextBox();
            this.NotesLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.ItemDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.credentialToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(963, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // credentialToolStripMenuItem
            // 
            this.credentialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCredentialToolStripMenuItem,
            this.toolStripSeparator2,
            this.optionsToolStripMenuItem1});
            this.credentialToolStripMenuItem.Name = "credentialToolStripMenuItem";
            this.credentialToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.credentialToolStripMenuItem.Text = "Credential";
            // 
            // addCredentialToolStripMenuItem
            // 
            this.addCredentialToolStripMenuItem.Name = "addCredentialToolStripMenuItem";
            this.addCredentialToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.addCredentialToolStripMenuItem.Text = "Add Credential..";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
            this.optionsToolStripMenuItem1.Text = "Options..";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.aboutPassmanToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            // 
            // aboutPassmanToolStripMenuItem
            // 
            this.aboutPassmanToolStripMenuItem.Name = "aboutPassmanToolStripMenuItem";
            this.aboutPassmanToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.aboutPassmanToolStripMenuItem.Text = "About Passman";
            // 
            // siteImages
            // 
            this.siteImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.siteImages.ImageSize = new System.Drawing.Size(16, 16);
            this.siteImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(114, 136);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(227, 27);
            this.Username.TabIndex = 6;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(30, 139);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(78, 20);
            this.UsernameLbl.TabIndex = 5;
            this.UsernameLbl.Text = "Username:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(114, 169);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(227, 27);
            this.Password.TabIndex = 4;
            this.Password.UseSystemPasswordChar = true;
            // 
            // ShowPasswordBtn
            // 
            this.ShowPasswordBtn.Location = new System.Drawing.Point(347, 169);
            this.ShowPasswordBtn.Name = "ShowPasswordBtn";
            this.ShowPasswordBtn.Size = new System.Drawing.Size(62, 29);
            this.ShowPasswordBtn.TabIndex = 3;
            this.ShowPasswordBtn.Text = "Show..";
            this.ShowPasswordBtn.UseVisualStyleBackColor = true;
            this.ShowPasswordBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordBtn_MouseDown);
            this.ShowPasswordBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordBtn_MouseUp);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(35, 172);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(73, 20);
            this.PasswordLbl.TabIndex = 2;
            this.PasswordLbl.Text = "Password:";
            // 
            // Website
            // 
            this.Website.Location = new System.Drawing.Point(114, 103);
            this.Website.Name = "Website";
            this.Website.Size = new System.Drawing.Size(227, 27);
            this.Website.TabIndex = 1;
            // 
            // WebsiteLbl
            // 
            this.WebsiteLbl.AutoSize = true;
            this.WebsiteLbl.Location = new System.Drawing.Point(43, 106);
            this.WebsiteLbl.Name = "WebsiteLbl";
            this.WebsiteLbl.Size = new System.Drawing.Size(65, 20);
            this.WebsiteLbl.TabIndex = 0;
            this.WebsiteLbl.Text = "Website:";
            // 
            // SiteListView
            // 
            this.SiteListView.EmptyMessage = "No saved credentials";
            this.SiteListView.EmptyMessageColor = System.Drawing.Color.Silver;
            this.SiteListView.HideSelection = false;
            this.SiteListView.Location = new System.Drawing.Point(12, 31);
            this.SiteListView.MultiSelect = false;
            this.SiteListView.Name = "SiteListView";
            this.SiteListView.Size = new System.Drawing.Size(412, 506);
            this.SiteListView.SmallImageList = this.siteImages;
            this.SiteListView.TabIndex = 3;
            this.SiteListView.UseCompatibleStateImageBehavior = false;
            this.SiteListView.View = System.Windows.Forms.View.List;
            this.SiteListView.SelectedIndexChanged += new System.EventHandler(this.SiteListView_SelectedIndexChanged);
            // 
            // ItemDetails
            // 
            this.ItemDetails.Controls.Add(this.Type);
            this.ItemDetails.Controls.Add(this.TypeLbl);
            this.ItemDetails.Controls.Add(this.Notes);
            this.ItemDetails.Controls.Add(this.NotesLbl);
            this.ItemDetails.Controls.Add(this.SaveBtn);
            this.ItemDetails.Controls.Add(this.ResetBtn);
            this.ItemDetails.Controls.Add(this.Website);
            this.ItemDetails.Controls.Add(this.Username);
            this.ItemDetails.Controls.Add(this.ShowPasswordBtn);
            this.ItemDetails.Controls.Add(this.PasswordLbl);
            this.ItemDetails.Controls.Add(this.Password);
            this.ItemDetails.Controls.Add(this.WebsiteLbl);
            this.ItemDetails.Controls.Add(this.UsernameLbl);
            this.ItemDetails.Location = new System.Drawing.Point(430, 31);
            this.ItemDetails.Name = "ItemDetails";
            this.ItemDetails.Size = new System.Drawing.Size(521, 506);
            this.ItemDetails.TabIndex = 7;
            this.ItemDetails.TabStop = false;
            this.ItemDetails.Text = "Details";
            this.ItemDetails.Visible = false;
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Website",
            "Standard"});
            this.Type.Location = new System.Drawing.Point(114, 70);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(137, 28);
            this.Type.TabIndex = 12;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(65, 73);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(43, 20);
            this.TypeLbl.TabIndex = 11;
            this.TypeLbl.Text = "Type:";
            // 
            // Notes
            // 
            this.Notes.Location = new System.Drawing.Point(114, 202);
            this.Notes.Multiline = true;
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(227, 81);
            this.Notes.TabIndex = 10;
            // 
            // NotesLbl
            // 
            this.NotesLbl.AutoSize = true;
            this.NotesLbl.Location = new System.Drawing.Point(57, 205);
            this.NotesLbl.Name = "NotesLbl";
            this.NotesLbl.Size = new System.Drawing.Size(51, 20);
            this.NotesLbl.TabIndex = 9;
            this.NotesLbl.Text = "Notes:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(389, 471);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(126, 29);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(6, 471);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(94, 29);
            this.ResetBtn.TabIndex = 7;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 718);
            this.Controls.Add(this.ItemDetails);
            this.Controls.Add(this.SiteListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ItemDetails.ResumeLayout(false);
            this.ItemDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutPassmanToolStripMenuItem;
        private System.Windows.Forms.TextBox Website;
        private System.Windows.Forms.Label WebsiteLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button ShowPasswordBtn;
        private System.Windows.Forms.ImageList siteImages;
        private CustomListView SiteListView;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.GroupBox ItemDetails;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.Label NotesLbl;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.ToolStripMenuItem credentialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCredentialToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
    }
}
