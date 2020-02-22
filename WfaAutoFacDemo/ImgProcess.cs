using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;


namespace WfaAutoFacDemo
{
    class ImgProcess
    {
        public Mat GaussianNoise(Mat Mat, double miu, double sigma)
        {
            Mat dstImage = Mat.Clone();
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
                    byte color = (byte)Math.Abs(dstImage.Get<byte>(i, j) + addval);

                    if (color < 0)
                        color = 0;
                    if (color > 255)
                        color = 255;
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
            Random rnd = new Random();
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
    }


}
