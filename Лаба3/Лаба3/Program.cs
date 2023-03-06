using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double x = Convert.ToDouble(textBox1.Text), y = Convert.ToInt32(textBox2.Text); // х - левая граница у - правая граница
            //int q = 0;
            //double[] rez = new double[1000];
            //string[] a = new string[4];
            //double h = Math.Abs(y - x) / 1000; //шаг
            //while (x < y)
            //{
            //    try
            //    {
            //        double F = 0;
            //        int cnt = 0;
            //        a[0] = F1(x);
            //        a[1] = F2(x);
            //        a[2] = F3(x);
            //        a[3] = F4(x);
            //        while (cnt < a.Length)
            //        {
            //            if (double.TryParse(a[cnt], out double n) && Double.IsInfinity(Convert.ToDouble(a[cnt])) == false && Double.IsNaN(Convert.ToDouble(a[cnt])) == false)
            //            {
            //                F += Convert.ToDouble(a[cnt]);
            //                cnt++;
            //                if (cnt == a.Length)
            //                {
            //                    rez[q] = F;
            //                    q++;
            //                    label4.Text += $"При x = {Math.Round(x, 4)} F = {Math.Round(F, 3)}\n";
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show($"Исключение при x = {Math.Round(x, 4)}");
            //                cnt += a.Length;
            //            }
            //        }
            //    }
            //    catch
            //    {
            //        MessageBox.Show($"Исключение при x = {Math.Round(x, 4)}");
            //    }
            //    x += h;
            //}
            Form1 form = new Form1();
            form.ShowDialog();
        }
        //static string F1(double x)
        //{
        //    double f = (1 / x);
        //    return Convert.ToString(Math.Exp(f - Math.PI));
        //}
        //static string F2(double x)
        //{
        //    return Convert.ToString(Math.Pow(2, Math.Abs(x) * Math.Acos(x)));
        //}
        //static string F3(double x)
        //{
        //    return Convert.ToString(Math.Log(Math.Cosh(-1 / (x - 1))));
        //}
        //static string F4(double x)
        //{
        //    int j = 1;
        //    double f = 0;
        //    while (j < 1000000)
        //    {
        //        f += 1 / (x + Math.Sqrt(j));
        //        j++;
        //    }
        //    return Convert.ToString(f);
        //}
    }
}