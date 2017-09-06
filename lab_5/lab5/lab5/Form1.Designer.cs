using ZedGraph;

namespace lab5
{

    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private double[] mas1, mas2, mas3, mas4, masP;
        private double[,] select_mas;
        private int N = 200000;
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
            this.label1 = new System.Windows.Forms.Label();
            this.zedGraph1_2 = new ZedGraph.ZedGraphControl();
            this.tabPage2_1 = new System.Windows.Forms.TabPage();
            this.zedGraph2_1 = new ZedGraph.ZedGraphControl();
            this.tabPage2_2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.zedGraph2_2 = new ZedGraph.ZedGraphControl();
            this.tabPage3_1 = new System.Windows.Forms.TabPage();
            this.zedGraph3_1 = new ZedGraph.ZedGraphControl();
            this.tabPage3_2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.zedGraph3_2 = new ZedGraph.ZedGraphControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1_1.SuspendLayout();
            this.tabPage1_2.SuspendLayout();
            this.tabPage2_1.SuspendLayout();
            this.tabPage2_2.SuspendLayout();
            this.tabPage3_1.SuspendLayout();
            this.tabPage3_2.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage2_1);
            this.tabControl1.Controls.Add(this.tabPage2_2);
            this.tabControl1.Controls.Add(this.tabPage3_1);
            this.tabControl1.Controls.Add(this.tabPage3_2);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
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
            this.tabPage1_1.Text = "Проверка1_1";
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
            this.tabPage1_2.Controls.Add(this.label1);
            this.tabPage1_2.Controls.Add(this.zedGraph1_2);
            this.tabPage1_2.Location = new System.Drawing.Point(4, 22);
            this.tabPage1_2.Name = "tabPage1_2";
            this.tabPage1_2.Size = new System.Drawing.Size(526, 374);
            this.tabPage1_2.TabIndex = 3;
            this.tabPage1_2.Text = "Проверка1_2";
            this.tabPage1_2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label2";
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
            // tabPage2_1
            // 
            this.tabPage2_1.Controls.Add(this.zedGraph2_1);
            this.tabPage2_1.Location = new System.Drawing.Point(4, 22);
            this.tabPage2_1.Name = "tabPage2_1";
            this.tabPage2_1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2_1.Size = new System.Drawing.Size(526, 374);
            this.tabPage2_1.TabIndex = 1;
            this.tabPage2_1.Text = "Проверка2_1";
            this.tabPage2_1.UseVisualStyleBackColor = true;
            // 
            // zedGraph2_1
            // 
            this.zedGraph2_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraph2_1.IsShowPointValues = false;
            this.zedGraph2_1.Location = new System.Drawing.Point(3, 3);
            this.zedGraph2_1.Name = "zedGraph2_1";
            this.zedGraph2_1.PointValueFormat = "G";
            this.zedGraph2_1.Size = new System.Drawing.Size(520, 368);
            this.zedGraph2_1.TabIndex = 3;
            // 
            // tabPage2_2
            // 
            this.tabPage2_2.Controls.Add(this.label2);
            this.tabPage2_2.Controls.Add(this.zedGraph2_2);
            this.tabPage2_2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2_2.Name = "tabPage2_2";
            this.tabPage2_2.Size = new System.Drawing.Size(526, 374);
            this.tabPage2_2.TabIndex = 4;
            this.tabPage2_2.Text = "Проверка2_2";
            this.tabPage2_2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label3";
            // 
            // zedGraph2_2
            // 
            this.zedGraph2_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraph2_2.IsShowPointValues = false;
            this.zedGraph2_2.Location = new System.Drawing.Point(0, 0);
            this.zedGraph2_2.Name = "zedGraph2_2";
            this.zedGraph2_2.PointValueFormat = "G";
            this.zedGraph2_2.Size = new System.Drawing.Size(526, 374);
            this.zedGraph2_2.TabIndex = 3;
            // 
            // tabPage3_1
            // 
            this.tabPage3_1.Controls.Add(this.zedGraph3_1);
            this.tabPage3_1.Location = new System.Drawing.Point(4, 22);
            this.tabPage3_1.Name = "tabPage3_1";
            this.tabPage3_1.Size = new System.Drawing.Size(526, 374);
            this.tabPage3_1.TabIndex = 2;
            this.tabPage3_1.Text = "Проверка3_1";
            this.tabPage3_1.UseVisualStyleBackColor = true;
            // 
            // zedGraph3_1
            // 
            this.zedGraph3_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraph3_1.IsShowPointValues = false;
            this.zedGraph3_1.Location = new System.Drawing.Point(0, 0);
            this.zedGraph3_1.Name = "zedGraph3_1";
            this.zedGraph3_1.PointValueFormat = "G";
            this.zedGraph3_1.Size = new System.Drawing.Size(526, 374);
            this.zedGraph3_1.TabIndex = 3;
            // 
            // tabPage3_2
            // 
            this.tabPage3_2.Controls.Add(this.label3);
            this.tabPage3_2.Controls.Add(this.zedGraph3_2);
            this.tabPage3_2.Location = new System.Drawing.Point(4, 22);
            this.tabPage3_2.Name = "tabPage3_2";
            this.tabPage3_2.Size = new System.Drawing.Size(526, 374);
            this.tabPage3_2.TabIndex = 5;
            this.tabPage3_2.Text = "Проверка3_2";
            this.tabPage3_2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label4";
            // 
            // zedGraph3_2
            // 
            this.zedGraph3_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraph3_2.IsShowPointValues = false;
            this.zedGraph3_2.Location = new System.Drawing.Point(0, 0);
            this.zedGraph3_2.Name = "zedGraph3_2";
            this.zedGraph3_2.PointValueFormat = "G";
            this.zedGraph3_2.Size = new System.Drawing.Size(526, 374);
            this.zedGraph3_2.TabIndex = 3;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(526, 374);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(526, 374);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
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
            this.tabPage1_2.PerformLayout();
            this.tabPage2_1.ResumeLayout(false);
            this.tabPage2_2.ResumeLayout(false);
            this.tabPage2_2.PerformLayout();
            this.tabPage3_1.ResumeLayout(false);
            this.tabPage3_2.ResumeLayout(false);
            this.tabPage3_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1_1;
        private System.Windows.Forms.TabPage tabPage1_2;
        private System.Windows.Forms.TabPage tabPage2_1;
        private System.Windows.Forms.TabPage tabPage2_2;
        private System.Windows.Forms.TabPage tabPage3_1;
        private System.Windows.Forms.TabPage tabPage3_2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ZedGraphControl zedGraph1_1; 
        private ZedGraphControl zedGraph2_1; 
        private ZedGraphControl zedGraph3_1;
        private ZedGraphControl zedGraph1_2;
        private ZedGraphControl zedGraph2_2;
        private ZedGraphControl zedGraph3_2;
    }
}

