using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace WfaAutoFacDemo
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
    }

}
