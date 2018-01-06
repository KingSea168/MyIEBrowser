namespace MyWebBrowser.Mails
{
    partial class FormMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMail));
            this.btn_Receive = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_RunInback = new System.Windows.Forms.Button();
            this.btn_MailSetting = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.ucMaiSetting1 = new MyWebBrowser.UserControls.ucMaiSetting();
            this.ucViewMail1 = new MyWebBrowser.UserControls.ucViewMail();
            this.ucSendMail1 = new MyWebBrowser.UserControls.ucSendMail();
            this.ucReceiveMail1 = new MyWebBrowser.UserControls.ucReceiveMail();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btn_Receive
            // 
            this.btn_Receive.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Receive.Location = new System.Drawing.Point(16, 44);
            this.btn_Receive.Name = "btn_Receive";
            this.btn_Receive.Size = new System.Drawing.Size(68, 23);
            this.btn_Receive.TabIndex = 0;
            this.btn_Receive.Text = "接收邮件";
            this.btn_Receive.UseVisualStyleBackColor = false;
            this.btn_Receive.Click += new System.EventHandler(this.btn_Receive_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.Yellow;
            this.btn_Send.Location = new System.Drawing.Point(16, 83);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(68, 23);
            this.btn_Send.TabIndex = 1;
            this.btn_Send.Text = "发送邮件";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_RunInback
            // 
            this.btn_RunInback.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_RunInback.Location = new System.Drawing.Point(16, 164);
            this.btn_RunInback.Name = "btn_RunInback";
            this.btn_RunInback.Size = new System.Drawing.Size(68, 23);
            this.btn_RunInback.TabIndex = 3;
            this.btn_RunInback.Text = "后台运行";
            this.btn_RunInback.UseVisualStyleBackColor = false;
            this.btn_RunInback.Click += new System.EventHandler(this.btn_RunInback_Click);
            // 
            // btn_MailSetting
            // 
            this.btn_MailSetting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_MailSetting.Location = new System.Drawing.Point(16, 125);
            this.btn_MailSetting.Name = "btn_MailSetting";
            this.btn_MailSetting.Size = new System.Drawing.Size(68, 23);
            this.btn_MailSetting.TabIndex = 2;
            this.btn_MailSetting.Text = "邮件设置";
            this.btn_MailSetting.UseVisualStyleBackColor = false;
            this.btn_MailSetting.Click += new System.EventHandler(this.btn_MailSetting_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Close.Location = new System.Drawing.Point(16, 204);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(68, 23);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "关闭";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // ucMaiSetting1
            // 
            this.ucMaiSetting1.BackColor = System.Drawing.Color.Transparent;
            this.ucMaiSetting1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucMaiSetting1.BackgroundImage")));
            this.ucMaiSetting1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMaiSetting1.Location = new System.Drawing.Point(90, 12);
            this.ucMaiSetting1.Name = "ucMaiSetting1";
            this.ucMaiSetting1.Size = new System.Drawing.Size(652, 555);
            this.ucMaiSetting1.TabIndex = 8;
            this.ucMaiSetting1.Visible = false;
            // 
            // ucViewMail1
            // 
            this.ucViewMail1.BackColor = System.Drawing.Color.Transparent;
            this.ucViewMail1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucViewMail1.BackgroundImage")));
            this.ucViewMail1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucViewMail1.Location = new System.Drawing.Point(96, 12);
            this.ucViewMail1.Name = "ucViewMail1";
            this.ucViewMail1.Size = new System.Drawing.Size(652, 555);
            this.ucViewMail1.TabIndex = 7;
            this.ucViewMail1.Visible = false;
            // 
            // ucSendMail1
            // 
            this.ucSendMail1.BackColor = System.Drawing.Color.Transparent;
            this.ucSendMail1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucSendMail1.BackgroundImage")));
            this.ucSendMail1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucSendMail1.Location = new System.Drawing.Point(96, 8);
            this.ucSendMail1.Name = "ucSendMail1";
            this.ucSendMail1.Size = new System.Drawing.Size(652, 555);
            this.ucSendMail1.TabIndex = 6;
            this.ucSendMail1.Visible = false;
            // 
            // ucReceiveMail1
            // 
            this.ucReceiveMail1.BackColor = System.Drawing.Color.Transparent;
            this.ucReceiveMail1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucReceiveMail1.BackgroundImage")));
            this.ucReceiveMail1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucReceiveMail1.Location = new System.Drawing.Point(96, 8);
            this.ucReceiveMail1.Name = "ucReceiveMail1";
            this.ucReceiveMail1.Size = new System.Drawing.Size(652, 555);
            this.ucReceiveMail1.TabIndex = 5;
            this.ucReceiveMail1.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "KING浏览器-邮件收发";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // FormMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyWebBrowser.Properties.Resources.dialog_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 569);
            this.Controls.Add(this.ucMaiSetting1);
            this.Controls.Add(this.ucViewMail1);
            this.Controls.Add(this.ucSendMail1);
            this.Controls.Add(this.ucReceiveMail1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_RunInback);
            this.Controls.Add(this.btn_MailSetting);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_Receive);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "邮件收发";
            this.Load += new System.EventHandler(this.FormMail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Receive;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_RunInback;
        private System.Windows.Forms.Button btn_MailSetting;
        private System.Windows.Forms.Button btn_Close;
        private UserControls.ucReceiveMail ucReceiveMail1;
        private UserControls.ucSendMail ucSendMail1;
        private UserControls.ucViewMail ucViewMail1;
        private UserControls.ucMaiSetting ucMaiSetting1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}