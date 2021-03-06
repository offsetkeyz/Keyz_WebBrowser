﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class TabUserControl : UserControl
    {
        public TabPage currentTabPage; 

        public TabUserControl()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";            
        }
        
        public TabUserControl(TabPage tabPageIn)
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
            currentTabPage = tabPageIn; 
        }

        public void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string previousURL = addressTextBox.Text;
            string currentURL = addressTextBox.Text = webBrowser1.Url.ToString();

            // push current link history if not the same as previous
            if (!previousURL.Equals(currentURL))
            {
                var newHistoryItem = new HistoryItem(webBrowser1.Url.ToString(), webBrowser1.DocumentTitle, DateTime.Now);
                HistoryManager.AddHistoryItem(newHistoryItem);
                currentTabPage.Text = webBrowser1.Document.Title; 
            }
           
            
        }

        public void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.webBrowser1.Document.MouseOver += new HtmlElementEventHandler(this.Browser_Mouse_Moved);
        }

        // mouse hover url
        private void Browser_Mouse_Moved(object sender, HtmlElementEventArgs e)
        {
            string element = webBrowser1.Document.GetElementFromPoint(e.ClientMousePosition).GetAttribute("href");
            toolStripStatusLabel1.Text = element;
        }


        // Sets progress bar
        private void webBrowser1_ProgressChanged_1(object sender, WebBrowserProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = (int)e.MaximumProgress; 

            if((e.CurrentProgress > 0) && (e.CurrentProgress <= e.MaximumProgress))
            {
                toolStripProgressBar1.Value = (int)e.CurrentProgress;
            }
        }



        /************************************************************
        *********************** Tool Strip *************************
        ************************************************************/
        public void backButton_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack(); 
            }
        }      

        public void forwardButton_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        public void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh(); 
        }

        public void homeButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com"); 
        }

        public void addressTextBox_Click(object sender, EventArgs e)
        {

        }

        public void goButton_Click_1(object sender, EventArgs e)
        {
            string url = addressTextBox.Text;
            try
            {
                webBrowser1.Navigate(new Uri(url));
            }
            catch
            {
                webBrowser1.Navigate(new Uri("http://" + url));
                addressTextBox.Text = "http://" + url;
            }
        }

        public void bookmarkButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newBookmarkItem = new BookmarkItem();
                newBookmarkItem.URL = webBrowser1.Url.ToString();
                newBookmarkItem.Title = webBrowser1.DocumentTitle; 
                BookmarkManager.AddBookmarkItem(newBookmarkItem); 
            } catch
            {
                MessageBox.Show("Bookmark URL already exists");
                
            }
        }
       

        // when user presses enter, browser will navigate
        // TODO: create separate method for navigating to address
        public void addressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = addressTextBox.Text;
                try
                {
                    webBrowser1.Navigate(new Uri(url));
                }
                catch
                {
                    webBrowser1.Navigate(new Uri("http://" + url));
                    addressTextBox.Text = "http://" + url;
                }
            }

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            addressTextBox.Text = "";
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            webBrowser1.Visible = true; 
        }
    }
}
