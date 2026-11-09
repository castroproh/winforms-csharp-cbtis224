namespace Temas_semana_9___13
{
    public partial class Form7 : Form
    {
        int intentos = 3;

        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Escribe tu usuario de socio.", "Costco Wholesale");
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Escribe tu contraseña.", "Costco Wholesale");
                textBox2.Focus();
                return;
            }

            if (textBox1.Text == "socio" && textBox2.Text == "costco123")
            {
                MessageBox.Show("¡Bienvenido a Costco Wholesale!", "Acceso correcto");
                this.Close();
            }
            else
            {
                intentos--;

                if (intentos == 0)
                {
                    lblEstado.Text = "Cuenta bloqueada";
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                }
                else
                {
                    lblEstado.Text = "Datos incorrectos. Intentos restantes: " + intentos;
                    textBox2.Clear();
                    textBox2.Focus();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
