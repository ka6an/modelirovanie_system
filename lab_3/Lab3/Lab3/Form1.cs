using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

 

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void func_random()
        {
            Random rand = new Random();
            int i=0;
            for (i = 0; i < 50; i++)
                mas1[i] = 1 - (Math.Log(1 - rand.NextDouble())) / 4; 
            for (i = 0; i < 100; i++)
                mas2[i] = 1 - (Math.Log(1 - rand.NextDouble())) / 4;
            for (i = 0; i < 1000; i++)
                mas3[i] = 1 - (Math.Log(1 - rand.NextDouble())) / 4;
            for (i = 0; i < 100000; i++)
                mas4[i] = 1 - (Math.Log(1 - rand.NextDouble())) / 4;
        }

        private void func_math()
        {
            Mx1 = Mx2 = Mx3 = Mx4 = Dx1 = Dx2 = Dx3 = Dx4 = 0;
            int i = 0;
            for (i = 0; i < 50; i++)
            {
                Mx1 += mas1[i];
                Dx1 += mas1[i] * mas1[i];
            }
            for (i = 0; i < 100; i++)
            {
                Mx2 += mas2[i];
                Dx2 += mas2[i] * mas2[i];
            }
            for (i = 0; i < 1000; i++)
            {
                Mx3 += mas3[i];
                Dx3 += mas3[i] * mas3[i];
            }
            for (i = 0; i < 10000; i++)
            {
                Mx4 += mas4[i];
                Dx4 += mas4[i] * mas4[i];
            }
            Mx1 /= 50; Dx1 = Dx1 / 50 - Mx1 * Mx1;
            Mx2 /= 100; Dx2 = Dx2 / 100 - Mx2 * Mx2;
            Mx3 /= 1000; Dx3 = Dx3 / 1000 - Mx3 * Mx3;
            Mx4 /= 10000; Dx4 = Dx4 / 10000 - Mx4 * Mx4;
        }


        private void add_label()
        {
            label1.Text = Convert.ToString("Mx1= " + Mx1);
            label2.Text = Convert.ToString("Mx2= " + Mx2);
            label3.Text = Convert.ToString("Mx3= " + Mx3);
            label4.Text = Convert.ToString("Mx4= " + Mx4);

            label5.Text = Convert.ToString("Dx1= " + Dx1);
            label6.Text = Convert.ToString("Dx2= " + Dx2);
            label7.Text = Convert.ToString("Dx3= " + Dx3);
            label8.Text = Convert.ToString("Dx4= " + Dx4);
        }

        private void func_selection()
        {
            Array.Sort(mas1);
            func_calculus(50, mas1, select_mas1);
            Array.Sort(mas2);
            func_calculus(100, mas2, select_mas2);
            Array.Sort(mas3);
            func_calculus(1000, mas3, select_mas3);
            Array.Sort(mas4);
            func_calculus(100000, mas4, select_mas4);
        }

        void func_calculus(int num, double[] mas, double[,] select_mas)
        {
            int count, tem;
            double  temp, flus;
            if (num <= 500)
            {
                count = num/15;
                temp = (mas[num-1] - mas[0])/count;
                Console.WriteLine(num + " " + mas[num-1] + " " + mas[0] + " " + temp);
            }
            else
            {
                temp = (mas[num - 1] - mas[0]) / 30;
                Console.WriteLine(num + " " + mas[num - 1] + " " + mas[0] + " " + temp);
            }
            flus = mas[0] + temp;
            for (int i = 0, j =0, k=-1; i < num; i++)
            {
                k++;
                if (mas[i] > flus || i == (num-1)) //для Баранова Станислава Васильевича из группы И531
                {
                    if(mas[i]-flus > temp)
                    {
                        double a=mas[i]-flus;
                        for(int l=0; l<a/temp-1; l++)
                        {
                            select_mas[j, 0] = flus - temp;
                            select_mas[j, 1] = flus;
                            select_mas[j, 2] = (select_mas[j, 0] + select_mas[j, 1]) / 2;
                            select_mas[j, 3] = 0;
                            select_mas[j, 4] = 0;
                            j++;
                            flus += temp;
                        }
                    }
                    select_mas[j, 0] = flus-temp;
                    select_mas[j, 1] = flus;
                    select_mas[j, 2] = (select_mas[j, 0] + select_mas[j, 1]) / 2;
                    select_mas[j, 3] = k;
                    select_mas[j, 4] = (double)k / (double)num;
                    j++;
                    flus += temp;
                    Console.WriteLine(j);
                    k = 0;
                }
            }
        }

        private void func_xi()
        {
            double p=0;
            bool temp; 
            Xi1 = 0; Xi2 = 0; Xi3 = 0; Xi4 = 0;
            for(int i=0;i<30;i++)
            {
                if(i<3)
                {
                    p = Math.Exp(4 - 4 * select_mas1[i, 1]) - Math.Exp(4 - 4 * select_mas1[i, 0]); 
                    Xi1 += ((select_mas1[i, 4] - p) * (select_mas1[i, 4] - p)) / p; 
                }
                if(i<6)
                {
                    p = Math.Exp(4 - 4 * select_mas2[i, 1]) - Math.Exp(4 - 4 * select_mas2[i, 0]);
                    Xi2 += ((select_mas2[i, 4] - p) * (select_mas2[i, 4] - p)) / p;
                }

                p = Math.Exp(4 - 4 * select_mas3[i, 1]) - Math.Exp(4 - 4 * select_mas3[i, 0]);
                Xi3 += ((select_mas3[i, 4] - p) * (select_mas3[i, 4] - p)) / p;

                p = Math.Exp(4 - 4 * select_mas4[i, 1]) - Math.Exp(4 - 4 * select_mas4[i, 0]);
                Xi4 += ((select_mas4[i, 4] - p) * (select_mas4[i, 4] - p)) / p;
            }
            Xi1 *= 50; Xi2 *= 100; Xi3 *= 1000; Xi4 *= 100000;
            if (Xi1 < masP[2])
                label9.Text = Convert.ToString("Xi1 = " + Xi1 + "          Удовлетворяет условию");
            else
                label9.Text = Convert.ToString("Xi1 = " + Xi1 + "          Не удовлетворяет условию");
            
            if (Xi2 < masP[5])
                label10.Text = Convert.ToString("Xi2 = " + Xi2 + "          Удовлетворяет условию");
            else
                label10.Text = Convert.ToString("Xi2 = " + Xi2 + "          Не удовлетворяет условию");
            
            if (Xi3 < masP[29])
                label11.Text = Convert.ToString("Xi3 = " + Xi3 + "          Удовлетворяет условию");
            else
                label11.Text = Convert.ToString("Xi3 = " + Xi3 + "          Не удовлетворяет условию");
            
            if (Xi4 < masP[29])
                label12.Text = Convert.ToString("Xi4 = " + Xi4 + "          Удовлетворяет условию");
            else
                label12.Text = Convert.ToString("Xi4 = " + Xi4 + "          Не удовлетворяет условию");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            func_random();
            func_math();
            add_label();
            func_selection();
            DrawGraph();
            func_xi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mas1 = new double[50];
            mas2 = new double[100];
            mas3 = new double[1000];
            mas4 = new double[100000];
            select_mas1 = new double[3, 5];
            select_mas2 = new double[6, 5];
            select_mas3 = new double[30, 5];
            select_mas4 = new double[30, 5];
            masP = new double[30];
            masP[0] = 2.7;  masP[1] = 4.6;  masP[2] = 6.3;  masP[3] = 7.8;  masP[4] = 9.2;
            masP[5] = 10.6; masP[6] = 12;   masP[7] = 13.4; masP[8] = 14.7; masP[9] = 16;
            masP[10]= 17.3; masP[11]= 18.5; masP[12]= 19.8; masP[13]= 21.1; masP[14]= 22.3;
            masP[15]= 23.5; masP[16]= 24.8; masP[17]= 26;   masP[18]= 27.2; masP[19]= 28.4;
            masP[20]= 29.6; masP[21]= 30.8; masP[22]= 32;   masP[23]= 33.2; masP[24]= 34.4;
            masP[25]= 35.6; masP[26]= 36.7; masP[27]= 37.9; masP[28]= 39.4; masP[29]= 40.3;
        }

        private void DrawGraph()
        {
            // Получим панель для рисования
            GraphPane pane1 = zedGraph_1.GraphPane; 
            GraphPane pane2 = zedGraph_2.GraphPane; 
            GraphPane pane3 = zedGraph_3.GraphPane; 
            GraphPane pane4 = zedGraph_4.GraphPane;


            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane1.CurveList.Clear();
            pane2.CurveList.Clear();
            pane3.CurveList.Clear();
            pane4.CurveList.Clear();

            // Подписи под столбиками
            string[] names1 = new string[3];
            string[] names2 = new string[6];
            string[] names3 = new string[30];
            string[] names4 = new string[30];

            // Высота столбиков
            double[] values1 = new double[3];
            double[] values2 = new double[6];
            double[] values3 = new double[30];
            double[] values4 = new double[30];

            // Заполним данные
            for (int i = 0; i < 30; i++)
            {
                if (i < 3)
                {
                    names1[i] = string.Format(select_mas1[i, 1].ToString() , i);
                    values1[i] = select_mas1[i, 4];
                }
                if(i<6)
                {
                    names2[i] = string.Format(select_mas2[i, 1].ToString(), i);
                    values2[i] = select_mas2[i, 4];
                }

                names3[i] = string.Format(select_mas3[i, 1].ToString(), i);
                values3[i] = select_mas3[i, 4];

                names4[i] = string.Format(select_mas4[i, 1].ToString(), i);
                values4[i] = select_mas4[i, 4];
            }

            // Создадим кривую-гистограмму
            // Первый параметр - название кривой для легенды
            // Второй параметр - значения для оси X, т.к. у нас по этой оси будет идти текст, а функция ожидает тип параметра double[], то пока передаем null
            // Третий параметр - значения для оси Y
            // Четвертый параметр - цвет
            BarItem curve1 = pane1.AddBar("Гистограмма выборки 50", null, values1, Color.Blue);
            BarItem curve2 = pane2.AddBar("Гистограмма выборки 100", null, values2, Color.Blue);
            BarItem curve3 = pane3.AddBar("Гистограмма выборки 1000", null, values3, Color.Blue);
            BarItem curve4 = pane4.AddBar("Гистограмма выборки 100000", null, values4, Color.Blue);

            // Настроим ось X так, чтобы она отображала текстовые данные
            pane1.XAxis.Type = AxisType.Text;
            pane2.XAxis.Type = AxisType.Text; 
            pane3.XAxis.Type = AxisType.Text;
            pane4.XAxis.Type = AxisType.Text;

            // Уставим для оси наши подписи
            pane1.XAxis.TextLabels = names1;
            pane2.XAxis.TextLabels = names2;
            pane3.XAxis.TextLabels = names3;
            pane4.XAxis.TextLabels = names4;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 

            zedGraph_1.AxisChange();
            zedGraph_2.AxisChange();
            zedGraph_3.AxisChange();
            zedGraph_4.AxisChange();

            // Обновляем график
            zedGraph_1.Invalidate();
            zedGraph_2.Invalidate();
            zedGraph_3.Invalidate();
            zedGraph_4.Invalidate();
        }
    }
}
