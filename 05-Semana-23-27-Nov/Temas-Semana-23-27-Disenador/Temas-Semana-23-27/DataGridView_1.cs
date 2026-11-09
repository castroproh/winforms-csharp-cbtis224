using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TemasSemana
{
    // Tema 22: clase Producto + List<Producto> mostrada en un DataGridView.
    public partial class DataGridView_1 : Form
    {
        private List<Producto> lista = new List<Producto>();

        public DataGridView_1()
        {
            InitializeComponent();

            // Las columnas están en el Designer; aquí solo lo que no cabe en propiedades simples.
            ConfigurarGrid();
            // El icono se dibuja con GDI+ (Dibujo.cs), por eso se asigna aquí y no en el Designer.
            picEncabezado.Image = Dibujo.IconoTabla(48);
            CargarLista();
        }

        // Las columnas se definen en el Designer; el DataSource se asigna en el código.
        private void ConfigurarGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            colPrecio.DefaultCellStyle.FormatProvider = UI.Cultura;
            colImporte.DefaultCellStyle.FormatProvider = UI.Cultura;
        }

        private void MostrarLista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
            lblConteo.Text = "Elementos en la lista: " + lista.Count;
        }

        private void CargarLista()
        {
            lista = DatosTienda.ObtenerProductos();
            MostrarLista();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarLista();
            }
            catch (Exception ex)
            {
                UI.MostrarError("No se pudo cargar la lista: " + ex.Message);
            }
        }

        private void BtnVaciar_Click(object sender, EventArgs e)
        {
            try
            {
                lista = new List<Producto>();
                MostrarLista();
            }
            catch (Exception ex)
            {
                UI.MostrarError("No se pudo vaciar la lista: " + ex.Message);
            }
        }
    }
}
