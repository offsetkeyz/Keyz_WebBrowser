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
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        public void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            PopulateBookmarkList(); 
        }

        private void PopulateBookmarkList()
        {
            var items = BookmarkManager.GetAllBookmarkItems();
            BookmarksListBox.Items.Clear();

            foreach (var item in items)
            {
                BookmarksListBox.Items.Add(string.Format("{0} ({1})",
                    item.Title, item.URL));
            }

        }

        private void BookmarksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookmarkSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBookmarkItemButton_Click(object sender, EventArgs e)
        {
            if(BookmarksListBox.SelectedIndex >= 0)
            {
                string selectedBookmark = BookmarksListBox.Items[BookmarksListBox.SelectedIndex].ToString();
                string selectedURLstring = selectedBookmark.Split('(', ')')[1]; 
                try
                {
                    BookmarkManager.DeleteBookmark(selectedURLstring);
                } catch
                {
                    Console.WriteLine("Delete Bookmark Error");
                }
                PopulateBookmarkList(); 
            }
        }
    }
}
