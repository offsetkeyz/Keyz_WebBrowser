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


        // TODO 26:00 in video
        private void HistoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetAllHistoryItems();
            HistoryListBox.Items.Clear(); 

            foreach(var item in items)
            {
                HistoryListBox.Items.Add(string.Format("[{0}] {1} ({2})", 
                    item.Date, item.Title, item.URL)); 
            }
        }
    }
}
