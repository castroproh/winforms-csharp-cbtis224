using System.Drawing.Printing;

namespace Temas_Semana_30_nov_4_dic
{
    // Tema 27: pago, descuento, cambio y ticket (PrintPreviewDialog / PDF)
    public partial class FormTicket : FormBase
    {
        private static readonly decimal[] Porcentajes = { 0m, 5m, 10m, 15m };

        private Form regresarA;

        // Valores que se calculan en pantalla
        private decimal subtotal;
        private decimal descuento;
        private decimal iva;
        private decimal total;
        private decimal pctDescuento;

        // Datos congelados al momento de cobrar (los usa el ticket)
        private List<ItemVenta> itemsTicket = new List<ItemVenta>();
        private decimal pago;
        private decimal cambio;
        private DateTime fecha;
        private int folio;

        public FormTicket(Form regresar) : base("Pymasa - Ticket", 860, 560)
        {
            InitializeComponent();
            regresarA = regresar;

            // Imagen del encabezado dibujada en codigo y color de resalte de los botones
            picLogoEncabezado.Image = Estilo.Logo(96);
            AplicarHover(btnRegresar, btnPdf, btnPagar);

            cmbDescuento.SelectedIndex = 0;
            PintarResumen();
        }

        // Si se entra desde el menu sin haber capturado productos, se ofrece una venta de ejemplo
        private void FormTicket_Shown(object sender, EventArgs e)
        {
            if (Venta.Carrito.Count == 0)
            {
                DialogResult r = MessageBox.Show(
                    "Todavia no hay productos capturados (tema 26).\n¿Quieres cargar una venta de ejemplo para probar el ticket?",
                    "Pymasa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    Venta.Agregar(0, 2);
                    Venta.Agregar(2, 1);
                    Venta.Agregar(5, 3);
                    Venta.Agregar(4, 1);
                    PintarResumen();
                }
            }
            txtPago.Focus();
        }

        private void CmbDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecalcularTotales();
        }

        private void TxtPago_TextChanged(object sender, EventArgs e)
        {
            ActualizarCambioEnVivo();
        }

        // Llena la tabla con los productos de la venta y recalcula
        private void PintarResumen()
        {
            dgvResumen.Rows.Clear();
            foreach (ItemVenta it in Venta.Carrito)
            {
                dgvResumen.Rows.Add(it.Producto, it.Cantidad, Venta.Dinero(it.Subtotal));
            }
            if (dgvResumen.Rows.Count > 0)
            {
                dgvResumen.ClearSelection();
            }
            lblArticulos.Text = "Articulos: " + Venta.Articulos();
            RecalcularTotales();
        }

        // Descuento sobre el subtotal y el IVA se calcula sobre lo que queda
        private void RecalcularTotales()
        {
            if (cmbDescuento.SelectedIndex < 0) return;

            pctDescuento = Porcentajes[cmbDescuento.SelectedIndex];
            subtotal = Venta.Subtotal();
            descuento = Math.Round(subtotal * pctDescuento / 100m, 2, MidpointRounding.AwayFromZero);
            decimal baseGravable = subtotal - descuento;
            iva = Venta.Iva(baseGravable);
            total = baseGravable + iva;

            lblSubtotalValor.Text = Venta.Dinero(subtotal);
            lblDescuentoValor.Text = "-" + Venta.Dinero(descuento);
            lblIvaValor.Text = Venta.Dinero(iva);
            lblTotalValor.Text = Venta.Dinero(total);
            ActualizarCambioEnVivo();
        }

        // Muestra el cambio mientras se teclea el pago (sin mensajes de error)
        private void ActualizarCambioEnVivo()
        {
            decimal p;
            if (Venta.TryDinero(txtPago.Text, out p) && p >= total && total > 0m)
            {
                lblCambioValor.Text = Venta.Dinero(p - total);
            }
            else
            {
                lblCambioValor.Text = "---";
            }
        }

        // Valida el pago y congela los datos del ticket. Devuelve false si algo esta mal.
        private bool PrepararCobro()
        {
            if (Venta.Carrito.Count == 0)
            {
                MessageBox.Show("Error! \n no hay productos en la venta!! \n regresa al tema 26 para capturarlos!!",
                    "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPago.Text))
            {
                MessageBox.Show("Teclea el pago del cliente (efectivo recibido)!!",
                    "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPago.Focus();
                return false;
            }

            decimal p;
            if (!Venta.TryDinero(txtPago.Text, out p) || p <= 0m)
            {
                MessageBox.Show("Error! \n el pago debe ser un numero mayor a cero!! \n intentalo de nuevo!!",
                    "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPago.Text = "";
                txtPago.Focus();
                return false;
            }

            p = Math.Round(p, 2, MidpointRounding.AwayFromZero);
            if (p < total)
            {
                MessageBox.Show("El pago (" + Venta.Dinero(p) + ") no alcanza para cubrir el total (" + Venta.Dinero(total) + ")!!",
                    "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPago.Focus();
                txtPago.SelectAll();
                return false;
            }

            pago = p;
            cambio = p - total;
            fecha = DateTime.Now;
            folio = Venta.Folio;
            itemsTicket = new List<ItemVenta>(Venta.Carrito);
            return true;
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (!PrepararCobro()) return;

            MessageBox.Show("Pago recibido: " + Venta.Dinero(pago) + "\nTotal: " + Venta.Dinero(total) + "\nCambio: " + Venta.Dinero(cambio),
                "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (!MostrarVistaPrevia()) return;

            // Venta terminada
            Venta.Folio++;
            Venta.Limpiar();
            MessageBox.Show("¡Venta terminada!", "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Regresar();
        }

        private bool MostrarVistaPrevia()
        {
            try
            {
                using (PrintDocument pd = new PrintDocument())
                using (PrintPreviewDialog vista = new PrintPreviewDialog())
                {
                    pd.DocumentName = "Ticket Pymasa";
                    pd.PrintPage += Pd_PrintPage;
                    vista.Document = pd;
                    vista.Text = "Vista previa del ticket";
                    vista.StartPosition = FormStartPosition.CenterScreen;
                    vista.Width = 800;
                    vista.Height = 700;
                    vista.ShowDialog(this);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la vista previa del ticket.\n" + ex.Message,
                    "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Opcional: guarda el ticket como PDF con la impresora "Microsoft Print to PDF"
        private void BtnPdf_Click(object sender, EventArgs e)
        {
            if (!PrepararCobro()) return;

            bool existe = false;
            foreach (string impresora in PrinterSettings.InstalledPrinters)
            {
                if (impresora == "Microsoft Print to PDF") existe = true;
            }
            if (!existe)
            {
                MessageBox.Show("No se encontro la impresora \"Microsoft Print to PDF\" en esta computadora.",
                    "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog guardar = new SaveFileDialog())
            {
                guardar.Filter = "Archivo PDF (*.pdf)|*.pdf";
                guardar.FileName = "Ticket_" + folio.ToString("000000") + ".pdf";
                guardar.Title = "Guardar ticket como PDF";
                if (guardar.ShowDialog(this) != DialogResult.OK) return;

                try
                {
                    using (PrintDocument pd = new PrintDocument())
                    {
                        pd.DocumentName = "Ticket Pymasa";
                        pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                        pd.PrinterSettings.PrintToFile = true;
                        pd.PrinterSettings.PrintFileName = guardar.FileName;
                        pd.PrintController = new StandardPrintController();
                        pd.PrintPage += Pd_PrintPage;
                        pd.Print();
                    }
                    MessageBox.Show("PDF guardado en:\n" + guardar.FileName,
                        "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo crear el PDF.\n" + ex.Message,
                        "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Dibuja el ticket (se usa para la vista previa y para el PDF)
        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            float ancho = 300f;                                   // 3 pulgadas
            float x = (e.PageBounds.Width - ancho) / 2f;
            float y = e.MarginBounds.Top;

            using (Font fNormal = new Font("Courier New", 9f))
            using (Font fNegrita = new Font("Courier New", 9f, FontStyle.Bold))
            using (Font fTitulo = new Font("Courier New", 16f, FontStyle.Bold))
            using (Font fGrande = new Font("Courier New", 12f, FontStyle.Bold))
            using (Pen guiones = new Pen(Color.Black, 1f))
            {
                guiones.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                // Encabezado con logo dibujado en codigo
                using (Bitmap logo = Estilo.Logo(160))
                {
                    g.DrawImage(logo, x + (ancho - 60f) / 2f, y, 60f, 60f);
                }
                y += 68f;

                Centrado(g, "PYMASA", fTitulo, x, ancho, ref y);
                Centrado(g, "Punto de venta", fNormal, x, ancho, ref y);
                Centrado(g, "TICKET DE VENTA", fNegrita, x, ancho, ref y);
                y += 6f;

                Par(g, "Folio:", folio.ToString("000000"), fNormal, x, ancho, ref y);
                Par(g, "Fecha:", fecha.ToString("dd/MM/yyyy"), fNormal, x, ancho, ref y);
                Par(g, "Hora:", fecha.ToString("HH:mm:ss"), fNormal, x, ancho, ref y);
                Par(g, "Cajero:", Venta.Usuario, fNormal, x, ancho, ref y);
                Linea(g, guiones, x, ancho, ref y);

                // Productos
                Par(g, "PRODUCTO", "IMPORTE", fNegrita, x, ancho, ref y);
                foreach (ItemVenta it in itemsTicket)
                {
                    Izquierda(g, it.Producto, fNormal, x, ancho, ref y);
                    Par(g, "  " + it.Cantidad + " x " + Venta.Dinero(it.Precio), Venta.Dinero(it.Subtotal), fNormal, x, ancho, ref y);
                }
                Linea(g, guiones, x, ancho, ref y);

                // Totales
                Par(g, "Subtotal:", Venta.Dinero(subtotal), fNormal, x, ancho, ref y);
                if (descuento > 0m)
                {
                    Par(g, "Descuento " + pctDescuento.ToString("0") + "%:", "-" + Venta.Dinero(descuento), fNormal, x, ancho, ref y);
                }
                Par(g, "IVA 16%:", Venta.Dinero(iva), fNormal, x, ancho, ref y);
                y += 4f;
                Par(g, "TOTAL:", Venta.Dinero(total), fGrande, x, ancho, ref y);
                y += 4f;
                Par(g, "Efectivo:", Venta.Dinero(pago), fNormal, x, ancho, ref y);
                Par(g, "Cambio:", Venta.Dinero(cambio), fNegrita, x, ancho, ref y);
                Linea(g, guiones, x, ancho, ref y);

                Centrado(g, "Articulos: " + TotalArticulos(), fNormal, x, ancho, ref y);
                y += 8f;
                Centrado(g, "¡Gracias por su compra!", fGrande, x, ancho, ref y);
            }

            e.HasMorePages = false;
        }

        private int TotalArticulos()
        {
            int n = 0;
            foreach (ItemVenta it in itemsTicket) n += it.Cantidad;
            return n;
        }

        private static void Centrado(Graphics g, string texto, Font f, float x, float ancho, ref float y)
        {
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                float alto = f.GetHeight(g);
                g.DrawString(texto, f, Brushes.Black, new RectangleF(x, y, ancho, alto), sf);
                y += alto + 2f;
            }
        }

        private static void Izquierda(Graphics g, string texto, Font f, float x, float ancho, ref float y)
        {
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Near;
                sf.Trimming = StringTrimming.EllipsisCharacter;
                sf.FormatFlags = StringFormatFlags.NoWrap;
                float alto = f.GetHeight(g);
                g.DrawString(texto, f, Brushes.Black, new RectangleF(x, y, ancho, alto), sf);
                y += alto + 2f;
            }
        }

        // Texto a la izquierda y otro alineado a la derecha en el mismo renglon
        private static void Par(Graphics g, string izq, string der, Font f, float x, float ancho, ref float y)
        {
            float alto = f.GetHeight(g);
            using (StringFormat sfIzq = new StringFormat())
            using (StringFormat sfDer = new StringFormat())
            {
                sfIzq.Alignment = StringAlignment.Near;
                sfIzq.FormatFlags = StringFormatFlags.NoWrap;
                sfDer.Alignment = StringAlignment.Far;
                sfDer.FormatFlags = StringFormatFlags.NoWrap;
                g.DrawString(izq, f, Brushes.Black, new RectangleF(x, y, ancho, alto), sfIzq);
                g.DrawString(der, f, Brushes.Black, new RectangleF(x, y, ancho, alto), sfDer);
            }
            y += alto + 2f;
        }

        private static void Linea(Graphics g, Pen lapiz, float x, float ancho, ref float y)
        {
            y += 3f;
            g.DrawLine(lapiz, x, y, x + ancho, y);
            y += 6f;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Regresar();
        }

        private void Regresar()
        {
            regresarA.Show();
            navegando = true;
            this.Close();
        }
    }
}
