using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            double F = 0;
            double x = Convert.ToDouble(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text), q = 0;
            double[] rez = new double[y];
            double h = Math.Abs(y - x)/1000;
            string[] a = new string[4];
            while (x < y)
            {
                try
                {
                    int cnt = 0;
                    //a.Append(F1(x));
                    //a.Append(F2(x));
                    //a.Append(F3(x));
                    a.Append(F4(x));
                    while (cnt < a.Length)
                    {
                        bool result = int.TryParse(a[cnt], out var number);
                        if (result == true)
                        {
                            F += Convert.ToDouble(a[cnt]);
                            if(cnt == 3)
                            {
                                rez.Append(F);
                                label4.Text += $"При x = {x} F = {Math.Round(rez[q], 3)}\n";
                                q++;
                            }
                            cnt++;
                        }
                        else
                        {
                            MessageBox.Show($"Исключение при x = {x}");
                            cnt += a.Length;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show($"Исключение при x = {x}");
                }
                x += h;
            }
        }
        static string F1(double x)
        {
            return Convert.ToString(Math.Exp(1 / x - Math.PI));
        }
        static string F2(double x)
        {
            return Convert.ToString(Math.Pow(2, Math.Abs(x) * Math.Acos(x)));
        }
        static string F3(double x)
        {
            return Convert.ToString(Math.Log(Math.Cosh(-1 / (x - 1))));
        }
        static string F4(double x)
        {
            int j = 1;
            double f = 0;
            while (j < 1000000)
            {
                f += 1 / (x + Math.Sqrt(j));
                j++;
            }
            return Convert.ToString(f);
        }
    }
}
