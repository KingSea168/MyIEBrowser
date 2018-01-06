namespace MyWebBrowser
{
    partial class FormPreference
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreference));
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_StartPage = new System.Windows.Forms.ComboBox();
            this.tbx_StartUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_HomeUrl = new System.Windows.Forms.TextBox();
            this.tbx_SearchUrl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckb_MenuBar = new System.Windows.Forms.CheckBox();
            this.ckb_NavigateBar = new System.Windows.Forms.CheckBox();
            this.ckb_StatusBar = new System.Windows.Forms.CheckBox();
            this.ckb_SearchBar = new System.Windows.Forms.CheckBox();
            this.ckb_Shortcut = new System.Windows.Forms.CheckBox();
            this.ckb_HomeBtn = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_Theme = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckb_InputRecord = new System.Windows.Forms.CheckBox();
            this.ckb_History = new System.Windows.Forms.CheckBox();
            this.ckb_Cookie = new System.Windows.Forms.CheckBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.llbl_Default = new System.Windows.Forms.LinkLabel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.picSkinShow = new System.Windows.Forms.PictureBox();
            this.il_ThemeShow = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSkinShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "默认启动页面:";
            // 
            // cbb_StartPage
            // 
            this.cbb_StartPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_StartPage.FormattingEnabled = true;
            this.cbb_StartPage.Items.AddRange(new object[] {
            "主页",
            "新标签页",
            "指定页面"});
            this.cbb_StartPage.Location = new System.Drawing.Point(142, 22);
            this.cbb_StartPage.Name = "cbb_StartPage";
            this.cbb_StartPage.Size = new System.Drawing.Size(108, 20);
            this.cbb_StartPage.TabIndex = 1;
            this.cbb_StartPage.SelectedIndexChanged += new System.EventHandler(this.cbb_StartPage_SelectedIndexChanged);
            // 
            // tbx_StartUrl
            // 
            this.tbx_StartUrl.Location = new System.Drawing.Point(260, 22);
            this.tbx_StartUrl.Name = "tbx_StartUrl";
            this.tbx_StartUrl.Size = new System.Drawing.Size(299, 21);
            this.tbx_StartUrl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(89, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "主页:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(73, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "搜索页:";
            // 
            // tbx_HomeUrl
            // 
            this.tbx_HomeUrl.Location = new System.Drawing.Point(143, 61);
            this.tbx_HomeUrl.Name = "tbx_HomeUrl";
            this.tbx_HomeUrl.Size = new System.Drawing.Size(416, 21);
            this.tbx_HomeUrl.TabIndex = 5;
            // 
            // tbx_SearchUrl
            // 
            this.tbx_SearchUrl.Location = new System.Drawing.Point(143, 103);
            this.tbx_SearchUrl.Name = "tbx_SearchUrl";
            this.tbx_SearchUrl.Size = new System.Drawing.Size(416, 21);
            this.tbx_SearchUrl.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbb_Theme);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ckb_Shortcut);
            this.groupBox1.Controls.Add(this.ckb_HomeBtn);
            this.groupBox1.Controls.Add(this.ckb_SearchBar);
            this.groupBox1.Controls.Add(this.ckb_StatusBar);
            this.groupBox1.Controls.Add(this.ckb_NavigateBar);
            this.groupBox1.Controls.Add(this.ckb_MenuBar);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(28, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 115);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "窗体显示";
            // 
            // ckb_MenuBar
            // 
            this.ckb_MenuBar.AutoSize = true;
            this.ckb_MenuBar.Checked = true;
            this.ckb_MenuBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_MenuBar.Location = new System.Drawing.Point(32, 34);
            this.ckb_MenuBar.Name = "ckb_MenuBar";
            this.ckb_MenuBar.Size = new System.Drawing.Size(75, 20);
            this.ckb_MenuBar.TabIndex = 0;
            this.ckb_MenuBar.Text = "菜单栏";
            this.ckb_MenuBar.UseVisualStyleBackColor = true;
            // 
            // ckb_NavigateBar
            // 
            this.ckb_NavigateBar.AutoSize = true;
            this.ckb_NavigateBar.Checked = true;
            this.ckb_NavigateBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_NavigateBar.Location = new System.Drawing.Point(160, 34);
            this.ckb_NavigateBar.Name = "ckb_NavigateBar";
            this.ckb_NavigateBar.Size = new System.Drawing.Size(75, 20);
            this.ckb_NavigateBar.TabIndex = 1;
            this.ckb_NavigateBar.Text = "导航栏";
            this.ckb_NavigateBar.UseVisualStyleBackColor = true;
            // 
            // ckb_StatusBar
            // 
            this.ckb_StatusBar.AutoSize = true;
            this.ckb_StatusBar.Checked = true;
            this.ckb_StatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_StatusBar.Location = new System.Drawing.Point(283, 34);
            this.ckb_StatusBar.Name = "ckb_StatusBar";
            this.ckb_StatusBar.Size = new System.Drawing.Size(75, 20);
            this.ckb_StatusBar.TabIndex = 2;
            this.ckb_StatusBar.Text = "状态栏";
            this.ckb_StatusBar.UseVisualStyleBackColor = true;
            // 
            // ckb_SearchBar
            // 
            this.ckb_SearchBar.AutoSize = true;
            this.ckb_SearchBar.Checked = true;
            this.ckb_SearchBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_SearchBar.Location = new System.Drawing.Point(402, 34);
            this.ckb_SearchBar.Name = "ckb_SearchBar";
            this.ckb_SearchBar.Size = new System.Drawing.Size(75, 20);
            this.ckb_SearchBar.TabIndex = 3;
            this.ckb_SearchBar.Text = "搜索栏";
            this.ckb_SearchBar.UseVisualStyleBackColor = true;
            // 
            // ckb_Shortcut
            // 
            this.ckb_Shortcut.AutoSize = true;
            this.ckb_Shortcut.Checked = true;
            this.ckb_Shortcut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_Shortcut.Location = new System.Drawing.Point(160, 75);
            this.ckb_Shortcut.Name = "ckb_Shortcut";
            this.ckb_Shortcut.Size = new System.Drawing.Size(107, 20);
            this.ckb_Shortcut.TabIndex = 5;
            this.ckb_Shortcut.Text = "使用快捷键";
            this.ckb_Shortcut.UseVisualStyleBackColor = true;
            // 
            // ckb_HomeBtn
            // 
            this.ckb_HomeBtn.AutoSize = true;
            this.ckb_HomeBtn.Checked = true;
            this.ckb_HomeBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_HomeBtn.Location = new System.Drawing.Point(32, 75);
            this.ckb_HomeBtn.Name = "ckb_HomeBtn";
            this.ckb_HomeBtn.Size = new System.Drawing.Size(91, 20);
            this.ckb_HomeBtn.TabIndex = 4;
            this.ckb_HomeBtn.Text = "主页按钮";
            this.ckb_HomeBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(280, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "主题风格:";
            // 
            // cbb_Theme
            // 
            this.cbb_Theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Theme.FormattingEnabled = true;
            this.cbb_Theme.Items.AddRange(new object[] {
            "默认",
            "Calmness",
            "Midsummer",
            "Msn",
            "Page",
            "Steelblack"});
            this.cbb_Theme.Location = new System.Drawing.Point(366, 72);
            this.cbb_Theme.Name = "cbb_Theme";
            this.cbb_Theme.Size = new System.Drawing.Size(108, 24);
            this.cbb_Theme.TabIndex = 8;
            this.cbb_Theme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbb_Theme_MouseClick);
            this.cbb_Theme.MouseLeave += new System.EventHandler(this.cbb_Theme_MouseLeave);
            this.cbb_Theme.MouseHover += new System.EventHandler(this.cbb_Theme_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.ckb_InputRecord);
            this.groupBox2.Controls.Add(this.ckb_History);
            this.groupBox2.Controls.Add(this.ckb_Cookie);
            this.groupBox2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(28, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 76);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "删除记录";
            // 
            // ckb_InputRecord
            // 
            this.ckb_InputRecord.AutoSize = true;
            this.ckb_InputRecord.Checked = true;
            this.ckb_InputRecord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_InputRecord.Location = new System.Drawing.Point(283, 34);
            this.ckb_InputRecord.Name = "ckb_InputRecord";
            this.ckb_InputRecord.Size = new System.Drawing.Size(91, 20);
            this.ckb_InputRecord.TabIndex = 2;
            this.ckb_InputRecord.Text = "输入记录";
            this.ckb_InputRecord.UseVisualStyleBackColor = true;
            // 
            // ckb_History
            // 
            this.ckb_History.AutoSize = true;
            this.ckb_History.Checked = true;
            this.ckb_History.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_History.Location = new System.Drawing.Point(160, 34);
            this.ckb_History.Name = "ckb_History";
            this.ckb_History.Size = new System.Drawing.Size(91, 20);
            this.ckb_History.TabIndex = 1;
            this.ckb_History.Text = "历史记录";
            this.ckb_History.UseVisualStyleBackColor = true;
            // 
            // ckb_Cookie
            // 
            this.ckb_Cookie.AutoSize = true;
            this.ckb_Cookie.Checked = true;
            this.ckb_Cookie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_Cookie.Location = new System.Drawing.Point(32, 34);
            this.ckb_Cookie.Name = "ckb_Cookie";
            this.ckb_Cookie.Size = new System.Drawing.Size(75, 20);
            this.ckb_Cookie.TabIndex = 0;
            this.ckb_Cookie.Text = "Cookie";
            this.ckb_Cookie.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.BackgroundImage = global::MyWebBrowser.Properties.Resources.dialog_back;
            this.btn_Delete.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Delete.Location = new System.Drawing.Point(402, 32);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // llbl_Default
            // 
            this.llbl_Default.AutoSize = true;
            this.llbl_Default.BackColor = System.Drawing.Color.Transparent;
            this.llbl_Default.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.llbl_Default.Location = new System.Drawing.Point(267, 385);
            this.llbl_Default.Name = "llbl_Default";
            this.llbl_Default.Size = new System.Drawing.Size(104, 16);
            this.llbl_Default.TabIndex = 10;
            this.llbl_Default.TabStop = true;
            this.llbl_Default.Text = "恢复缺省设置";
            this.llbl_Default.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_Default_LinkClicked);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackgroundImage = global::MyWebBrowser.Properties.Resources.dialog_back;
            this.btn_Cancel.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(394, 382);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackgroundImage = global::MyWebBrowser.Properties.Resources.dialog_back;
            this.btn_Confirm.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Confirm.Location = new System.Drawing.Point(484, 382);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 11;
            this.btn_Confirm.Text = "确认";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // picSkinShow
            // 
            this.picSkinShow.BackColor = System.Drawing.SystemColors.Control;
            this.picSkinShow.Location = new System.Drawing.Point(132, 46);
            this.picSkinShow.Name = "picSkinShow";
            this.picSkinShow.Size = new System.Drawing.Size(256, 200);
            this.picSkinShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSkinShow.TabIndex = 12;
            this.picSkinShow.TabStop = false;
            this.picSkinShow.Visible = false;
            // 
            // il_ThemeShow
            // 
            this.il_ThemeShow.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_ThemeShow.ImageStream")));
            this.il_ThemeShow.TransparentColor = System.Drawing.Color.Transparent;
            this.il_ThemeShow.Images.SetKeyName(0, "Chrysanthemum.jpg");
            this.il_ThemeShow.Images.SetKeyName(1, "Desert.jpg");
            this.il_ThemeShow.Images.SetKeyName(2, "Hydrangeas.jpg");
            this.il_ThemeShow.Images.SetKeyName(3, "Jellyfish.jpg");
            this.il_ThemeShow.Images.SetKeyName(4, "Koala.jpg");
            this.il_ThemeShow.Images.SetKeyName(5, "Tulips.jpg");
            // 
            // FormPreference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyWebBrowser.Properties.Resources.dialog_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 425);
            this.Controls.Add(this.picSkinShow);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.llbl_Default);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbx_SearchUrl);
            this.Controls.Add(this.tbx_HomeUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_StartUrl);
            this.Controls.Add(this.cbb_StartPage);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPreference";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "首选项";
            this.Load += new System.EventHandler(this.FormPreference_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSkinShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_StartPage;
        private System.Windows.Forms.TextBox tbx_StartUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_HomeUrl;
        private System.Windows.Forms.TextBox tbx_SearchUrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckb_MenuBar;
        private System.Windows.Forms.CheckBox ckb_Shortcut;
        private System.Windows.Forms.CheckBox ckb_HomeBtn;
        private System.Windows.Forms.CheckBox ckb_SearchBar;
        private System.Windows.Forms.CheckBox ckb_StatusBar;
        private System.Windows.Forms.CheckBox ckb_NavigateBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_Theme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckb_InputRecord;
        private System.Windows.Forms.CheckBox ckb_History;
        private System.Windows.Forms.CheckBox ckb_Cookie;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.LinkLabel llbl_Default;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.PictureBox picSkinShow;
        private System.Windows.Forms.ImageList il_ThemeShow;
    }
}