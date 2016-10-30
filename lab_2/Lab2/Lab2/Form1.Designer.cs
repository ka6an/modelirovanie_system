using System.Windows.Forms;
namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private int z = 0, x = 0, temp=0;
        private int[,] mas_x = {{1,2,3,4,5,6},{2,3,4,5,6,1},{3,4,5,6,1,2},{4,5,6,1,2,3},{5,6,1,2,3,4},{6,1,2,3,4,5}};
        private Label[,] mas_l = new Label[6, 6];
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.y3_2 = new System.Windows.Forms.Label();
            this.y4 = new System.Windows.Forms.Label();
            this.y3 = new System.Windows.Forms.Label();
            this.y2 = new System.Windows.Forms.Label();
            this.y1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.l11 = new System.Windows.Forms.Label();
            this.l12 = new System.Windows.Forms.Label();
            this.l13 = new System.Windows.Forms.Label();
            this.l14 = new System.Windows.Forms.Label();
            this.l15 = new System.Windows.Forms.Label();
            this.l16 = new System.Windows.Forms.Label();
            this.l21 = new System.Windows.Forms.Label();
            this.l22 = new System.Windows.Forms.Label();
            this.l23 = new System.Windows.Forms.Label();
            this.l24 = new System.Windows.Forms.Label();
            this.l25 = new System.Windows.Forms.Label();
            this.l26 = new System.Windows.Forms.Label();
            this.l31 = new System.Windows.Forms.Label();
            this.l32 = new System.Windows.Forms.Label();
            this.l33 = new System.Windows.Forms.Label();
            this.l34 = new System.Windows.Forms.Label();
            this.l35 = new System.Windows.Forms.Label();
            this.l36 = new System.Windows.Forms.Label();
            this.l41 = new System.Windows.Forms.Label();
            this.l42 = new System.Windows.Forms.Label();
            this.l43 = new System.Windows.Forms.Label();
            this.l44 = new System.Windows.Forms.Label();
            this.l45 = new System.Windows.Forms.Label();
            this.l46 = new System.Windows.Forms.Label();
            this.l51 = new System.Windows.Forms.Label();
            this.l52 = new System.Windows.Forms.Label();
            this.l53 = new System.Windows.Forms.Label();
            this.l54 = new System.Windows.Forms.Label();
            this.l55 = new System.Windows.Forms.Label();
            this.l56 = new System.Windows.Forms.Label();
            this.l61 = new System.Windows.Forms.Label();
            this.l62 = new System.Windows.Forms.Label();
            this.l63 = new System.Windows.Forms.Label();
            this.l64 = new System.Windows.Forms.Label();
            this.l65 = new System.Windows.Forms.Label();
            this.l66 = new System.Windows.Forms.Label();
            this.y3_1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.y3_2, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.y4, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.y3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.y2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.y1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.l11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.l12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.l13, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.l14, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.l15, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.l16, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.l21, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.l22, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.l23, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.l24, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.l25, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.l26, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.l31, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.l32, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.l33, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.l34, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.l35, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.l36, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.l41, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.l42, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.l43, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.l44, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.l45, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.l46, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.l51, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.l52, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.l53, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.l54, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.l55, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.l56, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.l61, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.l62, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.l63, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.l64, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.l65, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.l66, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.y3_1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // y3_2
            // 
            this.y3_2.AutoSize = true;
            this.y3_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.y3_2.Location = new System.Drawing.Point(417, 0);
            this.y3_2.Name = "y3_2";
            this.y3_2.Size = new System.Drawing.Size(64, 37);
            this.y3_2.TabIndex = 48;
            this.y3_2.Text = "Y3=Z6";
            this.y3_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // y4
            // 
            this.y4.AutoSize = true;
            this.y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.y4.Location = new System.Drawing.Point(348, 0);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(63, 37);
            this.y4.TabIndex = 47;
            this.y4.Text = "Y4 = Z5";
            this.y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // y3
            // 
            this.y3.AutoSize = true;
            this.y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.y3.Location = new System.Drawing.Point(279, 0);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(63, 37);
            this.y3.TabIndex = 46;
            this.y3.Text = "Y3 = Z4";
            this.y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // y2
            // 
            this.y2.AutoSize = true;
            this.y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.y2.Location = new System.Drawing.Point(210, 0);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(63, 37);
            this.y2.TabIndex = 45;
            this.y2.Text = "Y2 = Z3";
            this.y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // y1
            // 
            this.y1.AutoSize = true;
            this.y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.y1.Location = new System.Drawing.Point(141, 0);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(63, 37);
            this.y1.TabIndex = 44;
            this.y1.Text = "Y1 = Z2";
            this.y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(3, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "X2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "X1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(3, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "X3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(3, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 31);
            this.button4.TabIndex = 3;
            this.button4.Text = "X4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(3, 188);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 31);
            this.button5.TabIndex = 4;
            this.button5.Text = "X5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(3, 225);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "X6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Автомат Мура";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l11
            // 
            this.l11.AutoSize = true;
            this.l11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l11.Image = global::Lab2.Properties.Resources._2;
            this.l11.Location = new System.Drawing.Point(72, 37);
            this.l11.Name = "l11";
            this.l11.Size = new System.Drawing.Size(63, 37);
            this.l11.TabIndex = 7;
            this.l11.Text = "Z1";
            this.l11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l12
            // 
            this.l12.AutoSize = true;
            this.l12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l12.Location = new System.Drawing.Point(141, 37);
            this.l12.Name = "l12";
            this.l12.Size = new System.Drawing.Size(63, 37);
            this.l12.TabIndex = 8;
            this.l12.Text = "Z2";
            this.l12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l13
            // 
            this.l13.AutoSize = true;
            this.l13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l13.Location = new System.Drawing.Point(210, 37);
            this.l13.Name = "l13";
            this.l13.Size = new System.Drawing.Size(63, 37);
            this.l13.TabIndex = 9;
            this.l13.Text = "Z3";
            this.l13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l14
            // 
            this.l14.AutoSize = true;
            this.l14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l14.Location = new System.Drawing.Point(279, 37);
            this.l14.Name = "l14";
            this.l14.Size = new System.Drawing.Size(63, 37);
            this.l14.TabIndex = 10;
            this.l14.Text = "Z4";
            this.l14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l15
            // 
            this.l15.AutoSize = true;
            this.l15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l15.Location = new System.Drawing.Point(348, 37);
            this.l15.Name = "l15";
            this.l15.Size = new System.Drawing.Size(63, 37);
            this.l15.TabIndex = 11;
            this.l15.Text = "Z5";
            this.l15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l16
            // 
            this.l16.AutoSize = true;
            this.l16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l16.Location = new System.Drawing.Point(417, 37);
            this.l16.Name = "l16";
            this.l16.Size = new System.Drawing.Size(64, 37);
            this.l16.TabIndex = 12;
            this.l16.Text = "Z6";
            this.l16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l21
            // 
            this.l21.AutoSize = true;
            this.l21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l21.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l21.Location = new System.Drawing.Point(72, 74);
            this.l21.Name = "l21";
            this.l21.Size = new System.Drawing.Size(63, 37);
            this.l21.TabIndex = 13;
            this.l21.Text = "Z2";
            this.l21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l22
            // 
            this.l22.AutoSize = true;
            this.l22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l22.Location = new System.Drawing.Point(141, 74);
            this.l22.Name = "l22";
            this.l22.Size = new System.Drawing.Size(63, 37);
            this.l22.TabIndex = 14;
            this.l22.Text = "Z3";
            this.l22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l23
            // 
            this.l23.AutoSize = true;
            this.l23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l23.Location = new System.Drawing.Point(210, 74);
            this.l23.Name = "l23";
            this.l23.Size = new System.Drawing.Size(63, 37);
            this.l23.TabIndex = 15;
            this.l23.Text = "Z4";
            this.l23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l24
            // 
            this.l24.AutoSize = true;
            this.l24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l24.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l24.Location = new System.Drawing.Point(279, 74);
            this.l24.Name = "l24";
            this.l24.Size = new System.Drawing.Size(63, 37);
            this.l24.TabIndex = 16;
            this.l24.Text = "Z5";
            this.l24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l25
            // 
            this.l25.AutoSize = true;
            this.l25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l25.Location = new System.Drawing.Point(348, 74);
            this.l25.Name = "l25";
            this.l25.Size = new System.Drawing.Size(63, 37);
            this.l25.TabIndex = 17;
            this.l25.Text = "Z6";
            this.l25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l26
            // 
            this.l26.AutoSize = true;
            this.l26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l26.Location = new System.Drawing.Point(417, 74);
            this.l26.Name = "l26";
            this.l26.Size = new System.Drawing.Size(64, 37);
            this.l26.TabIndex = 18;
            this.l26.Text = "Z1";
            this.l26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l31
            // 
            this.l31.AutoSize = true;
            this.l31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l31.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l31.Location = new System.Drawing.Point(72, 111);
            this.l31.Name = "l31";
            this.l31.Size = new System.Drawing.Size(63, 37);
            this.l31.TabIndex = 19;
            this.l31.Text = "Z3";
            this.l31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l32
            // 
            this.l32.AutoSize = true;
            this.l32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l32.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l32.Location = new System.Drawing.Point(141, 111);
            this.l32.Name = "l32";
            this.l32.Size = new System.Drawing.Size(63, 37);
            this.l32.TabIndex = 20;
            this.l32.Text = "Z4";
            this.l32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l33
            // 
            this.l33.AutoSize = true;
            this.l33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l33.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l33.Location = new System.Drawing.Point(210, 111);
            this.l33.Name = "l33";
            this.l33.Size = new System.Drawing.Size(63, 37);
            this.l33.TabIndex = 21;
            this.l33.Text = "Z5";
            this.l33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l34
            // 
            this.l34.AutoSize = true;
            this.l34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l34.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l34.Location = new System.Drawing.Point(279, 111);
            this.l34.Name = "l34";
            this.l34.Size = new System.Drawing.Size(63, 37);
            this.l34.TabIndex = 22;
            this.l34.Text = "Z6";
            this.l34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l35
            // 
            this.l35.AutoSize = true;
            this.l35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l35.Location = new System.Drawing.Point(348, 111);
            this.l35.Name = "l35";
            this.l35.Size = new System.Drawing.Size(63, 37);
            this.l35.TabIndex = 23;
            this.l35.Text = "Z1";
            this.l35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l36
            // 
            this.l36.AutoSize = true;
            this.l36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l36.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l36.Location = new System.Drawing.Point(417, 111);
            this.l36.Name = "l36";
            this.l36.Size = new System.Drawing.Size(64, 37);
            this.l36.TabIndex = 24;
            this.l36.Text = "Z2";
            this.l36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l41
            // 
            this.l41.AutoSize = true;
            this.l41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l41.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l41.Location = new System.Drawing.Point(72, 148);
            this.l41.Name = "l41";
            this.l41.Size = new System.Drawing.Size(63, 37);
            this.l41.TabIndex = 25;
            this.l41.Text = "Z4";
            this.l41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l42
            // 
            this.l42.AutoSize = true;
            this.l42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l42.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l42.Location = new System.Drawing.Point(141, 148);
            this.l42.Name = "l42";
            this.l42.Size = new System.Drawing.Size(63, 37);
            this.l42.TabIndex = 26;
            this.l42.Text = "Z5";
            this.l42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l43
            // 
            this.l43.AutoSize = true;
            this.l43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l43.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l43.Location = new System.Drawing.Point(210, 148);
            this.l43.Name = "l43";
            this.l43.Size = new System.Drawing.Size(63, 37);
            this.l43.TabIndex = 27;
            this.l43.Text = "Z6";
            this.l43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l44
            // 
            this.l44.AutoSize = true;
            this.l44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l44.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l44.Location = new System.Drawing.Point(279, 148);
            this.l44.Name = "l44";
            this.l44.Size = new System.Drawing.Size(63, 37);
            this.l44.TabIndex = 28;
            this.l44.Text = "Z1";
            this.l44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l45
            // 
            this.l45.AutoSize = true;
            this.l45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l45.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l45.Location = new System.Drawing.Point(348, 148);
            this.l45.Name = "l45";
            this.l45.Size = new System.Drawing.Size(63, 37);
            this.l45.TabIndex = 29;
            this.l45.Text = "Z2";
            this.l45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l46
            // 
            this.l46.AutoSize = true;
            this.l46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l46.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l46.Location = new System.Drawing.Point(417, 148);
            this.l46.Name = "l46";
            this.l46.Size = new System.Drawing.Size(64, 37);
            this.l46.TabIndex = 30;
            this.l46.Text = "Z3";
            this.l46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l51
            // 
            this.l51.AutoSize = true;
            this.l51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l51.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l51.Location = new System.Drawing.Point(72, 185);
            this.l51.Name = "l51";
            this.l51.Size = new System.Drawing.Size(63, 37);
            this.l51.TabIndex = 31;
            this.l51.Text = "Z5";
            this.l51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l52
            // 
            this.l52.AutoSize = true;
            this.l52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l52.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l52.Location = new System.Drawing.Point(141, 185);
            this.l52.Name = "l52";
            this.l52.Size = new System.Drawing.Size(63, 37);
            this.l52.TabIndex = 32;
            this.l52.Text = "Z6";
            this.l52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l53
            // 
            this.l53.AutoSize = true;
            this.l53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l53.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l53.Location = new System.Drawing.Point(210, 185);
            this.l53.Name = "l53";
            this.l53.Size = new System.Drawing.Size(63, 37);
            this.l53.TabIndex = 33;
            this.l53.Text = "Z1";
            this.l53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l54
            // 
            this.l54.AutoSize = true;
            this.l54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l54.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l54.Location = new System.Drawing.Point(279, 185);
            this.l54.Name = "l54";
            this.l54.Size = new System.Drawing.Size(63, 37);
            this.l54.TabIndex = 34;
            this.l54.Text = "Z2";
            this.l54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l55
            // 
            this.l55.AutoSize = true;
            this.l55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l55.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l55.Location = new System.Drawing.Point(348, 185);
            this.l55.Name = "l55";
            this.l55.Size = new System.Drawing.Size(63, 37);
            this.l55.TabIndex = 35;
            this.l55.Text = "Z3";
            this.l55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l56
            // 
            this.l56.AutoSize = true;
            this.l56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l56.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l56.Location = new System.Drawing.Point(417, 185);
            this.l56.Name = "l56";
            this.l56.Size = new System.Drawing.Size(64, 37);
            this.l56.TabIndex = 36;
            this.l56.Text = "Z4";
            this.l56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l61
            // 
            this.l61.AutoSize = true;
            this.l61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l61.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l61.Location = new System.Drawing.Point(72, 222);
            this.l61.Name = "l61";
            this.l61.Size = new System.Drawing.Size(63, 40);
            this.l61.TabIndex = 37;
            this.l61.Text = "Z6";
            this.l61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l62
            // 
            this.l62.AutoSize = true;
            this.l62.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l62.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l62.Location = new System.Drawing.Point(141, 222);
            this.l62.Name = "l62";
            this.l62.Size = new System.Drawing.Size(63, 40);
            this.l62.TabIndex = 38;
            this.l62.Text = "Z1";
            this.l62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l63
            // 
            this.l63.AutoSize = true;
            this.l63.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l63.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l63.Location = new System.Drawing.Point(210, 222);
            this.l63.Name = "l63";
            this.l63.Size = new System.Drawing.Size(63, 40);
            this.l63.TabIndex = 39;
            this.l63.Text = "Z2";
            this.l63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l64
            // 
            this.l64.AutoSize = true;
            this.l64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l64.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l64.Location = new System.Drawing.Point(279, 222);
            this.l64.Name = "l64";
            this.l64.Size = new System.Drawing.Size(63, 40);
            this.l64.TabIndex = 40;
            this.l64.Text = "Z3";
            this.l64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l65
            // 
            this.l65.AutoSize = true;
            this.l65.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l65.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l65.Location = new System.Drawing.Point(348, 222);
            this.l65.Name = "l65";
            this.l65.Size = new System.Drawing.Size(63, 40);
            this.l65.TabIndex = 41;
            this.l65.Text = "Z4";
            this.l65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l66
            // 
            this.l66.AutoSize = true;
            this.l66.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l66.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l66.Location = new System.Drawing.Point(417, 222);
            this.l66.Name = "l66";
            this.l66.Size = new System.Drawing.Size(64, 40);
            this.l66.TabIndex = 42;
            this.l66.Text = "Z5";
            this.l66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // y3_1
            // 
            this.y3_1.AutoSize = true;
            this.y3_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.y3_1.Image = global::Lab2.Properties.Resources._1;
            this.y3_1.Location = new System.Drawing.Point(72, 0);
            this.y3_1.Name = "y3_1";
            this.y3_1.Size = new System.Drawing.Size(63, 37);
            this.y3_1.TabIndex = 43;
            this.y3_1.Text = "Y3 = Z1";
            this.y3_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Автомат Мура";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l11;
        private System.Windows.Forms.Label l12;
        private System.Windows.Forms.Label l13;
        private System.Windows.Forms.Label l14;
        private System.Windows.Forms.Label l15;
        private System.Windows.Forms.Label l16;
        private System.Windows.Forms.Label l21;
        private System.Windows.Forms.Label l22;
        private System.Windows.Forms.Label l23;
        private System.Windows.Forms.Label l24;
        private System.Windows.Forms.Label l25;
        private System.Windows.Forms.Label l26;
        private System.Windows.Forms.Label l31;
        private System.Windows.Forms.Label l32;
        private System.Windows.Forms.Label l33;
        private System.Windows.Forms.Label l34;
        private System.Windows.Forms.Label l35;
        private System.Windows.Forms.Label l36;
        private System.Windows.Forms.Label l41;
        private System.Windows.Forms.Label l42;
        private System.Windows.Forms.Label l43;
        private System.Windows.Forms.Label l44;
        private System.Windows.Forms.Label l45;
        private System.Windows.Forms.Label l46;
        private System.Windows.Forms.Label l51;
        private System.Windows.Forms.Label l52;
        private System.Windows.Forms.Label l53;
        private System.Windows.Forms.Label l54;
        private System.Windows.Forms.Label l55;
        private System.Windows.Forms.Label l56;
        private System.Windows.Forms.Label l61;
        private System.Windows.Forms.Label l62;
        private System.Windows.Forms.Label l63;
        private System.Windows.Forms.Label l64;
        private System.Windows.Forms.Label l65;
        private System.Windows.Forms.Label l66;
        private Label y3_2;
        private Label y4;
        private Label y3;
        private Label y2;
        private Label y1;
        private Label y3_1;

        }
}

