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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }


        private void HistoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            PopulateHistoryListBox(); 
        }

        private void HistorySearchButton_Click(object sender, EventArgs e)
        {
            if (!HistorySearchTextBox.Text.Trim().Equals(""))
            {
                var items = HistoryManager.GetAllHistoryItems();
                HistoryListBox.Items.Clear();
                string searchFor = HistorySearchTextBox.Text.Trim().ToLower();
                foreach (var item in items)
                {
                    if (item.URL.Contains(searchFor) || item.Title.Contains(searchFor))
                    {
                        HistoryListBox.Items.Add(string.Format("[{0}] {1} ({2})",
                            item.Date, item.Title, item.URL));
                    }
                }
            }

        }

        private void HistorySearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearHistoryButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to clear history?";
            var confirmBox = MessageBox.Show(message, "Warning", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning); 
            if(confirmBox == DialogResult.Yes)
            {
                HistoryManager.ClearHistory();
                HistoryListBox.Items.Clear();
            }
        }

        private void DeleteHistoryItemButton_Click(object sender, EventArgs e)
        {
            string selectedHistoryItem = HistoryListBox.Items[HistoryListBox.SelectedIndex].ToString();
            string selectedURLString = selectedHistoryItem.Split('(', ')')[1];
            try
            {
                HistoryManager.DeleteHistoryItem(selectedURLString);

            }
            catch
            {

            }
            PopulateHistoryListBox(); 
        }

        /**
         * populates the history listbox
         */
        protected void PopulateHistoryListBox()
        {
            var items = HistoryManager.GetAllHistoryItems();
            HistoryListBox.Items.Clear();

            foreach (var item in items)
            {
                HistoryListBox.Items.Add(string.Format("[{0}] {1} ({2})",
                    item.Date, item.Title, item.URL));
            }

        }
    }
}
