using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;

namespace ImageNation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();//构造函数
            ComboBox_GrayScale.Enabled = false;
            ComboBox_PepperNoise.Enabled = false;
        }

        public PreviewForm previewForm { get; set;}


        //将私有的勾选状态转成可以用公有的方法获取;通过属性传递
        //mainForm和previewForm之间状态同步
        public CheckBox State_CheckBoxAlgo1Gauss()
        {
            //this.CheckBoxAlgo1Gauss.CheckState = previewForm.State_CheckBoxAlgo1Gauss().CheckState;
            return this.CheckBoxAlgo1Gauss;
        }

        public CheckBox State_CheckBoxAlgo2GrayScale()
        {
            //this.CheckBoxAlgo2GrayScale.CheckState = previewForm.State_CheckBoxAlgo2GrayScale().CheckState;
            return this.CheckBoxAlgo2GrayScale;
        }

        public CheckBox State_CheckBoxAlgo3GaussianBlur()
        {
            //this.CheckBoxAlgo3GaussianBlur.CheckState = previewForm.State_CheckBoxAlgo3GaussianBlur().CheckState;
            return this.CheckBoxAlgo3GaussianBlur;
        }

        public CheckBox State_CheckBoxAlgo4PepperNoise()
        {
            //this.CheckBoxAlgo4PepperNoise.CheckState = previewForm.State_CheckBoxAlgo4PepperNoise().CheckState;
            return this.CheckBoxAlgo4PepperNoise;
        }

        public ComboBox State_ComboBox_PepperNoise()
        {
            return this.ComboBox_PepperNoise;
        }

        public ComboBox State_ComboBox_GrayScale()
        {
            return this.ComboBox_GrayScale;
        }

        //委托方法接收PreView传来的参数
        private void RecvPara(decimal para)
        {
            Value_ParaSlopeMin.Value = para;

        }



        public Mat imgOrigin;//定义初始图像

        //public OpenFileDialog GetOpenFileDialog
        //Mat(OpenImgFileDialog.FileName, ImreadModes.Grayscale);
        public Mat ImgOriginPublic
        {
            get
            {
                imgOrigin = new Mat(OpenImgFileDialog.FileName, ImreadModes.Grayscale);
                return imgOrigin;
            }

        }

        public Mat imgResult;
        ParaProcess ParaList= new ParaProcess();//动态类，需要实例化；工具类一般用静态类，函数前加static即可直接调用
        ImgProcess img = new ImgProcess();

        ////增加一个控制台，用于信息输出
        //[System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        //[return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        //static extern bool AllocConsole();


        private void Button_StartDegradation_Click(object sender, EventArgs e)
        {
            //AllocConsole();
            int img_num = Convert.ToInt32(ImgNum.Value); //获取输入框中的数字,目标图片总数
            pBarImg.Maximum = img_num;//设置最大长度值
            pBarImg.Value = 0;//设置当前值
            //imgOrigin = new Mat(OpenImgFileDialog.FileName,ImreadModes.Grayscale);
            Mat imgOrigin = this.ImgOriginPublic;

            String[] path_Ori = { ImgStorageFolder.SelectedPath, string.Concat("Image_Original", ".jpg") };
            string fullpath_Ori = Path.Combine(path_Ori);
            imgOrigin.SaveImage(fullpath_Ori);

            double[,] ParaVal = new double[6, img_num];
            double[] MiuVal = new double[img_num];
            double[] SigmaVal = new double[img_num];
            double[] SlopeVal = new double[img_num];
            double[] InterceptVal = new double[img_num];
            double[] Sigma2Val = new double[img_num];
            double[] CoeffVal = new double[img_num];


            //判断一共有几种算法，统计有多少变量，做成一整个数组

            if (CheckBoxAlgo1Gauss.Checked)
            {
                double miuScale = 1;//设为-100~100
                double sigmaScale = 20;//设为0~5

                double miuMin = Convert.ToDouble(Value_ParaMiuMin.Value)/miuScale;
                double miuMax = Convert.ToDouble(Value_ParaMiuMax.Value)/miuScale;
                double sigmaMin = Convert.ToDouble(Value_ParaSigmaMin.Value)/sigmaScale;
                double sigmaMax = Convert.ToDouble(Value_ParaSigmaMax.Value)/sigmaScale;

                MiuVal = ParaList.GetRandomList(miuMin,miuMax,img_num);
                SigmaVal = ParaList.GetRandomList(sigmaMin, sigmaMax, img_num);
            }

            if (CheckBoxAlgo2GrayScale.Checked)
            {

                double slopeMin = Convert.ToDouble(Value_ParaSlopeMin.Value);
                double slopeMax = Convert.ToDouble(Value_ParaSlopeMax.Value);
                double interceptMin = Convert.ToDouble(Value_ParaInterceptMin.Value);
                double interceptMax = Convert.ToDouble(Value_ParaInterceptMax.Value);

                SlopeVal = ParaList.GetRandomList(slopeMin, slopeMax, img_num);
                InterceptVal = ParaList.GetRandomList(interceptMin, interceptMax, img_num);
            }

            if (CheckBoxAlgo3GaussianBlur.Checked)
            {
                double sigma2Scale = 1;//参数值设为0~100，值越小越模糊，故需反转

                double sigma2Min = Convert.ToDouble(Value_ParaSigma2Min.Value) / sigma2Scale;
                double sigma2Max = Convert.ToDouble(Value_ParaSigma2Max.Value) / sigma2Scale;

                Sigma2Val = ParaList.GetRandomList(sigma2Min, sigma2Max, img_num);
            }

            if (CheckBoxAlgo4PepperNoise.Checked)
            {
                ComboBox_PepperNoise.Visible = true;

                double coeffMin = Convert.ToDouble(Value_ParaNoiseCoeffMin.Value);
                double coeffMax = Convert.ToDouble(Value_ParaNoiseCoeffMax.Value);

                CoeffVal = ParaList.GetRandomList(coeffMin, coeffMax, img_num);

            }


            //存储数组
            string newTxtPath = ImgStorageFolder.SelectedPath + string.Concat("/", "Para", ".txt");//创建txt文件的具体路径
            StreamWriter sw = new StreamWriter(newTxtPath, false, Encoding.Default);//实例化StreamWriter

            for (int i = 0; i < img_num; i++)
            {
                Mat transImg= imgOrigin.Clone();
                if (CheckBoxAlgo1Gauss.Checked)
                {
                    transImg = img.GaussianNoise(transImg, MiuVal[i], SigmaVal[i]);
                }

                if (CheckBoxAlgo2GrayScale.Checked)
                {
                    transImg = img.GrayScale(transImg, SlopeVal[i], InterceptVal[i]); 
                }

                if (CheckBoxAlgo3GaussianBlur.Checked)
                {
                    transImg = img.LowPassFreq(transImg, Sigma2Val[i]);
                }

                if (CheckBoxAlgo4PepperNoise.Checked)
                {
                    transImg = img.PepperNoise(transImg, CoeffVal[i], ComboBox_PepperNoise.SelectedIndex);
                }

                imgResult = transImg.Clone();

                //存储图片
                string imgNamePrefix = TextBox_FileNamePrefix.Text;
                //String[] path = {ImgStorageFolder.SelectedPath, string.Concat("Images", i.ToString("D5"),".jpg") };
                String[] path = { ImgStorageFolder.SelectedPath, string.Concat(imgNamePrefix, i.ToString("D5"), ".jpg") };
                string fullpath = Path.Combine(path);
                imgResult.SaveImage(fullpath);

                pBarImg.Value = i+1;//进度条更新
                //if (i == img_num)
                //{
                //    Console.WriteLine("退化完成！");//只有控制台程序中才有
                //}

                //存储参数数据
                sw.WriteLine(MiuVal[i].ToString("F5") + "\t"
                    + SigmaVal[i].ToString("F5") + "\t"
                    + SlopeVal[i].ToString("F5") + "\t"
                    + InterceptVal[i].ToString("F5") + "\t"
                    + Sigma2Val[i].ToString("F5") + "\t"
                    + CoeffVal[i].ToString("F5") + "\t"
                    );

                //double[][] Val = new double[2][];
                //Val[0] = MiuVal;
                //Val[1] = SigmaVal;
                //String[] ValPath = { folderBrowserDialog1.SelectedPath, string.Concat("Para", i.ToString("D5"), ".txt") };
                //string ValFullPath = Path.Combine(ValPath);
                //File.WriteAllLines(ValFullPath, Val, Encoding.Default);
                

            }
            sw.Flush();
            sw.Close();
            //Console.WriteLine("退化完成！");
        }

        private void Button_ImageScan_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();     //显示选择文件对话框
            OpenImgFileDialog.InitialDirectory = "C:\\Users\\zjsyzyt\\Pictures";//初始加载路径为C盘；
            OpenImgFileDialog.Filter = "图像文件 (*.jpg)|*.jpg";//过滤你想设置的文本文件类型（这是txt型）
                                                          // openFileDialog1.Filter = "文本文件 (*.txt)|*.txt|All files (*.*)|*.*";（这是全部类型文件）
            if (this.OpenImgFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextBox_ImgPath.Text = Path.GetFileName(OpenImgFileDialog.FileName);//显示文件的名字
                this.pictureBox1.Load(OpenImgFileDialog.FileName);
                
            }

        }

        private void Button_FilePathScan_Click(object sender, EventArgs e)
        {
            ImgStorageFolder.SelectedPath = "C:\\Users\\zjsyzyt\\Desktop\\test";
            if (this.ImgStorageFolder.ShowDialog() == DialogResult.OK)
            {
                if (this.ImgStorageFolder.SelectedPath.Trim() != "")
                    this.TextBox_ImgStoragePath.Text = this.ImgStorageFolder.SelectedPath.Trim();
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void OpenImgFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ImgNum_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void Value_ParaMiuMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Value_ParaMiuMax_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxAlgo1Gauss_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxAlgo2GrayScale_CheckedChanged(object sender, EventArgs e)
        {
            switch (CheckBoxAlgo2GrayScale.Checked)
            {
                case true:
                    ComboBox_GrayScale.Enabled = true;
                    break;
                case false:
                    ComboBox_GrayScale.Enabled = false;
                    break;
            }
        }

        private void Value_ParaSigmaMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Value_ParaSigmaMax_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FileNamePrefix_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxAlgo3GaussianBlur_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Value_ParaSigma2Max_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label_Para3Max_Click(object sender, EventArgs e)
        {

        }

        private void Label_Para3Min_Click(object sender, EventArgs e)
        {

        }

        private void Label_ParaSigma2_Click(object sender, EventArgs e)
        {

        }

        private void TrackBar_ParaSigma2_Scroll(object sender, EventArgs e)
        {

        }

        private void Value_ParaSigma2Min_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pBarImg_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Button_PreviewForm_Click(object sender, EventArgs e)
        {
            PreviewForm previewForm = new PreviewForm(this);//引用Preview(MainForm)

            //用这个方法无法传输图像和数据，仅实例化Preview()
            //PreviewForm previewForm = new PreviewForm();//实例化，引用Preview()
            //previewForm.mainForm = this;//建立父子关系,此时this指向mainform窗口

            previewForm.Show();




        }

        private void CheckBoxAlgo4PepperNoise_CheckedChanged(object sender, EventArgs e)
        {
            switch (CheckBoxAlgo4PepperNoise.Checked)
            {
                case true:
                    ComboBox_PepperNoise.Enabled = true;
                    break;
                case false:
                    ComboBox_PepperNoise.Enabled = false;
                    break;
            }
        }

        private void comboBox_PepperNoise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_GrayScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBox_GrayScale.SelectedIndex)
            {
                case 0://增大对比度
                    Value_ParaSlopeMin.Minimum = 1;
                    Value_ParaSlopeMin.Maximum = 5;
                    Value_ParaSlopeMax.Minimum = 1;
                    Value_ParaSlopeMax.Maximum = 5;
                    Value_ParaSlopeMin.DecimalPlaces = 1;
                    Value_ParaSlopeMin.Increment = 0.2M;
                    Value_ParaSlopeMax.DecimalPlaces = 1;
                    Value_ParaSlopeMax.Increment = 0.2M;
                    break;
                case 1://减小对比度
                    Value_ParaSlopeMin.Minimum = 0;
                    Value_ParaSlopeMin.Maximum = 1;
                    Value_ParaSlopeMax.Minimum = 0;
                    Value_ParaSlopeMax.Maximum = 1;
                    Value_ParaSlopeMin.DecimalPlaces = 1;
                    Value_ParaSlopeMin.Increment = 0.1M;
                    Value_ParaSlopeMax.DecimalPlaces = 1;
                    Value_ParaSlopeMax.Increment = 0.1M;
                    break;
                case 2://倒置
                    Value_ParaSlopeMin.Minimum = -1;
                    Value_ParaSlopeMin.Maximum = -1;
                    Value_ParaSlopeMax.Minimum = -1;
                    Value_ParaSlopeMax.Maximum = -1;
                    Value_ParaSlopeMin.Value = -1;
                    Value_ParaSlopeMax.Value = -1;
                    Value_ParaInterceptMin.Minimum = 255;
                    Value_ParaInterceptMin.Maximum = 255;
                    Value_ParaInterceptMax.Minimum = 255;
                    Value_ParaInterceptMax.Maximum = 255;
                    Value_ParaInterceptMin.Value = 255;
                    Value_ParaInterceptMax.Value = 255;
                    break;
                default:
                    break;
            }
        }
    }
}
