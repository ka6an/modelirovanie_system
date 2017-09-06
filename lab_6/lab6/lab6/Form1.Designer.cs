using ZedGraph;

namespace lab6
{

    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private double[] mas1, mas2, mas3, mas4, mas_1, mas_2, masP;
        private double[,] select_mas;
        private int N = 10000, M = 100;
        private double alpha = 1.5, h = 0.005, d, m, s_0, k_f, t_f;
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1_1 = new System.Windows.Forms.TabPage();
            this.zedGraph1_1 = new ZedGraph.ZedGraphControl();
            this.tabPage1_2 = new System.Windows.Forms.TabPage();
            this.zedGraph1_2 = new ZedGraph.ZedGraphControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1_1.SuspendLayout();
            this.tabPage1_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1_1);
            this.tabControl1.Controls.Add(this.tabPage1_2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 400);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1_1
            // 
            this.tabPage1_1.Controls.Add(this.zedGraph1_1);
            this.tabPage1_1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1_1.Name = "tabPage1_1";
            this.tabPage1_1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1_1.Size = new System.Drawing.Size(526, 374);
            this.tabPage1_1.TabIndex = 0;
            this.tabPage1_1.Text = "Стационарность";
            this.tabPage1_1.UseVisualStyleBackColor = true;
            // 
            // zedGraph1_1
            // 
            this.zedGraph1_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraph1_1.IsShowPointValues = false;
            this.zedGraph1_1.Location = new System.Drawing.Point(3, 3);
            this.zedGraph1_1.Name = "zedGraph1_1";
            this.zedGraph1_1.PointValueFormat = "G";
            this.zedGraph1_1.Size = new System.Drawing.Size(520, 368);
            this.zedGraph1_1.TabIndex = 2;
            // 
            // tabPage1_2
            // 
            this.tabPage1_2.Controls.Add(this.zedGraph1_2);
            this.tabPage1_2.Location = new System.Drawing.Point(4, 22);
            this.tabPage1_2.Name = "tabPage1_2";
            this.tabPage1_2.Size = new System.Drawing.Size(526, 374);
            this.tabPage1_2.TabIndex = 3;
            this.tabPage1_2.Text = "Эргодичность";
            this.tabPage1_2.UseVisualStyleBackColor = true;
            // 
            // zedGraph1_2
            // 
            this.zedGraph1_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraph1_2.IsShowPointValues = false;
            this.zedGraph1_2.Location = new System.Drawing.Point(0, 0);
            this.zedGraph1_2.Name = "zedGraph1_2";
            this.zedGraph1_2.PointValueFormat = "G";
            this.zedGraph1_2.Size = new System.Drawing.Size(526, 374);
            this.zedGraph1_2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 422);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1_1.ResumeLayout(false);
            this.tabPage1_2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1_1;
        private System.Windows.Forms.TabPage tabPage1_2;
        private ZedGraphControl zedGraph1_1;
        private ZedGraphControl zedGraph1_2;
    }
}

