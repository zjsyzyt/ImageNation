using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace ImageNation
{
    class ImgQE
    {
        //PSNR
        public double ValuePSNR(Mat srcMat, Mat dstMat)
        {
            double psnrValue = Cv2.PSNR(dstMat, srcMat);
            return psnrValue;
        }

        //SSIM
        public double ValueSSIM(Mat Mat1, Mat Mat2)
        {
            double ssimValue;
            using (Mat I1 = new Mat(), I2 = new Mat())
            {
                int winSize = 7;
                double k1 = 0.01d;
                double k2 = 0.03d;
                double L = 255d;
                Mat1.ConvertTo(I1, MatType.CV_64F);
                Mat2.ConvertTo(I2, MatType.CV_64F);
                int ndim = I1.Dims;
                double NP = (double)Math.Pow(winSize, ndim);//滑动窗口覆盖的像素点个数
                double cov_norm = NP / (NP - 1);//NP个点上求平均值，无偏估计，需要乘以NP再除以NP-1
                double C1 = (k1 * L) * (k1 * L);
                double C2 = (k2 * L) * (k2 * L);

                Mat ux = new Mat();
                Mat uy = new Mat();
                Mat uxx = I1.Mul(I1);//元素为x^2
                Mat uyy = I2.Mul(I2);//元素为y^2
                Mat uxy = I1.Mul(I2);//元素为xy

                Size window = new Size(winSize, winSize);
                Point anchorPoint = new Point(-1, -1);
                Cv2.Blur(I1, ux, window, anchorPoint);//按窗口对图像均值滤波，计算x的期望
                Cv2.Blur(I2, uy, window, anchorPoint);

                Cv2.Blur(uxx, uxx, window, anchorPoint);//按窗口对uxx均值滤波，计算x^2的期望
                Cv2.Blur(uyy, uyy, window, anchorPoint);
                Cv2.Blur(uxy, uxy, window, anchorPoint);

                Mat ux_sq = ux.Mul(ux);//对均值矩阵进行元素平方，元素ux^2
                Mat uy_sq = uy.Mul(uy);
                Mat uxy_m = ux.Mul(uy);//对均值矩阵进行元素平方，元素ux*uy

                Mat vx = cov_norm * (uxx - ux_sq);//x方差，=E(x^2)-E^2(x)，无偏估计
                Mat vy = cov_norm * (uyy - uy_sq);
                Mat vxy = cov_norm * (uxy - uxy_m);//x,y协方差，=E(xy)-E(x)E(y)

                Mat A1 = 2 * uxy_m;
                Mat A2 = 2 * vxy;
                Mat B1 = ux_sq + uy_sq;
                Mat B2 = vx + vy;

                Mat ssim_map = (A1 + C1).Mul(A2 + C2) / (B1 + C1).Mul(B2 + C2);

                Scalar mssim = Cv2.Mean(ssim_map);
                ssim_map.ConvertTo(ssim_map, MatType.CV_8UC1, 255, 0);

                //imshow("ssim", ssim_map);
                ssimValue = mssim[0];

                //Console.WriteLine(ssimValue.ToString("F10"));
                //Console.ReadKey();
            }

                return ssimValue;
        }

        //dhash
        public double ValueDHash(Mat Mat1, Mat Mat2)
        {
            double dhashValue, dhashSigValue;
            string dhashString1, dhashString2;
            using (Mat I1 = new Mat(), I2 = new Mat())
            {
                Size window = new Size(17, 16);
                Cv2.Resize(Mat1, I1, window, 0, 0, InterpolationFlags.Cubic);
                Cv2.Resize(Mat2, I2, window, 0, 0, InterpolationFlags.Cubic);
                dhashString1 = StringDHash(I1);
                dhashString2 = StringDHash(I2);
                int nValue = CmpHash(dhashString1, dhashString2);
                dhashValue = 1 - ((double)nValue) / 256;
                double SigValue = Sigmoid(dhashValue);
                dhashSigValue = SigValue * dhashValue;
            }
            return dhashSigValue;
        }
        //生成哈希数列
        private string StringDHash(Mat Mat)
        {
            string hash_str = "";
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (Mat.At<byte>(i, j) > Mat.At<byte>(i, j + 1))
                        hash_str = hash_str + '1';
                    else
                        hash_str = hash_str + '0';
                }
            }
            return hash_str;
        }
        //比较图像哈希值
        private int CmpHash(string hash1,string hash2)
        {
            int n = 0;
            if (hash1.Length != hash2.Length)
                return -1;
            for (int i = 0; i < hash1.Length; i++)
            {
                if (hash1[i] != hash2[i])
                    n = n + 1;
            }
            return n;
        }
        //结构调整系数
        private double Sigmoid(double hashValue)
        {
            double SigValue;
            if (hashValue >= 0.993)
                SigValue = hashValue;
            else
                SigValue = Math.Round(1 / (1 + Math.Exp(-10 * (hashValue - 0.5 - 1e-4))), 3);
            return SigValue;
        }

    }
}
