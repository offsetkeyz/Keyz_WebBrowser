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

        public TabControl publicTabControl; 

        public BrowserForm()
        {
            InitializeComponent();
            publicTabControl = tabControl1; 
        }

        public void BrowserForm_Load(object sender, EventArgs e)
        {
        }

        /************************************************************
         *********************** Menu Strip *************************
         ************************************************************/
        // File Options
        public void newTabToolStrip_Click(object sender, EventArgs e)
        {
            TabPage newTabPage = new TabPage();
            newTabPage.Text = "New Tab";
            TabUserControl newUserControl = new TabUserControl(newTabPage);
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
                TabUserControl newUserControl = new TabUserControl(newTabPage);
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

        public void tabUserControl1_Load(object sender, EventArgs e)
        {
        }




        /*************************************************************************
         * ************************** Add Tab Page *******************************
         * **********************************************************************/
        // determines the tab has been clicked
        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = this.tabControl1.TabCount - 1; 
            if(this.tabControl1.GetTabRect(lastIndex).Contains(e.Location))
            {
                TabPage newTabPage = new TabPage();
                newTabPage.Text = "New Tab";
                TabUserControl newUserControl = new TabUserControl(newTabPage);
                newUserControl.Dock = DockStyle.Fill;
                newTabPage.Controls.Add(newUserControl);
                tabControl1.TabPages.Insert(lastIndex, newTabPage);
                this.tabControl1.SelectedIndex = lastIndex; 
            }

        }

        // prevent selecting
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(e.TabPageIndex == this.tabControl1.TabCount - 1)
            {
                e.Cancel = true; 
            }
        }

        //**************************** Adds X to tab ********************************
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
/*            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black,
                e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
*/        }

        private void BrowserForm_MouseDown(object sender, MouseEventArgs e)
        {
            /*            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
                        {
                            Rectangle r = tabControl1.GetTabRect(i);
                            //Getting the position of the "x" mark.
                            Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                            if (closeButton.Contains(e.Location))
                            {
                                if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    this.tabControl1.TabPages.RemoveAt(i);
                                    break;


                        tabControl1.SelectedTab.Text = this.tabUserControl1.webBrowserTitle; 

                                }
                            }
                        }
            */
        }
    }
}