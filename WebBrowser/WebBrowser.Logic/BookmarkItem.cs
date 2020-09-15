using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    class BookmarkItem
    {
        public string URL { get; set; }
        public string Title { get; set; }

        /**
         * Constructor for Bookmark Item
         */
        public BookmarkItem(string URLin, string TitleIn)
        {
            this.URL = URLin;
            this.Title = TitleIn; 
        }
    }
}
