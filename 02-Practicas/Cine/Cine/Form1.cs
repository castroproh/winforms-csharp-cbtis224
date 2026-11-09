using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cine
{
    public partial class Form1 : Form
    {
        // Constructor: aquí se ponen las propiedades del Form
        public Form1()
        {
            InitializeComponent();
            this.Text = "Cine Estrella - Inicio";                // Título de la ventana
            this.BackColor = Color.Lavender;                      // Color de fondo
            this.StartPosition = FormStartPosition.CenterScreen;  // Aparece en el centro de la pantalla
        }

        // Load: se ejecuta cuando se abre el Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Mostramos la fecha y hora de la computadora
            lblFecha.Text = "Hoy es: " + DateTime.Now.ToString("dd/MM/yyyy   hh:mm tt");

            // El aviso de error empieza oculto
            lblAviso.Visible = false;
        }

        // Botón Entrar: revisa que escribieron su nombre y abre el Form2
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string p = txtNombre.Text;

            // Validación: si el TextBox está vacío
            if (string.IsNullOrWhiteSpace(p))
            {
                lblAviso.Visible = true;   // Mostramos el aviso rojo
                MessageBox.Show("Escribe tu nombre para continuar.", "Falta un dato");
                txtNombre.Focus();         // El cursor regresa al TextBox
                return;                    // Nos salimos sin abrir el otro Form
            }

            lblAviso.Visible = false;      // Ocultamos el aviso

            btnEntrar.BackColor = Color.LightSalmon;   // El botón regresa a su color normal

            // Abrimos Form2 y le mandamos este Form1 (this) para poder regresar a él
            Form2 compra = new Form2(this, p.Trim());
            compra.Show();
            this.Hide();                   // Ocultamos Form1 (sigue en memoria)
        }

        // MouseHover: cuando el mouse está sobre el botón, cambia de color
        private void btnEntrar_MouseHover(object sender, EventArgs e)
        {
            btnEntrar.BackColor = Color.Khaki;
        }

        // MouseLeave: cuando el mouse sale del botón, regresa a su color
        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            btnEntrar.BackColor = Color.LightSalmon;
        }

        // ----- MENÚ: abrir otros Forms -----

        // "Comprar boletos" hace lo mismo que el botón Entrar
        private void mnuPedido_Click(object sender, EventArgs e)
        {
            btnEntrar_Click(sender, e);
        }

        // Abre la cartelera de la semana (Form3)
        private void mnuMenuSemana_Click(object sender, EventArgs e)
        {
            Form3 cartelera = new Form3(this);
            cartelera.Show();
            this.Hide();
        }

        // Abre la sala de espera (Form4)
        private void mnuDescanso_Click(object sender, EventArgs e)
        {
            Form4 espera = new Form4(this);
            espera.Show();
            this.Hide();
        }

        // ----- MENÚ: cambiar el color de fondo -----

        private void mnuAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSkyBlue;
        }

        private void mnuRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightCoral;
        }

        private void mnuOriginal_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Lavender;
        }

        // ----- SALIR: cierran todo el programa -----

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
