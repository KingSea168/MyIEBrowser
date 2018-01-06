namespace MyWebBrowser.UserControls
{
    partial class ucMaiSetting
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
            this.gbx_Account = new System.Windows.Forms.GroupBox();
            this.tbx_Pwd = new System.Windows.Forms.TextBox();
            this.tbx_EmailAddr = new System.Windows.Forms.TextBox();
            this.tbx_UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_POPPort = new System.Windows.Forms.TextBox();
            this.tbx_POPServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbx_SMTPPort = new System.Windows.Forms.TextBox();
            this.tbx_SMTPServer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.gbx_Account.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.label1.Text = "邮件设置";
            // 
            // gbx_Account
            // 
            this.gbx_Account.Controls.Add(this.tbx_Pwd);
            this.gbx_Account.Controls.Add(this.tbx_EmailAddr);
            this.gbx_Account.Controls.Add(this.tbx_UserName);
            this.gbx_Account.Controls.Add(this.label4);
            this.gbx_Account.Controls.Add(this.label3);
            this.gbx_Account.Controls.Add(this.label2);
            this.gbx_Account.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbx_Account.Location = new System.Drawing.Point(29, 54);
            this.gbx_Account.Name = "gbx_Account";
            this.gbx_Account.Size = new System.Drawing.Size(590, 134);
            this.gbx_Account.TabIndex = 1;
            this.gbx_Account.TabStop = false;
            this.gbx_Account.Text = "账号设置";
            // 
            // tbx_Pwd
            // 
            this.tbx_Pwd.Location = new System.Drawing.Point(127, 100);
            this.tbx_Pwd.Name = "tbx_Pwd";
            this.tbx_Pwd.Size = new System.Drawing.Size(145, 26);
            this.tbx_Pwd.TabIndex = 5;
            // 
            // tbx_EmailAddr
            // 
            this.tbx_EmailAddr.Location = new System.Drawing.Point(127, 65);
            this.tbx_EmailAddr.Name = "tbx_EmailAddr";
            this.tbx_EmailAddr.Size = new System.Drawing.Size(403, 26);
            this.tbx_EmailAddr.TabIndex = 4;
            // 
            // tbx_UserName
            // 
            this.tbx_UserName.Location = new System.Drawing.Point(127, 29);
            this.tbx_UserName.Name = "tbx_UserName";
            this.tbx_UserName.Size = new System.Drawing.Size(145, 26);
            this.tbx_UserName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "邮箱地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户名：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_POPPort);
            this.groupBox1.Controls.Add(this.tbx_POPServer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(29, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 134);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "POP接收设置";
            // 
            // tbx_POPPort
            // 
            this.tbx_POPPort.Location = new System.Drawing.Point(127, 76);
            this.tbx_POPPort.Name = "tbx_POPPort";
            this.tbx_POPPort.Size = new System.Drawing.Size(145, 26);
            this.tbx_POPPort.TabIndex = 5;
            // 
            // tbx_POPServer
            // 
            this.tbx_POPServer.Location = new System.Drawing.Point(127, 35);
            this.tbx_POPServer.Name = "tbx_POPServer";
            this.tbx_POPServer.Size = new System.Drawing.Size(403, 26);
            this.tbx_POPServer.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "POP端口号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "POP服务器：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbx_SMTPPort);
            this.groupBox2.Controls.Add(this.tbx_SMTPServer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(29, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 134);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SMTP发送设置";
            // 
            // tbx_SMTPPort
            // 
            this.tbx_SMTPPort.Location = new System.Drawing.Point(127, 75);
            this.tbx_SMTPPort.Name = "tbx_SMTPPort";
            this.tbx_SMTPPort.Size = new System.Drawing.Size(145, 26);
            this.tbx_SMTPPort.TabIndex = 5;
            // 
            // tbx_SMTPServer
            // 
            this.tbx_SMTPServer.Location = new System.Drawing.Point(127, 35);
            this.tbx_SMTPServer.Name = "tbx_SMTPServer";
            this.tbx_SMTPServer.Size = new System.Drawing.Size(403, 26);
            this.tbx_SMTPServer.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "SMTP端口号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "SMTP服务器：";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackgroundImage = global::MyWebBrowser.Properties.Resources.dialog_back;
            this.btn_Confirm.Location = new System.Drawing.Point(544, 520);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 8;
            this.btn_Confirm.Text = "确认";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // ucMaiSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::MyWebBrowser.Properties.Resources.dialog_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_Account);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ucMaiSetting";
            this.Size = new System.Drawing.Size(652, 555);
            this.gbx_Account.ResumeLayout(false);
            this.gbx_Account.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbx_Account;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Pwd;
        private System.Windows.Forms.TextBox tbx_EmailAddr;
        private System.Windows.Forms.TextBox tbx_UserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_POPPort;
        private System.Windows.Forms.TextBox tbx_POPServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbx_SMTPPort;
        private System.Windows.Forms.TextBox tbx_SMTPServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Confirm;
    }
}
