using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWebBrowserModels
{
    /// <summary>
    /// 首选项
    /// </summary>
    [Serializable]
    public class Preference
    {
        public Preference(){}

        public Preference(string startId,string startUrl,string homeUrl,string searchUrl,string showMenu,string showNavigate,
                            string showStatus,string showSearch,string showHomebtn,string useShortcut,string themeId)
        {
            DefaultStartId = startId;
            StartUrl = startUrl;
            HomeUrl = homeUrl;
            SearchUrl = searchUrl;
            ShowMenuBar = showMenu;
            ShowNavigateBar = showNavigate;
            ShowStatusBar = showStatus;
            ShowSearchBar = showSearch;
            ShowHomeBtn = showHomebtn;
            UseShortcut = useShortcut;
            ThemeId = themeId;
        }

        /// <summary>
        /// 启动项ID
        /// </summary>
        public string DefaultStartId { get; set; }

        /// <summary>
        /// 启动url
        /// </summary>
        public string StartUrl { get; set; }

        /// <summary>
        /// 主页url
        /// </summary>
        public string HomeUrl { get; set; }

        /// <summary>
        /// 搜索页url
        /// </summary>
        public string SearchUrl { get; set; }

        /// <summary>
        /// 是否显示菜单栏
        /// </summary>
        public string ShowMenuBar { get; set; }

        /// <summary>
        /// 是否显示导航栏
        /// </summary>
        public string ShowNavigateBar { get; set; }

        /// <summary>
        /// 是否显示状态栏
        /// </summary>
        public string ShowStatusBar { get; set; }

        /// <summary>
        /// 是否显示搜索栏
        /// </summary>
        public string ShowSearchBar { get; set; }

        /// <summary>
        /// 是否显示主页按钮
        /// </summary>
        public string ShowHomeBtn { get; set; }

        /// <summary>
        /// 是否使用快捷键
        /// </summary>
        public string UseShortcut { get; set; }

        /// <summary>
        /// 主题ID
        /// </summary>
        public string ThemeId { get; set; }

        ///// <summary>
        ///// 是否删除Cookie
        ///// </summary>
        //public string DeleteCookie { get; set; }

        ///// <summary>
        ///// 是否删除Cookie
        ///// </summary>
        //public string DeleteHistory { get; set; }

        ///// <summary>
        ///// 是否删除Cookie
        ///// </summary>
        //public string DeleteInputRecord { get; set; }
    }
}
