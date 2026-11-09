using System.Drawing.Printing;

namespace PDV
{
    public partial class FormVenta : Form
    {
        // Lista de productos y sus precios
        Dictionary<string, decimal> preciosPinturas = new Dictionary<string, decimal>()
        {
            { "Pintura acrílica/plástica (interiores)", 350.00m },
            { "Pintura al temple (interiores)", 200.00m },
            { "Pintura elástica (interiores)", 420.00m },
            { "Pintura mate (interiores)", 330.00m },
            { "Pintura satinada (interiores)", 370.00m },
            { "Pintura brillante (interiores)", 400.00m },
            { "Pintura acrílica polisiloxano (exteriores)", 550.00m },
            { "Esmalte sintético (madera/metal)", 450.00m },
            { "Pintura epóxica (suelos/industrial)", 600.00m },
            { "Pintura de cal (económica/transpirable)", 180.00m },
            { "Pintura antigraffiti (protección)", 700.00m },
            { "Pintura ecológica (sin COV)", 480.00m },
            { "Estuco veneciano (decorativa)", 520.00m },
            { "Impermeabilizante acrílico (techos)", 780.00m },
            { "Sellador vinílico (base)", 260.00m },
            { "Primario anticorrosivo (metal)", 340.00m },
            { "Barniz marino (madera)", 510.00m },
            { "Thinner (1 L)", 95.00m },
            { "Aguarrás (1 L)", 85.00m },
            { "Brocha profesional 4 pulgadas", 75.00m },
            { "Rodillo antigota 9 pulgadas", 120.00m },
            { "Cinta de enmascarar", 45.00m }
        };

        // Totales de la venta actual (se muestran en pantalla y se imprimen)
        decimal subtotalActual = 0;
        decimal descuentoActual = 0;
        decimal ivaActual = 0;
        decimal totalActual = 0;
        decimal efectivoActual = 0;
        decimal cambioActual = 0;
        int folio = 1;

        public FormVenta()
        {
            InitializeComponent();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            CargarProductos("");
            CBDESCUENTO.SelectedIndex = 0;
            DGVVENTA.Columns["Precio"].DefaultCellStyle.Format = "C2";
            DGVVENTA.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
        }

        // ---------------- BUSCAR PRODUCTO ----------------
        // Llena el ComboBox solo con los productos que contienen el texto buscado
        private void CargarProductos(string filtro)
        {
            CBPRODUCTOS.Items.Clear();
            foreach (string nombre in preciosPinturas.Keys)
            {
                if (nombre.ToLower().Contains(filtro.ToLower()))
                {
                    CBPRODUCTOS.Items.Add(nombre);
                }
            }
            if (CBPRODUCTOS.Items.Count > 0)
            {
                CBPRODUCTOS.SelectedIndex = 0;
            }
        }

        private void TBBUSCAR_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(TBBUSCAR.Text.Trim());
        }

        // Muestra el precio del producto elegido
        private void CBPRODUCTOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBPRODUCTOS.SelectedIndex >= 0)
            {
                LPRECIO.Text = preciosPinturas[CBPRODUCTOS.Text].ToString("C2");
            }
            else
            {
                LPRECIO.Text = "$0.00";
            }
        }

        // ---------------- COLOR ----------------
        private void TBCOLOR_TextChanged(object sender, EventArgs e)
        {
            string codigo = TBCOLOR.Text.Trim();
            if (!codigo.StartsWith("#"))
            {
                codigo = "#" + codigo;
            }
            try
            {
                PCOLOR.BackColor = ColorTranslator.FromHtml(codigo);
            }
            catch
            {
                // Si el código no es válido, se pone blanco
                PCOLOR.BackColor = Color.White;
            }
        }

        // ---------------- SOLO NÚMEROS ----------------
        private void TBCANTIDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBEFECTIVO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        // ---------------- AGREGAR ----------------
        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            // Validar cliente
            string nombreCliente = TBCLIENTE.Text;
            if (nombreCliente.Trim() == "")
            {
                MessageBox.Show("Ingresa el nombre del cliente.");
                return;
            }

            // Validar producto
            if (CBPRODUCTOS.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            // Validar cantidad
            int cantidad;
            if (!int.TryParse(TBCANTIDAD.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Introduce una cantidad válida.");
                return;
            }

            string producto = CBPRODUCTOS.Text;
            string codigoColor = TBCOLOR.Text.Trim();
            if (codigoColor == "")
            {
                codigoColor = "#FFFFFF";
            }
            decimal precioUnitario = preciosPinturas[producto];
            decimal subtotal = cantidad * precioUnitario;

            DGVVENTA.Rows.Add(DGVVENTA.Rows.Count + 1, nombreCliente, producto, codigoColor, precioUnitario, cantidad, subtotal);

            TBCANTIDAD.Clear();
            TBCOLOR.Clear();
            ActualizarTotales();
        }

        // ---------------- EDITAR ----------------
        // Pasa los datos de la fila seleccionada otra vez a las cajas y la quita de la tabla
        private void BEDITAR_Click(object sender, EventArgs e)
        {
            if (DGVVENTA.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = DGVVENTA.SelectedRows[0];
                TBCLIENTE.Text = fila.Cells["Cliente"].Value.ToString();
                TBBUSCAR.Clear();
                CBPRODUCTOS.Text = fila.Cells["Producto"].Value.ToString();
                TBCOLOR.Text = fila.Cells["CodigoColor"].Value.ToString();
                TBCANTIDAD.Text = fila.Cells["Cantidad"].Value.ToString();
                DGVVENTA.Rows.Remove(fila);
                Renumerar();
                ActualizarTotales();
            }
            else
            {
                MessageBox.Show("Selecciona un producto para editar.");
            }
        }

        // ---------------- ELIMINAR ----------------
        private void BELIMINAR_Click(object sender, EventArgs e)
        {
            if (DGVVENTA.SelectedRows.Count > 0)
            {
                DGVVENTA.Rows.Remove(DGVVENTA.SelectedRows[0]);
                Renumerar();
                ActualizarTotales();
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar.");
            }
        }

        // ---------------- LIMPIAR ----------------
        private void BLIMPIAR_Click(object sender, EventArgs e)
        {
            DGVVENTA.Rows.Clear();
            TBCLIENTE.Clear();
            TBTELEFONO.Clear();
            TBBUSCAR.Clear();
            TBCANTIDAD.Clear();
            TBCOLOR.Clear();
            TBEFECTIVO.Clear();
            CBDESCUENTO.SelectedIndex = 0;
            ActualizarTotales();
        }

        // Vuelve a poner los números 1, 2, 3... en la primera columna
        private void Renumerar()
        {
            for (int i = 0; i < DGVVENTA.Rows.Count; i++)
            {
                DGVVENTA.Rows[i].Cells["Num"].Value = i + 1;
            }
        }

        // ---------------- TOTALES, DESCUENTO Y CAMBIO ----------------
        private void CBDESCUENTO_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTotales();
        }

        private void TBEFECTIVO_TextChanged(object sender, EventArgs e)
        {
            ActualizarCambio();
        }

        private void ActualizarTotales()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow fila in DGVVENTA.Rows)
            {
                subtotal += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
            }

            decimal porcentaje = 0;
            decimal.TryParse(CBDESCUENTO.Text, out porcentaje);

            decimal descuento = subtotal * porcentaje / 100;      // descuento en dinero
            decimal iva = (subtotal - descuento) * 0.16m;         // 16% de IVA sobre lo ya descontado
            decimal total = subtotal - descuento + iva;

            subtotalActual = subtotal;
            descuentoActual = descuento;
            ivaActual = iva;
            totalActual = total;

            LSUBTOTAL.Text = subtotal.ToString("C2");
            LDESCUENTO.Text = "-" + descuento.ToString("C2");
            LIVA.Text = iva.ToString("C2");
            LTOTAL.Text = total.ToString("C2");

            ActualizarCambio();
        }

        private void ActualizarCambio()
        {
            decimal efectivo = 0;
            decimal.TryParse(TBEFECTIVO.Text, out efectivo);
            efectivoActual = efectivo;

            if (efectivo == 0)
            {
                cambioActual = 0;
                LCAMBIO.Text = "$0.00";
                LCAMBIO.ForeColor = Color.Black;
            }
            else if (efectivo >= totalActual)
            {
                cambioActual = efectivo - totalActual;
                LCAMBIO.Text = cambioActual.ToString("C2");
                LCAMBIO.ForeColor = Color.DarkGreen;
            }
            else
            {
                cambioActual = 0;
                LCAMBIO.Text = "Falta " + (totalActual - efectivo).ToString("C2");
                LCAMBIO.ForeColor = Color.Red;
            }
        }

        // ---------------- PAGAR E IMPRIMIR ----------------
        private void BPAGAR_Click(object sender, EventArgs e)
        {
            if (DGVVENTA.Rows.Count == 0)
            {
                MessageBox.Show("Agrega al menos un producto.");
                return;
            }
            if (efectivoActual < totalActual)
            {
                MessageBox.Show("El efectivo no alcanza para pagar.");
                TBEFECTIVO.Focus();
                return;
            }

            PrintDocument ticket = new PrintDocument();
            ticket.PrintPage += new PrintPageEventHandler(ImprimirTicket);

            // Vista previa
            PrintPreviewDialog vistaPrevia = new PrintPreviewDialog();
            vistaPrevia.Document = ticket;
            vistaPrevia.ShowDialog();

            // Nueva venta
            folio++;
            BLIMPIAR_Click(sender, e);
        }

        private void ImprimirTicket(object sender, PrintPageEventArgs e)
        {
            Font fontTitulo = new Font("Arial", 12, FontStyle.Bold);
            Font fontTexto = new Font("Arial", 9);
            float y = 20f;          // posición vertical inicial
            float margenX = 20f;

            // Encabezado
            e.Graphics.DrawString("PYMASA - Pinturas para profesionales", fontTitulo, Brushes.Black, new PointF(margenX, y));
            y += 22f;
            e.Graphics.DrawString("Culiacán, Sinaloa, México", fontTexto, Brushes.Black, new PointF(margenX, y));
            y += 18f;
            e.Graphics.DrawString("Folio: " + folio.ToString("0000") + "   Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fontTexto, Brushes.Black, new PointF(margenX, y));
            y += 18f;
            e.Graphics.DrawString("Cliente: " + TBCLIENTE.Text, fontTexto, Brushes.Black, new PointF(margenX, y));
            y += 18f;
            e.Graphics.DrawString("-------------------------------------------------------------", fontTexto, Brushes.Black, new PointF(margenX, y));
            y += 18f;
            e.Graphics.DrawString("Producto                                   Color      Cant   Importe", fontTexto, Brushes.Black, new PointF(margenX, y));
            y += 16f;

            // Una línea por cada fila de la tabla
            foreach (DataGridViewRow fila in DGVVENTA.Rows)
            {
                string producto = fila.Cells["Producto"].Value.ToString();
                if (producto.Length > 30)
                {
                    producto = producto.Substring(0, 30);
                }
                string color = fila.Cells["CodigoColor"].Value.ToString();
                string cantidad = fila.Cells["Cantidad"].Value.ToString();
                decimal subFila = Convert.ToDecimal(fila.Cells["Subtotal"].Value);

                e.Graphics.DrawString(producto, fontTexto, Brushes.Black, new PointF(margenX, y));
                e.Graphics.DrawString(color, fontTexto, Brushes.Black, new PointF(margenX + 230, y));
                e.Graphics.DrawString(cantidad, fontTexto, Brushes.Black, new PointF(margenX + 300, y));
                e.Graphics.DrawString(subFila.ToString("C2"), fontTexto, Brushes.Black, new PointF(margenX + 340, y));
                y += 14f;
            }

            y += 8f;
            e.Graphics.DrawString("-------------------------------------------------------------", fontTexto, Brushes.Black, new PointF(margenX, y));
            y += 18f;

            // Totales
            e.Graphics.DrawString("Subtotal: " + subtotalActual.ToString("C2"), fontTexto, Brushes.Black, new PointF(margenX, y));
            y += 16f;
            if (descuentoActual > 0)
            {
                e.Graphics.DrawString("Descuento (" + CBDESCUENTO.Text + "%): -" + descuentoActual.ToString("C2"), fontTexto, Brushes.Black, new PointF(margenX, y));
                y += 16f;
            }
            e.Graphics.DrawString("IVA (16%): " + ivaActual.ToString("C2"), fontTexto, Brushes.Black, new PointF(margenX, y));
            y += 16f;
            e.Graphics.DrawString("TOTAL: " + totalActual.ToString("C2"), fontTitulo, Brushes.Black, new PointF(margenX, y));
            y += 22f;
            e.Graphics.DrawString("Efectivo: " + efectivoActual.ToString("C2"), fontTexto, Brushes.Black, new PointF(margenX, y));
            y += 16f;
            e.Graphics.DrawString("Cambio: " + cambioActual.ToString("C2"), fontTexto, Brushes.Black, new PointF(margenX, y));
            y += 22f;
            e.Graphics.DrawString("¡Gracias por su compra!", fontTexto, Brushes.Black, new PointF(margenX, y));
        }
    }
}
