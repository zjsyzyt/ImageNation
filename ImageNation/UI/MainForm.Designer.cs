namespace ImageNation
{
    partial class MainForm
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
            this.Label_Para21Max = new System.Windows.Forms.Label();
            this.Label_Para21Min = new System.Windows.Forms.Label();
            this.Label_ParaIntercept = new System.Windows.Forms.Label();
            this.Label_ParaSlope = new System.Windows.Forms.Label();
            this.pBarImg = new System.Windows.Forms.ProgressBar();
            this.Value_ParaSigma2Max = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaSigma2Min = new System.Windows.Forms.NumericUpDown();
            this.Label_Para3Max = new System.Windows.Forms.Label();
            this.Label_Para3Min = new System.Windows.Forms.Label();
            this.Label_ParaSigma2 = new System.Windows.Forms.Label();
            this.CheckBoxAlgo3GaussianBlur = new System.Windows.Forms.CheckBox();
            this.tabControl_MainForm = new System.Windows.Forms.TabControl();
            this.tabPage1_MainForm = new System.Windows.Forms.TabPage();
            this.ComboBox_PepperNoise = new System.Windows.Forms.ComboBox();
            this.Value_ParaNoiseCoeffMax = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxAlgo4PepperNoise = new System.Windows.Forms.CheckBox();
            this.Label_PepperNoise = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Value_ParaNoiseCoeffMin = new System.Windows.Forms.NumericUpDown();
            this.tabPage2_MainForm = new System.Windows.Forms.TabPage();
            this.Label_Para22Min = new System.Windows.Forms.Label();
            this.Label_Para22Max = new System.Windows.Forms.Label();
            this.ComboBox_GrayScale = new System.Windows.Forms.ComboBox();
            this.tabPage3_MainForm = new System.Windows.Forms.TabPage();
            this.Button_PreviewForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaMiuMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaMiuMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigmaMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigmaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaInterceptMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaInterceptMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSlopeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSlopeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigma2Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigma2Min)).BeginInit();
            this.tabControl_MainForm.SuspendLayout();
            this.tabPage1_MainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaNoiseCoeffMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaNoiseCoeffMin)).BeginInit();
            this.tabPage2_MainForm.SuspendLayout();
            this.SuspendLayout();


            //添加委托实例定义
            this.previewForm.SendToMainForm += new PreviewForm.SendPara(RecvPara);

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
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Button_StartDegradation
            // 
            this.Button_StartDegradation.BackColor = System.Drawing.SystemColors.Control;
            this.Button_StartDegradation.Location = new System.Drawing.Point(703, 381);
            this.Button_StartDegradation.Name = "Button_StartDegradation";
            this.Button_StartDegradation.Size = new System.Drawing.Size(127, 45);
            this.Button_StartDegradation.TabIndex = 0;
            this.Button_StartDegradation.Text = "启动退化";
            this.Button_StartDegradation.UseVisualStyleBackColor = true;
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
            10,
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
            this.Value_ParaMiuMin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Value_ParaMiuMin.Location = new System.Drawing.Point(196, 43);
            this.Value_ParaMiuMin.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Value_ParaMiuMin.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.Value_ParaMiuMin.Name = "Value_ParaMiuMin";
            this.Value_ParaMiuMin.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaMiuMin.TabIndex = 28;
            this.Value_ParaMiuMin.Value = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.Value_ParaMiuMin.ValueChanged += new System.EventHandler(this.Value_ParaMiuMin_ValueChanged);
            // 
            // Value_ParaMiuMax
            // 
            this.Value_ParaMiuMax.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Value_ParaMiuMax.Location = new System.Drawing.Point(279, 43);
            this.Value_ParaMiuMax.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Value_ParaMiuMax.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.Value_ParaMiuMax.Name = "Value_ParaMiuMax";
            this.Value_ParaMiuMax.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaMiuMax.TabIndex = 29;
            this.Value_ParaMiuMax.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Value_ParaMiuMax.ValueChanged += new System.EventHandler(this.Value_ParaMiuMax_ValueChanged);
            // 
            // Value_ParaSigmaMax
            // 
            this.Value_ParaSigmaMax.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
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
            this.Value_ParaSigmaMin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Value_ParaSigmaMin.Location = new System.Drawing.Point(196, 83);
            this.Value_ParaSigmaMin.Name = "Value_ParaSigmaMin";
            this.Value_ParaSigmaMin.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaSigmaMin.TabIndex = 30;
            this.Value_ParaSigmaMin.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.Value_ParaSigmaMin.ValueChanged += new System.EventHandler(this.Value_ParaSigmaMin_ValueChanged);
            // 
            // Value_ParaInterceptMax
            // 
            this.Value_ParaInterceptMax.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Value_ParaInterceptMax.Location = new System.Drawing.Point(268, 86);
            this.Value_ParaInterceptMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Value_ParaInterceptMax.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
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
            this.Value_ParaInterceptMin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Value_ParaInterceptMin.Location = new System.Drawing.Point(159, 86);
            this.Value_ParaInterceptMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Value_ParaInterceptMin.Minimum = new decimal(new int[] {
            255,
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
            this.Value_ParaSlopeMax.DecimalPlaces = 1;
            this.Value_ParaSlopeMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Value_ParaSlopeMax.Location = new System.Drawing.Point(268, 46);
            this.Value_ParaSlopeMax.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Value_ParaSlopeMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Value_ParaSlopeMax.Name = "Value_ParaSlopeMax";
            this.Value_ParaSlopeMax.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaSlopeMax.TabIndex = 39;
            this.Value_ParaSlopeMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Value_ParaSlopeMin
            // 
            this.Value_ParaSlopeMin.DecimalPlaces = 1;
            this.Value_ParaSlopeMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Value_ParaSlopeMin.Location = new System.Drawing.Point(159, 46);
            this.Value_ParaSlopeMin.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Value_ParaSlopeMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Value_ParaSlopeMin.Name = "Value_ParaSlopeMin";
            this.Value_ParaSlopeMin.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaSlopeMin.TabIndex = 38;
            this.Value_ParaSlopeMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label_Para21Max
            // 
            this.Label_Para21Max.AutoSize = true;
            this.Label_Para21Max.Location = new System.Drawing.Point(221, 50);
            this.Label_Para21Max.Name = "Label_Para21Max";
            this.Label_Para21Max.Size = new System.Drawing.Size(41, 12);
            this.Label_Para21Max.TabIndex = 37;
            this.Label_Para21Max.Text = "最大值";
            // 
            // Label_Para21Min
            // 
            this.Label_Para21Min.AutoSize = true;
            this.Label_Para21Min.Location = new System.Drawing.Point(112, 50);
            this.Label_Para21Min.Name = "Label_Para21Min";
            this.Label_Para21Min.Size = new System.Drawing.Size(41, 12);
            this.Label_Para21Min.TabIndex = 36;
            this.Label_Para21Min.Text = "最小值";
            // 
            // Label_ParaIntercept
            // 
            this.Label_ParaIntercept.AutoSize = true;
            this.Label_ParaIntercept.Location = new System.Drawing.Point(15, 90);
            this.Label_ParaIntercept.Name = "Label_ParaIntercept";
            this.Label_ParaIntercept.Size = new System.Drawing.Size(53, 12);
            this.Label_ParaIntercept.TabIndex = 35;
            this.Label_ParaIntercept.Text = "灰度平移";
            // 
            // Label_ParaSlope
            // 
            this.Label_ParaSlope.AutoSize = true;
            this.Label_ParaSlope.Location = new System.Drawing.Point(15, 50);
            this.Label_ParaSlope.Name = "Label_ParaSlope";
            this.Label_ParaSlope.Size = new System.Drawing.Size(53, 12);
            this.Label_ParaSlope.TabIndex = 34;
            this.Label_ParaSlope.Text = "变化倍数";
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
            this.Value_ParaSigma2Max.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Value_ParaSigma2Max.Location = new System.Drawing.Point(279, 225);
            this.Value_ParaSigma2Max.Name = "Value_ParaSigma2Max";
            this.Value_ParaSigma2Max.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaSigma2Max.TabIndex = 49;
            this.Value_ParaSigma2Max.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Value_ParaSigma2Max.ValueChanged += new System.EventHandler(this.Value_ParaSigma2Max_ValueChanged);
            // 
            // Value_ParaSigma2Min
            // 
            this.Value_ParaSigma2Min.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Value_ParaSigma2Min.Location = new System.Drawing.Point(196, 225);
            this.Value_ParaSigma2Min.Name = "Value_ParaSigma2Min";
            this.Value_ParaSigma2Min.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaSigma2Min.TabIndex = 48;
            this.Value_ParaSigma2Min.ValueChanged += new System.EventHandler(this.Value_ParaSigma2Min_ValueChanged);
            // 
            // Label_Para3Max
            // 
            this.Label_Para3Max.AutoSize = true;
            this.Label_Para3Max.Location = new System.Drawing.Point(287, 206);
            this.Label_Para3Max.Name = "Label_Para3Max";
            this.Label_Para3Max.Size = new System.Drawing.Size(41, 12);
            this.Label_Para3Max.TabIndex = 47;
            this.Label_Para3Max.Text = "最大值";
            this.Label_Para3Max.Click += new System.EventHandler(this.Label_Para3Max_Click);
            // 
            // Label_Para3Min
            // 
            this.Label_Para3Min.AutoSize = true;
            this.Label_Para3Min.Location = new System.Drawing.Point(204, 206);
            this.Label_Para3Min.Name = "Label_Para3Min";
            this.Label_Para3Min.Size = new System.Drawing.Size(41, 12);
            this.Label_Para3Min.TabIndex = 46;
            this.Label_Para3Min.Text = "最小值";
            this.Label_Para3Min.Click += new System.EventHandler(this.Label_Para3Min_Click);
            // 
            // Label_ParaSigma2
            // 
            this.Label_ParaSigma2.AutoSize = true;
            this.Label_ParaSigma2.Location = new System.Drawing.Point(15, 229);
            this.Label_ParaSigma2.Name = "Label_ParaSigma2";
            this.Label_ParaSigma2.Size = new System.Drawing.Size(53, 12);
            this.Label_ParaSigma2.TabIndex = 45;
            this.Label_ParaSigma2.Text = "模糊程度";
            this.Label_ParaSigma2.Click += new System.EventHandler(this.Label_ParaSigma2_Click);
            // 
            // CheckBoxAlgo3GaussianBlur
            // 
            this.CheckBoxAlgo3GaussianBlur.AutoSize = true;
            this.CheckBoxAlgo3GaussianBlur.Location = new System.Drawing.Point(17, 202);
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
            this.tabPage1_MainForm.Controls.Add(this.ComboBox_PepperNoise);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaNoiseCoeffMax);
            this.tabPage1_MainForm.Controls.Add(this.CheckBoxAlgo4PepperNoise);
            this.tabPage1_MainForm.Controls.Add(this.Label_PepperNoise);
            this.tabPage1_MainForm.Controls.Add(this.label2);
            this.tabPage1_MainForm.Controls.Add(this.label3);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaNoiseCoeffMin);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaMiuMax);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaSigma2Max);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaSigma2Min);
            this.tabPage1_MainForm.Controls.Add(this.CheckBoxAlgo1Gauss);
            this.tabPage1_MainForm.Controls.Add(this.Label_Para3Max);
            this.tabPage1_MainForm.Controls.Add(this.Label_Para3Min);
            this.tabPage1_MainForm.Controls.Add(this.Label_ParaSigma2);
            this.tabPage1_MainForm.Controls.Add(this.Label_ParaMiu);
            this.tabPage1_MainForm.Controls.Add(this.Label_ParaSigma);
            this.tabPage1_MainForm.Controls.Add(this.CheckBoxAlgo3GaussianBlur);
            this.tabPage1_MainForm.Controls.Add(this.Label_Para1Min);
            this.tabPage1_MainForm.Controls.Add(this.Label_Para1Max);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaMiuMin);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaSigmaMin);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaSigmaMax);
            this.tabPage1_MainForm.Location = new System.Drawing.Point(4, 22);
            this.tabPage1_MainForm.Name = "tabPage1_MainForm";
            this.tabPage1_MainForm.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1_MainForm.Size = new System.Drawing.Size(363, 262);
            this.tabPage1_MainForm.TabIndex = 0;
            this.tabPage1_MainForm.Text = "加噪、模糊";
            this.tabPage1_MainForm.UseVisualStyleBackColor = true;
            // 
            // ComboBox_PepperNoise
            // 
            this.ComboBox_PepperNoise.FormattingEnabled = true;
            this.ComboBox_PepperNoise.Items.AddRange(new object[] {
            "仅椒噪声",
            "仅盐噪声",
            "椒盐噪声"});
            this.ComboBox_PepperNoise.Location = new System.Drawing.Point(87, 125);
            this.ComboBox_PepperNoise.Name = "ComboBox_PepperNoise";
            this.ComboBox_PepperNoise.Size = new System.Drawing.Size(97, 20);
            this.ComboBox_PepperNoise.TabIndex = 56;
            this.ComboBox_PepperNoise.Text = "请选择噪声种类";
            this.ComboBox_PepperNoise.SelectedIndexChanged += new System.EventHandler(this.comboBox_PepperNoise_SelectedIndexChanged);
            // 
            // Value_ParaNoiseCoeffMax
            // 
            this.Value_ParaNoiseCoeffMax.Location = new System.Drawing.Point(280, 148);
            this.Value_ParaNoiseCoeffMax.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Value_ParaNoiseCoeffMax.Name = "Value_ParaNoiseCoeffMax";
            this.Value_ParaNoiseCoeffMax.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaNoiseCoeffMax.TabIndex = 55;
            this.Value_ParaNoiseCoeffMax.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // CheckBoxAlgo4PepperNoise
            // 
            this.CheckBoxAlgo4PepperNoise.AutoSize = true;
            this.CheckBoxAlgo4PepperNoise.Location = new System.Drawing.Point(17, 128);
            this.CheckBoxAlgo4PepperNoise.Name = "CheckBoxAlgo4PepperNoise";
            this.CheckBoxAlgo4PepperNoise.Size = new System.Drawing.Size(72, 16);
            this.CheckBoxAlgo4PepperNoise.TabIndex = 50;
            this.CheckBoxAlgo4PepperNoise.Text = "椒盐噪声";
            this.CheckBoxAlgo4PepperNoise.UseVisualStyleBackColor = true;
            this.CheckBoxAlgo4PepperNoise.CheckedChanged += new System.EventHandler(this.CheckBoxAlgo4PepperNoise_CheckedChanged);
            // 
            // Label_PepperNoise
            // 
            this.Label_PepperNoise.AutoSize = true;
            this.Label_PepperNoise.Location = new System.Drawing.Point(15, 151);
            this.Label_PepperNoise.Name = "Label_PepperNoise";
            this.Label_PepperNoise.Size = new System.Drawing.Size(53, 12);
            this.Label_PepperNoise.TabIndex = 51;
            this.Label_PepperNoise.Text = "噪声比例";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 52;
            this.label2.Text = "最小值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 53;
            this.label3.Text = "最大值";
            // 
            // Value_ParaNoiseCoeffMin
            // 
            this.Value_ParaNoiseCoeffMin.Location = new System.Drawing.Point(196, 148);
            this.Value_ParaNoiseCoeffMin.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Value_ParaNoiseCoeffMin.Name = "Value_ParaNoiseCoeffMin";
            this.Value_ParaNoiseCoeffMin.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaNoiseCoeffMin.TabIndex = 54;
            // 
            // tabPage2_MainForm
            // 
            this.tabPage2_MainForm.Controls.Add(this.Label_Para22Min);
            this.tabPage2_MainForm.Controls.Add(this.Label_Para22Max);
            this.tabPage2_MainForm.Controls.Add(this.ComboBox_GrayScale);
            this.tabPage2_MainForm.Controls.Add(this.Value_ParaSlopeMax);
            this.tabPage2_MainForm.Controls.Add(this.CheckBoxAlgo2GrayScale);
            this.tabPage2_MainForm.Controls.Add(this.Label_Para21Min);
            this.tabPage2_MainForm.Controls.Add(this.Label_Para21Max);
            this.tabPage2_MainForm.Controls.Add(this.Value_ParaInterceptMax);
            this.tabPage2_MainForm.Controls.Add(this.Label_ParaIntercept);
            this.tabPage2_MainForm.Controls.Add(this.Value_ParaSlopeMin);
            this.tabPage2_MainForm.Controls.Add(this.Label_ParaSlope);
            this.tabPage2_MainForm.Controls.Add(this.Value_ParaInterceptMin);
            this.tabPage2_MainForm.Location = new System.Drawing.Point(4, 22);
            this.tabPage2_MainForm.Name = "tabPage2_MainForm";
            this.tabPage2_MainForm.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2_MainForm.Size = new System.Drawing.Size(363, 262);
            this.tabPage2_MainForm.TabIndex = 1;
            this.tabPage2_MainForm.Text = "分辨率、对比度";
            this.tabPage2_MainForm.UseVisualStyleBackColor = true;
            // 
            // Label_Para22Min
            // 
            this.Label_Para22Min.AutoSize = true;
            this.Label_Para22Min.Location = new System.Drawing.Point(112, 90);
            this.Label_Para22Min.Name = "Label_Para22Min";
            this.Label_Para22Min.Size = new System.Drawing.Size(41, 12);
            this.Label_Para22Min.TabIndex = 43;
            this.Label_Para22Min.Text = "最小值";
            // 
            // Label_Para22Max
            // 
            this.Label_Para22Max.AutoSize = true;
            this.Label_Para22Max.Location = new System.Drawing.Point(221, 90);
            this.Label_Para22Max.Name = "Label_Para22Max";
            this.Label_Para22Max.Size = new System.Drawing.Size(41, 12);
            this.Label_Para22Max.TabIndex = 44;
            this.Label_Para22Max.Text = "最大值";
            // 
            // ComboBox_GrayScale
            // 
            this.ComboBox_GrayScale.FormattingEnabled = true;
            this.ComboBox_GrayScale.Items.AddRange(new object[] {
            "增大对比度",
            "减小对比度",
            "倒置"});
            this.ComboBox_GrayScale.Location = new System.Drawing.Point(96, 11);
            this.ComboBox_GrayScale.Name = "ComboBox_GrayScale";
            this.ComboBox_GrayScale.Size = new System.Drawing.Size(121, 20);
            this.ComboBox_GrayScale.TabIndex = 42;
            this.ComboBox_GrayScale.Text = "请选择变化形式";
            this.ComboBox_GrayScale.SelectedIndexChanged += new System.EventHandler(this.ComboBox_GrayScale_SelectedIndexChanged);
            // 
            // tabPage3_MainForm
            // 
            this.tabPage3_MainForm.Location = new System.Drawing.Point(4, 22);
            this.tabPage3_MainForm.Name = "tabPage3_MainForm";
            this.tabPage3_MainForm.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            this.Button_PreviewForm.Click += new System.EventHandler(this.Button_PreviewForm_Click);
            // 
            // MainForm
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
            this.Name = "MainForm";
            this.Text = "图像退化软件";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaMiuMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaMiuMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigmaMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigmaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaInterceptMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaInterceptMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSlopeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSlopeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigma2Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigma2Min)).EndInit();
            this.tabControl_MainForm.ResumeLayout(false);
            this.tabPage1_MainForm.ResumeLayout(false);
            this.tabPage1_MainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaNoiseCoeffMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaNoiseCoeffMin)).EndInit();
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
        private System.Windows.Forms.Label Label_Para21Max;
        private System.Windows.Forms.Label Label_Para21Min;
        private System.Windows.Forms.Label Label_ParaIntercept;
        private System.Windows.Forms.Label Label_ParaSlope;
        private System.Windows.Forms.ProgressBar pBarImg;
        private System.Windows.Forms.NumericUpDown Value_ParaSigma2Max;
        private System.Windows.Forms.NumericUpDown Value_ParaSigma2Min;
        private System.Windows.Forms.Label Label_Para3Max;
        private System.Windows.Forms.Label Label_Para3Min;
        private System.Windows.Forms.Label Label_ParaSigma2;
        private System.Windows.Forms.CheckBox CheckBoxAlgo3GaussianBlur;
        private System.Windows.Forms.TabControl tabControl_MainForm;
        private System.Windows.Forms.TabPage tabPage1_MainForm;
        private System.Windows.Forms.TabPage tabPage2_MainForm;
        private System.Windows.Forms.TabPage tabPage3_MainForm;
        private System.Windows.Forms.Button Button_PreviewForm;
        private System.Windows.Forms.ComboBox ComboBox_GrayScale;
        private System.Windows.Forms.Label Label_Para22Min;
        private System.Windows.Forms.Label Label_Para22Max;
        private System.Windows.Forms.ComboBox ComboBox_PepperNoise;
        private System.Windows.Forms.NumericUpDown Value_ParaNoiseCoeffMax;
        private System.Windows.Forms.CheckBox CheckBoxAlgo4PepperNoise;
        private System.Windows.Forms.Label Label_PepperNoise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Value_ParaNoiseCoeffMin;
    }
}

