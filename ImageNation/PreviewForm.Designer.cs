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
            this.CheckBoxAlgo2GrayScale = new System.Windows.Forms.CheckBox();
            this.Value_ParaSlope = new System.Windows.Forms.NumericUpDown();
            this.TrackBar_ParaSlope = new System.Windows.Forms.TrackBar();
            this.TrackBar_ParaIntercept = new System.Windows.Forms.TrackBar();
            this.Value_ParaIntercept = new System.Windows.Forms.NumericUpDown();
            this.tabPage3_MainForm = new System.Windows.Forms.TabPage();
            this.pictureBox_SrcImg = new System.Windows.Forms.PictureBox();
            this.ComboBox_GrayScale = new System.Windows.Forms.ComboBox();
            this.pictureBox_DstImg = new System.Windows.Forms.PictureBox();
            this.button_SetParaSlopeMin = new System.Windows.Forms.Button();
            this.button_SetParaSlopeMax = new System.Windows.Forms.Button();
            this.button_SetParaInterceptMax = new System.Windows.Forms.Button();
            this.button_SetParaInterceptMin = new System.Windows.Forms.Button();
            this.Label_ParaSlope = new System.Windows.Forms.Label();
            this.Label_ParaIntercept = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSlope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSlope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaIntercept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaIntercept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SrcImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DstImg)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_PreviewForm
            // 
            this.Button_PreviewForm.Location = new System.Drawing.Point(571, 539);
            this.Button_PreviewForm.Name = "Button_PreviewForm";
            this.Button_PreviewForm.Size = new System.Drawing.Size(127, 52);
            this.Button_PreviewForm.TabIndex = 54;
            this.Button_PreviewForm.Text = "一键退化";
            this.Button_PreviewForm.UseVisualStyleBackColor = true;
            // 
            // tabControl_MainForm
            // 
            this.tabControl_MainForm.Controls.Add(this.tabPage1_MainForm);
            this.tabControl_MainForm.Controls.Add(this.tabPage2_MainForm);
            this.tabControl_MainForm.Controls.Add(this.tabPage3_MainForm);
            this.tabControl_MainForm.Location = new System.Drawing.Point(12, 338);
            this.tabControl_MainForm.Name = "tabControl_MainForm";
            this.tabControl_MainForm.SelectedIndex = 0;
            this.tabControl_MainForm.Size = new System.Drawing.Size(516, 257);
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
            this.tabPage1_MainForm.Size = new System.Drawing.Size(508, 231);
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
            this.tabPage2_MainForm.Controls.Add(this.Label_ParaIntercept);
            this.tabPage2_MainForm.Controls.Add(this.Label_ParaSlope);
            this.tabPage2_MainForm.Controls.Add(this.button_SetParaInterceptMax);
            this.tabPage2_MainForm.Controls.Add(this.button_SetParaInterceptMin);
            this.tabPage2_MainForm.Controls.Add(this.button_SetParaSlopeMax);
            this.tabPage2_MainForm.Controls.Add(this.button_SetParaSlopeMin);
            this.tabPage2_MainForm.Controls.Add(this.ComboBox_GrayScale);
            this.tabPage2_MainForm.Controls.Add(this.CheckBoxAlgo2GrayScale);
            this.tabPage2_MainForm.Controls.Add(this.Value_ParaSlope);
            this.tabPage2_MainForm.Controls.Add(this.TrackBar_ParaSlope);
            this.tabPage2_MainForm.Controls.Add(this.TrackBar_ParaIntercept);
            this.tabPage2_MainForm.Controls.Add(this.Value_ParaIntercept);
            this.tabPage2_MainForm.Location = new System.Drawing.Point(4, 22);
            this.tabPage2_MainForm.Name = "tabPage2_MainForm";
            this.tabPage2_MainForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2_MainForm.Size = new System.Drawing.Size(508, 231);
            this.tabPage2_MainForm.TabIndex = 1;
            this.tabPage2_MainForm.Text = "分辨率、对比度";
            this.tabPage2_MainForm.UseVisualStyleBackColor = true;
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
            // Value_ParaSlope
            // 
            this.Value_ParaSlope.Location = new System.Drawing.Point(226, 49);
            this.Value_ParaSlope.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.Value_ParaSlope.Name = "Value_ParaSlope";
            this.Value_ParaSlope.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaSlope.TabIndex = 38;
            this.Value_ParaSlope.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // TrackBar_ParaSlope
            // 
            this.TrackBar_ParaSlope.AutoSize = false;
            this.TrackBar_ParaSlope.Location = new System.Drawing.Point(102, 49);
            this.TrackBar_ParaSlope.Name = "TrackBar_ParaSlope";
            this.TrackBar_ParaSlope.Size = new System.Drawing.Size(116, 21);
            this.TrackBar_ParaSlope.TabIndex = 32;
            // 
            // TrackBar_ParaIntercept
            // 
            this.TrackBar_ParaIntercept.AutoSize = false;
            this.TrackBar_ParaIntercept.Location = new System.Drawing.Point(102, 89);
            this.TrackBar_ParaIntercept.Name = "TrackBar_ParaIntercept";
            this.TrackBar_ParaIntercept.Size = new System.Drawing.Size(116, 21);
            this.TrackBar_ParaIntercept.TabIndex = 33;
            // 
            // Value_ParaIntercept
            // 
            this.Value_ParaIntercept.Location = new System.Drawing.Point(226, 89);
            this.Value_ParaIntercept.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Value_ParaIntercept.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Value_ParaIntercept.Name = "Value_ParaIntercept";
            this.Value_ParaIntercept.Size = new System.Drawing.Size(56, 21);
            this.Value_ParaIntercept.TabIndex = 40;
            this.Value_ParaIntercept.Value = new decimal(new int[] {
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
            this.tabPage3_MainForm.Size = new System.Drawing.Size(508, 231);
            this.tabPage3_MainForm.TabIndex = 2;
            this.tabPage3_MainForm.Text = "空间移动";
            this.tabPage3_MainForm.UseVisualStyleBackColor = true;
            // 
            // pictureBox_SrcImg
            // 
            this.pictureBox_SrcImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_SrcImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_SrcImg.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_SrcImg.Name = "pictureBox_SrcImg";
            this.pictureBox_SrcImg.Size = new System.Drawing.Size(350, 308);
            this.pictureBox_SrcImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_SrcImg.TabIndex = 52;
            this.pictureBox_SrcImg.TabStop = false;
            // 
            // ComboBox_GrayScale
            // 
            this.ComboBox_GrayScale.FormattingEnabled = true;
            this.ComboBox_GrayScale.Items.AddRange(new object[] {
            "增大对比度",
            "减小对比度"});
            this.ComboBox_GrayScale.Location = new System.Drawing.Point(105, 10);
            this.ComboBox_GrayScale.Name = "ComboBox_GrayScale";
            this.ComboBox_GrayScale.Size = new System.Drawing.Size(121, 20);
            this.ComboBox_GrayScale.TabIndex = 43;
            this.ComboBox_GrayScale.Text = "请选择变化形式";
            this.ComboBox_GrayScale.Visible = false;
            // 
            // pictureBox_DstImg
            // 
            this.pictureBox_DstImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_DstImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_DstImg.Location = new System.Drawing.Point(368, 12);
            this.pictureBox_DstImg.Name = "pictureBox_DstImg";
            this.pictureBox_DstImg.Size = new System.Drawing.Size(350, 308);
            this.pictureBox_DstImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_DstImg.TabIndex = 55;
            this.pictureBox_DstImg.TabStop = false;
            // 
            // button_SetParaSlopeMin
            // 
            this.button_SetParaSlopeMin.Location = new System.Drawing.Point(307, 48);
            this.button_SetParaSlopeMin.Name = "button_SetParaSlopeMin";
            this.button_SetParaSlopeMin.Size = new System.Drawing.Size(75, 23);
            this.button_SetParaSlopeMin.TabIndex = 44;
            this.button_SetParaSlopeMin.Text = "设为最小值";
            this.button_SetParaSlopeMin.UseVisualStyleBackColor = true;
            // 
            // button_SetParaSlopeMax
            // 
            this.button_SetParaSlopeMax.Location = new System.Drawing.Point(399, 48);
            this.button_SetParaSlopeMax.Name = "button_SetParaSlopeMax";
            this.button_SetParaSlopeMax.Size = new System.Drawing.Size(75, 23);
            this.button_SetParaSlopeMax.TabIndex = 45;
            this.button_SetParaSlopeMax.Text = "设为最大值";
            this.button_SetParaSlopeMax.UseVisualStyleBackColor = true;
            // 
            // button_SetParaInterceptMax
            // 
            this.button_SetParaInterceptMax.Location = new System.Drawing.Point(399, 86);
            this.button_SetParaInterceptMax.Name = "button_SetParaInterceptMax";
            this.button_SetParaInterceptMax.Size = new System.Drawing.Size(75, 23);
            this.button_SetParaInterceptMax.TabIndex = 47;
            this.button_SetParaInterceptMax.Text = "设为最大值";
            this.button_SetParaInterceptMax.UseVisualStyleBackColor = true;
            // 
            // button_SetParaInterceptMin
            // 
            this.button_SetParaInterceptMin.Location = new System.Drawing.Point(307, 86);
            this.button_SetParaInterceptMin.Name = "button_SetParaInterceptMin";
            this.button_SetParaInterceptMin.Size = new System.Drawing.Size(75, 23);
            this.button_SetParaInterceptMin.TabIndex = 46;
            this.button_SetParaInterceptMin.Text = "设为最小值";
            this.button_SetParaInterceptMin.UseVisualStyleBackColor = true;
            // 
            // Label_ParaSlope
            // 
            this.Label_ParaSlope.AutoSize = true;
            this.Label_ParaSlope.Location = new System.Drawing.Point(14, 53);
            this.Label_ParaSlope.Name = "Label_ParaSlope";
            this.Label_ParaSlope.Size = new System.Drawing.Size(77, 12);
            this.Label_ParaSlope.TabIndex = 48;
            this.Label_ParaSlope.Text = "对比变化比例";
            // 
            // Label_ParaIntercept
            // 
            this.Label_ParaIntercept.AutoSize = true;
            this.Label_ParaIntercept.Location = new System.Drawing.Point(25, 91);
            this.Label_ParaIntercept.Name = "Label_ParaIntercept";
            this.Label_ParaIntercept.Size = new System.Drawing.Size(53, 12);
            this.Label_ParaIntercept.TabIndex = 49;
            this.Label_ParaIntercept.Text = "灰度平移";
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 599);
            this.Controls.Add(this.pictureBox_DstImg);
            this.Controls.Add(this.Button_PreviewForm);
            this.Controls.Add(this.tabControl_MainForm);
            this.Controls.Add(this.pictureBox_SrcImg);
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
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaSlope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaSlope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_ParaIntercept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value_ParaIntercept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SrcImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DstImg)).EndInit();
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
        private System.Windows.Forms.CheckBox CheckBoxAlgo2GrayScale;
        private System.Windows.Forms.NumericUpDown Value_ParaSlope;
        private System.Windows.Forms.TrackBar TrackBar_ParaSlope;
        private System.Windows.Forms.TrackBar TrackBar_ParaIntercept;
        private System.Windows.Forms.NumericUpDown Value_ParaIntercept;
        private System.Windows.Forms.TabPage tabPage3_MainForm;
        private System.Windows.Forms.PictureBox pictureBox_SrcImg;
        private System.Windows.Forms.ComboBox ComboBox_GrayScale;
        private System.Windows.Forms.PictureBox pictureBox_DstImg;
        private System.Windows.Forms.Button button_SetParaInterceptMax;
        private System.Windows.Forms.Button button_SetParaInterceptMin;
        private System.Windows.Forms.Button button_SetParaSlopeMax;
        private System.Windows.Forms.Button button_SetParaSlopeMin;
        private System.Windows.Forms.Label Label_ParaSlope;
        private System.Windows.Forms.Label Label_ParaIntercept;
    }
}