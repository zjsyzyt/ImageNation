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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.ComboBox_PyrDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Value_ParaPyrDownCoeff = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxPyrDown = new System.Windows.Forms.CheckBox();
            this.ComboBox_GrayScale = new System.Windows.Forms.ComboBox();
            this.tabPage3_MainForm = new System.Windows.Forms.TabPage();
            this.Value_ParaAngleMax = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.Value_ParaAngleMin = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxRotate = new System.Windows.Forms.CheckBox();
            this.Value_ParaOffsetYMax = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Value_ParaOffsetYMin = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxOffsetY = new System.Windows.Forms.CheckBox();
            this.Value_ParaOffsetXMax = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaOffsetXMin = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxOffsetX = new System.Windows.Forms.CheckBox();
            this.Button_PreviewForm = new System.Windows.Forms.Button();
            this.Value_PSNRThreshold = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxIQAThreshold = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Value_SSIMThreshold = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Value_HashThreshold = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.Value_SSIMOffsetThreshold = new System.Windows.Forms.NumericUpDown();
            this.bgWorker_pBarImg = new System.ComponentModel.BackgroundWorker();
            this.timer_ComfirmForm = new System.Windows.Forms.Timer(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaPyrDownCoeff)).BeginInit();
            this.tabPage3_MainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaAngleMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaAngleMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaOffsetYMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaOffsetYMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaOffsetXMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaOffsetXMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_PSNRThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_SSIMThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_HashThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_SSIMOffsetThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBoxAlgo1Gauss
            // 
            this.CheckBoxAlgo1Gauss.AutoSize = true;
            this.CheckBoxAlgo1Gauss.Location = new System.Drawing.Point(34, 33);
            this.CheckBoxAlgo1Gauss.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBoxAlgo1Gauss.Name = "CheckBoxAlgo1Gauss";
            this.CheckBoxAlgo1Gauss.Size = new System.Drawing.Size(90, 22);
            this.CheckBoxAlgo1Gauss.TabIndex = 4;
            this.CheckBoxAlgo1Gauss.Text = "高斯噪声";
            this.CheckBoxAlgo1Gauss.UseVisualStyleBackColor = true;
            this.CheckBoxAlgo1Gauss.CheckedChanged += new System.EventHandler(this.CheckBoxAlgo1Gauss_CheckedChanged);
            this.CheckBoxAlgo1Gauss.Click += new System.EventHandler(this.CheckBoxAlgo1Gauss_CheckedChanged);
            // 
            // CheckBoxAlgo2GrayScale
            // 
            this.CheckBoxAlgo2GrayScale.AutoSize = true;
            this.CheckBoxAlgo2GrayScale.Location = new System.Drawing.Point(32, 25);
            this.CheckBoxAlgo2GrayScale.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBoxAlgo2GrayScale.Name = "CheckBoxAlgo2GrayScale";
            this.CheckBoxAlgo2GrayScale.Size = new System.Drawing.Size(90, 22);
            this.CheckBoxAlgo2GrayScale.TabIndex = 5;
            this.CheckBoxAlgo2GrayScale.Text = "灰度变化";
            this.CheckBoxAlgo2GrayScale.UseVisualStyleBackColor = true;
            this.CheckBoxAlgo2GrayScale.CheckedChanged += new System.EventHandler(this.CheckBoxAlgo2GrayScale_CheckedChanged);
            this.CheckBoxAlgo2GrayScale.Click += new System.EventHandler(this.CheckBoxAlgo2GrayScale_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 729);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Button_StartDegradation
            // 
            this.Button_StartDegradation.BackColor = System.Drawing.SystemColors.Control;
            this.Button_StartDegradation.Location = new System.Drawing.Point(1320, 765);
            this.Button_StartDegradation.Margin = new System.Windows.Forms.Padding(6);
            this.Button_StartDegradation.Name = "Button_StartDegradation";
            this.Button_StartDegradation.Size = new System.Drawing.Size(222, 110);
            this.Button_StartDegradation.TabIndex = 0;
            this.Button_StartDegradation.Text = "启动退化";
            this.Button_StartDegradation.UseVisualStyleBackColor = true;
            this.Button_StartDegradation.Click += new System.EventHandler(this.Button_StartDegradation_Click);
            // 
            // ImgNum
            // 
            this.ImgNum.Location = new System.Drawing.Point(1146, 808);
            this.ImgNum.Margin = new System.Windows.Forms.Padding(6);
            this.ImgNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ImgNum.Name = "ImgNum";
            this.ImgNum.Size = new System.Drawing.Size(126, 24);
            this.ImgNum.TabIndex = 8;
            this.ImgNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Label_ImgNum.Location = new System.Drawing.Point(940, 813);
            this.Label_ImgNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ImgNum.Name = "Label_ImgNum";
            this.Label_ImgNum.Size = new System.Drawing.Size(82, 15);
            this.Label_ImgNum.TabIndex = 9;
            this.Label_ImgNum.Text = "图像数量：";
            // 
            // Button_ImageScan
            // 
            this.Button_ImageScan.Location = new System.Drawing.Point(720, 788);
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
            this.Button_FilePathScan.Location = new System.Drawing.Point(720, 850);
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
            this.TextBox_ImgPath.Location = new System.Drawing.Point(154, 795);
            this.TextBox_ImgPath.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_ImgPath.Name = "TextBox_ImgPath";
            this.TextBox_ImgPath.Size = new System.Drawing.Size(560, 24);
            this.TextBox_ImgPath.TabIndex = 12;
            // 
            // TextBox_ImgStoragePath
            // 
            this.TextBox_ImgStoragePath.Location = new System.Drawing.Point(154, 857);
            this.TextBox_ImgStoragePath.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_ImgStoragePath.Name = "TextBox_ImgStoragePath";
            this.TextBox_ImgStoragePath.Size = new System.Drawing.Size(560, 24);
            this.TextBox_ImgStoragePath.TabIndex = 13;
            // 
            // Label_ImgPath
            // 
            this.Label_ImgPath.AutoSize = true;
            this.Label_ImgPath.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_ImgPath.Location = new System.Drawing.Point(24, 800);
            this.Label_ImgPath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ImgPath.Name = "Label_ImgPath";
            this.Label_ImgPath.Size = new System.Drawing.Size(75, 15);
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
            this.Label_ImgStoragePath.Size = new System.Drawing.Size(75, 15);
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
            this.TextBox_FileNamePrefix.Location = new System.Drawing.Point(1146, 856);
            this.TextBox_FileNamePrefix.Margin = new System.Windows.Forms.Padding(6);
            this.TextBox_FileNamePrefix.Name = "TextBox_FileNamePrefix";
            this.TextBox_FileNamePrefix.Size = new System.Drawing.Size(126, 24);
            this.TextBox_FileNamePrefix.TabIndex = 16;
            this.TextBox_FileNamePrefix.Text = "Images";
            this.TextBox_FileNamePrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_FileNamePrefix.TextChanged += new System.EventHandler(this.FileNamePrefix_TextChanged);
            // 
            // Label_FileNamePrefix
            // 
            this.Label_FileNamePrefix.AutoSize = true;
            this.Label_FileNamePrefix.Location = new System.Drawing.Point(940, 859);
            this.Label_FileNamePrefix.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_FileNamePrefix.Name = "Label_FileNamePrefix";
            this.Label_FileNamePrefix.Size = new System.Drawing.Size(128, 18);
            this.Label_FileNamePrefix.TabIndex = 17;
            this.Label_FileNamePrefix.Text = "文件名（前缀）：";
            // 
            // Label_ParaMiu
            // 
            this.Label_ParaMiu.AutoSize = true;
            this.Label_ParaMiu.Location = new System.Drawing.Point(30, 93);
            this.Label_ParaMiu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ParaMiu.Name = "Label_ParaMiu";
            this.Label_ParaMiu.Size = new System.Drawing.Size(68, 18);
            this.Label_ParaMiu.TabIndex = 20;
            this.Label_ParaMiu.Text = "噪声均值";
            // 
            // Label_ParaSigma
            // 
            this.Label_ParaSigma.AutoSize = true;
            this.Label_ParaSigma.Location = new System.Drawing.Point(30, 150);
            this.Label_ParaSigma.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ParaSigma.Name = "Label_ParaSigma";
            this.Label_ParaSigma.Size = new System.Drawing.Size(68, 18);
            this.Label_ParaSigma.TabIndex = 21;
            this.Label_ParaSigma.Text = "噪声方差";
            // 
            // Label_Para1Min
            // 
            this.Label_Para1Min.AutoSize = true;
            this.Label_Para1Min.Location = new System.Drawing.Point(230, 42);
            this.Label_Para1Min.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_Para1Min.Name = "Label_Para1Min";
            this.Label_Para1Min.Size = new System.Drawing.Size(53, 18);
            this.Label_Para1Min.TabIndex = 22;
            this.Label_Para1Min.Text = "最小值";
            // 
            // Label_Para1Max
            // 
            this.Label_Para1Max.AutoSize = true;
            this.Label_Para1Max.Location = new System.Drawing.Point(418, 42);
            this.Label_Para1Max.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_Para1Max.Name = "Label_Para1Max";
            this.Label_Para1Max.Size = new System.Drawing.Size(53, 18);
            this.Label_Para1Max.TabIndex = 23;
            this.Label_Para1Max.Text = "最大值";
            // 
            // Value_ParaMiuMin
            // 
            this.Value_ParaMiuMin.Location = new System.Drawing.Point(214, 90);
            this.Value_ParaMiuMin.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaMiuMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Value_ParaMiuMin.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.Value_ParaMiuMin.Name = "Value_ParaMiuMin";
            this.Value_ParaMiuMin.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaMiuMin.TabIndex = 28;
            this.Value_ParaMiuMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_ParaMiuMin.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Value_ParaMiuMin.ValueChanged += new System.EventHandler(this.Value_ParaMiuMin_ValueChanged);
            // 
            // Value_ParaMiuMax
            // 
            this.Value_ParaMiuMax.Location = new System.Drawing.Point(402, 90);
            this.Value_ParaMiuMax.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaMiuMax.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Value_ParaMiuMax.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.Value_ParaMiuMax.Name = "Value_ParaMiuMax";
            this.Value_ParaMiuMax.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaMiuMax.TabIndex = 29;
            this.Value_ParaMiuMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_ParaMiuMax.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.Value_ParaMiuMax.ValueChanged += new System.EventHandler(this.Value_ParaMiuMax_ValueChanged);
            // 
            // Value_ParaSigmaMax
            // 
            this.Value_ParaSigmaMax.DecimalPlaces = 1;
            this.Value_ParaSigmaMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Value_ParaSigmaMax.Location = new System.Drawing.Point(402, 147);
            this.Value_ParaSigmaMax.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaSigmaMax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Value_ParaSigmaMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Value_ParaSigmaMax.Name = "Value_ParaSigmaMax";
            this.Value_ParaSigmaMax.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaSigmaMax.TabIndex = 31;
            this.Value_ParaSigmaMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_ParaSigmaMax.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Value_ParaSigmaMax.ValueChanged += new System.EventHandler(this.Value_ParaSigmaMax_ValueChanged);
            // 
            // Value_ParaSigmaMin
            // 
            this.Value_ParaSigmaMin.DecimalPlaces = 1;
            this.Value_ParaSigmaMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Value_ParaSigmaMin.Location = new System.Drawing.Point(214, 147);
            this.Value_ParaSigmaMin.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaSigmaMin.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Value_ParaSigmaMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Value_ParaSigmaMin.Name = "Value_ParaSigmaMin";
            this.Value_ParaSigmaMin.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaSigmaMin.TabIndex = 30;
            this.Value_ParaSigmaMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_ParaSigmaMin.Value = new decimal(new int[] {
            2,
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
            this.Value_ParaInterceptMax.Location = new System.Drawing.Point(360, 210);
            this.Value_ParaInterceptMax.Margin = new System.Windows.Forms.Padding(6);
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
            this.Value_ParaInterceptMax.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaInterceptMax.TabIndex = 41;
            this.Value_ParaInterceptMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Value_ParaInterceptMin.Location = new System.Drawing.Point(192, 210);
            this.Value_ParaInterceptMin.Margin = new System.Windows.Forms.Padding(6);
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
            this.Value_ParaInterceptMin.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaInterceptMin.TabIndex = 40;
            this.Value_ParaInterceptMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Value_ParaSlopeMax.Location = new System.Drawing.Point(360, 127);
            this.Value_ParaSlopeMax.Margin = new System.Windows.Forms.Padding(6);
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
            this.Value_ParaSlopeMax.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaSlopeMax.TabIndex = 39;
            this.Value_ParaSlopeMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Value_ParaSlopeMin.Location = new System.Drawing.Point(192, 127);
            this.Value_ParaSlopeMin.Margin = new System.Windows.Forms.Padding(6);
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
            this.Value_ParaSlopeMin.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaSlopeMin.TabIndex = 38;
            this.Value_ParaSlopeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_ParaSlopeMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label_Para21Max
            // 
            this.Label_Para21Max.AutoSize = true;
            this.Label_Para21Max.Location = new System.Drawing.Point(374, 96);
            this.Label_Para21Max.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_Para21Max.Name = "Label_Para21Max";
            this.Label_Para21Max.Size = new System.Drawing.Size(53, 18);
            this.Label_Para21Max.TabIndex = 37;
            this.Label_Para21Max.Text = "最大值";
            // 
            // Label_Para21Min
            // 
            this.Label_Para21Min.AutoSize = true;
            this.Label_Para21Min.Location = new System.Drawing.Point(208, 96);
            this.Label_Para21Min.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_Para21Min.Name = "Label_Para21Min";
            this.Label_Para21Min.Size = new System.Drawing.Size(53, 18);
            this.Label_Para21Min.TabIndex = 36;
            this.Label_Para21Min.Text = "最小值";
            this.Label_Para21Min.Click += new System.EventHandler(this.Label_Para21Min_Click);
            // 
            // Label_ParaIntercept
            // 
            this.Label_ParaIntercept.AutoSize = true;
            this.Label_ParaIntercept.Location = new System.Drawing.Point(30, 219);
            this.Label_ParaIntercept.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ParaIntercept.Name = "Label_ParaIntercept";
            this.Label_ParaIntercept.Size = new System.Drawing.Size(68, 18);
            this.Label_ParaIntercept.TabIndex = 35;
            this.Label_ParaIntercept.Text = "灰度平移";
            // 
            // Label_ParaSlope
            // 
            this.Label_ParaSlope.AutoSize = true;
            this.Label_ParaSlope.Location = new System.Drawing.Point(30, 135);
            this.Label_ParaSlope.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ParaSlope.Name = "Label_ParaSlope";
            this.Label_ParaSlope.Size = new System.Drawing.Size(68, 18);
            this.Label_ParaSlope.TabIndex = 34;
            this.Label_ParaSlope.Text = "变化倍数";
            // 
            // Value_ParaSigma2Max
            // 
            this.Value_ParaSigma2Max.Location = new System.Drawing.Point(402, 400);
            this.Value_ParaSigma2Max.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaSigma2Max.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.Value_ParaSigma2Max.Name = "Value_ParaSigma2Max";
            this.Value_ParaSigma2Max.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaSigma2Max.TabIndex = 49;
            this.Value_ParaSigma2Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_ParaSigma2Max.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Value_ParaSigma2Max.ValueChanged += new System.EventHandler(this.Value_ParaSigma2Max_ValueChanged);
            // 
            // Value_ParaSigma2Min
            // 
            this.Value_ParaSigma2Min.Location = new System.Drawing.Point(214, 400);
            this.Value_ParaSigma2Min.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaSigma2Min.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.Value_ParaSigma2Min.Name = "Value_ParaSigma2Min";
            this.Value_ParaSigma2Min.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaSigma2Min.TabIndex = 48;
            this.Value_ParaSigma2Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_ParaSigma2Min.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Value_ParaSigma2Min.ValueChanged += new System.EventHandler(this.Value_ParaSigma2Min_ValueChanged);
            // 
            // Label_Para3Max
            // 
            this.Label_Para3Max.AutoSize = true;
            this.Label_Para3Max.Location = new System.Drawing.Point(418, 363);
            this.Label_Para3Max.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_Para3Max.Name = "Label_Para3Max";
            this.Label_Para3Max.Size = new System.Drawing.Size(53, 18);
            this.Label_Para3Max.TabIndex = 47;
            this.Label_Para3Max.Text = "最大值";
            this.Label_Para3Max.Click += new System.EventHandler(this.Label_Para3Max_Click);
            // 
            // Label_Para3Min
            // 
            this.Label_Para3Min.AutoSize = true;
            this.Label_Para3Min.Location = new System.Drawing.Point(230, 363);
            this.Label_Para3Min.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_Para3Min.Name = "Label_Para3Min";
            this.Label_Para3Min.Size = new System.Drawing.Size(53, 18);
            this.Label_Para3Min.TabIndex = 46;
            this.Label_Para3Min.Text = "最小值";
            this.Label_Para3Min.Click += new System.EventHandler(this.Label_Para3Min_Click);
            // 
            // Label_ParaSigma2
            // 
            this.Label_ParaSigma2.AutoSize = true;
            this.Label_ParaSigma2.Location = new System.Drawing.Point(30, 403);
            this.Label_ParaSigma2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ParaSigma2.Name = "Label_ParaSigma2";
            this.Label_ParaSigma2.Size = new System.Drawing.Size(68, 18);
            this.Label_ParaSigma2.TabIndex = 45;
            this.Label_ParaSigma2.Text = "模糊程度";
            this.Label_ParaSigma2.Click += new System.EventHandler(this.Label_ParaSigma2_Click);
            // 
            // CheckBoxAlgo3GaussianBlur
            // 
            this.CheckBoxAlgo3GaussianBlur.AutoSize = true;
            this.CheckBoxAlgo3GaussianBlur.Location = new System.Drawing.Point(34, 361);
            this.CheckBoxAlgo3GaussianBlur.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBoxAlgo3GaussianBlur.Name = "CheckBoxAlgo3GaussianBlur";
            this.CheckBoxAlgo3GaussianBlur.Size = new System.Drawing.Size(90, 22);
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
            this.tabControl_MainForm.Location = new System.Drawing.Point(926, 25);
            this.tabControl_MainForm.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl_MainForm.Name = "tabControl_MainForm";
            this.tabControl_MainForm.SelectedIndex = 0;
            this.tabControl_MainForm.Size = new System.Drawing.Size(616, 526);
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
            this.tabPage1_MainForm.Location = new System.Drawing.Point(4, 27);
            this.tabPage1_MainForm.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1_MainForm.Name = "tabPage1_MainForm";
            this.tabPage1_MainForm.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1_MainForm.Size = new System.Drawing.Size(608, 495);
            this.tabPage1_MainForm.TabIndex = 0;
            this.tabPage1_MainForm.Text = "加噪、模糊";
            this.tabPage1_MainForm.UseVisualStyleBackColor = true;
            this.tabPage1_MainForm.Click += new System.EventHandler(this.tabPage1_MainForm_Click);
            // 
            // ComboBox_PepperNoise
            // 
            this.ComboBox_PepperNoise.FormattingEnabled = true;
            this.ComboBox_PepperNoise.Items.AddRange(new object[] {
            "仅椒噪声",
            "仅盐噪声",
            "椒盐噪声"});
            this.ComboBox_PepperNoise.Location = new System.Drawing.Point(232, 209);
            this.ComboBox_PepperNoise.Margin = new System.Windows.Forms.Padding(6);
            this.ComboBox_PepperNoise.Name = "ComboBox_PepperNoise";
            this.ComboBox_PepperNoise.Size = new System.Drawing.Size(242, 26);
            this.ComboBox_PepperNoise.TabIndex = 56;
            this.ComboBox_PepperNoise.Text = "请选择噪声种类";
            this.ComboBox_PepperNoise.SelectedIndexChanged += new System.EventHandler(this.ComboBox_PepperNoise_SelectedIndexChanged);
            // 
            // Value_ParaNoiseCoeffMax
            // 
            this.Value_ParaNoiseCoeffMax.Location = new System.Drawing.Point(402, 297);
            this.Value_ParaNoiseCoeffMax.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaNoiseCoeffMax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Value_ParaNoiseCoeffMax.Name = "Value_ParaNoiseCoeffMax";
            this.Value_ParaNoiseCoeffMax.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaNoiseCoeffMax.TabIndex = 55;
            this.Value_ParaNoiseCoeffMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_ParaNoiseCoeffMax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // CheckBoxAlgo4PepperNoise
            // 
            this.CheckBoxAlgo4PepperNoise.AutoSize = true;
            this.CheckBoxAlgo4PepperNoise.Location = new System.Drawing.Point(34, 214);
            this.CheckBoxAlgo4PepperNoise.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBoxAlgo4PepperNoise.Name = "CheckBoxAlgo4PepperNoise";
            this.CheckBoxAlgo4PepperNoise.Size = new System.Drawing.Size(90, 22);
            this.CheckBoxAlgo4PepperNoise.TabIndex = 50;
            this.CheckBoxAlgo4PepperNoise.Text = "椒盐噪声";
            this.CheckBoxAlgo4PepperNoise.UseVisualStyleBackColor = true;
            this.CheckBoxAlgo4PepperNoise.CheckedChanged += new System.EventHandler(this.CheckBoxAlgo4PepperNoise_CheckedChanged);
            // 
            // Label_PepperNoise
            // 
            this.Label_PepperNoise.AutoSize = true;
            this.Label_PepperNoise.Location = new System.Drawing.Point(28, 300);
            this.Label_PepperNoise.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_PepperNoise.Name = "Label_PepperNoise";
            this.Label_PepperNoise.Size = new System.Drawing.Size(68, 18);
            this.Label_PepperNoise.TabIndex = 51;
            this.Label_PepperNoise.Text = "噪声比例";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "最小值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "最大值";
            // 
            // Value_ParaNoiseCoeffMin
            // 
            this.Value_ParaNoiseCoeffMin.Location = new System.Drawing.Point(214, 297);
            this.Value_ParaNoiseCoeffMin.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaNoiseCoeffMin.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Value_ParaNoiseCoeffMin.Name = "Value_ParaNoiseCoeffMin";
            this.Value_ParaNoiseCoeffMin.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaNoiseCoeffMin.TabIndex = 54;
            this.Value_ParaNoiseCoeffMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2_MainForm
            // 
            this.tabPage2_MainForm.Controls.Add(this.ComboBox_PyrDown);
            this.tabPage2_MainForm.Controls.Add(this.label1);
            this.tabPage2_MainForm.Controls.Add(this.Value_ParaPyrDownCoeff);
            this.tabPage2_MainForm.Controls.Add(this.CheckBoxPyrDown);
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
            this.tabPage2_MainForm.Location = new System.Drawing.Point(4, 27);
            this.tabPage2_MainForm.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2_MainForm.Name = "tabPage2_MainForm";
            this.tabPage2_MainForm.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2_MainForm.Size = new System.Drawing.Size(608, 495);
            this.tabPage2_MainForm.TabIndex = 1;
            this.tabPage2_MainForm.Text = "分辨率、对比度";
            this.tabPage2_MainForm.UseVisualStyleBackColor = true;
            // 
            // ComboBox_PyrDown
            // 
            this.ComboBox_PyrDown.FormattingEnabled = true;
            this.ComboBox_PyrDown.Items.AddRange(new object[] {
            "复原尺寸-通过上采样",
            "不复原"});
            this.ComboBox_PyrDown.Location = new System.Drawing.Point(192, 304);
            this.ComboBox_PyrDown.Margin = new System.Windows.Forms.Padding(6);
            this.ComboBox_PyrDown.Name = "ComboBox_PyrDown";
            this.ComboBox_PyrDown.Size = new System.Drawing.Size(238, 26);
            this.ComboBox_PyrDown.TabIndex = 56;
            this.ComboBox_PyrDown.Text = "选择是否复原尺寸";
            this.ComboBox_PyrDown.SelectedIndexChanged += new System.EventHandler(this.ComboBox_PyrDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 356);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "1/2降采样次数";
            // 
            // Value_ParaPyrDownCoeff
            // 
            this.Value_ParaPyrDownCoeff.Location = new System.Drawing.Point(360, 353);
            this.Value_ParaPyrDownCoeff.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaPyrDownCoeff.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Value_ParaPyrDownCoeff.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Value_ParaPyrDownCoeff.Name = "Value_ParaPyrDownCoeff";
            this.Value_ParaPyrDownCoeff.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaPyrDownCoeff.TabIndex = 46;
            this.Value_ParaPyrDownCoeff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_ParaPyrDownCoeff.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Value_ParaPyrDownCoeff.ValueChanged += new System.EventHandler(this.Value_ParaPyrDownCoeff_ValueChanged);
            // 
            // CheckBoxPyrDown
            // 
            this.CheckBoxPyrDown.AutoSize = true;
            this.CheckBoxPyrDown.Location = new System.Drawing.Point(34, 309);
            this.CheckBoxPyrDown.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBoxPyrDown.Name = "CheckBoxPyrDown";
            this.CheckBoxPyrDown.Size = new System.Drawing.Size(75, 22);
            this.CheckBoxPyrDown.TabIndex = 45;
            this.CheckBoxPyrDown.Text = "降采样";
            this.CheckBoxPyrDown.UseVisualStyleBackColor = true;
            this.CheckBoxPyrDown.CheckedChanged += new System.EventHandler(this.CheckBoxPyrDown_CheckedChanged);
            // 
            // ComboBox_GrayScale
            // 
            this.ComboBox_GrayScale.FormattingEnabled = true;
            this.ComboBox_GrayScale.Items.AddRange(new object[] {
            "增大对比度和亮度",
            "减小对比度和亮度",
            "倒置"});
            this.ComboBox_GrayScale.Location = new System.Drawing.Point(192, 23);
            this.ComboBox_GrayScale.Margin = new System.Windows.Forms.Padding(6);
            this.ComboBox_GrayScale.Name = "ComboBox_GrayScale";
            this.ComboBox_GrayScale.Size = new System.Drawing.Size(238, 26);
            this.ComboBox_GrayScale.TabIndex = 42;
            this.ComboBox_GrayScale.Text = "请选择变化形式";
            this.ComboBox_GrayScale.SelectedIndexChanged += new System.EventHandler(this.ComboBox_GrayScale_SelectedIndexChanged);
            // 
            // tabPage3_MainForm
            // 
            this.tabPage3_MainForm.Controls.Add(this.Value_ParaAngleMax);
            this.tabPage3_MainForm.Controls.Add(this.label8);
            this.tabPage3_MainForm.Controls.Add(this.Value_ParaAngleMin);
            this.tabPage3_MainForm.Controls.Add(this.CheckBoxRotate);
            this.tabPage3_MainForm.Controls.Add(this.Value_ParaOffsetYMax);
            this.tabPage3_MainForm.Controls.Add(this.label5);
            this.tabPage3_MainForm.Controls.Add(this.Value_ParaOffsetYMin);
            this.tabPage3_MainForm.Controls.Add(this.CheckBoxOffsetY);
            this.tabPage3_MainForm.Controls.Add(this.Value_ParaOffsetXMax);
            this.tabPage3_MainForm.Controls.Add(this.Value_ParaOffsetXMin);
            this.tabPage3_MainForm.Controls.Add(this.CheckBoxOffsetX);
            this.tabPage3_MainForm.Location = new System.Drawing.Point(4, 27);
            this.tabPage3_MainForm.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage3_MainForm.Name = "tabPage3_MainForm";
            this.tabPage3_MainForm.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage3_MainForm.Size = new System.Drawing.Size(608, 495);
            this.tabPage3_MainForm.TabIndex = 2;
            this.tabPage3_MainForm.Text = "空间移动";
            this.tabPage3_MainForm.UseVisualStyleBackColor = true;
            this.tabPage3_MainForm.Click += new System.EventHandler(this.tabPage3_MainForm_Click);
            // 
            // Value_ParaAngleMax
            // 
            this.Value_ParaAngleMax.Location = new System.Drawing.Point(356, 223);
            this.Value_ParaAngleMax.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaAngleMax.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.Value_ParaAngleMax.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.Value_ParaAngleMax.Name = "Value_ParaAngleMax";
            this.Value_ParaAngleMax.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaAngleMax.TabIndex = 53;
            this.Value_ParaAngleMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_ParaAngleMax.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Value_ParaAngleMax.ValueChanged += new System.EventHandler(this.Value_ParaAngleMax_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 51;
            this.label8.Text = "最大值";
            // 
            // Value_ParaAngleMin
            // 
            this.Value_ParaAngleMin.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Value_ParaAngleMin.Location = new System.Drawing.Point(186, 223);
            this.Value_ParaAngleMin.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaAngleMin.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.Value_ParaAngleMin.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.Value_ParaAngleMin.Name = "Value_ParaAngleMin";
            this.Value_ParaAngleMin.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaAngleMin.TabIndex = 52;
            this.Value_ParaAngleMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_ParaAngleMin.Value = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.Value_ParaAngleMin.ValueChanged += new System.EventHandler(this.Value_ParaAngleMin_ValueChanged);
            // 
            // CheckBoxRotate
            // 
            this.CheckBoxRotate.AutoSize = true;
            this.CheckBoxRotate.Location = new System.Drawing.Point(32, 225);
            this.CheckBoxRotate.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBoxRotate.Name = "CheckBoxRotate";
            this.CheckBoxRotate.Size = new System.Drawing.Size(60, 22);
            this.CheckBoxRotate.TabIndex = 49;
            this.CheckBoxRotate.Text = "旋转";
            this.CheckBoxRotate.UseVisualStyleBackColor = true;
            this.CheckBoxRotate.CheckedChanged += new System.EventHandler(this.CheckBoxRotate_CheckedChanged);
            // 
            // Value_ParaOffsetYMax
            // 
            this.Value_ParaOffsetYMax.Location = new System.Drawing.Point(356, 152);
            this.Value_ParaOffsetYMax.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaOffsetYMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Value_ParaOffsetYMax.Name = "Value_ParaOffsetYMax";
            this.Value_ParaOffsetYMax.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaOffsetYMax.TabIndex = 48;
            this.Value_ParaOffsetYMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_ParaOffsetYMax.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Value_ParaOffsetYMax.ValueChanged += new System.EventHandler(this.Value_ParaOffsetYMax_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "最小值";
            // 
            // Value_ParaOffsetYMin
            // 
            this.Value_ParaOffsetYMin.Location = new System.Drawing.Point(186, 152);
            this.Value_ParaOffsetYMin.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaOffsetYMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Value_ParaOffsetYMin.Name = "Value_ParaOffsetYMin";
            this.Value_ParaOffsetYMin.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaOffsetYMin.TabIndex = 47;
            this.Value_ParaOffsetYMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_ParaOffsetYMin.Value = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.Value_ParaOffsetYMin.ValueChanged += new System.EventHandler(this.Value_ParaOffsetYMin_ValueChanged);
            // 
            // CheckBoxOffsetY
            // 
            this.CheckBoxOffsetY.AutoSize = true;
            this.CheckBoxOffsetY.Location = new System.Drawing.Point(32, 154);
            this.CheckBoxOffsetY.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBoxOffsetY.Name = "CheckBoxOffsetY";
            this.CheckBoxOffsetY.Size = new System.Drawing.Size(69, 22);
            this.CheckBoxOffsetY.TabIndex = 44;
            this.CheckBoxOffsetY.Text = "Y平移";
            this.CheckBoxOffsetY.UseVisualStyleBackColor = true;
            this.CheckBoxOffsetY.CheckedChanged += new System.EventHandler(this.CheckBoxOffsetY_CheckedChanged);
            // 
            // Value_ParaOffsetXMax
            // 
            this.Value_ParaOffsetXMax.Location = new System.Drawing.Point(356, 73);
            this.Value_ParaOffsetXMax.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaOffsetXMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Value_ParaOffsetXMax.Name = "Value_ParaOffsetXMax";
            this.Value_ParaOffsetXMax.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaOffsetXMax.TabIndex = 43;
            this.Value_ParaOffsetXMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_ParaOffsetXMax.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Value_ParaOffsetXMax.ValueChanged += new System.EventHandler(this.Value_ParaOffsetXMax_ValueChanged);
            // 
            // Value_ParaOffsetXMin
            // 
            this.Value_ParaOffsetXMin.Location = new System.Drawing.Point(186, 73);
            this.Value_ParaOffsetXMin.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaOffsetXMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Value_ParaOffsetXMin.Name = "Value_ParaOffsetXMin";
            this.Value_ParaOffsetXMin.Size = new System.Drawing.Size(112, 24);
            this.Value_ParaOffsetXMin.TabIndex = 42;
            this.Value_ParaOffsetXMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_ParaOffsetXMin.Value = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.Value_ParaOffsetXMin.ValueChanged += new System.EventHandler(this.Value_ParaOffsetXMin_ValueChanged);
            // 
            // CheckBoxOffsetX
            // 
            this.CheckBoxOffsetX.AutoSize = true;
            this.CheckBoxOffsetX.Location = new System.Drawing.Point(32, 75);
            this.CheckBoxOffsetX.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBoxOffsetX.Name = "CheckBoxOffsetX";
            this.CheckBoxOffsetX.Size = new System.Drawing.Size(70, 22);
            this.CheckBoxOffsetX.TabIndex = 6;
            this.CheckBoxOffsetX.Text = "X平移";
            this.CheckBoxOffsetX.UseVisualStyleBackColor = true;
            this.CheckBoxOffsetX.CheckedChanged += new System.EventHandler(this.CheckBoxOffsetX_CheckedChanged);
            // 
            // Button_PreviewForm
            // 
            this.Button_PreviewForm.Location = new System.Drawing.Point(1320, 604);
            this.Button_PreviewForm.Margin = new System.Windows.Forms.Padding(6);
            this.Button_PreviewForm.Name = "Button_PreviewForm";
            this.Button_PreviewForm.Size = new System.Drawing.Size(222, 108);
            this.Button_PreviewForm.TabIndex = 51;
            this.Button_PreviewForm.Text = "退化预览";
            this.Button_PreviewForm.UseVisualStyleBackColor = true;
            this.Button_PreviewForm.Click += new System.EventHandler(this.Button_PreviewForm_Click);
            // 
            // Value_PSNRThreshold
            // 
            this.Value_PSNRThreshold.DecimalPlaces = 2;
            this.Value_PSNRThreshold.Location = new System.Drawing.Point(1146, 606);
            this.Value_PSNRThreshold.Margin = new System.Windows.Forms.Padding(6);
            this.Value_PSNRThreshold.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Value_PSNRThreshold.Name = "Value_PSNRThreshold";
            this.Value_PSNRThreshold.Size = new System.Drawing.Size(126, 24);
            this.Value_PSNRThreshold.TabIndex = 53;
            this.Value_PSNRThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_PSNRThreshold.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // CheckBoxIQAThreshold
            // 
            this.CheckBoxIQAThreshold.AutoSize = true;
            this.CheckBoxIQAThreshold.Location = new System.Drawing.Point(940, 564);
            this.CheckBoxIQAThreshold.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBoxIQAThreshold.Name = "CheckBoxIQAThreshold";
            this.CheckBoxIQAThreshold.Size = new System.Drawing.Size(120, 22);
            this.CheckBoxIQAThreshold.TabIndex = 54;
            this.CheckBoxIQAThreshold.Text = "质量评估筛选";
            this.CheckBoxIQAThreshold.UseVisualStyleBackColor = true;
            this.CheckBoxIQAThreshold.CheckedChanged += new System.EventHandler(this.CheckBoxIQAThreshold_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(940, 609);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 55;
            this.label4.Text = "PSNR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(940, 660);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 57;
            this.label6.Text = "SSIM(无位移）";
            // 
            // Value_SSIMThreshold
            // 
            this.Value_SSIMThreshold.DecimalPlaces = 2;
            this.Value_SSIMThreshold.Location = new System.Drawing.Point(1146, 657);
            this.Value_SSIMThreshold.Margin = new System.Windows.Forms.Padding(6);
            this.Value_SSIMThreshold.Name = "Value_SSIMThreshold";
            this.Value_SSIMThreshold.Size = new System.Drawing.Size(126, 24);
            this.Value_SSIMThreshold.TabIndex = 56;
            this.Value_SSIMThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_SSIMThreshold.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(940, 762);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 59;
            this.label7.Text = "HASH";
            // 
            // Value_HashThreshold
            // 
            this.Value_HashThreshold.DecimalPlaces = 2;
            this.Value_HashThreshold.Location = new System.Drawing.Point(1146, 759);
            this.Value_HashThreshold.Margin = new System.Windows.Forms.Padding(6);
            this.Value_HashThreshold.Name = "Value_HashThreshold";
            this.Value_HashThreshold.Size = new System.Drawing.Size(126, 24);
            this.Value_HashThreshold.TabIndex = 58;
            this.Value_HashThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_HashThreshold.Value = new decimal(new int[] {
            80,
            0,
            0,
            131072});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(940, 711);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 18);
            this.label9.TabIndex = 61;
            this.label9.Text = "SSIM(有位移）";
            // 
            // Value_SSIMOffsetThreshold
            // 
            this.Value_SSIMOffsetThreshold.DecimalPlaces = 2;
            this.Value_SSIMOffsetThreshold.Location = new System.Drawing.Point(1146, 708);
            this.Value_SSIMOffsetThreshold.Margin = new System.Windows.Forms.Padding(6);
            this.Value_SSIMOffsetThreshold.Name = "Value_SSIMOffsetThreshold";
            this.Value_SSIMOffsetThreshold.Size = new System.Drawing.Size(126, 24);
            this.Value_SSIMOffsetThreshold.TabIndex = 60;
            this.Value_SSIMOffsetThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value_SSIMOffsetThreshold.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // bgWorker_pBarImg
            // 
            this.bgWorker_pBarImg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_pBarImg_DoWork);
            this.bgWorker_pBarImg.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_pBarImg_RunWorkerCompleted);
            // 
            // timer_ComfirmForm
            // 
            this.timer_ComfirmForm.Interval = 500;
            this.timer_ComfirmForm.Tick += new System.EventHandler(this.timer_ComfirmForm_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1574, 929);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Value_SSIMOffsetThreshold);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Value_HashThreshold);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Value_SSIMThreshold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CheckBoxIQAThreshold);
            this.Controls.Add(this.Value_PSNRThreshold);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "机器视觉退化验证器";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaPyrDownCoeff)).EndInit();
            this.tabPage3_MainForm.ResumeLayout(false);
            this.tabPage3_MainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaAngleMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaAngleMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaOffsetYMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaOffsetYMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaOffsetXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaOffsetXMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_PSNRThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_SSIMThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_HashThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_SSIMOffsetThreshold)).EndInit();
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
        private System.Windows.Forms.ComboBox ComboBox_PepperNoise;
        private System.Windows.Forms.NumericUpDown Value_ParaNoiseCoeffMax;
        private System.Windows.Forms.CheckBox CheckBoxAlgo4PepperNoise;
        private System.Windows.Forms.Label Label_PepperNoise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Value_ParaNoiseCoeffMin;
        private System.Windows.Forms.NumericUpDown Value_ParaAngleMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Value_ParaAngleMin;
        private System.Windows.Forms.CheckBox CheckBoxRotate;
        private System.Windows.Forms.NumericUpDown Value_ParaOffsetYMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Value_ParaOffsetYMin;
        private System.Windows.Forms.CheckBox CheckBoxOffsetY;
        private System.Windows.Forms.NumericUpDown Value_ParaOffsetXMax;
        private System.Windows.Forms.NumericUpDown Value_ParaOffsetXMin;
        private System.Windows.Forms.CheckBox CheckBoxOffsetX;
        private System.Windows.Forms.CheckBox CheckBoxPyrDown;
        private System.Windows.Forms.NumericUpDown Value_ParaPyrDownCoeff;
        private System.Windows.Forms.NumericUpDown Value_PSNRThreshold;
        private System.Windows.Forms.CheckBox CheckBoxIQAThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Value_SSIMThreshold;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Value_HashThreshold;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Value_SSIMOffsetThreshold;
        private System.ComponentModel.BackgroundWorker bgWorker_pBarImg;
        private System.Windows.Forms.Timer timer_ComfirmForm;
        private System.Windows.Forms.ComboBox ComboBox_PyrDown;
    }
}

