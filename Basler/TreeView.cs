using System;
using System.Drawing;
using System.Windows.Forms;
using Basler.Pylon;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Collections.Generic;

/// <summary>
/// 相机设备列表功能定义 & 描述
/// </summary>
namespace Basler
{
    public partial class Basler : Form
    {
        /// <summary>
        /// 选中列表项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deviceList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<TreeViewEventArgs>(deviceList_AfterSelect), sender, e);
                return;
            }
            try
            {
                // 选中的不是Basler标题
                if (e.Node != deviceList.Nodes[0])
                {
                    // 关闭其他未选中的相机
                    foreach (TreeNode tempNode in deviceList.Nodes[0].Nodes)
                    {
                        // 判断是否是当前选中的相机
                        Camera tempCamera = (Camera)tempNode.Tag;
                        if (tempCamera != myCamera)
                            tempCamera.Close();
                    }
                    // 判断是否重复点击了原来的相机标签
                    if (myCamera != null)
                    {
                        // 如果当前选择的相机不是正在运行的相机
                        if (myCamera != (Camera)(e.Node.Tag))
                        {
                            // 打开
                        }
                        //else
                        //{
                        //    // 如果当前相机正在运行
                        //    if (myCamera.IsOpen)
                        //    {
                        //        // 关闭 ... 按钮
                        //        if (myCamera.IsOpen)
                        //        {
                        //            if (myCamera.Parameters[PLCamera.ac])
                        //                ButtonState(false, true, true, true);
                        //        }
                        //        else
                        //            ButtonState(true, true, true, true);
                        //    }
                        //}
                    }
                    myCamera = (Camera)(e.Node.Tag);
                }
            }
            catch (Exception E)
            {
                ShowException(sender, E);
            }

        }

        /// <summary>
        /// 刷新设备列表
        /// </summary>
        private void RefreshDeviceList()
        {
            try
            {
                // 先删除列表中的所有相机
                deviceList.Nodes[0].Nodes.Clear();
                // 再添加已探测到的相机
                // 建立链表存放所有已经找到的 CameraInfo
                List<ICameraInfo> allCamerasInfo = CameraFinder.Enumerate();
                foreach (ICameraInfo cameraInfo in allCamerasInfo)
                {
                    Camera tempCamera = new Camera(cameraInfo);
                    TreeNode tempNode = new TreeNode(cameraInfo[CameraInfoKey.ModelName]);
                    //在 nodeBasler 节点下新增节点
                    tempNode.Tag = tempCamera;
                    deviceList.Nodes[0].Nodes.Add(tempNode);
                }
                //刷新后默认的相机为第一个相机
                myCamera = (Camera)(deviceList.Nodes[0].FirstNode.Tag);
            }
            catch (Exception E)
            {
                ShowException(E);
            }
        }
    }
}