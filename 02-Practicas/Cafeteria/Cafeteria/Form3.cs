using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class Form3 : Form
    {
        // Referencia al Form1 original
        private Form1 principal;

        // Vectores: días de la semana y tiempos de comida
        private string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
        private string[] tiempos = { "Desayuno", "Comida" };

        // Matriz (arreglo de dos dimensiones): 5 filas (días) x 2 columnas (desayuno y comida)
        private string[,] menu =
        {
            { "Molletes",             "Enchiladas verdes" },
            { "Chilaquiles",          "Sopa de fideo y milanesa" },
            { "Hot cakes",            "Tacos dorados" },
            { "Huevos a la mexicana", "Pollo en mole" },
            { "Sándwich",             "Pizza escolar" }
        };

        // Constructor: recibe el Form1 original
        public Form3(Form1 principal)
        {
            InitializeComponent();
            this.principal = principal;

            this.Text = "Cafetería Escolar - Menú de la semana";
            this.BackColor = Color.MistyRose;
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
            lblDesayuno.Text = "Desayuno: " + menu[f, 0];   // Columna 0
            lblComida.Text = "Comida: " + menu[f, 1];       // Columna 1
            grpDia.Visible = true;
        }

        // Botón Ver toda la semana: recorre TODA la matriz con for anidado
        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            lstMenu.Items.Clear();

            // for externo: recorre las filas (los días)
            for (int i = 0; i < menu.GetLength(0); i++)
            {
                lstMenu.Items.Add("----- " + dias[i] + " -----");

                // for interno: recorre las columnas (desayuno y comida)
                for (int j = 0; j < menu.GetLength(1); j++)
                {
                    lstMenu.Items.Add("   " + tiempos[j] + ": " + menu[i, j]);
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