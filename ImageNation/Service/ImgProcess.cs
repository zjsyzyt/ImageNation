using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace ImageNation
{
    public class ImgProcess
    {
        private Mat ImgPreProcess(Mat Mat)
        {

            Mat dstImage=Mat.Clone();//先要初始化；
            int channels = dstImage.Channels();
            switch (channels)
            {
                case 1:
                    dstImage = Mat.Clone();
                    break;
                case 3:
                    dstImage = Mat.CvtColor(ColorConversionCodes.BGR2GRAY);
                    break;
                default:
                    Console.WriteLine("图像格式有误，请重新导入");
                    break;
            }
            return dstImage;

            //if (channels==1)
            //{
            //    dstImage = Mat;
            //    return dstImage;
            //}
            //else if(channels==3)
            //{
            //    dstImage = Mat.CvtColor(ColorConversionCodes.BGR2GRAY);
            //    return dstImage;
            //}
        }

        //高斯噪声
        public Mat GaussianNoise(Mat Mat, double miu, double sigma)
        {
            Mat dstImage = ImgPreProcess(Mat);
            //Mat dstImage0 = Mat.Clone();
            //Mat dstImage;
            //Mat src = new Mat(imagePath, ImreadModes.Grayscale);
            //dstImage.ImDecode(byte[] imageBytes, ImreadModes.Grayscale);//ImreadModes.Grayscale
            //dstImage0.ConvertTo(dstImage, 0);//CV_8U
            int channels = dstImage.Channels();
            int rowsNumber = dstImage.Rows;
            int colsNumber = dstImage.Cols * channels;
            //判断图像的连续性
            if (dstImage.IsContinuous())
            {
                colsNumber *= rowsNumber;
                rowsNumber = 1;
            }
            for (int i = 0; i < rowsNumber; i++)
            {
                for (int j = 0; j < colsNumber; j++)
                {
                    //添加高斯噪声
                    int addval = (int)(generateGaussianNoise(miu, sigma));
                    int bigcolor = (int)Math.Abs(dstImage.Get<byte>(i, j) + addval);

                    if (bigcolor < 0)
                        bigcolor = 0;
                    if (bigcolor > 255)
                        bigcolor = 255;

                    byte color = (byte)bigcolor;
                    dstImage.Set(i, j, color);
                }
            }
            return dstImage;
        }


        //生成高斯噪声
        private double generateGaussianNoise(double miu, double sigma)
        {
            //定义小值
            const double ep = double.Epsilon;
            double z0;
            double z1 = 0.0;
            bool flag = false;
            flag = !flag;
            //flag为假,构造高斯随机变量X
            if (!flag)
            {
                return z1 * sigma + miu;
            }
            double u1, u2;//根据Box-Muller变换原理构造随机变量
            //ParaProcess Para = new ParaProcess();
            Random rnd = new Random(ParaProcess.GetRandomSeed());
            do
            {
                u1 = rnd.NextDouble();//0~1之间的随机数
                u2 = rnd.NextDouble();
            } while (u1 <= ep);
            //flag为真,构造高斯随机变量
            z0 = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2 * Math.PI * u2);
            z1 = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2 * Math.PI * u2);
            return z0 * sigma + miu;
        }

        //static int GetRandomSeed() //产生随机种子
        //{
        //    byte[] bytes = new byte[4];
        //    System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
        //    rng.GetBytes(bytes);
        //    return BitConverter.ToInt32(bytes, 0);
        //} 

        //椒盐噪声
        public Mat PepperNoise(Mat Mat,double noise_coeff,int noise_type_index)
        {
            Mat dstImage = ImgPreProcess(Mat);

            int w = dstImage.Cols;
            int h = dstImage.Rows;
            int n = (int) (w * h * noise_coeff/100);
            int value = 0;
            int noiseCols = 0;
            int noiseRows = 0;
            Random rnd = new Random();

            for (int k = 0; k<n ; k++)
            {
                noiseCols = rnd.Next(dstImage.Cols);
                noiseRows = rnd.Next(dstImage.Rows);
                if (noise_type_index==0)
                {
                    value = 0;
                }
                else if (noise_type_index == 1)
                {
                    value = 255;
                }
                else
                {
                    value = rnd.Next(0,2)*255;
                }
                dstImage.Set(noiseRows, noiseCols, (byte)value);

            }
            return dstImage;
        }
            


        //灰度线性变化
        public Mat GrayScale(Mat Mat, double k, double b)
        {
            Mat dstImage = ImgPreProcess(Mat);


            int rowsNumber = dstImage.Rows;
            int colsNumber = dstImage.Cols;
            if (dstImage.IsContinuous())
            {
                colsNumber *= rowsNumber;
                rowsNumber = 1;
            }
            for (int i = 0; i < rowsNumber; i++)
            {
                for (int j = 0; j < colsNumber; j++)
                {
                    //灰度线性变化
                    int bigcolor = (int)Math.Abs(k * (dstImage.Get<byte>(i, j)) + b);

                    if (bigcolor < 0)
                        bigcolor = 0;
                    if (bigcolor > 255)
                        bigcolor = 255;

                    byte color = (byte)bigcolor;
                    dstImage.Set(i, j, color);
                    if(j==34786)
                    {
                        byte dstcolor = color;
                    }
                }
            }
            return dstImage;
        }



        //低通滤波
        public Mat LowPassFreq(Mat Mat,double sigma)
        {
            Mat oriImage = ImgPreProcess(Mat);
            int w = Cv2.GetOptimalDFTSize(oriImage.Cols);  //获取进行dtf的最优尺寸
            int h = Cv2.GetOptimalDFTSize(oriImage.Rows); //获取进行dtf的最优尺寸

            Mat paddedImage= new Mat();
            Cv2.CopyMakeBorder(oriImage, paddedImage, 0, h - oriImage.Rows, 0, w - oriImage.Cols, BorderTypes.Constant, Scalar.All(0));//边界填充
            paddedImage.ConvertTo(paddedImage, MatType.CV_64FC1); //将图像转换为double型
            Mat GaussianKernel = GaussianLowPassFreq(paddedImage, sigma);//高斯低通滤波器

            Mat dstImage = new Mat();
            dstImage = FreqFilter(paddedImage, GaussianKernel);//频率域滤波

            //dstImage.ConvertTo(dstImage,MatType.CV_8UC1);
            //out = out *255;
            dstImage = dstImage * 255;
            //return dstImage;


            //除去边框
            Rect roi = new Rect(0, 0, oriImage.Cols, oriImage.Rows);//首先要用个rect确定我们的兴趣区域在哪
            Mat dstImageROI = new Mat(dstImage, roi);//新建一个mat，把roi内的图像加载到里面去。

            return dstImageROI;
        }


        Mat GaussianLowPassFreq(Mat srcImage, double sigma)
        {
            Mat gaussianBlur = new Mat(srcImage.Size(), MatType.CV_64FC1);//64对应double
            double d0 = 2 * sigma * sigma;//高斯函数参数，越小，频率高斯滤波器越窄，滤除高频成分越多，图像就越平滑
            for (int i = 0; i < srcImage.Rows; i++)
            {
                for (int j = 0; j < srcImage.Cols; j++)
                {
                    double d = Math.Pow((i - srcImage.Rows/2), 2) + Math.Pow((j - srcImage.Cols/2), 2);//分子,计算pow必须为double型
                    double weight = Math.Exp(-d / d0);//exp为以e为底求幂（必须为double型）
                    gaussianBlur.Set(i, j, weight);
                }
            }
            return gaussianBlur;
        }


        //*****************频率域滤波*******************
        Mat FreqFilter(Mat srcImage, Mat blur)
        {
            //***********************DFT*******************
            Mat[] plane = {srcImage, Mat.Zeros(srcImage.Size(), MatType.CV_64FC1) }; //创建通道，存储dft后的实部与虚部（CV_64F，必须为单通道数）
            Mat complexIm=new Mat();
            Cv2.Merge(plane, complexIm);//合并通道 （把两个矩阵合并为一个2通道的Mat类容器）
            Cv2.Dft(complexIm, complexIm);//进行傅立叶变换，结果保存在自身  

            //***************中心化********************
            Cv2.Split(complexIm, out plane);//分离通道（数组分离）

            int cx = plane[0].Cols / 2;
            int cy = plane[0].Rows / 2;//以下的操作是移动图像  (零频移到中心)
            Mat part1_r= new Mat(plane[0], new Rect(0, 0, cx, cy));  //元素坐标表示为(cx,cy)
            Mat part2_r = new Mat(plane[0], new Rect(cx, 0, cx, cy));
            Mat part3_r = new Mat(plane[0], new Rect(0, cy, cx, cy));
            Mat part4_r = new Mat(plane[0], new Rect(cx, cy, cx, cy));

            Mat temp = new Mat();
            part1_r.CopyTo(temp);  //左上与右下交换位置(实部)
            part4_r.CopyTo(part1_r);
            temp.CopyTo(part4_r);

            part2_r.CopyTo(temp);  //右上与左下交换位置(实部)
            part3_r.CopyTo(part2_r);
            temp.CopyTo(part3_r);

            Mat part1_i = new Mat(plane[1], new Rect(0, 0, cx, cy));  //元素坐标表示为(cx,cy)
            Mat part2_i = new Mat(plane[1], new Rect(cx, 0, cx, cy));
            Mat part3_i = new Mat(plane[1], new Rect(0, cy, cx, cy));
            Mat part4_i = new Mat(plane[1], new Rect(cx, cy, cx, cy));

            part1_i.CopyTo(temp);  //左上与右下交换位置(虚部)
            part4_i.CopyTo(part1_i);
            temp.CopyTo(part4_i);

            part2_i.CopyTo(temp);  //右上与左下交换位置(虚部)
            part3_i.CopyTo(part2_i);
            temp.CopyTo(part3_i);

            //*****************滤波器函数与DFT结果的乘积****************
            Mat blur_r = new Mat();
            Mat blur_i = new Mat();
            Mat BLUR = new Mat();
            Cv2.Multiply(plane[0], blur, blur_r); //滤波（实部与滤波器模板对应元素相乘）
            Cv2.Multiply(plane[1], blur, blur_i);//滤波（虚部与滤波器模板对应元素相乘）
            Mat[] plane1 = { blur_r, blur_i };
            Cv2.Merge(plane1, BLUR);//实部与虚部合并

            //*********************得到原图频谱图***********************************
            /*
            Cv2.Magnitude(plane[0], plane[1], plane[0]);//获取幅度图像，0通道为实部通道，1为虚部，因为二维傅立叶变换结果是复数  
            plane[0] += Scalar::all(1);  //傅立叶变o换后的图片不好分析，进行对数处理，结果比较好看 
            Cv2.Sca
            log(plane[0], plane[0]);    // float型的灰度空间为[0，1])
            normalize(plane[0], plane[0], 1, 0, NORM_MINMAX);  //归一化便于显示
            imshow("原图像频谱图", plane[0] * 255);
            */

            //******************IDFT*******************************
            /*
            Mat part111(BLUR,Rect(0,0,cx,cy));  //元素坐标(cx,cy)
            Mat part222(BLUR,Rect(cx,0,cx,cy));
            Mat part333(BLUR,Rect(0,cy,cx,cy));
            Mat part444(BLUR,Rect(cx,cy,cx,cy));
             part111.copyTo(temp);  //左上与右下交换位置(虚部)
            part444.copyTo(part111);
            temp.copyTo(part444);

            part222.copyTo(temp);  //右上与左下交换位置
            part333.copyTo(part222);
            temp.copyTo(part333);
            */

            Cv2.Idft(BLUR, BLUR);   //idft结果也为复数
            Cv2.Split(BLUR, out plane);//分离通道，主要获取通道
            Cv2.Magnitude(plane[0], plane[1], plane[0]);  //求幅值(模)
            Cv2.Normalize(plane[0], plane[0], 1, 0, NormTypes.MinMax);  //归一化便于显示
            return plane[0];//返回参数
        }




    }

}
