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

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s_0 =  h/12;
            t_f = 1 / alpha;
            k_f = Math.Sqrt((2 * d) / (alpha * s_0));
            mas = new double[N];
        }

        private void DrawGraph()
        {
            // Получим панель для рисования
            double temp=0;

            GraphPane pane1 = zedGraph.GraphPane;
            pane1.Title = Convert.ToString(" ");
            pane1.XAxis.Title = Convert.ToString("D");
            pane1.YAxis.Title = Convert.ToString("T");
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
                    temp += mas[i] * mas[i + j];
                }
                //Console.WriteLine("temp " + temp);
                temp *= (double)1/(N+1-j);
                //Console.WriteLine(temp);
                
                // добавим в список точку
                list1.Add(j *  h, temp);
                list2.Add(j *  h, 2*Math.Exp(-j * h * alpha));
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

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double x=0;
            mas[0]=0;
            for(int i=1;i<N;i++)
            {
                x = mas[i-1] + ((-mas[i-1]) / t_f + (k_f / t_f) * (rand.NextDouble() - 0.5))*h;
                mas[i] = x;
            }
            //for (int i = 0; i < 200; i++)
            //    Console.WriteLine(mas[i]);
            DrawGraph();
        }
    }
}
