using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace Лаба5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лаба 5. Задание 2\n");
            Console.WriteLine("Введите:\nкол-во наборов, начальное значение x, количество точек для х, шаг для х," +
                "\nначальное значение y, конечное значение у, шаг для у:");
            try
            {
                string ish1 = Console.ReadLine();
                string[] ish = ish1.Split(',');
                int q = 0;
                double[] x0 = new double[Convert.ToInt32(ish[0])];
                double[] y0 = new double[Convert.ToInt32(ish[0])];
                double[] yk = new double[Convert.ToInt32(ish[0])];
                double[] hx = new double[Convert.ToInt32(ish[0])];
                double[] hy = new double[Convert.ToInt32(ish[0])];
                int[] nx = new int[Convert.ToInt32(ish[0])];
                for (int i = 1; i < Convert.ToInt32(ish[0]) + 1; i++) // номер набора исходных данных
                {
                    x0[q] = Convert.ToDouble(ish[1 + 6]);
                    y0[q] = Convert.ToDouble(ish[4 + 6]);
                    yk[q] = Convert.ToDouble(ish[5 + 6]);
                    hx[q] = Convert.ToDouble(ish[3 + 6]);
                    hy[q] = Convert.ToDouble(ish[6 + 6]);
                    nx[q] = Convert.ToInt32(ish[2 + 6]);
                    nx[q] = Convert.ToInt32(ish[2 + 6]);
                    double[] x = new double[nx[q]];
                    double[] y = new double[nx[q]];
                    double[] res = new double[nx[q]*2];
                    string[] o = new string[nx[q]];
                    using (FileStream c = new FileStream($"C:\\Users\\polin\\OneDrive\\Рабочий стол\\G{i}.txt", FileMode.Create))
                    {
                        byte[] array = System.Text.Encoding.Default.GetBytes($"G(x,y) = ch(x)/exp(y)\nКол-во точек для x = {nx[q]}, y = {nx[q]}\nx,y");

                        c.Write(array, 0, array.Length);
                    }
                    for (int j = 0; j < nx[q]; j++)
                    {
                        x[j] = x0[q] + hx[q] * j;
                        if ((y0[q] + hy[q] * j) <= yk[q])
                        {
                            y[j] = y0[q] + hy[q] * j;
                        }
                        File.AppendAllText($"C:\\Users\\polin\\OneDrive\\Рабочий стол\\G{i}.txt", $"\ty{j}\t\t");
                    }
                    int w = 0;
                    for (int j = 0; j < nx[q]; j++)
                    {
                        File.AppendAllText($"C:\\Users\\polin\\OneDrive\\Рабочий стол\\G{i}.txt", $"\nx{j}");
                        for (int k = 0; k < nx[q]; k++)
                        {
                            string a = G(x[j], y[k], i);
                            if (a.Contains("Ошибка") == false)
                            {
                                res[w] = Convert.ToDouble(a);
                                Console.WriteLine(res[w]);
                                File.AppendAllText($"C:\\Users\\polin\\OneDrive\\Рабочий стол\\G{i}.txt", $"\t{res[w]}");
                            }
                            else
                            {
                                File.AppendAllText($"C:\\Users\\polin\\OneDrive\\Рабочий стол\\G{i}.txt", $"\tNaN");
                            }
                            w++;
                        }
                    }
                    q++;
                }
                using (FileStream a = new FileStream("C:\\Users\\polin\\OneDrive\\Рабочий стол\\myProgram.log", FileMode.Create))
                {
                    string text = $"Лаба5-6 Вариант 27\n{DateTime.Now}\nG(x,y) = ch(x)/exp(y)\n";
                    for (int i = 1; i < Convert.ToInt32(ish[0]) + 1; i++)
                    {
                        text += $"G{i}.dat\n";
                    }
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);

                    a.Write(array, 0, array.Length);
                }
            }
            catch
            {
                Console.WriteLine("Неверный ввод набора исходных данных!");
            }
            try
            {
                using (FileStream a = File.OpenRead("C:\\Users\\polin\\OneDrive\\Рабочий стол\\myProgram.log"))
                {
                    byte[] array = new byte[a.Length];
                    a.Read(array, 0, array.Length);

                    string textFrom = System.Text.Encoding.Default.GetString(array);
                    string[] z = textFrom.Split('\n');
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ошибка при считывании: {ex.Message}");
            }

            //Console.WriteLine("Лаба 6");
            //string[] a = new string[4];
            //string[] b = new string[4]; //здесь будут результаты расчётов из предыдущего задания
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = "C:\\Users\\polin\\OneDrive\\Рабочий стол\\" + "G" + Convert.ToString(i).PadLeft(4, '0') + ".rez";
            //    File.Create(a[i]);
            //    using (FileStream q = new FileStream(a[i], FileMode.OpenOrCreate)) //запись в файл (задание а)
            //    {
            //        byte[] array = System.Text.Encoding.Default.GetBytes(b[i]);

            //        q.Write(array, 0, array.Length);
            //        q.Close();
            //    }
            //    using (FileStream z = File.OpenRead(a[i])) //считывание из файла (задание в)
            //    {
            //        byte[] array = new byte[z.Length];
            //        z.Read(array, 0, array.Length);

            //        string textFrom = System.Text.Encoding.Default.GetString(array);
            //        System.Console.WriteLine(textFrom);
            //        z.Close();
            //    }
            //    string calc = @"C:\Users\polin\OneDrive\Рабочий стол\Calc.ini";
            //    File.Create(calc);
            //    using (FileStream w = new FileStream(calc, FileMode.OpenOrCreate)) //запись в файл (задание б)
            //    {
            //        byte[] array = System.Text.Encoding.Default.GetBytes(b[i]);

            //        w.Write(array, 0, array.Length);
            //    }
            //}
        }
        public static string G(double x, double y, int i)
        {
            try
            {
                return Convert.ToString(Math.Cosh(x) / Math.Exp(y));
            }
            catch(Exception ex)
            {
                using (FileStream b = new FileStream("C:\\Users\\polin\\OneDrive\\Рабочий стол\\myErrors.log", FileMode.OpenOrCreate))
                {
                    string text = $"G{i}.dat\nG(x,y) = ch(x)/exp(y)\nx = {x} y = {y}\nИсключение: {ex.Message}";

                    byte[] array = System.Text.Encoding.Default.GetBytes(text);

                    b.Write(array, 0, array.Length);
                }
                return $"Ошибка при {x}, {y}";
            }
        }
    }
}