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
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.ButtonOpenDataFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "退化完成！";
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.Location = new System.Drawing.Point(114, 201);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(210, 52);
            this.ButtonConfirm.TabIndex = 1;
            this.ButtonConfirm.Text = "OK";
            this.ButtonConfirm.UseVisualStyleBackColor = true;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // ButtonOpenDataFile
            // 
            this.ButtonOpenDataFile.Location = new System.Drawing.Point(422, 201);
            this.ButtonOpenDataFile.Name = "ButtonOpenDataFile";
            this.ButtonOpenDataFile.Size = new System.Drawing.Size(210, 52);
            this.ButtonOpenDataFile.TabIndex = 2;
            this.ButtonOpenDataFile.Text = "打开存储文件夹";
            this.ButtonOpenDataFile.UseVisualStyleBackColor = true;
            this.ButtonOpenDataFile.Click += new System.EventHandler(this.ButtonOpenDataFile_Click);
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 329);
            this.Controls.Add(this.ButtonOpenDataFile);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonConfirm;
        private System.Windows.Forms.Button ButtonOpenDataFile;
    }
}