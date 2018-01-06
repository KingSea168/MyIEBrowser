namespace MyWebBrowser.UserControls
{
    partial class ucViewMail
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rtbx_mailContent = new System.Windows.Forms.RichTextBox();
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
            this.label1.Text = "查看邮件";
            // 
            // lbl_Addr
            // 
            this.lbl_Addr.AutoSize = true;
            this.lbl_Addr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Addr.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Addr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Addr.Location = new System.Drawing.Point(33, 57);
            this.lbl_Addr.Name = "lbl_Addr";
            this.lbl_Addr.Size = new System.Drawing.Size(67, 14);
            this.lbl_Addr.TabIndex = 1;
            this.lbl_Addr.Text = "发件人：";
            // 
            // lbl_MailCount
            // 
            this.lbl_MailCount.AutoSize = true;
            this.lbl_MailCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MailCount.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_MailCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_MailCount.Location = new System.Drawing.Point(48, 89);
            this.lbl_MailCount.Name = "lbl_MailCount";
            this.lbl_MailCount.Size = new System.Drawing.Size(52, 14);
            this.lbl_MailCount.TabIndex = 2;
            this.lbl_MailCount.Text = "主题：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(18, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "详细信息：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 21);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(430, 21);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 121);
            this.textBox3.MaximumSize = new System.Drawing.Size(517, 300);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(430, 81);
            this.textBox3.TabIndex = 7;
            // 
            // rtbx_mailContent
            // 
            this.rtbx_mailContent.Location = new System.Drawing.Point(21, 222);
            this.rtbx_mailContent.Name = "rtbx_mailContent";
            this.rtbx_mailContent.Size = new System.Drawing.Size(613, 270);
            this.rtbx_mailContent.TabIndex = 8;
            this.rtbx_mailContent.Text = "";
            // 
            // ucViewMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::MyWebBrowser.Properties.Resources.dialog_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.rtbx_mailContent);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_MailCount);
            this.Controls.Add(this.lbl_Addr);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ucViewMail";
            this.Size = new System.Drawing.Size(652, 555);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Addr;
        private System.Windows.Forms.Label lbl_MailCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox rtbx_mailContent;
    }
}
