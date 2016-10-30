using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void func()
        {   
            switch (z)
            {
                case 0: y3_1.Image = null; break;
                case 1: y1.Image = null; break;
                case 2: y2.Image = null; break;
                case 3: y3.Image = null; break;
                case 4: y4.Image = null; break;
                case 5: y3_2.Image = null; break;
            }
            if (mas_x[x, z] - 1 == z)
                if (z < 5)
                    z++;
                else
                    z=0;
            else
                z = mas_x[x, z] - 1;
            //label1.Text = Convert.ToString("z"+(z+1));
            if(x==0)
                switch (z)
                {
                    case 0: y3_1.Image = global::Lab2.Properties.Resources._1; break;
                    case 1: y1.Image = global::Lab2.Properties.Resources._1; break;
                    case 2: y2.Image = global::Lab2.Properties.Resources._1; break;
                    case 3: y3.Image = global::Lab2.Properties.Resources._1; break;
                    case 4: y4.Image = global::Lab2.Properties.Resources._1; break;
                    case 5: y3_2.Image = global::Lab2.Properties.Resources._1; break;
                }

                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mas_l[x, temp].Image = null;
            x = 0;
            temp = z;
            mas_l[x, z].Image = global::Lab2.Properties.Resources._2;
            func();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mas_l[x, temp].Image = null;
            x = 1;
            temp = z;
            mas_l[x, z].Image = global::Lab2.Properties.Resources._2;
            func();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mas_l[x, temp].Image = null;
            x = 2;
            temp = z;
            mas_l[x, z].Image = global::Lab2.Properties.Resources._2;
            func();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mas_l[x, temp].Image = null;
            x = 3;
            temp = z;
            mas_l[x, z].Image = global::Lab2.Properties.Resources._2;
            func();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mas_l[x, temp].Image = null;
            x = 4;
            temp = z;
            mas_l[x, z].Image = global::Lab2.Properties.Resources._2;
            func();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mas_l[x, temp].Image = null;
            x = 5;
            temp = z;
            mas_l[x, z].Image = global::Lab2.Properties.Resources._2;
            func();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mas_l[0, 0] = l11; mas_l[0, 1] = l12; mas_l[0, 2] = l13; mas_l[0, 3] = l14; mas_l[0, 4] = l15; mas_l[0, 5] = l16;
            mas_l[1, 0] = l21; mas_l[1, 1] = l22; mas_l[1, 2] = l23; mas_l[1, 3] = l24; mas_l[1, 4] = l25; mas_l[1, 5] = l26;
            mas_l[2, 0] = l31; mas_l[2, 1] = l32; mas_l[2, 2] = l33; mas_l[2, 3] = l34; mas_l[2, 4] = l35; mas_l[2, 5] = l36;
            mas_l[3, 0] = l41; mas_l[3, 1] = l42; mas_l[3, 2] = l34; mas_l[3, 3] = l44; mas_l[3, 4] = l45; mas_l[3, 5] = l46;
            mas_l[4, 0] = l51; mas_l[4, 1] = l52; mas_l[4, 2] = l35; mas_l[4, 3] = l54; mas_l[4, 4] = l55; mas_l[4, 5] = l56;
            mas_l[5, 0] = l61; mas_l[5, 1] = l62; mas_l[5, 2] = l36; mas_l[5, 3] = l64; mas_l[5, 4] = l65; mas_l[5, 5] = l66;
        }
       
    }
}
