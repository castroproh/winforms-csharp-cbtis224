using System;
using System.Drawing;
using System.IO;            // Para usar File.Exists (revisar si existe el archivo)
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class Form4 : Form
    {
        // Referencia al Form1 original
        private Form1 principal;

        // Constructor: recibe el Form1 original
        public Form4(Form1 principal)
        {
            InitializeComponent();
            this.principal = principal;

            this.Text = "Cafetería Escolar - Zona de descanso";
            this.BackColor = Color.Lavender;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Load: el resultado del juego empieza oculto
        private void Form4_Load(object sender, EventArgs e)
        {
            lblResultado.Visible = false;
            lblInvertido.Visible = false;
        }

        // Reproducir: busca el archivo de música junto al programa y lo reproduce
        private void btnReproducir_Click(object sender, EventArgs e)
        {
            // Ruta del archivo: la carpeta del programa + el nombre del archivo
            string ruta = Application.StartupPath + "\\Caifanes audio.mp3";

            // Si el archivo no existe, avisamos para que no truene el programa
            if (!File.Exists(ruta))
            {
                MessageBox.Show("No se encontró el archivo de música.", "Error");
                return;
            }

            axWmpMusica.URL = ruta;            // Le decimos al reproductor qué archivo usar
            axWmpMusica.Ctlcontrols.play();    // Empieza a sonar
        }

        // Detener la música
        private void btnDetener_Click(object sender, EventArgs e)
        {
            axWmpMusica.Ctlcontrols.stop();
        }

        // Invertir: escribe la palabra al revés y revisa si es palíndromo
        private void btnInvertir_Click(object sender, EventArgs e)
        {
            string p = txtPalabra.Text;

            // Validación: si está vacío avisamos y regresamos el cursor
            if (string.IsNullOrWhiteSpace(p))
            {
                MessageBox.Show("Escribe una palabra primero.", "Falta un dato");
                txtPalabra.Focus();
                return;
            }

            p = p.ToLower();   // Pasamos a minúsculas para comparar bien

            // for al revés: empieza en la última letra y termina en la primera
            string invertido = "";
            int K;
            for (K = p.Length - 1; K >= 0; K--)
            {
                invertido = invertido + p[K];
            }

            lblInvertido.Text = "Al revés: " + invertido;
            lblInvertido.Visible = true;   // Mostramos la palabra al revés

            // if: si la palabra y su inversa son iguales, es palíndromo
            if (p == invertido)
            {
                lblResultado.Text = "¡Sí es palíndromo!";
                lblResultado.ForeColor = Color.Green;
            }
            else
            {
                lblResultado.Text = "No es palíndromo.";
                lblResultado.ForeColor = Color.Red;
            }
            lblResultado.Visible = true;
        }

        // Limpiar: borra todo y regresa el cursor al TextBox
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPalabra.Clear();
            lblInvertido.Visible = false;
            lblResultado.Visible = false;
            txtPalabra.Focus();
        }

        // Regresar: cierra (destruye) este Form
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Al cerrarse: detenemos la música y mostramos el mismo Form1
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            axWmpMusica.Ctlcontrols.stop();
            principal.Show();
        }
    }
}
