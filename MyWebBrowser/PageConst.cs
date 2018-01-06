using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyWebBrowser
{
    public class PageConst
    {
        public static readonly string LOG_FILENAME = Application.StartupPath + "\\ganeral.log";
        public static readonly string ERROR_FILENAME = Application.StartupPath + "\\error.log";

        public static readonly string APP_NAME = "KINGBrowser";
        public static readonly string APP_REVION = "V1.0.0";

        public static FormMain MainForm;
    }
}
