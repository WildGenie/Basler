using System;
using System.Drawing;
using System.Windows.Forms;
using Basler.Pylon;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Collections.Generic;

/// <summary>
/// 相机功能定义 & 描述
/// </summary>
namespace Basler
{
    public partial class Basler : Form
    {
        /// <summary>
        /// 成功打开相机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCameraOpened(Object sender, EventArgs e)
        {
            try
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new EventHandler<EventArgs>(OnCameraOpened), sender, e);
                    return;
                }

                pictureBox.Height = (int)myCamera.Parameters[PLCamera.Height].GetValue();
                pictureBox.Width = (int)myCamera.Parameters[PLCamera.Width].GetValue();
                ButtonState(false, true, false, true);
            }
            catch (Exception E)
            {
                ShowException(sender, E);
            }
        }

        /// <summary>
        /// 开始抓取图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnGrabStarted(object sender, EventArgs e)
        {
            try
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new EventHandler<EventArgs>(OnGrabStarted), sender, e);
                    return;
                }
                myStopWatch.Reset();
            }
            catch (Exception E)
            {
                ShowException(sender, E);
            }
        }

        /// <summary>
        /// 抓取到图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnGrabImage(object sender, ImageGrabbedEventArgs e)
        {
            //线程处理？
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<ImageGrabbedEventArgs>(OnGrabImage), sender, e.Clone());
                return;
            }
            try
            {
                IGrabResult grabResult = e.GrabResult;
                if (grabResult.IsValid)
                {
                    if (!myStopWatch.IsRunning || myStopWatch.ElapsedMilliseconds > 33)
                    {
                        myStopWatch.Restart();

                        // 实例化位图对象,图像大小指定为 相机已抓取图象的大小,此处内存未被赋值
                        Bitmap myBitmap = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format32bppRgb);
                        textBox1.Text = $"height:{grabResult.Height}\r\n" + $"width:{grabResult.Width}";
                        // 将 myBitmap 锁定到 myBitmapData 内存中以便进行位图像素格式转换
                        BitmapData myBitmapData = myBitmap.LockBits(new Rectangle(0, 0, myBitmap.Width, myBitmap.Height), ImageLockMode.ReadWrite, myBitmap.PixelFormat);
                        // 设定转换的图像像素格式
                        converter.OutputPixelFormat = PixelType.BGRA8packed;
                        // 获取 锁定的图象内存指针
                        IntPtr ptrBmp = myBitmapData.Scan0;
                        // 将grabResult中的数据按照指定的内存大小及像素格式转换到ptrBmp所指向(myBitmapData)的内存区域。
                        converter.Convert(ptrBmp, myBitmapData.Stride * myBitmap.Height, grabResult);
                        // 解锁内存
                        myBitmap.UnlockBits(myBitmapData);
                        //显示新的图象
                        pictureBox.Image = myBitmap;
                    }
                }
            }
            catch (Exception E)
            {
                ShowException(sender, E);
            }
            finally
            {
                // Dispose the grab result if needed for returning it to the grab loop.
                e.DisposeGrabResultIfClone();
            }
        }

        /// <summary>
        /// 丢失连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnConnectionLost(object sender, EventArgs e)
        {
            try
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new EventHandler<EventArgs>(OnConnectionLost), sender, e);
                    return;
                }
                // 释放相机资源
                DestroyCamera();
                // 刷新设备列表
                RefreshDeviceList();
                // 关闭按钮
                ButtonState(false, false, false, false);
            }
            catch (Exception E)
            {
                ShowException(sender, E);
            }
        }

        /// <summary>
        /// 释放相机资源
        /// </summary>
        private void DestroyCamera()
        {
            try
            {
                if (myCamera != null)
                {
                    myCamera.Close();
                    myCamera.Dispose();
                    myCamera = null;
                }
            }
            catch (Exception E)
            {
                ShowException(E);
            }
        }

        /// <summary>
        /// 设置相机为连续获取模式
        /// </summary>
        private void ContinueShot()
        {
            try
            {
                // 将相机设置为连续获取模式
                myCamera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.Continuous);
                // 开始抓取图像
                myCamera.StreamGrabber.Start(GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
            }
            catch (Exception E)
            {
                ShowException(E);
            }
        }
    }
}