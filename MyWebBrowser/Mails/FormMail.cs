using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyWebBrowser.Mails
{
    public partial class FormMail : Form
    {
        private UserControl currUserControl;

        public FormMail()
        {
            InitializeComponent();
        }

        private void FormMail_Load(object sender, EventArgs e)
        {
            ucReceiveMail1.Visible = true;
            currUserControl = ucReceiveMail1;
        }

        private void btn_Receive_Click(object sender, EventArgs e)
        {
            currUserControl.Visible = false;
            ucReceiveMail1.Visible = true;
            currUserControl = ucReceiveMail1;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            currUserControl.Visible = false;
            ucSendMail1.Visible = true;
            currUserControl = ucSendMail1;
        }

        private void btn_MailSetting_Click(object sender, EventArgs e)
        {
            currUserControl.Visible = false;
            ucMaiSetting1.Visible = true;
            currUserControl = ucMaiSetting1;
        }

        private void btn_RunInback_Click(object sender, EventArgs e)
        {
            this.Dispose(); // 释放内存
            this.WindowState = FormWindowState.Minimized; // 切换到最小化 并且任务栏显示邮箱图标
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose(); // 释放内存
            this.Close(); // 关闭当前窗体
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) // 如果当前状态为最小化
            {
                this.WindowState = FormWindowState.Normal; // 显示窗体
                this.Activate(); // 该窗体获取焦点
            }
        }
    }
}
