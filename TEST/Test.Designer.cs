namespace TEST
{
    partial class Test
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
            this.ZoomOut = new System.Windows.Forms.Button();
            this.ZoomIn = new System.Windows.Forms.Button();
            this.LoadLocalPicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SavePicture = new System.Windows.Forms.Button();
            this.LoadOnlinePicture = new System.Windows.Forms.Button();
            this.SavePicture_ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZoomOut
            // 
            this.ZoomOut.Location = new System.Drawing.Point(0, 90);
            this.ZoomOut.Name = "ZoomOut";
            this.ZoomOut.Size = new System.Drawing.Size(75, 23);
            this.ZoomOut.TabIndex = 0;
            this.ZoomOut.Text = "放大";
            this.ZoomOut.UseVisualStyleBackColor = true;
            this.ZoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // ZoomIn
            // 
            this.ZoomIn.Location = new System.Drawing.Point(0, 119);
            this.ZoomIn.Name = "ZoomIn";
            this.ZoomIn.Size = new System.Drawing.Size(75, 23);
            this.ZoomIn.TabIndex = 1;
            this.ZoomIn.Text = "缩小";
            this.ZoomIn.UseVisualStyleBackColor = true;
            this.ZoomIn.Click += new System.EventHandler(this.ZoomIn_Click);
            // 
            // LoadLocalPicture
            // 
            this.LoadLocalPicture.Location = new System.Drawing.Point(0, 0);
            this.LoadLocalPicture.Name = "LoadLocalPicture";
            this.LoadLocalPicture.Size = new System.Drawing.Size(88, 23);
            this.LoadLocalPicture.TabIndex = 3;
            this.LoadLocalPicture.Text = "加载本地图片";
            this.LoadLocalPicture.UseVisualStyleBackColor = true;
            this.LoadLocalPicture.Click += new System.EventHandler(this.LoadPicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 322);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(138, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 322);
            this.panel1.TabIndex = 4;
            // 
            // SavePicture
            // 
            this.SavePicture.Location = new System.Drawing.Point(0, 148);
            this.SavePicture.Name = "SavePicture";
            this.SavePicture.Size = new System.Drawing.Size(75, 23);
            this.SavePicture.TabIndex = 5;
            this.SavePicture.Text = "保存图片";
            this.SavePicture.UseVisualStyleBackColor = true;
            this.SavePicture.Click += new System.EventHandler(this.SavePicture_Click);
            // 
            // LoadOnlinePicture
            // 
            this.LoadOnlinePicture.Location = new System.Drawing.Point(0, 29);
            this.LoadOnlinePicture.Name = "LoadOnlinePicture";
            this.LoadOnlinePicture.Size = new System.Drawing.Size(88, 23);
            this.LoadOnlinePicture.TabIndex = 6;
            this.LoadOnlinePicture.Text = "加载网络图片";
            this.LoadOnlinePicture.UseVisualStyleBackColor = true;
            this.LoadOnlinePicture.Click += new System.EventHandler(this.LoadOnlinePicture_Click);
            // 
            // SavePicture_
            // 
            this.SavePicture_.Location = new System.Drawing.Point(0, 58);
            this.SavePicture_.Name = "SavePicture_";
            this.SavePicture_.Size = new System.Drawing.Size(75, 23);
            this.SavePicture_.TabIndex = 7;
            this.SavePicture_.Text = "保存图片";
            this.SavePicture_.UseVisualStyleBackColor = true;
            this.SavePicture_.Click += new System.EventHandler(this.SavePicture__Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(774, 334);
            this.Controls.Add(this.SavePicture_);
            this.Controls.Add(this.LoadOnlinePicture);
            this.Controls.Add(this.SavePicture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoadLocalPicture);
            this.Controls.Add(this.ZoomIn);
            this.Controls.Add(this.ZoomOut);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ZoomOut;
        private System.Windows.Forms.Button ZoomIn;
        private System.Windows.Forms.Button LoadLocalPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SavePicture;
        private System.Windows.Forms.Button LoadOnlinePicture;
        private System.Windows.Forms.Button SavePicture_;
    }
}

