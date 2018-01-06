using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MyWebBrowser.Bookmarks;
using MyWebBrowser.Mails;
using MyWebBrowser.Properties;
using MyWebBrowserBLL;
using MyWebBrowserModels;
using Sunisoft.IrisSkin;

namespace MyWebBrowser
{
    public partial class FormMain : Form
    {
        private string defaultUrl = "about:blank";

        private string startUrl = "https://www.baidu.com/";
        private string homeUrl = "https://www.baidu.com/";
        private string searchUrl = "http://www.google.cn";

        private double currSizeScale;

        private bool isUseShortcut = true;
        private string currThemeName;

        private HistoryManager historyManager = new HistoryManager();
        private BookmarkManager bookManager = new BookmarkManager();

        public FormMain()
        {
            InitializeComponent();

            GlobalHelper.AppStartupPath = Application.StartupPath;

            // 读取配置项信息
            GetPreference();

            // 读取历史记录信息
            GetHistory();

            // 读取书签信息
            GetBookmarks();

            if (currThemeName != "default")
            {
                var se = new SkinEngine
                {
                    SkinAllForm = true,                             // 所有窗体都使用主题风格
                    SkinFile = @"skin/" + currThemeName + ".ssk"    // 使用的主题风格
                };
            }
        }

        /// <summary>
        /// 窗体加载时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            PageConst.MainForm = this;
            InitBrowser();

            tscb_Url.AutoCompleteMode = AutoCompleteMode.SuggestAppend;   // 自动补全网址
            tscb_Url.AutoCompleteSource = AutoCompleteSource.ListItems;   // 自动补全网址文件源
        }

        /// <summary>
        /// 窗体调整大小时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Resize(object sender, EventArgs e)
        {
            ResizeWindow();
        }

        /// <summary>
        /// 窗体关闭时事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveHistory();

            SaveBookmark();

            //this.Dispose();
            //Application.Exit();
        }

        #region 网页事件

        /// <summary>
        /// 当浏览器控制进度条发生变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="webBrowserProgressChangedEventArgs"></param>
        private void MyBrowserOnProgressChanged(object sender, WebBrowserProgressChangedEventArgs webBrowserProgressChangedEventArgs)
        {
            tspb_Progress.Visible = true;

            // 读取下载的最大容量
            tspb_Progress.Maximum = (int)webBrowserProgressChangedEventArgs.MaximumProgress;

            // 读取当前下载的容量
            var currProgress = (int)webBrowserProgressChangedEventArgs.CurrentProgress;
            if (currProgress < 0)
            {
                currProgress = 0;
            }
            tspb_Progress.Value = currProgress;

            tspb_Progress.Visible = false;
            SetStatusBtn();
        }

        /// <summary>
        /// 当浏览器状态发生变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void MyBrowserOnStatusTextChanged(object sender, EventArgs eventArgs)
        {
            var browser = (WebBrowser)sender;
            if (!browser.Equals(GetCurrentBrowser()))
            {
                return;
            }

            tssl_Status.Text = browser.StatusText;
        }

        /// <summary>
        /// 当浏览器产生新窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cancelEventArgs"></param>
        private void MyBrowserOnNewWindow(object sender, CancelEventArgs cancelEventArgs)
        {
            var browser = (WebBrowser)sender;
            if (browser == null)
            {
                return;
            }

            if (isUseShortcut)
            {
                this.tc_PageShow.KeyDown += new KeyEventHandler(tab_KeyDown); // 当前标签页中的按钮事件
            }

            // 通过StatusText属性获得新的url
            var newUrl = browser.StatusText;

            NewPage(newUrl);

            cancelEventArgs.Cancel = true; // 在新标签页打开新连接
        }

        /// <summary>
        /// 当浏览器定向完毕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="webBrowserNavigatedEventArgs"></param>
        private void MyBrowserOnNavigated(object sender, WebBrowserNavigatedEventArgs webBrowserNavigatedEventArgs)
        {
            SetStatusBtn();
        }

        private void MyBrowserOnDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs webBrowserDocumentCompletedEventArgs)
        {
            var browser = (WebBrowser)sender;
            var page = (TabPage)browser.Parent;

            if (Math.Abs(currSizeScale - 1.0) > 0)
            {
                if (browser.Document != null)
                {
                    if (browser.Document.Body != null)
                    {
                        browser.Document.Body.Style = "zoom:" + currSizeScale;
                    }
                }
            }

            // 设置浏览器所在tab标题
            SetTabTitle(browser, page);

            // 添加历史记录
            AddHistory();
        }

        #endregion

        #region 常用方法

        private void InitBrowser()
        {
            btn_ExitFullScreen.Visible = false;
            tsb_NewShow.Visible = false;
            NewPage(startUrl);
        }

        /// <summary>
        /// 获取配置项
        /// </summary>
        private void GetPreference()
        {
            var prefer = new PreferenceManager().GetPreference();
            if (prefer == null)
            {
                return;
            }

            homeUrl = prefer.HomeUrl;
            searchUrl = prefer.SearchUrl;

            SetMenuBarVisible(Convert.ToBoolean(prefer.ShowMenuBar));
            SetNavigateBarVisible(Convert.ToBoolean(prefer.ShowNavigateBar));
            SetStatusBarVisible(Convert.ToBoolean(prefer.ShowStatusBar));
            SetSearchBarVisible(Convert.ToBoolean(prefer.ShowSearchBar));
            SetHomeBtnVisible(Convert.ToBoolean(prefer.ShowHomeBtn));

            isUseShortcut = Convert.ToBoolean(prefer.UseShortcut);

            switch (prefer.DefaultStartId)
            {
                case "0":
                    startUrl = homeUrl;
                    break;

                case "1":
                    startUrl = defaultUrl;
                    break;

                case "2":
                    startUrl = prefer.StartUrl;
                    break;

                default:
                    startUrl = defaultUrl;
                    break;
            }

            switch (prefer.ThemeId)
            {
                case "1":
                    currThemeName = "Calmness";
                    break;
                case "2":
                    currThemeName = "Midsummer";
                    break;
                case "3":
                    currThemeName = "Msn";
                    break;
                case "4":
                    currThemeName = "Page";
                    break;
                case "5":
                    currThemeName = "Steelblack";
                    break;
                default:
                    currThemeName = "default";
                    break;
            }
        }

        /// <summary>
        /// have problem need to modify
        /// </summary>
        private void ResizeWindow()
        {
            if (WindowState != FormWindowState.Maximized)
            {
                //if (tsl_SearchLogo.Visible)
                //{
                //    SetSearchBarVisible(false);
                //}

                if (Width >= 800)
                {
                    tscb_Url.Width = 300;
                }
                else
                {
                    tscb_Url.Width = Width - 400;
                }
            }
            else
            {
                //if (!tsl_SearchLogo.Visible)
                //{
                //    SetSearchBarVisible(true);
                //}

                tscb_Url.Width = 300;
            }
        }

        /// <summary>
        /// 获取当前浏览器
        /// </summary>
        /// <returns></returns>
        private WebBrowser GetCurrentBrowser()
        {
            var currBrowser = (WebBrowser)tc_PageShow.SelectedTab.Controls[0];
            return currBrowser;

        }

        /// <summary>
        /// 在当前页面上重新定向，即根据网址刷新网页
        /// </summary>
        /// <param name="address">字符串</param>
        private void NewPageUrl(string address)
        {
            var url = GetUrl(address);
            GetCurrentBrowser().Navigate(url);
        }

        /// <summary>
        /// 打开网址
        /// </summary>
        /// <param name="url">完整网址</param>
        private void NewUrl(string url)
        {
            GetCurrentBrowser().Navigate(url);
        }

        /// <summary>
        /// 打开空白页
        /// </summary>
        private void NewEmptyPage()
        {
            NewPage(defaultUrl);
            tc_PageShow.SelectedTab = tc_PageShow.TabPages[tc_PageShow.TabPages.Count - 1];
        }

        /// <summary>
        /// 创建新的一页
        /// </summary>
        /// <param name="url"></param>
        private void NewPage(string url)
        {
            var myPage = new TabPage();
            var myBrowser = new WebBrowser();

            if (isUseShortcut)
            {
                this.tc_PageShow.KeyDown += new KeyEventHandler(tab_KeyDown); // 当前标签页中的按钮事件
            }

            myBrowser.Navigated += MyBrowserOnNavigated;
            myBrowser.NewWindow += MyBrowserOnNewWindow;
            myBrowser.StatusTextChanged += MyBrowserOnStatusTextChanged;
            myBrowser.ProgressChanged += MyBrowserOnProgressChanged;
            myBrowser.DocumentCompleted += MyBrowserOnDocumentCompleted;
            myBrowser.Dock = DockStyle.Fill;
            //if (url.Equals(""))
            //{
            //    myBrowser.GoHome();             //和新建空白页不同
            //}
            //else
            //{
            //    myBrowser.Navigate(url);
            //}
            myBrowser.Navigate(url);
            myPage.Controls.Add(myBrowser);
            tc_PageShow.TabPages.Add(myPage);
            //tabControl1.TabPages[tabControl1.TabPages.Count -1].Controls.Add(myBrowser);
            tc_PageShow.SelectedIndex = tc_PageShow.TabPages.Count - 1; // 选中新建标签页
        }

        /// <summary>
        /// 根据字符串获取Uri
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        private Uri GetUrl(string address)
        {
            string tempAddress = address;
            if ((!address.StartsWith("http://")) && (!address.StartsWith("https://")) && (!address.StartsWith("ftp://")))
            {
                tempAddress = "http://" + address;
            }

            Uri myUri;
            try
            {
                myUri = new Uri(tempAddress);
            }
            catch (Exception)
            {
                myUri = new Uri(defaultUrl);
            }

            return myUri;
        }

        /// <summary>
        /// 设置浏览器所在tab标题
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="page"></param>
        private void SetTabTitle(WebBrowser browser, TabPage page)
        {
            //var title = PageCommon.GetNewString(browser.DocumentTitle);
            //var isDefault = browser.Url.AbsoluteUri.Contains(defaultUrl);
            //page.Text = title.Equals("") ? (isDefault ? "空白页" : "无法访问") : title;

            var url = browser.Url.ToString();
            if (browser.Document != null)
            {
                var title = browser.Document.Title;
                if (url.Equals(defaultUrl))
                {
                    title = "空标签页";
                    tscb_Url.Text = "请输入网址";
                    tscb_Url.ForeColor = Color.Blue;
                }
                else
                {
                    if (string.IsNullOrEmpty(title))
                    {
                        title = "无标题文档";
                    }
                    else if (title.Equals("Internet Explorer 无法显示该网页") || title.Equals("找不到服务器"))
                    {
                        title = "无法显示网页";
                    }
                    else if (title.Length > 10)
                    {
                        title = PageCommon.GetNewString(title);
                    }

                    tscb_Url.Text = url;
                    tscb_Url.ForeColor = Color.Black;

                }

                SetStatusBtn();
                page.Text = title;
                page.Select();
            }
        }

        /// <summary>
        /// 关闭当前页面
        /// </summary>
        private void ClosePage()
        {
            if (tc_PageShow.TabPages.Count <= 1)
            {
                if (tc_PageShow.SelectedTab.Text.Equals("空标签页"))
                {
                    return;
                }

                NewUrl(defaultUrl);
            }
            else
            {
                //先将tabControl1隐藏然后remove掉目标tab
                //如果不隐藏则出现闪烁，即系统自动跳转到tabControl1的第一个tab然后跳回。）
                //最后显示tabControl1。
                tc_PageShow.Visible = false;
                var browser = GetCurrentBrowser();

                // 释放资源
                browser.Dispose();
                browser.Controls.Clear();
                tc_PageShow.TabPages.Remove(tc_PageShow.SelectedTab);

                // 重新设置当前tab
                tc_PageShow.SelectedTab = tc_PageShow.TabPages[tc_PageShow.TabPages.Count - 1];
                tc_PageShow.Visible = true;
            }
        }

        /// <summary>
        /// 关闭所有页面
        /// </summary>
        private void CloseAllPage()
        {
            if (tc_PageShow.TabCount == 1 && tc_PageShow.SelectedTab.Text.Equals("空标签页"))
            {
                return;
            }

            try
            {
                for (var i = tc_PageShow.TabPages.Count - 1; i >= 0; i--)
                {
                    tc_PageShow.SelectedTab = tc_PageShow.TabPages[i];

                    ClosePage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetHomePage()
        {
            //1.
            //GetCurrentBrowser().GoHome();

            //2.
            //var currUrl = GetCurrentBrowser().Url.ToString();
            //if (!currUrl.Equals(defaultUrl) && !currUrl.Equals(homeUrl))
            //{
            //    NewEmptyPage();
            //}

            //NewUrl(homeUrl);

            //3.
            NewUrl(homeUrl);
        }

        #endregion

        #region 工具栏

        /// <summary>
        /// 后退按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Goback_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser().GoBack();
            SetStatusBtn();
        }

        /// <summary>
        /// 前进按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Foreword_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser().GoForward();
            SetStatusBtn();
        }

        /// <summary>
        /// 停止按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Stop_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser().Stop();
        }

        /// <summary>
        /// 刷新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Refresh_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser().Refresh();
        }

        /// <summary>
        /// 主页按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Home_Click(object sender, EventArgs e)
        {
            SetHomePage();
        }

        /// <summary>
        /// 搜索按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Search_Click(object sender, EventArgs e)
        {
            //GetCurrentBrowser().GoSearch();
            Search();
        }

        /// <summary>
        /// 打印按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Print_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser().ShowPrintDialog();
        }

        /// <summary>
        /// 新建按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_NewPage_Click(object sender, EventArgs e)
        {
            NewEmptyPage();
        }

        /// <summary>
        /// 转到按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Go_Click(object sender, EventArgs e)
        {
            if (tscb_Url.Text.Equals("请输入网址"))
            {
                return;
            }

            NewPageUrl(tscb_Url.Text);
        }

        /// <summary>
        /// 当在地址栏输入网址后，按回车键打开网址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tscb_Url_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NewPageUrl(tscb_Url.Text);
            }
        }

        private void tscb_Url_MouseEnter(object sender, EventArgs e)
        {
            if (tscb_Url.Text.Equals("请输入网址"))
            {
                tscb_Url.Text = "";
            }

            tscb_Url.ForeColor = Color.Black;
        }

        private void tscb_Url_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tscb_Url.Text))
            {
                if (GetCurrentBrowser().Url == null)
                {
                    return;
                }

                if (GetCurrentBrowser().Url.ToString() != defaultUrl)
                {
                    tscb_Url.Text = GetCurrentBrowser().Url.ToString();
                    tscb_Url.ForeColor = Color.Black;
                }
                else
                {
                    tscb_Url.Text = "请输入网址";
                    tscb_Url.ForeColor = Color.Blue;
                }
            }
        }

        /// <summary>
        /// 设置前进、后退按钮是否可点击
        /// </summary>
        private void SetStatusBtn()
        {
            tsb_Goback.Enabled = 后退BToolStripMenuItem.Enabled = GetCurrentBrowser().CanGoBack;
            tsb_Foreword.Enabled = 前进FToolStripMenuItem.Enabled = GetCurrentBrowser().CanGoForward;
        }

        private void tsb_NewShow_Click(object sender, EventArgs e)
        {

        }

        private void tsb_ClosePage_Click(object sender, EventArgs e)
        {
            ClosePage();
        }

        private void tsb_CloseAllPage_Click(object sender, EventArgs e)
        {
            CloseAllPage();
        }

        private void tsb_AddBookmark_Click(object sender, EventArgs e)
        {
            AddBookmark();
        }

        #endregion

        #region 菜单栏

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEmptyPage();
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.openFile.ShowDialog(); // 打开选择文件窗体
            //var nowUrl = this.openFile.FileName; // 选中的文件地址
            //this.openFile.Dispose();
            //if (!this.tabControl1.SelectedTab.Text.Equals("空标签页"))
            //{
            //    NewEmptyPage();
            //}

            //NewUrl(nowUrl);

            var openFileDialog = new OpenFileDialog
            {
                DefaultExt = "html",
                Filter = "全部文件 |"
            };
            openFileDialog.ShowDialog(); // 打开选择文件窗体
            var nowUrl = openFileDialog.FileName; // 选中的文件地址
            openFileDialog.Dispose();

            if (!this.tc_PageShow.SelectedTab.Text.Equals("空标签页"))
            {
                NewEmptyPage();
            }

            NewUrl(nowUrl);

        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser().ShowSaveAsDialog();
        }

        private void 页面设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser().ShowPageSetupDialog();
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser().ShowPrintDialog();
        }

        private void 打印预览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser().ShowPrintPreviewDialog();
        }

        private void 属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser().ShowPropertiesDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void 停止ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser().Stop();
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser().Refresh();
        }

        private void 源文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currUrl = tscb_Url.Text.Trim();
            if (currUrl != defaultUrl)
            {
                var frmSource = new FormSource(currUrl);
                frmSource.ShowDialog();
            }
        }

        private void 菜单栏MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetMenuBarVisible(!ms_Menu.Visible);
        }

        private void 导航栏IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetNavigateBarVisible(!ts_ToolBar.Visible);
        }

        private void 状态栏SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStatusBarVisible(!ss_ButtomBar.Visible);
        }

        private void 搜索栏GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSearchBarVisible(!tstb_Search.Visible);
        }

        private void 主页按钮HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetHomeBtnVisible(!tsb_Home.Visible);
        }

        private void 添加书签AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookmark();
        }

        private void 书签管理OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manager = new FormBookmarkManage();
            manager.ShowDialog();
        }

        private void 后退BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser().GoBack();
            SetStatusBtn();
        }

        private void 前进FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetCurrentBrowser().GoForward();
            SetStatusBtn();
        }

        private void 主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetHomePage();
        }

        private void 搜索SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!tc_PageShow.SelectedTab.Text.Equals("空标签页"))
            {
                NewEmptyPage();
            }

            NewUrl(searchUrl);
        }

        private void 新闻订阅RToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 邮件收发MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mail = new FormMail();
            mail.ShowDialog();
        }

        private void 首选项OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var preference = new FormPreference(this);
            preference.ShowDialog();
        }

        private void 帮助F1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PageCommon.ShowInforDiolag("Welcome to use KINGBrowser.\r\n It's so easy to use,so no help for u.^_^");

            try
            {
                var helpUrl = GlobalHelper.AppStartupPath + "\\help.html";
                if (!tc_PageShow.SelectedTab.Text.Equals("空标签页"))
                {
                    NewEmptyPage();
                }

                NewUrl(helpUrl);
            }
            catch (Exception ex)
            {
                FileLog.LogError(ex);
                PageCommon.ShowInforDiolag("未找到帮助页面！");
            }

        }

        private void 程序更新UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageCommon.ShowInforDiolag("你目前使用的版本是: " + PageConst.APP_REVION + "\r\n Update func is coming.");
        }

        private void 检查连接LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageCommon.ShowInforDiolag(IsConnected2Internect() ? "网络已连接." : "网络未连接.");
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageCommon.ShowInforDiolag("Welcome to use KINGBrowser.\r\n\r\n                   --Power by KING.");
        }

        #endregion

        #region 选项卡事件

        /// <summary>
        /// 切换不同的tab时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var browser = GetCurrentBrowser();
            var page = (TabPage)browser.Parent;
            if (browser.Url != null)
            {
                tscb_Url.Text = browser.Url.ToString();
                SetTabTitle(browser, page);
            }
            else
            {
                tscb_Url.Text = defaultUrl;
                page.Text = "空白页";
            }

            SetStatusBtn();
        }

        /// <summary>
        /// 关闭指定tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            ClosePage();
        }

        /// <summary>
        /// 快捷键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // 全屏
                if (e.KeyCode == Keys.F11)
                {
                    if (this.FormBorderStyle == FormBorderStyle.None)
                    {
                        ExitFullScreen();
                        return;
                    }
                    else
                    {
                        SetFullScreen();
                        return;
                    }
                }

                // 帮助
                if (e.Alt && e.KeyCode == Keys.F1)
                {
                    帮助F1ToolStripMenuItem_Click(null,null);
                    return;
                }
            }
            catch (Exception ex)
            {
                FileLog.LogError(ex);
            }
        }

        #endregion

        #region 历史记录

        private void AddHistory()
        {
            var htmlDocument = GetCurrentBrowser().Document;
            if (htmlDocument != null)
            {
                var title = htmlDocument.Title;
                var url = GetCurrentBrowser().Url.ToString();
                if (url.ToLower() == defaultUrl || title.Equals("空标签页"))
                {
                    return;
                }

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(url))
                {
                    return;
                }

                var isExist = CheckIsExistHistory();
                if (历史ToolStripMenuItem.DropDownItems.Count >= 10 && !isExist)
                {
                    历史ToolStripMenuItem.DropDownItems.RemoveAt(9);
                }

                AddHistoryItem(title, url);
            }

        }

        private void AddHistoryItem(string title, string url, bool isNew = true)
        {
            var history = new ToolStripMenuItem()
            {
                Text = title,
                Tag = url,
                BackColor = Color.Transparent,
                BackgroundImage = Resources.dialog_back,
            };

            history.Click += HistoryOnClick;

            if (isNew)
            {
                历史ToolStripMenuItem.DropDownItems.Insert(0, history);
            }
            else
            {
                历史ToolStripMenuItem.DropDownItems.Add(history);
            }

        }

        private void HistoryOnClick(object sender, EventArgs eventArgs)
        {
            try
            {
                var nowUrl = ((ToolStripMenuItem)sender).Tag.ToString();
                if (!this.tc_PageShow.SelectedTab.Text.Equals("空标签页"))
                {
                    NewEmptyPage();
                }

                NewUrl(nowUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// 检测当前地址是否已经存在于历史记录中
        /// </summary>
        /// <returns></returns>
        private bool CheckIsExistHistory()
        {
            var url = GetCurrentBrowser().Url.ToString();
            for (int i = 0; i < 历史ToolStripMenuItem.DropDownItems.Count; i++)
            {
                if (历史ToolStripMenuItem.DropDownItems[i].Tag.ToString() == url)
                {
                    历史ToolStripMenuItem.DropDownItems.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 保存历史记录
        /// </summary>
        private void SaveHistory()
        {
            var dataList = (from ToolStripMenuItem dropDownItem in 历史ToolStripMenuItem.DropDownItems
                            select new History()
                            {
                                Title = dropDownItem.Text,
                                Address = dropDownItem.Tag.ToString(),
                            }).ToList();

            historyManager.SaveHistory(dataList);
        }

        /// <summary>
        /// 获取历史记录
        /// </summary>
        private void GetHistory()
        {
            var dataList = historyManager.GetHistory();
            foreach (var history in dataList)
            {
                AddHistoryItem(history.Title, history.Address, false);
            }
        }

        #endregion

        #region 全屏
        private void 全屏AltF11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFullScreen();
        }

        //private const int SW_HIDE = 0;      //隐藏任务栏
        //private const int SW_RESTORE = 9;   //显示任务栏

        //[DllImport("user32.dll")]
        //public static extern int ShowWindow(int hwnd, int nCmdShow);

        //[DllImport("user32.dll")]
        //public static extern int FindWindow(string IpClassName, string IpWindowName);

        ////ShowWindow(FindWindow("Shell_TrayWnd", null), SW_HIDE);
        ////ShowWindow(FindWindow("Shell_TrayWnd", null), SW_RESTORE);

        /// <summary>
        /// 设置全屏
        /// </summary>
        private void SetFullScreen()
        {
            SetVisibleCore(false);
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            btn_ExitFullScreen.Visible = true;
            SetAllVisible(false);
            SetVisibleCore(true);
        }

        /// <summary>
        /// 退出全屏
        /// </summary>
        private void ExitFullScreen()
        {
            SetVisibleCore(false);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            btn_ExitFullScreen.Visible = false;
            SetAllVisible(true);
            SetVisibleCore(true);
        }

        private void btn_ExitFullScreen_Click(object sender, EventArgs e)
        {
            ExitFullScreen();
        }

        #endregion

        #region 搜索
        private void Search()
        {
            var url = defaultUrl;
            if (string.IsNullOrEmpty(tstb_Search.Text) || tstb_Search.Text.Equals("Google(谷歌)搜索"))
            {
                url = "http://www.google.cn";
            }
            else
            {
                url =
                    string.Format(
                        "http://www.google.cn/search?hl=zh-CN&rlz=1C1_____enCN355&newwindow=1&q={0}&btnG=Google+%E6%90%9C%E7%B4%A2&aq=f&oq=",
                        tstb_Search.Text);
            }

            if (!tc_PageShow.SelectedTab.Text.Equals("空标签页"))
            {
                NewEmptyPage();
            }

            NewUrl(url);
            tstb_Search.Text = "Google(谷歌)搜索";
        }

        private void tstb_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void tstb_Search_MouseEnter(object sender, EventArgs e)
        {
            tstb_Search.Clear();
        }

        private void tstb_Search_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tstb_Search.Text))
            {
                tstb_Search.Text = "Google(谷歌)搜索";
            }
        }
        #endregion

        #region 书签

        private void AddBookmark()
        {
            if (tscb_Url.Text.Trim() == defaultUrl || tscb_Url.Text.Trim().Equals("")
                || (!tscb_Url.Text.Trim().StartsWith("http://") && !tscb_Url.Text.Trim().StartsWith("https://")))
            {
                return;
            }

            var book = new Bookmark()
            {
                Title = GetCurrentBrowser().DocumentTitle,
                Url = tscb_Url.Text.Trim()
            };

            var mewfavorite = new FormAddBookmark(book);
            mewfavorite.ShowDialog();
        }

        /// <summary>
        /// 添加书签目录项
        /// </summary>
        /// <param name="title"></param>
        /// <param name="url"></param>
        public void AddBookmarkItem(string title, string url)
        {
            var bookmark = new ToolStripMenuItem()
            {
                Text = title,
                Tag = url,
                BackColor = Color.Transparent,
                BackgroundImage = Resources.dialog_back,
            };

            bookmark.Click += BookmarkItemOnClick;

            书签ToolStripMenuItem.DropDownItems.Add(bookmark);

        }

        private void BookmarkItemOnClick(object sender, EventArgs eventArgs)
        {
            try
            {
                var nowUrl = ((ToolStripMenuItem)sender).Tag.ToString();
                if (!this.tc_PageShow.SelectedTab.Text.Equals("空标签页"))
                {
                    NewEmptyPage();
                }

                NewUrl(nowUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// 获取书签信息
        /// </summary>
        private void GetBookmarks()
        {
            while (this.书签ToolStripMenuItem.DropDownItems.Count > 2) // 如前书签个数大于2(第一个添加书签, 第二个书签管理)
            {
                this.书签ToolStripMenuItem.DropDownItems.RemoveAt(2); // 移除其他书签
            }

            var dataList = bookManager.GetBookmarks();
            GlobalHelper.BookmarksList = dataList;
            foreach (var book in dataList)
            {
                AddBookmarkItem(book.Title, book.Url);
            }
        }

        /// <summary>
        /// 获取书签信息
        /// </summary>
        public void UpdateBookmarks()
        {
            while (this.书签ToolStripMenuItem.DropDownItems.Count > 2) // 如前书签个数大于2(第一个添加书签, 第二个书签管理)
            {
                this.书签ToolStripMenuItem.DropDownItems.RemoveAt(2); // 移除其他书签
            }

            foreach (var book in GlobalHelper.BookmarksList)
            {
                AddBookmarkItem(book.Title, book.Url);
            }
        }

        /// <summary>
        /// 保存书签信息
        /// </summary>
        private void SaveBookmark()
        {
            bookManager.SaveBookmarks(GlobalHelper.BookmarksList);
        }

        #endregion

        #region 检测连接

        [DllImport("wininet.dll", EntryPoint = "InternetGetConnectedState")]                // 导入函数
        private static extern bool InternetGetConnectedState(out int conState, int read);   // 声明接口

        /// <summary>
        /// desc = 16 未连接
        /// desc = 18 已连接
        /// </summary>
        /// <returns></returns>
        private bool IsConnected2Internect()                                                // 利用接口检查连接状态
        {
            var desc = 0;
            var isConnected = InternetGetConnectedState(out desc, 0);
            return isConnected;
        }

        #endregion

        #region 功能显示与否

        private void SetAllVisible(bool isVisible)
        {
            if (isVisible)
            {
                ms_Menu.Show();
                ts_ToolBar.Show();
                ss_ButtomBar.Show();
            }
            else
            {
                ms_Menu.Hide();
                ts_ToolBar.Hide();
                ss_ButtomBar.Hide();
            }
        }

        private void SetMenuBarVisible(bool isVisible)
        {
            ms_Menu.Visible = isVisible;
            菜单栏MToolStripMenuItem.Image =
                菜单栏ToolStripMenuItem.Image = isVisible ? il_Status.Images[0] : il_Status.Images[1];
        }

        private void SetNavigateBarVisible(bool isVisible)
        {
            ts_ToolBar.Visible = isVisible;
            搜索栏GToolStripMenuItem.Enabled =
                搜索栏ToolStripMenuItem.Enabled = isVisible;
            主页按钮HToolStripMenuItem.Enabled =
                主页按钮ToolStripMenuItem.Enabled = isVisible;

            导航栏IToolStripMenuItem.Image =
                导航栏ToolStripMenuItem.Image = isVisible ? il_Status.Images[0] : il_Status.Images[1];
        }

        private void SetStatusBarVisible(bool isVisible)
        {
            ss_ButtomBar.Visible = isVisible;
            状态栏SToolStripMenuItem.Image =
                状态栏ToolStripMenuItem.Image = isVisible ? il_Status.Images[0] : il_Status.Images[1];
        }

        private void SetSearchBarVisible(bool isVisible)
        {
            tsl_SearchLogo.Visible = tstb_Search.Visible = tsb_Search.Visible = isVisible;
            搜索栏GToolStripMenuItem.Image =
                搜索栏ToolStripMenuItem.Image = isVisible ? il_Status.Images[0] : il_Status.Images[1];
        }

        private void SetHomeBtnVisible(bool isVisible)
        {
            tsb_Home.Visible = isVisible;
            主页按钮HToolStripMenuItem.Image =
                主页按钮ToolStripMenuItem.Image = isVisible ? il_Status.Images[0] : il_Status.Images[1];
        }

        #endregion

        #region 状态栏
        private void SetSize_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if (item == null)
            {
                return;
            }

            var sizeScale = Convert.ToDouble(item.Tag.ToString());
            var isSetSuccess = false;
            for (var i = 0; i < tc_PageShow.TabPages.Count; i++)
            {
                var target = tc_PageShow.TabPages[i];
                var browser = (WebBrowser)target.Controls[0];
                if (browser.Document == null)
                {
                    continue;
                }

                if (browser.Document.Body != null)
                {
                    browser.Document.Body.Style = "zoom:" + sizeScale;
                    isSetSuccess = true;
                }
            }

            if (isSetSuccess)
            {
                currSizeScale = sizeScale;
                tsddb_Size.Text = item.Text;
            }
        }
        #endregion

        #region 上下文菜单
        private void 菜单栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetMenuBarVisible(!ms_Menu.Visible);
        }

        private void 导航栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetNavigateBarVisible(!ts_ToolBar.Visible);
        }

        private void 状态栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStatusBarVisible(!ss_ButtomBar.Visible);
        }

        private void 搜索栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSearchBarVisible(!tstb_Search.Visible);
        }

        private void 主页按钮ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetHomeBtnVisible(!tsb_Home.Visible);
        }

        private void tsmi_NewPage_Click(object sender, EventArgs e)
        {
            NewEmptyPage();
        }

        private void tsmi_ClosePage_Click(object sender, EventArgs e)
        {
            ClosePage();
        }

        private void tsmi_CloseAllPage_Click(object sender, EventArgs e)
        {
            CloseAllPage();
        }

        #endregion
    }
}
