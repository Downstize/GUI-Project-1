using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
	public partial class Form1 : Form
	{
		public const double a_lf = 1.1; //инициализация переменных
		public const double b_Rh = 1.9;//инициализация переменных
		public double c_accureded;//инициализация переменных //ограниченная область
		public double d_step;//инициализация переменных //шаг переменной, число к которому прибавляется x
		public Form1()
		{
			InitializeComponent();

		}

		private void btn_interesion_Click_1(object sender, EventArgs e)
		{
			c_accureded = double.Parse(txt_accureid.Text); //парсим значения вводимые в text_box на форме (указываем тип - double)
			d_step = double.Parse(txt_step.Text); //парсим значения вводимые в text_box на форме (указываем тип - double)
			lbl_param.Text = "левая граница: " + a_lf + "\r\n правая граница:" + b_Rh + "\r\n точность: " + c_accureded + "\r\n шаг: " + d_step;
			//выводим в форму введенные параметры

			method_full_iteration(); //запуск функции
		}
		public void method_full_iteration() //функция метода иттерация
		{
			double kr_step = 1; //инициализация переменных
			double kr_function = 0l;//инициализация переменных
			double x_tecuch = 0l; //инициализация переменных
			var startTime = System.Diagnostics.Stopwatch.StartNew();//функция для расчета времени 		

			{
				for (x_tecuch = a_lf; x_tecuch < b_Rh; x_tecuch = x_tecuch + d_step)//начало работы цикла
				{
					kr_function = Math.Asin(x_tecuch - 1) + x_tecuch - 2;//математическое уравнение с подставляемой переменной 
					if (Math.Abs(kr_function) <= c_accureded) //начало работы цикла
					{
						break;//выход из цикла
					}
					kr_step++; //прибавление +1 после прохода цикла

				}
			}

			startTime.Stop();//остановка таймера расчета затраченного времени
			var resultTime = startTime.Elapsed;//присваивание переменной получившего времени расчета

			lbl_result.Text = "Время выполнения: " + resultTime + "\r\n найдено " + x_tecuch + "\r\n шаги " + kr_step + "\r\n функция " + kr_function + "\r\n модуль функции " + (Math.Abs(kr_function) - c_accureded);
			//выводим в label результата
		}


		private void button2_Click(object sender, EventArgs e)
		{
			c_accureded = double.Parse(txt_accureid.Text); //парсим значения вводимые в text_box на форме (указываем тип - double)
			d_step = double.Parse(txt_step.Text); //парсим значения вводимые в text_box на форме (указываем тип - double)
			lbl_param.Text = "левая граница: " + a_lf + "\r\n правая граница:" + b_Rh + "\r\n точность: " + c_accureded + "\r\n шаг: " + d_step;
			//выводим в форму введенные параметры

			method_dihotomii(); //запуск функции
		}

		public void method_dihotomii()//функция метода дихотомии
		{
			double x = 0;//инициализация переменных
			double kr_step = 1;//инициализация переменных
			double kr_function = 0l; //инициализация переменных
			var startTime = System.Diagnostics.Stopwatch.StartNew();//функция для расчета времени 

			double a = a_lf;//левая граница
			double b = b_Rh;//правая граница
				while (b - a > c_accureded) //начало цикла
				{
					x = (a + b) / 2;
					if (f(b) * f(x) > 0)
					{
						b = x;
					}
					else
					{
						a = x;
					}
					kr_step++;
				}

			kr_function = Math.Asin(x - 1) + x - 2; //функция 

			startTime.Stop();//остановка таймера расчета затраченного времени
			var resultTime = startTime.Elapsed;//присваивание переменной получившего времени расчета

			lbl_result.Text = "Время выполнения: " + resultTime + "\r\n найдено " + x + "\r\n шаги " + kr_step + "\r\n функция " + kr_function + "\r\n модуль функции " + (Math.Abs(kr_function) - c_accureded);//выводим в label результата
		}
		public double f(double x)
		{
			return Math.Asin(x - 1) + x - 2;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void chart1_Click(object sender, EventArgs e)
        {
			
        }

        private void button1_Click(object sender, EventArgs e)
        {
			double Xmin = double.Parse(textBoxXmin.Text);

			double Xmax = double.Parse(textBoxXmax.Text);

			double Step = double.Parse(textBoxStep.Text);


			// Количество точек графика

			int count = (int)Math.Ceiling((Xmax - Xmin) / Step)

			+ 1;



			// Массив значений X – общий для обоих графиков

			double[] x = new double[count];



			// Два массива Y – по одному для каждого графика

			double[] y1 = new double[count];

			double[] y2 = new double[count];



			// Расчитываем точки для графиков функции

			for (int i = 0; i < count; i++)

			{

				// Вычисляем значение X

				x[i] = Xmin + Step * i;

				// Вычисляем значение функций в точке X

				y1[i] = Math.Asin(x[i] - 1) + x[i] - 2;

				y2[i] = Math.Asin(x[i] - 1) + x[i] - 2;

			}



			// Настраиваем оси графика

			chart1.ChartAreas[0].AxisX.Minimum = Xmin;

			chart1.ChartAreas[0].AxisX.Maximum = Xmax;



			// Определяем шаг сетки

			chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;



			// Добавляем вычисленные значения в графики

			chart1.Series[0].Points.DataBindXY(x, y1);

			tabControl1.SelectTab(tabPage2);
		}
    }
}
