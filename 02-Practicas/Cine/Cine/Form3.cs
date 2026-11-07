using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cine
{
    public partial class Form3 : Form
    {
        // Referencia al Form1 original
        private Form1 principal;

        // Vectores: días de la semana y horarios de función
        private string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
        private string[] horarios = { "Matiné (4:00 pm)", "Tarde (6:30 pm)", "Noche (9:00 pm)" };

        // Matriz (arreglo de dos dimensiones): 5 filas (días) x 3 columnas (matiné, tarde y noche)
        private string[,] cartelera =
        {
            { "Robots del futuro",     "Comedia de verano",     "Misterio en el museo" },
            { "Aventura en la selva",  "Robots del futuro",     "Terror en la cabaña"  },
            { "Comedia de verano",     "Misterio en el museo",  "Aventura en la selva" },
            { "Misterio en el museo",  "Terror en la cabaña",   "Robots del futuro"    },
            { "Aventura en la selva",  "Comedia de verano",     "Terror en la cabaña"  }
        };

        // Constructor: recibe el Form1 original
        public Form3(Form1 principal)
        {
            InitializeComponent();
            this.principal = principal;

            this.Text = "Cine Estrella - Cartelera de la semana";
            this.BackColor = Color.PapayaWhip;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Load: llenamos el ComboBox con el vector de días
        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dias.Length; i++)
            {
                cmbDia.Items.Add(dias[i]);
            }
            grpDia.Visible = false;   // El GroupBox se muestra hasta que elijan un día
        }

        // Cuando cambian el día del ComboBox, mostramos ese renglón de la matriz
        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int f = cmbDia.SelectedIndex;   // El índice del día es la fila de la matriz

            if (f < 0)   // Si no hay nada seleccionado, no hacemos nada
            {
                return;
            }

            grpDia.Text = dias[f];
            lblMatine.Text = "Matiné: " + cartelera[f, 0];   // Columna 0
            lblTarde.Text = "Tarde: " + cartelera[f, 1];     // Columna 1
            lblNoche.Text = "Noche: " + cartelera[f, 2];     // Columna 2
            grpDia.Visible = true;
        }

        // Botón Ver toda la semana: recorre TODA la matriz con for anidado
        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            lstMenu.Items.Clear();

            // for externo: recorre las filas (los días)
            for (int i = 0; i < cartelera.GetLength(0); i++)
            {
                lstMenu.Items.Add("----- " + dias[i] + " -----");

                // for interno: recorre las columnas (matiné, tarde y noche)
                for (int j = 0; j < cartelera.GetLength(1); j++)
                {
                    lstMenu.Items.Add("   " + horarios[j] + ": " + cartelera[i, j]);
                }
            }
        }

        // Regresar: cierra este Form
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Al cerrarse, volvemos a mostrar el mismo Form1
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Show();
        }
    }
}
