using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TemasSemana
{
    // Tema 24: catálogo en un DataGridView con búsqueda por nombre.
    public partial class FormCatalogo : Form
    {
        private readonly List<Producto> catalogo = DatosTienda.ObtenerProductos();

        public FormCatalogo()
        {
            InitializeComponent();

            // Las columnas están en el Designer; aquí solo lo que no cabe en propiedades simples.
            ConfigurarGrid();
            // El icono se dibuja con GDI+ (Dibujo.cs), por eso se asigna aquí y no en el Designer.
            picEncabezado.Image = Dibujo.IconoLupa(48);
            AplicarBusqueda();
        }

        // Las columnas se definen en el Designer; el DataSource se asigna en el código.
        private void ConfigurarGrid()
        {
            dgvCatalogo.AutoGenerateColumns = false;
            colPrecio.DefaultCellStyle.FormatProvider = UI.Cultura;
            colImporte.DefaultCellStyle.FormatProvider = UI.Cultura;
        }

        private void AplicarBusqueda()
        {
            string texto = txtBuscar.Text.Trim();
            List<Producto> resultado = catalogo.Where(p => UI.Contiene(p.Nombre, texto)).ToList();
            dgvCatalogo.DataSource = resultado;

            if (resultado.Count == 0)
            {
                lblResultados.Text = "Sin resultados para \"" + texto + "\"";
            }
            else
            {
                lblResultados.Text = "Mostrando " + resultado.Count + " de " + catalogo.Count + " productos";
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AplicarBusqueda();
            }
            catch (Exception ex)
            {
                UI.MostrarError("No se pudo buscar: " + ex.Message);
            }
        }

        private void BtnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            txtBuscar.Focus();
        }
    }
}
