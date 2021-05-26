using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            double y;
            double xmin, xmax;
            double dx;
            double x, k;

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                xmin = Convert.ToDouble(textBox1.Text);
                xmax = Convert.ToDouble(textBox3.Text);
                dx = Convert.ToDouble(textBox2.Text);
                k = Convert.ToDouble(textBox4.Text);

                if (xmin > xmax)
                {
                    MessageBox.Show("Уведіть правильно границі", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (x = xmin; x <= xmax; x += dx)
                {
                    if (k - x > 0 && k * x >= 0)
                    {
                        y = Math.Pow(Math.Tan(k * x), 2) + Math.Log(k - x) - Math.Sqrt(k * x);
                        listBox1.Items.Add($"For x = {x} -> y = {y}");
                    }
                    else listBox1.Items.Add($"For x = {x} -> y = помилка");

                }

            }
            else MessageBox.Show("Введіть всі параметри", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
