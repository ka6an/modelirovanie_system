using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double func_post(double R)
        {
            return -1 / lyamd * Math.Log(1 - R);
        }
        private double func_obsl(double R)
        {
            if (k==0)
                return -1 / my * Math.Log(1 - R);
            else
                return -1 / (my * k)* Math.Log(1 - R);
        }
        private double func_interv(double t, double T)
        {
            Random rand = new Random();
            Console.WriteLine(t + "   " + T);
            while (t < T)
            {
                double t_i, T_i;
                t_i = func_post(rand.NextDouble());
                if (k == 0)
                {
                    N++;
                    M++;
                    k++;
                }
                else
                {
                    T_i = func_obsl(rand.NextDouble());
                    if (t_i < T_i)
                    {
                        N++;
                        t += t_i;
                        if (k < n)
                        {
                            M++;
                            k++;
                        }
                        else
                            if (k == 0 && r < m)
                            {
                                M++;
                                r++;
                            }
                    }
                    else
                    {
                        t += t_i;
                        if (r == 0)
                            k--;
                        else
                            r--;
                    }
                }
            }
                
            //Console.WriteLine(t);
            //Console.WriteLine("апрол " + t);
            q = (double)(N - M) / N;
            p = (double)M / N;
            eps = alpha_d * Math.Sqrt((p * (1 - p)) / N);
            if (eps > 0.01)
                N_treb = (alpha_d * alpha_d * p * (1 - p)) / (0.01 * 0.01);//
            else
                N_treb = 0;
            return t;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            t = 0; T = 100; N = 0; M = 0; k = 0;
            t = func_post(rand.NextDouble());
            N++; M++;// k++;
            //Console.WriteLine(t);
            t = func_interv(t, T);
            Console.WriteLine(N + "  " + M);
            Console.WriteLine(p + "  " + q);
            double temp = N / t;
            //Console.WriteLine(N + "  " + t + "  " + temp);
            label1.Text = Convert.ToString("Лямбда = " + temp);
            label2.Text = Convert.ToString("Вероятность приема = " + p);
            if (N_treb != 0)
            {
                label3.Text = Convert.ToString("N требуемое = " + N_treb + "    " + "N текущее = " + N);
                label6.Text = Convert.ToString("Требуемое время = " + N_treb / temp);
            }
            else
            {
                label3.Text = Convert.ToString("N требуемое достигрнуто!" + "    " + "N текущее = " + N);
                label6.Text = Convert.ToString("Требуемое время достигнуто!");
            }
            label5.Text = Convert.ToString("Эпсилонд = " + eps);
            label6.Text = Convert.ToString("Требуемое время = " + N_treb/temp);
            label4.Text = Convert.ToString("До какого интервала времени увеличить интрвал, если текущий интервал от 0 до " + T + " ?");
            textBox1.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(textBox1.Text) > T)
            {
                T = Convert.ToInt16(textBox1.Text);
                t = func_interv(t, T);
                Console.WriteLine(N + "  " + M);
                Console.WriteLine(p + "  " + q);
                double temp = N / t;
                Console.WriteLine(N + "  " + t + "  " + temp);
                label1.Text = Convert.ToString("Лямбда = " + N / t);
                label2.Text = Convert.ToString("Вероятность приема = " + p);
                if (N_treb != 0)
                {
                    label3.Text = Convert.ToString("N требуемое = " + N_treb + "    " + "N текущее = " + N);
                    label6.Text = Convert.ToString("Требуемое время = " + N_treb / temp);
                }
                else
                {
                    label3.Text = Convert.ToString("N требуемое достигрнуто!" + "    " + "N текущее = " + N);
                    label6.Text = Convert.ToString("Требуемое время достигнуто!");
                }

                label4.Text = Convert.ToString("До какого интервала времени увеличить интрвал, если текущий интервал от 0 до " + T + " ?");
                label5.Text = Convert.ToString("Эпсилонд = " + eps);
                
            }
            else
                MessageBox.Show("Ошибка, введено неверное значение");
        }
    }
}
