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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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
    }
}
