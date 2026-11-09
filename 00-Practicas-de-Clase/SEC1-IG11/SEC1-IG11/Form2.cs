using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SEC1_IG11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = 0, n2 = 0, r = 0;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                r = n1 + n2;
                label4.Text = "+";
                label4.Visible = true;
                textBox3.Text = Convert.ToString(r);
                textBox3.Visible = true;
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show(" Error \n tienes que teclear solo numeros en ambas cajas!! \n Intentalo de nuevo!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Visible = false;
            label5.Visible = false;
            textBox3.Visible = false;
            textBox1.Focus();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {

        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            label10.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = 0, n2 = 0, r = 0;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                r = n1 - n2;
                label4.Text = "-";
                label4.Visible = true;
                textBox3.Text = Convert.ToString(r);
                textBox3.Visible = true;
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show(" Error \n tienes que teclear solo numeros en ambas cajas!! \n Intentalo de nuevo!!");
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = 0, n2 = 0, r = 0;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                r = n1 * n2;
                label4.Text = "*";
                label4.Visible = true;
                textBox3.Text = Convert.ToString(r);
                textBox3.Visible = true;
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show(" Error \n tienes que teclear solo numeros en ambas cajas!! \n Intentalo de nuevo!!");
            }
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            label8.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = 0, n2 = 0, r = 0;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                r = n1 / n2;
                label4.Text = "/";
                label4.Visible = true;
                textBox3.Text = Convert.ToString(r);
                textBox3.Visible = true;
                label5.Visible = true;
            }
            catch
            {
                MessageBox.Show(" Error \n tienes que teclear solo numeros en ambas cajas!! \n Intentalo de nuevo!!");
            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            label9.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label9.Visible = false;
        }
    }
}
