using System;
using System.Collections.Generic;
using System.IO;
using MyWebBrowserModels;

namespace MyWebBrowserDAL
{
    public class HistoryService
    {
        private FileStream fs = null;

        /// <summary>
        /// 获取历史记录
        /// </summary>
        /// <returns></returns>
        public List<History> GetHistory()
        {
            var historyList = new List<History>();
            StreamReader sr = null;
            try
            {
                fs = new FileStream(GlobalHelper.AppStartupPath + "\\history.ini", FileMode.OpenOrCreate);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    var history = new History()
                    {
                        Title = sr.ReadLine(),
                        Address = sr.ReadLine(),
                    };

                    historyList.Add(history);
                }
            }
            catch (Exception ex)
            {
                FileLog.LogError(ex);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Dispose();
                    sr.Close();
                }

                if (fs != null)
                {
                    fs.Dispose();
                    fs.Close();
                }
            }

            return historyList;
        }

        /// <summary>
        /// 保存历史记录
        /// </summary>
        /// <param name="historyList"></param>
        /// <returns></returns>
        public bool SaveHistory(List<History> historyList)
        {
            var isSave = true;
            StreamWriter sw = null;         //写入器

            try
            {
                fs = new FileStream(GlobalHelper.AppStartupPath + "\\history.ini", FileMode.Create);        // 创建文件流
                sw = new StreamWriter(fs);      // 创建读写器
                foreach (var history in historyList)
                {
                    sw.WriteLine(history.Title);
                    sw.WriteLine(history.Address);
                }
            }
            catch (Exception ex)
            {
                isSave = false;
                FileLog.LogError(ex);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Dispose();   // 释放内存
                    sw.Close();     // 关闭写入器
                }

                if (fs != null)
                {
                    fs.Dispose();  // 释放内存
                    fs.Close();    // 关闭文件流
                }
            }

            return isSave;
        }
    }
}
