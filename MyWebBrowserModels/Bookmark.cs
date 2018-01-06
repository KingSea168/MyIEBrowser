namespace MyWebBrowserModels
{
    /// <summary>
    /// 书签实体类
    /// </summary>
    public class Bookmark
    {
        public Bookmark()
        {
        }

        public Bookmark(string title,string url)
        {
            Title = title;
            Url = url;
        }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Url { get; set; }
    }
}
