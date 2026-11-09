using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TemasSemana
{
    // Tema 25: agregar, editar, eliminar y limpiar filas, con subtotal, IVA 16% y total.
    public class FormEdicion : Form
    {
        private DataGridView dgvProductos;
        private TextBox txtNombre;
        private ComboBox cmbCategoria;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private Label lblArticulos;
        private Label lblSubtotal;
        private Label lblIva;
        private Label lblTotal;

        // BindingList avisa al DataGridView cuando se agregan o quitan filas.
        private readonly BindingList<Producto> lista = new BindingList<Producto>(DatosTienda.ObtenerProductos());

        public FormEdicion()
        {
            UI.ConfigurarFormulario(this, "Tema 25 - DataGridView (edición y totales)", 1000, 640);
            ConstruirInterfaz();

            dgvProductos.DataSource = lista;
            dgvProductos.SelectionChanged += DgvProductos_SelectionChanged;
            Shown += FormEdicion_Shown;

            ActualizarTotales();
        }

        private void ConstruirInterfaz()
        {
            TableLayoutPanel layout = new TableLayoutPanel();
            layout.Dock = DockStyle.Fill;
            layout.ColumnCount = 2;
            layout.RowCount = 3;
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 330F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));

            Panel encabezado = UI.CrearEncabezado(
                "Edición de productos", "Agregar, editar, eliminar y limpiar filas", Dibujo.IconoLapiz(48));
            layout.Controls.Add(encabezado, 0, 0);
            layout.SetColumnSpan(encabezado, 2);

            dgvProductos = UI.CrearGridProductos();
            dgvProductos.Margin = new Padding(10, 10, 0, 10);
            layout.Controls.Add(dgvProductos, 0, 1);

            Panel panelCampos = new Panel();
            panelCampos.Dock = DockStyle.Fill;
            panelCampos.BackColor = Color.White;
            panelCampos.AutoScroll = true;
            panelCampos.Margin = new Padding(10);

            txtNombre = new TextBox();
            txtNombre.MaxLength = 40;

            cmbCategoria = new ComboBox();
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Items.AddRange(DatosTienda.Categorias);

            txtPrecio = new TextBox();
            txtCantidad = new TextBox();

            int y = 8;
            UI.AgregarCampo(panelCampos, "Nombre", txtNombre, ref y);
            UI.AgregarCampo(panelCampos, "Categoría", cmbCategoria, ref y);
            UI.AgregarCampo(panelCampos, "Precio", txtPrecio, ref y);
            UI.AgregarCampo(panelCampos, "Cantidad", txtCantidad, ref y);

            FlowLayoutPanel botones = new FlowLayoutPanel();
            botones.Location = new Point(8, y);
            botones.Size = new Size(296, 132);
            botones.WrapContents = true;
            botones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            Button btnAgregar = UI.CrearBoton("Agregar", 138, BtnAgregar_Click);
            Button btnEditar = UI.CrearBoton("Editar", 138, BtnEditar_Click);
            Button btnEliminar = UI.CrearBoton("Eliminar", 138, BtnEliminar_Click);
            Button btnLimpiarCampos = UI.CrearBoton("Limpiar campos", 138, BtnLimpiarCampos_Click);
            Button btnLimpiarFilas = UI.CrearBoton("Limpiar filas", 138, BtnLimpiarFilas_Click);
            btnEliminar.BackColor = Color.FromArgb(176, 52, 52);
            btnLimpiarFilas.BackColor = Color.FromArgb(176, 52, 52);
            btnLimpiarCampos.BackColor = Color.FromArgb(110, 110, 110);

            botones.Controls.Add(btnAgregar);
            botones.Controls.Add(btnEditar);
            botones.Controls.Add(btnEliminar);
            botones.Controls.Add(btnLimpiarCampos);
            botones.Controls.Add(btnLimpiarFilas);
            panelCampos.Controls.Add(botones);

            layout.Controls.Add(panelCampos, 1, 1);

            TableLayoutPanel totales = new TableLayoutPanel();
            totales.Dock = DockStyle.Fill;
            totales.BackColor = UI.AzulClaro;
            totales.Margin = new Padding(0);
            totales.ColumnCount = 4;
            totales.RowCount = 1;
            totales.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            totales.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            totales.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            totales.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            totales.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            lblArticulos = CrearEtiquetaTotal();
            lblSubtotal = CrearEtiquetaTotal();
            lblIva = CrearEtiquetaTotal();
            lblTotal = CrearEtiquetaTotal();
            lblTotal.ForeColor = Color.FromArgb(150, 30, 30);

            totales.Controls.Add(lblArticulos, 0, 0);
            totales.Controls.Add(lblSubtotal, 1, 0);
            totales.Controls.Add(lblIva, 2, 0);
            totales.Controls.Add(lblTotal, 3, 0);
            layout.Controls.Add(totales, 0, 2);
            layout.SetColumnSpan(totales, 2);

            Controls.Add(layout);
        }

        private static Label CrearEtiquetaTotal()
        {
            Label etiqueta = new Label();
            etiqueta.Dock = DockStyle.Fill;
            etiqueta.AutoSize = false;
            etiqueta.TextAlign = ContentAlignment.MiddleCenter;
            etiqueta.Font = UI.Grande;
            etiqueta.ForeColor = UI.Azul;
            return etiqueta;
        }

        // ---------- Botones ----------

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DatosProducto datos;
                if (!LeerCampos(out datos))
                {
                    return;
                }

                lista.Add(new Producto(
                    DatosTienda.SiguienteId(lista), datos.Nombre, datos.Categoria, datos.Precio, datos.Cantidad));
                ActualizarTotales();
                LimpiarCampos();

                if (dgvProductos.RowCount > 0)
                {
                    dgvProductos.FirstDisplayedScrollingRowIndex = dgvProductos.RowCount - 1;
                }
            }
            catch (Exception ex)
            {
                UI.MostrarError("No se pudo agregar el producto: " + ex.Message);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto seleccionado = ObtenerSeleccionado();
                if (seleccionado == null)
                {
                    UI.Aviso("Selecciona una fila de la tabla para editarla.");
                    return;
                }

                DatosProducto datos;
                if (!LeerCampos(out datos))
                {
                    return;
                }

                seleccionado.Nombre = datos.Nombre;
                seleccionado.Categoria = datos.Categoria;
                seleccionado.Precio = datos.Precio;
                seleccionado.Cantidad = datos.Cantidad;

                // Producto no avisa de sus cambios, así que se le indica a la lista que refresque esa fila.
                lista.ResetItem(lista.IndexOf(seleccionado));
                ActualizarTotales();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                UI.MostrarError("No se pudo editar el producto: " + ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto seleccionado = ObtenerSeleccionado();
                if (seleccionado == null)
                {
                    UI.Aviso("Selecciona una fila de la tabla para eliminarla.");
                    return;
                }
                if (!UI.Confirmar("¿Eliminar \"" + seleccionado.Nombre + "\"?"))
                {
                    return;
                }

                lista.Remove(seleccionado);
                ActualizarTotales();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                UI.MostrarError("No se pudo eliminar el producto: " + ex.Message);
            }
        }

        private void BtnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnLimpiarFilas_Click(object sender, EventArgs e)
        {
            try
            {
                if (lista.Count == 0)
                {
                    UI.Informar("La tabla ya está vacía.", "Limpiar filas");
                    return;
                }
                if (!UI.Confirmar("¿Quitar las " + lista.Count + " filas de la tabla?"))
                {
                    return;
                }

                lista.Clear();
                ActualizarTotales();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                UI.MostrarError("No se pudieron limpiar las filas: " + ex.Message);
            }
        }

        // ---------- Eventos de la tabla y del formulario ----------

        private void DgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            Producto seleccionado = ObtenerSeleccionado();
            if (seleccionado == null)
            {
                return;
            }

            txtNombre.Text = seleccionado.Nombre;
            cmbCategoria.SelectedItem = seleccionado.Categoria;
            txtPrecio.Text = seleccionado.Precio.ToString("0.00", CultureInfo.InvariantCulture);
            txtCantidad.Text = seleccionado.Cantidad.ToString(CultureInfo.InvariantCulture);
        }

        private void FormEdicion_Shown(object sender, EventArgs e)
        {
            // Al abrir, el DataGridView selecciona la primera fila; se deja todo limpio.
            LimpiarCampos();
        }

        // ---------- Ayudas ----------

        private Producto ObtenerSeleccionado()
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                return null;
            }
            return dgvProductos.SelectedRows[0].DataBoundItem as Producto;
        }

        private bool LeerCampos(out DatosProducto datos)
        {
            string categoria = cmbCategoria.SelectedItem == null ? string.Empty : cmbCategoria.SelectedItem.ToString();
            string error;
            int campo;
            if (Validacion.TryLeerProducto(txtNombre.Text, categoria, txtPrecio.Text, txtCantidad.Text,
                    out datos, out error, out campo))
            {
                return true;
            }

            UI.Aviso(error);
            EnfocarCampo(campo);
            return false;
        }

        private void EnfocarCampo(int campo)
        {
            switch (campo)
            {
                case Validacion.CampoNombre:
                    txtNombre.Focus();
                    break;
                case Validacion.CampoCategoria:
                    cmbCategoria.Focus();
                    break;
                case Validacion.CampoPrecio:
                    txtPrecio.Focus();
                    break;
                case Validacion.CampoCantidad:
                    txtCantidad.Focus();
                    break;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            cmbCategoria.SelectedIndex = -1;
            txtPrecio.Clear();
            txtCantidad.Clear();
            dgvProductos.ClearSelection();
            txtNombre.Focus();
        }

        private void ActualizarTotales()
        {
            decimal subtotal = 0m;
            foreach (Producto producto in lista)
            {
                subtotal += producto.Importe;
            }
            decimal iva = Math.Round(subtotal * UI.TasaIva, 2);
            decimal total = subtotal + iva;

            lblArticulos.Text = "Filas: " + lista.Count;
            lblSubtotal.Text = "Subtotal: " + UI.Dinero(subtotal);
            lblIva.Text = "IVA 16%: " + UI.Dinero(iva);
            lblTotal.Text = "Total: " + UI.Dinero(total);
        }
    }
}
