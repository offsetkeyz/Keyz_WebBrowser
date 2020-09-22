using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data;
using WebBrowser.Data.BrowserDatasetTableAdapters; 

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        /**
         * Adds a HistoryItem to the database
         */
        public static void AddHistoryItem(HistoryItem item)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(item.URL, item.Title, item.Date); 
        }

        /**
         * Gets all History Items in the database.
         * @return a list of all history items
         */
        public static List<HistoryItem> GetAllHistoryItems()
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem(row.URL, row.Title, row.Date);

                results.Add(item);
            }
            return results;
        }

    }
}
