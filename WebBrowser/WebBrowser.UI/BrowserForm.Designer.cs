﻿namespace WebBrowser.UI
{
    partial class BrowserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserForm));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCurrentTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePageAsHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addTabPage = new System.Windows.Forms.TabPage();
            this.RightClickMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CloseTab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.RightClickMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(1488, 31);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStrip,
            this.closeCurrentTabToolStripMenuItem,
            this.savePageAsHTMLToolStripMenuItem,
            this.printPageToolStripMenuItem,
            this.exitBrowserToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 29);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newTabToolStrip
            // 
            this.newTabToolStrip.Name = "newTabToolStrip";
            this.newTabToolStrip.Size = new System.Drawing.Size(270, 34);
            this.newTabToolStrip.Text = "New Tab";
            this.newTabToolStrip.Click += new System.EventHandler(this.newTabToolStrip_Click);
            // 
            // closeCurrentTabToolStripMenuItem
            // 
            this.closeCurrentTabToolStripMenuItem.Name = "closeCurrentTabToolStripMenuItem";
            this.closeCurrentTabToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.closeCurrentTabToolStripMenuItem.Text = "Close Current Tab";
            this.closeCurrentTabToolStripMenuItem.Click += new System.EventHandler(this.closeCurrentTabToolStripMenuItem_Click);
            // 
            // savePageAsHTMLToolStripMenuItem
            // 
            this.savePageAsHTMLToolStripMenuItem.Name = "savePageAsHTMLToolStripMenuItem";
            this.savePageAsHTMLToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.savePageAsHTMLToolStripMenuItem.Text = "Save Page As HTML";
            this.savePageAsHTMLToolStripMenuItem.Click += new System.EventHandler(this.savePageAsHTMLToolStripMenuItem_Click);
            // 
            // printPageToolStripMenuItem
            // 
            this.printPageToolStripMenuItem.Name = "printPageToolStripMenuItem";
            this.printPageToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.printPageToolStripMenuItem.Text = "Print Page";
            this.printPageToolStripMenuItem.Click += new System.EventHandler(this.printPageToolStripMenuItem_Click);
            // 
            // exitBrowserToolStripMenuItem
            // 
            this.exitBrowserToolStripMenuItem.Name = "exitBrowserToolStripMenuItem";
            this.exitBrowserToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitBrowserToolStripMenuItem.Text = "Exit Browser";
            this.exitBrowserToolStripMenuItem.Click += new System.EventHandler(this.exitBrowserToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageHistoryToolStripMenuItem,
            this.manageBookmarksToolStripMenuItem,
            this.clearHistoryToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // manageHistoryToolStripMenuItem
            // 
            this.manageHistoryToolStripMenuItem.Name = "manageHistoryToolStripMenuItem";
            this.manageHistoryToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.manageHistoryToolStripMenuItem.Text = "Manage History";
            this.manageHistoryToolStripMenuItem.Click += new System.EventHandler(this.manageHistoryToolStripMenuItem_Click);
            // 
            // manageBookmarksToolStripMenuItem
            // 
            this.manageBookmarksToolStripMenuItem.Name = "manageBookmarksToolStripMenuItem";
            this.manageBookmarksToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.manageBookmarksToolStripMenuItem.Text = "Manage Bookmarks";
            this.manageBookmarksToolStripMenuItem.Click += new System.EventHandler(this.manageBookmarksToolStripMenuItem_Click);
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.clearHistoryToolStripMenuItem.Text = "Clear History";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 27);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1488, 1296);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 3;
            this.tabControl1.TabStop = false;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // addTabPage
            // 
            this.addTabPage.BackColor = System.Drawing.Color.Transparent;
            this.addTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addTabPage.Location = new System.Drawing.Point(4, 31);
            this.addTabPage.Name = "addTabPage";
            this.addTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addTabPage.Size = new System.Drawing.Size(1480, 1261);
            this.addTabPage.TabIndex = 1;
            this.addTabPage.Text = " + ";
            this.addTabPage.Click += new System.EventHandler(this.addTabPage_Click);
            // 
            // RightClickMenuStrip
            // 
            this.RightClickMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.RightClickMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseTab});
            this.RightClickMenuStrip.Name = "RightClickMenuStrip";
            this.RightClickMenuStrip.Size = new System.Drawing.Size(241, 69);
            this.RightClickMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.RightClickMenuStrip_Opening);
            // 
            // CloseTab
            // 
            this.CloseTab.Name = "CloseTab";
            this.CloseTab.Size = new System.Drawing.Size(240, 32);
            this.CloseTab.Text = "Close Tab";
            this.CloseTab.Click += new System.EventHandler(this.CloseTab_Click);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1488, 1327);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrowserForm";
            this.ShowInTaskbar = false;
            this.Text = "KEYZ";
            this.Load += new System.EventHandler(this.BrowserForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BrowserForm_MouseDown);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.RightClickMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStrip;
        private System.Windows.Forms.ToolStripMenuItem closeCurrentTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePageAsHTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
        private System.Windows.Forms.TabPage addTabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ContextMenuStrip RightClickMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CloseTab;
    }
}

