
namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txt_Lf_border = new System.Windows.Forms.TextBox();
            this.txt_rh_border = new System.Windows.Forms.TextBox();
            this.txt_accureid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_step = new System.Windows.Forms.TextBox();
            this.btn_interesion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_param = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.textBoxXmax = new System.Windows.Forms.TextBox();
            this.textBoxXmin = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Левая граница:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Правая граница:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Точность:";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_result.Location = new System.Drawing.Point(11, 192);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(63, 15);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Text = "Результат:";
            // 
            // txt_Lf_border
            // 
            this.txt_Lf_border.Location = new System.Drawing.Point(108, 22);
            this.txt_Lf_border.Name = "txt_Lf_border";
            this.txt_Lf_border.ReadOnly = true;
            this.txt_Lf_border.Size = new System.Drawing.Size(100, 20);
            this.txt_Lf_border.TabIndex = 4;
            this.txt_Lf_border.Text = "1.1";
            // 
            // txt_rh_border
            // 
            this.txt_rh_border.Location = new System.Drawing.Point(108, 45);
            this.txt_rh_border.Name = "txt_rh_border";
            this.txt_rh_border.ReadOnly = true;
            this.txt_rh_border.Size = new System.Drawing.Size(100, 20);
            this.txt_rh_border.TabIndex = 5;
            this.txt_rh_border.Text = "1.9";
            // 
            // txt_accureid
            // 
            this.txt_accureid.Location = new System.Drawing.Point(108, 88);
            this.txt_accureid.Name = "txt_accureid";
            this.txt_accureid.Size = new System.Drawing.Size(100, 20);
            this.txt_accureid.TabIndex = 6;
            this.txt_accureid.Text = "0,001";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Шаг:";
            // 
            // txt_step
            // 
            this.txt_step.Location = new System.Drawing.Point(108, 126);
            this.txt_step.Name = "txt_step";
            this.txt_step.Size = new System.Drawing.Size(100, 20);
            this.txt_step.TabIndex = 8;
            this.txt_step.Text = "0,001";
            // 
            // btn_interesion
            // 
            this.btn_interesion.Location = new System.Drawing.Point(317, 35);
            this.btn_interesion.Name = "btn_interesion";
            this.btn_interesion.Size = new System.Drawing.Size(168, 23);
            this.btn_interesion.TabIndex = 9;
            this.btn_interesion.Text = "Метод прямого перебора";
            this.btn_interesion.UseVisualStyleBackColor = true;
            this.btn_interesion.Click += new System.EventHandler(this.btn_interesion_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Метод дихотомии";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_param
            // 
            this.lbl_param.AutoSize = true;
            this.lbl_param.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_param.Location = new System.Drawing.Point(367, 192);
            this.lbl_param.Name = "lbl_param";
            this.lbl_param.Size = new System.Drawing.Size(65, 15);
            this.lbl_param.TabIndex = 11;
            this.lbl_param.Text = "Параметр:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 448);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbl_param);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_interesion);
            this.tabPage1.Controls.Add(this.lbl_result);
            this.tabPage1.Controls.Add(this.txt_step);
            this.tabPage1.Controls.Add(this.txt_Lf_border);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_rh_border);
            this.tabPage1.Controls.Add(this.txt_accureid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(758, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Решение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Построить график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBoxStep);
            this.tabPage2.Controls.Add(this.textBoxXmax);
            this.tabPage2.Controls.Add(this.textBoxXmin);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(758, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "График";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Шаг:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Правая граница:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Левая граница:";
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(272, 395);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(100, 20);
            this.textBoxStep.TabIndex = 3;
            this.textBoxStep.Text = "0,1";
            // 
            // textBoxXmax
            // 
            this.textBoxXmax.Location = new System.Drawing.Point(137, 395);
            this.textBoxXmax.Name = "textBoxXmax";
            this.textBoxXmax.ReadOnly = true;
            this.textBoxXmax.Size = new System.Drawing.Size(100, 20);
            this.textBoxXmax.TabIndex = 2;
            this.textBoxXmax.Text = "1,9";
            // 
            // textBoxXmin
            // 
            this.textBoxXmin.Location = new System.Drawing.Point(8, 395);
            this.textBoxXmin.Name = "textBoxXmin";
            this.textBoxXmin.ReadOnly = true;
            this.textBoxXmin.Size = new System.Drawing.Size(100, 20);
            this.textBoxXmin.TabIndex = 1;
            this.textBoxXmin.Text = "1,1";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.Name = "arcsin(x-1)+x-2";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(746, 368);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox txt_Lf_border;
        private System.Windows.Forms.TextBox txt_rh_border;
        private System.Windows.Forms.TextBox txt_accureid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_step;
        private System.Windows.Forms.Button btn_interesion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_param;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxXmin;
        private System.Windows.Forms.TextBox textBoxXmax;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}

