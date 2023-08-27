namespace Курсовая
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Brosit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cubiki = new System.Windows.Forms.RichTextBox();
            this.CountPopitki = new System.Windows.Forms.Label();
            this.Zanovo = new System.Windows.Forms.Button();
            this.SumPolz = new System.Windows.Forms.NumericUpDown();
            this.StavkaPolz = new System.Windows.Forms.NumericUpDown();
            this.Ochki = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PravilaIgr = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Zapis = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VernutNastr = new System.Windows.Forms.Button();
            this.SohranNastr = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ColorBack = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SumPolz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StavkaPolz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Brosit
            // 
            this.Brosit.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Brosit.Location = new System.Drawing.Point(20, 129);
            this.Brosit.Name = "Brosit";
            this.Brosit.Size = new System.Drawing.Size(233, 61);
            this.Brosit.TabIndex = 1;
            this.Brosit.Text = "Бросить кубики";
            this.Brosit.UseVisualStyleBackColor = false;
            this.Brosit.Click += new System.EventHandler(this.Brosit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Результат: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сумма цифр:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ваша ставка:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кол-во очков:";
            // 
            // Cubiki
            // 
            this.Cubiki.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Cubiki.Location = new System.Drawing.Point(329, 149);
            this.Cubiki.Name = "Cubiki";
            this.Cubiki.Size = new System.Drawing.Size(209, 61);
            this.Cubiki.TabIndex = 8;
            this.Cubiki.Text = "";
            // 
            // CountPopitki
            // 
            this.CountPopitki.AutoSize = true;
            this.CountPopitki.Location = new System.Drawing.Point(325, 220);
            this.CountPopitki.Name = "CountPopitki";
            this.CountPopitki.Size = new System.Drawing.Size(146, 20);
            this.CountPopitki.TabIndex = 9;
            this.CountPopitki.Text = "Кол-во попыток: 0";
            // 
            // Zanovo
            // 
            this.Zanovo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Zanovo.Location = new System.Drawing.Point(20, 196);
            this.Zanovo.Name = "Zanovo";
            this.Zanovo.Size = new System.Drawing.Size(233, 29);
            this.Zanovo.TabIndex = 10;
            this.Zanovo.Text = "Заново";
            this.Zanovo.UseVisualStyleBackColor = false;
            this.Zanovo.Click += new System.EventHandler(this.Zanovo_Click);
            // 
            // SumPolz
            // 
            this.SumPolz.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.SumPolz.Location = new System.Drawing.Point(133, 22);
            this.SumPolz.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.SumPolz.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SumPolz.Name = "SumPolz";
            this.SumPolz.Size = new System.Drawing.Size(120, 26);
            this.SumPolz.TabIndex = 11;
            this.SumPolz.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // StavkaPolz
            // 
            this.StavkaPolz.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.StavkaPolz.Location = new System.Drawing.Point(133, 82);
            this.StavkaPolz.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StavkaPolz.Name = "StavkaPolz";
            this.StavkaPolz.Size = new System.Drawing.Size(120, 26);
            this.StavkaPolz.TabIndex = 12;
            this.StavkaPolz.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StavkaPolz.ValueChanged += new System.EventHandler(this.StavkaPolz_ValueChanged);
            // 
            // Ochki
            // 
            this.Ochki.AutoSize = true;
            this.Ochki.Location = new System.Drawing.Point(411, 22);
            this.Ochki.Name = "Ochki";
            this.Ochki.Size = new System.Drawing.Size(36, 20);
            this.Ochki.TabIndex = 13;
            this.Ochki.Text = "100";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.richTextBox1.Location = new System.Drawing.Point(20, 231);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(485, 30);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(169)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(169)))));
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.LightGray;
            chartArea3.AxisY.MajorGrid.Interval = 1D;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(726, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Вы";
            series5.Points.Add(dataPoint5);
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Компьютер";
            series6.Points.Add(dataPoint6);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(540, 644);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // PravilaIgr
            // 
            this.PravilaIgr.AutoSize = true;
            this.PravilaIgr.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.PravilaIgr.CausesValidation = false;
            this.PravilaIgr.Location = new System.Drawing.Point(114, 327);
            this.PravilaIgr.Name = "PravilaIgr";
            this.PravilaIgr.Size = new System.Drawing.Size(578, 260);
            this.PravilaIgr.TabIndex = 15;
            this.PravilaIgr.Text = resources.GetString("PravilaIgr.Text");
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(133, 267);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(195, 24);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Очистить и записать";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 267);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 24);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Записать";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Zapis
            // 
            this.Zapis.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Zapis.Location = new System.Drawing.Point(420, 287);
            this.Zapis.Name = "Zapis";
            this.Zapis.Size = new System.Drawing.Size(109, 30);
            this.Zapis.TabIndex = 24;
            this.Zapis.Text = "Записать";
            this.Zapis.UseVisualStyleBackColor = false;
            this.Zapis.Click += new System.EventHandler(this.Zapis_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.VernutNastr);
            this.panel1.Controls.Add(this.SohranNastr);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.ColorBack);
            this.panel1.Location = new System.Drawing.Point(114, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 260);
            this.panel1.TabIndex = 26;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "1. Ягодный",
            "2. Зелёный",
            "3. Шоколад"});
            this.listBox2.Location = new System.Drawing.Point(316, 46);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(256, 64);
            this.listBox2.TabIndex = 29;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(190)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(312, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Цвет гистограммы";
            // 
            // VernutNastr
            // 
            this.VernutNastr.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.VernutNastr.Location = new System.Drawing.Point(125, 133);
            this.VernutNastr.Name = "VernutNastr";
            this.VernutNastr.Size = new System.Drawing.Size(138, 80);
            this.VernutNastr.TabIndex = 27;
            this.VernutNastr.Text = "Вернуть предыдущие";
            this.VernutNastr.UseVisualStyleBackColor = false;
            this.VernutNastr.Click += new System.EventHandler(this.VernutNastr_Click);
            // 
            // SohranNastr
            // 
            this.SohranNastr.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.SohranNastr.Location = new System.Drawing.Point(7, 133);
            this.SohranNastr.Name = "SohranNastr";
            this.SohranNastr.Size = new System.Drawing.Size(112, 81);
            this.SohranNastr.TabIndex = 2;
            this.SohranNastr.Text = "Сохранить настройки";
            this.SohranNastr.UseVisualStyleBackColor = false;
            this.SohranNastr.Click += new System.EventHandler(this.SohranNastr_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "1. Персиковый",
            "2. Зелёный",
            "3. Жёлтый"});
            this.listBox1.Location = new System.Drawing.Point(7, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 64);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ColorBack
            // 
            this.ColorBack.AutoSize = true;
            this.ColorBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(190)))));
            this.ColorBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ColorBack.Location = new System.Drawing.Point(3, 10);
            this.ColorBack.Name = "ColorBack";
            this.ColorBack.Size = new System.Drawing.Size(103, 20);
            this.ColorBack.TabIndex = 0;
            this.ColorBack.Text = "Цвет фона";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(44, 373);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Zapis);
            this.panel2.Controls.Add(this.PravilaIgr);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.CountPopitki);
            this.panel2.Controls.Add(this.Cubiki);
            this.panel2.Location = new System.Drawing.Point(-33, -20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1799, 1800);
            this.panel2.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1337, 720);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Ochki);
            this.Controls.Add(this.StavkaPolz);
            this.Controls.Add(this.SumPolz);
            this.Controls.Add(this.Zanovo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Brosit);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SumPolz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StavkaPolz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Brosit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Cubiki;
        private System.Windows.Forms.Label CountPopitki;
        private System.Windows.Forms.Button Zanovo;
        private System.Windows.Forms.NumericUpDown SumPolz;
        private System.Windows.Forms.NumericUpDown StavkaPolz;
        private System.Windows.Forms.Label Ochki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label PravilaIgr;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button Zapis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ColorBack;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button VernutNastr;
        private System.Windows.Forms.Button SohranNastr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
    }
}