namespace LaserServer2017_2_3
{
    partial class Form1
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
            this.LogLv = new System.Windows.Forms.ListBox();
            this.startListenBtn = new System.Windows.Forms.Button();
            this.stopListenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogLv
            // 
            this.LogLv.FormattingEnabled = true;
            this.LogLv.ItemHeight = 12;
            this.LogLv.Location = new System.Drawing.Point(12, 12);
            this.LogLv.Name = "LogLv";
            this.LogLv.Size = new System.Drawing.Size(284, 424);
            this.LogLv.TabIndex = 1;
            // 
            // startListenBtn
            // 
            this.startListenBtn.Location = new System.Drawing.Point(811, 12);
            this.startListenBtn.Name = "startListenBtn";
            this.startListenBtn.Size = new System.Drawing.Size(92, 33);
            this.startListenBtn.TabIndex = 2;
            this.startListenBtn.Text = "开始监听";
            this.startListenBtn.UseVisualStyleBackColor = true;
            this.startListenBtn.Click += new System.EventHandler(this.startListenBtn_Click);
            // 
            // stopListenBtn
            // 
            this.stopListenBtn.Location = new System.Drawing.Point(811, 80);
            this.stopListenBtn.Name = "stopListenBtn";
            this.stopListenBtn.Size = new System.Drawing.Size(92, 33);
            this.stopListenBtn.TabIndex = 3;
            this.stopListenBtn.Text = "停止监听";
            this.stopListenBtn.UseVisualStyleBackColor = true;
            this.stopListenBtn.Click += new System.EventHandler(this.stopListenBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 444);
            this.Controls.Add(this.stopListenBtn);
            this.Controls.Add(this.startListenBtn);
            this.Controls.Add(this.LogLv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LogLv;
        private System.Windows.Forms.Button startListenBtn;
        private System.Windows.Forms.Button stopListenBtn;

    }
}

