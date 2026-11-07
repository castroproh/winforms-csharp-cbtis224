namespace Temas_semana_9___13
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            string tipo = "";
            int opcion = 0;

            if (radioButton1.Checked)
            {
                opcion = 1;
            }
            else if (radioButton2.Checked)
            {
                opcion = 2;
            }
            else if (radioButton3.Checked)
            {
                opcion = 3;
            }

            if (opcion == 0)
            {
                MessageBox.Show("Elige un tipo de membresía.", "Costco Wholesale");
                return;
            }

            switch (opcion)
            {
                case 1:
                    tipo = "Oro (Gold Star)";
                    total = 600;
                    break;
                case 2:
                    tipo = "Empresarial";
                    total = 600;
                    break;
                case 3:
                    tipo = "Ejecutiva";
                    total = 1200;
                    break;
            }

            if (checkBox1.Checked)
            {
                total += 300;
            }
            if (checkBox2.Checked)
            {
                total += 150;
            }
            if (checkBox3.Checked)
            {
                total -= 50;
            }

            lblResultado.Text = "Membresía " + tipo + "\nTotal: " + total.ToString("C2");
        }
    }
}
