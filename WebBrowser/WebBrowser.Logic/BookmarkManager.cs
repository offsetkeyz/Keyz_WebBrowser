using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.Database1DataSetTableAdapters;

namespace WebBrowser.Logic
{
    class BookmarkManager
    {
        /**
         * Adds a Bookmark Item to the database
         */
        public static void AddHistoryItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(item.URL, item.Title);
        }
    }
}
