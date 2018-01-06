using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyWebBrowserBLL;
using MyWebBrowserModels;

namespace MyWebBrowser
{
    public partial class FormPreference : Form
    {
        private PreferenceManager preferManager = new PreferenceManager();
        private Preference prefer;

        private string homeUrl = "https://www.baidu.com";
        private string searchUrl = "http://www.google.cn";
        private string defaultUrl = "about:blank";

        private bool isCleanHistroy = false;
        private bool isCleanInput = false;

        private Form mainForm;

        public FormPreference(Form main)
        {
            InitializeComponent();

            mainForm = main;
        }

        private void FormPreference_Load(object sender, EventArgs e)
        {
            prefer = preferManager.GetPreference();
            if (prefer == null)
            {
                // 缺省设置
                SetDefaultInfo();
            }
            else
            {
                // 根据配置项设置
                SetInfoByPrefer();
            }
        }

        private void cbb_StartPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            var url = string.Empty;
            switch (cbb_StartPage.SelectedIndex)
            {
                // 主页
                case (int)StartPageIndex.HomePage:
                    url = prefer == null ? homeUrl : prefer.HomeUrl;
                    tbx_StartUrl.Enabled = false;
                    break;

                // 新标签页
                case (int)StartPageIndex.NewPage:
                    url = defaultUrl;
                    tbx_StartUrl.Enabled = false;
                    break;

                // 指定页面
                case (int)StartPageIndex.SpecifiedPage:
                    url = prefer == null ? "" : prefer.StartUrl;
                    tbx_StartUrl.Enabled = true;
                    tbx_StartUrl.Focus();
                    break;
            }

            tbx_StartUrl.Text = url;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (!ckb_Cookie.Checked && !ckb_History.Checked && !ckb_InputRecord.Checked)
            {
                PageCommon.ShowInforDiolag("请选择要删除的记录", "提示");
                return;
            }

            var result = PageCommon.ShowInforDiolag("确认删除记录吗?", "系统提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                PageCommon.ShowInforDiolag(DeleteInfo() ? "删除记录成功!" : "删除记录失败!", "提示");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckIsChange())
                {
                    SavePrefer();
                }

                CloseWindow();
            }
            catch (Exception ex)
            {
                FileLog.LogError(ex);
            }
            
        }

        private void llbl_Default_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetDefaultInfo();
        }

        private void cbb_Theme_MouseHover(object sender, EventArgs e)
        {
            picSkinShow.Visible = true;
            picSkinShow.Image = il_ThemeShow.Images[cbb_Theme.SelectedIndex];
        }

        private void cbb_Theme_MouseLeave(object sender, EventArgs e)
        {
            picSkinShow.Visible = false;
            picSkinShow.Image = null;
        }

        private void cbb_Theme_MouseClick(object sender, MouseEventArgs e)
        {
            cbb_Theme_MouseLeave(null, null);
        }

        /// <summary>
        /// 缺省设置
        /// </summary>
        private void SetDefaultInfo()
        {
            cbb_StartPage.SelectedIndex = (int)StartPageIndex.NewPage;
            tbx_HomeUrl.Text = homeUrl;
            tbx_SearchUrl.Text = searchUrl;
            ckb_MenuBar.Checked =
                ckb_NavigateBar.Checked =
                    ckb_StatusBar.Checked =
                        ckb_SearchBar.Checked =
                            ckb_HomeBtn.Checked =
                                ckb_Shortcut.Checked = true;
            cbb_Theme.SelectedIndex = (int)ThemeIndex.Default;
        }

        /// <summary>
        /// 根据配置信息设置
        /// </summary>
        private void SetInfoByPrefer()
        {
            cbb_StartPage.SelectedIndex = Convert.ToInt32(prefer.DefaultStartId);
            tbx_HomeUrl.Text = prefer.HomeUrl;
            tbx_SearchUrl.Text = prefer.SearchUrl;
            ckb_MenuBar.Checked = Convert.ToBoolean(prefer.ShowMenuBar);
            ckb_NavigateBar.Checked = Convert.ToBoolean(prefer.ShowNavigateBar);
            ckb_StatusBar.Checked = Convert.ToBoolean(prefer.ShowStatusBar);
            ckb_SearchBar.Checked = Convert.ToBoolean(prefer.ShowSearchBar);
            ckb_HomeBtn.Checked = Convert.ToBoolean(prefer.ShowHomeBtn);
            ckb_Shortcut.Checked = Convert.ToBoolean(prefer.UseShortcut);
            cbb_Theme.SelectedIndex = Convert.ToInt32(prefer.ThemeId);
        }

        /// <summary>
        /// 保存配置
        /// </summary>
        private void SavePrefer()
        {
            prefer = new Preference(cbb_StartPage.SelectedIndex.ToString(), tbx_StartUrl.Text, tbx_HomeUrl.Text, tbx_SearchUrl.Text,
                ckb_MenuBar.Checked.ToString(), ckb_NavigateBar.Checked.ToString(), ckb_StatusBar.Checked.ToString(), ckb_SearchBar.Checked.ToString(),
                ckb_HomeBtn.Checked.ToString(), ckb_Shortcut.Checked.ToString(), cbb_Theme.SelectedIndex.ToString());
            if (preferManager.SavePreference(prefer))
            {
                var result = PageCommon.ShowInforDiolag("配置成功! 新配置会在重新启动程序后生效, 现在就要重新启动吗?", "系统提示", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Dispose();
                    mainForm.Dispose();
                    Application.Restart();
                }
            }
            else
            {
                PageCommon.ShowInforDiolag("配置保存失败！", "错误提示");
            }
        }

        /// <summary>
        /// 检测是否更改
        /// </summary>
        /// <returns></returns>
        private bool CheckIsChange()
        {
            if (prefer == null)
            {
                return true;
            }

            if (cbb_StartPage.SelectedIndex == Convert.ToInt32(prefer.DefaultStartId)
                && tbx_HomeUrl.Text == prefer.HomeUrl
                && tbx_SearchUrl.Text == prefer.SearchUrl
                && ckb_MenuBar.Checked == Convert.ToBoolean(prefer.ShowMenuBar)
                && ckb_NavigateBar.Checked == Convert.ToBoolean(prefer.ShowNavigateBar)
                && ckb_StatusBar.Checked == Convert.ToBoolean(prefer.ShowStatusBar)
                && ckb_SearchBar.Checked == Convert.ToBoolean(prefer.ShowSearchBar)
                && ckb_HomeBtn.Checked == Convert.ToBoolean(prefer.ShowHomeBtn)
                && ckb_Shortcut.Checked == Convert.ToBoolean(prefer.UseShortcut)
                && cbb_Theme.SelectedIndex == Convert.ToInt32(prefer.ThemeId))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <returns></returns>
        private bool DeleteInfo()
        {
            if (ckb_Cookie.Checked)
            {
                try
                {
                    var fileList = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
                    foreach (var s in fileList)
                    {
                        if (s.ToLower().IndexOf("index.dat", StringComparison.Ordinal) == -1)
                        {
                            File.Delete(s);
                        }
                    }
                }
                catch (Exception ex)
                {
                    FileLog.LogError(ex);
                    return false;
                }
            }

            if (ckb_History.Checked)
            {
                isCleanHistroy = true;
            }

            if (ckb_InputRecord.Checked)
            {
                isCleanInput = true;
            }

            return true;
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        private void CloseWindow()
        {
            Dispose();
            Close();

            // 如果删除过记录，刷新主窗体
            if (isCleanHistroy || isCleanInput)
            {
                GlobalHelper.IsCleanHistory = isCleanHistroy;
                GlobalHelper.IsCleanInputRecord = isCleanInput;

                mainForm.Activate();    // 激活主窗体
                mainForm.Refresh();     // 重新绘制主窗体
                mainForm.Update();      // 刷新主窗体
            }
        }
    }
}
