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
        private MainForm mainForm;

        public ConfirmForm()
        {
            InitializeComponent();
        }

        public ConfirmForm(MainForm mainForm)
            : this()//调用其他形式（没有参数的）的构造函数
        {
            this.mainForm = mainForm;
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

        private void timer_ComfirmForm_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
