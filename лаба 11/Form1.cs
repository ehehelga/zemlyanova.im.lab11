using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            double Mean, Variance, dzeta, E = 0, D = 0, erE, erD, Chi2N = 0;
            int M;
            List<int> Stat = new List<int>();
            List<double> xi = new List<double>();
            Random rand = new Random();


            Mean = (double)edMean.Value;
            Variance = (double)edVariance.Value;
            M = (int)edSize.Value;

            for (int i = 0; i < M; i++) 
            {
                dzeta = 0;
                for (int j = 0; j < 12; j++) 
                {
                    dzeta += rand.NextDouble();
                }
                dzeta -= 6;
                xi.Add(Variance * dzeta + Mean);
            }


            double min = double.MaxValue, max = double.MinValue;
            for (int i = 0; i < M; i++) 
            {
                if (xi[i] < min) { min = xi[i]; }
                else if (xi[i] > max) { max = xi[i]; }
            }
            max = Math.Ceiling(max);
            min = Math.Floor(min);

            int N = (int)(max + Math.Abs(min));
            for (int i = 0; i < N; i++)
            {
                Stat.Add(0);
            }

            for (int i = 0; i < M; i++) 
            {
                for (int j = 0; j < N; j++)
                {
                    if (xi[i] > (j + min) && xi[i] <= (j + min + 1)) { Stat[j]++; }
                }
            }


            for (int i = 0; i < M; i++)
            {
                E += xi[i];
            }
            E /= M;

            for (int i = 0; i < M; i++)
            {
                D += xi[i] * xi[i];
            }
            D /= M;
            D -= - E * E;


            erE = Math.Abs(E - Mean);
            erD = Math.Abs(D - Variance);


            double[] p = new double[N];
            for (int i = 0; i < N; i++) 
            {
                p[i] = Math.Exp(-Math.Pow(((i + min + i + min + 1) / 2) - Mean, 2) / (2 * Variance)) / Math.Sqrt(Variance * Math.PI * 2);
            }

            for (int i = 0; i < N; i++) { Chi2N += Stat[i] * Stat[i] / (p[i] * M); }
            Chi2N = Chi2N - M;
            

            tbAverage.Text = Convert.ToString(Math.Round(E, 3)) + "(ошибка=" + Math.Round(erE, 3) + ")";
            tbVariance.Text = Convert.ToString(Math.Round(D, 3)) + "(ошибка=" + Math.Round(erD, 3) + ")";
            tbChi.Text = Convert.ToString(Chi2N);

            for (int i = 0; i < N; i++) { chart1.Series[0].Points.AddXY("("+(i+min)+"-"+ (i + min+1)+"]", Stat[i]); }
        }

    }
}
