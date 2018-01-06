namespace MyWebBrowser.UserControls
{
    partial class ucReceiveMail
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
            this.lbl_Addr = new System.Windows.Forms.Label();
            this.lbl_MailCount = new System.Windows.Forms.Label();
            this.lv_MailList = new System.Windows.Forms.ListView();
            this.ch_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Sender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label1.Text = "接收邮件";
            // 
            // lbl_Addr
            // 
            this.lbl_Addr.AutoSize = true;
            this.lbl_Addr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Addr.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Addr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Addr.Location = new System.Drawing.Point(33, 57);
            this.lbl_Addr.Name = "lbl_Addr";
            this.lbl_Addr.Size = new System.Drawing.Size(37, 14);
            this.lbl_Addr.TabIndex = 1;
            this.lbl_Addr.Text = "地址";
            // 
            // lbl_MailCount
            // 
            this.lbl_MailCount.AutoSize = true;
            this.lbl_MailCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MailCount.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_MailCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_MailCount.Location = new System.Drawing.Point(33, 83);
            this.lbl_MailCount.Name = "lbl_MailCount";
            this.lbl_MailCount.Size = new System.Drawing.Size(90, 14);
            this.lbl_MailCount.TabIndex = 2;
            this.lbl_MailCount.Text = "共有X封邮件";
            // 
            // lv_MailList
            // 
            this.lv_MailList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_title,
            this.ch_Sender});
            this.lv_MailList.FullRowSelect = true;
            this.lv_MailList.Location = new System.Drawing.Point(30, 104);
            this.lv_MailList.Name = "lv_MailList";
            this.lv_MailList.Scrollable = false;
            this.lv_MailList.Size = new System.Drawing.Size(593, 400);
            this.lv_MailList.TabIndex = 3;
            this.lv_MailList.UseCompatibleStateImageBehavior = false;
            this.lv_MailList.View = System.Windows.Forms.View.Details;
            // 
            // ch_title
            // 
            this.ch_title.Text = "标题";
            this.ch_title.Width = 360;
            // 
            // ch_Sender
            // 
            this.ch_Sender.Text = "发件人";
            this.ch_Sender.Width = 660;
            // 
            // ucReceiveMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::MyWebBrowser.Properties.Resources.dialog_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lv_MailList);
            this.Controls.Add(this.lbl_MailCount);
            this.Controls.Add(this.lbl_Addr);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ucReceiveMail";
            this.Size = new System.Drawing.Size(652, 555);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Addr;
        private System.Windows.Forms.Label lbl_MailCount;
        private System.Windows.Forms.ListView lv_MailList;
        private System.Windows.Forms.ColumnHeader ch_title;
        private System.Windows.Forms.ColumnHeader ch_Sender;
    }
}
