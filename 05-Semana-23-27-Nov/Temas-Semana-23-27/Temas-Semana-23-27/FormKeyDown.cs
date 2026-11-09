using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace TemasSemana
{
    // Tema 21: evento KeyDown con KeyPreview activado.
    public class FormKeyDown : Form
    {
        private Label lblTecla;
        private Label lblAccion;
        private Label lblAyuda;
        private ListBox lstProductos;
        private TextBox txtBuscar;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private Button btnGuardar;

        private readonly List<Producto> productos = DatosTienda.ObtenerProductos();
        private Producto editando;

        public FormKeyDown()
        {
            UI.ConfigurarFormulario(this, "Tema 21 - KeyDown (atajos de teclado)", 900, 620);

            // KeyPreview hace que el formulario reciba la tecla antes que el control que tiene el foco.
            KeyPreview = true;

            ConstruirInterfaz();
            KeyDown += FormKeyDown_KeyDown;
            RefrescarLista();
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
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));

            layout.Controls.Add(
                UI.CrearEncabezado("KeyDown", "Atajos de teclado con KeyPreview activado", Dibujo.IconoTeclado(48)), 0, 0);

            lblTecla = new Label();
            lblTecla.Dock = DockStyle.Fill;
            lblTecla.Text = "Tecla presionada: (ninguna todavía)";
            lblTecla.Font = UI.Grande;
            lblTecla.ForeColor = UI.Azul;
            lblTecla.BackColor = Color.White;
            lblTecla.TextAlign = ContentAlignment.MiddleCenter;
            lblTecla.Margin = new Padding(10, 6, 10, 0);
            layout.Controls.Add(lblTecla, 0, 1);

            lblAccion = new Label();
            lblAccion.Dock = DockStyle.Fill;
            lblAccion.Text = "Prueba los atajos de abajo con el teclado.";
            lblAccion.TextAlign = ContentAlignment.MiddleCenter;
            lblAccion.ForeColor = Color.FromArgb(60, 60, 60);
            layout.Controls.Add(lblAccion, 0, 2);

            TableLayoutPanel cuerpo = new TableLayoutPanel();
            cuerpo.Dock = DockStyle.Fill;
            cuerpo.ColumnCount = 2;
            cuerpo.RowCount = 1;
            cuerpo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            cuerpo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            cuerpo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            lstProductos = new ListBox();
            lstProductos.Dock = DockStyle.Fill;
            lstProductos.Font = UI.Normal;
            lstProductos.IntegralHeight = false;
            lstProductos.Margin = new Padding(10);
            cuerpo.Controls.Add(lstProductos, 0, 0);

            Panel panelCampos = new Panel();
            panelCampos.Dock = DockStyle.Fill;
            panelCampos.BackColor = Color.White;
            panelCampos.Margin = new Padding(0, 10, 10, 10);

            txtBuscar = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();

            int y = 8;
            UI.AgregarCampo(panelCampos, "Buscar por nombre (F3)", txtBuscar, ref y);
            UI.AgregarCampo(panelCampos, "Nombre", txtNombre, ref y);
            UI.AgregarCampo(panelCampos, "Precio", txtPrecio, ref y);
            UI.AgregarCampo(panelCampos, "Cantidad", txtCantidad, ref y);

            btnGuardar = UI.CrearBoton("Guardar (nuevo o editado)", 240, BtnGuardar_Click);
            btnGuardar.Location = new Point(12, y);
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCampos.Controls.Add(btnGuardar);

            txtBuscar.TextChanged += TxtBuscar_TextChanged;

            cuerpo.Controls.Add(panelCampos, 1, 0);
            layout.Controls.Add(cuerpo, 0, 3);

            lblAyuda = new Label();
            lblAyuda.Dock = DockStyle.Fill;
            lblAyuda.Text = "F2 Nuevo   |   F3 Buscar   |   F4 Editar el seleccionado   |   F5 Actualizar lista\r\n" +
                            "Supr Eliminar   |   Ctrl+D Duplicar   |   F9 Cobrar (subtotal, IVA y total)";
            lblAyuda.TextAlign = ContentAlignment.MiddleCenter;
            lblAyuda.BackColor = UI.AzulClaro;
            lblAyuda.ForeColor = UI.Azul;
            lblAyuda.Font = UI.Negrita;
            lblAyuda.Margin = new Padding(0);
            layout.Controls.Add(lblAyuda, 0, 4);

            Controls.Add(layout);
        }

        // ---------- Evento KeyDown del formulario ----------

        private void FormKeyDown_KeyDown(object sender, KeyEventArgs e)
        {
            lblTecla.Text = "Tecla presionada: " + NombreTecla(e);

            bool atendida = true;
            try
            {
                switch (e.KeyData)
                {
                    case Keys.F2:
                        NuevoProducto();
                        break;
                    case Keys.F3:
                        BuscarProducto();
                        break;
                    case Keys.F4:
                        EditarSeleccionado();
                        break;
                    case Keys.F5:
                        ActualizarLista();
                        break;
                    case Keys.Delete:
                        // Si el usuario está escribiendo en una caja, Supr debe borrar texto, no productos.
                        if (ActiveControl is TextBox)
                        {
                            atendida = false;
                            lblAccion.Text = "Supr borra texto mientras escribes en un campo; sal del campo para eliminar productos.";
                        }
                        else
                        {
                            EliminarSeleccionado();
                        }
                        break;
                    case Keys.Control | Keys.D:
                        DuplicarSeleccionado();
                        break;
                    case Keys.F9:
                        Cobrar();
                        break;
                    default:
                        atendida = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                UI.MostrarError("No se pudo ejecutar el atajo: " + ex.Message);
            }

            if (atendida)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private static string NombreTecla(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                return "Ctrl";
            }
            if (e.KeyCode == Keys.ShiftKey)
            {
                return "Shift";
            }
            if (e.KeyCode == Keys.Menu)
            {
                return "Alt";
            }

            string nombre = e.KeyCode == Keys.Delete ? "Supr (Delete)" : e.KeyCode.ToString();
            string prefijo = string.Empty;
            if (e.Control)
            {
                prefijo += "Ctrl+";
            }
            if (e.Alt)
            {
                prefijo += "Alt+";
            }
            if (e.Shift)
            {
                prefijo += "Shift+";
            }
            return prefijo + nombre;
        }

        // ---------- Acciones de los atajos ----------

        private void NuevoProducto()
        {
            editando = null;
            LimpiarCampos();
            txtNombre.Focus();
            lblAccion.Text = "F2: campos limpios, listo para capturar un producto nuevo.";
        }

        private void BuscarProducto()
        {
            txtBuscar.Focus();
            txtBuscar.SelectAll();
            lblAccion.Text = "F3: escribe el nombre que buscas.";
        }

        private void EditarSeleccionado()
        {
            Producto seleccionado = lstProductos.SelectedItem as Producto;
            if (seleccionado == null)
            {
                UI.Aviso("Selecciona un producto de la lista para editarlo.");
                return;
            }

            editando = seleccionado;
            txtNombre.Text = seleccionado.Nombre;
            txtPrecio.Text = seleccionado.Precio.ToString("0.00", CultureInfo.InvariantCulture);
            txtCantidad.Text = seleccionado.Cantidad.ToString(CultureInfo.InvariantCulture);
            txtNombre.Focus();
            lblAccion.Text = "F4: editando \"" + seleccionado.Nombre + "\". Cambia los datos y pulsa Guardar.";
        }

        private void ActualizarLista()
        {
            txtBuscar.Clear();
            RefrescarLista();
            lblAccion.Text = "F5: lista actualizada (" + productos.Count + " productos).";
        }

        private void EliminarSeleccionado()
        {
            Producto seleccionado = lstProductos.SelectedItem as Producto;
            if (seleccionado == null)
            {
                UI.Aviso("Selecciona un producto de la lista para eliminarlo.");
                return;
            }
            if (!UI.Confirmar("¿Eliminar \"" + seleccionado.Nombre + "\"?"))
            {
                return;
            }

            productos.Remove(seleccionado);
            if (editando == seleccionado)
            {
                editando = null;
                LimpiarCampos();
            }
            RefrescarLista();
            lblAccion.Text = "Supr: producto eliminado.";
        }

        private void DuplicarSeleccionado()
        {
            Producto seleccionado = lstProductos.SelectedItem as Producto;
            if (seleccionado == null)
            {
                UI.Aviso("Selecciona un producto de la lista para duplicarlo.");
                return;
            }

            Producto copia = new Producto(
                DatosTienda.SiguienteId(productos),
                seleccionado.Nombre + " (copia)",
                seleccionado.Categoria,
                seleccionado.Precio,
                seleccionado.Cantidad);
            productos.Add(copia);
            RefrescarLista();
            lstProductos.SelectedItem = copia;
            lblAccion.Text = "Ctrl+D: producto duplicado.";
        }

        private void Cobrar()
        {
            decimal subtotal = 0m;
            foreach (Producto producto in productos)
            {
                subtotal += producto.Importe;
            }
            decimal iva = Math.Round(subtotal * UI.TasaIva, 2);
            decimal total = subtotal + iva;

            UI.Informar(
                "Subtotal: " + UI.Dinero(subtotal) + "\r\n" +
                "IVA (16%): " + UI.Dinero(iva) + "\r\n" +
                "Total: " + UI.Dinero(total),
                "F9 - Cobrar");
            lblAccion.Text = "F9: total calculado, " + UI.Dinero(total) + ".";
        }

        // ---------- Guardar, buscar y lista ----------

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string categoria = editando != null ? editando.Categoria : "General";
                DatosProducto datos;
                string error;
                int campo;
                if (!Validacion.TryLeerProducto(txtNombre.Text, categoria, txtPrecio.Text, txtCantidad.Text,
                        out datos, out error, out campo))
                {
                    UI.Aviso(error);
                    EnfocarCampo(campo);
                    return;
                }

                if (editando == null)
                {
                    productos.Add(new Producto(
                        DatosTienda.SiguienteId(productos), datos.Nombre, datos.Categoria, datos.Precio, datos.Cantidad));
                    lblAccion.Text = "Producto agregado: " + datos.Nombre;
                }
                else
                {
                    editando.Nombre = datos.Nombre;
                    editando.Precio = datos.Precio;
                    editando.Cantidad = datos.Cantidad;
                    lblAccion.Text = "Producto actualizado: " + datos.Nombre;
                }

                editando = null;
                LimpiarCampos();
                RefrescarLista();
            }
            catch (Exception ex)
            {
                UI.MostrarError("No se pudo guardar el producto: " + ex.Message);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            RefrescarLista();
        }

        private void EnfocarCampo(int campo)
        {
            switch (campo)
            {
                case Validacion.CampoNombre:
                    txtNombre.Focus();
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
            txtPrecio.Clear();
            txtCantidad.Clear();
        }

        private void RefrescarLista()
        {
            string filtro = txtBuscar.Text.Trim();
            List<Producto> vista = productos.Where(p => UI.Contiene(p.Nombre, filtro)).ToList();
            lstProductos.DataSource = null;
            lstProductos.DataSource = vista;
        }
    }
}
