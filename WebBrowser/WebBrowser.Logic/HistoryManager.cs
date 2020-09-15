using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        public static void AddHistoryItem(string URL, string Title)
        {
            DateTime currentDateTime = DateTime.Now;
            HistoryItem newItem = new HistoryItem(URL, Title, currentDateTime); 
        }
    }
}
