using System;
using System.Drawing;
using System.Windows.Forms;

namespace Papeleria
{
    public partial class Form3 : Form
    {
        // Referencia al Form1 original
        private Form1 principal;

        // Vectores: categorías de productos y niveles (económico y premium)
        private string[] categorias = { "Cuadernos", "Escritura", "Organización", "Arte", "Geometría" };
        private string[] niveles = { "Económico", "Premium" };

        // Matriz (arreglo de dos dimensiones): 5 filas (categorías) x 2 columnas (niveles)
        private string[,] catalogo =
        {
            { "Cuaderno cuadro chico ($15)",    "Cuaderno profesional 100 hojas ($35)" },
            { "Bolígrafo azul ($6)",            "Plumas de gel de colores ($28)" },
            { "Carpeta de cartón ($8)",         "Archivero con argollas ($60)" },
            { "Crayones de 12 ($20)",           "Lápices de colores de 24 ($75)" },
            { "Regla de 30 cm ($7)",            "Juego de geometría metálico ($45)" }
        };

        // Constructor: recibe el Form1 original
        public Form3(Form1 principal)
        {
            InitializeComponent();
            this.principal = principal;

            this.Text = "Papelería Escolar - Catálogo de productos";
            this.BackColor = Color.MistyRose;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Load: llenamos el ComboBox con el vector de categorías
        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < categorias.Length; i++)
            {
                cmbCategoria.Items.Add(categorias[i]);
            }
            grpCategoria.Visible = false;   // El GroupBox se muestra hasta que elijan una categoría
        }

        // Cuando cambian la categoría, mostramos ese renglón de la matriz
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int f = cmbCategoria.SelectedIndex;   // El índice de la categoría es la fila de la matriz

            if (f < 0)   // Si no hay nada seleccionado, no hacemos nada
            {
                return;
            }

            grpCategoria.Text = categorias[f];
            lblEconomico.Text = niveles[0] + ": " + catalogo[f, 0];   // Columna 0
            lblPremium.Text = niveles[1] + ": " + catalogo[f, 1];     // Columna 1
            grpCategoria.Visible = true;
        }

        // Botón Ver todo: recorre TODA la matriz con for anidado
        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            lstCatalogo.Items.Clear();

            // for externo: recorre las filas (las categorías)
            for (int i = 0; i < catalogo.GetLength(0); i++)
            {
                lstCatalogo.Items.Add("----- " + categorias[i] + " -----");

                // for interno: recorre las columnas (económico y premium)
                for (int j = 0; j < catalogo.GetLength(1); j++)
                {
                    lstCatalogo.Items.Add("   " + niveles[j] + ": " + catalogo[i, j]);
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
