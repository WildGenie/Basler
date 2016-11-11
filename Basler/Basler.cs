using System;
using System.Drawing;
using System.Windows.Forms;
using Basler.Pylon;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Collections;

namespace Basler
{
    public partial class Basler : Form
    {
        private Camera myCamera = null;
        private Stopwatch myStopWatch = new Stopwatch();
        private PixelDataConverter converter = new PixelDataConverter();

        public Basler()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打开窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Basler_FormShown(object sender, EventArgs e)
        {
            try
            {
                //打开窗口后刷新相机列表
                RefreshDeviceList();
            }
            catch (Exception E)
            {
                ShowException(sender, E);
            }
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Basler_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new EventHandler<FormClosedEventArgs>(Basler_FormClosed), sender, e);
                    return;
                }
                DestroyCamera();
            }
            catch (Exception E)
            {
                ShowException(sender, E);
            }
        }

        private void ShowException(object sender,Exception E)
        {
            MessageBox.Show($"异常源 : {sender.ToString()}\r\n异常信息 : {E.Message}", "警告");
        }

        private void ShowException(Exception E)
        {
            MessageBox.Show($"异常源 : {E.Source}\r\n异常信息 : {E.Message}", "警告");
        }
    }
}
