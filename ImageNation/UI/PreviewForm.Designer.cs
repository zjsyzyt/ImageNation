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
            this.Button_SetParaNoiseCoeffMax = new System.Windows.Forms.Button();
            this.Button_SetParaNoiseCoeffMin = new System.Windows.Forms.Button();
            this.TrackBar_ParaNoiseCoeff = new System.Windows.Forms.TrackBar();
            this.Value_ParaNoiseCoeff_PreView = new System.Windows.Forms.NumericUpDown();
            this.Button_SetParaSigma2Max = new System.Windows.Forms.Button();
            this.Button_SetParaSigma2Min = new System.Windows.Forms.Button();
            this.Button_SetParaSigmaMax = new System.Windows.Forms.Button();
            this.Button_SetParaSigmaMin = new System.Windows.Forms.Button();
            this.Button_SetParaMiuMax = new System.Windows.Forms.Button();
            this.Button_SetParaMiuMin = new System.Windows.Forms.Button();
            this.ComboBox_PepperNoise = new System.Windows.Forms.ComboBox();
            this.CheckBoxAlgo4PepperNoise = new System.Windows.Forms.CheckBox();
            this.Label_PepperNoise = new System.Windows.Forms.Label();
            this.Value_ParaSigma2_PreView = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxAlgo1Gauss = new System.Windows.Forms.CheckBox();
            this.TrackBar_ParaMiu = new System.Windows.Forms.TrackBar();
            this.TrackBar_ParaSigma = new System.Windows.Forms.TrackBar();
            this.Label_ParaSigma2 = new System.Windows.Forms.Label();
            this.Label_ParaMiu = new System.Windows.Forms.Label();
            this.TrackBar_ParaSigma2 = new System.Windows.Forms.TrackBar();
            this.Label_ParaSigma = new System.Windows.Forms.Label();
            this.CheckBoxAlgo3GaussianBlur = new System.Windows.Forms.CheckBox();
            this.Value_ParaMiu_PreView = new System.Windows.Forms.NumericUpDown();
            this.Value_ParaSigma_PreView = new System.Windows.Forms.NumericUpDown();
            this.tabPage2_MainForm = new System.Windows.Forms.TabPage();
            this.Label_ParaIntercept = new System.Windows.Forms.Label();
            this.Label_ParaSlope = new System.Windows.Forms.Label();
            this.Button_SetParaInterceptMax = new System.Windows.Forms.Button();
            this.Button_SetParaInterceptMin = new System.Windows.Forms.Button();
            this.Button_SetParaSlopeMax = new System.Windows.Forms.Button();
            this.Button_SetParaSlopeMin = new System.Windows.Forms.Button();
            this.ComboBox_GrayScale = new System.Windows.Forms.ComboBox();
            this.CheckBoxAlgo2GrayScale = new System.Windows.Forms.CheckBox();
            this.Value_ParaSlope_PreView = new System.Windows.Forms.NumericUpDown();
            this.TrackBar_ParaSlope = new System.Windows.Forms.TrackBar();
            this.TrackBar_ParaIntercept = new System.Windows.Forms.TrackBar();
            this.Value_ParaIntercept_PreView = new System.Windows.Forms.NumericUpDown();
            this.tabPage3_MainForm = new System.Windows.Forms.TabPage();
            this.pictureBox_SrcImg = new System.Windows.Forms.PictureBox();
            this.pictureBox_DstImg = new System.Windows.Forms.PictureBox();
            this.CheckBoxOffsetX = new System.Windows.Forms.CheckBox();
            this.tabControl_MainForm.SuspendLayout();
            this.tabPage1_MainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaNoiseCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaNoiseCoeff_PreView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigma2_PreView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaMiu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSigma2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaMiu_PreView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigma_PreView)).BeginInit();
            this.tabPage2_MainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSlope_PreView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSlope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaIntercept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaIntercept_PreView)).BeginInit();
            this.tabPage3_MainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SrcImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DstImg)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_PreviewForm
            // 
            this.Button_PreviewForm.Location = new System.Drawing.Point(1142, 1123);
            this.Button_PreviewForm.Margin = new System.Windows.Forms.Padding(6);
            this.Button_PreviewForm.Name = "Button_PreviewForm";
            this.Button_PreviewForm.Size = new System.Drawing.Size(254, 108);
            this.Button_PreviewForm.TabIndex = 54;
            this.Button_PreviewForm.Text = "一键退化";
            this.Button_PreviewForm.UseVisualStyleBackColor = true;
            // 
            // tabControl_MainForm
            // 
            this.tabControl_MainForm.Controls.Add(this.tabPage1_MainForm);
            this.tabControl_MainForm.Controls.Add(this.tabPage2_MainForm);
            this.tabControl_MainForm.Controls.Add(this.tabPage3_MainForm);
            this.tabControl_MainForm.Location = new System.Drawing.Point(24, 704);
            this.tabControl_MainForm.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl_MainForm.Name = "tabControl_MainForm";
            this.tabControl_MainForm.SelectedIndex = 0;
            this.tabControl_MainForm.Size = new System.Drawing.Size(1032, 535);
            this.tabControl_MainForm.TabIndex = 53;
            // 
            // tabPage1_MainForm
            // 
            this.tabPage1_MainForm.Controls.Add(this.Button_SetParaNoiseCoeffMax);
            this.tabPage1_MainForm.Controls.Add(this.Button_SetParaNoiseCoeffMin);
            this.tabPage1_MainForm.Controls.Add(this.TrackBar_ParaNoiseCoeff);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaNoiseCoeff_PreView);
            this.tabPage1_MainForm.Controls.Add(this.Button_SetParaSigma2Max);
            this.tabPage1_MainForm.Controls.Add(this.Button_SetParaSigma2Min);
            this.tabPage1_MainForm.Controls.Add(this.Button_SetParaSigmaMax);
            this.tabPage1_MainForm.Controls.Add(this.Button_SetParaSigmaMin);
            this.tabPage1_MainForm.Controls.Add(this.Button_SetParaMiuMax);
            this.tabPage1_MainForm.Controls.Add(this.Button_SetParaMiuMin);
            this.tabPage1_MainForm.Controls.Add(this.ComboBox_PepperNoise);
            this.tabPage1_MainForm.Controls.Add(this.CheckBoxAlgo4PepperNoise);
            this.tabPage1_MainForm.Controls.Add(this.Label_PepperNoise);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaSigma2_PreView);
            this.tabPage1_MainForm.Controls.Add(this.CheckBoxAlgo1Gauss);
            this.tabPage1_MainForm.Controls.Add(this.TrackBar_ParaMiu);
            this.tabPage1_MainForm.Controls.Add(this.TrackBar_ParaSigma);
            this.tabPage1_MainForm.Controls.Add(this.Label_ParaSigma2);
            this.tabPage1_MainForm.Controls.Add(this.Label_ParaMiu);
            this.tabPage1_MainForm.Controls.Add(this.TrackBar_ParaSigma2);
            this.tabPage1_MainForm.Controls.Add(this.Label_ParaSigma);
            this.tabPage1_MainForm.Controls.Add(this.CheckBoxAlgo3GaussianBlur);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaMiu_PreView);
            this.tabPage1_MainForm.Controls.Add(this.Value_ParaSigma_PreView);
            this.tabPage1_MainForm.Location = new System.Drawing.Point(8, 39);
            this.tabPage1_MainForm.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1_MainForm.Name = "tabPage1_MainForm";
            this.tabPage1_MainForm.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1_MainForm.Size = new System.Drawing.Size(1016, 488);
            this.tabPage1_MainForm.TabIndex = 0;
            this.tabPage1_MainForm.Text = "加噪、模糊";
            this.tabPage1_MainForm.UseVisualStyleBackColor = true;
            // 
            // Button_SetParaNoiseCoeffMax
            // 
            this.Button_SetParaNoiseCoeffMax.Location = new System.Drawing.Point(732, 298);
            this.Button_SetParaNoiseCoeffMax.Margin = new System.Windows.Forms.Padding(6);
            this.Button_SetParaNoiseCoeffMax.Name = "Button_SetParaNoiseCoeffMax";
            this.Button_SetParaNoiseCoeffMax.Size = new System.Drawing.Size(150, 48);
            this.Button_SetParaNoiseCoeffMax.TabIndex = 69;
            this.Button_SetParaNoiseCoeffMax.Text = "设为最大值";
            this.Button_SetParaNoiseCoeffMax.UseVisualStyleBackColor = true;
            this.Button_SetParaNoiseCoeffMax.Click += new System.EventHandler(this.Button_SetParaNoiseCoeffMax_Click);
            // 
            // Button_SetParaNoiseCoeffMin
            // 
            this.Button_SetParaNoiseCoeffMin.Location = new System.Drawing.Point(548, 298);
            this.Button_SetParaNoiseCoeffMin.Margin = new System.Windows.Forms.Padding(6);
            this.Button_SetParaNoiseCoeffMin.Name = "Button_SetParaNoiseCoeffMin";
            this.Button_SetParaNoiseCoeffMin.Size = new System.Drawing.Size(150, 48);
            this.Button_SetParaNoiseCoeffMin.TabIndex = 68;
            this.Button_SetParaNoiseCoeffMin.Text = "设为最小值";
            this.Button_SetParaNoiseCoeffMin.UseVisualStyleBackColor = true;
            this.Button_SetParaNoiseCoeffMin.Click += new System.EventHandler(this.Button_SetParaNoiseCoeffMin_Click);
            // 
            // TrackBar_ParaNoiseCoeff
            // 
            this.TrackBar_ParaNoiseCoeff.AutoSize = false;
            this.TrackBar_ParaNoiseCoeff.Location = new System.Drawing.Point(144, 300);
            this.TrackBar_ParaNoiseCoeff.Margin = new System.Windows.Forms.Padding(6);
            this.TrackBar_ParaNoiseCoeff.Maximum = 20;
            this.TrackBar_ParaNoiseCoeff.Name = "TrackBar_ParaNoiseCoeff";
            this.TrackBar_ParaNoiseCoeff.Size = new System.Drawing.Size(232, 44);
            this.TrackBar_ParaNoiseCoeff.TabIndex = 66;
            this.TrackBar_ParaNoiseCoeff.Scroll += new System.EventHandler(this.TrackBar_ParaNoiseCoeff_Scroll);
            // 
            // Value_ParaNoiseCoeff_PreView
            // 
            this.Value_ParaNoiseCoeff_PreView.Location = new System.Drawing.Point(392, 306);
            this.Value_ParaNoiseCoeff_PreView.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaNoiseCoeff_PreView.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Value_ParaNoiseCoeff_PreView.Name = "Value_ParaNoiseCoeff_PreView";
            this.Value_ParaNoiseCoeff_PreView.Size = new System.Drawing.Size(112, 31);
            this.Value_ParaNoiseCoeff_PreView.TabIndex = 67;
            this.Value_ParaNoiseCoeff_PreView.ValueChanged += new System.EventHandler(this.Value_ParaNoiseCoeff_PreView_ValueChanged);
            // 
            // Button_SetParaSigma2Max
            // 
            this.Button_SetParaSigma2Max.Location = new System.Drawing.Point(732, 427);
            this.Button_SetParaSigma2Max.Margin = new System.Windows.Forms.Padding(6);
            this.Button_SetParaSigma2Max.Name = "Button_SetParaSigma2Max";
            this.Button_SetParaSigma2Max.Size = new System.Drawing.Size(150, 48);
            this.Button_SetParaSigma2Max.TabIndex = 65;
            this.Button_SetParaSigma2Max.Text = "设为最大值";
            this.Button_SetParaSigma2Max.UseVisualStyleBackColor = true;
            this.Button_SetParaSigma2Max.Click += new System.EventHandler(this.Button_SetParaSigma2Max_Click);
            // 
            // Button_SetParaSigma2Min
            // 
            this.Button_SetParaSigma2Min.Location = new System.Drawing.Point(548, 427);
            this.Button_SetParaSigma2Min.Margin = new System.Windows.Forms.Padding(6);
            this.Button_SetParaSigma2Min.Name = "Button_SetParaSigma2Min";
            this.Button_SetParaSigma2Min.Size = new System.Drawing.Size(150, 48);
            this.Button_SetParaSigma2Min.TabIndex = 64;
            this.Button_SetParaSigma2Min.Text = "设为最小值";
            this.Button_SetParaSigma2Min.UseVisualStyleBackColor = true;
            this.Button_SetParaSigma2Min.Click += new System.EventHandler(this.Button_SetParaSigma2Min_Click);
            // 
            // Button_SetParaSigmaMax
            // 
            this.Button_SetParaSigmaMax.Location = new System.Drawing.Point(732, 158);
            this.Button_SetParaSigmaMax.Margin = new System.Windows.Forms.Padding(6);
            this.Button_SetParaSigmaMax.Name = "Button_SetParaSigmaMax";
            this.Button_SetParaSigmaMax.Size = new System.Drawing.Size(150, 48);
            this.Button_SetParaSigmaMax.TabIndex = 63;
            this.Button_SetParaSigmaMax.Text = "设为最大值";
            this.Button_SetParaSigmaMax.UseVisualStyleBackColor = true;
            this.Button_SetParaSigmaMax.Click += new System.EventHandler(this.Button_SetParaSigmaMax_Click);
            // 
            // Button_SetParaSigmaMin
            // 
            this.Button_SetParaSigmaMin.Location = new System.Drawing.Point(548, 158);
            this.Button_SetParaSigmaMin.Margin = new System.Windows.Forms.Padding(6);
            this.Button_SetParaSigmaMin.Name = "Button_SetParaSigmaMin";
            this.Button_SetParaSigmaMin.Size = new System.Drawing.Size(150, 48);
            this.Button_SetParaSigmaMin.TabIndex = 62;
            this.Button_SetParaSigmaMin.Text = "设为最小值";
            this.Button_SetParaSigmaMin.UseVisualStyleBackColor = true;
            this.Button_SetParaSigmaMin.Click += new System.EventHandler(this.Button_SetParaSigmaMin_Click);
            // 
            // Button_SetParaMiuMax
            // 
            this.Button_SetParaMiuMax.Location = new System.Drawing.Point(732, 79);
            this.Button_SetParaMiuMax.Margin = new System.Windows.Forms.Padding(6);
            this.Button_SetParaMiuMax.Name = "Button_SetParaMiuMax";
            this.Button_SetParaMiuMax.Size = new System.Drawing.Size(150, 48);
            this.Button_SetParaMiuMax.TabIndex = 61;
            this.Button_SetParaMiuMax.Text = "设为最大值";
            this.Button_SetParaMiuMax.UseVisualStyleBackColor = true;
            this.Button_SetParaMiuMax.Click += new System.EventHandler(this.Button_SetParaMiuMax_Click);
            // 
            // Button_SetParaMiuMin
            // 
            this.Button_SetParaMiuMin.Location = new System.Drawing.Point(548, 79);
            this.Button_SetParaMiuMin.Margin = new System.Windows.Forms.Padding(6);
            this.Button_SetParaMiuMin.Name = "Button_SetParaMiuMin";
            this.Button_SetParaMiuMin.Size = new System.Drawing.Size(150, 48);
            this.Button_SetParaMiuMin.TabIndex = 60;
            this.Button_SetParaMiuMin.Text = "设为最小值";
            this.Button_SetParaMiuMin.UseVisualStyleBackColor = true;
            this.Button_SetParaMiuMin.Click += new System.EventHandler(this.Button_SetParaMiuMin_Click);
            // 
            // ComboBox_PepperNoise
            // 
            this.ComboBox_PepperNoise.FormattingEnabled = true;
            this.ComboBox_PepperNoise.Items.AddRange(new object[] {
            "仅椒噪声",
            "仅盐噪声",
            "椒盐噪声"});
            this.ComboBox_PepperNoise.Location = new System.Drawing.Point(174, 248);
            this.ComboBox_PepperNoise.Margin = new System.Windows.Forms.Padding(6);
            this.ComboBox_PepperNoise.Name = "ComboBox_PepperNoise";
            this.ComboBox_PepperNoise.Size = new System.Drawing.Size(190, 33);
            this.ComboBox_PepperNoise.TabIndex = 59;
            this.ComboBox_PepperNoise.Text = "请选择噪声种类";
            this.ComboBox_PepperNoise.SelectedIndexChanged += new System.EventHandler(this.ComboBox_PepperNoise_SelectedIndexChanged);
            // 
            // CheckBoxAlgo4PepperNoise
            // 
            this.CheckBoxAlgo4PepperNoise.AutoSize = true;
            this.CheckBoxAlgo4PepperNoise.Location = new System.Drawing.Point(34, 254);
            this.CheckBoxAlgo4PepperNoise.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBoxAlgo4PepperNoise.Name = "CheckBoxAlgo4PepperNoise";
            this.CheckBoxAlgo4PepperNoise.Size = new System.Drawing.Size(128, 29);
            this.CheckBoxAlgo4PepperNoise.TabIndex = 57;
            this.CheckBoxAlgo4PepperNoise.Text = "椒盐噪声";
            this.CheckBoxAlgo4PepperNoise.UseVisualStyleBackColor = true;
            this.CheckBoxAlgo4PepperNoise.CheckedChanged += new System.EventHandler(this.CheckBoxAlgo4PepperNoise_CheckedChanged);
            // 
            // Label_PepperNoise
            // 
            this.Label_PepperNoise.AutoSize = true;
            this.Label_PepperNoise.Location = new System.Drawing.Point(30, 308);
            this.Label_PepperNoise.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_PepperNoise.Name = "Label_PepperNoise";
            this.Label_PepperNoise.Size = new System.Drawing.Size(96, 25);
            this.Label_PepperNoise.TabIndex = 58;
            this.Label_PepperNoise.Text = "噪声比例";
            // 
            // Value_ParaSigma2_PreView
            // 
            this.Value_ParaSigma2_PreView.Location = new System.Drawing.Point(392, 437);
            this.Value_ParaSigma2_PreView.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaSigma2_PreView.Name = "Value_ParaSigma2_PreView";
            this.Value_ParaSigma2_PreView.Size = new System.Drawing.Size(112, 31);
            this.Value_ParaSigma2_PreView.TabIndex = 48;
            this.Value_ParaSigma2_PreView.ValueChanged += new System.EventHandler(this.Value_ParaSigma2_PreView_ValueChanged);
            // 
            // CheckBoxAlgo1Gauss
            // 
            this.CheckBoxAlgo1Gauss.AutoSize = true;
            this.CheckBoxAlgo1Gauss.Location = new System.Drawing.Point(34, 33);
            this.CheckBoxAlgo1Gauss.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBoxAlgo1Gauss.Name = "CheckBoxAlgo1Gauss";
            this.CheckBoxAlgo1Gauss.Size = new System.Drawing.Size(128, 29);
            this.CheckBoxAlgo1Gauss.TabIndex = 4;
            this.CheckBoxAlgo1Gauss.Text = "高斯噪声";
            this.CheckBoxAlgo1Gauss.UseVisualStyleBackColor = true;
            this.CheckBoxAlgo1Gauss.CheckedChanged += new System.EventHandler(this.CheckBoxAlgo1Gauss_CheckedChanged);
            // 
            // TrackBar_ParaMiu
            // 
            this.TrackBar_ParaMiu.AutoSize = false;
            this.TrackBar_ParaMiu.Location = new System.Drawing.Point(144, 90);
            this.TrackBar_ParaMiu.Margin = new System.Windows.Forms.Padding(6);
            this.TrackBar_ParaMiu.Maximum = 127;
            this.TrackBar_ParaMiu.Minimum = -127;
            this.TrackBar_ParaMiu.Name = "TrackBar_ParaMiu";
            this.TrackBar_ParaMiu.Size = new System.Drawing.Size(232, 44);
            this.TrackBar_ParaMiu.TabIndex = 18;
            this.TrackBar_ParaMiu.Scroll += new System.EventHandler(this.TrackBar_ParaMiu_Scroll);
            // 
            // TrackBar_ParaSigma
            // 
            this.TrackBar_ParaSigma.AutoSize = false;
            this.TrackBar_ParaSigma.LargeChange = 1;
            this.TrackBar_ParaSigma.Location = new System.Drawing.Point(144, 173);
            this.TrackBar_ParaSigma.Margin = new System.Windows.Forms.Padding(6);
            this.TrackBar_ParaSigma.Maximum = 40;
            this.TrackBar_ParaSigma.Name = "TrackBar_ParaSigma";
            this.TrackBar_ParaSigma.Size = new System.Drawing.Size(232, 44);
            this.TrackBar_ParaSigma.TabIndex = 19;
            this.TrackBar_ParaSigma.Scroll += new System.EventHandler(this.TrackBar_ParaSigma_Scroll);
            // 
            // Label_ParaSigma2
            // 
            this.Label_ParaSigma2.AutoSize = true;
            this.Label_ParaSigma2.Location = new System.Drawing.Point(30, 446);
            this.Label_ParaSigma2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ParaSigma2.Name = "Label_ParaSigma2";
            this.Label_ParaSigma2.Size = new System.Drawing.Size(75, 25);
            this.Label_ParaSigma2.TabIndex = 45;
            this.Label_ParaSigma2.Text = "模糊度";
            // 
            // Label_ParaMiu
            // 
            this.Label_ParaMiu.AutoSize = true;
            this.Label_ParaMiu.Location = new System.Drawing.Point(30, 98);
            this.Label_ParaMiu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ParaMiu.Name = "Label_ParaMiu";
            this.Label_ParaMiu.Size = new System.Drawing.Size(96, 25);
            this.Label_ParaMiu.TabIndex = 20;
            this.Label_ParaMiu.Text = "噪声幅度";
            // 
            // TrackBar_ParaSigma2
            // 
            this.TrackBar_ParaSigma2.AutoSize = false;
            this.TrackBar_ParaSigma2.Location = new System.Drawing.Point(144, 437);
            this.TrackBar_ParaSigma2.Margin = new System.Windows.Forms.Padding(6);
            this.TrackBar_ParaSigma2.Name = "TrackBar_ParaSigma2";
            this.TrackBar_ParaSigma2.Size = new System.Drawing.Size(232, 44);
            this.TrackBar_ParaSigma2.TabIndex = 44;
            this.TrackBar_ParaSigma2.Scroll += new System.EventHandler(this.TrackBar_ParaSigma2_Scroll);
            // 
            // Label_ParaSigma
            // 
            this.Label_ParaSigma.AutoSize = true;
            this.Label_ParaSigma.Location = new System.Drawing.Point(30, 181);
            this.Label_ParaSigma.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ParaSigma.Name = "Label_ParaSigma";
            this.Label_ParaSigma.Size = new System.Drawing.Size(96, 25);
            this.Label_ParaSigma.TabIndex = 21;
            this.Label_ParaSigma.Text = "噪声密度";
            // 
            // CheckBoxAlgo3GaussianBlur
            // 
            this.CheckBoxAlgo3GaussianBlur.AutoSize = true;
            this.CheckBoxAlgo3GaussianBlur.Location = new System.Drawing.Point(34, 390);
            this.CheckBoxAlgo3GaussianBlur.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBoxAlgo3GaussianBlur.Name = "CheckBoxAlgo3GaussianBlur";
            this.CheckBoxAlgo3GaussianBlur.Size = new System.Drawing.Size(128, 29);
            this.CheckBoxAlgo3GaussianBlur.TabIndex = 43;
            this.CheckBoxAlgo3GaussianBlur.Text = "图像模糊";
            this.CheckBoxAlgo3GaussianBlur.UseVisualStyleBackColor = true;
            this.CheckBoxAlgo3GaussianBlur.CheckedChanged += new System.EventHandler(this.CheckBoxAlgo3GaussianBlur_CheckedChanged);
            // 
            // Value_ParaMiu_PreView
            // 
            this.Value_ParaMiu_PreView.Location = new System.Drawing.Point(392, 90);
            this.Value_ParaMiu_PreView.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaMiu_PreView.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.Value_ParaMiu_PreView.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.Value_ParaMiu_PreView.Name = "Value_ParaMiu_PreView";
            this.Value_ParaMiu_PreView.Size = new System.Drawing.Size(112, 31);
            this.Value_ParaMiu_PreView.TabIndex = 28;
            this.Value_ParaMiu_PreView.ValueChanged += new System.EventHandler(this.Value_ParaMiu_PreView_ValueChanged);
            // 
            // Value_ParaSigma_PreView
            // 
            this.Value_ParaSigma_PreView.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Value_ParaSigma_PreView.Location = new System.Drawing.Point(392, 173);
            this.Value_ParaSigma_PreView.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaSigma_PreView.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Value_ParaSigma_PreView.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Value_ParaSigma_PreView.Name = "Value_ParaSigma_PreView";
            this.Value_ParaSigma_PreView.Size = new System.Drawing.Size(112, 31);
            this.Value_ParaSigma_PreView.TabIndex = 30;
            this.Value_ParaSigma_PreView.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Value_ParaSigma_PreView.ValueChanged += new System.EventHandler(this.Value_ParaSigma_PreView_ValueChanged);
            // 
            // tabPage2_MainForm
            // 
            this.tabPage2_MainForm.Controls.Add(this.Label_ParaIntercept);
            this.tabPage2_MainForm.Controls.Add(this.Label_ParaSlope);
            this.tabPage2_MainForm.Controls.Add(this.Button_SetParaInterceptMax);
            this.tabPage2_MainForm.Controls.Add(this.Button_SetParaInterceptMin);
            this.tabPage2_MainForm.Controls.Add(this.Button_SetParaSlopeMax);
            this.tabPage2_MainForm.Controls.Add(this.Button_SetParaSlopeMin);
            this.tabPage2_MainForm.Controls.Add(this.ComboBox_GrayScale);
            this.tabPage2_MainForm.Controls.Add(this.CheckBoxAlgo2GrayScale);
            this.tabPage2_MainForm.Controls.Add(this.Value_ParaSlope_PreView);
            this.tabPage2_MainForm.Controls.Add(this.TrackBar_ParaSlope);
            this.tabPage2_MainForm.Controls.Add(this.TrackBar_ParaIntercept);
            this.tabPage2_MainForm.Controls.Add(this.Value_ParaIntercept_PreView);
            this.tabPage2_MainForm.Location = new System.Drawing.Point(8, 39);
            this.tabPage2_MainForm.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2_MainForm.Name = "tabPage2_MainForm";
            this.tabPage2_MainForm.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2_MainForm.Size = new System.Drawing.Size(1016, 488);
            this.tabPage2_MainForm.TabIndex = 1;
            this.tabPage2_MainForm.Text = "分辨率、对比度";
            this.tabPage2_MainForm.UseVisualStyleBackColor = true;
            // 
            // Label_ParaIntercept
            // 
            this.Label_ParaIntercept.AutoSize = true;
            this.Label_ParaIntercept.Location = new System.Drawing.Point(28, 190);
            this.Label_ParaIntercept.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ParaIntercept.Name = "Label_ParaIntercept";
            this.Label_ParaIntercept.Size = new System.Drawing.Size(96, 25);
            this.Label_ParaIntercept.TabIndex = 49;
            this.Label_ParaIntercept.Text = "灰度平移";
            // 
            // Label_ParaSlope
            // 
            this.Label_ParaSlope.AutoSize = true;
            this.Label_ParaSlope.Location = new System.Drawing.Point(28, 110);
            this.Label_ParaSlope.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_ParaSlope.Name = "Label_ParaSlope";
            this.Label_ParaSlope.Size = new System.Drawing.Size(96, 25);
            this.Label_ParaSlope.TabIndex = 48;
            this.Label_ParaSlope.Text = "变化倍数";
            // 
            // Button_SetParaInterceptMax
            // 
            this.Button_SetParaInterceptMax.Location = new System.Drawing.Point(798, 179);
            this.Button_SetParaInterceptMax.Margin = new System.Windows.Forms.Padding(6);
            this.Button_SetParaInterceptMax.Name = "Button_SetParaInterceptMax";
            this.Button_SetParaInterceptMax.Size = new System.Drawing.Size(150, 48);
            this.Button_SetParaInterceptMax.TabIndex = 47;
            this.Button_SetParaInterceptMax.Text = "设为最大值";
            this.Button_SetParaInterceptMax.UseVisualStyleBackColor = true;
            this.Button_SetParaInterceptMax.Click += new System.EventHandler(this.Button_SetParaInterceptMax_Click);
            // 
            // Button_SetParaInterceptMin
            // 
            this.Button_SetParaInterceptMin.Location = new System.Drawing.Point(614, 179);
            this.Button_SetParaInterceptMin.Margin = new System.Windows.Forms.Padding(6);
            this.Button_SetParaInterceptMin.Name = "Button_SetParaInterceptMin";
            this.Button_SetParaInterceptMin.Size = new System.Drawing.Size(150, 48);
            this.Button_SetParaInterceptMin.TabIndex = 46;
            this.Button_SetParaInterceptMin.Text = "设为最小值";
            this.Button_SetParaInterceptMin.UseVisualStyleBackColor = true;
            this.Button_SetParaInterceptMin.Click += new System.EventHandler(this.Button_SetParaInterceptMin_Click);
            // 
            // Button_SetParaSlopeMax
            // 
            this.Button_SetParaSlopeMax.Location = new System.Drawing.Point(798, 98);
            this.Button_SetParaSlopeMax.Margin = new System.Windows.Forms.Padding(6);
            this.Button_SetParaSlopeMax.Name = "Button_SetParaSlopeMax";
            this.Button_SetParaSlopeMax.Size = new System.Drawing.Size(150, 48);
            this.Button_SetParaSlopeMax.TabIndex = 45;
            this.Button_SetParaSlopeMax.Text = "设为最大值";
            this.Button_SetParaSlopeMax.UseVisualStyleBackColor = true;
            this.Button_SetParaSlopeMax.Click += new System.EventHandler(this.Button_SetParaSlopeMax_Click);
            // 
            // Button_SetParaSlopeMin
            // 
            this.Button_SetParaSlopeMin.Location = new System.Drawing.Point(614, 98);
            this.Button_SetParaSlopeMin.Margin = new System.Windows.Forms.Padding(6);
            this.Button_SetParaSlopeMin.Name = "Button_SetParaSlopeMin";
            this.Button_SetParaSlopeMin.Size = new System.Drawing.Size(150, 48);
            this.Button_SetParaSlopeMin.TabIndex = 44;
            this.Button_SetParaSlopeMin.Text = "设为最小值";
            this.Button_SetParaSlopeMin.UseVisualStyleBackColor = true;
            this.Button_SetParaSlopeMin.Click += new System.EventHandler(this.Button_SetParaSlopeMin_Click);
            // 
            // ComboBox_GrayScale
            // 
            this.ComboBox_GrayScale.FormattingEnabled = true;
            this.ComboBox_GrayScale.Items.AddRange(new object[] {
            "增大对比度",
            "减小对比度",
            "倒置"});
            this.ComboBox_GrayScale.Location = new System.Drawing.Point(210, 21);
            this.ComboBox_GrayScale.Margin = new System.Windows.Forms.Padding(6);
            this.ComboBox_GrayScale.Name = "ComboBox_GrayScale";
            this.ComboBox_GrayScale.Size = new System.Drawing.Size(238, 33);
            this.ComboBox_GrayScale.TabIndex = 43;
            this.ComboBox_GrayScale.Text = "请选择变化形式";
            this.ComboBox_GrayScale.SelectedIndexChanged += new System.EventHandler(this.ComboBox_GrayScale_SelectedIndexChanged);
            // 
            // CheckBoxAlgo2GrayScale
            // 
            this.CheckBoxAlgo2GrayScale.AutoSize = true;
            this.CheckBoxAlgo2GrayScale.Location = new System.Drawing.Point(32, 25);
            this.CheckBoxAlgo2GrayScale.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBoxAlgo2GrayScale.Name = "CheckBoxAlgo2GrayScale";
            this.CheckBoxAlgo2GrayScale.Size = new System.Drawing.Size(128, 29);
            this.CheckBoxAlgo2GrayScale.TabIndex = 5;
            this.CheckBoxAlgo2GrayScale.Text = "灰度变化";
            this.CheckBoxAlgo2GrayScale.UseVisualStyleBackColor = true;
            this.CheckBoxAlgo2GrayScale.CheckedChanged += new System.EventHandler(this.CheckBoxAlgo2GrayScale_CheckedChanged);
            // 
            // Value_ParaSlope_PreView
            // 
            this.Value_ParaSlope_PreView.DecimalPlaces = 1;
            this.Value_ParaSlope_PreView.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Value_ParaSlope_PreView.Location = new System.Drawing.Point(452, 106);
            this.Value_ParaSlope_PreView.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaSlope_PreView.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Value_ParaSlope_PreView.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Value_ParaSlope_PreView.Name = "Value_ParaSlope_PreView";
            this.Value_ParaSlope_PreView.Size = new System.Drawing.Size(112, 31);
            this.Value_ParaSlope_PreView.TabIndex = 38;
            this.Value_ParaSlope_PreView.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Value_ParaSlope_PreView.ValueChanged += new System.EventHandler(this.Value_ParaSlope_PreView_ValueChanged);
            // 
            // TrackBar_ParaSlope
            // 
            this.TrackBar_ParaSlope.AutoSize = false;
            this.TrackBar_ParaSlope.Location = new System.Drawing.Point(204, 100);
            this.TrackBar_ParaSlope.Margin = new System.Windows.Forms.Padding(6);
            this.TrackBar_ParaSlope.Maximum = 100;
            this.TrackBar_ParaSlope.Name = "TrackBar_ParaSlope";
            this.TrackBar_ParaSlope.Size = new System.Drawing.Size(232, 44);
            this.TrackBar_ParaSlope.TabIndex = 32;
            this.TrackBar_ParaSlope.Scroll += new System.EventHandler(this.TrackBar_ParaSlope_Scroll);
            // 
            // TrackBar_ParaIntercept
            // 
            this.TrackBar_ParaIntercept.AutoSize = false;
            this.TrackBar_ParaIntercept.Location = new System.Drawing.Point(204, 185);
            this.TrackBar_ParaIntercept.Margin = new System.Windows.Forms.Padding(6);
            this.TrackBar_ParaIntercept.Maximum = 255;
            this.TrackBar_ParaIntercept.Minimum = -255;
            this.TrackBar_ParaIntercept.Name = "TrackBar_ParaIntercept";
            this.TrackBar_ParaIntercept.Size = new System.Drawing.Size(232, 44);
            this.TrackBar_ParaIntercept.TabIndex = 33;
            this.TrackBar_ParaIntercept.Scroll += new System.EventHandler(this.TrackBar_ParaIntercept_Scroll);
            // 
            // Value_ParaIntercept_PreView
            // 
            this.Value_ParaIntercept_PreView.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Value_ParaIntercept_PreView.Location = new System.Drawing.Point(452, 185);
            this.Value_ParaIntercept_PreView.Margin = new System.Windows.Forms.Padding(6);
            this.Value_ParaIntercept_PreView.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Value_ParaIntercept_PreView.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.Value_ParaIntercept_PreView.Name = "Value_ParaIntercept_PreView";
            this.Value_ParaIntercept_PreView.Size = new System.Drawing.Size(112, 31);
            this.Value_ParaIntercept_PreView.TabIndex = 40;
            this.Value_ParaIntercept_PreView.ValueChanged += new System.EventHandler(this.Value_ParaIntercept_PreView_ValueChanged);
            // 
            // tabPage3_MainForm
            // 
            this.tabPage3_MainForm.Controls.Add(this.CheckBoxOffsetX);
            this.tabPage3_MainForm.Location = new System.Drawing.Point(8, 39);
            this.tabPage3_MainForm.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage3_MainForm.Name = "tabPage3_MainForm";
            this.tabPage3_MainForm.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage3_MainForm.Size = new System.Drawing.Size(1016, 488);
            this.tabPage3_MainForm.TabIndex = 2;
            this.tabPage3_MainForm.Text = "空间移动";
            this.tabPage3_MainForm.UseVisualStyleBackColor = true;
            // 
            // pictureBox_SrcImg
            // 
            this.pictureBox_SrcImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_SrcImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_SrcImg.Location = new System.Drawing.Point(24, 25);
            this.pictureBox_SrcImg.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox_SrcImg.Name = "pictureBox_SrcImg";
            this.pictureBox_SrcImg.Size = new System.Drawing.Size(696, 637);
            this.pictureBox_SrcImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_SrcImg.TabIndex = 52;
            this.pictureBox_SrcImg.TabStop = false;
            // 
            // pictureBox_DstImg
            // 
            this.pictureBox_DstImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_DstImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_DstImg.Location = new System.Drawing.Point(736, 25);
            this.pictureBox_DstImg.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox_DstImg.Name = "pictureBox_DstImg";
            this.pictureBox_DstImg.Size = new System.Drawing.Size(696, 637);
            this.pictureBox_DstImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_DstImg.TabIndex = 55;
            this.pictureBox_DstImg.TabStop = false;
            // 
            // CheckBoxOffsetX
            // 
            this.CheckBoxOffsetX.AutoSize = true;
            this.CheckBoxOffsetX.Location = new System.Drawing.Point(39, 35);
            this.CheckBoxOffsetX.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBoxOffsetX.Name = "CheckBoxOffsetX";
            this.CheckBoxOffsetX.Size = new System.Drawing.Size(128, 29);
            this.CheckBoxOffsetX.TabIndex = 6;
            this.CheckBoxOffsetX.Text = "水平位移";
            this.CheckBoxOffsetX.UseVisualStyleBackColor = true;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 1294);
            this.Controls.Add(this.pictureBox_DstImg);
            this.Controls.Add(this.Button_PreviewForm);
            this.Controls.Add(this.tabControl_MainForm);
            this.Controls.Add(this.pictureBox_SrcImg);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PreviewForm";
            this.Text = "PreviewForm";
            this.tabControl_MainForm.ResumeLayout(false);
            this.tabPage1_MainForm.ResumeLayout(false);
            this.tabPage1_MainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaNoiseCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaNoiseCoeff_PreView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigma2_PreView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaMiu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSigma2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaMiu_PreView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSigma_PreView)).EndInit();
            this.tabPage2_MainForm.ResumeLayout(false);
            this.tabPage2_MainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSlope_PreView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSlope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaIntercept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaIntercept_PreView)).EndInit();
            this.tabPage3_MainForm.ResumeLayout(false);
            this.tabPage3_MainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SrcImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DstImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_PreviewForm;
        private System.Windows.Forms.TabControl tabControl_MainForm;
        private System.Windows.Forms.TabPage tabPage1_MainForm;
        private System.Windows.Forms.NumericUpDown Value_ParaSigma2_PreView;
        private System.Windows.Forms.CheckBox CheckBoxAlgo1Gauss;
        private System.Windows.Forms.TrackBar TrackBar_ParaMiu;
        private System.Windows.Forms.TrackBar TrackBar_ParaSigma;
        private System.Windows.Forms.Label Label_ParaSigma2;
        private System.Windows.Forms.Label Label_ParaMiu;
        private System.Windows.Forms.TrackBar TrackBar_ParaSigma2;
        private System.Windows.Forms.Label Label_ParaSigma;
        private System.Windows.Forms.CheckBox CheckBoxAlgo3GaussianBlur;
        private System.Windows.Forms.NumericUpDown Value_ParaMiu_PreView;
        private System.Windows.Forms.NumericUpDown Value_ParaSigma_PreView;
        private System.Windows.Forms.TabPage tabPage2_MainForm;
        private System.Windows.Forms.CheckBox CheckBoxAlgo2GrayScale;
        private System.Windows.Forms.NumericUpDown Value_ParaSlope_PreView;
        private System.Windows.Forms.TrackBar TrackBar_ParaSlope;
        private System.Windows.Forms.TrackBar TrackBar_ParaIntercept;
        private System.Windows.Forms.NumericUpDown Value_ParaIntercept_PreView;
        private System.Windows.Forms.TabPage tabPage3_MainForm;
        private System.Windows.Forms.PictureBox pictureBox_SrcImg;
        private System.Windows.Forms.ComboBox ComboBox_GrayScale;
        private System.Windows.Forms.PictureBox pictureBox_DstImg;
        private System.Windows.Forms.Button Button_SetParaInterceptMax;
        private System.Windows.Forms.Button Button_SetParaInterceptMin;
        private System.Windows.Forms.Button Button_SetParaSlopeMax;
        private System.Windows.Forms.Button Button_SetParaSlopeMin;
        private System.Windows.Forms.Label Label_ParaSlope;
        private System.Windows.Forms.Label Label_ParaIntercept;
        private System.Windows.Forms.ComboBox ComboBox_PepperNoise;
        private System.Windows.Forms.CheckBox CheckBoxAlgo4PepperNoise;
        private System.Windows.Forms.Label Label_PepperNoise;
        private System.Windows.Forms.Button Button_SetParaSigma2Max;
        private System.Windows.Forms.Button Button_SetParaSigma2Min;
        private System.Windows.Forms.Button Button_SetParaSigmaMax;
        private System.Windows.Forms.Button Button_SetParaSigmaMin;
        private System.Windows.Forms.Button Button_SetParaMiuMax;
        private System.Windows.Forms.Button Button_SetParaMiuMin;
        private System.Windows.Forms.Button Button_SetParaNoiseCoeffMax;
        private System.Windows.Forms.Button Button_SetParaNoiseCoeffMin;
        private System.Windows.Forms.TrackBar TrackBar_ParaNoiseCoeff;
        private System.Windows.Forms.NumericUpDown Value_ParaNoiseCoeff_PreView;
        private System.Windows.Forms.CheckBox CheckBoxOffsetX;
    }
}