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
            this.ShowPasswordBtn = new System.Windows.Forms.Button();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.Website = new System.Windows.Forms.TextBox();
            this.WebsiteLbl = new System.Windows.Forms.Label();
            this.SiteContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemDetails = new System.Windows.Forms.GroupBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.PasswordStrength = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.TextBox();
            this.NotesLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SiteItemContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteCredentialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SiteListView = new Passman.CustomListView();
            this.menuStrip1.SuspendLayout();
            this.SiteContextMenu.SuspendLayout();
            this.ItemDetails.SuspendLayout();
            this.SiteItemContextMenu.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
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
            this.credentialToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.credentialToolStripMenuItem.Text = "Credential";
            // 
            // addCredentialToolStripMenuItem
            // 
            this.addCredentialToolStripMenuItem.Name = "addCredentialToolStripMenuItem";
            this.addCredentialToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addCredentialToolStripMenuItem.Text = "Add Credential..";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.optionsToolStripMenuItem1.Text = "Options..";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.aboutPassmanToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            // 
            // aboutPassmanToolStripMenuItem
            // 
            this.aboutPassmanToolStripMenuItem.Name = "aboutPassmanToolStripMenuItem";
            this.aboutPassmanToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
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
            this.Username.Location = new System.Drawing.Point(100, 102);
            this.Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(199, 23);
            this.Username.TabIndex = 6;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(26, 104);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(63, 15);
            this.UsernameLbl.TabIndex = 5;
            this.UsernameLbl.Text = "Username:";
            // 
            // ShowPasswordBtn
            // 
            this.ShowPasswordBtn.Location = new System.Drawing.Point(304, 127);
            this.ShowPasswordBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowPasswordBtn.Name = "ShowPasswordBtn";
            this.ShowPasswordBtn.Size = new System.Drawing.Size(54, 22);
            this.ShowPasswordBtn.TabIndex = 3;
            this.ShowPasswordBtn.Text = "Show..";
            this.ShowPasswordBtn.UseVisualStyleBackColor = true;
            this.ShowPasswordBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordBtn_MouseDown);
            this.ShowPasswordBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordBtn_MouseUp);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(31, 129);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(60, 15);
            this.PasswordLbl.TabIndex = 2;
            this.PasswordLbl.Text = "Password:";
            // 
            // Website
            // 
            this.Website.Location = new System.Drawing.Point(100, 77);
            this.Website.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Website.Name = "Website";
            this.Website.Size = new System.Drawing.Size(199, 23);
            this.Website.TabIndex = 1;
            // 
            // WebsiteLbl
            // 
            this.WebsiteLbl.AutoSize = true;
            this.WebsiteLbl.Location = new System.Drawing.Point(38, 80);
            this.WebsiteLbl.Name = "WebsiteLbl";
            this.WebsiteLbl.Size = new System.Drawing.Size(52, 15);
            this.WebsiteLbl.TabIndex = 0;
            this.WebsiteLbl.Text = "Website:";
            // 
            // SiteContextMenu
            // 
            this.SiteContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.SiteContextMenu.Name = "SiteContextMenu";
            this.SiteContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.SiteContextMenu.Size = new System.Drawing.Size(154, 26);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.testToolStripMenuItem.Text = "Add Credential";
            // 
            // ItemDetails
            // 
            this.ItemDetails.Controls.Add(this.Password);
            this.ItemDetails.Controls.Add(this.PasswordStrength);
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
            this.ItemDetails.Controls.Add(this.WebsiteLbl);
            this.ItemDetails.Controls.Add(this.UsernameLbl);
            this.ItemDetails.Location = new System.Drawing.Point(376, 23);
            this.ItemDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemDetails.Name = "ItemDetails";
            this.ItemDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemDetails.Size = new System.Drawing.Size(456, 380);
            this.ItemDetails.TabIndex = 7;
            this.ItemDetails.TabStop = false;
            this.ItemDetails.Text = "Details";
            this.ItemDetails.Visible = false;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(100, 128);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(198, 23);
            this.Password.TabIndex = 14;
            this.Password.UseSystemPasswordChar = true;
            // 
            // PasswordStrength
            // 
            this.PasswordStrength.AutoSize = true;
            this.PasswordStrength.Location = new System.Drawing.Point(148, 152);
            this.PasswordStrength.Name = "PasswordStrength";
            this.PasswordStrength.Size = new System.Drawing.Size(0, 15);
            this.PasswordStrength.TabIndex = 13;
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Website",
            "Standard"});
            this.Type.Location = new System.Drawing.Point(100, 52);
            this.Type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(120, 23);
            this.Type.TabIndex = 12;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(57, 55);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(34, 15);
            this.TypeLbl.TabIndex = 11;
            this.TypeLbl.Text = "Type:";
            // 
            // Notes
            // 
            this.Notes.Location = new System.Drawing.Point(100, 169);
            this.Notes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Notes.Multiline = true;
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(199, 72);
            this.Notes.TabIndex = 10;
            // 
            // NotesLbl
            // 
            this.NotesLbl.AutoSize = true;
            this.NotesLbl.Location = new System.Drawing.Point(50, 171);
            this.NotesLbl.Name = "NotesLbl";
            this.NotesLbl.Size = new System.Drawing.Size(41, 15);
            this.NotesLbl.TabIndex = 9;
            this.NotesLbl.Text = "Notes:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(340, 353);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 22);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(5, 353);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(82, 22);
            this.ResetBtn.TabIndex = 7;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // SiteItemContextMenu
            // 
            this.SiteItemContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCredentialToolStripMenuItem});
            this.SiteItemContextMenu.Name = "SiteItemContextMenu";
            this.SiteItemContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.SiteItemContextMenu.Size = new System.Drawing.Size(165, 26);
            // 
            // deleteCredentialToolStripMenuItem
            // 
            this.deleteCredentialToolStripMenuItem.Name = "deleteCredentialToolStripMenuItem";
            this.deleteCredentialToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteCredentialToolStripMenuItem.Text = "Delete Credential";
            // 
            // SiteListView
            // 
            this.SiteListView.EmptyMessageColor = System.Drawing.Color.Empty;
            this.SiteListView.FullRowSelect = true;
            this.SiteListView.HideSelection = false;
            this.SiteListView.Location = new System.Drawing.Point(12, 26);
            this.SiteListView.Name = "SiteListView";
            this.SiteListView.Size = new System.Drawing.Size(358, 377);
            this.SiteListView.SmallImageList = this.siteImages;
            this.SiteListView.TabIndex = 8;
            this.SiteListView.UseCompatibleStateImageBehavior = false;
            this.SiteListView.View = System.Windows.Forms.View.List;
            this.SiteListView.SelectedIndexChanged += new System.EventHandler(this.SiteListView_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 538);
            this.Controls.Add(this.SiteListView);
            this.Controls.Add(this.ItemDetails);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SiteContextMenu.ResumeLayout(false);
            this.ItemDetails.ResumeLayout(false);
            this.ItemDetails.PerformLayout();
            this.SiteItemContextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Button ShowPasswordBtn;
        private System.Windows.Forms.ImageList siteImages;
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
        private System.Windows.Forms.ContextMenuStrip SiteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip SiteItemContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteCredentialToolStripMenuItem;
        private System.Windows.Forms.Label PasswordStrength;
        private System.Windows.Forms.TextBox Password;
        private CustomListView SiteListView;
    }
}
