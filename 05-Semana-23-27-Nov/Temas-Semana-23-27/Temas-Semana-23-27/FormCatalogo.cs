using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TemasSemana
{
    // Tema 24: catálogo en un DataGridView con búsqueda por nombre.
    public class FormCatalogo : Form
    {
        private TextBox txtBuscar;
        private Label lblResultados;
        private DataGridView dgvCatalogo;

        private readonly List<Producto> catalogo = DatosTienda.ObtenerProductos();

        public FormCatalogo()
        {
            UI.ConfigurarFormulario(this, "Tema 24 - DataGridView (catálogo)", 860, 560);
            ConstruirInterfaz();
            AplicarBusqueda();
        }

        private void ConstruirInterfaz()
        {
            TableLayoutPanel layout = new TableLayoutPanel();
            layout.Dock = DockStyle.Fill;
            layout.ColumnCount = 1;
            layout.RowCount = 3;
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            layout.Controls.Add(
                UI.CrearEncabezado("Catálogo de productos", "Escribe para filtrar por nombre", Dibujo.IconoLupa(48)), 0, 0);

            FlowLayoutPanel barra = new FlowLayoutPanel();
            barra.Dock = DockStyle.Fill;
            barra.Padding = new Padding(6, 4, 0, 0);

            Label lblBuscar = UI.CrearEtiqueta("Buscar por nombre:", true);
            lblBuscar.Margin = new Padding(4, 8, 4, 0);

            txtBuscar = new TextBox();
            txtBuscar.Font = UI.Normal;
            txtBuscar.Width = 260;
            txtBuscar.MaxLength = 40;
            txtBuscar.Margin = new Padding(4, 5, 4, 0);
            txtBuscar.TextChanged += TxtBuscar_TextChanged;

            Button btnLimpiarBusqueda = UI.CrearBoton("Limpiar", 100, BtnLimpiarBusqueda_Click);

            lblResultados = UI.CrearEtiqueta(string.Empty, false);
            lblResultados.Margin = new Padding(16, 8, 0, 0);

            barra.Controls.Add(lblBuscar);
            barra.Controls.Add(txtBuscar);
            barra.Controls.Add(btnLimpiarBusqueda);
            barra.Controls.Add(lblResultados);
            layout.Controls.Add(barra, 0, 1);

            dgvCatalogo = UI.CrearGridProductos();
            layout.Controls.Add(dgvCatalogo, 0, 2);

            Controls.Add(layout);
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
