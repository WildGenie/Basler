using Basler.Pylon; 

namespace Basler
{
    partial class Basler
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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Basler");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basler));
            this.ContinueShotButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.OpenCamera = new System.Windows.Forms.Button();
            this.deviceList = new System.Windows.Forms.TreeView();
            this.StopCamera = new System.Windows.Forms.Button();
            this.CloseCamera = new System.Windows.Forms.Button();
            this.ZoomOut = new System.Windows.Forms.Button();
            this.ZoomIn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContinueShotButton
            // 
            this.ContinueShotButton.Enabled = false;
            this.ContinueShotButton.Location = new System.Drawing.Point(0, 69);
            this.ContinueShotButton.Name = "ContinueShotButton";
            this.ContinueShotButton.Size = new System.Drawing.Size(101, 63);
            this.ContinueShotButton.TabIndex = 0;
            this.ContinueShotButton.Text = "开始拍照";
            this.ContinueShotButton.UseVisualStyleBackColor = true;
            this.ContinueShotButton.Click += new System.EventHandler(this.ContinueShotBtnClick);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1124, 684);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // OpenCamera
            // 
            this.OpenCamera.Location = new System.Drawing.Point(0, 0);
            this.OpenCamera.Name = "OpenCamera";
            this.OpenCamera.Size = new System.Drawing.Size(101, 63);
            this.OpenCamera.TabIndex = 2;
            this.OpenCamera.Text = "打开相机";
            this.OpenCamera.UseVisualStyleBackColor = true;
            this.OpenCamera.Click += new System.EventHandler(this.OpenCamera_Click);
            // 
            // deviceList
            // 
            this.deviceList.Location = new System.Drawing.Point(0, 138);
            this.deviceList.Name = "deviceList";
            treeNode4.Name = "nodeBasler";
            treeNode4.Text = "Basler";
            this.deviceList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.deviceList.Size = new System.Drawing.Size(208, 104);
            this.deviceList.TabIndex = 3;
            this.deviceList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.deviceList_AfterSelect);
            // 
            // StopCamera
            // 
            this.StopCamera.Location = new System.Drawing.Point(107, 69);
            this.StopCamera.Name = "StopCamera";
            this.StopCamera.Size = new System.Drawing.Size(101, 63);
            this.StopCamera.TabIndex = 4;
            this.StopCamera.Text = "暂停拍照";
            this.StopCamera.UseVisualStyleBackColor = true;
            this.StopCamera.Click += new System.EventHandler(this.StopCamera_Click);
            // 
            // CloseCamera
            // 
            this.CloseCamera.Location = new System.Drawing.Point(107, 1);
            this.CloseCamera.Name = "CloseCamera";
            this.CloseCamera.Size = new System.Drawing.Size(101, 61);
            this.CloseCamera.TabIndex = 5;
            this.CloseCamera.Text = "关闭相机";
            this.CloseCamera.UseVisualStyleBackColor = true;
            this.CloseCamera.Click += new System.EventHandler(this.ColseCamera_Click);
            // 
            // ZoomOut
            // 
            this.ZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("ZoomOut.Image")));
            this.ZoomOut.Location = new System.Drawing.Point(0, 248);
            this.ZoomOut.Name = "ZoomOut";
            this.ZoomOut.Size = new System.Drawing.Size(77, 72);
            this.ZoomOut.TabIndex = 6;
            this.ZoomOut.UseVisualStyleBackColor = true;
            this.ZoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // ZoomIn
            // 
            this.ZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("ZoomIn.Image")));
            this.ZoomIn.Location = new System.Drawing.Point(107, 248);
            this.ZoomIn.Name = "ZoomIn";
            this.ZoomIn.Size = new System.Drawing.Size(74, 72);
            this.ZoomIn.TabIndex = 7;
            this.ZoomIn.UseVisualStyleBackColor = true;
            this.ZoomIn.Click += new System.EventHandler(this.ZoomIn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 326);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 51);
            this.textBox1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(214, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 684);
            this.panel1.TabIndex = 9;
            // 
            // Basler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 697);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ZoomIn);
            this.Controls.Add(this.ZoomOut);
            this.Controls.Add(this.CloseCamera);
            this.Controls.Add(this.StopCamera);
            this.Controls.Add(this.deviceList);
            this.Controls.Add(this.OpenCamera);
            this.Controls.Add(this.ContinueShotButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Basler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Basler_FormClosed);
            this.Shown += new System.EventHandler(this.Basler_FormShown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ContinueShotButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button OpenCamera;
        private System.Windows.Forms.TreeView deviceList;
        private System.Windows.Forms.Button StopCamera;
        private System.Windows.Forms.Button CloseCamera;
        private System.Windows.Forms.Button ZoomOut;
        private System.Windows.Forms.Button ZoomIn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

