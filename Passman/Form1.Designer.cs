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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPassmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteImages = new System.Windows.Forms.ImageList(this.components);
            this.ItemDetailsPanel = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.TextBox();
            this.ShowPasswordBtn = new System.Windows.Forms.Button();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.Website = new System.Windows.Forms.TextBox();
            this.WebsiteLbl = new System.Windows.Forms.Label();
            this.SiteListView = new Passman.CustomListView();
            this.menuStrip1.SuspendLayout();
            this.ItemDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1109, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.optionsToolStripMenuItem.Text = "Options...";
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
            // ItemDetailsPanel
            // 
            this.ItemDetailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemDetailsPanel.Controls.Add(this.Password);
            this.ItemDetailsPanel.Controls.Add(this.ShowPasswordBtn);
            this.ItemDetailsPanel.Controls.Add(this.PasswordLbl);
            this.ItemDetailsPanel.Controls.Add(this.Website);
            this.ItemDetailsPanel.Controls.Add(this.WebsiteLbl);
            this.ItemDetailsPanel.Location = new System.Drawing.Point(430, 31);
            this.ItemDetailsPanel.Name = "ItemDetailsPanel";
            this.ItemDetailsPanel.Size = new System.Drawing.Size(667, 506);
            this.ItemDetailsPanel.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(165, 114);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(227, 27);
            this.Password.TabIndex = 4;
            this.Password.UseSystemPasswordChar = true;
            // 
            // ShowPasswordBtn
            // 
            this.ShowPasswordBtn.Location = new System.Drawing.Point(398, 113);
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
            this.PasswordLbl.Location = new System.Drawing.Point(86, 117);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(73, 20);
            this.PasswordLbl.TabIndex = 2;
            this.PasswordLbl.Text = "Password:";
            // 
            // Website
            // 
            this.Website.Location = new System.Drawing.Point(165, 64);
            this.Website.Name = "Website";
            this.Website.Size = new System.Drawing.Size(227, 27);
            this.Website.TabIndex = 1;
            // 
            // WebsiteLbl
            // 
            this.WebsiteLbl.AutoSize = true;
            this.WebsiteLbl.Location = new System.Drawing.Point(94, 67);
            this.WebsiteLbl.Name = "WebsiteLbl";
            this.WebsiteLbl.Size = new System.Drawing.Size(65, 20);
            this.WebsiteLbl.TabIndex = 0;
            this.WebsiteLbl.Text = "Website:";
            // 
            // SiteListView
            // 
            this.SiteListView.EmptyMessage = "No data";
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 718);
            this.Controls.Add(this.SiteListView);
            this.Controls.Add(this.ItemDetailsPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ItemDetailsPanel.ResumeLayout(false);
            this.ItemDetailsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutPassmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Panel ItemDetailsPanel;
        private System.Windows.Forms.TextBox Website;
        private System.Windows.Forms.Label WebsiteLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button ShowPasswordBtn;
        private System.Windows.Forms.ImageList siteImages;
        private CustomListView SiteListView;
    }
}
