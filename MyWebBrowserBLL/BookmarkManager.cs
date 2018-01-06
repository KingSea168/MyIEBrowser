using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyWebBrowserDAL;
using MyWebBrowserModels;

namespace MyWebBrowserBLL
{
    public class BookmarkManager
    {
        private BookmarkService bookseService = new BookmarkService();

        public List<Bookmark> GetBookmarks()
        {
            return bookseService.GetBookMarks();
        }

        public bool SaveBookmark(Bookmark book)
        {
            return bookseService.SaveBookmark(book);
        }

        public bool SaveBookmarks(List<Bookmark> bookList)
        {
            return bookseService.SaveBookmarks(bookList);
        }
    }
}
