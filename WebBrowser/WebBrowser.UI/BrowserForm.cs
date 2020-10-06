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
        public TabPage selectedTabPage;  

        public BrowserForm()
        {
            InitializeComponent();
        }

        public void BrowserForm_Load(object sender, EventArgs e)
        {
            CreateNewTab();
        }

        /************************************************************
         *********************** Menu Strip *************************
         ************************************************************/
        // File Options
        /**
         * Create new tab
         */
        public void newTabToolStrip_Click(object sender, EventArgs e)
        {
            CreateNewTab(); 
        }

        /** 
         * CTRL + T opens new tab
         * CTRL + W closes current tab
         */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.T))
            {
                CreateNewTab();
                return true; 
            }

            if (keyData == (Keys.Control | Keys.W))
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                return true; 
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        /**
         * Close current tab
         */
        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab.Dispose(); 
        }

        private void savePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {//TODO create this
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


        /*************************************************************************
         * ************************** Add Tab Page *******************************
         * **********************************************************************/

        // determines the tab has been clicked
        protected void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = this.tabControl1.TabCount - 1; 
            if(this.tabControl1.GetTabRect(lastIndex).Contains(e.Location))
            {
                CreateNewTab(); 
            }

            // right click on tab
            if (e.Button == MouseButtons.Right)
            {
                for(int i = 0; i < tabControl1.TabCount; i++)
                {
                    Rectangle r = tabControl1.GetTabRect(i);
                    if (r.Contains(e.Location))
                    {
                        RightClickMenuStrip.Show(this, new Point(e.X, e.Y));
                        selectedTabPage = tabControl1.TabPages[i]; 
                    }
                }
            }
        }

        private void CloseTab_Click(object sender, EventArgs e)
        {
            selectedTabPage.Dispose(); 
        }

        // prevent selecting of add tab page
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(e.TabPageIndex == this.tabControl1.TabCount - 1)
            {
                e.Cancel = true; 
            }
        }

        /**
         * Creates a new tab at the second to last index
         */
        public void CreateNewTab()
        {
            var lastIndex = this.tabControl1.TabCount - 1;
            TabPage newTabPage = new TabPage();
            newTabPage.Text = "New Tab";
            TabUserControl newUserControl = new TabUserControl(newTabPage);
            newUserControl.Dock = DockStyle.Fill;
            newUserControl.BackgroundImage = Properties.Resources.Keyz_Logo;
            newUserControl.BackgroundImageLayout = ImageLayout.Zoom;

            newTabPage.Controls.Add(newUserControl);
            tabControl1.TabPages.Insert(lastIndex, newTabPage);
            this.tabControl1.SelectedIndex = lastIndex;
        }



        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
        }

        private void BrowserForm_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void addTabPage_Click(object sender, EventArgs e)
        {
        }

        private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        public void tabUserControl1_Load(object sender, EventArgs e)
        {
        }

        private void RightClickMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

    }
}