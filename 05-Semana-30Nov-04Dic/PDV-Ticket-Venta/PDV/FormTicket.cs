using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace PDV
{
    public partial class FormTicket : Form
    {
        static readonly CultureInfo MX = CultureInfo.GetCultureInfo("es-MX");
        static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        // Catálogo de ejemplo (puedes cambiar nombres y precios)
        readonly Dictionary<string, decimal> precios = new Dictionary<string, decimal>
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
            { "Sellador vinílico 5 en 1 (base)", 260.00m },
            { "Primario anticorrosivo (metal)", 340.00m },
            { "Barniz marino (madera)", 510.00m },
            { "Thinner (1 L)", 95.00m },
            { "Aguarrás (1 L)", 85.00m },
            { "Resanador en pasta (1 kg)", 110.00m },
            { "Brocha profesional 4 pulgadas", 75.00m },
            { "Rodillo antigota 9 pulgadas", 120.00m },
            { "Charola para rodillo", 60.00m },
            { "Cinta de enmascarar", 45.00m },
            { "Lija al agua (pliego)", 12.00m }
        };

        static readonly decimal[] Descuentos = { 0m, 5m, 10m, 15m, 20m, 25m };
        static readonly decimal[] EfectivoRapido = { 0m, 200m, 500m, 1000m };

        readonly List<TicketItem> items = new List<TicketItem>();

        // copia del ticket que se imprime al cobrar
        List<TicketItem> snapshot = new List<TicketItem>();
        string snapCliente = "";
        int snapFolio = 1;
        decimal snapSub, snapDescPct, snapDesc, snapIva, snapTot, snapRec, snapCam;

        float phase;
        string cajero;
        ToastNotice toast;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        public FormTicket() : this("Alumno1") { }

        public FormTicket(string cajero)
        {
            this.cajero = cajero;
            InitializeComponent();
            DoubleBuffered = true;

            toast = new ToastNotice();
            Controls.Add(toast);
            toast.BringToFront();

            dgv.RowTemplate.Height = 28;
            FiltrarProductos();

            ticket.Items = items;
            ticket.PayFinished += (s, e) => BeginInvoke(new Action(TerminarPago));

            studio.ColorPicked += studio_ColorPicked;
            studio.Current = Theme.Paleta[1];

            chipDesc.Options = new[] { "0%", "5%", "10%", "15%", "20%", "25%" };
            chipDesc.Columns = 3;
            chipDesc.SelectedIndex = 0;
            chipDesc.ChipClicked += chipDesc_ChipClicked;

            chipCash.Options = new[] { "Exacto", "$200", "$500", "$1,000" };
            chipCash.Columns = 2;
            chipCash.Selectable = false;
            chipCash.ChipClicked += chipCash_ChipClicked;

            // resalta el campo activo con el color de acento
            foreach (Control c in new Control[] { txtCliente, txtTel, txtBuscar, txtCant, cmbProd, txtColor, txtRecibido })
            {
                c.GotFocus += (s, e) => FocoCambio();
                c.LostFocus += (s, e) => FocoCambio();
            }

            ActualizarCobro();
            ActualizarEstado();
            headerTimer_Tick(null, EventArgs.Empty);
            Opacity = 0;
            fadeTimer.Start();
            headerTimer.Start();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SendMessage(txtBuscar.Handle, 0x1501, IntPtr.Zero, "Nombre o tipo…");
            SendMessage(txtRecibido.Handle, 0x1501, IntPtr.Zero, "0.00");
            toast.Mostrar("Bienvenido, " + cajero + "  ·  Caja 01 lista para cobrar", ToastKind.Info);
        }

        void FocoCambio()
        {
            studio.HexFocused = txtColor.Focused;
            left.Invalidate();
            pay.Invalidate();
        }

        // ============ animaciones ============
        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            Opacity = Math.Min(1, Opacity + 0.07);
            if (Opacity >= 1) fadeTimer.Stop();
        }

        private void headerTimer_Tick(object sender, EventArgs e)
        {
            phase += 7f;
            var now = DateTime.Now;
            string t = now.ToString("HH:mm") + "\n" + now.ToString("ddd dd MMM", MX).ToUpper();
            if (lblReloj.Text != t) lblReloj.Text = t;
            header.Invalidate();
        }

        // ============ dibujo ============
        private void header_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // muestras de pintura que "bailan" en ola
            int n = Theme.Paleta.Length;
            float chipW = 14f, gap = 6f;
            float total = n * (chipW + gap) - gap;
            float startX = lblReloj.Left - 36f - total;
            for (int i = 0; i < n; i++)
            {
                float dy = (float)Math.Sin(phase / 60f + i * 0.55f) * 5f;
                var r = new RectangleF(startX + i * (chipW + gap), 22f + dy, chipW, 24f);
                using (var p = Theme.Rounded(r, 8))
                using (var b = new SolidBrush(Theme.Paleta[i]))
                    g.FillPath(b, p);
            }

            // barra de luz amarilla que recorre la base
            int w = 280;
            float bx = (phase % (header.Width + w)) - w;
            var br = new RectangleF(bx, header.Height - 4, w, 4);
            using (var lg = new LinearGradientBrush(br, Theme.Acento, Theme.Acento, 0f))
            {
                var cb = new ColorBlend(3);
                cb.Colors = new[] { Color.FromArgb(0, Theme.Acento), Theme.Acento, Color.FromArgb(0, Theme.Acento) };
                cb.Positions = new[] { 0f, 0.5f, 1f };
                lg.InterpolationColors = cb;
                g.FillRectangle(lg, br);
            }
        }

        static void DibujarCampo(Graphics g, Rectangle r, bool foco)
        {
            using (var p = Theme.Rounded(new RectangleF(r.X + 0.5f, r.Y + 0.5f, r.Width - 1f, r.Height - 1f), 16))
            using (var b = new SolidBrush(Theme.Input))
            using (var pen = new Pen(foco ? Theme.Acento : Theme.Borde, foco ? 1.5f : 1f))
            {
                g.FillPath(b, p);
                g.DrawPath(pen, p);
            }
        }

        static void DibujarTarjeta(Graphics g, RectangleF r)
        {
            using (var p = Theme.Rounded(r, 28))
            using (var b = new SolidBrush(Theme.Superficie))
            using (var pen = new Pen(Theme.Borde))
            {
                g.FillPath(b, p);
                g.DrawPath(pen, p);
            }
        }

        private void left_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            DibujarTarjeta(g, new RectangleF(24.5f, 8.5f, 711f, 148f));

            foreach (var c in new Control[] { txtCliente, txtTel, txtBuscar, txtCant })
                DibujarCampo(g, new Rectangle(c.Left - 8, c.Top - 6, c.Width + 16, c.Height + 12), c.Focused);
            DibujarCampo(g, new Rectangle(cmbProd.Left - 2, cmbProd.Top - 2, cmbProd.Width + 4, cmbProd.Height + 4), cmbProd.Focused);

            using (var pen = new Pen(Theme.Borde))
                g.DrawRectangle(pen, dgv.Left - 1, dgv.Top - 1, dgv.Width + 1, dgv.Height + 1);
        }

        private void pay_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            DibujarTarjeta(g, new RectangleF(8.5f, 8.5f, pay.Width - 17f, pay.Height - 17f));
            DibujarCampo(g, new Rectangle(txtRecibido.Left - 8, txtRecibido.Top - 6, txtRecibido.Width + 16, txtRecibido.Height + 12), txtRecibido.Focused);
        }

        // ============ buscar producto ============
        static string Normalizar(string s)
        {
            var d = (s ?? "").Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            foreach (char c in d)
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark) sb.Append(c);
            return sb.ToString().ToLowerInvariant().Trim();
        }

        void FiltrarProductos()
        {
            string q = Normalizar(txtBuscar.Text);
            string[] lista = precios.Keys.Where(k => q.Length == 0 || Normalizar(k).Contains(q)).ToArray();
            string actual = cmbProd.Text;

            cmbProd.BeginUpdate();
            cmbProd.Items.Clear();
            cmbProd.Items.AddRange(lista);
            cmbProd.EndUpdate();

            if (lista.Length > 0)
            {
                int i = Array.IndexOf(lista, actual);
                cmbProd.SelectedIndex = i >= 0 ? i : 0;
            }
            else
            {
                cmbProd.SelectedIndex = -1;
                lblPrecio.Text = "—";
            }
            lblProducto.Text = q.Length == 0
                ? "PRODUCTO"
                : "PRODUCTO  ·  " + lista.Length + " de " + precios.Count;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                txtCant.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                txtBuscar.Clear();
            }
        }

        private void cmbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal p;
            if (cmbProd.SelectedIndex >= 0 && precios.TryGetValue(cmbProd.Text, out p))
                lblPrecio.Text = p.ToString("C2", MX);
        }

        // ============ color ============
        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            Color c;
            if (Theme.TryColor(txtColor.Text, out c)) studio.Current = c;
        }

        void studio_ColorPicked(object sender, Color c)
        {
            txtColor.Text = Theme.ToHex(c);
            studio.Current = c;
        }

        // ============ entrada numérica ============
        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && "+- ()".IndexOf(e.KeyChar) < 0;
        }

        private void txtRecibido_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool ok = char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) ||
                      (e.KeyChar == '.' && txtRecibido.Text.IndexOf('.') < 0);
            e.Handled = !ok;
        }

        // ============ descuento / efectivo / cambio ============
        private void chipDesc_ChipClicked(object sender, int i)
        {
            ticket.Descuento = Descuentos[i];
            ActualizarCobro();
        }

        private void chipCash_ChipClicked(object sender, int i)
        {
            ticket.Recalc();
            decimal monto = i == 0 ? ticket.Total : EfectivoRapido[i];
            txtRecibido.Text = monto > 0m ? monto.ToString("0.00", Inv) : "";
            txtRecibido.Focus();
            txtRecibido.SelectionStart = txtRecibido.Text.Length;
        }

        private void txtRecibido_TextChanged(object sender, EventArgs e)
        {
            ActualizarCobro();
        }

        decimal LeerRecibido()
        {
            decimal r;
            return decimal.TryParse(txtRecibido.Text, NumberStyles.AllowDecimalPoint, Inv, out r) ? r : 0m;
        }

        void ActualizarCobro()
        {
            decimal rec = LeerRecibido();
            ticket.Recibido = rec;
            ticket.Recalc();
            decimal total = ticket.Total;
            lblTotal.Text = total.ToString("C2", MX);

            if (rec <= 0m)
            {
                lblCambioCap.Text = "CAMBIO";
                lblCambio.Text = "—";
                lblCambio.ForeColor = Theme.Texto2;
                lblCambioNota.Text = "Ingresa el efectivo recibido";
            }
            else if (rec >= total)
            {
                lblCambioCap.Text = "CAMBIO";
                lblCambio.Text = (rec - total).ToString("C2", MX);
                lblCambio.ForeColor = Theme.Exito;
                lblCambioNota.Text = rec == total ? "Pago exacto" : "Entregar al cliente";
            }
            else
            {
                lblCambioCap.Text = "FALTA";
                lblCambio.Text = (total - rec).ToString("C2", MX);
                lblCambio.ForeColor = Theme.Peligro;
                lblCambioNota.Text = "Aún no alcanza para cobrar";
            }
        }

        // ============ tabla (chip de color en la celda) ============
        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colColor.Index) return;
            e.PaintBackground(e.ClipBounds, true);
            string hex = Convert.ToString(e.Value);
            Color c;
            if (Theme.TryColor(hex, out c))
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                var r = new Rectangle(e.CellBounds.X + 8, e.CellBounds.Y + (e.CellBounds.Height - 14) / 2, 14, 14);
                using (var b = new SolidBrush(c)) g.FillEllipse(b, r);
                using (var p = new Pen(Theme.Borde)) g.DrawEllipse(p, r);
                TextRenderer.DrawText(g, hex, e.CellStyle.Font,
                    new Rectangle(e.CellBounds.X + 28, e.CellBounds.Y, e.CellBounds.Width - 28, e.CellBounds.Height),
                    e.CellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
            e.Handled = true;
        }

        // ============ sincronizar tabla y ticket ============
        void RefreshAll()
        {
            dgv.Rows.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                var it = items[i];
                dgv.Rows.Add(i + 1, it.Cliente, it.Producto, it.ColorHex,
                             it.Precio.ToString("C2", MX), it.Cantidad, it.Subtotal.ToString("C2", MX));
            }
            if (dgv.Rows.Count > 0) dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
            ticket.Items = items;
            ActualizarCobro();
        }

        // ============ botones ============
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ticket.Paying) return;
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                toast.Mostrar("Ingresa el nombre del cliente.", ToastKind.Aviso);
                txtCliente.Focus();
                return;
            }
            if (cmbProd.SelectedIndex < 0)
            {
                toast.Mostrar("No hay un producto seleccionado. Revisa tu búsqueda.", ToastKind.Aviso);
                txtBuscar.Focus();
                return;
            }
            int cant;
            if (!int.TryParse(txtCant.Text, out cant) || cant <= 0)
            {
                toast.Mostrar("Introduce una cantidad válida.", ToastKind.Aviso);
                txtCant.Focus();
                return;
            }
            Color col = Color.White;
            string hex = "#FFFFFF";
            if (txtColor.Text.Trim().Length > 0)
            {
                if (!Theme.TryColor(txtColor.Text, out col))
                {
                    toast.Mostrar("Código HEX inválido. Ejemplo: #FFD60A", ToastKind.Error);
                    txtColor.Focus();
                    return;
                }
                hex = Theme.ToHex(col);
            }

            string prod = cmbProd.Text;
            items.Add(new TicketItem
            {
                Cliente = txtCliente.Text.Trim(),
                Producto = prod,
                ColorHex = hex,
                Color = col,
                Precio = precios.ContainsKey(prod) ? precios[prod] : 0m,
                Cantidad = cant,
                Alpha = 0f
            });
            ticket.Cliente = txtCliente.Text.Trim();
            txtCant.Clear();
            txtColor.Clear();
            RefreshAll();
            toast.Mostrar("Agregado: " + cant + " × " + prod, ToastKind.Exito);
            txtCant.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ticket.Paying) return;
            if (dgv.SelectedRows.Count == 0)
            {
                toast.Mostrar("Selecciona un producto de la tabla para editar.", ToastKind.Aviso);
                return;
            }
            var it = items[dgv.SelectedRows[0].Index];
            txtBuscar.Clear();
            txtCliente.Text = it.Cliente;
            cmbProd.Text = it.Producto;
            txtColor.Text = it.ColorHex;
            txtCant.Text = it.Cantidad.ToString();
            items.Remove(it);
            RefreshAll();
            txtCant.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ticket.Paying) return;
            if (dgv.SelectedRows.Count == 0)
            {
                toast.Mostrar("Selecciona un producto de la tabla para eliminar.", ToastKind.Aviso);
                return;
            }
            items.RemoveAt(dgv.SelectedRows[0].Index);
            RefreshAll();
            toast.Mostrar("Producto eliminado del ticket.", ToastKind.Info);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (ticket.Paying) return;
            items.Clear();
            txtCliente.Clear(); txtTel.Clear(); txtCant.Clear(); txtColor.Clear(); txtBuscar.Clear();
            ReiniciarCobro();
            ticket.Cliente = "";
            RefreshAll();
        }

        void ReiniciarCobro()
        {
            ticket.Descuento = 0m;
            chipDesc.SelectedIndex = 0;
            txtRecibido.Clear();
        }

        // ============ pago + impresión ============
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (items.Count == 0)
            {
                toast.Mostrar("El ticket está vacío. Agrega al menos un producto.", ToastKind.Aviso);
                return;
            }

            ActualizarCobro();
            decimal rec = ticket.Recibido;
            decimal total = ticket.Total;
            if (rec > 0m && rec < total)
            {
                toast.Mostrar("Efectivo insuficiente: faltan " + (total - rec).ToString("C2", MX), ToastKind.Error);
                txtRecibido.Focus();
                return;
            }
            if (rec <= 0m)
            {
                // sin efectivo capturado: se toma como pago exacto
                txtRecibido.Text = total.ToString("0.00", Inv);
                ActualizarCobro();
            }

            snapshot = items.Select(i => new TicketItem
            {
                Cliente = i.Cliente, Producto = i.Producto, ColorHex = i.ColorHex,
                Color = i.Color, Precio = i.Precio, Cantidad = i.Cantidad, Alpha = 1f
            }).ToList();
            snapCliente = ticket.Cliente;
            snapFolio = ticket.Folio;
            snapSub = ticket.Subtotal;
            snapDescPct = ticket.Descuento;
            snapDesc = ticket.DescMonto;
            snapIva = ticket.Iva;
            snapTot = ticket.Total;
            snapRec = ticket.Recibido;
            snapCam = ticket.Cambio;

            btnPagar.Enabled = false;
            ticket.StartPay();
        }

        void TerminarPago()
        {
            SalesLog.Ventas.Add(new SaleRecord
            {
                Folio = snapFolio,
                Fecha = DateTime.Now,
                Cliente = string.IsNullOrWhiteSpace(snapCliente) ? "Mostrador" : snapCliente,
                Cajero = cajero,
                Articulos = snapshot.Sum(i => i.Cantidad),
                Subtotal = snapSub,
                DescPct = snapDescPct,
                Descuento = snapDesc,
                Iva = snapIva,
                Total = snapTot,
                Recibido = snapRec,
                Cambio = snapCam,
                Detalle = string.Join(" | ", snapshot.Select(i => i.Cantidad + "x " + i.Producto))
            });

            // Vista previa de impresión con el ticket que acaba de salir
            var doc = new PrintDocument();
            doc.PrintPage += ImprimirTicket;
            using (var vp = new PrintPreviewDialog())
            {
                vp.Document = doc;
                vp.Width = 600;
                vp.Height = 800;
                vp.ShowDialog(this);
            }

            items.Clear();
            ticket.Cliente = "";
            ticket.Folio++;
            txtCliente.Clear(); txtTel.Clear(); txtBuscar.Clear();
            ReiniciarCobro();
            RefreshAll();
            btnPagar.Enabled = true;
            ActualizarEstado();
            toast.Mostrar("Venta registrada  ·  Folio " + snapFolio.ToString("0000") + "  ·  " + snapTot.ToString("C2", MX), ToastKind.Exito);
        }

        // ============ corte de caja ============
        private void btnCorte_Click(object sender, EventArgs e)
        {
            using (var f = new FormCorte(SalesLog.Ventas))
                f.ShowDialog(this);
        }

        // ============ barra de estado ============
        static readonly Font FKey = new Font("Segoe UI", 7.5f, FontStyle.Bold);
        static readonly Font FEstado = new Font("Segoe UI", 8.5f);
        static readonly string[,] Atajos =
        {
            { "F2", "Buscar" }, { "F3", "Color" }, { "F4", "Cobrar" }, { "F5", "Limpiar" },
            { "Supr", "Quitar" }, { "Ctrl+D", "Descuento" }, { "F9", "Corte" }
        };

        void ActualizarEstado()
        {
            status.Invalidate();
        }

        private void status_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            using (var line = new Pen(Theme.Borde))
                g.DrawLine(line, 0, 0, status.Width, 0);

            using (var sec = new SolidBrush(Theme.Texto2))
            using (var txt = new SolidBrush(Theme.Texto))
            using (var kb = new SolidBrush(Theme.Elevado))
            using (var kp = new Pen(Theme.Borde))
            using (var center = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                float x = 16f;
                for (int i = 0; i < Atajos.GetLength(0); i++)
                {
                    string k = Atajos[i, 0], t = Atajos[i, 1];
                    float kw = g.MeasureString(k, FKey).Width + 8f;
                    var kr = new RectangleF(x, 5, kw, 18);
                    using (var p = Theme.Rounded(kr, 8))
                    {
                        g.FillPath(kb, p);
                        g.DrawPath(kp, p);
                    }
                    g.DrawString(k, FKey, txt, kr, center);
                    x += kw + 5f;
                    g.DrawString(t, FEstado, sec, x, 6);
                    x += g.MeasureString(t, FEstado).Width + 14f;
                }

                decimal hoy = SalesLog.Ventas.Sum(v => v.Total);
                string der = "Cajero " + cajero + "   ·   Caja 01   ·   Tickets " + SalesLog.Ventas.Count +
                             "   ·   Ventas " + hoy.ToString("C2", MX);
                using (var right = new StringFormat { Alignment = StringAlignment.Far })
                    g.DrawString(der, FEstado, sec, new RectangleF(0, 6, status.Width - 16, 18), right);
            }
        }

        // ============ atajos de teclado ============
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F2) { txtBuscar.Focus(); txtBuscar.SelectAll(); return true; }
            if (keyData == Keys.F3) { txtColor.Focus(); txtColor.SelectAll(); return true; }
            if (keyData == Keys.F4) { btnPagar.PerformClick(); return true; }
            if (keyData == Keys.F5) { btnLimpiar.PerformClick(); return true; }
            if (keyData == Keys.F9) { btnCorte.PerformClick(); return true; }
            if (keyData == Keys.Delete && !(ActiveControl is TextBoxBase))
            {
                btnEliminar.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.D))
            {
                int next = (chipDesc.SelectedIndex + 1) % Descuentos.Length;
                chipDesc.SelectedIndex = next;
                chipDesc_ChipClicked(chipDesc, next);
                toast.Mostrar("Descuento: " + Descuentos[next].ToString("0.##") + " %", ToastKind.Info);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        void ImprimirTicket(object sender, PrintPageEventArgs e)
        {
            using (var fTitulo = new Font("Arial", 12, FontStyle.Bold))
            using (var fTexto = new Font("Arial", 9))
            {
                float y = 20f, mx = 20f;
                var g = e.Graphics;
                g.DrawString("PYMASA - Pinturas para profesionales", fTitulo, Brushes.Black, new PointF(mx, y)); y += 22f;
                g.DrawString("Culiacán, Sinaloa, México  +52 667 217 7576", fTexto, Brushes.Black, new PointF(mx, y)); y += 18f;
                g.DrawString("Folio: " + snapFolio.ToString("0000") + "   Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fTexto, Brushes.Black, new PointF(mx, y)); y += 18f;
                g.DrawString("Cliente: " + (string.IsNullOrWhiteSpace(snapCliente) ? "Mostrador" : snapCliente), fTexto, Brushes.Black, new PointF(mx, y)); y += 18f;
                g.DrawString("-------------------------------------------------------------", fTexto, Brushes.Black, new PointF(mx, y)); y += 18f;
                g.DrawString("Producto                                   Color      Cant   Importe", fTexto, Brushes.Black, new PointF(mx, y)); y += 16f;

                foreach (var it in snapshot)
                {
                    string nombre = it.Producto.Length > 30 ? it.Producto.Substring(0, 30) : it.Producto;
                    g.DrawString(nombre, fTexto, Brushes.Black, new PointF(mx, y));
                    g.DrawString(it.ColorHex, fTexto, Brushes.Black, new PointF(mx + 230, y));
                    g.DrawString(it.Cantidad.ToString(), fTexto, Brushes.Black, new PointF(mx + 300, y));
                    g.DrawString(it.Subtotal.ToString("C2", MX), fTexto, Brushes.Black, new PointF(mx + 340, y));
                    y += 14f;
                }
                y += 8f;
                g.DrawString("-------------------------------------------------------------", fTexto, Brushes.Black, new PointF(mx, y)); y += 18f;
                g.DrawString("Subtotal: " + snapSub.ToString("C2", MX), fTexto, Brushes.Black, new PointF(mx, y)); y += 16f;
                if (snapDescPct > 0m)
                {
                    g.DrawString("Descuento (" + snapDescPct.ToString("0.##") + "%): -" + snapDesc.ToString("C2", MX), fTexto, Brushes.Black, new PointF(mx, y)); y += 16f;
                }
                g.DrawString("IVA (16%): " + snapIva.ToString("C2", MX), fTexto, Brushes.Black, new PointF(mx, y)); y += 16f;
                g.DrawString("TOTAL: " + snapTot.ToString("C2", MX), fTitulo, Brushes.Black, new PointF(mx, y)); y += 22f;
                g.DrawString("Recibido: " + snapRec.ToString("C2", MX), fTexto, Brushes.Black, new PointF(mx, y)); y += 16f;
                g.DrawString("Cambio: " + snapCam.ToString("C2", MX), fTexto, Brushes.Black, new PointF(mx, y)); y += 22f;
                g.DrawString("¡Gracias por su compra!", fTexto, Brushes.Black, new PointF(mx, y));
            }
        }
    }
}
