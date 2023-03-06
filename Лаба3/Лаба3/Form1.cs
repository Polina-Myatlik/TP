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
            label5.Text = "Статус: В процессе";
            richTextBox1.Text = "";
            double x = Convert.ToDouble(textBox1.Text), y = Convert.ToDouble(textBox2.Text); // х - левая граница у - правая граница
            int q = 0;
            double[] rez = new double[1000]; // для F
            double[] rezx = new double[1000]; // для х
            double[] a = new double[4];
            double h = Math.Abs(y - x) / 1000; //шаг
            label6.Text = $"Шаг: {h}";
            while (x < y)
            {
                try
                {
                    double F = 0;
                    int cnt = 0;
                    a[0] = F1(x);
                    a[1] = F2(x);
                    a[2] = F3(x);
                    a[3] = F4(x);
                    while (cnt < a.Length)
                    {
                        if (double.TryParse(Convert.ToString(a[cnt]), out double n) && Double.IsInfinity(a[cnt]) == false && Double.IsNaN(a[cnt]) == false)
                        {
                            F += a[cnt];
                            cnt++;
                            if (cnt == a.Length)
                            {
                                rez[q] = F;
                                rezx[q] = x;
                                q++;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Исключение при x = {Math.Round(x, 4)}");
                            cnt += a.Length;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show($"Исключение при x = {Math.Round(x, 4)}");
                }
                x += h;
            }
            for (int i = 0; i < q; i++)
            {
                richTextBox1.Text += $"При x = {Math.Round(rezx[i], 4)} F = {Math.Round(rez[i], 3)}\n";
            }
            label5.Text = "Статус: Готово";
        }
        double F1(double x)
        {
            return Math.Exp(1 / x - Math.PI);
        }
        double F2(double x)
        {
            return Math.Pow(2, Math.Abs(x) * Math.Acos(x));
        }
        double F3(double x)
        {
            return Math.Log(Math.Cosh(-1 / (x - 1)));
        }
        double F4(double x)
        {
            int j = 1;
            double f = 0;
            while (j < 1000000)
            {
                f += 1 / (x + Math.Sqrt(j));
                j++;
            }
            return f;
        }
    }
}
