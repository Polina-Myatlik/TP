using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PravilaIgr.Text = "";
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            panel1.Visible = false;
            listBox1.SelectedIndex = 2;
            listBox2.SelectedIndex = 2;
            PravilaIgr.Text = $"ПРАВИЛА ИГРЫ:\n" +
                $"Введите любое число от 2 до 12 в ячейку 'Сумма цифр'\n" +
                $"и Вашу ставку в ячейку 'Ваша ставка'.\n" +
                $"~Если сумма выпавших цифр меньше 7 и Вы задумали число меньшее 7, то\n" +
                $"Вы выигрываете сделанную ставку.\n" +
                $"~Если сумма выпавших цифр больше 7 и Вы задумали число большее 7, то\n" +
                $"Вы также выигрывает сделанную ставку.\n" +
                $"~Если Вы угадали сумму цифр, то\n" +
                $"Вы получаете в четыре раза больше очков, чем сделанная ставка.\n" +
                $"~Иначе ставка програна.\n" +
                $"В начальный момент у Вас 100 очков.\n" +
                $"~Если количество очков становится меньше 1, то Вы проигрываете.\n" +
                $"~Если больше 150, то выигрываете.";
            PravilaIgr.Visible = false;
        }
        //Реализовать алгоритм игры «Кости». Играющий называет любое число в диапазоне от 2 до 12 и
        //ставку, которую он делает в этот ход.Программа с помощью генератора псевдослучайных чисел
        //дважды выбирает числа от 1 до 6.
        //Если сумма выпавших цифр меньше 7 и играющий задумал число меньшее 7, он выигрывает сделанную ставку
        //Если сумма выпавших цифр больше 7 и играющий задумал число большее 7, он также выигрывает сделанную ставку.
        //Если играющий угадал сумму цифр, он получает в четыре раза больше очков, чем сделанная ставка.
        //Ставка проиграна, если не имеет место ни одна из описанных ситуаций
        //В начальный момент у играющего 100 очков.
        //Если количество очков становится меньше 0, то игрок проигрывает.
        //Если больше заданного в начале игры максимального значения, то выигрывает.
        int popitka = 0;
        int a;
        int sum;
        int stavka;
        Dictionary<int, int> polz = new Dictionary<int, int>()
        {
            [2] = 0,
            [3] = 0,
            [4] = 0,
            [5] = 0,
            [6] = 0,
            [7] = 0,
            [8] = 0,
            [9] = 0,
            [10] = 0,
            [11] = 0,
            [12] = 0,
        };
        Dictionary<int, int> comp = new Dictionary<int, int>()
        {
            [2] = 0,
            [3] = 0,
            [4] = 0,
            [5] = 0,
            [6] = 0,
            [7] = 0,
            [8] = 0,
            [9] = 0,
            [10] = 0,
            [11] = 0,
            [12] = 0,
        };

        private void StavkaPolz_ValueChanged(object sender, EventArgs e)
        {
            StavkaPolz.Maximum = Convert.ToInt32(Ochki.Text);
        }

        private void Alg(int a0, int a1, int c, int sum, int stavka)
        {
            int s = a0 + a1;
            if (s < 7 && sum < 7)
            {
                label1.Text = "Результат: Вы выиграли сделанную ставку";
                c += stavka;
            }
            else if (s > 7 && sum > 7)
            {
                label1.Text = "Результат: Вы выиграли сделанную ставку";
                c += stavka;
            }
            else if (s == sum)
            {
                label1.Text = "Результат: Вы выиграли сделанную ставку";
                c += 4 * stavka;
            }
            else
            {
                label1.Text = "Результат: Ставка проиграна";
                c -= stavka;
            }
            Cubiki.Text = $"Первый кубик: {a0}\nВторой кубик: {a1}";

            //Гистограмма
            a = a0 + a1;
            polz[sum] += 1;
            comp[a] += 1;
            chart1.Series[0].Points.AddXY(sum, polz[sum]);
            chart1.Series[1].Points.AddXY(a, comp[a]);

            Ochki.Text = $"{c}";
            if (c <= 150 && c > 0)
            {
                Ochki.Text = $"{c}";
            }
            else if (c > 150)
            {
                Ochki.Text = $"{c}";
                MessageBox.Show("Вы выиграли!");
                c = 100;
                Ochki.Text = $"{c}";
                label1.Text = "Результат: ";
                SumPolz.Value = 2;
                StavkaPolz.Value = 1;
                Cubiki.Text = "";
                popitka = 0;
                CountPopitki.Text = $"Кол-во попыток: {popitka}";
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }
            else if (c < 0 || c == 0)
            {
                Ochki.Text = $"{c}";
                MessageBox.Show("Вы проиграли!");
                c = 100;
                Ochki.Text = $"{c}";
                label1.Text = "Результат: ";
                SumPolz.Value = 2;
                StavkaPolz.Value = 1;
                Cubiki.Text = "";
                popitka = 0;
                CountPopitki.Text = $"Кол-во попыток: {popitka}";
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PravilaIgr.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            PravilaIgr.Visible = false;
        }

        int count = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            count += 1;
            if (count % 2 == 1)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vibor1();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vibor2();
        }

        private void Vibor1()
        {
            if (listBox1.SelectedIndex == 0)
            {
                panel2.BackColor = Color.PeachPuff;

            }
            else if (listBox1.SelectedIndex == 1)
            {
                panel2.BackColor = Color.YellowGreen;
            }
            else
            {
                panel2.BackColor = Color.PaleGoldenrod;
            }
        }
        private void Vibor2()
        {
            if (listBox2.SelectedIndex == 2)
            {
                chart1.Palette = ChartColorPalette.Chocolate;

            }
            else if (listBox2.SelectedIndex == 1)
            {
                chart1.Palette = ChartColorPalette.SeaGreen;
            }
            else
            {
                chart1.Palette = ChartColorPalette.Berry;
            }
        }

        string text;
        private void Zapis_Click(object sender, EventArgs e)
        {
            if(popitka != 0)
            {
                if (radioButton1.Checked)
                {
                    try
                    {
                        text = $"Выбор компьютера: {a}\nВыбор пользователя: {sum}\nСтавка пользователя: {stavka}\nНомер попытки: {popitka}\n\n"; //Строка в файл
                        if (File.Exists(richTextBox1.Text))
                        {
                            StreamWriter f = new StreamWriter(richTextBox1.Text, false);
                            f.WriteLine(text);
                            f.Close();
                        }
                        else
                        {
                            MessageBox.Show("Введите путь к файлу!");
                        }
                    }
                    catch
                    {
                        if (richTextBox1.Text == "" || richTextBox1.Text == "Введите путь к файлу")
                        {
                            MessageBox.Show("Введите путь к файлу!");
                        }
                        else
                        {
                            MessageBox.Show("Ошибка!");
                        }
                    }
                }
                else if (radioButton2.Checked)
                {
                    try
                    {
                        text = $"Выбор компьютера: {a}\nВыбор пользователя: {sum}\nСтавка пользователя: {stavka}\nНомер попытки: {popitka}\n\n"; //Строка в файл
                        if (File.Exists(richTextBox1.Text))
                        {
                            StreamWriter f = new StreamWriter(richTextBox1.Text, true);
                            f.WriteLine(text);
                            f.Close();
                        }
                        else
                        {
                            MessageBox.Show("Введите путь к файлу!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка!");
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            else
            {
                MessageBox.Show("Вы не сделали ни одной попытки");
            }
        }

        private void Brosit_Click(object sender, EventArgs e)
        {
            try
            {
                popitka++;
                CountPopitki.Text = $"Кол-во попыток: {popitka}";
                sum = Convert.ToInt32(SumPolz.Text); //ввод очков пользователя
                stavka = Convert.ToInt32(StavkaPolz.Text); //ввод ставки пользователя
                int c = Convert.ToInt32(Ochki.Text); //начальное кол-во очков
                Random a0 = new Random();
                int[] a = new int[2];
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = Convert.ToInt32(a0.Next(1, 7));
                }
                Alg(a[0], a[1], c, sum, stavka);
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        string path = "C:\\Users\\polin\\OneDrive\\Рабочий стол\\Учёба\\Прога 4сем\\Курсовая\\Пользовательские настройки.txt";
        private void VernutNastr_Click(object sender, EventArgs e)
        {
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    listBox1.SelectedIndex = reader.ReadInt32();
                    listBox2.SelectedIndex = reader.ReadInt32();
                    Vibor1();
                }
            }
            catch
            {
                MessageBox.Show("Файл не создан");
            }
        }

        private void SohranNastr_Click(object sender, EventArgs e)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(listBox1.SelectedIndex);
                writer.Write(listBox2.SelectedIndex);
            }
        }

        private void Zanovo_Click(object sender, EventArgs e)
        {
            label1.Text = "Результат: ";
            SumPolz.Value = 2;
            StavkaPolz.Value = 1;
            Cubiki.Text = "";
            Ochki.Text = "100";
            popitka = 0;
            CountPopitki.Text = $"Кол-во попыток: {popitka}";
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }
    }

}
