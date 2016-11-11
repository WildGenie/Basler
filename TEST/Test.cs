using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Basler.Pylon;

namespace TEST
{
    public partial class Test : Form
    {
        OpenFileDialog imageFileDialog = new OpenFileDialog();

        public Test()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imageFileDialog.FileOk += ImageFileDialog_FileOk;

            //panel1.Height = this.Height - LoadPicture.Height;
            //panel1.Width = this.Width - LoadPicture.Width;

            //pictureBox1.Height = panel1.Height;
            //pictureBox1.Width = panel1.Width;
        }

        private void ImageFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<CancelEventArgs>(ImageFileDialog_FileOk), sender, e);
            }
            try
            {
                Bitmap tempBitmap = new Bitmap(imageFileDialog.FileName);
                pictureBox1.Height = tempBitmap.Height;
                pictureBox1.Width = tempBitmap.Width;
                pictureBox1.Image = tempBitmap;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void ZoomOut_Click(object sender, EventArgs e)
        {

        }

        private void ZoomIn_Click(object sender, EventArgs e)
        {

        }

        private void LoadPicture_Click(object sender, EventArgs e)
        {
            try
            {
                imageFileDialog.Multiselect = false;
                imageFileDialog.Filter = "指定文件(*.bmp*)|*.bmp*";
                imageFileDialog.ShowDialog();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void SavePicture_Click(object sender, EventArgs e)
        {
       //     Bitmap tempBitmap = pictureBox1.
        }
    }
}
