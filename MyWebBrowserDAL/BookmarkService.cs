using System;
using System.Collections.Generic;
using System.IO;
using MyWebBrowserModels;

namespace MyWebBrowserDAL
{
    public class BookmarkService
    {
        private FileStream fs = null;

        /// <summary>
        /// 获取书签
        /// </summary>
        /// <returns></returns>
        public List<Bookmark> GetBookMarks()
        {
            var bookList = new List<Bookmark>();
            StreamReader sr = null;
            try
            {
                fs = new FileStream(GlobalHelper.AppStartupPath + "\\bookmark.ini", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    var book = new Bookmark(sr.ReadLine(), sr.ReadLine());
                    bookList.Add(book);
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

            return bookList;
        }

        /// <summary>
        /// 保存书签
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public bool SaveBookmark(Bookmark book)
        {
            var isSave = true;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(GlobalHelper.AppStartupPath + "\\bookmark.ini", FileMode.Create);
                sw = new StreamWriter(fs);

                sw.WriteLine(book.Title);
                sw.WriteLine(book.Url);
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
                    sw.Dispose();
                    sw.Close();
                }

                if (fs != null)
                {
                    fs.Dispose();
                    fs.Close();
                }
            }

            return isSave;
        }

        /// <summary>
        /// 批量保存书签
        /// </summary>
        /// <param name="bookList"></param>
        /// <returns></returns>
        public bool SaveBookmarks(List<Bookmark> bookList)
        {
            var isSave = true;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(GlobalHelper.AppStartupPath + "\\bookmark.ini", FileMode.Create);
                sw = new StreamWriter(fs);

                foreach (var book in bookList)
                {
                    sw.WriteLine(book.Title);
                    sw.WriteLine(book.Url);
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
                    sw.Dispose();
                    sw.Close();
                }

                if (fs != null)
                {
                    fs.Dispose();
                    fs.Close();
                }
            }

            return isSave;
        }
    }
}
