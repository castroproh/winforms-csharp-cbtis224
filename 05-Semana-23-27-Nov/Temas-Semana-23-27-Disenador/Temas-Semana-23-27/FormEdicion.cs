using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace TemasSemana
{
    // Tema 25: agregar, editar, eliminar y limpiar filas, con subtotal, IVA 16% y total.
    public partial class FormEdicion : Form
    {
        // BindingList avisa al DataGridView cuando se agregan o quitan filas.
        private readonly BindingList<Producto> lista = new BindingList<Producto>(DatosTienda.ObtenerProductos());

        public FormEdicion()
        {
            InitializeComponent();

            // Las columnas están en el Designer; aquí solo lo que no cabe en propiedades simples.
            ConfigurarGrid();
            // El icono se dibuja con GDI+ (Dibujo.cs), por eso se asigna aquí y no en el Designer.
            picEncabezado.Image = Dibujo.IconoLapiz(48);
            // Las categorías vienen de DatosTienda (datos en tiempo de ejecución).
            cmbCategoria.Items.AddRange(DatosTienda.Categorias);

            dgvProductos.DataSource = lista;
            // Se suscribe después de asignar el DataSource, como antes: así no se dispara
            // SelectionChanged mientras se enlaza la lista.
            dgvProductos.SelectionChanged += DgvProductos_SelectionChanged;

            ActualizarTotales();
        }

        // Las columnas se definen en el Designer; el DataSource se asigna en el código.
        private void ConfigurarGrid()
        {
            dgvProductos.AutoGenerateColumns = false;
            colPrecio.DefaultCellStyle.FormatProvider = UI.Cultura;
            colImporte.DefaultCellStyle.FormatProvider = UI.Cultura;
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
