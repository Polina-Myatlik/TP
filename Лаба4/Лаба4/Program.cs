using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace Лаба4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[4];
            string[] b = new string[4];
            a[0] = @"C:\\Users\\polin\\OneDrive\\Рабочий стол\\z.xlsx";
            a[1] = @"C:\Users\polin\OneDrive\Рабочий стол\x.xlsx";
            a[2] = @"https://translate.yandex.ru/";
            a[3] = @"ftp://ftp.cdrom.com/pub/music/songs/1996";


            Console.WriteLine("Задание 1");
            string[] v = new string[] { "http:/", "https:/", "ftp:/", "C:\\" };
            int c = 0;
            for (int j = 0; j < v.Length; j++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i].Contains(v[j]))
                    {
                        c++;
                    }
                }
                Console.WriteLine($"Количество путей вида '{v[j]}' равно {c}");
                c = 0;
            }
            Console.WriteLine();
            Console.WriteLine("Задание 2");
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < v.Length - 1; j++)
                {
                    if (a[i].Contains(v[j]))
                    {
                        while (a[i].Contains("/"))
                        {
                            a[i] = a[i].Replace("/", "\\");
                        }
                        a[i] = a[i].Replace(":", "");
                        b[i] = "C:\\" + a[i];
                        Console.WriteLine(b[i]);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Задание 3");
            try
            {
                for (int i = 0; i < a.Length - 2; i++)
                {
                    //поиск индекса последнего слеша
                    int ind = a[i].LastIndexOf('\\');
                    string q = Path.GetFileNameWithoutExtension(a[i]);
                    //переименование
                    b[i] = a[i].Remove(ind + 1) + q + "_0" + (i + 1) + Path.GetExtension(a[i]);
                    File.Move(a[i], b[i]);
                    Console.WriteLine(b[i]);
                }
                Console.WriteLine("Работа завершена. Проверьте Рабочий стол");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Не удалось переименовать. Файл не найден");
            }
            Console.WriteLine();
            Console.WriteLine("Задание 4");
            c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int ind = a[i].LastIndexOf('\\');
                string q = Path.GetFileNameWithoutExtension(a[i]);
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] == 't')
                    {
                        c++;
                    }
                }
            }
            Console.WriteLine($"Количество символов 't' равно {c}");
        }
    }
}
