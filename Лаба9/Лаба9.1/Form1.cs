using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Лаба9._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Axis ax = new Axis();
            ax.Title = "Ось Х";
            chart1.ChartAreas[0].AxisX = ax;
            Axis ay = new Axis();
            ay.Title = "Ось Y";
            chart1.ChartAreas[0].AxisY = ay;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int tol = (int)numericUpDown1.Value;

                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();

                double y;
                for (int x = 1; x < 5; x ++)
                {
                    y = Math.Sin(x) * 100;
                    chart1.Series[0].Points.AddXY(x, y);
                }
            }
            catch
            {
                MessageBox.Show("Выберите фильтры");
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int tol = (int)numericUpDown1.Value;

                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();

                double y;
                for (int x = 1; x < 5; x++)
                {
                    y = Math.Sin(x) * 100;
                    chart1.Series[1].Points.AddXY(x, y);
                }
            }
            catch
            {
                MessageBox.Show("Выберите фильтры");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox4.Checked = false;
                checkBox3.Checked = false;
                chart1.Series[0].Color = Color.Green;
                chart1.Series[1].Color = Color.Green;
                chart1.Series[2].Color = Color.Green;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox3.Checked = false;
                checkBox5.Checked = false;
                chart1.Series[0].Color = Color.Blue;
                chart1.Series[1].Color = Color.Blue;
                chart1.Series[2].Color = Color.Blue;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                chart1.Series[0].Color = Color.Red;
                chart1.Series[1].Color = Color.Red;
                chart1.Series[2].Color = Color.Red;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                chart1.Legends[0].ForeColor = Color.Coral;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox7.Checked = false;
                checkBox6.Checked = false;
                chart1.Legends[0].ForeColor = Color.OliveDrab;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox6.Checked = false;
                checkBox8.Checked = false;
                chart1.Legends[0].ForeColor = Color.Teal;
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int tol = (int)numericUpDown1.Value;

                chart1.Series[2].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.Clear();


                double y;
                for (int x = 1; x < 5; x++)
                {
                    y = Math.Sin(x) * 100;
                    chart1.Series[2].Points.AddXY(x, y);
                }
            }
            catch
            {
                MessageBox.Show("Выберите фильтры");
            }
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            int tol = (int)numericUpDown1.Value;

            chart1.Series[0].BorderWidth = tol;
            chart1.Series[1].BorderWidth = tol;
            chart1.Series[2].BorderWidth = tol;
        }
    }
}
