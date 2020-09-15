using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.Data
{
    public partial class HistoryDisplayForm : Form
    {
        public HistoryDisplayForm()
        {
            InitializeComponent();
        }

        private void bookmarksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookmarksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void HistoryDisplayForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Bookmarks' table. You can move, or remove it, as needed.
            this.bookmarksTableAdapter.Fill(this.database1DataSet.Bookmarks);

        }
    }
}
