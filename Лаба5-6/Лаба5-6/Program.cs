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
                                //Console.WriteLine(res[w]);
                                File.AppendAllText($"C:\\Users\\polin\\OneDrive\\Рабочий стол\\G{i}.txt", $"\t{res[w]}");
                                w++;
                            }
                            else
                            {
                                File.AppendAllText($"C:\\Users\\polin\\OneDrive\\Рабочий стол\\G{i}.txt", $"\tNaN");
                            }
                        }
                    }
                    q++;
                }
                using (FileStream a = new FileStream("C:\\Users\\polin\\OneDrive\\Рабочий стол\\myProgram.log", FileMode.Create))
                {
                    string text = $"Лаба5-6 Вариант 27\n{DateTime.Now}\nG(x,y) = ch(x)/exp(y)\n";
                    for (int i = 1; i < Convert.ToInt32(ish[0]) + 1; i++)
                    {
                        text += $"G{i}.rez\n";
                    }
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);

                    a.Write(array, 0, array.Length);
                }
                Console.WriteLine();
                //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
                //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
                Console.WriteLine("Лаба 6");
                Console.WriteLine();
                using (FileStream a = new FileStream("C:\\Users\\polin\\OneDrive\\Рабочий стол\\Calc.ini", FileMode.Create))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(ish1);

                    a.Write(array, 0, array.Length);
                }
                for(int i = 1; i< Convert.ToInt32(ish[0]) + 1; i++)
                {
                    try
                    {
                        using (FileStream a = File.OpenRead($"C:\\Users\\polin\\OneDrive\\Рабочий стол\\G{i}.txt"))
                        {
                            Console.WriteLine($"Файл G{i}.rez");
                            Console.WriteLine($"Введите координаты краёв матрицы");
                            int p = 0;
                            while(p == 0) //чтобы при неверном вводе он повторял ввод с клавиатуры
                            {
                                Console.WriteLine("Левый:");
                                int xn0 = Convert.ToInt32(Console.ReadLine());
                                int yn0 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Правый:");
                                int xn = Convert.ToInt32(Console.ReadLine());
                                int yn = Convert.ToInt32(Console.ReadLine());
                                if(xn >= xn0 && yn >= yn0)
                                {
                                    p++;
                                    int[] x = new int[2]; //координаты по оси х
                                    x[0] = xn0;
                                    x[1] = xn;
                                    int[] y = new int[2]; //координаты по оси у
                                    y[0] = yn0;
                                    y[1] = yn;
                                    byte[] array = new byte[a.Length];
                                    a.Read(array, 0, array.Length);

                                    string textFrom = System.Text.Encoding.Default.GetString(array); //считать весь файл в строку

                                    string[][] mod = new string[textFrom.Length][];
                                    string[] mod2 = textFrom.Split(new Char[] { '\n' }); //разделить построчно
                                    string[] mod1 = new string[mod2.Length];
                                    Console.WriteLine();
                                    int c = 0;
                                    for (int m = 3; m < mod1.Length; m++) //убрать ненужные первые 3 строки
                                    {
                                        mod[c] = mod2[m].Split(new Char[] { '\t' }); //разделить через табуляцию, получить массив из двух массивов
                                        c++;
                                    }

                                    for (int x1 = x[0]; x1 < x[1]+1; x1++)
                                    {
                                        for (int y1 = y[0]+1; y1 < y[1]+2; y1++)
                                        {
                                            Console.Write($"{mod[x1][y1]}\t");; //вывести массив из двух массивов по координатам (х,у)
                                        }
                                        Console.WriteLine();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Неверные значения. Повторите ввод");
                                }
                            }
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    Console.WriteLine();
                }
                //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
                //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
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
                    string text = $"G{i}.rez\nG(x,y) = ch(x)/exp(y)\nx = {x} y = {y}\nИсключение: {ex.Message}";

                    byte[] array = System.Text.Encoding.Default.GetBytes(text);

                    b.Write(array, 0, array.Length);
                }
                return $"Ошибка при {x}, {y}";
            }
        }
    }
}
//2,1,2,3,4,5,6,1,2,3,4,5,6
//3,1,2,3,4,5,6,1,2,3,4,5,6,1,2,3,4,5,6