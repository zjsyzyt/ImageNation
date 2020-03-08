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

namespace WfaAutoFacDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//构造函数
        }

        private void CheckBox_Algo1_Gauss_CheckedChanged(object sender, EventArgs e)
        {

        }

        public Mat imgOrigin;//定义初始图像
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
            imgOrigin = new Mat(OpenImgFileDialog.FileName,ImreadModes.Grayscale);

            String[] path_Ori = { ImgStorageFolder.SelectedPath, string.Concat("Image_Original", ".jpg") };
            string fullpath_Ori = Path.Combine(path_Ori);
            imgOrigin.SaveImage(fullpath_Ori);

            double[,] ParaVal = new double[4, img_num];
            double[] MiuVal = new double[img_num];
            double[] SigmaVal = new double[img_num];
            double[] SlopeVal = new double[img_num];
            double[] InterceptVal = new double[img_num];

            //判断一共有几种算法，统计有多少变量，做成一整个数组

            if (CheckBoxAlgo1Gauss.Checked)
            {
                double miuScale = 5;//设为-20~20
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
                double slopeScale = 25;//设为-4~4
                double interceptScale = 2;//设为-50~50

                double slopeMin = Convert.ToDouble(Value_ParaSlopeMin.Value)/slopeScale;
                double slopeMax = Convert.ToDouble(Value_ParaSlopeMax.Value)/slopeScale;
                double interceptMin = Convert.ToDouble(Value_ParaInterceptMin.Value)/interceptScale;
                double interceptMax = Convert.ToDouble(Value_ParaInterceptMax.Value)/interceptScale;

                SlopeVal = ParaList.GetRandomList(slopeMin, slopeMax, img_num);
                InterceptVal = ParaList.GetRandomList(interceptMin, interceptMax, img_num);
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

                imgResult = transImg.Clone();

                //存储图片
                String[] path = {ImgStorageFolder.SelectedPath, string.Concat("Images", i.ToString("D5"),".jpg") };
                string fullpath = Path.Combine(path);
                imgResult.SaveImage(fullpath);

                pBarImg.Value = i+1;//进度条更新
                //if (i == img_num)
                //{
                //    Console.WriteLine("退化完成！");
                //}

                //存储参数数据
                sw.WriteLine(MiuVal[i].ToString("F5") + "\t"
                    + SigmaVal[i].ToString("F5") + "\t"
                    + SlopeVal[i].ToString("F5") + "\t"
                    + InterceptVal[i].ToString("F5") + "\t"
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
    }
}
