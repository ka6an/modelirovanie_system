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

namespace lab5
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
            double x = 0, R=0;
            mas1[0] = 0;
            for (int i = 1; i < N; i++)
            {
                for (int j = 0; j < 12; j++)
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
                mas2[i] = (f * mas1[i] / Math.Sqrt(2 * Math.PI))+0.5;
            }
        }

        private void func_obr_frv()
        {
            int firstM= (int)(3*t_f/h);
            int firstD = (int)(1.5 * t_f / h);
            int NM = N - firstM;
            int ND = N - firstD;
            double m_temp=0, d_temp=0;
            for (int i = 0; i < N; i++) 
                mas3[i] = 1- (Math.Log(1 - mas2[i])) / 4; 
                //Console.WriteLine(mas2[i] + "  " + mas3[i]);
            for(int i=firstM; i<N;i++)
                m_temp += mas3[i];
            for (int i = firstD; i<N; i++)
                d_temp += mas3[i] * mas3[i];

            d = d_temp / (ND-1);
            m = m_temp / NM;
            //Console.WriteLine(m + "  " + d);
            label3.Text = d.ToString();

        }

        private void DrawGraph_func_kor(double[] mas, ZedGraphControl zedGraph)
        {
            // Получим панель для рисования
            double temp = 0;

            GraphPane pane1 = zedGraph.GraphPane;
            pane1.Title = Convert.ToString(" ");
            pane1.XAxis.Title = Convert.ToString("T");
            pane1.YAxis.Title = Convert.ToString("D");
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane1.CurveList.Clear();

            // Создадим список точек
            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();
            // Заполняем список точек
            for (int j = 0; j < 400; j++)
            {
                for (int i = 0; i < N - j; i++)
                {
                    temp += (mas[i] - m) * (mas[i + j] - m);
                }
                //Console.WriteLine("temp " + temp);
                temp *= (double)1 / (N + 1 - j);
                //Console.WriteLine(temp);
                
                // добавим в список точку
                list1.Add(j * h, temp);
                list2.Add(j * h, d*Math.Exp(-j * h * alpha));
                temp = 0;
            }
            // Создадим кривую с названием "Sinc", 
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve1 = pane1.AddCurve("Практическая", list1, Color.Blue, SymbolType.None);
            LineItem myCurve2 = pane1.AddCurve("Теоритическая", list2, Color.Red, SymbolType.None);

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }

        private void DrawGraph_func_zak_rasp(double[,] mas, ZedGraphControl zedGraph)
        {
            // Получим панель для рисования
            GraphPane pane1 = zedGraph.GraphPane; 


            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane1.CurveList.Clear();
            
            // Подписи под столбиками
            string[] names = new string[30];

            // Высота столбиков
            double[] values = new double[30];

            // Заполним данные
            for (int i = 0; i < 30; i++)
            {
                names[i] = string.Format(mas[i, 1].ToString() , i);
                values[i] = mas[i, 4];   
            }

            // Создадим кривую-гистограмму
            // Первый параметр - название кривой для легенды
            // Второй параметр - значения для оси X, т.к. у нас по этой оси будет идти текст, а функция ожидает тип параметра double[], то пока передаем null
            // Третий параметр - значения для оси Y
            // Четвертый параметр - цвет
            BarItem curve1 = pane1.AddBar("Гистограмма выборки 200000", null, values, Color.Blue);

            // Настроим ось X так, чтобы она отображала текстовые данные
            pane1.XAxis.Type = AxisType.Text;

            // Уставим для оси наши подписи
            pane1.XAxis.TextLabels = names;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            zedGraph.AxisChange();
            
            // Обновляем график
            zedGraph.Invalidate();
        }

        private void func_zak_rasp(double[] mas, Label label, ZedGraphControl zedGraph)
        {
            Array.Copy(mas, mas4, N);
            Array.Sort(mas4);
            double flus;
            double p = 0, Xi = 0;
            //создание таблицы
            flus = (mas4[N - 1] - mas4[0]) / 30;
            Console.WriteLine(N + " " + mas4[N - 1] + " " + mas4[0] + " " + flus);
            for (int j = 0; j < 30; j++)
            {
                select_mas[j, 0] = mas4[N-1]; 
                select_mas[j, 1] = mas4[0];
                select_mas[j, 2] = 0;
                select_mas[j, 3] = 0;
                select_mas[j, 4] = 0;
            }
            for (int i = 0; i < N; i+=400)
                for (int j = 0; j < 30; j++ )
                    if (mas4[i] >= mas4[0] + j * flus && mas4[i] < mas4[0] + (j + 1) * flus)
                    {
                        if (mas4[i] < select_mas[j, 0])
                            select_mas[j, 0] = mas4[i];
                        if (mas4[i] > select_mas[j, 1])
                            select_mas[j, 1] = mas4[i];
                        select_mas[j,3]++;
                        break;
                    }
            for (int j = 0; j < 30; j++) 
            {
                select_mas[j, 2] = (select_mas[j, 0] + select_mas[j, 1]) / 2;
                select_mas[j, 4] = select_mas[j, 3] / N;
            }
            DrawGraph_func_zak_rasp(select_mas, zedGraph);
            //Проверка условия
            double temp1, temp0, f1, f0;
            Xi = 0;
            for (int i = 0, j=1; i < 30; i++)
            {
                if(label == label1)
                {
                    temp1 = temp0 = f1 = f0 = 1;j = 1;
                    while (Math.Abs(temp1) > 1e-5)
                    {
                        temp1 *= -select_mas[i,1] * select_mas[i,1] * (2 * j - 1) / (double)(2 * (2 * j + 1) * j);
                        f1 += temp1;
                        temp0 *= -select_mas[i,0] * select_mas[i,0] * (2 * j - 1) / (double)(2 * (2 * j + 1) * j);
                        f0 += temp0;
                        j++;
                    }
                    p = (f1 * select_mas[i,1] / Math.Sqrt(2 * Math.PI)) - (f0 * select_mas[i,0] / Math.Sqrt(2 * Math.PI));
                }
                else
                    if(label ==label2)
                        p = select_mas[i, 1] - select_mas[i, 0]; 
                    else
                        p = Math.Exp(4 - 4 * select_mas[i, 1]) - Math.Exp(4 - 4 * select_mas[i, 0]); 
                
                if(p!=0)
                    Xi += ((select_mas[i, 4] - p) * (select_mas[i, 4] - p)) / p;
                //Console.WriteLine(p);
            }
            Xi *= 50;
            if (Xi < masP[29])
                label.Text = Convert.ToString("Xi = " + Xi + "          Удовлетворяет условию");
            else
                label.Text = Convert.ToString("Xi = " + Xi + "          Не удовлетворяет условию");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(k_f + "  " + );
            func_filter();
            d = 1;
            m = 0;
            DrawGraph_func_kor(mas1, zedGraph1_1);
            func_zak_rasp(mas1, label1, zedGraph1_2);
            func_ravn();
            d = 1.0 / 12.0;
            m = 0.5;
            DrawGraph_func_kor(mas2, zedGraph2_1);
            func_zak_rasp(mas2, label2, zedGraph2_2);
            func_obr_frv();
            d = 0.060788;
            DrawGraph_func_kor(mas3 , zedGraph3_1);
            func_zak_rasp(mas3, label3, zedGraph3_2);
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