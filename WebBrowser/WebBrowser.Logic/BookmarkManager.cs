using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.BrowserDatasetTableAdapters; 

namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        /**
         * Adds a Bookmark Item to the database
         */
        public static void AddBookmarkItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter(); 
            adapter.Insert(item.URL, item.Title);
        }

        /**
         * Gets all Bookmark Items in the database.
         * @return a list of all bookmark items
         */
        public static List<BookmarkItem> GetAllBookmarkItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.Id = row.Id; 
                item.URL = row.URL;
                item.Title = row.Title; 

                results.Add(item);
            }

            return results;
        }

        public static void DeleteBookmark(string URLin)
        {
            var adapter = new BookmarksTableAdapter();
            var rows = adapter.GetData(); 
            foreach(var row in rows)
            {
                if(row.URL.Equals(URLin))
                {
                    adapter.Delete(row.Id, row.URL, row.Title);
                    break;
                }
            }
        }
    }
}
