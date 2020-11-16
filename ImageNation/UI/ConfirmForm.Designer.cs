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
            this.Label_Finish = new System.Windows.Forms.Label();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.ButtonOpenDataFile = new System.Windows.Forms.Button();
            this.timer_ComfirmForm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Label_Finish
            // 
            this.Label_Finish.AutoSize = true;
            this.Label_Finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Finish.Location = new System.Drawing.Point(219, 40);
            this.Label_Finish.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label_Finish.Name = "Label_Finish";
            this.Label_Finish.Size = new System.Drawing.Size(237, 51);
            this.Label_Finish.TabIndex = 0;
            this.Label_Finish.Text = "退化完成！";
            this.Label_Finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.Location = new System.Drawing.Point(82, 121);
            this.ButtonConfirm.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(195, 60);
            this.ButtonConfirm.TabIndex = 1;
            this.ButtonConfirm.Text = "OK";
            this.ButtonConfirm.UseVisualStyleBackColor = true;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // ButtonOpenDataFile
            // 
            this.ButtonOpenDataFile.Location = new System.Drawing.Point(398, 121);
            this.ButtonOpenDataFile.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.ButtonOpenDataFile.Name = "ButtonOpenDataFile";
            this.ButtonOpenDataFile.Size = new System.Drawing.Size(195, 60);
            this.ButtonOpenDataFile.TabIndex = 2;
            this.ButtonOpenDataFile.Text = "打开存储文件夹";
            this.ButtonOpenDataFile.UseVisualStyleBackColor = true;
            this.ButtonOpenDataFile.Click += new System.EventHandler(this.ButtonOpenDataFile_Click);
            // 
            // timer_ComfirmForm
            // 
            this.timer_ComfirmForm.Enabled = true;
            this.timer_ComfirmForm.Interval = 5000;
            this.timer_ComfirmForm.Tick += new System.EventHandler(this.timer_ComfirmForm_Tick);
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 229);
            this.Controls.Add(this.ButtonOpenDataFile);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.Label_Finish);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "ConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Finish;
        private System.Windows.Forms.Button ButtonConfirm;
        private System.Windows.Forms.Button ButtonOpenDataFile;
        private System.Windows.Forms.Timer timer_ComfirmForm;
    }
}