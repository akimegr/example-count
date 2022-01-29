using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Text = "Лаб. раб N1 Ст.гр 10701320 ";

            this.textBox1.Width = 265;
            this.textBox1.Height = 100;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double x = Double.Parse(field_x.Text);
                double y = Double.Parse(field_y.Text);
                double z = Double.Parse(field_z.Text);
                double S = Math.Pow((8 + Math.Pow(Math.Abs(x - y), 2) + 1), (1 / 3)) / (Math.Pow(x, 2) + Math.Pow(y, 2) + 2) - Math.Pow(Math.E, Math.Abs(x - y)) * (Math.Pow(Math.Pow(Math.Tan(z), 2) + 1, x));
                string s = "";
                s += " Лаб.раб N1 Ст.гр 10701320 Акимов Е.С. \r\n" ;
                s += " x:=" + x.ToString()+"\r\n";
                s += " y:= " + y.ToString() + "\r\n";
                s += " z:= " + z.ToString() + "\r\n";
                s += " Результат U:= " + S.ToString() + "\r\n";

                textBox1.Text = s;
            }
            catch (FormatException ex)
            {
                double x = 1;
                double y = 2;
                double z = 3;

                double S = Math.Pow((8 + Math.Pow(Math.Abs(x - y), 2) + 1), (1 / 3)) / (Math.Pow(x, 2) + Math.Pow(y, 2) + 2) - Math.Pow(Math.E, Math.Abs(x - y)) * (Math.Pow(Math.Pow(Math.Tan(z), 2) + 1, x));
                string s = "";
                s += " Лаб.раб N1 Ст.гр 10701320 Акимов Е.С. \r\n";
                s += " ОШИБКА!!! Значения по умолчнаию: \r\n";
                s += " x:=" + x.ToString() + "\r\n";
                s += " y:= " + y.ToString() + "\r\n";
                s += " z:= " + z.ToString() + "\r\n";
                s += " Результат U:= " + S.ToString() + "\r\n";
                textBox1.Text = s;
            }

            
        }


    }
}
