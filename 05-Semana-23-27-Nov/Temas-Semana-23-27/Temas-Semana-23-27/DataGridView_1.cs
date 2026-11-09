using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TemasSemana
{
    // Tema 22: clase Producto + List<Producto> mostrada en un DataGridView.
    public class DataGridView_1 : Form
    {
        private DataGridView dataGridView1;
        private Label lblConteo;

        private List<Producto> lista = new List<Producto>();

        public DataGridView_1()
        {
            UI.ConfigurarFormulario(this, "Tema 22 - Clase DataGridView_1 (Producto y lista)", 860, 560);
            ConstruirInterfaz();
            CargarLista();
        }

        private void ConstruirInterfaz()
        {
            TableLayoutPanel layout = new TableLayoutPanel();
            layout.Dock = DockStyle.Fill;
            layout.ColumnCount = 1;
            layout.RowCount = 5;
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));

            layout.Controls.Add(
                UI.CrearEncabezado("DataGridView_1", "Clase Producto y una lista mostrada en el DataGridView", Dibujo.IconoTabla(48)), 0, 0);

            Label lblInfo = new Label();
            lblInfo.Dock = DockStyle.Fill;
            lblInfo.Text = "Se define la clase Producto, se llena una List<Producto> con los datos de la tienda " +
                           "y se muestra asignándola a dataGridView1.DataSource.";
            lblInfo.TextAlign = ContentAlignment.MiddleLeft;
            lblInfo.Padding = new Padding(10, 0, 10, 0);
            layout.Controls.Add(lblInfo, 0, 1);

            FlowLayoutPanel botones = new FlowLayoutPanel();
            botones.Dock = DockStyle.Fill;
            botones.Padding = new Padding(6, 4, 0, 0);
            Button btnCargar = UI.CrearBoton("Cargar lista", 150, BtnCargar_Click);
            Button btnVaciar = UI.CrearBoton("Vaciar lista", 150, BtnVaciar_Click);
            botones.Controls.Add(btnCargar);
            botones.Controls.Add(btnVaciar);
            layout.Controls.Add(botones, 0, 2);

            dataGridView1 = UI.CrearGridProductos();
            layout.Controls.Add(dataGridView1, 0, 3);

            lblConteo = new Label();
            lblConteo.Dock = DockStyle.Fill;
            lblConteo.TextAlign = ContentAlignment.MiddleLeft;
            lblConteo.Padding = new Padding(10, 0, 0, 0);
            lblConteo.Font = UI.Negrita;
            lblConteo.ForeColor = UI.Azul;
            layout.Controls.Add(lblConteo, 0, 4);

            Controls.Add(layout);
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
