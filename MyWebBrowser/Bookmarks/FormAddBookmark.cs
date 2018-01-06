using System;
using System.Windows.Forms;
using MyWebBrowserBLL;
using MyWebBrowserModels;

namespace MyWebBrowser.Bookmarks
{
    public partial class FormAddBookmark : Form
    {
        private Bookmark curBook;

        public FormAddBookmark(Bookmark book, bool isManager = false)
        {
            InitializeComponent();

            curBook = book;
            if (!isManager)
            {
                StartPosition = FormStartPosition.Manual;
                Top = 50;
                Left = 180;
            }
            else
            {
                StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void FormAddFavorite_Load(object sender, EventArgs e)
        {
            tb_title.Text = curBook.Title;
            tbx_url.Text = curBook.Url;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }

            //var favorite = new WFavorite()
            //{
            //    Title = tb_title.Text,
            //    Url = tbx_url.Text
            //};

            var book = new Bookmark()
            {
                Title = tb_title.Text,
                Url = tbx_url.Text
            };

            //var isAdd = new FavoriteManager().AddFavorite(favorite, "Favorites");
            //var result = isAdd
            //    ? MessageBox.Show("添加书签成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            //    : MessageBox.Show("添加书签失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //if (result == DialogResult.OK)
            //{
            //    Close();
            //}

            //var isAdd = new FavoriteManager().AddFavorite(favorite, "Favorites");

            //var isAdd = new BookmarkManager().SaveBookMark(book);
            //if (isAdd)
            //{
            //    PageCommon.ShowInforDiolag("添加书签成功！");
            //    if (PageConst.MainForm != null)
            //    {
            //        PageConst.MainForm.AddBookmarkItem(book.Title, book.Url);
            //    }

            //    Close();
            //}
            //else
            //{
            //    lbl_Tips.Text = "添加书签失败！";
            //}

            GlobalHelper.BookmarksList.Add(book);
            PageConst.MainForm.AddBookmarkItem(book.Title,book.Url);
            PageCommon.ShowInforDiolag("添加书签成功！");

            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckInput()
        {
            if (tb_title.Text == "")
            {
                PageCommon.ShowInforDiolag("请输入标题!");
                return false;
            }

            if (tbx_url.Text == "")
            {
                PageCommon.ShowInforDiolag("请输入地址!");
                return false;
            }

            return true;
        }
    }
}
