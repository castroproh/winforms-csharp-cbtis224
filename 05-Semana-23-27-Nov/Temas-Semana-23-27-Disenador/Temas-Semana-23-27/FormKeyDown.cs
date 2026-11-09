using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace TemasSemana
{
    // Tema 21: evento KeyDown con KeyPreview activado.
    public partial class FormKeyDown : Form
    {
        private readonly List<Producto> productos = DatosTienda.ObtenerProductos();
        private Producto editando;

        public FormKeyDown()
        {
            // KeyPreview = true (en el Designer) hace que el formulario reciba la tecla
            // antes que el control que tiene el foco.
            InitializeComponent();

            // El icono se dibuja con GDI+ (Dibujo.cs), por eso se asigna aquí y no en el Designer.
            picEncabezado.Image = Dibujo.IconoTeclado(48);
            RefrescarLista();
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
