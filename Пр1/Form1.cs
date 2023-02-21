using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр1
{
    public partial class Form1 : Form
    {
        private double a, b;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                if (a <= 0 || b <= 0)
                    MessageBox.Show("Сторона должна быть больше нуля");                
                else
                {
                    double c = Math.Sqrt((a * a) + (b * b));
                    label3.Text = "Ответ:   " + Convert.ToString(c);
                }
            }
            catch
            {
                MessageBox.Show("Введены некорректные числа или поле для ввода пустое");
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
        }
    }
}
