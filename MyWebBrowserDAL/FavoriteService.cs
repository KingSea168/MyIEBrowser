using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using IWshRuntimeLibrary;
using MyWebBrowserModels;
using File = System.IO.File;

namespace MyWebBrowserDAL
{
    public class FavoriteService
    {
        /// <summary>
        /// 添加收藏
        /// </summary>
        /// <param name="favorite"></param>
        /// <param name="savePath"></param>
        /// <returns></returns>
        public bool AddFavorite(WFavorite favorite, string savePath)
        {
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\\" + favorite.Title + ".url";
                var fileExist = File.Exists(path);
                if (!fileExist)
                {
                    IWshShell_Class shell = new IWshShell_ClassClass();
                    IWshURLShortcut shortcut;
                    if (savePath == "Favorites")
                    {
                        var pathLink = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\\" + favorite.Title + ".url";
                        shortcut = shell.CreateShortcut(pathLink) as IWshURLShortcut;

                    }
                    else
                    {
                        var pathLink = Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\\" + savePath + "\\" + favorite.Title + ".url";
                        shortcut = shell.CreateShortcut(pathLink) as IWshURLShortcut;
                    }

                    if (shortcut != null)
                    {
                        shortcut.TargetPath = favorite.Url;
                        shortcut.Save();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                FileLog.LogError(ex);
            }

            return false;
        }

        /// <summary>
        /// 获取所有收藏
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<FileInfo> GetAllFavorites(string path)
        {
            try
            {
                var dirInfo = new DirectoryInfo(path);
                var dataList = dirInfo.GetFiles().ToList();
                return dataList;
            }
            catch (Exception ex)
            {
                FileLog.LogError(ex);
            }

            return null;
        }

        /// <summary>
        /// 删除指定收藏
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool DeleteFavorite(string path)
        {
            try
            {
                var fileInfo = new FileInfo(path);
                fileInfo.Delete();
                return true;
            }
            catch (Exception ex)
            {
                FileLog.LogError(ex);
            }

            return false;
        }
    }
}
