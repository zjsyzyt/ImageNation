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
    public partial class ProgressForm : Form
    {
        private BackgroundWorker bgWorker_pBarImg; //ProgressForm窗体事件(进度条窗体)
        public ProgressForm(BackgroundWorker bgWork)
        {
            InitializeComponent();
            bgWorker_pBarImg = bgWork;
            //绑定进度条改变事件
            bgWorker_pBarImg.ProgressChanged += new ProgressChangedEventHandler(bgWorker_pBarImg_ProgressChanged);
            //绑定后台操作完成，取消，异常时的事件
            bgWorker_pBarImg.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_pBarImg_RunWorkerCompleted);
        }

        void bgWorker_pBarImg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pBarImg.Value = e.ProgressPercentage;  //获取异步任务的进度百分比
            //System.Threading.Thread.Sleep(2000);
        }

        void bgWorker_pBarImg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer_ProgressForm.Enabled = true;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.bgWorker_pBarImg.CancelAsync(); //请求取消挂起的后台操作
            this.ButtonCancel.Enabled = false;
            this.Close();
        }

        private void timer_ProgressForm_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
