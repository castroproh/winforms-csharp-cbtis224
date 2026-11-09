using System.ComponentModel;

namespace Temas_Semana_30_nov_4_dic
{
    // Tema 26 (parte 2): pantalla de venta con DataGridView
    [DesignerCategory("Code")]
    public class FormVenta : FormBase
    {
        private Form menu;

        private Panel pnlEncabezado;
        private Label lblUsuario;
        private Label lblFecha;

        private GroupBox gbAgregar;
        private Label lblProducto;
        private ComboBox cmbProducto;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Button btnAgregar;

        private DataGridView dgvVenta;
        private Label lblArticulos;

        private GroupBox gbTotales;
        private Label lblSubtotalTxt;
        private Label lblSubtotalValor;
        private Label lblIvaTxt;
        private Label lblIvaValor;
        private Label lblTotalTxt;
        private Label lblTotalValor;

        private Button btnQuitar;
        private Button btnLimpiar;
        private Button btnPagar;
        private Button btnRegresar;

        public FormVenta(Form menuPrincipal) : base("Pymasa - Ticket de venta", 960, 600)
        {
            menu = menuPrincipal;

            // ----- Encabezado -----
            pnlEncabezado = Estilo.Encabezado("PYMASA - Punto de venta", 960);
            Controls.Add(pnlEncabezado);

            lblUsuario = Estilo.Etiqueta("Cajero: " + Venta.Usuario, 640, 10, 300, 26, 10f, true, ContentAlignment.MiddleRight);
            lblUsuario.ForeColor = Color.White;
            pnlEncabezado.Controls.Add(lblUsuario);

            lblFecha = Estilo.Etiqueta("", 640, 36, 300, 24, 9f, false, ContentAlignment.MiddleRight);
            lblFecha.ForeColor = Color.Gainsboro;
            lblFecha.Text = Convert.ToString(DateTime.Now);
            pnlEncabezado.Controls.Add(lblFecha);

            // ----- Agregar producto -----
            gbAgregar = new GroupBox();
            gbAgregar.Text = "Agregar producto";
            gbAgregar.SetBounds(20, 85, 920, 78);
            gbAgregar.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            Controls.Add(gbAgregar);

            lblProducto = Estilo.Etiqueta("Producto:", 15, 32, 70, 26, 10f, false, ContentAlignment.MiddleLeft);
            gbAgregar.Controls.Add(lblProducto);

            cmbProducto = new ComboBox();
            cmbProducto.SetBounds(90, 31, 230, 28);
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.Font = new Font("Segoe UI", 10f);
            for (int i = 0; i < Venta.Nombres.Length; i++)
            {
                cmbProducto.Items.Add(Venta.Nombres[i]);
            }
            gbAgregar.Controls.Add(cmbProducto);

            lblPrecio = Estilo.Etiqueta("Precio:", 340, 32, 55, 26, 10f, false, ContentAlignment.MiddleLeft);
            gbAgregar.Controls.Add(lblPrecio);

            txtPrecio = new TextBox();
            txtPrecio.SetBounds(398, 31, 90, 28);
            txtPrecio.ReadOnly = true;
            txtPrecio.Font = new Font("Segoe UI", 10f);
            gbAgregar.Controls.Add(txtPrecio);

            lblCantidad = Estilo.Etiqueta("Cantidad:", 510, 32, 70, 26, 10f, false, ContentAlignment.MiddleLeft);
            gbAgregar.Controls.Add(lblCantidad);

            txtCantidad = new TextBox();
            txtCantidad.SetBounds(585, 31, 60, 28);
            txtCantidad.Text = "1";
            txtCantidad.Font = new Font("Segoe UI", 10f);
            gbAgregar.Controls.Add(txtCantidad);

            btnAgregar = Estilo.Boton("Agregar", 670, 27, 150, 34, Estilo.Principal);
            btnAgregar.Click += BtnAgregar_Click;
            gbAgregar.Controls.Add(btnAgregar);

            // ----- DataGridView -----
            dgvVenta = new DataGridView();
            dgvVenta.SetBounds(20, 180, 620, 330);
            dgvVenta.Columns.Add("colProducto", "Producto");
            dgvVenta.Columns.Add("colPrecio", "Precio");
            dgvVenta.Columns.Add("colCantidad", "Cantidad");
            dgvVenta.Columns.Add("colSubtotal", "Subtotal");
            Estilo.EstiloGrid(dgvVenta);
            dgvVenta.Columns[0].FillWeight = 190;
            dgvVenta.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVenta.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVenta.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Controls.Add(dgvVenta);

            lblArticulos = Estilo.Etiqueta("Articulos: 0", 20, 518, 300, 26, 10f, true, ContentAlignment.MiddleLeft);
            lblArticulos.ForeColor = Estilo.Oscuro;
            Controls.Add(lblArticulos);

            // ----- Totales -----
            gbTotales = new GroupBox();
            gbTotales.Text = "Totales";
            gbTotales.SetBounds(660, 180, 280, 195);
            gbTotales.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            Controls.Add(gbTotales);

            lblSubtotalTxt = Estilo.Etiqueta("Subtotal:", 15, 32, 110, 28, 11f, false, ContentAlignment.MiddleLeft);
            gbTotales.Controls.Add(lblSubtotalTxt);
            lblSubtotalValor = Estilo.Etiqueta("$0.00", 125, 32, 140, 28, 11f, true, ContentAlignment.MiddleRight);
            gbTotales.Controls.Add(lblSubtotalValor);

            lblIvaTxt = Estilo.Etiqueta("IVA 16%:", 15, 72, 110, 28, 11f, false, ContentAlignment.MiddleLeft);
            gbTotales.Controls.Add(lblIvaTxt);
            lblIvaValor = Estilo.Etiqueta("$0.00", 125, 72, 140, 28, 11f, true, ContentAlignment.MiddleRight);
            gbTotales.Controls.Add(lblIvaValor);

            lblTotalTxt = Estilo.Etiqueta("TOTAL:", 15, 128, 100, 40, 14f, true, ContentAlignment.MiddleLeft);
            lblTotalTxt.ForeColor = Estilo.Principal;
            gbTotales.Controls.Add(lblTotalTxt);
            lblTotalValor = Estilo.Etiqueta("$0.00", 105, 128, 160, 40, 18f, true, ContentAlignment.MiddleRight);
            lblTotalValor.ForeColor = Estilo.Principal;
            gbTotales.Controls.Add(lblTotalValor);

            // ----- Botones -----
            btnQuitar = Estilo.Boton("Quitar producto", 660, 392, 134, 40, Estilo.Acento);
            btnQuitar.Click += BtnQuitar_Click;
            Controls.Add(btnQuitar);

            btnLimpiar = Estilo.Boton("Limpiar venta", 806, 392, 134, 40, Estilo.Rojo);
            btnLimpiar.Click += BtnLimpiar_Click;
            Controls.Add(btnLimpiar);

            btnPagar = Estilo.Boton("Pagar  (tema 27)", 660, 446, 280, 54, Estilo.Azul);
            btnPagar.Font = new Font("Segoe UI", 13f, FontStyle.Bold);
            btnPagar.Click += BtnPagar_Click;
            Controls.Add(btnPagar);

            btnRegresar = Estilo.Boton("Regresar al menu", 760, 530, 180, 38, Estilo.Oscuro);
            btnRegresar.Click += BtnRegresar_Click;
            Controls.Add(btnRegresar);

            // ----- Eventos -----
            cmbProducto.SelectedIndexChanged += CmbProducto_SelectedIndexChanged;
            VisibleChanged += FormVenta_VisibleChanged;
            Shown += FormVenta_Shown;
            AcceptButton = btnAgregar;

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
