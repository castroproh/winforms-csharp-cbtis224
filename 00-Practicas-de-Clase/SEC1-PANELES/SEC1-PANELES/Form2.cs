using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SEC1_PANELES
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double n1, n2, r;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                r = n1 + n2;
                textBox3.Visible = true;
                textBox3.Text = Convert.ToString(r);
            }
            catch
            {
                MessageBox.Show("Error! \n tienes que teclear solo numeros en ambas cajas!! \n intentalo de nuevo!!");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox3.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
