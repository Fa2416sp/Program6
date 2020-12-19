using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zagatovka.Visible = true;
            A1.Visible = false;
            A2.Visible = false;
            A3.Visible = false;
            A12.Visible = false;
            A13.Visible = false;
            A23.Visible = false;
            A123.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a1, a2, a3, x1, x2, x3, y1, y2, y3, d;
            //A1
            x1 = Convert.ToDouble(textBox1.Text);
            y1 = Convert.ToDouble(textBox2.Text);
            //A2
            x2 = Convert.ToDouble(textBox4.Text);
            y2 = Convert.ToDouble(textBox3.Text);
            //A3
            x3 = Convert.ToDouble(textBox6.Text);
            y3 = Convert.ToDouble(textBox5.Text);
            //Вычесления 
            a1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            a2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            a3 = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));
            //Вывод значений 
            if (a1 > a2 & a1 > a3)
            {
                textBox7.Text = "точка A1 дальше от начала координат";
                zagatovka.Visible = false;

                zagatovka.Visible = false;
                A1.Visible = true;
                A2.Visible = false;
                A3.Visible = false;
                A12.Visible = false;
                A13.Visible = false;
                A23.Visible = false;
                A123.Visible = false;
            }
            if (a2 > a1 & a2 > a3)
            {
                textBox7.Text = "точка A2 дальше от начала координат";
                zagatovka.Visible = false;
                A1.Visible = false;
                A2.Visible = true;
                A3.Visible = false;
                A12.Visible = false;
                A13.Visible = false;
                A23.Visible = false;
                A123.Visible = false;
            }
            if (a3 > a1 & a3 > a2)
            {
                textBox7.Text = "точка A3 дальше от начала координат";
                zagatovka.Visible = false;
                A1.Visible = false;
                A2.Visible = false;
                A3.Visible = true;
                A12.Visible = false;
                A13.Visible = false;
                A23.Visible = false;
                A123.Visible = false;
            }
            if (a1 == a2)
            {
                textBox7.Text = "точки A1 и A2 равноудалены от начала координат";
                zagatovka.Visible = false;
                A1.Visible = false;
                A2.Visible = false;
                A3.Visible = false;
                A12.Visible = true;
                A13.Visible = false;
                A23.Visible = false;
                A123.Visible = false;
            }
            if (a1 == a3)
            {
                textBox7.Text = "точки A1 и A3 равноудалены от начала координат";
                zagatovka.Visible = false;
                A1.Visible = false;
                A2.Visible = false;
                A3.Visible = false;
                A12.Visible = false;
                A13.Visible = true;
                A23.Visible = false;
                A123.Visible = false;
            }
            if (a2 == a3)
            {
                textBox7.Text = "точки A2 и A3 равноудалены от начала координат";
                zagatovka.Visible = false;
                A1.Visible = false;
                A2.Visible = false;
                A3.Visible = false;
                A12.Visible = false;
                A13.Visible = false;
                A23.Visible = true;
                A123.Visible = false;
            }
            if (a1 == a2 & a1 == a3 & a2 == a3)
            {
                textBox7.Text = "точки равноудалены от начала координат";
                zagatovka.Visible = false;
                A1.Visible = false;
                A2.Visible = false;
                A3.Visible = false;
                A12.Visible = false;
                A13.Visible = false;
                A23.Visible = false;
                A123.Visible = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
