using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaAutoFacDemo
{
    public class ParaProcess
    {
        public double[] GetRandomList(double paraMin,double paraMax,int count)
        {
            const double ep = double.Epsilon;
            double paraRange = paraMax - paraMin;
            double[] randomList = new double[count];
            Random rnd = new Random(GetRandomSeed());//新建一个Random类，名为rnd
            for (int i = 0; i < count; i++)
            {
                double u1;//构造均布随机变量
                do
                {
                    u1 = rnd.NextDouble();//0~1之间的随机数
                } while (u1 <= ep);

                randomList[i] = u1 * paraRange + paraMin;
            }
            return randomList;
        }

        public static int GetRandomSeed() //产生随机种子
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
    }
}
