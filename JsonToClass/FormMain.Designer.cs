namespace JsonToClass
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.webBrowser_JsonToClass = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser_JsonToClass
            // 
            this.webBrowser_JsonToClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_JsonToClass.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_JsonToClass.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_JsonToClass.Name = "webBrowser_JsonToClass";
            this.webBrowser_JsonToClass.ScriptErrorsSuppressed = true;
            this.webBrowser_JsonToClass.Size = new System.Drawing.Size(581, 368);
            this.webBrowser_JsonToClass.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 368);
            this.Controls.Add(this.webBrowser_JsonToClass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Json转Class";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser_JsonToClass;
    }
}

