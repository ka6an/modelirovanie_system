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


namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void func_filter()
        {
            Random rand = new Random();
            double x = 0, R = 0;
            mas1[0] = 0;
            for (int i = 1; i < N; i++)
            {
                for (int k = 0; k < 12; k++)
                    R += rand.NextDouble();
                R -= 6;
                x = mas1[i - 1] + ((-mas1[i - 1]) / t_f + (k_f / t_f) * R) * h;
                mas1[i] = x;
                R = 0;
            }
        }

        private void func_ravn()
        {
            double f, temp;
            int j;
            for (int i = 0; i < N; i++)
            {
                temp = f = 1;
                j = 1;
                while (Math.Abs(temp) > 1e-5)
                {
                    temp *= -mas1[i] * mas1[i] * (2 * j - 1) / (double)(2 * (2 * j + 1) * j);
                    f += temp;
                    j++;
                }
                mas2[i] = (f * mas1[i] / Math.Sqrt(2 * Math.PI)) + 0.5;
            }
        }

        private void func_obr_frv()
        {
            for (int i = 0; i < N; i++)
                mas3[i] = 1 - (Math.Log(1 - mas2[i])) / 4;
        }

        private void DrawGraph_stat_s(double[] mas1, double[] mas2)
        {
            // Получим панель для рисования
            double[] m1 = new double[M]; 
            double temp;
            GraphPane pane1 = zedGraph1_1.GraphPane;
            pane1.Title = Convert.ToString(" ");
            pane1.XAxis.Title = Convert.ToString("");
            pane1.YAxis.Title = Convert.ToString("");
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane1.CurveList.Clear();

            // Создадим список точек
            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();
            // Заполняем список точек
            for (int j = 0; j < M; j++)
            {
                //Console.WriteLine(mas_1[j]);
                list1.Add(mas1[j], (double)j / M);
                list2.Add(mas2[j], (double)j / M);
                if (j != M - 1)
                {
                    list1.Add(mas1[j + 1], (double)j / M);
                    list2.Add(mas2[j + 1], (double)j / M);
                }
                else
                {
                    list1.Add(mas1[j], (double)j / M);
                    list2.Add(mas2[j], (double)j / M);
                }
                m1[j] = (double)j / M;
            }
            // Создадим кривую с названием "Sinc", 
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve1 = pane1.AddCurve("t=10sec.", list1, Color.Blue, SymbolType.None);
            LineItem myCurve2 = pane1.AddCurve("t=15sec", list2, Color.Red, SymbolType.None);

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraph1_1.AxisChange();

            // Обновляем график
            zedGraph1_1.Invalidate();
            temp = func_max_delta(m1, mas1, mas2, M)*Math.Sqrt(M*M/(M+M));
            if(temp > 1.22)
                pane1.XAxis.Title = Convert.ToString("Лямбда = " + temp + " --> Не удовлетворяет");
            else
                pane1.XAxis.Title = Convert.ToString("Лямбда = " + temp + " --> Удовлетворяет");
        }
        private void DrawGraph_stat_e(double[] mas1, double[] mas2)
        {
            // Получим панель для рисования
            int n = 100;
            double temp;
            double[] m1, m2;
            m1 = new double[M];
            m2 = new double[M];

            GraphPane pane1 = zedGraph1_2.GraphPane;
            pane1.Title = Convert.ToString(" ");
            pane1.XAxis.Title = Convert.ToString("");
            pane1.YAxis.Title = Convert.ToString("");
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane1.CurveList.Clear();

            // Создадим список точек
            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();
            // Заполняем список точек
            for (int j = 0; j < M; j++)
            {
                //Console.WriteLine(mas_1[j]);
                list1.Add(mas1[j], (double)j / M);
                if (j != M - 1)
                {
                    list1.Add(mas1[j + 1], (double)j / M);
                }
                else
                {
                    list1.Add(mas1[j], (double)j / M);
                }
                m1[j] = (double)j / M;
            }
            for (int j = 0, i=0; j < N; j+=n, i++)
            {
                //Console.WriteLine(mas_1[j]);
                list2.Add(mas2[j], (double)j / N);
                if (j != N - n)
                {
                    list2.Add(mas2[j + n], (double)j / N);
                }
                else
                {
                    list2.Add(mas2[j], (double)j / N);
                }
                m2[i] = mas2[j];
            }
            // Создадим кривую с названием "Sinc", 
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve1 = pane1.AddCurve("t=10sec.", list1, Color.Blue, SymbolType.None);
            LineItem myCurve2 = pane1.AddCurve("Выборка", list2, Color.Red, SymbolType.None);

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraph1_2.AxisChange();

            // Обновляем график
            zedGraph1_2.Invalidate();
            temp = func_max_delta(m1, m2, mas1, M) * Math.Sqrt(M * M / (M + M));
            if (temp > 1.22)
                pane1.XAxis.Title = Convert.ToString("Лямбда = " + temp + " --> Не удовлетворяет");
            else
                pane1.XAxis.Title = Convert.ToString("Лямбда = " + temp + " --> Удовлетворяет");
            //pane1.XAxis.Title = Convert.ToString("Лямбда = " + func_max_delta(m1,m2, mas1, M)*Math.Sqrt(M*M/(M+M)));
        }

        private double func_max_delta(double[] m1, double[] mas1, double[] mas2, int n)
        {
            double delta_1 = 0;
            int count_1 = 0, count_2 = 0;
            while (count_1 + 1 < n || count_2 + 1 < n)
            {
                double x1 = count_1 + 1 >= n? 99999 : mas1[count_1 + 1];
                double x2 = count_2 + 1 >= n? 99999 : mas2[count_2 + 1];
                if (x1 < x2)
                    count_1++;
                else
                    count_2++;
                delta_1 = Math.Max(delta_1, Math.Abs(m1[count_1] - m1[count_2]));
                //Console.WriteLine(m1[count_1]);
            }
            return delta_1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < M; i++)
            {
                func_filter();
                func_ravn();
                func_obr_frv();
                mas_1[i] = mas3[1999];
                mas_2[i] = mas3[2999];
                //Console.WriteLine(mas_1[i]);
            }
            Array.Sort(mas_1);
            Array.Sort(mas_2);
            DrawGraph_stat_s(mas_1, mas_2);
            Array.Sort(mas3);
            DrawGraph_stat_e(mas_1, mas3);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            d = 1;
            m = 0;
            s_0 = h;
            t_f = 1 / alpha;
            k_f = Math.Sqrt((2 * d) / (alpha * s_0));
            select_mas = new double[30, 5];
            mas1 = new double[N];
            mas2 = new double[N];
            mas3 = new double[N];
            mas4 = new double[N];
            mas_1 = new double[M];
            mas_2 = new double[M];
            masP = new double[30];
            masP[0] = 2.7; masP[1] = 4.6; masP[2] = 6.3; masP[3] = 7.8; masP[4] = 9.2;
            masP[5] = 10.6; masP[6] = 12; masP[7] = 13.4; masP[8] = 14.7; masP[9] = 16;
            masP[10] = 17.3; masP[11] = 18.5; masP[12] = 19.8; masP[13] = 21.1; masP[14] = 22.3;
            masP[15] = 23.5; masP[16] = 24.8; masP[17] = 26; masP[18] = 27.2; masP[19] = 28.4;
            masP[20] = 29.6; masP[21] = 30.8; masP[22] = 32; masP[23] = 33.2; masP[24] = 34.4;
            masP[25] = 35.6; masP[26] = 36.7; masP[27] = 37.9; masP[28] = 39.4; masP[29] = 40.3;
        }

        
    }
}