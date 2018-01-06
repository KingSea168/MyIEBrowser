namespace MyWebBrowser.Bookmarks
{
    partial class FormBookmarkManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookmarkManage));
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lv_BookMarkList = new System.Windows.Forms.ListView();
            this.ch_Tilte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_addr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.BackgroundImage")));
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Delete.Location = new System.Drawing.Point(504, 395);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Location = new System.Drawing.Point(504, 424);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "关闭";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lv_BookMarkList
            // 
            this.lv_BookMarkList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Tilte,
            this.ch_Addr});
            this.lv_BookMarkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lv_BookMarkList.FullRowSelect = true;
            this.lv_BookMarkList.Location = new System.Drawing.Point(39, 24);
            this.lv_BookMarkList.Name = "lv_BookMarkList";
            this.lv_BookMarkList.Scrollable = false;
            this.lv_BookMarkList.Size = new System.Drawing.Size(540, 294);
            this.lv_BookMarkList.TabIndex = 1;
            this.lv_BookMarkList.UseCompatibleStateImageBehavior = false;
            this.lv_BookMarkList.View = System.Windows.Forms.View.Details;
            this.lv_BookMarkList.Click += new System.EventHandler(this.lv_BookMarkList_Click);
            // 
            // ch_Tilte
            // 
            this.ch_Tilte.Text = "标题";
            this.ch_Tilte.Width = 178;
            // 
            // ch_Addr
            // 
            this.ch_Addr.Text = "地址";
            this.ch_Addr.Width = 375;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbx_addr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbx_title);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(39, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请选择";
            // 
            // tbx_addr
            // 
            this.tbx_addr.Location = new System.Drawing.Point(79, 71);
            this.tbx_addr.Name = "tbx_addr";
            this.tbx_addr.Size = new System.Drawing.Size(348, 26);
            this.tbx_addr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "地址：";
            // 
            // tbx_title
            // 
            this.tbx_title.Location = new System.Drawing.Point(79, 35);
            this.tbx_title.Name = "tbx_title";
            this.tbx_title.Size = new System.Drawing.Size(348, 26);
            this.tbx_title.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题：";
            // 
            // btn_Modify
            // 
            this.btn_Modify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Modify.BackgroundImage")));
            this.btn_Modify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modify.Location = new System.Drawing.Point(504, 368);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 23);
            this.btn_Modify.TabIndex = 5;
            this.btn_Modify.Text = "修改";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.BackgroundImage")));
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add.Location = new System.Drawing.Point(504, 339);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "增加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // FormBookmarkManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyWebBrowser.Properties.Resources.dialog_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 466);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.lv_BookMarkList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Delete);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBookmarkManage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "书签管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBookmarkManage_FormClosing);
            this.Load += new System.EventHandler(this.FormAddFavorite_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ListView lv_BookMarkList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader ch_Tilte;
        private System.Windows.Forms.ColumnHeader ch_Addr;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.TextBox tbx_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_addr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Add;
    }
}