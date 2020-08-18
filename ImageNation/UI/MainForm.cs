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
        //1.声明自适应类实例  
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public MainForm()
        {
            InitializeComponent();//构造函数
            ComboBox_GrayScale.Enabled = false;
            ComboBox_PepperNoise.Enabled = false;
            CheckBoxPyrDown.Enabled = false;
        }
        //2. 为窗体添加Load事件，并在其方法MainForm_Load中，调用类的初始化方法，记录窗体和其控件的初始位置和大小  
        private void MainForm_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
        }
        //3.为窗体添加SizeChanged事件，并在其方法MainForm_SizeChanged中，调用类的自适应方法，完成自适应  
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
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

        public CheckBox State_CheckBoxOffsetX()
        {
            return this.CheckBoxOffsetX;
        }

        public CheckBox State_CheckBoxOffsetY()
        {
            return this.CheckBoxOffsetY;
        }

        public CheckBox State_CheckBoxRotate()
        {
            return this.CheckBoxRotate;
        }

        public CheckBox State_CheckBoxPyrDown()
        {
            return this.CheckBoxPyrDown;
        }




        public Mat imgOrigin;//定义初始图像

        public string ImgStorageFolderPath;

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

            ImgStorageFolderPath= ImgStorageFolder.SelectedPath;

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

            double[] OffsetXVal = new double[img_num];
            double[] OffsetYVal = new double[img_num];
            double[] AngleVal = new double[img_num];
            //double[] PyrDownCoeffVal = new double[img_num];
            double[] PSNRVal = new double[img_num];
            double[] SSIMVal = new double[img_num];
            double[] DHashVal = new double[img_num];

            //判断一共有几种算法，统计有多少变量，做成一整个数组

            if (CheckBoxAlgo1Gauss.Checked)
            {
                double miuScale = 1;//设为-128~128
                double sigmaScale = 1;//设为0~5

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

            if (CheckBoxOffsetX.Checked)
            {
                double offsetXMin = Convert.ToDouble(Value_ParaOffsetXMin.Value);
                double offsetXMax = Convert.ToDouble(Value_ParaOffsetXMax.Value);

                OffsetXVal = ParaList.GetRandomList(offsetXMin, offsetXMax, img_num);
            }

            if (CheckBoxOffsetY.Checked)
            {
                double offsetYMin = Convert.ToDouble(Value_ParaOffsetYMin.Value);
                double offsetYMax = Convert.ToDouble(Value_ParaOffsetYMax.Value);

                OffsetYVal = ParaList.GetRandomList(offsetYMin, offsetYMax, img_num);
            }

            if (CheckBoxRotate.Checked)
            {
                double angleMin = Convert.ToDouble(Value_ParaAngleMin.Value);
                double angleMax = Convert.ToDouble(Value_ParaAngleMax.Value);

                AngleVal = ParaList.GetRandomList(angleMin, angleMax, img_num);
            }

            int IQAStateFlag;//质量评估勾选状态

            if (CheckBoxIQAThreshold.Checked)
            {
                IQAStateFlag = 1;
            }else
            {
                IQAStateFlag = 0;
            }

            //存储数组
            string newTxtPath = ImgStorageFolder.SelectedPath + string.Concat("/", "Para", ".txt");//创建txt文件的具体路径
            StreamWriter sw = new StreamWriter(newTxtPath, false, Encoding.Default);//实例化StreamWriter

            int pyrDownNum = 0;

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

                if (CheckBoxOffsetX.Checked || CheckBoxOffsetY.Checked)
                {
                    double offsetx, offsety;
                    if (CheckBoxOffsetX.Checked)
                    {
                        offsetx = OffsetXVal[i];
                    }
                    else
                    {
                        offsetx = 0;
                    }

                    if (CheckBoxOffsetY.Checked)
                    {
                        offsety = OffsetYVal[i];
                    }
                    else
                    {
                        offsety = 0;
                    }

                    transImg = img.ImgAffine_Offset(transImg, offsetx, offsety);
                }

                if (CheckBoxRotate.Checked)
                {
                    transImg = img.ImgAffine_Rotate(transImg, AngleVal[i]);
                }

                if (CheckBoxPyrDown.Checked)
                {
                    pyrDownNum = (int)Value_ParaPyrDownCoeff.Value;
                    transImg = img.ImgPyrDown(transImg, pyrDownNum);
                }

                imgResult = transImg.Clone();

                int OffsetStateFlag;//位移退化状态
                if (CheckBoxOffsetX.Checked && CheckBoxOffsetY.Checked && CheckBoxRotate.Checked)
                {
                    OffsetStateFlag = 1;
                }else
                {
                    OffsetStateFlag = 0;
                }


                //质量评估
                using (ImgQE imgQuality = new ImgQE())
                {
                    PSNRVal[i] = imgQuality.ValuePSNR(imgOrigin, imgResult);
                    SSIMVal[i] = imgQuality.ValueSSIM(imgOrigin, imgResult);
                    DHashVal[i] = imgQuality.ValueDHash(imgOrigin, imgResult);
                }


                string NameResult = "";
                if (IQAStateFlag == 1)
                {
                    double SSIMThreshold;
                    double PSNRThreshold = (double)Value_PSNRThreshold.Value;
                    double HashThreshold = (double)Value_HashThreshold.Value;
                    if (OffsetStateFlag == 0)
                    {
                        SSIMThreshold = (double)Value_SSIMThreshold.Value;
                    }else
                    {
                        SSIMThreshold = (double)Value_SSIMOffsetThreshold.Value;
                    }

                    //判断
                    if (PSNRVal[i]>PSNRThreshold && SSIMVal[i] > SSIMThreshold && DHashVal[i] > HashThreshold)
                    {
                        NameResult = "OK";
                    }
                    else
                    {
                        NameResult = "NG";
                    }
                }


                //存储图片
                string imgNamePrefix = TextBox_FileNamePrefix.Text;
                //String[] path = {ImgStorageFolder.SelectedPath, string.Concat("Images", i.ToString("D5"),".jpg") };
                String[] path = { ImgStorageFolder.SelectedPath, string.Concat(imgNamePrefix, i.ToString("D5"), NameResult,".jpg") };
                string fullpath = Path.Combine(path);
                imgResult.SaveImage(fullpath);

                


                //存储参数数据
                sw.WriteLine(SigmaVal[i].ToString("F5") + "\t"
                        + MiuVal[i].ToString("F5") + "\t"
                        + SlopeVal[i].ToString("F5") + "\t"
                        + InterceptVal[i].ToString("F5") + "\t"
                        + Sigma2Val[i].ToString("F5") + "\t"
                        + CoeffVal[i].ToString("F5") + "\t"
                        + OffsetXVal[i].ToString("F5") + "\t"
                        + OffsetYVal[i].ToString("F5") + "\t"
                        + AngleVal[i].ToString("F5") + "\t"
                        + pyrDownNum.ToString("F0") + "\t"
                        + PSNRVal[i].ToString("F5") + "\t"
                        + SSIMVal[i].ToString("F5") + "\t"
                        + DHashVal[i].ToString("F5") + "\t"
                        );

                //double[][] Val = new double[2][];
                //Val[0] = MiuVal;
                //Val[1] = SigmaVal;
                //String[] ValPath = { folderBrowserDialog1.SelectedPath, string.Concat("Para", i.ToString("D5"), ".txt") };
                //string ValFullPath = Path.Combine(ValPath);
                //File.WriteAllLines(ValFullPath, Val, Encoding.Default);

                pBarImg.Value = i + 1;//进度条更新

            }
            sw.Flush();
            sw.Close();
            //Console.WriteLine("退化完成！");
            ConfirmForm confirmForm = new ConfirmForm(this);//引用Confirm(MainForm)
            confirmForm.Show();

        }



        private void Button_ImageScan_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();     //显示选择文件对话框
            string originalPath = "C:\\Users\\zjsyzyt\\Pictures";
            OpenImgFileDialog.InitialDirectory = originalPath;//初始加载路径为C盘；
            //OpenImgFileDialog.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;*.png;*.tif;*.tiff|";//过滤你想设置的文本文件类型（这是txt型）
            OpenImgFileDialog.Filter ="图像文件(*.jpg)|*.jpg|图像文件(*.bmp)|*.bmp"; ;//过滤你想设置的文本文件类型（这是txt型）
                                                            // openFileDialog1.Filter = "文本文件 (*.txt)|*.txt|All files (*.*)|*.*";（这是全部类型文件）
            if (this.OpenImgFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextBox_ImgPath.Text = Path.GetFileName(OpenImgFileDialog.FileName);//显示文件的名字
                this.pictureBox1.Load(OpenImgFileDialog.FileName);
                
            }

        }

        private void Button_FilePathScan_Click(object sender, EventArgs e)
        {
            ImgStorageFolder.SelectedPath = "C:\\Users\\zjsyzyt\\Desktop\\test\\InSight退化测试\\NG-Test1";
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

        private void CheckBoxOffsetX_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxOffsetY_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxRotate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxPyrDown_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxIQAThreshold_CheckedChanged(object sender, EventArgs e)
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

        private void Button_PreviewForm_Click(object sender, EventArgs e)
        {
            PreviewForm previewForm = new PreviewForm(this);//引用Preview(MainForm)

            //用这个方法无法传输图像和数据，仅实例化Preview()
            //PreviewForm previewForm = new PreviewForm();//实例化，引用Preview()
            //previewForm.mainForm = this;//建立父子关系,此时this指向mainform窗口

            //添加委托实例定义
            previewForm.SendParaInterceptMin += new PreviewForm.SendPara(RecvParaInterceptMin);
            previewForm.SendParaInterceptMax += new PreviewForm.SendPara(RecvParaInterceptMax);
            previewForm.SendParaSlopeMin += new PreviewForm.SendPara(RecvParaSlopeMin);
            previewForm.SendParaSlopeMax += new PreviewForm.SendPara(RecvParaSlopeMax);

            previewForm.SendParaMiuMin += new PreviewForm.SendPara(RecvParaMiuMin);
            previewForm.SendParaMiuMax += new PreviewForm.SendPara(RecvParaMiuMax);
            previewForm.SendParaSigmaMin += new PreviewForm.SendPara(RecvParaSigmaMin);
            previewForm.SendParaSigmaMax += new PreviewForm.SendPara(RecvParaSigmaMax);

            previewForm.SendParaNoiseCoeffMin += new PreviewForm.SendPara(RecvParaNoiseCoeffMin);
            previewForm.SendParaNoiseCoeffMax += new PreviewForm.SendPara(RecvParaNoiseCoeffMax);

            previewForm.SendParaSigma2Min += new PreviewForm.SendPara(RecvParaSigma2Min);
            previewForm.SendParaSigma2Max += new PreviewForm.SendPara(RecvParaSigma2Max);

            previewForm.SendParaOffsetXMin += new PreviewForm.SendPara(RecvParaOffsetXMin);
            previewForm.SendParaOffsetXMax += new PreviewForm.SendPara(RecvParaOffsetXMax);

            previewForm.SendParaOffsetYMin += new PreviewForm.SendPara(RecvParaOffsetYMin);
            previewForm.SendParaOffsetYMax += new PreviewForm.SendPara(RecvParaOffsetYMax);

            previewForm.SendParaAngleMin += new PreviewForm.SendPara(RecvParaAngleMin);
            previewForm.SendParaAngleMax += new PreviewForm.SendPara(RecvParaAngleMax);

            previewForm.SendParaPyrDownCoeff += new PreviewForm.SendPara(RecvParaPyrDownCoeff);

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

        private void ComboBox_PepperNoise_SelectedIndexChanged(object sender, EventArgs e)
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


        //委托方法接收PreView传来的参数
        private void RecvParaInterceptMin(SendValueEventArgs e)
        {
            Value_ParaInterceptMin.Value = e.Value;
        }

        private void RecvParaInterceptMax(SendValueEventArgs e)
        {
            Value_ParaInterceptMax.Value = e.Value;
        }

        private void RecvParaSlopeMin(SendValueEventArgs e)
        {
            Value_ParaSlopeMin.Value = e.Value;
        }

        private void RecvParaSlopeMax(SendValueEventArgs e)
        {
            Value_ParaSlopeMax.Value = e.Value;
        }


        private void RecvParaMiuMin(SendValueEventArgs e)
        {
            Value_ParaMiuMin.Value = e.Value;
        }

        private void RecvParaMiuMax(SendValueEventArgs e)
        {
            Value_ParaMiuMax.Value = e.Value;
        }

        private void RecvParaSigmaMin(SendValueEventArgs e)
        {
            Value_ParaSigmaMin.Value = e.Value;
        }

        private void RecvParaSigmaMax(SendValueEventArgs e)
        {
            Value_ParaSigmaMax.Value = e.Value;
        }

        private void RecvParaNoiseCoeffMin(SendValueEventArgs e)
        {
            Value_ParaNoiseCoeffMin.Value = e.Value;
        }

        private void RecvParaNoiseCoeffMax(SendValueEventArgs e)
        {
            Value_ParaNoiseCoeffMax.Value = e.Value;
        }

        private void RecvParaSigma2Min(SendValueEventArgs e)
        {
            Value_ParaSigma2Min.Value = e.Value;
        }

        private void RecvParaSigma2Max(SendValueEventArgs e)
        {
            Value_ParaSigma2Max.Value = e.Value;
        }

        private void RecvParaOffsetXMin(SendValueEventArgs e)
        {
            Value_ParaOffsetXMin.Value = e.Value;
        }

        private void RecvParaOffsetXMax(SendValueEventArgs e)
        {
            Value_ParaOffsetXMax.Value = e.Value;
        }

        private void RecvParaOffsetYMin(SendValueEventArgs e)
        {
            Value_ParaOffsetYMin.Value = e.Value;
        }

        private void RecvParaOffsetYMax(SendValueEventArgs e)
        {
            Value_ParaOffsetYMax.Value = e.Value;
        }

        private void RecvParaAngleMin(SendValueEventArgs e)
        {
            Value_ParaAngleMin.Value = e.Value;
        }

        private void RecvParaAngleMax(SendValueEventArgs e)
        {
            Value_ParaAngleMax.Value = e.Value;
        }

        private void RecvParaPyrDownCoeff(SendValueEventArgs e)
        {
            Value_ParaPyrDownCoeff.Value = e.Value;
        }
        


        private void Value_ParaOffsetXMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Value_ParaOffsetXMax_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Value_ParaOffsetYMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Value_ParaOffsetYMax_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Value_ParaAngleMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Value_ParaAngleMax_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Value_ParaPyrDownCoeff_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_MainForm_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_MainForm_Click(object sender, EventArgs e)
        {

        }

        private void Label_Para21Min_Click(object sender, EventArgs e)
        {

        }


    }
}
