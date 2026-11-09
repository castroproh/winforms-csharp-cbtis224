using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Practica_Secuencia_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ListViewGroup frutas = new ListViewGroup("Frutas", HorizontalAlignment.Left);

            ListViewGroup carnes = new ListViewGroup("Carnes", HorizontalAlignment.Left);

            //Elementos de los grupos
            listView1.Items.Add(new ListViewItem("Manzana", frutas));
            listView1.Items.Add(new ListViewItem("Pera", frutas));
            listView1.Items.Add(new ListViewItem("Sandia", frutas));
            listView1.Items.Add(new ListViewItem("Platano", frutas));
            listView1.Items.Add(new ListViewItem("Fresa", frutas));
            listView1.Items.Add(new ListViewItem("Melon", frutas));

            //otra forma de poner los elementos
            ListViewItem Elemento = new ListViewItem("Pollo", carnes);
            listView1.Items.Add(Elemento);

            listView1.Items.Add(new ListViewItem("Res", carnes));
            listView1.Items.Add(new ListViewItem("Pescado", carnes));
            listView1.Items.Add(new ListViewItem("Cerdo", carnes));
            listView1.Items.Add(new ListViewItem("Codorniz", carnes));

            //Adicionar los grupos al listview
            listView1.Groups.Add(frutas);
            listView1.Groups.Add(carnes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
