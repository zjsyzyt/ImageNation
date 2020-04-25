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
        //public MainForm mainForm { get; set; }
        public MainForm mainForm;

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
            : this()//调用其他形式（没有参数的）的构造函数
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


            //同步MainForm中
            //this.CheckBoxAlgo2GrayScale.CheckState = mainForm.CheckBoxAlgo2GrayScale.CheckBoxAlgo2GrayScale.Checkstate;

            //CheckBox state_CheckBoxAlgo1Gauss;
            //CheckBox state_CheckBoxAlgo1Gauss=mainForm.State_CheckBoxAlgo1Gauss();
            this.CheckBoxAlgo1Gauss.CheckState = mainForm.State_CheckBoxAlgo1Gauss().CheckState;
            this.CheckBoxAlgo2GrayScale.CheckState = mainForm.State_CheckBoxAlgo2GrayScale().CheckState;
            State_CheckBoxAlgo3GaussianBlur();
            State_CheckBoxAlgo4PepperNoise();

            this.ComboBox_GrayScale.Enabled = mainForm.State_ComboBox_GrayScale().Enabled;
            this.ComboBox_GrayScale.SelectedIndex = mainForm.State_ComboBox_GrayScale().SelectedIndex;
            this.ComboBox_PepperNoise.Enabled = mainForm.State_ComboBox_PepperNoise().Enabled;
            this.ComboBox_PepperNoise.SelectedIndex = mainForm.State_ComboBox_PepperNoise().SelectedIndex;


        }

        //将私有的勾选状态转成可以用公有的方法获取;
        //mainForm和previewForm之间状态同步
        //public CheckBox State_CheckBoxAlgo1Gauss
        //{
        //    set
        //    {
        //        this.CheckBoxAlgo1Gauss.CheckState = mainForm.State_CheckBoxAlgo1Gauss().CheckState;
        //    }
        //    get
        //    {
        //        return this.CheckBoxAlgo1Gauss;
        //    }
        //}

        public CheckBox State_CheckBoxAlgo2GrayScale()
        {
            //this.CheckBoxAlgo2GrayScale.CheckState = mainForm.State_CheckBoxAlgo2GrayScale().CheckState;
            return this.CheckBoxAlgo2GrayScale;
        }

        public CheckBox State_CheckBoxAlgo3GaussianBlur()
        {
            this.CheckBoxAlgo3GaussianBlur.CheckState = mainForm.State_CheckBoxAlgo3GaussianBlur().CheckState;
            return this.CheckBoxAlgo3GaussianBlur;
        }

        public CheckBox State_CheckBoxAlgo4PepperNoise()
        {
            this.CheckBoxAlgo4PepperNoise.CheckState = mainForm.State_CheckBoxAlgo4PepperNoise().CheckState;
            return this.CheckBoxAlgo4PepperNoise;
        }

        //将算法勾选框状态同步到MainForm
        private void CheckBoxAlgo1Gauss_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.State_CheckBoxAlgo1Gauss().CheckState = this.CheckBoxAlgo1Gauss.CheckState;
        }


        private void CheckBoxAlgo2GrayScale_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.State_CheckBoxAlgo2GrayScale().CheckState = this.State_CheckBoxAlgo2GrayScale().CheckState;
        }

        private void CheckBoxAlgo3GaussianBlur_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.State_CheckBoxAlgo3GaussianBlur().CheckState = this.CheckBoxAlgo3GaussianBlur.CheckState;
        }

        private void CheckBoxAlgo4PepperNoise_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.State_CheckBoxAlgo4PepperNoise().CheckState = this.CheckBoxAlgo4PepperNoise.CheckState;
        }

        private void ComboBox_GrayScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainForm.State_ComboBox_GrayScale().SelectedIndex = this.ComboBox_GrayScale.SelectedIndex;
            TrackBar_ParaSlope.Enabled = true;
            TrackBar_ParaIntercept.Enabled = true;
            Value_ParaSlope_PreView.Enabled = true;
            Value_ParaIntercept_PreView.Enabled = true;
            Button_SetParaSlopeMin.Enabled = true;
            Button_SetParaSlopeMax.Enabled = true;
            Button_SetParaInterceptMin.Enabled = true;
            Button_SetParaInterceptMax.Enabled = true;

            switch (ComboBox_GrayScale.SelectedIndex)
            {
                case 0://增大对比度
                    Value_ParaSlope_PreView.Minimum = 1;
                    Value_ParaSlope_PreView.Maximum = 5;
                    Value_ParaSlope_PreView.DecimalPlaces = 1;
                    Value_ParaSlope_PreView.Increment = 0.2M;
                    TrackBar_ParaSlope.Maximum = 20;
                    //TrackBar_ParaSlope.Value = 0;
                    //Value_ParaSlope_PreView.Value = 1;
                    break;
                case 1://减小对比度
                    Value_ParaSlope_PreView.Minimum = 0;
                    Value_ParaSlope_PreView.Maximum = 1;
                    Value_ParaSlope_PreView.DecimalPlaces = 1;
                    Value_ParaSlope_PreView.Increment = 0.1M;
                    TrackBar_ParaSlope.Maximum = 10;
                    //TrackBar_ParaSlope.Value = 0;
                    //Value_ParaSlope_PreView.Value = 1;
                    break;
                case 2://倒置
                    Value_ParaSlope_PreView.Minimum = -1;
                    Value_ParaSlope_PreView.Maximum = -1;
                    Value_ParaSlope_PreView.Value = -1;
                    Value_ParaIntercept_PreView.Value = 255;
                    //TrackBar_ParaSlope.Value = -1;
                    //TrackBar_ParaIntercept.Value = 255;
                    TrackBar_ParaSlope.Enabled = false;
                    TrackBar_ParaIntercept.Enabled = false;
                    Value_ParaSlope_PreView.Enabled = false;
                    Value_ParaIntercept_PreView.Enabled = false;

                    Button_SetParaSlopeMin.Enabled = false;
                    Button_SetParaSlopeMax.Enabled = false;
                    Button_SetParaInterceptMin.Enabled = false;
                    Button_SetParaInterceptMax.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void ComboBox_PepperNoise_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainForm.State_ComboBox_PepperNoise().SelectedIndex = this.ComboBox_PepperNoise.SelectedIndex;
        }

        //委托方法传递参数到MainForm
        public delegate void SendPara(decimal para);
        public event SendPara SendToMainForm;

        private void Button_SetParaInterceptMin_Click(object sender, EventArgs e)
        {
            SendToMainForm(this.Value_ParaSlope_PreView.Value);

        }

        private void Button_SetParaInterceptMax_Click(object sender, EventArgs e)
        {

        }

        private void Button_SetParaSlopeMin_Click(object sender, EventArgs e)
        {

        }

        private void Button_SetParaSlopeMax_Click(object sender, EventArgs e)
        {

        }

        private void TrackBar_ParaSlope_Scroll(object sender, EventArgs e)
        {
            switch (ComboBox_GrayScale.SelectedIndex)
            {
                case 0://增大对比度
                    Value_ParaSlope_PreView.Value = TrackBar_ParaSlope.Value * 0.2M + 1;
                    break;
                case 1://减小对比度
                    Value_ParaSlope_PreView.Value = 1- TrackBar_ParaSlope.Value * 0.1M;
                    break;
                default:
                    break;
            }
        }

        private void TrackBar_ParaIntercept_Scroll(object sender, EventArgs e)
        {
            Value_ParaIntercept_PreView.Value = TrackBar_ParaIntercept.Value;
        }
    }
}
