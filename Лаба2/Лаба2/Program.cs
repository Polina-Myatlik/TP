using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] p = new double[] {0.1, 5, 10 };
            int[] t = new int[5];
            int i = 300;
            t[0] = i;
            int j = 1;
            while (i < 381)
            {
                i += 20;
                if(i < 381)
                {
                    t[j] = i;
                    j++;
                }
            }
            for(i = 0; i<t.Length; i++)
            {
                for (j = 0; j < p.Length; j++)
                {
                    Tepl(t[i], p[j]);
                }
            }
            
        }
        static void Tepl(int t, double p)
        {
            double a0 = 248 - 0.4695 * t + 2.889 * Math.Pow(10, -4) * Math.Pow(t, 2);
            double a1 = -0.669 + 4.879 * Math.Pow(10, -3) * t - 4.86 * Math.Pow(10, -6) * Math.Pow(t, 2);
            double a2 = 2.889 * Math.Pow(10, -3) - 1.852 * Math.Pow(10, -5) * t + 2.263 * Math.Pow(10, -8) * Math.Pow(t, 2);
            double l = a0 + a1*p + a2*Math.Pow(p, 2);
            Console.WriteLine(Math.Round(l, 3));
        }
    }
}
