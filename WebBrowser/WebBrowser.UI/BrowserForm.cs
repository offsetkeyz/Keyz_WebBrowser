using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

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
        protected void newTabToolStrip_Click(object sender, EventArgs e)
        {
            TabPage newTabPage = new TabPage();
            newTabPage.Text = "New Tab";
            TabUserControl newUserControl = new TabUserControl();
            newUserControl.Dock = DockStyle.Fill; 
            newTabPage.Controls.Add(newUserControl); 
            this.tabControl1.TabPages.Add(newTabPage); 
        }

        /** 
         * CTRL + T opens new tab
         * CTRL + W closes current tab
         */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.T))
            {
                TabPage newTabPage = new TabPage();
                newTabPage.Text = "New Tab";
                TabUserControl newUserControl = new TabUserControl();
                newUserControl.Dock = DockStyle.Fill;
                newTabPage.Controls.Add(newUserControl);
                tabControl1.TabPages.Add(newTabPage);
                return true; 
            }

            if (keyData == (Keys.Control | Keys.W))
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                return true; 
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab.Dispose(); 
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
            var histManagerForm = new HistoryManagerForm();
            histManagerForm.ShowDialog(); 
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookmarkManager = new BookmarkManagerForm();
            bookmarkManager.ShowDialog(); 
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to clear history?";
            var confirmBox = MessageBox.Show(message, "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmBox == DialogResult.Yes)
            {
                HistoryManager newManager = new HistoryManager();
                HistoryManager.ClearHistory();
            }
        }


        // Help
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "This browser was created by Colin McAllister for use in Auburn " +
                "University's Software Construction Class. Email CZM0135@auburn.edu " +
                "with any questions. Copyright 2020.";
            MessageBox.Show(message);
        }

        protected void tabUserControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}