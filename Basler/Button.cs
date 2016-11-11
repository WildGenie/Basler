using System;
using System.Drawing;
using System.Windows.Forms;
using Basler.Pylon;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Collections.Generic;


/// <summary>
/// 按钮功能定义 & 描述
/// </summary>
namespace Basler
{
    public partial class Basler : Form 
    {
        /// <summary>
        /// 连续拍照
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContinueShotBtnClick(object sender, EventArgs e)
        {
            ContinueShot();
            ButtonState(false, false, true, true);
        }

        /// <summary>
        /// 打开相机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenCamera_Click(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<EventArgs>(OpenCamera_Click), sender, e);
                return;
            }
            try
            {
                myCamera.CameraOpened += Configuration.AcquireContinuous;
                // 添加事件处理函数
                myCamera.ConnectionLost += OnConnectionLost;
                myCamera.CameraOpened += OnCameraOpened;
                myCamera.StreamGrabber.ImageGrabbed += OnGrabImage;
                myCamera.StreamGrabber.GrabStarted += OnGrabStarted;

                // 打开相机
                myCamera.Open();

                ButtonState(false, true, false, true);
            }
            catch (Exception E)
            {
                ShowException(sender, E);
            }
        }

        /// <summary>
        /// 暂停相机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopCamera_Click(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<EventArgs>(StopCamera_Click), sender, e);
                return;
            }
            try
            {
                myCamera.StreamGrabber.Stop();
                ButtonState(false, true, false, true);
            }
            catch (Exception E)
            {
                ShowException(sender, E);
            }
        }

        /// <summary>
        /// 关闭相机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColseCamera_Click(object sender, EventArgs e)
        {
            myCamera.Close();
            ButtonState(true, false, false, false);
        }

        /// <summary>
        /// 按钮状态控制
        /// </summary>
        /// <param name="OpenCamBtnSta"> 打开相机按钮 </param>
        /// <param name="CtnuShotBtnSta"> 连续拍照按钮 </param>
        /// /// <param name="ClsCamBtnSta"> 关闭拍照按钮 </param>
        private void ButtonState(bool OpenCamBtnSta, bool CtnuShotBtnSta, bool StopCameraSta, bool ClsCamBtnSta)
        {
            OpenCamera.Enabled = OpenCamBtnSta;
            ContinueShotButton.Enabled = CtnuShotBtnSta;
            StopCamera.Enabled = StopCameraSta;
            CloseCamera.Enabled = ClsCamBtnSta;
        }

        /// <summary>
        /// 按钮状态控制
        /// </summary>
        /// <param name="OpenCamBtnSta"> 打开相机按钮 </param>
        /// <param name="CtnuShotBtnSta"> 连续拍照按钮 </param>
        private void ButtonState(bool OpenCamBtnSta, bool CtnuShotBtnSta)
        {
            OpenCamera.Enabled = OpenCamBtnSta;
            ContinueShotButton.Enabled = CtnuShotBtnSta;
        }

        private void ZoomOut_Click(object sender, EventArgs e)
        {
            pictureBox.Width = (int)((float)(pictureBox.Width) * 1.2);
            pictureBox.Height = (int)((float)(pictureBox.Height) * 1.2);
        }

        private void ZoomIn_Click(object sender, EventArgs e)
        {
            pictureBox.Width = (int)((float)(pictureBox.Width) / 1.2);
            pictureBox.Height = (int)((float)(pictureBox.Height) / 1.2);
        }
    }
}