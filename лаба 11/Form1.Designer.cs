namespace лаба_11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbChi = new System.Windows.Forms.TextBox();
            this.tbVariance = new System.Windows.Forms.TextBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.edSize = new System.Windows.Forms.NumericUpDown();
            this.edVariance = new System.Windows.Forms.NumericUpDown();
            this.edMean = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbChi);
            this.panel1.Controls.Add(this.tbVariance);
            this.panel1.Controls.Add(this.tbAverage);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.edSize);
            this.panel1.Controls.Add(this.edVariance);
            this.panel1.Controls.Add(this.edMean);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 209);
            this.panel1.TabIndex = 0;
            // 
            // tbChi
            // 
            this.tbChi.Location = new System.Drawing.Point(517, 112);
            this.tbChi.Name = "tbChi";
            this.tbChi.Size = new System.Drawing.Size(163, 20);
            this.tbChi.TabIndex = 12;
            // 
            // tbVariance
            // 
            this.tbVariance.Location = new System.Drawing.Point(517, 83);
            this.tbVariance.Name = "tbVariance";
            this.tbVariance.Size = new System.Drawing.Size(163, 20);
            this.tbVariance.TabIndex = 11;
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(517, 54);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(163, 20);
            this.tbAverage.TabIndex = 10;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(134, 156);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(86, 35);
            this.btStart.TabIndex = 9;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // edSize
            // 
            this.edSize.Location = new System.Drawing.Point(201, 116);
            this.edSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edSize.Name = "edSize";
            this.edSize.Size = new System.Drawing.Size(120, 20);
            this.edSize.TabIndex = 8;
            this.edSize.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // edVariance
            // 
            this.edVariance.Location = new System.Drawing.Point(201, 87);
            this.edVariance.Name = "edVariance";
            this.edVariance.Size = new System.Drawing.Size(120, 20);
            this.edVariance.TabIndex = 7;
            this.edVariance.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // edMean
            // 
            this.edMean.Location = new System.Drawing.Point(201, 55);
            this.edMean.Name = "edMean";
            this.edMean.Size = new System.Drawing.Size(120, 20);
            this.edMean.TabIndex = 6;
            this.edMean.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chi-squared:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Variance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sample size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Variance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mean";
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 208);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(773, 371);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 579);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbChi;
        private System.Windows.Forms.TextBox tbVariance;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown edSize;
        private System.Windows.Forms.NumericUpDown edVariance;
        private System.Windows.Forms.NumericUpDown edMean;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

