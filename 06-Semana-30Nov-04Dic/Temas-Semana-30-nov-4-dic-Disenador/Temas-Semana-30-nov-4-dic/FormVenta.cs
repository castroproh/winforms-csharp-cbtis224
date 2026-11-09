namespace Temas_Semana_30_nov_4_dic
{
    // Tema 26 (parte 2): pantalla de venta con DataGridView
    public partial class FormVenta : FormBase
    {
        private Form menu;

        public FormVenta(Form menuPrincipal) : base("Pymasa - Ticket de venta", 960, 600)
        {
            InitializeComponent();
            menu = menuPrincipal;

            // Imagen del encabezado dibujada en codigo y color de resalte de los botones
            picLogoEncabezado.Image = Estilo.Logo(96);
            AplicarHover(btnAgregar, btnQuitar, btnLimpiar, btnPagar, btnRegresar);

            // Datos que dependen de la venta en ejecucion
            lblUsuario.Text = "Cajero: " + Venta.Usuario;
            lblFecha.Text = Convert.ToString(DateTime.Now);
            for (int i = 0; i < Venta.Nombres.Length; i++)
            {
                cmbProducto.Items.Add(Venta.Nombres[i]);
            }

            cmbProducto.SelectedIndex = 0;
            ActualizarPantalla();
        }

        private void FormVenta_Shown(object sender, EventArgs e)
        {
            cmbProducto.Focus();
        }

        // Cuando se regresa desde el ticket, se vuelve a pintar la lista
        private void FormVenta_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                lblFecha.Text = Convert.ToString(DateTime.Now);
                ActualizarPantalla();
            }
        }

        private void CmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex >= 0)
            {
                txtPrecio.Text = Venta.Dinero(Venta.Precios[cmbProducto.SelectedIndex]);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex < 0)
            {
                MessageBox.Show("Elige un producto de la lista!!", "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProducto.Focus();
                return;
            }

            int cantidad;
            if (!int.TryParse(txtCantidad.Text.Trim(), out cantidad) || cantidad < 1 || cantidad > Venta.MaxPorProducto)
            {
                MessageBox.Show("Error! \n la cantidad debe ser un numero entero de 1 a " + Venta.MaxPorProducto + "!! \n intentalo de nuevo!!",
                    "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Text = "1";
                txtCantidad.Focus();
                txtCantidad.SelectAll();
                return;
            }

            if (!Venta.Agregar(cmbProducto.SelectedIndex, cantidad))
            {
                MessageBox.Show("No se puede tener mas de " + Venta.MaxPorProducto + " piezas del mismo producto!!",
                    "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return;
            }

            ActualizarPantalla();
            txtCantidad.Text = "1";
            cmbProducto.Focus();
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona en la tabla el producto que quieres quitar!!",
                    "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int indice = dgvVenta.SelectedRows[0].Index;
            if (indice >= 0 && indice < Venta.Carrito.Count)
            {
                Venta.Carrito.RemoveAt(indice);
                ActualizarPantalla();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if (Venta.Carrito.Count == 0)
            {
                MessageBox.Show("La venta ya esta vacia.", "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult r = MessageBox.Show("¿Seguro que quieres borrar todos los productos de la venta?",
                "Pymasa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Venta.Limpiar();
                ActualizarPantalla();
            }
        }

        // Pasa al tema 27 (pago, descuento, cambio y ticket)
        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (Venta.Carrito.Count == 0)
            {
                MessageBox.Show("Error! \n no hay productos en la venta!! \n agrega al menos uno antes de pagar!!",
                    "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProducto.Focus();
                return;
            }

            FormTicket ticket = new FormTicket(this);
            ticket.Show();
            this.Hide();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            menu.Show();
            navegando = true;
            this.Close();
        }

        // Vuelve a llenar la tabla y los totales con lo que hay en Venta.Carrito
        private void ActualizarPantalla()
        {
            dgvVenta.Rows.Clear();
            foreach (ItemVenta it in Venta.Carrito)
            {
                dgvVenta.Rows.Add(it.Producto, Venta.Dinero(it.Precio), it.Cantidad, Venta.Dinero(it.Subtotal));
            }
            if (dgvVenta.Rows.Count > 0)
            {
                dgvVenta.ClearSelection();
            }

            decimal subtotal = Venta.Subtotal();
            decimal iva = Venta.Iva(subtotal);
            decimal total = subtotal + iva;

            lblSubtotalValor.Text = Venta.Dinero(subtotal);
            lblIvaValor.Text = Venta.Dinero(iva);
            lblTotalValor.Text = Venta.Dinero(total);
            lblArticulos.Text = "Articulos: " + Venta.Articulos();
        }
    }
}
