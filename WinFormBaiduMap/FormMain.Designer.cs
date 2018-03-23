namespace WindowsFormsApp1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTrackPoly = new System.Windows.Forms.Button();
            this.buttonTrack = new System.Windows.Forms.Button();
            this.buttonBasic = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonTrackPoly);
            this.groupBox1.Controls.Add(this.buttonTrack);
            this.groupBox1.Controls.Add(this.buttonBasic);
            this.groupBox1.Controls.Add(this.buttonInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选项";
            // 
            // buttonTrackPoly
            // 
            this.buttonTrackPoly.Location = new System.Drawing.Point(324, 21);
            this.buttonTrackPoly.Name = "buttonTrackPoly";
            this.buttonTrackPoly.Size = new System.Drawing.Size(75, 23);
            this.buttonTrackPoly.TabIndex = 1;
            this.buttonTrackPoly.Text = "轨迹折线";
            this.buttonTrackPoly.UseVisualStyleBackColor = true;
            this.buttonTrackPoly.Click += new System.EventHandler(this.buttonTrackPoly_Click);
            // 
            // buttonTrack
            // 
            this.buttonTrack.Location = new System.Drawing.Point(233, 21);
            this.buttonTrack.Name = "buttonTrack";
            this.buttonTrack.Size = new System.Drawing.Size(75, 23);
            this.buttonTrack.TabIndex = 1;
            this.buttonTrack.Text = "轨迹";
            this.buttonTrack.UseVisualStyleBackColor = true;
            this.buttonTrack.Click += new System.EventHandler(this.buttonTrack_Click);
            // 
            // buttonBasic
            // 
            this.buttonBasic.Location = new System.Drawing.Point(17, 21);
            this.buttonBasic.Name = "buttonBasic";
            this.buttonBasic.Size = new System.Drawing.Size(75, 23);
            this.buttonBasic.TabIndex = 0;
            this.buttonBasic.Text = "基本地图";
            this.buttonBasic.UseVisualStyleBackColor = true;
            this.buttonBasic.Click += new System.EventHandler(this.buttonBasic_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(108, 21);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(109, 23);
            this.buttonInfo.TabIndex = 0;
            this.buttonInfo.Text = "标注点信息窗口";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 72);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(634, 359);
            this.webBrowser1.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 443);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebBrowser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonTrack;
        private System.Windows.Forms.Button buttonBasic;
        private System.Windows.Forms.Button buttonTrackPoly;
    }
}

