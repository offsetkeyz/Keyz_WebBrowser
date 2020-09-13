﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            InitializeComponent();
        }

        public void BrowserForm_Load(object sender, EventArgs e)
        {

        }

        /************************************************************
         *********************** Menu Strip *************************
         ************************************************************/
        // File Options
        private void newTabToolStrip_Click(object sender, EventArgs e)
        {
            TabPage newTabPage = new TabPage();
            newTabPage.Text = "New Tab2";
            TabUserControl newUserControl = new TabUserControl();
            newUserControl.Dock = DockStyle.Fill; 
            newTabPage.Controls.Add(newUserControl); 
            this.tabControl1.TabPages.Add(newTabPage); 
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage currentTab = tabControl1.SelectedTab;
            currentTab.Dispose();  
        }

        private void savePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        // Tools
        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Help
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "This browser was created by Colin McAllister for use in Auburn " +
                "University's Software Construction Class. Email CZM0135@auburn.edu " +
                "with any questions. Copyright 2020.";
            MessageBox.Show(message);
        }

        private void tabUserControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}