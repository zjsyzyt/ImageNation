using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace ImageNation
{
    public partial class PreviewForm : Form
    {
        MainForm mainForm;

        public PreviewForm()
        {
            InitializeComponent();
            //imgOrigin;
            //Mat SrcImg = new MainForm.imgOrigin;
            //this.pictureBox_SrcImg.Show(MainForm.imgOrigin);

        }

        // 重载构造函数
        // 构造函数参数 mainForm：对MainForm实例引用
        public PreviewForm(MainForm mainForm)
            : this()
        {
            // 建立对MainForm实例的引用
            this.mainForm = mainForm;
            // 通过mainForm.imgOrigin属性获取MainForm中的图像
            //pictureBox_SrcImg.Image = mainForm.imgOrigin.ConvertTo();


            Mat imgOrigin = mainForm.ImgOriginPublic;//.CvtColor(ColorConversionCodes.GRAY2RGBA);
            //Mat imgOrigin = mainForm.imgOrigin.Clone();

            //Bitmap hBitmap = new Bitmap(imgOrigin.Cols, imgOrigin.Rows, imgOrigin.Step(), System.Drawing.Imaging.PixelFormat.Format8bppIndexed, imgOrigin.Data);
            //Bitmap hBitmap = new Bitmap(imgOrigin.Cols, imgOrigin.Rows, (int)imgOrigin.Step(), System.Drawing.Imaging.PixelFormat.Format8bppIndexed, imgOrigin.Data);
            

            Bitmap hBitmap = BitmapConverter.ToBitmap(imgOrigin);
            pictureBox_SrcImg.Image = hBitmap;

        }
    }
}
