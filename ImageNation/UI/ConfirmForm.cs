using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageNation
{
    public partial class ConfirmForm : Form
    {
        private BackgroundWorker bgWorker_pBarImg; //ProgressForm窗体事件(进度条窗体)
        public MainForm mainForm;

        public ConfirmForm(BackgroundWorker bgWork)
        {
            InitializeComponent();
            this.bgWorker_pBarImg = bgWork;
            //绑定进度条改变事件
            this.bgWorker_pBarImg.ProgressChanged += new ProgressChangedEventHandler(bgWorker_pBarImg_ProgressChanged);
            //绑定后台操作完成，取消，异常时的事件
            this.bgWorker_pBarImg.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_pBarImg_RunWorkerCompleted);
        }

        //public ConfirmForm(MainForm mainForm)
        //    : this()//调用其他形式（没有参数的）的构造函数
        //{
        //    this.mainForm = mainForm;
        //}

        void bgWorker_pBarImg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.pBarImg.Value = e.ProgressPercentage;  //获取异步任务的进度百分比
        }

        void bgWorker_pBarImg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //this.Close();  //执行完之后，直接关闭页面
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.bgWorker_pBarImg.CancelAsync(); //请求取消挂起的后台操作
            this.ButtonCancel.Enabled = false;
            this.Close();
        }


        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOpenDataFile_Click(object sender, EventArgs e)
        {
            string ImgStoragePath = this.mainForm.ImgStorageFolderPath;
            System.Diagnostics.Process.Start("explorer.exe", ImgStoragePath);
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
