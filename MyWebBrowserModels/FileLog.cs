using System;
using System.IO;
using System.Text;

namespace MyWebBrowserModels
{
    public static class FileLog
    {
        private static string LogFileName = string.Empty;
        private static string ErrorFileName = string.Empty;

        #region 初始化Log文件名

        public static void SetLogFile(string fileName)
        {
            LogFileName = fileName;
        }

        public static void SetErrorFile(string fileName)
        {
            ErrorFileName = fileName;
        }

        #endregion

        public static void Log(string str)
        {
            WriteFile(LogFileName, str);
        }

        public static void LogError(string errorDescription)
        {
            WriteFile(ErrorFileName, string.Format("Source={0}\r\nDescription={1}\r\n", DateTime.Now, errorDescription));
        }

        public static void LogError(Exception ex)
        {
            WriteFile(ErrorFileName, string.Format("Source={0}\r\nDescription={1}\r\nData={2}\r\n", ex.Source, ex.Message, ex.Data));
        }

        #region 本地文件操作方法

        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="content"></param>
        public static void WriteFile(string filePath, string content)
        {
            var str = DateTime.Now +"\r\n"+ content;
            var fs = new FileStream(filePath, FileMode.Append);
            var sw = new StreamWriter(fs, Encoding.Default);
            sw.Flush();
            sw.WriteLine(str);

            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// 写临时文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="content"></param>
        public static void WriteTempFile(string filePath, string content)
        {
            var fs = new FileStream(filePath, FileMode.Create);
            var sw = new StreamWriter(fs, Encoding.Default);
            sw.Flush();
            sw.WriteLine(content);

            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// 读取文件
        /// 把文件加载到内存中
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string ReadFile(string filePath)
        {
            byte[] buffer;
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                var length = (int)fileStream.Length;    // get file length
                buffer = new byte[length];              
                int count;                              // actual number of bytes read
                var sum = 0;                            // total number of bytes read
                while ((count = fileStream.Read(buffer, sum, length - sum)) > 0)
                {
                    sum += count;                       // sum is a buffer offset for next reading
                }
            }
            catch (Exception ex)
            {
                buffer = new byte[] { };
                LogError(ex);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }

            string content = string.Empty;
            foreach (var b in buffer)
            {
                content += Convert.ToChar(b);
            }

            return content;
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="filePath"></param>
        public static void DeleteFile(string filePath)
        {
            File.Delete(filePath);
        }

        #endregion
    }
}
