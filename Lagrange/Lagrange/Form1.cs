using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagrange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double l(int index, double[] X, double x) //расчет базисных полиномов
        {
            double l = 1;
            for (int i = 0; i < X.Length; i++)
            {
                if (i != index)
                {
                    l *= (x - X[i]) / (X[index] - X[i]);
                }
            }

            return l;
        }

        public double GetValue(double[] X, double[] Y, double x) //вычисление многочленов
        {
            double y = 0;
            double[] li = new double[9];
            for (int i = 0; i < X.Length; i++)
            {
                y += Y[i] * l(i, X, x);
                li[i] = l(i, X, x);
            }
            //вывод полиномов на экран
            label9.Text = "L1 = " + li[0].ToString();
            label10.Text = "L2 = " + li[1].ToString();
            label11.Text = "L3 = " + li[2].ToString();
            label12.Text = "L4 = " + li[3].ToString();
            label13.Text = "L5 = " + li[4].ToString();
            label14.Text = "L6 = " + li[5].ToString();
            label15.Text = "L7 = " + li[6].ToString();
            label16.Text = "L8 = " + li[7].ToString();
            label17.Text = "L9 = " + li[8].ToString();
            
            return y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //передаем значения textBox в переменные
                double x1 = Convert.ToDouble(textBox1.Text);
                double x2 = Convert.ToDouble(textBox2.Text);
                double x3 = Convert.ToDouble(textBox3.Text);
                double x4 = Convert.ToDouble(textBox4.Text);
                double x5 = Convert.ToDouble(textBox5.Text);
                double x6 = Convert.ToDouble(textBox6.Text);
                double x7 = Convert.ToDouble(textBox7.Text);
                double x8 = Convert.ToDouble(textBox8.Text);
                double x9 = Convert.ToDouble(textBox9.Text);
                double y9 = Convert.ToDouble(textBox10.Text);
                double y8 = Convert.ToDouble(textBox11.Text);
                double y7 = Convert.ToDouble(textBox12.Text);
                double y6 = Convert.ToDouble(textBox13.Text);
                double y5 = Convert.ToDouble(textBox14.Text);
                double y4 = Convert.ToDouble(textBox15.Text);
                double y3 = Convert.ToDouble(textBox16.Text);
                double y2 = Convert.ToDouble(textBox17.Text);
                double y1 = Convert.ToDouble(textBox18.Text);

                double x = Convert.ToDouble(textBox19.Text);

                //создание массива и заполенение его перменными
                double[] X = new double[9] { x1, x2, x3, x4, x5, x6, x7, x8, x9 };
                double[] Y = new double[9] { y1, y2, y3, y4, y5, y6, y7, y8, y9 };

                //интерполированное значение
                double y = GetValue(X, Y, x);

                //вывод на экран значений x и y
                textBox21.Text = x.ToString();
                textBox20.Text = y.ToString();
            }
            catch
            {
                //обработка исключений
                MessageBox.Show("Неправильно введены данные");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //передаем значения textBox в переменные
            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text);
            double x3 = Convert.ToDouble(textBox3.Text);
            double x4 = Convert.ToDouble(textBox4.Text);
            double x5 = Convert.ToDouble(textBox5.Text);
            double x6 = Convert.ToDouble(textBox6.Text);
            double x7 = Convert.ToDouble(textBox7.Text);
            double x8 = Convert.ToDouble(textBox8.Text);
            double x9 = Convert.ToDouble(textBox9.Text);
            double y9 = Convert.ToDouble(textBox10.Text);
            double y8 = Convert.ToDouble(textBox11.Text);
            double y7 = Convert.ToDouble(textBox12.Text);
            double y6 = Convert.ToDouble(textBox13.Text);
            double y5 = Convert.ToDouble(textBox14.Text);
            double y4 = Convert.ToDouble(textBox15.Text);
            double y3 = Convert.ToDouble(textBox16.Text);
            double y2 = Convert.ToDouble(textBox17.Text);
            double y1 = Convert.ToDouble(textBox18.Text);
            double x = Convert.ToDouble(textBox19.Text);

            //очищаем элемент chart
            this.chart1.Series[0].Points.Clear();
            //заполняем элемент точками
            this.chart1.Series[0].Points.AddXY(x1, y1);
            this.chart1.Series[0].Points.AddXY(x2, y2);
            this.chart1.Series[0].Points.AddXY(x3, y3);
            this.chart1.Series[0].Points.AddXY(x4, y4);
            this.chart1.Series[0].Points.AddXY(x5, y5);
            this.chart1.Series[0].Points.AddXY(x6, y6);
            this.chart1.Series[0].Points.AddXY(x7, y7);
            this.chart1.Series[0].Points.AddXY(x8, y8);
            this.chart1.Series[0].Points.AddXY(x9, y9);
        }
    }
}
