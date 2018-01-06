using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MyWebBrowserBLL;
using MyWebBrowserModels;

namespace MyWebBrowser.Bookmarks
{
    public partial class FormBookmarkManage : Form
    {
        private bool isModified = false;

        public FormBookmarkManage()
        {
            InitializeComponent();
        }

        private void FormAddFavorite_Load(object sender, EventArgs e)
        {
            LoadAllBookMarks();
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (isModified)
            {
               var result =  PageCommon.ShowInforDiolag("书签内容已被修改, 确定要不保存退出吗?","提示",MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    // 保存数据
                    SaveData();
                }
            }

            this.Dispose();
            this.Close();
        }

        /// <summary>
        /// 删除书签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (lv_BookMarkList.SelectedItems.Count == 0)
            {
                PageCommon.ShowInforDiolag("请选择要删除的书签！");
                return;
            }

            lv_BookMarkList.SelectedItems[0].Remove();
            isModified = true;
        }

        /// <summary>
        /// 修改书签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_title.Text))
            {
                PageCommon.ShowInforDiolag("请输入标题！");
                return;
            }

            if (string.IsNullOrEmpty(tbx_addr.Text))
            {
                PageCommon.ShowInforDiolag("请输入地址！");
                return;
            }

            lv_BookMarkList.SelectedItems[0].SubItems[0].Text = tbx_title.Text.Trim() ; // 标题
            lv_BookMarkList.SelectedItems[0].SubItems[1].Text = tbx_addr.Text.Trim() ; // 地址

            isModified = true;
        }

        /// <summary>
        /// 添加书签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            var book = new Bookmark()
            {
                Title = "",
                Url = ""
            };

            var addBook = new FormAddBookmark(book, true);
            addBook.ShowDialog();

            LoadAllBookMarks();
        }

        /// <summary>
        /// 加载书签
        /// </summary>
        private void LoadAllBookMarks()
        {
            lv_BookMarkList.Items.Clear();
            var bookList = GlobalHelper.BookmarksList;
            foreach (var book in bookList)
            {
                var data = new string[] { book.Title, book.Url };
                var lvi = new ListViewItem(data);
                lv_BookMarkList.Items.Add(lvi);
            }
        }

        /// <summary>
        /// 点击listview的项
        /// </summary>
        /// <param name="sender"></param>   
        /// <param name="e"></param>
        private void lv_BookMarkList_Click(object sender, EventArgs e)
        {
            tbx_title.Text = lv_BookMarkList.SelectedItems[0].SubItems[0].Text; // 标题
            tbx_addr.Text = lv_BookMarkList.SelectedItems[0].SubItems[1].Text; // 地址
        }

        private void SaveData()
        {
            var bookList = new List<Bookmark>();
            for (var i = 0; i < lv_BookMarkList.Items.Count; i++)
            {
                var book = new Bookmark(lv_BookMarkList.Items[i].SubItems[0].Text,
                    lv_BookMarkList.Items[i].SubItems[1].Text);
                bookList.Add(book);
            }

            GlobalHelper.BookmarksList = bookList;

            if (PageConst.MainForm != null)
            {
                PageConst.MainForm.UpdateBookmarks();
            }
        }

        private void FormBookmarkManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (isModified)
            //{
            //    var result = PageCommon.ShowInforDiolag("书签内容已被修改, 确定要不保存退出吗?", "提示", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.No)
            //    {
            //        // 保存数据
            //        SaveData();
            //    }
            //}
        }
    }
}
