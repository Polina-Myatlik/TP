using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Лаба8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            button6.BackColor = Color.Gray;
            button7.BackColor = Color.Gray;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if(checkedListBox2.CheckedItems.Count != 1 && checkedListBox2.CheckedItems.Count != 1)
            {
                MessageBox.Show("Ошибка фильтрации");
            }
            else if(q == 0)
            {
                MessageBox.Show("Ошибка фильтрации");
            }
            else
            {
                int znach = (int)numericUpDown1.Value;
                string a1 = File.ReadAllText("C:\\Users\\polin\\OneDrive\\Рабочий стол\\Учёба\\Прога 4сем\\Лаба8\\Лаба.txt");
                string[] a2 = a1.Split(new char[] { '\n' });
                string[][] a = new string[a2.Length][];
                for(int i = 0; i<a2.Length; i++)
                {
                    string[] a3 = a2[i].Split(new char[] { ' ' });
                    for (int j = 0; j < a3.Length; j++)
                    {
                        a[i][j] = a3[j];
                    }
                }
                if ((bool)checkedListBox1.CheckedItems[0])
                {
                    for (int i = 0; i < a1.Length; i++)
                    {
                        for (int j = 0; j < a1.Length; j++)
                        {
                            if (int.TryParse(a[i][j], out var number) == false)
                            {
                                a[i][j] = "0";
                            }
                        }
                    }
                }
                if ((bool)checkedListBox2.CheckedItems[0])
                {
                    for (int i = 0; i < a1.Length; i++)
                    {
                        for (int j = 0; j < a1.Length; j++)
                        {
                            if (int.TryParse(a[i][j], out var number))
                            {
                                int z = (int)Math.Round(Convert.ToDouble(a[i][j]), 0);
                                a[i][j] = Convert.ToString(z);
                            }
                        }
                    }
                }
                string text = "";
                for (int i = 0; i < a1.Length; i++)
                {
                    for (int j = 0; j < a1.Length; j++)
                    {
                        text += a[i][j];
                    }
                    text += "\n";
                }

                using (FileStream x = new FileStream("C:\\Users\\polin\\OneDrive\\Рабочий стол\\Учёба\\Прога 4сем\\Лаба8\\Новый текстовый документ.txt", FileMode.OpenOrCreate))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);

                    x.Write(array, 0, array.Length);
                }
            }
        }
        int q = 0;
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            q = 1;
            button2.BackColor = Color.GreenYellow;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            button6.BackColor = Color.Gray;
            button7.BackColor = Color.Gray;
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            q = 2;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.GreenYellow;
            button5.BackColor = Color.Gray;
            button6.BackColor = Color.Gray;
            button7.BackColor = Color.Gray;
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            q = 3;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.GreenYellow;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            button6.BackColor = Color.Gray;
            button7.BackColor = Color.Gray;
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            q = 4;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            button6.BackColor = Color.Gray;
            button7.BackColor = Color.GreenYellow;
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            q = 5;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.GreenYellow;
            button6.BackColor = Color.Gray;
            button7.BackColor = Color.Gray;
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            q = 6;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            button6.BackColor = Color.GreenYellow;
            button7.BackColor = Color.Gray;
        }
    }
}
