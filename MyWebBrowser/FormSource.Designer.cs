namespace MyWebBrowser
{
    partial class FormSource
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
            this.rtb_source = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtb_source
            // 
            this.rtb_source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_source.Location = new System.Drawing.Point(0, 0);
            this.rtb_source.Name = "rtb_source";
            this.rtb_source.Size = new System.Drawing.Size(493, 544);
            this.rtb_source.TabIndex = 0;
            this.rtb_source.Text = "";
            // 
            // FormSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 544);
            this.Controls.Add(this.rtb_source);
            this.Name = "FormSource";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "源文件";
            this.Load += new System.EventHandler(this.FormSource_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_source;
    }
}