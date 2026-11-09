using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SEC1_IG2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            label5.Visible = false;
            label6.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            name = (textBox1.Text);

            try
            {
                double a, b, area, perim;
                a = Convert.ToDouble(textBox2.Text);
                if(a < 1 || a > 50)
                {
                    MessageBox.Show(" Error fuera de rango!!");
                    textBox2.Text = " ";
                    textBox2.Focus();
                    return;
                }
                b = Convert.ToDouble(textBox3.Text);
                if ( b < 1 || b > 50)
                {
                    MessageBox.Show(" Error fuera de rango!!");
                    textBox3.Text = " ";
                    textBox3.Focus();
                    return;
                }
                area = a * b;
                perim = (a * a) + (b * b);
                label5.Visible = true;
                label6.Visible = true;
                textBox4.Text = Convert.ToString(area);
                textBox5.Text = Convert.ToString(perim);
                textBox4.Visible = true;
                textBox5.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            catch
            {
                MessageBox.Show(" Error!\n Tienes que teclear sólo números en ambas cajas!! \n Inténtalo de nuevo!!");
                textBox2.Text = " ";
                textBox3.Text = " ";
                pictureBox1.Visible = false;
                return;
            }
        }
    }
}
