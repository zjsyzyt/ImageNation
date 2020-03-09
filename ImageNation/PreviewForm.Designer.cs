namespace ImageNation
{
    partial class PreviewForm
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
            this.Button_PreviewForm = new System.Windows.Forms.Button();
            this.tabControl_MainForm = new System.Windows.Forms.TabControl();
            this.tabPage1_MainForm = new System.Windows.Forms.TabPage();
            this.Value_ParaMiuMax = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaSigma2Max = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaSigma2Min = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxAlgo1Gauss = new System.Windows.Forms.CheckBox();
            this.Label_Para3Max = new System.Windows.Forms.Label();
            this.TrackBar_ParaMiu = new System.Windows.Forms.TrackBar();
            this.Label_Para3Min = new System.Windows.Forms.Label();
            this.TrackBar_ParaSigma = new System.Windows.Forms.TrackBar();
            this.Label_ParaSigma2 = new System.Windows.Forms.Label();
            this.Label_ParaMiu = new System.Windows.Forms.Label();
            this.TrackBar_ParaSigma2 = new System.Windows.Forms.TrackBar();
            this.Label_ParaSigma = new System.Windows.Forms.Label();
            this.CheckBoxAlgo3GaussianBlur = new System.Windows.Forms.CheckBox();
            this.Label_Para1Min = new System.Windows.Forms.Label();
            this.Label_Para1Max = new System.Windows.Forms.Label();
            this.Value_ParaMiuMin = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaSigmaMin = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaSigmaMax = new System.Windows.Forms.NumericUpDown();
            this.tabPage2_MainForm = new System.Windows.Forms.TabPage();
            this.Value_ParaSlopeMax = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxAlgo2GrayScale = new System.Windows.Forms.CheckBox();
            this.Label_Para2Min = new System.Windows.Forms.Label();
            this.Label_Para2Max = new System.Windows.Forms.Label();
            this.Value_ParaInterceptMax = new System.Windows.Forms.NumericUpDown();
            this.Label_ParaIntercept = new System.Windows.Forms.Label();
            this.Value_ParaSlopeMin = new System.Windows.Forms.NumericUpDown();
            this.TrackBar_ParaSlope = new System.Windows.Forms.TrackBar();
            this.Label_ParaSlope = new System.Windows.Forms.Label();
            this.TrackBar_ParaIntercept = new System.Windows.Forms.TrackBar();
            this.Value_ParaInterceptMin = new System.Windows.Forms.NumericUpDown();
            this.tabPage3_MainForm = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl_MainForm.SuspendLayout();
            this.tabPage1_MainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaMiuMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigma2Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigma2Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaMiu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSigma2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaMiuMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigmaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigmaMax)).BeginInit();
            this.tabPage2_MainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSlopeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaInterceptMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSlopeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSlope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaIntercept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaInterceptMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_PreviewForm
            // 
            this.Button_PreviewForm.Location = new System.Drawing.Point(703, 310);
            this.Button_PreviewForm.Name = "Button_PreviewForm";
            this.Button_PreviewForm.Size = new System.Drawing.Size(127, 52);
            this.Button_PreviewForm.TabIndex = 54;
            this.Button_PreviewForm.Text = "退化预览";
            this.Button_PreviewForm.UseVisualStyleBackColor = true;
            // 
            // tabControl_MainForm
            // 
            this.tabControl_MainForm.Controls.Add(this.tabPage1_MainForm);
            this.tabControl_MainForm.Controls.Add(this.tabPage2_MainForm);
            this.tabControl_MainForm.Controls.Add(this.tabPage3_MainForm);
            this.tabControl_MainForm.Location = new System.Drawing.Point(463, 12);
            this.tabControl_MainForm.Name = "tabControl_MainForm";
            this.tabControl_MainForm.SelectedIndex = 0;
            this.tabControl_MainForm.Size = new System.Drawing.Size(371, 288);
            this.tabControl_MainForm.TabIndex = 53;
            // 
            // tabPage1_MainForm
            // 
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaMiuMax);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaSigma2Max);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaSigma2Min);
            this.tabPage1_MainForm.Controls.Add(this.CheckBoxAlgo1Gauss);
            this.tabPage1_MainForm.Controls.Add(this.Label_Para3Max);
            this.tabPage1_MainForm.Controls.Add(this.TrackBar_ParaMiu);
            this.tabPage1_MainForm.Controls.Add(this.Label_Para3Min);
            this.tabPage1_MainForm.Controls.Add(this.TrackBar_ParaSigma);
            this.tabPage1_MainForm.Controls.Add(this.Label_ParaSigma2);
            this.tabPage1_MainForm.Controls.Add(this.Label_ParaMiu);
            this.tabPage1_MainForm.Controls.Add(this.TrackBar_ParaSigma2);
            this.tabPage1_MainForm.Controls.Add(this.Label_ParaSigma);
            this.tabPage1_MainForm.Controls.Add(this.CheckBoxAlgo3GaussianBlur);
            this.tabPage1_MainForm.Controls.Add(this.Label_Para1Min);
            this.tabPage1_MainForm.Controls.Add(this.Label_Para1Max);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaMiuMin);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaSigmaMin);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaSigmaMax);
            this.tabPage1_MainForm.Location = new System.Drawing.Point(4, 22);
            this.tabPage1_MainForm.Name = "tabPage1_MainForm";
            this.tabPage1_MainForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1_MainForm.Size = new System.Drawing.Size(363, 262);
            this.tabPage1_MainForm.TabIndex = 0;
            this.tabPage1_MainForm.Text = "加噪、模糊";
            this.tabPage1_MainForm.UseVisualStyleBackColor = true;
            // 
            // Value_ParaMiuMax
            // 
            this.Value_ParaMiuMax.Location = new System.Drawing.Point(279, 43);
            this.Value_ParaMiuMax.Name = "Value_ParaMiuMax";
            this.Value_ParaMiuMax.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaMiuMax.TabIndex = 29;
            this.Value_ParaMiuMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Value_ParaSigma2Max
            // 
            this.Value_ParaSigma2Max.Location = new System.Drawing.Point(279, 156);
            this.Value_ParaSigma2Max.Name = "Value_ParaSigma2Max";
            this.Value_ParaSigma2Max.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaSigma2Max.TabIndex = 49;
            this.Value_ParaSigma2Max.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // Value_ParaSigma2Min
            // 
            this.Value_ParaSigma2Min.Location = new System.Drawing.Point(196, 156);
            this.Value_ParaSigma2Min.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Value_ParaSigma2Min.Name = "Value_ParaSigma2Min";
            this.Value_ParaSigma2Min.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaSigma2Min.TabIndex = 48;
            this.Value_ParaSigma2Min.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // CheckBoxAlgo1Gauss
            // 
            this.CheckBoxAlgo1Gauss.AutoSize = true;
            this.CheckBoxAlgo1Gauss.Location = new System.Drawing.Point(17, 16);
            this.CheckBoxAlgo1Gauss.Name = "CheckBoxAlgo1Gauss";
            this.CheckBoxAlgo1Gauss.Size = new System.Drawing.Size(72, 16);
            this.CheckBoxAlgo1Gauss.TabIndex = 4;
            this.CheckBoxAlgo1Gauss.Text = "高斯噪声";
            this.CheckBoxAlgo1Gauss.UseVisualStyleBackColor = true;
            // 
            // Label_Para3Max
            // 
            this.Label_Para3Max.AutoSize = true;
            this.Label_Para3Max.Location = new System.Drawing.Point(287, 137);
            this.Label_Para3Max.Name = "Label_Para3Max";
            this.Label_Para3Max.Size = new System.Drawing.Size(41, 12);
            this.Label_Para3Max.TabIndex = 47;
            this.Label_Para3Max.Text = "最大值";
            // 
            // TrackBar_ParaMiu
            // 
            this.TrackBar_ParaMiu.AutoSize = false;
            this.TrackBar_ParaMiu.Location = new System.Drawing.Point(72, 43);
            this.TrackBar_ParaMiu.Name = "TrackBar_ParaMiu";
            this.TrackBar_ParaMiu.Size = new System.Drawing.Size(116, 21);
            this.TrackBar_ParaMiu.TabIndex = 18;
            // 
            // Label_Para3Min
            // 
            this.Label_Para3Min.AutoSize = true;
            this.Label_Para3Min.Location = new System.Drawing.Point(204, 137);
            this.Label_Para3Min.Name = "Label_Para3Min";
            this.Label_Para3Min.Size = new System.Drawing.Size(41, 12);
            this.Label_Para3Min.TabIndex = 46;
            this.Label_Para3Min.Text = "最小值";
            // 
            // TrackBar_ParaSigma
            // 
            this.TrackBar_ParaSigma.AutoSize = false;
            this.TrackBar_ParaSigma.Location = new System.Drawing.Point(72, 83);
            this.TrackBar_ParaSigma.Name = "TrackBar_ParaSigma";
            this.TrackBar_ParaSigma.Size = new System.Drawing.Size(116, 21);
            this.TrackBar_ParaSigma.TabIndex = 19;
            // 
            // Label_ParaSigma2
            // 
            this.Label_ParaSigma2.AutoSize = true;
            this.Label_ParaSigma2.Location = new System.Drawing.Point(15, 160);
            this.Label_ParaSigma2.Name = "Label_ParaSigma2";
            this.Label_ParaSigma2.Size = new System.Drawing.Size(41, 12);
            this.Label_ParaSigma2.TabIndex = 45;
            this.Label_ParaSigma2.Text = "模糊度";
            // 
            // Label_ParaMiu
            // 
            this.Label_ParaMiu.AutoSize = true;
            this.Label_ParaMiu.Location = new System.Drawing.Point(15, 47);
            this.Label_ParaMiu.Name = "Label_ParaMiu";
            this.Label_ParaMiu.Size = new System.Drawing.Size(53, 12);
            this.Label_ParaMiu.TabIndex = 20;
            this.Label_ParaMiu.Text = "噪声幅度";
            // 
            // TrackBar_ParaSigma2
            // 
            this.TrackBar_ParaSigma2.AutoSize = false;
            this.TrackBar_ParaSigma2.Location = new System.Drawing.Point(72, 156);
            this.TrackBar_ParaSigma2.Name = "TrackBar_ParaSigma2";
            this.TrackBar_ParaSigma2.Size = new System.Drawing.Size(116, 21);
            this.TrackBar_ParaSigma2.TabIndex = 44;
            // 
            // Label_ParaSigma
            // 
            this.Label_ParaSigma.AutoSize = true;
            this.Label_ParaSigma.Location = new System.Drawing.Point(15, 87);
            this.Label_ParaSigma.Name = "Label_ParaSigma";
            this.Label_ParaSigma.Size = new System.Drawing.Size(53, 12);
            this.Label_ParaSigma.TabIndex = 21;
            this.Label_ParaSigma.Text = "噪声密度";
            // 
            // CheckBoxAlgo3GaussianBlur
            // 
            this.CheckBoxAlgo3GaussianBlur.AutoSize = true;
            this.CheckBoxAlgo3GaussianBlur.Location = new System.Drawing.Point(17, 133);
            this.CheckBoxAlgo3GaussianBlur.Name = "CheckBoxAlgo3GaussianBlur";
            this.CheckBoxAlgo3GaussianBlur.Size = new System.Drawing.Size(72, 16);
            this.CheckBoxAlgo3GaussianBlur.TabIndex = 43;
            this.CheckBoxAlgo3GaussianBlur.Text = "图像模糊";
            this.CheckBoxAlgo3GaussianBlur.UseVisualStyleBackColor = true;
            // 
            // Label_Para1Min
            // 
            this.Label_Para1Min.AutoSize = true;
            this.Label_Para1Min.Location = new System.Drawing.Point(204, 24);
            this.Label_Para1Min.Name = "Label_Para1Min";
            this.Label_Para1Min.Size = new System.Drawing.Size(41, 12);
            this.Label_Para1Min.TabIndex = 22;
            this.Label_Para1Min.Text = "最小值";
            // 
            // Label_Para1Max
            // 
            this.Label_Para1Max.AutoSize = true;
            this.Label_Para1Max.Location = new System.Drawing.Point(287, 24);
            this.Label_Para1Max.Name = "Label_Para1Max";
            this.Label_Para1Max.Size = new System.Drawing.Size(41, 12);
            this.Label_Para1Max.TabIndex = 23;
            this.Label_Para1Max.Text = "最大值";
            // 
            // Value_ParaMiuMin
            // 
            this.Value_ParaMiuMin.Location = new System.Drawing.Point(196, 43);
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
            this.Value_ParaMiuMin.Value = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            // 
            // Value_ParaSigmaMin
            // 
            this.Value_ParaSigmaMin.Location = new System.Drawing.Point(196, 83);
            this.Value_ParaSigmaMin.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Value_ParaSigmaMin.Name = "Value_ParaSigmaMin";
            this.Value_ParaSigmaMin.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaSigmaMin.TabIndex = 30;
            this.Value_ParaSigmaMin.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Value_ParaSigmaMax
            // 
            this.Value_ParaSigmaMax.Location = new System.Drawing.Point(279, 83);
            this.Value_ParaSigmaMax.Name = "Value_ParaSigmaMax";
            this.Value_ParaSigmaMax.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaSigmaMax.TabIndex = 31;
            this.Value_ParaSigmaMax.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // tabPage2_MainForm
            // 
            this.tabPage2_MainForm.Controls.Add(this.Value_ParaSlopeMax);
            this.tabPage2_MainForm.Controls.Add(this.CheckBoxAlgo2GrayScale);
            this.tabPage2_MainForm.Controls.Add(this.Label_Para2Min);
            this.tabPage2_MainForm.Controls.Add(this.Label_Para2Max);
            this.tabPage2_MainForm.Controls.Add(this.Value_ParaInterceptMax);
            this.tabPage2_MainForm.Controls.Add(this.Label_ParaIntercept);
            this.tabPage2_MainForm.Controls.Add(this.Value_ParaSlopeMin);
            this.tabPage2_MainForm.Controls.Add(this.TrackBar_ParaSlope);
            this.tabPage2_MainForm.Controls.Add(this.Label_ParaSlope);
            this.tabPage2_MainForm.Controls.Add(this.TrackBar_ParaIntercept);
            this.tabPage2_MainForm.Controls.Add(this.Value_ParaInterceptMin);
            this.tabPage2_MainForm.Location = new System.Drawing.Point(4, 22);
            this.tabPage2_MainForm.Name = "tabPage2_MainForm";
            this.tabPage2_MainForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2_MainForm.Size = new System.Drawing.Size(363, 262);
            this.tabPage2_MainForm.TabIndex = 1;
            this.tabPage2_MainForm.Text = "分辨率、对比度";
            this.tabPage2_MainForm.UseVisualStyleBackColor = true;
            // 
            // Value_ParaSlopeMax
            // 
            this.Value_ParaSlopeMax.Location = new System.Drawing.Point(273, 62);
            this.Value_ParaSlopeMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.Value_ParaSlopeMax.Name = "Value_ParaSlopeMax";
            this.Value_ParaSlopeMax.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaSlopeMax.TabIndex = 39;
            this.Value_ParaSlopeMax.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // CheckBoxAlgo2GrayScale
            // 
            this.CheckBoxAlgo2GrayScale.AutoSize = true;
            this.CheckBoxAlgo2GrayScale.Location = new System.Drawing.Point(16, 12);
            this.CheckBoxAlgo2GrayScale.Name = "CheckBoxAlgo2GrayScale";
            this.CheckBoxAlgo2GrayScale.Size = new System.Drawing.Size(72, 16);
            this.CheckBoxAlgo2GrayScale.TabIndex = 5;
            this.CheckBoxAlgo2GrayScale.Text = "灰度变化";
            this.CheckBoxAlgo2GrayScale.UseVisualStyleBackColor = true;
            // 
            // Label_Para2Min
            // 
            this.Label_Para2Min.AutoSize = true;
            this.Label_Para2Min.Location = new System.Drawing.Point(205, 36);
            this.Label_Para2Min.Name = "Label_Para2Min";
            this.Label_Para2Min.Size = new System.Drawing.Size(41, 12);
            this.Label_Para2Min.TabIndex = 36;
            this.Label_Para2Min.Text = "最小值";
            // 
            // Label_Para2Max
            // 
            this.Label_Para2Max.AutoSize = true;
            this.Label_Para2Max.Location = new System.Drawing.Point(288, 36);
            this.Label_Para2Max.Name = "Label_Para2Max";
            this.Label_Para2Max.Size = new System.Drawing.Size(41, 12);
            this.Label_Para2Max.TabIndex = 37;
            this.Label_Para2Max.Text = "最大值";
            // 
            // Value_ParaInterceptMax
            // 
            this.Value_ParaInterceptMax.Location = new System.Drawing.Point(273, 102);
            this.Value_ParaInterceptMax.Name = "Value_ParaInterceptMax";
            this.Value_ParaInterceptMax.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaInterceptMax.TabIndex = 41;
            this.Value_ParaInterceptMax.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Label_ParaIntercept
            // 
            this.Label_ParaIntercept.AutoSize = true;
            this.Label_ParaIntercept.Location = new System.Drawing.Point(9, 106);
            this.Label_ParaIntercept.Name = "Label_ParaIntercept";
            this.Label_ParaIntercept.Size = new System.Drawing.Size(53, 12);
            this.Label_ParaIntercept.TabIndex = 35;
            this.Label_ParaIntercept.Text = "变换幅度";
            // 
            // Value_ParaSlopeMin
            // 
            this.Value_ParaSlopeMin.Location = new System.Drawing.Point(190, 62);
            this.Value_ParaSlopeMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.Value_ParaSlopeMin.Name = "Value_ParaSlopeMin";
            this.Value_ParaSlopeMin.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaSlopeMin.TabIndex = 38;
            this.Value_ParaSlopeMin.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // TrackBar_ParaSlope
            // 
            this.TrackBar_ParaSlope.AutoSize = false;
            this.TrackBar_ParaSlope.Location = new System.Drawing.Point(66, 62);
            this.TrackBar_ParaSlope.Name = "TrackBar_ParaSlope";
            this.TrackBar_ParaSlope.Size = new System.Drawing.Size(116, 21);
            this.TrackBar_ParaSlope.TabIndex = 32;
            // 
            // Label_ParaSlope
            // 
            this.Label_ParaSlope.AutoSize = true;
            this.Label_ParaSlope.Location = new System.Drawing.Point(9, 66);
            this.Label_ParaSlope.Name = "Label_ParaSlope";
            this.Label_ParaSlope.Size = new System.Drawing.Size(41, 12);
            this.Label_ParaSlope.TabIndex = 34;
            this.Label_ParaSlope.Text = "灵敏度";
            // 
            // TrackBar_ParaIntercept
            // 
            this.TrackBar_ParaIntercept.AutoSize = false;
            this.TrackBar_ParaIntercept.Location = new System.Drawing.Point(66, 102);
            this.TrackBar_ParaIntercept.Name = "TrackBar_ParaIntercept";
            this.TrackBar_ParaIntercept.Size = new System.Drawing.Size(116, 21);
            this.TrackBar_ParaIntercept.TabIndex = 33;
            // 
            // Value_ParaInterceptMin
            // 
            this.Value_ParaInterceptMin.Location = new System.Drawing.Point(190, 102);
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
            this.Value_ParaInterceptMin.Value = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            // 
            // tabPage3_MainForm
            // 
            this.tabPage3_MainForm.Location = new System.Drawing.Point(4, 22);
            this.tabPage3_MainForm.Name = "tabPage3_MainForm";
            this.tabPage3_MainForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3_MainForm.Size = new System.Drawing.Size(363, 262);
            this.tabPage3_MainForm.TabIndex = 2;
            this.tabPage3_MainForm.Text = "空间移动";
            this.tabPage3_MainForm.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 383);
            this.Controls.Add(this.Button_PreviewForm);
            this.Controls.Add(this.tabControl_MainForm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PreviewForm";
            this.Text = "PreviewForm";
            this.tabControl_MainForm.ResumeLayout(false);
            this.tabPage1_MainForm.ResumeLayout(false);
            this.tabPage1_MainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaMiuMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigma2Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigma2Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaMiu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSigma2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaMiuMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigmaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigmaMax)).EndInit();
            this.tabPage2_MainForm.ResumeLayout(false);
            this.tabPage2_MainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSlopeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaInterceptMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSlopeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSlope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaIntercept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaInterceptMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_PreviewForm;
        private System.Windows.Forms.TabControl tabControl_MainForm;
        private System.Windows.Forms.TabPage tabPage1_MainForm;
        private System.Windows.Forms.NumericUpDown Value_ParaMiuMax;
        private System.Windows.Forms.NumericUpDown Value_ParaSigma2Max;
        private System.Windows.Forms.NumericUpDown Value_ParaSigma2Min;
        private System.Windows.Forms.CheckBox CheckBoxAlgo1Gauss;
        private System.Windows.Forms.Label Label_Para3Max;
        private System.Windows.Forms.TrackBar TrackBar_ParaMiu;
        private System.Windows.Forms.Label Label_Para3Min;
        private System.Windows.Forms.TrackBar TrackBar_ParaSigma;
        private System.Windows.Forms.Label Label_ParaSigma2;
        private System.Windows.Forms.Label Label_ParaMiu;
        private System.Windows.Forms.TrackBar TrackBar_ParaSigma2;
        private System.Windows.Forms.Label Label_ParaSigma;
        private System.Windows.Forms.CheckBox CheckBoxAlgo3GaussianBlur;
        private System.Windows.Forms.Label Label_Para1Min;
        private System.Windows.Forms.Label Label_Para1Max;
        private System.Windows.Forms.NumericUpDown Value_ParaMiuMin;
        private System.Windows.Forms.NumericUpDown Value_ParaSigmaMin;
        private System.Windows.Forms.NumericUpDown Value_ParaSigmaMax;
        private System.Windows.Forms.TabPage tabPage2_MainForm;
        private System.Windows.Forms.NumericUpDown Value_ParaSlopeMax;
        private System.Windows.Forms.CheckBox CheckBoxAlgo2GrayScale;
        private System.Windows.Forms.Label Label_Para2Min;
        private System.Windows.Forms.Label Label_Para2Max;
        private System.Windows.Forms.NumericUpDown Value_ParaInterceptMax;
        private System.Windows.Forms.Label Label_ParaIntercept;
        private System.Windows.Forms.NumericUpDown Value_ParaSlopeMin;
        private System.Windows.Forms.TrackBar TrackBar_ParaSlope;
        private System.Windows.Forms.Label Label_ParaSlope;
        private System.Windows.Forms.TrackBar TrackBar_ParaIntercept;
        private System.Windows.Forms.NumericUpDown Value_ParaInterceptMin;
        private System.Windows.Forms.TabPage tabPage3_MainForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}