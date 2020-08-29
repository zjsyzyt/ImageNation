namespace ImageNation
{
    partial class ConfirmForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.ButtonOpenDataFile = new System.Windows.Forms.Button();
            this.timer_ComfirmForm = new System.Windows.Forms.Timer(this.components);
            this.pBarImg = new System.Windows.Forms.ProgressBar();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "退化完成！";
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.Location = new System.Drawing.Point(63, 200);
            this.ButtonConfirm.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(167, 52);
            this.ButtonConfirm.TabIndex = 1;
            this.ButtonConfirm.Text = "OK";
            this.ButtonConfirm.UseVisualStyleBackColor = true;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // ButtonOpenDataFile
            // 
            this.ButtonOpenDataFile.Location = new System.Drawing.Point(279, 200);
            this.ButtonOpenDataFile.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ButtonOpenDataFile.Name = "ButtonOpenDataFile";
            this.ButtonOpenDataFile.Size = new System.Drawing.Size(181, 52);
            this.ButtonOpenDataFile.TabIndex = 2;
            this.ButtonOpenDataFile.Text = "打开存储文件夹";
            this.ButtonOpenDataFile.UseVisualStyleBackColor = true;
            this.ButtonOpenDataFile.Click += new System.EventHandler(this.ButtonOpenDataFile_Click);
            // 
            // timer_ComfirmForm
            // 
            this.timer_ComfirmForm.Enabled = true;
            this.timer_ComfirmForm.Interval = 5000;
            // 
            // pBarImg
            // 
            this.pBarImg.Location = new System.Drawing.Point(63, 87);
            this.pBarImg.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pBarImg.Maximum = 10;
            this.pBarImg.Name = "pBarImg";
            this.pBarImg.Size = new System.Drawing.Size(649, 42);
            this.pBarImg.Step = 1;
            this.pBarImg.TabIndex = 43;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(531, 200);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(181, 52);
            this.ButtonCancel.TabIndex = 44;
            this.ButtonCancel.Text = "取消";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 329);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.pBarImg);
            this.Controls.Add(this.ButtonOpenDataFile);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "ConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonConfirm;
        private System.Windows.Forms.Button ButtonOpenDataFile;
        private System.Windows.Forms.Timer timer_ComfirmForm;
        private System.Windows.Forms.ProgressBar pBarImg;
        private System.Windows.Forms.Button ButtonCancel;
    }
}