using System;
using System.Drawing;
using System.IO;            // Para usar File.Exists y Path.Combine
using System.Windows.Forms;

namespace Papeleria
{
    public partial class Form4 : Form
    {
        // Referencia al Form1 original
        private Form1 principal;

        // Reproductor de Windows Media (control COM). Se crea la primera vez que se pulsa Reproducir.
        private object reproductor;

        // Constructor: recibe el Form1 original
        public Form4(Form1 principal)
        {
            InitializeComponent();
            this.principal = principal;

            this.Text = "Papelería Escolar - Zona de descanso";
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
            string ruta = Path.Combine(Application.StartupPath, "Motivator.mp3");

            // Si el archivo no existe, avisamos para que no truene el programa
            if (!File.Exists(ruta))
            {
                MessageBox.Show("No se encontró el archivo de música (Motivator.mp3).", "Error");
                return;
            }

            // Si todavía no existe el reproductor, lo creamos
            if (reproductor == null)
            {
                Type tipo = Type.GetTypeFromProgID("WMPlayer.OCX");
                if (tipo == null)
                {
                    MessageBox.Show("Windows Media Player no está disponible en esta computadora.", "Error");
                    return;
                }
                reproductor = Activator.CreateInstance(tipo);
            }

            // dynamic: nos permite usar las propiedades del reproductor sin referencia extra
            dynamic r = reproductor;
            r.URL = ruta;                 // Le decimos qué archivo usar
            r.controls.play();            // Empieza a sonar
        }

        // Detener la música
        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (reproductor != null)
            {
                dynamic r = reproductor;
                r.controls.stop();
            }
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
            for (int k = p.Length - 1; k >= 0; k--)
            {
                invertido = invertido + p[k];
            }

            lblInvertido.Text = "Al revés: " + invertido;
            lblInvertido.Visible = true;

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
            if (reproductor != null)
            {
                dynamic r = reproductor;
                r.controls.stop();
                reproductor = null;
            }
            principal.Show();
        }
    }
}
