using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WebBrowser.UI
{
    public partial class TabUserControl : UserControl
    {
        Stack<string> backLinks = new Stack<string>();
        Stack<string> forwardLinks = new Stack<string>();

        public TabUserControl()
        {
            InitializeComponent();          

        }

        public void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            addressTextBox.Text = webBrowser1.Url.ToString();
        }

        /************************************************************
        *********************** Tool Strip *************************
        ************************************************************/
        public void backButton_Click(object sender, EventArgs e)
        {
            forwardLinks.Push(addressTextBox.Text);
            try
            {
                string backURL = backLinks.Pop();
                webBrowser1.Navigate(backURL);
            } catch
            {

            }
        }      

        public void forwardButton_Click(object sender, EventArgs e)
        {

        }

        public void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh(); 
        }

        public void homeButton_Click(object sender, EventArgs e)
        {

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

    }
}
