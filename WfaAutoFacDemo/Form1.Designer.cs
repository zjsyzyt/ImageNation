namespace WfaAutoFacDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckBoxAlgo1Gauss = new System.Windows.Forms.CheckBox();
            this.CheckBoxAlgo2GrayScale = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ImgNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageScanButton = new System.Windows.Forms.Button();
            this.FilePathScanButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TrackBar_ParaMiu = new System.Windows.Forms.TrackBar();
            this.TrackBar_ParaSigma = new System.Windows.Forms.TrackBar();
            this.Label_ParaMiu = new System.Windows.Forms.Label();
            this.Label_ParaSigma = new System.Windows.Forms.Label();
            this.Label_ParaMin = new System.Windows.Forms.Label();
            this.Label_ParaMax = new System.Windows.Forms.Label();
            this.Value_ParaMiuMin = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaMiuMax = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaSigmaMax = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaSigmaMin = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaInterceptMax = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaInterceptMin = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaSlopeMax = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaSlopeMin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TrackBar_ParaIntercept = new System.Windows.Forms.TrackBar();
            this.TrackBar_ParaSlope = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaMiu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaMiuMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaMiuMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigmaMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigmaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaInterceptMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaInterceptMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSlopeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSlopeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaIntercept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSlope)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBoxAlgo1Gauss
            // 
            this.CheckBoxAlgo1Gauss.AutoSize = true;
            this.CheckBoxAlgo1Gauss.Location = new System.Drawing.Point(463, 12);
            this.CheckBoxAlgo1Gauss.Name = "CheckBoxAlgo1Gauss";
            this.CheckBoxAlgo1Gauss.Size = new System.Drawing.Size(72, 16);
            this.CheckBoxAlgo1Gauss.TabIndex = 4;
            this.CheckBoxAlgo1Gauss.Text = "高斯噪声";
            this.CheckBoxAlgo1Gauss.UseVisualStyleBackColor = true;
            this.CheckBoxAlgo1Gauss.CheckedChanged += new System.EventHandler(this.CheckBoxAlgo1Gauss_CheckedChanged);
            this.CheckBoxAlgo1Gauss.Click += new System.EventHandler(this.CheckBoxAlgo1Gauss_CheckedChanged);
            // 
            // CheckBoxAlgo2GrayScale
            // 
            this.CheckBoxAlgo2GrayScale.AutoSize = true;
            this.CheckBoxAlgo2GrayScale.Location = new System.Drawing.Point(463, 123);
            this.CheckBoxAlgo2GrayScale.Name = "CheckBoxAlgo2GrayScale";
            this.CheckBoxAlgo2GrayScale.Size = new System.Drawing.Size(72, 16);
            this.CheckBoxAlgo2GrayScale.TabIndex = 5;
            this.CheckBoxAlgo2GrayScale.Text = "灰度变化";
            this.CheckBoxAlgo2GrayScale.UseVisualStyleBackColor = true;
            this.CheckBoxAlgo2GrayScale.CheckedChanged += new System.EventHandler(this.CheckBoxAlgo2GrayScale_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(463, 380);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(165, 52);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "启动退化";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ImgNum
            // 
            this.ImgNum.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ImgNum.Location = new System.Drawing.Point(532, 319);
            this.ImgNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ImgNum.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ImgNum.Name = "ImgNum";
            this.ImgNum.Size = new System.Drawing.Size(96, 21);
            this.ImgNum.TabIndex = 8;
            this.ImgNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ImgNum.ValueChanged += new System.EventHandler(this.ImgNum_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(461, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "图像数量：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ImageScanButton
            // 
            this.ImageScanButton.Location = new System.Drawing.Point(360, 380);
            this.ImageScanButton.Name = "ImageScanButton";
            this.ImageScanButton.Size = new System.Drawing.Size(75, 23);
            this.ImageScanButton.TabIndex = 10;
            this.ImageScanButton.Text = "浏览";
            this.ImageScanButton.UseVisualStyleBackColor = true;
            this.ImageScanButton.Click += new System.EventHandler(this.ImageScanButton_Click);
            // 
            // FilePathScanButton
            // 
            this.FilePathScanButton.Location = new System.Drawing.Point(360, 410);
            this.FilePathScanButton.Name = "FilePathScanButton";
            this.FilePathScanButton.Size = new System.Drawing.Size(75, 23);
            this.FilePathScanButton.TabIndex = 11;
            this.FilePathScanButton.Text = "浏览";
            this.FilePathScanButton.UseVisualStyleBackColor = true;
            this.FilePathScanButton.Click += new System.EventHandler(this.FilePathScanButton_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\zjsyzyt\\Pictures";
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 21);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 411);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(282, 21);
            this.textBox2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "图像路径:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "存储路径:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\zjsyzyt\\Pictures";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(563, 342);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(65, 21);
            this.textBox3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "文件名（前缀）：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TrackBar_ParaMiu
            // 
            this.TrackBar_ParaMiu.AutoSize = false;
            this.TrackBar_ParaMiu.Location = new System.Drawing.Point(518, 39);
            this.TrackBar_ParaMiu.Name = "TrackBar_ParaMiu";
            this.TrackBar_ParaMiu.Size = new System.Drawing.Size(116, 21);
            this.TrackBar_ParaMiu.TabIndex = 18;
            // 
            // TrackBar_ParaSigma
            // 
            this.TrackBar_ParaSigma.AutoSize = false;
            this.TrackBar_ParaSigma.Location = new System.Drawing.Point(518, 79);
            this.TrackBar_ParaSigma.Name = "TrackBar_ParaSigma";
            this.TrackBar_ParaSigma.Size = new System.Drawing.Size(116, 21);
            this.TrackBar_ParaSigma.TabIndex = 19;
            // 
            // Label_ParaMiu
            // 
            this.Label_ParaMiu.AutoSize = true;
            this.Label_ParaMiu.Location = new System.Drawing.Point(461, 43);
            this.Label_ParaMiu.Name = "Label_ParaMiu";
            this.Label_ParaMiu.Size = new System.Drawing.Size(53, 12);
            this.Label_ParaMiu.TabIndex = 20;
            this.Label_ParaMiu.Text = "噪声幅度";
            // 
            // Label_ParaSigma
            // 
            this.Label_ParaSigma.AutoSize = true;
            this.Label_ParaSigma.Location = new System.Drawing.Point(461, 83);
            this.Label_ParaSigma.Name = "Label_ParaSigma";
            this.Label_ParaSigma.Size = new System.Drawing.Size(53, 12);
            this.Label_ParaSigma.TabIndex = 21;
            this.Label_ParaSigma.Text = "噪声密度";
            // 
            // Label_ParaMin
            // 
            this.Label_ParaMin.AutoSize = true;
            this.Label_ParaMin.Location = new System.Drawing.Point(650, 20);
            this.Label_ParaMin.Name = "Label_ParaMin";
            this.Label_ParaMin.Size = new System.Drawing.Size(41, 12);
            this.Label_ParaMin.TabIndex = 22;
            this.Label_ParaMin.Text = "最小值";
            // 
            // Label_ParaMax
            // 
            this.Label_ParaMax.AutoSize = true;
            this.Label_ParaMax.Location = new System.Drawing.Point(733, 20);
            this.Label_ParaMax.Name = "Label_ParaMax";
            this.Label_ParaMax.Size = new System.Drawing.Size(41, 12);
            this.Label_ParaMax.TabIndex = 23;
            this.Label_ParaMax.Text = "最大值";
            // 
            // Value_ParaMiuMin
            // 
            this.Value_ParaMiuMin.Location = new System.Drawing.Point(642, 39);
            this.Value_ParaMiuMin.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Value_ParaMiuMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Value_ParaMiuMin.Name = "Value_ParaMiuMin";
            this.Value_ParaMiuMin.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaMiuMin.TabIndex = 28;
            this.Value_ParaMiuMin.ValueChanged += new System.EventHandler(this.Value_ParaMiuMin_ValueChanged);
            // 
            // Value_ParaMiuMax
            // 
            this.Value_ParaMiuMax.Location = new System.Drawing.Point(725, 39);
            this.Value_ParaMiuMax.Name = "Value_ParaMiuMax";
            this.Value_ParaMiuMax.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaMiuMax.TabIndex = 29;
            this.Value_ParaMiuMax.ValueChanged += new System.EventHandler(this.Value_ParaMiuMax_ValueChanged);
            // 
            // Value_ParaSigmaMax
            // 
            this.Value_ParaSigmaMax.Location = new System.Drawing.Point(725, 79);
            this.Value_ParaSigmaMax.Name = "Value_ParaSigmaMax";
            this.Value_ParaSigmaMax.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaSigmaMax.TabIndex = 31;
            this.Value_ParaSigmaMax.ValueChanged += new System.EventHandler(this.Value_ParaSigmaMax_ValueChanged);
            // 
            // Value_ParaSigmaMin
            // 
            this.Value_ParaSigmaMin.Location = new System.Drawing.Point(642, 79);
            this.Value_ParaSigmaMin.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Value_ParaSigmaMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Value_ParaSigmaMin.Name = "Value_ParaSigmaMin";
            this.Value_ParaSigmaMin.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaSigmaMin.TabIndex = 30;
            this.Value_ParaSigmaMin.ValueChanged += new System.EventHandler(this.Value_ParaSigmaMin_ValueChanged);
            // 
            // Value_ParaInterceptMax
            // 
            this.Value_ParaInterceptMax.Location = new System.Drawing.Point(725, 186);
            this.Value_ParaInterceptMax.Name = "Value_ParaInterceptMax";
            this.Value_ParaInterceptMax.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaInterceptMax.TabIndex = 41;
            // 
            // Value_ParaInterceptMin
            // 
            this.Value_ParaInterceptMin.Location = new System.Drawing.Point(642, 186);
            this.Value_ParaInterceptMin.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Value_ParaInterceptMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Value_ParaInterceptMin.Name = "Value_ParaInterceptMin";
            this.Value_ParaInterceptMin.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaInterceptMin.TabIndex = 40;
            // 
            // Value_ParaSlopeMax
            // 
            this.Value_ParaSlopeMax.Location = new System.Drawing.Point(725, 146);
            this.Value_ParaSlopeMax.Name = "Value_ParaSlopeMax";
            this.Value_ParaSlopeMax.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaSlopeMax.TabIndex = 39;
            // 
            // Value_ParaSlopeMin
            // 
            this.Value_ParaSlopeMin.Location = new System.Drawing.Point(642, 146);
            this.Value_ParaSlopeMin.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Value_ParaSlopeMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Value_ParaSlopeMin.Name = "Value_ParaSlopeMin";
            this.Value_ParaSlopeMin.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaSlopeMin.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(733, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "最大值";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "最小值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 35;
            this.label7.Text = "变换幅度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 34;
            this.label8.Text = "灵敏度";
            // 
            // TrackBar_ParaIntercept
            // 
            this.TrackBar_ParaIntercept.AutoSize = false;
            this.TrackBar_ParaIntercept.Location = new System.Drawing.Point(518, 186);
            this.TrackBar_ParaIntercept.Name = "TrackBar_ParaIntercept";
            this.TrackBar_ParaIntercept.Size = new System.Drawing.Size(116, 21);
            this.TrackBar_ParaIntercept.TabIndex = 33;
            // 
            // TrackBar_ParaSlope
            // 
            this.TrackBar_ParaSlope.AutoSize = false;
            this.TrackBar_ParaSlope.Location = new System.Drawing.Point(518, 146);
            this.TrackBar_ParaSlope.Name = "TrackBar_ParaSlope";
            this.TrackBar_ParaSlope.Size = new System.Drawing.Size(116, 21);
            this.TrackBar_ParaSlope.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 451);
            this.Controls.Add(this.Value_ParaInterceptMax);
            this.Controls.Add(this.Value_ParaInterceptMin);
            this.Controls.Add(this.Value_ParaSlopeMax);
            this.Controls.Add(this.Value_ParaSlopeMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TrackBar_ParaIntercept);
            this.Controls.Add(this.TrackBar_ParaSlope);
            this.Controls.Add(this.Value_ParaSigmaMax);
            this.Controls.Add(this.Value_ParaSigmaMin);
            this.Controls.Add(this.Value_ParaMiuMax);
            this.Controls.Add(this.Value_ParaMiuMin);
            this.Controls.Add(this.Label_ParaMax);
            this.Controls.Add(this.Label_ParaMin);
            this.Controls.Add(this.Label_ParaSigma);
            this.Controls.Add(this.Label_ParaMiu);
            this.Controls.Add(this.TrackBar_ParaSigma);
            this.Controls.Add(this.TrackBar_ParaMiu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FilePathScanButton);
            this.Controls.Add(this.ImageScanButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImgNum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CheckBoxAlgo2GrayScale);
            this.Controls.Add(this.CheckBoxAlgo1Gauss);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaMiu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaMiuMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaMiuMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigmaMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigmaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaInterceptMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaInterceptMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSlopeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSlopeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaIntercept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSlope)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox CheckBoxAlgo1Gauss;
        private System.Windows.Forms.CheckBox CheckBoxAlgo2GrayScale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown ImgNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ImageScanButton;
        private System.Windows.Forms.Button FilePathScanButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar TrackBar_ParaMiu;
        private System.Windows.Forms.TrackBar TrackBar_ParaSigma;
        private System.Windows.Forms.Label Label_ParaMiu;
        private System.Windows.Forms.Label Label_ParaSigma;
        private System.Windows.Forms.Label Label_ParaMin;
        private System.Windows.Forms.Label Label_ParaMax;
        private System.Windows.Forms.NumericUpDown Value_ParaMiuMin;
        private System.Windows.Forms.NumericUpDown Value_ParaMiuMax;
        private System.Windows.Forms.NumericUpDown Value_ParaSigmaMax;
        private System.Windows.Forms.NumericUpDown Value_ParaSigmaMin;
        private System.Windows.Forms.NumericUpDown Value_ParaInterceptMax;
        private System.Windows.Forms.NumericUpDown Value_ParaInterceptMin;
        private System.Windows.Forms.NumericUpDown Value_ParaSlopeMax;
        private System.Windows.Forms.NumericUpDown Value_ParaSlopeMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar TrackBar_ParaIntercept;
        private System.Windows.Forms.TrackBar TrackBar_ParaSlope;
    }
}

