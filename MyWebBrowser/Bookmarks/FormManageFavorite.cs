using System;
using System.Windows.Forms;
using MyWebBrowserBLL;

namespace MyWebBrowser.Bookmarks
{
    public partial class FormManageFavorite : Form
    {
        private string favoritePath = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
        private FavoriteManager favoriteManager = new FavoriteManager();

        public FormManageFavorite()
        {
            InitializeComponent();
        }

        private void FormAddFavorite_Load(object sender, EventArgs e)
        {
            ScanAllFavorite(favoritePath);
        }

        private void ScanAllFavorite(string path)
        {
            var fsInfo = favoriteManager.GetAllFavorites(path);
            foreach (var info in fsInfo)
            {
                lbx_FavoriteList.Items.Add(info.ToString());
            }
        }

        /// <summary>
        /// 删除指定的收藏文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (lbx_FavoriteList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请选择要删除的书签！");
                return;
            }

            var path = favoritePath + "\\" + lbx_FavoriteList.SelectedItem;
            var type = path.Substring(path.LastIndexOf(".", StringComparison.Ordinal) + 1);
            if (type != "url")
            {
                return;
            }

            var isDelete = favoriteManager.DeleteFavorite(path);
            if (isDelete)
            {
                lbx_FavoriteList.Items.Clear();
                ScanAllFavorite(favoritePath);
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
