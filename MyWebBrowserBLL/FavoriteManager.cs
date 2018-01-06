using System.Collections.Generic;
using System.IO;
using MyWebBrowserDAL;
using MyWebBrowserModels;

namespace MyWebBrowserBLL
{
    public class FavoriteManager
    {
        private FavoriteService favoriteService = new FavoriteService();

        /// <summary>
        /// 添加收藏
        /// </summary>
        /// <param name="favorite"></param>
        /// <param name="savePath"></param>
        /// <returns></returns>
        public bool AddFavorite(WFavorite favorite, string savePath)
        {
            return favoriteService.AddFavorite(favorite, savePath);
        }

        /// <summary>
        /// 获取所有收藏
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<FileInfo> GetAllFavorites(string path)
        {
            return favoriteService.GetAllFavorites(path);
        }

        /// <summary>
        /// 删除指定收藏
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool DeleteFavorite(string path)
        {
            return favoriteService.DeleteFavorite(path);
        }
    }
}
