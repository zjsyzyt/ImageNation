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
            this.CheckBoxAlgo1Gauss.Location = new System.Drawing.Point(926, 25);
            this.CheckBoxAlgo1Gauss.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBoxAlgo1Gauss.Name = "CheckBoxAlgo1Gauss";
            this.CheckBoxAlgo1Gauss.Size = new System.Drawing.Size(128, 29);
            this.CheckBoxAlgo1Gauss.TabIndex = 4;
            this.CheckBoxAlgo1Gauss.Text = "高斯噪声";
            this.CheckBoxAlgo1Gauss.UseVisualStyleBackColor = true;
            this.CheckBoxAlgo1Gauss.CheckedChanged += new System.EventHandler(this.CheckBoxAlgo1Gauss_CheckedChanged);
            this.CheckBoxAlgo1Gauss.Click += new System.EventHandler(this.CheckBoxAlgo1Gauss_CheckedChanged);
            // 
            // CheckBoxAlgo2GrayScale
            // 
            this.CheckBoxAlgo2GrayScale.AutoSize = true;
            this.CheckBoxAlgo2GrayScale.Location = new System.Drawing.Point(926, 256);
            this.CheckBoxAlgo2GrayScale.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBoxAlgo2GrayScale.Name = "CheckBoxAlgo2GrayScale";
            this.CheckBoxAlgo2GrayScale.Size = new System.Drawing.Size(128, 29);
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
            this.pictureBox1.Location = new System.Drawing.Point(28, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 729);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Button_StartDegradation
            // 
            this.Button_StartDegradation.Location = new System.Drawing.Point(926, 792);
            this.Button_StartDegradation.Margin = new System.Windows.Forms.Padding(6);
            this.Button_StartDegradation.Name = "Button_StartDegradation";
            this.Button_StartDegradation.Size = new System.Drawing.Size(330, 48);
            this.Button_StartDegradation.TabIndex = 0;
            this.Button_StartDegradation.Text = "启动退化";
            this.Button_StartDegradation.UseVisualStyleBackColor = true;
            this.Button_StartDegradation.Click += new System.EventHandler(this.Button_StartDegradation_Click);
            // 
            // ImgNum
            // 
            this.ImgNum.Location = new System.Drawing.Point(1064, 665);
            this.ImgNum.Margin = new System.Windows.Forms.Padding(6);
            this.ImgNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ImgNum.Name = "ImgNum";
            this.ImgNum.Size = new System.Drawing.Size(192, 31);
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
            this.Label_ImgNum.Location = new System.Drawing.Point(922, 669);
            this.Label_ImgNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ImgNum.Name = "Label_ImgNum";
            this.Label_ImgNum.Size = new System.Drawing.Size(130, 24);
            this.Label_ImgNum.TabIndex = 9;
            this.Label_ImgNum.Text = "图像数量：";
            // 
            // Button_ImageScan
            // 
            this.Button_ImageScan.Location = new System.Drawing.Point(720, 792);
            this.Button_ImageScan.Margin = new System.Windows.Forms.Padding(6);
            this.Button_ImageScan.Name = "Button_ImageScan";
            this.Button_ImageScan.Size = new System.Drawing.Size(150, 48);
            this.Button_ImageScan.TabIndex = 10;
            this.Button_ImageScan.Text = "浏览";
            this.Button_ImageScan.UseVisualStyleBackColor = true;
            this.Button_ImageScan.Click += new System.EventHandler(this.Button_ImageScan_Click);
            // 
            // Button_FilePathScan
            // 
            this.Button_FilePathScan.Location = new System.Drawing.Point(720, 854);
            this.Button_FilePathScan.Margin = new System.Windows.Forms.Padding(6);
            this.Button_FilePathScan.Name = "Button_FilePathScan";
            this.Button_FilePathScan.Size = new System.Drawing.Size(150, 48);
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
            this.TextBox_ImgPath.Location = new System.Drawing.Point(154, 794);
            this.TextBox_ImgPath.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_ImgPath.Name = "TextBox_ImgPath";
            this.TextBox_ImgPath.Size = new System.Drawing.Size(560, 31);
            this.TextBox_ImgPath.TabIndex = 12;
            // 
            // TextBox_ImgStoragePath
            // 
            this.TextBox_ImgStoragePath.Location = new System.Drawing.Point(154, 856);
            this.TextBox_ImgStoragePath.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_ImgStoragePath.Name = "TextBox_ImgStoragePath";
            this.TextBox_ImgStoragePath.Size = new System.Drawing.Size(560, 31);
            this.TextBox_ImgStoragePath.TabIndex = 13;
            // 
            // Label_ImgPath
            // 
            this.Label_ImgPath.AutoSize = true;
            this.Label_ImgPath.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_ImgPath.Location = new System.Drawing.Point(24, 800);
            this.Label_ImgPath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ImgPath.Name = "Label_ImgPath";
            this.Label_ImgPath.Size = new System.Drawing.Size(118, 24);
            this.Label_ImgPath.TabIndex = 14;
            this.Label_ImgPath.Text = "图像路径:";
            // 
            // Label_ImgStoragePath
            // 
            this.Label_ImgStoragePath.AutoSize = true;
            this.Label_ImgStoragePath.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ImgStoragePath.Location = new System.Drawing.Point(24, 862);
            this.Label_ImgStoragePath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ImgStoragePath.Name = "Label_ImgStoragePath";
            this.Label_ImgStoragePath.Size = new System.Drawing.Size(118, 24);
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
            this.TextBox_FileNamePrefix.Location = new System.Drawing.Point(1138, 712);
            this.TextBox_FileNamePrefix.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_FileNamePrefix.Name = "TextBox_FileNamePrefix";
            this.TextBox_FileNamePrefix.Size = new System.Drawing.Size(118, 31);
            this.TextBox_FileNamePrefix.TabIndex = 16;
            this.TextBox_FileNamePrefix.TextChanged += new System.EventHandler(this.FileNamePrefix_TextChanged);
            // 
            // Label_FileNamePrefix
            // 
            this.Label_FileNamePrefix.AutoSize = true;
            this.Label_FileNamePrefix.Location = new System.Drawing.Point(922, 719);
            this.Label_FileNamePrefix.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_FileNamePrefix.Name = "Label_FileNamePrefix";
            this.Label_FileNamePrefix.Size = new System.Drawing.Size(180, 25);
            this.Label_FileNamePrefix.TabIndex = 17;
            this.Label_FileNamePrefix.Text = "文件名（前缀）：";
            // 
            // TrackBar_ParaMiu
            // 
            this.TrackBar_ParaMiu.AutoSize = false;
            this.TrackBar_ParaMiu.Location = new System.Drawing.Point(1036, 81);
            this.TrackBar_ParaMiu.Margin = new System.Windows.Forms.Padding(6);
            this.TrackBar_ParaMiu.Name = "TrackBar_ParaMiu";
            this.TrackBar_ParaMiu.Size = new System.Drawing.Size(232, 44);
            this.TrackBar_ParaMiu.TabIndex = 18;
            // 
            // TrackBar_ParaSigma
            // 
            this.TrackBar_ParaSigma.AutoSize = false;
            this.TrackBar_ParaSigma.Location = new System.Drawing.Point(1036, 165);
            this.TrackBar_ParaSigma.Margin = new System.Windows.Forms.Padding(6);
            this.TrackBar_ParaSigma.Name = "TrackBar_ParaSigma";
            this.TrackBar_ParaSigma.Size = new System.Drawing.Size(232, 44);
            this.TrackBar_ParaSigma.TabIndex = 19;
            // 
            // Label_ParaMiu
            // 
            this.Label_ParaMiu.AutoSize = true;
            this.Label_ParaMiu.Location = new System.Drawing.Point(922, 90);
            this.Label_ParaMiu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ParaMiu.Name = "Label_ParaMiu";
            this.Label_ParaMiu.Size = new System.Drawing.Size(96, 25);
            this.Label_ParaMiu.TabIndex = 20;
            this.Label_ParaMiu.Text = "噪声幅度";
            // 
            // Label_ParaSigma
            // 
            this.Label_ParaSigma.AutoSize = true;
            this.Label_ParaSigma.Location = new System.Drawing.Point(922, 173);
            this.Label_ParaSigma.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ParaSigma.Name = "Label_ParaSigma";
            this.Label_ParaSigma.Size = new System.Drawing.Size(96, 25);
            this.Label_ParaSigma.TabIndex = 21;
            this.Label_ParaSigma.Text = "噪声密度";
            // 
            // Label_Para1Min
            // 
            this.Label_Para1Min.AutoSize = true;
            this.Label_Para1Min.Location = new System.Drawing.Point(1300, 42);
            this.Label_Para1Min.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_Para1Min.Name = "Label_Para1Min";
            this.Label_Para1Min.Size = new System.Drawing.Size(75, 25);
            this.Label_Para1Min.TabIndex = 22;
            this.Label_Para1Min.Text = "最小值";
            // 
            // Label_Para1Max
            // 
            this.Label_Para1Max.AutoSize = true;
            this.Label_Para1Max.Location = new System.Drawing.Point(1466, 42);
            this.Label_Para1Max.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_Para1Max.Name = "Label_Para1Max";
            this.Label_Para1Max.Size = new System.Drawing.Size(75, 25);
            this.Label_Para1Max.TabIndex = 23;
            this.Label_Para1Max.Text = "最大值";
            // 
            // Value_ParaMiuMin
            // 
            this.Value_ParaMiuMin.Location = new System.Drawing.Point(1284, 81);
            this.Value_ParaMiuMin.Margin = new System.Windows.Forms.Padding(6);
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
            this.Value_ParaMiuMin.Size = new System.Drawing.Size(112, 31);
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
            this.Value_ParaMiuMax.Location = new System.Drawing.Point(1450, 81);
            this.Value_ParaMiuMax.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaMiuMax.Name = "Value_ParaMiuMax";
            this.Value_ParaMiuMax.Size = new System.Drawing.Size(112, 31);
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
            this.Value_ParaSigmaMax.Location = new System.Drawing.Point(1450, 165);
            this.Value_ParaSigmaMax.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaSigmaMax.Name = "Value_ParaSigmaMax";
            this.Value_ParaSigmaMax.Size = new System.Drawing.Size(112, 31);
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
            this.Value_ParaSigmaMin.Location = new System.Drawing.Point(1284, 165);
            this.Value_ParaSigmaMin.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaSigmaMin.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Value_ParaSigmaMin.Name = "Value_ParaSigmaMin";
            this.Value_ParaSigmaMin.Size = new System.Drawing.Size(112, 31);
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
            this.Value_ParaInterceptMax.Location = new System.Drawing.Point(1450, 387);
            this.Value_ParaInterceptMax.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaInterceptMax.Name = "Value_ParaInterceptMax";
            this.Value_ParaInterceptMax.Size = new System.Drawing.Size(112, 31);
            this.Value_ParaInterceptMax.TabIndex = 41;
            this.Value_ParaInterceptMax.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Value_ParaInterceptMin
            // 
            this.Value_ParaInterceptMin.Location = new System.Drawing.Point(1284, 387);
            this.Value_ParaInterceptMin.Margin = new System.Windows.Forms.Padding(6);
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
            this.Value_ParaInterceptMin.Size = new System.Drawing.Size(112, 31);
            this.Value_ParaInterceptMin.TabIndex = 40;
            this.Value_ParaInterceptMin.Value = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            // 
            // Value_ParaSlopeMax
            // 
            this.Value_ParaSlopeMax.Location = new System.Drawing.Point(1450, 304);
            this.Value_ParaSlopeMax.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaSlopeMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.Value_ParaSlopeMax.Name = "Value_ParaSlopeMax";
            this.Value_ParaSlopeMax.Size = new System.Drawing.Size(112, 31);
            this.Value_ParaSlopeMax.TabIndex = 39;
            this.Value_ParaSlopeMax.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // Value_ParaSlopeMin
            // 
            this.Value_ParaSlopeMin.Location = new System.Drawing.Point(1284, 304);
            this.Value_ParaSlopeMin.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaSlopeMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.Value_ParaSlopeMin.Name = "Value_ParaSlopeMin";
            this.Value_ParaSlopeMin.Size = new System.Drawing.Size(112, 31);
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
            this.Label_Para2Max.Location = new System.Drawing.Point(1466, 265);
            this.Label_Para2Max.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_Para2Max.Name = "Label_Para2Max";
            this.Label_Para2Max.Size = new System.Drawing.Size(75, 25);
            this.Label_Para2Max.TabIndex = 37;
            this.Label_Para2Max.Text = "最大值";
            // 
            // Label_Para2Min
            // 
            this.Label_Para2Min.AutoSize = true;
            this.Label_Para2Min.Location = new System.Drawing.Point(1300, 265);
            this.Label_Para2Min.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_Para2Min.Name = "Label_Para2Min";
            this.Label_Para2Min.Size = new System.Drawing.Size(75, 25);
            this.Label_Para2Min.TabIndex = 36;
            this.Label_Para2Min.Text = "最小值";
            // 
            // Label_ParaIntercept
            // 
            this.Label_ParaIntercept.AutoSize = true;
            this.Label_ParaIntercept.Location = new System.Drawing.Point(922, 396);
            this.Label_ParaIntercept.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ParaIntercept.Name = "Label_ParaIntercept";
            this.Label_ParaIntercept.Size = new System.Drawing.Size(96, 25);
            this.Label_ParaIntercept.TabIndex = 35;
            this.Label_ParaIntercept.Text = "变换幅度";
            // 
            // Label_ParaSlope
            // 
            this.Label_ParaSlope.AutoSize = true;
            this.Label_ParaSlope.Location = new System.Drawing.Point(922, 312);
            this.Label_ParaSlope.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ParaSlope.Name = "Label_ParaSlope";
            this.Label_ParaSlope.Size = new System.Drawing.Size(75, 25);
            this.Label_ParaSlope.TabIndex = 34;
            this.Label_ParaSlope.Text = "灵敏度";
            // 
            // TrackBar_ParaIntercept
            // 
            this.TrackBar_ParaIntercept.AutoSize = false;
            this.TrackBar_ParaIntercept.Location = new System.Drawing.Point(1036, 387);
            this.TrackBar_ParaIntercept.Margin = new System.Windows.Forms.Padding(6);
            this.TrackBar_ParaIntercept.Name = "TrackBar_ParaIntercept";
            this.TrackBar_ParaIntercept.Size = new System.Drawing.Size(232, 44);
            this.TrackBar_ParaIntercept.TabIndex = 33;
            // 
            // TrackBar_ParaSlope
            // 
            this.TrackBar_ParaSlope.AutoSize = false;
            this.TrackBar_ParaSlope.Location = new System.Drawing.Point(1036, 304);
            this.TrackBar_ParaSlope.Margin = new System.Windows.Forms.Padding(6);
            this.TrackBar_ParaSlope.Name = "TrackBar_ParaSlope";
            this.TrackBar_ParaSlope.Size = new System.Drawing.Size(232, 44);
            this.TrackBar_ParaSlope.TabIndex = 32;
            // 
            // pBarImg
            // 
            this.pBarImg.Location = new System.Drawing.Point(927, 862);
            this.pBarImg.Name = "pBarImg";
            this.pBarImg.Size = new System.Drawing.Size(329, 25);
            this.pBarImg.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 940);
            this.Controls.Add(this.pBarImg);
            this.Controls.Add(this.Value_ParaInterceptMax);
            this.Controls.Add(this.Value_ParaInterceptMin);
            this.Controls.Add(this.Value_ParaSlopeMax);
            this.Controls.Add(this.Value_ParaSlopeMin);
            this.Controls.Add(this.Label_Para2Max);
            this.Controls.Add(this.Label_Para2Min);
            this.Controls.Add(this.Label_ParaIntercept);
            this.Controls.Add(this.Label_ParaSlope);
            this.Controls.Add(this.TrackBar_ParaIntercept);
            this.Controls.Add(this.TrackBar_ParaSlope);
            this.Controls.Add(this.Value_ParaSigmaMax);
            this.Controls.Add(this.Value_ParaSigmaMin);
            this.Controls.Add(this.Value_ParaMiuMax);
            this.Controls.Add(this.Value_ParaMiuMin);
            this.Controls.Add(this.Label_Para1Max);
            this.Controls.Add(this.Label_Para1Min);
            this.Controls.Add(this.Label_ParaSigma);
            this.Controls.Add(this.Label_ParaMiu);
            this.Controls.Add(this.TrackBar_ParaSigma);
            this.Controls.Add(this.TrackBar_ParaMiu);
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
            this.Controls.Add(this.CheckBoxAlgo2GrayScale);
            this.Controls.Add(this.CheckBoxAlgo1Gauss);
            this.Controls.Add(this.Button_StartDegradation);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "图像退化软件";
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
    }
}

