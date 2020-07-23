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
        AutoSizeFormClass asc = new AutoSizeFormClass();

        //public MainForm mainForm { get; set; }
        public MainForm mainForm;

        public PreviewForm()
        {
            InitializeComponent();
            //imgOrigin;
            //Mat SrcImg = new MainForm.imgOrigin;
            //this.pictureBox_SrcImg.Show(MainForm.imgOrigin);

        }
        //2. 为窗体添加Load事件，并在其方法MainForm_Load中，调用类的初始化方法，记录窗体和其控件的初始位置和大小  
        private void PreViewForm_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
        }
        //3.为窗体添加SizeChanged事件，并在其方法MainForm_SizeChanged中，调用类的自适应方法，完成自适应  
        private void PreViewForm_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private Mat imgOrigin;
        ImgProcess img = new ImgProcess();


        // 重载构造函数
        // 构造函数参数 mainForm：对MainForm实例引用
        public PreviewForm(MainForm mainForm)
            : this()//调用其他形式（没有参数的）的构造函数
        {
            // 建立对MainForm实例的引用
            this.mainForm = mainForm;
            // 通过mainForm.imgOrigin属性获取MainForm中的图像
            //pictureBox_SrcImg.Image = mainForm.imgOrigin.ConvertTo();

            imgOrigin = mainForm.ImgOriginPublic;//.CvtColor(ColorConversionCodes.GRAY2RGBA);
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
            this.CheckBoxOffsetX.CheckState = mainForm.State_CheckBoxOffsetX().CheckState;
            this.CheckBoxOffsetY.CheckState = mainForm.State_CheckBoxOffsetY().CheckState;
            this.CheckBoxRotate.CheckState = mainForm.State_CheckBoxRotate().CheckState;
            this.CheckBoxPyrDown.CheckState = mainForm.State_CheckBoxPyrDown().CheckState;

            this.ComboBox_GrayScale.Enabled = mainForm.State_ComboBox_GrayScale().Enabled;
            this.ComboBox_GrayScale.SelectedIndex = mainForm.State_ComboBox_GrayScale().SelectedIndex;
            this.ComboBox_PepperNoise.Enabled = mainForm.State_ComboBox_PepperNoise().Enabled;
            this.ComboBox_PepperNoise.SelectedIndex = mainForm.State_ComboBox_PepperNoise().SelectedIndex;


        }

        private void Button_PreviewForm_Click(object sender, EventArgs e)
        {
            Mat transImg = imgOrigin.Clone();
            if (CheckBoxAlgo1Gauss.Checked)
            {
                double miuVal = (double)Value_ParaMiu_PreView.Value;
                double sigmaVal = (double)Value_ParaSigma_PreView.Value;
                transImg = img.GaussianNoise(transImg, miuVal, sigmaVal);
            }

            if (CheckBoxAlgo2GrayScale.Checked)
            {
                double slopeVal = (double)Value_ParaSlope_PreView.Value;
                double interceptVal = (double)Value_ParaIntercept_PreView.Value;
                transImg = img.GrayScale(transImg, slopeVal, interceptVal);
            }

            if (CheckBoxAlgo3GaussianBlur.Checked)
            {
                double sigma2Val = (double)Value_ParaSigma2_PreView.Value;
                transImg = img.LowPassFreq(transImg, sigma2Val);
            }

            if (CheckBoxAlgo4PepperNoise.Checked)
            {
                double coeffVal = (double)Value_ParaNoiseCoeff_PreView.Value;
                transImg = img.PepperNoise(transImg, coeffVal, ComboBox_PepperNoise.SelectedIndex);
            }

            if (CheckBoxOffsetX.Checked || CheckBoxOffsetY.Checked)
            {
                double offsetx, offsety;
                if (CheckBoxOffsetX.Checked)
                {
                    offsetx = (double)Value_ParaOffsetX.Value;
                }
                else
                {
                    offsetx = 0;
                }

                if (CheckBoxOffsetY.Checked)
                {
                    offsety = (double)Value_ParaOffsetY.Value;
                }
                else
                {
                    offsety = 0;
                }

                transImg = img.ImgAffine_Offset(transImg, offsetx, offsety);
            }

            if (CheckBoxRotate.Checked)
            {
                double angleVal = (double)Value_ParaAngle.Value;
                transImg = img.ImgAffine_Rotate(transImg, angleVal);
            }

            if (CheckBoxPyrDown.Checked)
            {
                int pyrDownNum = (int)Value_ParaPyrDownCoeff.Value;
                transImg = img.ImgPyrDown(transImg, pyrDownNum);
            }

            Mat imgResult = transImg.Clone();
            Bitmap hBitmap2 = BitmapConverter.ToBitmap(imgResult);
            pictureBox_DstImg.Image = hBitmap2;

        }

        private void Button_PreviewFormExit_Click(object sender, EventArgs e)
        {
            Close();
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
            this.ComboBox_GrayScale.Enabled = mainForm.State_ComboBox_GrayScale().Enabled;//将下拉框状态同步更新到预览界面
        }

        private void CheckBoxAlgo3GaussianBlur_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.State_CheckBoxAlgo3GaussianBlur().CheckState = this.CheckBoxAlgo3GaussianBlur.CheckState;
        }

        private void CheckBoxAlgo4PepperNoise_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.State_CheckBoxAlgo4PepperNoise().CheckState = this.CheckBoxAlgo4PepperNoise.CheckState;
            this.ComboBox_PepperNoise.Enabled = mainForm.State_ComboBox_PepperNoise().Enabled;//将下拉框状态同步更新到预览界面
        }

        private void ComboBox_PepperNoise_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainForm.State_ComboBox_PepperNoise().SelectedIndex = this.ComboBox_PepperNoise.SelectedIndex;
        }

        private void CheckBoxOffsetX_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.State_CheckBoxOffsetX().CheckState = this.CheckBoxOffsetX.CheckState;
        }

        private void CheckBoxOffsetY_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.State_CheckBoxOffsetY().CheckState = this.CheckBoxOffsetY.CheckState;
        }

        private void CheckBoxRotate_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.State_CheckBoxRotate().CheckState = this.CheckBoxRotate.CheckState;
        }

        private void CheckBoxPyrDown_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.State_CheckBoxPyrDown().CheckState = this.CheckBoxPyrDown.CheckState;
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

        

        //灰度变化
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

        private void Value_ParaSlope_PreView_ValueChanged(object sender, EventArgs e)
        {
            switch (ComboBox_GrayScale.SelectedIndex)
            {
                case 0://增大对比度
                    TrackBar_ParaSlope.Value = (int)(5 * (Value_ParaSlope_PreView.Value - 1));
                    break;
                case 1://减小对比度
                    TrackBar_ParaSlope.Value = (int)(10 * (1 - Value_ParaSlope_PreView.Value));
                    break;
                default:
                    break;
            }
        }

        private void TrackBar_ParaIntercept_Scroll(object sender, EventArgs e)
        {
            Value_ParaIntercept_PreView.Value = TrackBar_ParaIntercept.Value;
        }

        private void Value_ParaIntercept_PreView_ValueChanged(object sender, EventArgs e)
        {
            TrackBar_ParaIntercept.Value = (int)(Value_ParaIntercept_PreView.Value);
            //TrackBar_ParaIntercept.Value = Convert.ToInt32(Value_ParaIntercept_PreView.Value);
            
        }


        //高斯噪声
        private void TrackBar_ParaMiu_Scroll(object sender, EventArgs e)
        {
            Value_ParaMiu_PreView.Value = TrackBar_ParaMiu.Value;
        }

        private void Value_ParaMiu_PreView_ValueChanged(object sender, EventArgs e)
        {
            TrackBar_ParaMiu.Value = (int)(Value_ParaMiu_PreView.Value);
        }

        private void Value_ParaSigma_PreView_ValueChanged(object sender, EventArgs e)
        {
            TrackBar_ParaSigma.Value = (int)(10 * (Value_ParaSigma_PreView.Value - 1));
        }

        private void TrackBar_ParaSigma_Scroll(object sender, EventArgs e)
        {
            Value_ParaSigma_PreView.Value = TrackBar_ParaSigma.Value * 0.1M + 1;
        }

        //椒盐噪声
        private void Value_ParaNoiseCoeff_PreView_ValueChanged(object sender, EventArgs e)
        {
            TrackBar_ParaNoiseCoeff.Value = (int)(Value_ParaNoiseCoeff_PreView.Value);
        }

        private void TrackBar_ParaNoiseCoeff_Scroll(object sender, EventArgs e)
        {
            Value_ParaNoiseCoeff_PreView.Value = TrackBar_ParaNoiseCoeff.Value;
        }

        //图像模糊
        private void TrackBar_ParaSigma2_Scroll(object sender, EventArgs e)
        {
            Value_ParaSigma2_PreView.Value = TrackBar_ParaSigma2.Value;
        }

        private void Value_ParaSigma2_PreView_ValueChanged(object sender, EventArgs e)
        {
            TrackBar_ParaSigma2.Value = (int)(Value_ParaSigma2_PreView.Value);
        }

        //仿形变换
        private void TrackBar_ParaOffsetX_Scroll(object sender, EventArgs e)
        {
            Value_ParaOffsetX.Value = TrackBar_ParaOffsetX.Value;
        }

        private void Value_ParaOffsetX_ValueChanged(object sender, EventArgs e)
        {
            TrackBar_ParaOffsetX.Value = (int)Value_ParaOffsetX.Value;
        }

        private void TrackBar_ParaOffsetY_Scroll(object sender, EventArgs e)
        {
            Value_ParaOffsetY.Value = TrackBar_ParaOffsetY.Value;
        }

        private void Value_ParaOffsetY_ValueChanged(object sender, EventArgs e)
        {
            TrackBar_ParaOffsetY.Value = (int)Value_ParaOffsetY.Value;
        }

        private void TrackBar_ParaAngle_Scroll(object sender, EventArgs e)
        {
            Value_ParaAngle.Value = TrackBar_ParaAngle.Value;
        }

        private void Value_ParaAngle_ValueChanged(object sender, EventArgs e)
        {
            TrackBar_ParaAngle.Value = (int)Value_ParaAngle.Value;
        }

        //降采样率
        private void TrackBar_ParaPyrDownCoeff_Scroll(object sender, EventArgs e)
        {
            Value_ParaPyrDownCoeff.Value = TrackBar_ParaPyrDownCoeff.Value;
        }

        private void Value_ParaPyrDownCoeff_ValueChanged(object sender, EventArgs e)
        {
            TrackBar_ParaPyrDownCoeff.Value = (int)(Value_ParaPyrDownCoeff.Value);
        }



        //放在此处无法实现，因为放在局部类型public partial class PreviewForm : Form中（第16行）
        //MainForm中若需要引用，则需PreviewForm.SendValueEventArgs
        //public class SendValueEventArgs : System.EventArgs
        //{
        //    private decimal sentValue;

        //    public SendValueEventArgs(decimal value)
        //    {
        //        this.sentValue = value;
        //    }
        //    public decimal Value { get { return sentValue; } }
        //}


        //委托方法传递参数到MainForm
        //声明一个传递参数的委托
        public delegate void SendPara(SendValueEventArgs e);
        //public delegate void SendPara(decimal para);
        //声明一个传递参数的事件
        public event SendPara SendParaInterceptMin;
        public event SendPara SendParaInterceptMax;
        public event SendPara SendParaSlopeMin;
        public event SendPara SendParaSlopeMax;

        public event SendPara SendParaMiuMin;
        public event SendPara SendParaMiuMax;
        public event SendPara SendParaSigmaMin;
        public event SendPara SendParaSigmaMax;

        public event SendPara SendParaNoiseCoeffMin;
        public event SendPara SendParaNoiseCoeffMax;

        public event SendPara SendParaSigma2Min;
        public event SendPara SendParaSigma2Max;

        public event SendPara SendParaOffsetXMin;
        public event SendPara SendParaOffsetXMax;

        public event SendPara SendParaOffsetYMin;
        public event SendPara SendParaOffsetYMax;

        public event SendPara SendParaAngleMin;
        public event SendPara SendParaAngleMax;

        public event SendPara SendParaPyrDownCoeff;


        //灰度变化
        private void Button_SetParaInterceptMin_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaIntercept_PreView.Value);
            SendParaInterceptMin(args);
        }

        private void Button_SetParaInterceptMax_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaIntercept_PreView.Value);
            SendParaInterceptMax(args);
        }

        private void Button_SetParaSlopeMin_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaSlope_PreView.Value);
            SendParaSlopeMin(args);
        }

        private void Button_SetParaSlopeMax_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaSlope_PreView.Value);
            SendParaSlopeMax(args);
        }

        //高斯噪声
        private void Button_SetParaMiuMin_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaMiu_PreView.Value);
            SendParaMiuMin(args);
        }

        private void Button_SetParaMiuMax_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaMiu_PreView.Value);
            SendParaMiuMax(args);
        }

        private void Button_SetParaSigmaMin_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaSigma_PreView.Value);
            SendParaSigmaMin(args);
        }

        private void Button_SetParaSigmaMax_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaSigma_PreView.Value);
            SendParaSigmaMax(args);
        }

        //椒盐噪声
        private void Button_SetParaNoiseCoeffMin_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaNoiseCoeff_PreView.Value);
            SendParaNoiseCoeffMin(args);
        }

        private void Button_SetParaNoiseCoeffMax_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaNoiseCoeff_PreView.Value);
            SendParaNoiseCoeffMax(args);
        }
        
        //图像模糊
        private void Button_SetParaSigma2Min_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaSigma2_PreView.Value);
            SendParaSigma2Min(args);
        }

        private void Button_SetParaSigma2Max_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaSigma2_PreView.Value);
            SendParaSigma2Max(args);
        }

        private void Button_SetParaParaOffsetXMin_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaOffsetX.Value);
            SendParaOffsetXMin(args);
        }

        private void Button_SetParaParaOffsetXMax_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaOffsetX.Value);
            SendParaOffsetXMax(args);
        }

        private void Button_SetParaParaOffsetYMin_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaOffsetY.Value);
            SendParaOffsetYMin(args);
        }

        private void Button_SetParaParaOffsetYMax_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaOffsetY.Value);
            SendParaOffsetYMax(args);
        }

        private void Button_SetParaParaAngleMin_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaAngle.Value);
            SendParaAngleMin(args);
        }

        private void Button_SetParaParaAngleMax_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaAngle.Value);
            SendParaAngleMax(args);
        }

        private void Button_SetParaPyrDownCoeff_Click(object sender, EventArgs e)
        {
            var args = new SendValueEventArgs(Value_ParaPyrDownCoeff.Value);
            SendParaPyrDownCoeff(args);
        }


    }



    public class SendValueEventArgs : System.EventArgs
    {
        private decimal sentValue;

        public SendValueEventArgs(decimal value)
        {
            this.sentValue = value;
        }
        public decimal Value { get { return sentValue; } }
    }
}
