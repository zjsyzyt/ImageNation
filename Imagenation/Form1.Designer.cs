﻿namespace ImageNation
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
            this.Button_StartDegradation = new System.Windows.Forms.Button();
            this.ImgNum = new System.Windows.Forms.NumericUpDown();
            this.Label_ImgNum = new System.Windows.Forms.Label();
            this.Button_ImageScan = new System.Windows.Forms.Button();
            this.Button_FilePathScan = new System.Windows.Forms.Button();
            this.ImgStorageFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.TextBox_ImgPath = new System.Windows.Forms.TextBox();
            this.TextBox_ImgStoragePath = new System.Windows.Forms.TextBox();
            this.Label_ImgPath = new System.Windows.Forms.Label();
            this.Label_ImgStoragePath = new System.Windows.Forms.Label();
            this.OpenImgFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TextBox_FileNamePrefix = new System.Windows.Forms.TextBox();
            this.Label_FileNamePrefix = new System.Windows.Forms.Label();
            this.TrackBar_ParaMiu = new System.Windows.Forms.TrackBar();
            this.TrackBar_ParaSigma = new System.Windows.Forms.TrackBar();
            this.Label_ParaMiu = new System.Windows.Forms.Label();
            this.Label_ParaSigma = new System.Windows.Forms.Label();
            this.Label_Para1Min = new System.Windows.Forms.Label();
            this.Label_Para1Max = new System.Windows.Forms.Label();
            this.Value_ParaMiuMin = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaMiuMax = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaSigmaMax = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaSigmaMin = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaInterceptMax = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaInterceptMin = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaSlopeMax = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaSlopeMin = new System.Windows.Forms.NumericUpDown();
            this.Label_Para2Max = new System.Windows.Forms.Label();
            this.Label_Para2Min = new System.Windows.Forms.Label();
            this.Label_ParaIntercept = new System.Windows.Forms.Label();
            this.Label_ParaSlope = new System.Windows.Forms.Label();
            this.TrackBar_ParaIntercept = new System.Windows.Forms.TrackBar();
            this.TrackBar_ParaSlope = new System.Windows.Forms.TrackBar();
            this.pBarImg = new System.Windows.Forms.ProgressBar();
            this.Value_ParaSigma2Max = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaSigma2Min = new System.Windows.Forms.NumericUpDown();
            this.Label_Para3Max = new System.Windows.Forms.Label();
            this.Label_Para3Min = new System.Windows.Forms.Label();
            this.Label_ParaSigma2 = new System.Windows.Forms.Label();
            this.TrackBar_ParaSigma2 = new System.Windows.Forms.TrackBar();
            this.CheckBoxAlgo3GaussianBlur = new System.Windows.Forms.CheckBox();
            this.tabControl_MainForm = new System.Windows.Forms.TabControl();
            this.tabPage1_MainForm = new System.Windows.Forms.TabPage();
            this.tabPage2_MainForm = new System.Windows.Forms.TabPage();
            this.tabPage3_MainForm = new System.Windows.Forms.TabPage();
            this.Button_PreviewForm = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigma2Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigma2Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSigma2)).BeginInit();
            this.tabControl_MainForm.SuspendLayout();
            this.tabPage1_MainForm.SuspendLayout();
            this.tabPage2_MainForm.SuspendLayout();
            this.SuspendLayout();
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
            this.CheckBoxAlgo1Gauss.CheckedChanged += new System.EventHandler(this.CheckBoxAlgo1Gauss_CheckedChanged);
            this.CheckBoxAlgo1Gauss.Click += new System.EventHandler(this.CheckBoxAlgo1Gauss_CheckedChanged);
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
            this.CheckBoxAlgo2GrayScale.CheckedChanged += new System.EventHandler(this.CheckBoxAlgo2GrayScale_CheckedChanged);
            this.CheckBoxAlgo2GrayScale.Click += new System.EventHandler(this.CheckBoxAlgo2GrayScale_CheckedChanged);
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
            // Button_StartDegradation
            // 
            this.Button_StartDegradation.BackColor = System.Drawing.Color.Transparent;
            this.Button_StartDegradation.Location = new System.Drawing.Point(703, 381);
            this.Button_StartDegradation.Name = "Button_StartDegradation";
            this.Button_StartDegradation.Size = new System.Drawing.Size(127, 52);
            this.Button_StartDegradation.TabIndex = 0;
            this.Button_StartDegradation.Text = "启动退化";
            this.Button_StartDegradation.UseVisualStyleBackColor = false;
            this.Button_StartDegradation.Click += new System.EventHandler(this.Button_StartDegradation_Click);
            // 
            // ImgNum
            // 
            this.ImgNum.Location = new System.Drawing.Point(553, 380);
            this.ImgNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ImgNum.Name = "ImgNum";
            this.ImgNum.Size = new System.Drawing.Size(96, 21);
            this.ImgNum.TabIndex = 8;
            this.ImgNum.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ImgNum.ValueChanged += new System.EventHandler(this.ImgNum_ValueChanged);
            // 
            // Label_ImgNum
            // 
            this.Label_ImgNum.AutoSize = true;
            this.Label_ImgNum.Font = new System.Drawing.Font("宋体", 9F);
            this.Label_ImgNum.Location = new System.Drawing.Point(482, 384);
            this.Label_ImgNum.Name = "Label_ImgNum";
            this.Label_ImgNum.Size = new System.Drawing.Size(65, 12);
            this.Label_ImgNum.TabIndex = 9;
            this.Label_ImgNum.Text = "图像数量：";
            // 
            // Button_ImageScan
            // 
            this.Button_ImageScan.Location = new System.Drawing.Point(360, 380);
            this.Button_ImageScan.Name = "Button_ImageScan";
            this.Button_ImageScan.Size = new System.Drawing.Size(75, 23);
            this.Button_ImageScan.TabIndex = 10;
            this.Button_ImageScan.Text = "浏览";
            this.Button_ImageScan.UseVisualStyleBackColor = true;
            this.Button_ImageScan.Click += new System.EventHandler(this.Button_ImageScan_Click);
            // 
            // Button_FilePathScan
            // 
            this.Button_FilePathScan.Location = new System.Drawing.Point(360, 410);
            this.Button_FilePathScan.Name = "Button_FilePathScan";
            this.Button_FilePathScan.Size = new System.Drawing.Size(75, 23);
            this.Button_FilePathScan.TabIndex = 11;
            this.Button_FilePathScan.Text = "浏览";
            this.Button_FilePathScan.UseVisualStyleBackColor = true;
            this.Button_FilePathScan.Click += new System.EventHandler(this.Button_FilePathScan_Click);
            // 
            // ImgStorageFolder
            // 
            this.ImgStorageFolder.SelectedPath = "C:\\Users\\zjsyzyt\\Pictures";
            this.ImgStorageFolder.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // TextBox_ImgPath
            // 
            this.TextBox_ImgPath.Location = new System.Drawing.Point(77, 381);
            this.TextBox_ImgPath.Name = "TextBox_ImgPath";
            this.TextBox_ImgPath.Size = new System.Drawing.Size(282, 21);
            this.TextBox_ImgPath.TabIndex = 12;
            // 
            // TextBox_ImgStoragePath
            // 
            this.TextBox_ImgStoragePath.Location = new System.Drawing.Point(77, 411);
            this.TextBox_ImgStoragePath.Name = "TextBox_ImgStoragePath";
            this.TextBox_ImgStoragePath.Size = new System.Drawing.Size(282, 21);
            this.TextBox_ImgStoragePath.TabIndex = 13;
            // 
            // Label_ImgPath
            // 
            this.Label_ImgPath.AutoSize = true;
            this.Label_ImgPath.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_ImgPath.Location = new System.Drawing.Point(12, 384);
            this.Label_ImgPath.Name = "Label_ImgPath";
            this.Label_ImgPath.Size = new System.Drawing.Size(59, 12);
            this.Label_ImgPath.TabIndex = 14;
            this.Label_ImgPath.Text = "图像路径:";
            // 
            // Label_ImgStoragePath
            // 
            this.Label_ImgStoragePath.AutoSize = true;
            this.Label_ImgStoragePath.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ImgStoragePath.Location = new System.Drawing.Point(12, 414);
            this.Label_ImgStoragePath.Name = "Label_ImgStoragePath";
            this.Label_ImgStoragePath.Size = new System.Drawing.Size(59, 12);
            this.Label_ImgStoragePath.TabIndex = 15;
            this.Label_ImgStoragePath.Text = "存储路径:";
            // 
            // OpenImgFileDialog
            // 
            this.OpenImgFileDialog.FileName = "openFileDialog1";
            this.OpenImgFileDialog.InitialDirectory = "C:\\Users\\zjsyzyt\\Pictures";
            this.OpenImgFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenImgFileDialog_FileOk);
            // 
            // TextBox_FileNamePrefix
            // 
            this.TextBox_FileNamePrefix.Location = new System.Drawing.Point(590, 411);
            this.TextBox_FileNamePrefix.Name = "TextBox_FileNamePrefix";
            this.TextBox_FileNamePrefix.Size = new System.Drawing.Size(59, 21);
            this.TextBox_FileNamePrefix.TabIndex = 16;
            this.TextBox_FileNamePrefix.Text = "Images";
            this.TextBox_FileNamePrefix.TextChanged += new System.EventHandler(this.FileNamePrefix_TextChanged);
            // 
            // Label_FileNamePrefix
            // 
            this.Label_FileNamePrefix.AutoSize = true;
            this.Label_FileNamePrefix.Location = new System.Drawing.Point(482, 415);
            this.Label_FileNamePrefix.Name = "Label_FileNamePrefix";
            this.Label_FileNamePrefix.Size = new System.Drawing.Size(101, 12);
            this.Label_FileNamePrefix.TabIndex = 17;
            this.Label_FileNamePrefix.Text = "文件名（前缀）：";
            // 
            // TrackBar_ParaMiu
            // 
            this.TrackBar_ParaMiu.AutoSize = false;
            this.TrackBar_ParaMiu.Location = new System.Drawing.Point(72, 43);
            this.TrackBar_ParaMiu.Name = "TrackBar_ParaMiu";
            this.TrackBar_ParaMiu.Size = new System.Drawing.Size(116, 21);
            this.TrackBar_ParaMiu.TabIndex = 18;
            // 
            // TrackBar_ParaSigma
            // 
            this.TrackBar_ParaSigma.AutoSize = false;
            this.TrackBar_ParaSigma.Location = new System.Drawing.Point(72, 83);
            this.TrackBar_ParaSigma.Name = "TrackBar_ParaSigma";
            this.TrackBar_ParaSigma.Size = new System.Drawing.Size(116, 21);
            this.TrackBar_ParaSigma.TabIndex = 19;
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
            // Label_ParaSigma
            // 
            this.Label_ParaSigma.AutoSize = true;
            this.Label_ParaSigma.Location = new System.Drawing.Point(15, 87);
            this.Label_ParaSigma.Name = "Label_ParaSigma";
            this.Label_ParaSigma.Size = new System.Drawing.Size(53, 12);
            this.Label_ParaSigma.TabIndex = 21;
            this.Label_ParaSigma.Text = "噪声密度";
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
            this.Value_ParaMiuMin.ValueChanged += new System.EventHandler(this.Value_ParaMiuMin_ValueChanged);
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
            this.Value_ParaMiuMax.ValueChanged += new System.EventHandler(this.Value_ParaMiuMax_ValueChanged);
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
            this.Value_ParaSigmaMax.ValueChanged += new System.EventHandler(this.Value_ParaSigmaMax_ValueChanged);
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
            this.Value_ParaSigmaMin.ValueChanged += new System.EventHandler(this.Value_ParaSigmaMin_ValueChanged);
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
            // Label_Para2Max
            // 
            this.Label_Para2Max.AutoSize = true;
            this.Label_Para2Max.Location = new System.Drawing.Point(288, 36);
            this.Label_Para2Max.Name = "Label_Para2Max";
            this.Label_Para2Max.Size = new System.Drawing.Size(41, 12);
            this.Label_Para2Max.TabIndex = 37;
            this.Label_Para2Max.Text = "最大值";
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
            // Label_ParaIntercept
            // 
            this.Label_ParaIntercept.AutoSize = true;
            this.Label_ParaIntercept.Location = new System.Drawing.Point(9, 106);
            this.Label_ParaIntercept.Name = "Label_ParaIntercept";
            this.Label_ParaIntercept.Size = new System.Drawing.Size(53, 12);
            this.Label_ParaIntercept.TabIndex = 35;
            this.Label_ParaIntercept.Text = "变换幅度";
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
            // TrackBar_ParaSlope
            // 
            this.TrackBar_ParaSlope.AutoSize = false;
            this.TrackBar_ParaSlope.Location = new System.Drawing.Point(66, 62);
            this.TrackBar_ParaSlope.Name = "TrackBar_ParaSlope";
            this.TrackBar_ParaSlope.Size = new System.Drawing.Size(116, 21);
            this.TrackBar_ParaSlope.TabIndex = 32;
            // 
            // pBarImg
            // 
            this.pBarImg.Location = new System.Drawing.Point(703, 381);
            this.pBarImg.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pBarImg.Name = "pBarImg";
            this.pBarImg.Size = new System.Drawing.Size(127, 52);
            this.pBarImg.TabIndex = 42;
            this.pBarImg.Click += new System.EventHandler(this.pBarImg_Click);
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
            this.Value_ParaSigma2Max.ValueChanged += new System.EventHandler(this.Value_ParaSigma2Max_ValueChanged);
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
            this.Value_ParaSigma2Min.ValueChanged += new System.EventHandler(this.Value_ParaSigma2Min_ValueChanged);
            // 
            // Label_Para3Max
            // 
            this.Label_Para3Max.AutoSize = true;
            this.Label_Para3Max.Location = new System.Drawing.Point(287, 137);
            this.Label_Para3Max.Name = "Label_Para3Max";
            this.Label_Para3Max.Size = new System.Drawing.Size(41, 12);
            this.Label_Para3Max.TabIndex = 47;
            this.Label_Para3Max.Text = "最大值";
            this.Label_Para3Max.Click += new System.EventHandler(this.Label_Para3Max_Click);
            // 
            // Label_Para3Min
            // 
            this.Label_Para3Min.AutoSize = true;
            this.Label_Para3Min.Location = new System.Drawing.Point(204, 137);
            this.Label_Para3Min.Name = "Label_Para3Min";
            this.Label_Para3Min.Size = new System.Drawing.Size(41, 12);
            this.Label_Para3Min.TabIndex = 46;
            this.Label_Para3Min.Text = "最小值";
            this.Label_Para3Min.Click += new System.EventHandler(this.Label_Para3Min_Click);
            // 
            // Label_ParaSigma2
            // 
            this.Label_ParaSigma2.AutoSize = true;
            this.Label_ParaSigma2.Location = new System.Drawing.Point(15, 160);
            this.Label_ParaSigma2.Name = "Label_ParaSigma2";
            this.Label_ParaSigma2.Size = new System.Drawing.Size(41, 12);
            this.Label_ParaSigma2.TabIndex = 45;
            this.Label_ParaSigma2.Text = "模糊度";
            this.Label_ParaSigma2.Click += new System.EventHandler(this.Label_ParaSigma2_Click);
            // 
            // TrackBar_ParaSigma2
            // 
            this.TrackBar_ParaSigma2.AutoSize = false;
            this.TrackBar_ParaSigma2.Location = new System.Drawing.Point(72, 156);
            this.TrackBar_ParaSigma2.Name = "TrackBar_ParaSigma2";
            this.TrackBar_ParaSigma2.Size = new System.Drawing.Size(116, 21);
            this.TrackBar_ParaSigma2.TabIndex = 44;
            this.TrackBar_ParaSigma2.Scroll += new System.EventHandler(this.TrackBar_ParaSigma2_Scroll);
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
            this.CheckBoxAlgo3GaussianBlur.CheckedChanged += new System.EventHandler(this.CheckBoxAlgo3GaussianBlur_CheckedChanged);
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
            this.tabControl_MainForm.TabIndex = 50;
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
            // Button_PreviewForm
            // 
            this.Button_PreviewForm.Location = new System.Drawing.Point(703, 310);
            this.Button_PreviewForm.Name = "Button_PreviewForm";
            this.Button_PreviewForm.Size = new System.Drawing.Size(127, 52);
            this.Button_PreviewForm.TabIndex = 51;
            this.Button_PreviewForm.Text = "退化预览";
            this.Button_PreviewForm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 451);
            this.Controls.Add(this.Button_PreviewForm);
            this.Controls.Add(this.tabControl_MainForm);
            this.Controls.Add(this.Label_FileNamePrefix);
            this.Controls.Add(this.TextBox_FileNamePrefix);
            this.Controls.Add(this.Label_ImgStoragePath);
            this.Controls.Add(this.Label_ImgPath);
            this.Controls.Add(this.TextBox_ImgStoragePath);
            this.Controls.Add(this.TextBox_ImgPath);
            this.Controls.Add(this.Button_FilePathScan);
            this.Controls.Add(this.Button_ImageScan);
            this.Controls.Add(this.Label_ImgNum);
            this.Controls.Add(this.ImgNum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Button_StartDegradation);
            this.Controls.Add(this.pBarImg);
            this.Name = "Form1";
            this.Text = "图像退化软件";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigma2Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigma2Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSigma2)).EndInit();
            this.tabControl_MainForm.ResumeLayout(false);
            this.tabPage1_MainForm.ResumeLayout(false);
            this.tabPage1_MainForm.PerformLayout();
            this.tabPage2_MainForm.ResumeLayout(false);
            this.tabPage2_MainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox CheckBoxAlgo1Gauss;
        private System.Windows.Forms.CheckBox CheckBoxAlgo2GrayScale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_StartDegradation;
        private System.Windows.Forms.NumericUpDown ImgNum;
        private System.Windows.Forms.Label Label_ImgNum;
        private System.Windows.Forms.Button Button_ImageScan;
        private System.Windows.Forms.Button Button_FilePathScan;
        private System.Windows.Forms.FolderBrowserDialog ImgStorageFolder;
        private System.Windows.Forms.TextBox TextBox_ImgPath;
        private System.Windows.Forms.TextBox TextBox_ImgStoragePath;
        private System.Windows.Forms.Label Label_ImgPath;
        private System.Windows.Forms.Label Label_ImgStoragePath;
        private System.Windows.Forms.OpenFileDialog OpenImgFileDialog;
        private System.Windows.Forms.TextBox TextBox_FileNamePrefix;
        private System.Windows.Forms.Label Label_FileNamePrefix;
        private System.Windows.Forms.TrackBar TrackBar_ParaMiu;
        private System.Windows.Forms.TrackBar TrackBar_ParaSigma;
        private System.Windows.Forms.Label Label_ParaMiu;
        private System.Windows.Forms.Label Label_ParaSigma;
        private System.Windows.Forms.Label Label_Para1Min;
        private System.Windows.Forms.Label Label_Para1Max;
        private System.Windows.Forms.NumericUpDown Value_ParaMiuMin;
        private System.Windows.Forms.NumericUpDown Value_ParaMiuMax;
        private System.Windows.Forms.NumericUpDown Value_ParaSigmaMax;
        private System.Windows.Forms.NumericUpDown Value_ParaSigmaMin;
        private System.Windows.Forms.NumericUpDown Value_ParaInterceptMax;
        private System.Windows.Forms.NumericUpDown Value_ParaInterceptMin;
        private System.Windows.Forms.NumericUpDown Value_ParaSlopeMax;
        private System.Windows.Forms.NumericUpDown Value_ParaSlopeMin;
        private System.Windows.Forms.Label Label_Para2Max;
        private System.Windows.Forms.Label Label_Para2Min;
        private System.Windows.Forms.Label Label_ParaIntercept;
        private System.Windows.Forms.Label Label_ParaSlope;
        private System.Windows.Forms.TrackBar TrackBar_ParaIntercept;
        private System.Windows.Forms.TrackBar TrackBar_ParaSlope;
        private System.Windows.Forms.ProgressBar pBarImg;
        private System.Windows.Forms.NumericUpDown Value_ParaSigma2Max;
        private System.Windows.Forms.NumericUpDown Value_ParaSigma2Min;
        private System.Windows.Forms.Label Label_Para3Max;
        private System.Windows.Forms.Label Label_Para3Min;
        private System.Windows.Forms.Label Label_ParaSigma2;
        private System.Windows.Forms.TrackBar TrackBar_ParaSigma2;
        private System.Windows.Forms.CheckBox CheckBoxAlgo3GaussianBlur;
        private System.Windows.Forms.TabControl tabControl_MainForm;
        private System.Windows.Forms.TabPage tabPage1_MainForm;
        private System.Windows.Forms.TabPage tabPage2_MainForm;
        private System.Windows.Forms.TabPage tabPage3_MainForm;
        private System.Windows.Forms.Button Button_PreviewForm;
    }
}

