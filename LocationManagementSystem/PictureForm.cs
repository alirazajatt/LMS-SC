using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationManagementSystem
{
    public partial class PictureForm : Form
    {
        PictureBox mImgBox = null;
        WebCam mWebCam = null;

        public PictureForm(ref PictureBox imgBox)
        {
            InitializeComponent();

            mImgBox = imgBox;
            mWebCam = new WebCam();
            mWebCam.InitializeWebCam(ref pbxSnapShot);
            mWebCam.Start();
        }

        private void btnTakePicture_Click(object sender, EventArgs e)
        {
            mImgBox.Image = pbxSnapShot.Image;
            mWebCam.Stop();
            this.Close();
        }
    }
}
