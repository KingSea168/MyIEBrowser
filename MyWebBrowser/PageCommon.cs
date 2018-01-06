using System.Management;
using System.Windows.Forms;
using MyWebBrowserModels;

namespace MyWebBrowser
{
    public class PageCommon
    {
        private static int TITLT_COUNT = 10;

        /// <summary>
        /// 截取字符串为指定长度
        /// </summary>
        /// <param name="oldStr"></param>
        /// <returns></returns>
        public static string GetNewString(string oldStr)
        {
            var temp = oldStr.Length > TITLT_COUNT
                ? oldStr.Substring(0, TITLT_COUNT) + "..."
                : oldStr;

            return temp;
        }

        /// <summary>
        /// 设置本地log文件名
        /// </summary>
        public static void SetFileLogName()
        {
            FileLog.SetLogFile(PageConst.LOG_FILENAME);
            FileLog.SetErrorFile(PageConst.ERROR_FILENAME);
        }

        /// <summary>
        ///  提示框
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="messageBoxButtons"></param>
        /// <param name="nesMessageBoxIcon"></param>
        public static DialogResult ShowInforDiolag(string message, string title = "系统提示", MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK, MessageBoxIcon nesMessageBoxIcon = MessageBoxIcon.Information)
        {
            var result = MessageBox.Show(message, title, messageBoxButtons, nesMessageBoxIcon);
            return result;
        }

        /// <summary>
        /// 获取硬盘序列号
        /// </summary>
        public static string GetDiskId()
        {
            var diskId = string.Empty;
            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            foreach (var mo in searcher.Get())
            {
                diskId = mo["SerialNumber"].ToString().Trim();
                break;
            }

            return diskId;
        }
    }
}
