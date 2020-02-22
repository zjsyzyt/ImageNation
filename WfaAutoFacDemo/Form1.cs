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
            InitializeComponent();
        }

        private void CheckBox_Algo1_Gauss_CheckedChanged(object sender, EventArgs e)
        {

        }

        public Mat imgOrigin;//定义初始图像

        private void StartButton_Click(object sender, EventArgs e)
        {
            int img_num = Convert.ToInt32(ImgNum.Value); //获取输入框中的数字,目标图片总数
            imgOrigin = new Mat(openFileDialog1.FileName);

            //判断一共有几种算法，统计有多少变量，




            if (CheckBoxAlgo1Gauss.Checked)
            {
                double miuMin = Convert.ToDouble(Value_ParaMiuMin.Value);
                double miuMax = Convert.ToDouble(Value_ParaMiuMax.Value);
                double sigmaMin = Convert.ToDouble(Value_ParaSigmaMin.Value);
                double sigmaMax = Convert.ToDouble(Value_ParaSigmaMax.Value);


            }

            if (CheckBoxAlgo2GrayScale.Checked)
            {
                ;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void ImageScanButton_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();     //显示选择文件对话框
            openFileDialog1.InitialDirectory = "C:\\Users\\zjsyzyt\\Pictures";//初始加载路径为C盘；
            openFileDialog1.Filter = "图像文件 (*.jpg)|*.jpg";//过滤你想设置的文本文件类型（这是txt型）
                                                          // openFileDialog1.Filter = "文本文件 (*.txt)|*.txt|All files (*.*)|*.*";（这是全部类型文件）
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = Path.GetFileName(openFileDialog1.FileName);//显示文件的名字
                this.pictureBox1.Load(openFileDialog1.FileName);
                
            }

        }

        private void FilePathScanButton_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.SelectedPath ="D:\\";
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (this.folderBrowserDialog1.SelectedPath.Trim() != "")
                    this.textBox2.Text = this.folderBrowserDialog1.SelectedPath.Trim();
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ImgNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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
    }
}
