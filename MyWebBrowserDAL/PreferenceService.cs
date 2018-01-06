using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using MyWebBrowserModels;

namespace MyWebBrowserDAL
{
    public class PreferenceService
    {
        private FileStream fileStream;
        private BinaryFormatter binaryFormatter;
        private string filePath = GlobalHelper.AppStartupPath + "/preference.bin";

        /// <summary>
        /// 读取首选项
        /// </summary>
        /// <returns></returns>
        public Preference GetPreference()
        {
            Preference prefer;
            try
            {
                fileStream = new FileStream(filePath,FileMode.Open);
                binaryFormatter = new BinaryFormatter();
                prefer = (Preference)binaryFormatter.Deserialize(fileStream);   // 反序列化
            }
            catch (Exception ex)
            {
                prefer = null;
                FileLog.LogError(ex);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                    fileStream.Close();
                }
            }

            return prefer;
        }

        /// <summary>
        /// 保存首选项
        /// </summary>
        /// <param name="prefer"></param>
        /// <returns></returns>
        public bool SavePreference(Preference prefer)
        {
            var isSaved = true;
            try
            {
                fileStream = new FileStream(filePath, FileMode.Create); // 创建文件流
                binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, prefer);          // 序列化
            }
            catch (Exception ex)
            {
                isSaved = false;
                FileLog.LogError(ex);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();   // 释放内存
                    fileStream.Close();     // 关闭文件流
                }
            }

            return isSaved;
        }
    }
}
