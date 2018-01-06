using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWebBrowserModels
{
    public class GlobalHelper
    {
        public static string AppStartupPath;

        public static bool IsCleanHistory = false;
        public static bool IsCleanInputRecord = false;

        public static List<Bookmark> BookmarksList = new List<Bookmark>(); 
    }
}
