using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        /**
         * Adds a Bookmark Item to the database
         */
        public static void AddBookmarkItem(BookmarkItem item)
        {
/*            adapter.Insert(item.URL, item.Title);
*/        }

        /**
         * Gets all Bookmark Items in the database.
         * @return a list of all bookmark items
         */
        public static List<BookmarkItem> GetAllBookmarkItems()
        {
            var results = new List<BookmarkItem>();
/*            var rows = adapter.GetData();
*/
            foreach (var row in rows)
            {
                var item = new BookmarkItem(row.URL, row.Title);

                results.Add(item);
            }
            return results;
        }
    }
}
