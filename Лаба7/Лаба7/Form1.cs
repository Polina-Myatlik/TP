using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Лаба7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = "";
            bT.BackColor = Color.Gainsboro;
            bCos.BackColor = Color.Gainsboro;
            bSin.BackColor = Color.Gainsboro;
            timer1.Interval= 500;
            timer1.Start();
        }
        int c = 0;
        private void Lnv_MouseClick(object sender, MouseEventArgs e)
        {
            c++;
            if(c % 2 != 0)
            {
                bSin.Text = "ASin";
                bCos.Text = "ACos";
                bT.Text = "ATan";
            }
            else
            {
                bSin.Text = "Sin";
                bCos.Text = "Cos";
                bT.Text = "Tan";
            }
        }

        private void bPoint_MouseClick(object sender, MouseEventArgs e)
        {
            if (richTextBox1.Text.Contains(",") == false)
            {
                if(richTextBox1.Text == "")
                {
                    richTextBox1.Text += "0,";
                }
                else
                {
                    richTextBox1.Text += ",";
                }
            }
        }

        private void b0_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text += "0";
        }

        private void b1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text += "1";
        }

        private void b2_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text += "2";
        }

        private void b3_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text += "3";
        }

        private void b4_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text += "4";
        }

        private void b5_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text += "5";
        }

        private void b6_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text += "6";
        }

        private void b7_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text += "7";
        }

        private void b8_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text += "8";
        }

        private void b9_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text += "9";
        }

        private void bM_MouseClick(object sender, MouseEventArgs e)
        {
            if (richTextBox1.Text.Contains("-") == false)
            {
                richTextBox1.Text = richTextBox1.Text.Insert(0, "-");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(richTextBox1.Text != "" && richTextBox1.Text.Contains(",") == false)
            {
                int a = Convert.ToInt32(richTextBox1.Text);
                if (a > 1 || a < -1)
                {
                    label3.Text = "Введите другое число!";
                    bOk.Enabled = false;
                }
                else
                {
                    label3.Text = "";
                    bOk.Enabled = true;
                }
            }
            else if(richTextBox1.Text == "")
            {
                label3.Text = "";
                bOk.Enabled = true;
            }
        }

        private void bOtmena_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            pictureBox1.Image = null;
        }
        double znach;
        string sznach;

        Pen pen = new Pen(Color.Green, 3f);
        Point[] points = new Point[1000];
        private void bSin_MouseClick(object sender, MouseEventArgs e)
        {
            if(richTextBox1.Text != "")
            {
                bSin.BackColor= Color.AliceBlue;
                bCos.BackColor= Color.Gainsboro;
                bT.BackColor = Color.Gainsboro;
                znach = Convert.ToDouble(richTextBox1.Text);
                Graphics graphics = pictureBox1.CreateGraphics();
                if (c % 2 == 0)
                {
                    sznach = $"Sin({znach}) = {Math.Sin(znach)}";
                    for (int i = 0; i < points.Length; i++)
                    {
                        points[i] = new Point(i, (int)(Math.Sin((double)i / 10) * 100 + 200));
                    }
                }
                else
                {
                    sznach = $"Arcsin({znach}) = {Math.Asin(znach)}";
                    for (int i = 0; i < points.Length; i++)
                    {
                        points[i] = new Point(i, (int)(Math.Asin((double)i / 10) * 100 + 200));
                    }
                }
                graphics.DrawLines(pen, points);
            }
        }

        private void bCos_MouseClick(object sender, MouseEventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                Graphics graphics = pictureBox1.CreateGraphics();
                bSin.BackColor = Color.Gainsboro;
                bCos.BackColor = Color.AliceBlue;
                bT.BackColor = Color.Gainsboro;
                znach = Convert.ToDouble(richTextBox1.Text);
                if (c % 2 == 0)
                {
                    sznach = $"Cos({znach}) = {Math.Cos(znach)}";
                    for (int i = 0; i < points.Length; i++)
                    {
                        points[i] = new Point(i, (int)(Math.Cos((double)i / 10) * 100 + 200));
                    }
                }
                else
                {
                    sznach = $"Arccos({znach}) = {Math.Acos(znach)}";
                    for (int i = 0; i < points.Length; i++)
                    {
                        points[i] = new Point(i, (int)(Math.Acos((double)i / 10) * 100 + 200));
                    }
                }
                graphics.DrawLines(pen, points);
            }
        }

        private void bT_MouseClick(object sender, MouseEventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                Graphics graphics = pictureBox1.CreateGraphics();
                bSin.BackColor = Color.Gainsboro;
                bCos.BackColor = Color.Gainsboro;
                bT.BackColor = Color.AliceBlue;
                znach = Convert.ToDouble(richTextBox1.Text);
                if (c % 2 == 0)
                {
                    sznach = $"Tan({znach}) = {Math.Tan(znach)}";
                    for (int i = 0; i < points.Length; i++)
                    {
                        points[i] = new Point(i, (int)(Math.Tan((double)i / 10) * 100 + 200));
                    }
                }
                else
                {
                    sznach = $"Arctan({znach}) = {Math.Atan(znach)}";
                    for (int i = 0; i < points.Length; i++)
                    {
                        points[i] = new Point(i, (int)(Math.Atan((double)i / 10) * 100 + 200));
                    }
                }
                graphics.DrawLines(pen, points);
            }
        }

        private void bOk_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox2.Text = sznach;
        }
        string text;
        private void bCohran_MouseClick(object sender, MouseEventArgs e)
        {
            text += $"{sznach}\n";
            richTextBox3.Text += text;
            using (FileStream a = new FileStream("C:\\Users\\polin\\OneDrive\\Рабочий стол\\Учёба\\Прога 4сем\\Лаба7\\znach.txt", FileMode.Open))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);

                a.Write(array, 0, array.Length);
            }
        }

        private void richTextBox3_DoubleClick(object sender, EventArgs e)
        {
            richTextBox3.Text = "";
        }
    }
}
