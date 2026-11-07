using System;
using System.Drawing;
using System.IO;            // Para usar File.Exists y Path.Combine
using System.Windows.Forms;

namespace Cine
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

            this.Text = "Cine Estrella - Sala de espera";
            this.BackColor = Color.Honeydew;
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
            string ruta = Path.Combine(Application.StartupPath, "Musica.mp3");

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

        // Contar: cuenta las vocales de la palabra y además la escribe al revés
        private void btnContar_Click(object sender, EventArgs e)
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

            // for normal: recorremos cada letra y contamos si es vocal
            string vocalesValidas = "aeiouáéíóúü";
            int vocales = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (vocalesValidas.IndexOf(p[i]) >= 0)
                {
                    vocales = vocales + 1;
                }
            }

            // if: si no hay vocales avisamos en rojo, si hay las mostramos en verde
            if (vocales == 0)
            {
                lblResultado.Text = "No tiene vocales.";
                lblResultado.ForeColor = Color.Red;
            }
            else
            {
                lblResultado.Text = "Tiene " + vocales + " vocal(es).";
                lblResultado.ForeColor = Color.Green;
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
