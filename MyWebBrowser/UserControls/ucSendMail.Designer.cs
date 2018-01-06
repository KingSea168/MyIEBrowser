namespace MyWebBrowser.UserControls
{
    partial class ucSendMail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rtbx_mailContent = new System.Windows.Forms.RichTextBox();
            this.tbx_Topic = new System.Windows.Forms.TextBox();
            this.tbx_Receivers = new System.Windows.Forms.TextBox();
            this.tbx_Senders = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_MailCount = new System.Windows.Forms.Label();
            this.lbl_Addr = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "发送邮件";
            // 
            // rtbx_mailContent
            // 
            this.rtbx_mailContent.Location = new System.Drawing.Point(21, 164);
            this.rtbx_mailContent.Name = "rtbx_mailContent";
            this.rtbx_mailContent.Size = new System.Drawing.Size(613, 372);
            this.rtbx_mailContent.TabIndex = 15;
            this.rtbx_mailContent.Text = "";
            // 
            // tbx_Topic
            // 
            this.tbx_Topic.Location = new System.Drawing.Point(106, 125);
            this.tbx_Topic.MaximumSize = new System.Drawing.Size(517, 300);
            this.tbx_Topic.Name = "tbx_Topic";
            this.tbx_Topic.Size = new System.Drawing.Size(430, 21);
            this.tbx_Topic.TabIndex = 14;
            // 
            // tbx_Receivers
            // 
            this.tbx_Receivers.Location = new System.Drawing.Point(106, 93);
            this.tbx_Receivers.Name = "tbx_Receivers";
            this.tbx_Receivers.Size = new System.Drawing.Size(430, 21);
            this.tbx_Receivers.TabIndex = 13;
            // 
            // tbx_Senders
            // 
            this.tbx_Senders.Location = new System.Drawing.Point(106, 59);
            this.tbx_Senders.Name = "tbx_Senders";
            this.tbx_Senders.Size = new System.Drawing.Size(430, 21);
            this.tbx_Senders.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "收件人：";
            // 
            // lbl_MailCount
            // 
            this.lbl_MailCount.AutoSize = true;
            this.lbl_MailCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MailCount.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_MailCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_MailCount.Location = new System.Drawing.Point(48, 127);
            this.lbl_MailCount.Name = "lbl_MailCount";
            this.lbl_MailCount.Size = new System.Drawing.Size(52, 14);
            this.lbl_MailCount.TabIndex = 10;
            this.lbl_MailCount.Text = "主题：";
            // 
            // lbl_Addr
            // 
            this.lbl_Addr.AutoSize = true;
            this.lbl_Addr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Addr.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Addr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Addr.Location = new System.Drawing.Point(33, 61);
            this.lbl_Addr.Name = "lbl_Addr";
            this.lbl_Addr.Size = new System.Drawing.Size(67, 14);
            this.lbl_Addr.TabIndex = 9;
            this.lbl_Addr.Text = "发件人：";
            // 
            // btn_Send
            // 
            this.btn_Send.BackgroundImage = global::MyWebBrowser.Properties.Resources.dialog_back;
            this.btn_Send.Location = new System.Drawing.Point(559, 125);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 16;
            this.btn_Send.Text = "发送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // ucSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::MyWebBrowser.Properties.Resources.dialog_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.rtbx_mailContent);
            this.Controls.Add(this.tbx_Topic);
            this.Controls.Add(this.tbx_Receivers);
            this.Controls.Add(this.tbx_Senders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_MailCount);
            this.Controls.Add(this.lbl_Addr);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ucSendMail";
            this.Size = new System.Drawing.Size(652, 555);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbx_mailContent;
        private System.Windows.Forms.TextBox tbx_Topic;
        private System.Windows.Forms.TextBox tbx_Receivers;
        private System.Windows.Forms.TextBox tbx_Senders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MailCount;
        private System.Windows.Forms.Label lbl_Addr;
        private System.Windows.Forms.Button btn_Send;
    }
}
