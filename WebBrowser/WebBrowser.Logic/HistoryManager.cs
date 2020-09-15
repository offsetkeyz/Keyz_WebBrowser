using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data;
using WebBrowser.Data.Database1DataSetTableAdapters; 

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        public static void AddHistoryItem(HistoryItem item)
        {
            DateTime currentDateTime = DateTime.Now;
            var adapter = new HistoryTableAdapter();
            adapter.Insert(item.URL, item.Title, item.Date); 
        }
    }
}
