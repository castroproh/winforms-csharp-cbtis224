using System.Drawing.Drawing2D;
using System.Globalization;
using Timer = System.Windows.Forms.Timer;

namespace PDV
{
    /// <summary>
    /// Ticket de papel dibujado a mano: se desenrolla desde la impresora, los productos
    /// entran con fade, los totales "cuentan", al pagar aparece el sello PAGADO y el ticket sale.
    /// Papel crema (menos deslumbrante que blanco puro) + tinta azul oscuro + total destacado.
    /// </summary>
    public class TicketPaper : Control
    {
        public List<TicketItem> Items = new List<TicketItem>();
        public string Cliente = "";
        public int Folio = 1;
        public decimal Descuento;   // porcentaje 0-100 (se aplica antes del IVA)
        public decimal Recibido;    // efectivo recibido (0 = no se muestra)
        public event EventHandler PayFinished;

        const int W = 300;
        const float LH = 22f;
        const float HeaderH = 160f;
        const float FooterH = 156f;
        static readonly CultureInfo MX = CultureInfo.GetCultureInfo("es-MX");

        static readonly Font FTitulo = new Font("Segoe UI", 20f, FontStyle.Bold | FontStyle.Italic);
        static readonly Font FTexto = new Font("Consolas", 9f);
        static readonly Font FNegrita = new Font("Consolas", 9.5f, FontStyle.Bold);
        static readonly Font FPeque = new Font("Consolas", 8f);
        static readonly Font FTotal = new Font("Consolas", 14f, FontStyle.Bold);
        static readonly Font FSello = new Font("Segoe UI", 24f, FontStyle.Bold);
        static readonly Font FImpresora = new Font("Segoe UI", 7f, FontStyle.Bold);

        float paperH, targetH;
        float dSub, dIva, dTot, dDesc, dRec, dCam;
        decimal tSub, tIva, tTot, tDesc, tCam;
        bool paying;
        float payOff, stampT;
        int hold;
        readonly Timer timer = new Timer { Interval = 16 };

        public bool Paying { get { return paying; } }
        public decimal Subtotal { get { return tSub; } }
        public decimal DescMonto { get { return tDesc; } }
        public decimal Iva { get { return tIva; } }
        public decimal Total { get { return tTot; } }
        public decimal Cambio { get { return tCam; } }

        public TicketPaper()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            timer.Tick += Step;
            timer.Start();
            Recalc();
        }

        float Extra { get { return (Descuento > 0m ? 18f : 0f) + (Recibido > 0m ? 40f : 0f); } }

        int MaxItems
        {
            get { return Math.Max(1, (int)((Height - 34 - HeaderH - FooterH - 58f - 20) / LH)); }
        }

        public void Recalc()
        {
            tSub = Items.Sum(i => i.Subtotal);
            tDesc = Math.Round(tSub * Descuento / 100m, 2);
            tIva = Math.Round((tSub - tDesc) * 0.16m, 2);
            tTot = tSub - tDesc + tIva;
            tCam = Recibido > tTot ? Recibido - tTot : 0m;
            int n = Math.Max(1, Math.Min(Items.Count, MaxItems));
            targetH = HeaderH + n * LH + FooterH + Extra;
            Invalidate();
        }

        public void StartPay()
        {
            if (Items.Count == 0 || paying) return;
            paying = true;
            payOff = 0;
            stampT = 0;
            hold = 0;
        }

        static float Ease(float v, float target)
        {
            float d = target - v;
            return Math.Abs(d) < 0.01f ? target : v + d * 0.15f;
        }

        void Step(object s, EventArgs e)
        {
            bool dirty = false;

            float d = targetH - paperH;
            if (Math.Abs(d) > 0.5f) { paperH += d * 0.18f; dirty = true; }
            else if (paperH != targetH) { paperH = targetH; dirty = true; }

            foreach (var it in Items)
                if (it.Alpha < 1f) { it.Alpha = Math.Min(1f, it.Alpha + 0.07f); dirty = true; }

            float ns = Ease(dSub, (float)tSub), ni = Ease(dIva, (float)tIva), nt = Ease(dTot, (float)tTot);
            float nd = Ease(dDesc, (float)tDesc), nr = Ease(dRec, (float)Recibido), nc = Ease(dCam, (float)tCam);
            if (ns != dSub || ni != dIva || nt != dTot || nd != dDesc || nr != dRec || nc != dCam) dirty = true;
            dSub = ns; dIva = ni; dTot = nt; dDesc = nd; dRec = nr; dCam = nc;

            if (paying)
            {
                dirty = true;
                if (stampT < 1f) stampT = Math.Min(1f, stampT + 0.05f);   // sello PAGADO
                else if (hold < 32) hold++;                                 // pausa para verlo
                else
                {
                    payOff += 8f + payOff * 0.06f;                          // sale por la impresora
                    if (payOff > paperH + 60f)
                    {
                        paying = false;
                        payOff = 0;
                        stampT = 0;
                        hold = 0;
                        paperH = 0;
                        dSub = dIva = dTot = dDesc = dRec = dCam = 0;
                        var h = PayFinished;
                        if (h != null) h(this, EventArgs.Empty);
                    }
                }
            }
            if (dirty) Invalidate();
        }

        static string Money(float v) { return ((decimal)v).ToString("C2", MX); }

        static GraphicsPath PaperPath(float x, float y, float w, float h)
        {
            var pts = new List<PointF>();
            pts.Add(new PointF(x, y));
            pts.Add(new PointF(x + w, y));
            float bottom = y + h;
            float tooth = 10f;
            int n = (int)(w / tooth);
            pts.Add(new PointF(x + w, bottom - 6));
            for (int i = n; i >= 0; i--)
                pts.Add(new PointF(Math.Min(x + i * tooth, x + w), bottom - (i % 2 == 0 ? 6 : 0)));
            var p = new GraphicsPath();
            p.AddPolygon(pts.ToArray());
            return p;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            g.Clear(Theme.Fondo);
            if (Width < 60 || Height < 60) return;

            // resplandor suave detrás del papel (profundidad)
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(-Width * 0.25f, -Height * 0.1f, Width * 1.5f, Height * 1.2f);
                using (var pg = new PathGradientBrush(gp))
                {
                    pg.CenterColor = Theme.Superficie;
                    pg.SurroundColors = new[] { Theme.Fondo };
                    g.FillPath(pg, gp);
                }
            }

            float x = (Width - W) / 2f;
            float y0 = 34f - payOff;

            if (paperH > 4f)
            {
                using (var path = PaperPath(x, y0, W, paperH))
                {
                    var state = g.Save();

                    using (var sh = (GraphicsPath)path.Clone())
                    using (var m = new Matrix(1, 0, 0, 1, 6, 8))
                    using (var sb = new SolidBrush(Color.FromArgb(110, 0, 0, 0)))
                    {
                        sh.Transform(m);
                        g.SetClip(new RectangleF(0, 34, Width, Height), CombineMode.Replace);
                        g.FillPath(sb, sh);
                    }

                    g.SetClip(path, CombineMode.Replace);
                    g.IntersectClip(new RectangleF(0, 34, Width, Height));
                    using (var pb = new SolidBrush(Theme.Papel))
                        g.FillPath(pb, path);
                    DrawContent(g, x, y0);

                    g.Restore(state);
                }
            }
            DrawPrinter(g, x);
        }

        void DrawContent(Graphics g, float x, float y0)
        {
            using (var ink = new SolidBrush(Theme.Tinta))
            using (var soft = new SolidBrush(Theme.TintaSuave))
            using (var brand = new SolidBrush(Theme.Fondo))
            using (var center = new StringFormat { Alignment = StringAlignment.Center })
            using (var right = new StringFormat { Alignment = StringAlignment.Far })
            using (var ell = new StringFormat { Trimming = StringTrimming.EllipsisCharacter, FormatFlags = StringFormatFlags.NoWrap })
            using (var dash = new Pen(Color.FromArgb(150, 148, 160)) { DashStyle = DashStyle.Dash })
            {
                // banda de muestras de pintura (identidad de la tienda)
                float sw = W / (float)Theme.Paleta.Length;
                for (int i = 0; i < Theme.Paleta.Length; i++)
                    using (var b = new SolidBrush(Theme.Paleta[i]))
                        g.FillRectangle(b, x + i * sw, y0, sw + 0.6f, 6);

                float y = y0 + 16;
                g.DrawString("Pymasa", FTitulo, brand, new RectangleF(x, y, W, 34), center); y += 34;
                g.DrawString("PINTURAS PARA PROFESIONALES", FPeque, soft, new RectangleF(x, y, W, 16), center); y += 16;
                g.DrawString("Culiacán, Sinaloa  +52 667 217 7576", FPeque, soft, new RectangleF(x, y, W, 16), center); y += 16;
                g.DrawString("Folio " + Folio.ToString("0000") + "  " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), FPeque, soft, new RectangleF(x, y, W, 16), center); y += 16;
                string cli = string.IsNullOrWhiteSpace(Cliente) ? "Mostrador" : Cliente;
                g.DrawString("Cliente: " + cli, FNegrita, ink, new RectangleF(x + 14, y, W - 28, 18), ell); y += 20;
                g.DrawLine(dash, x + 14, y + 4, x + W - 14, y + 4); y += 12;

                g.DrawString("PRODUCTO", FNegrita, ink, new RectangleF(x + 30, y, 140, 18), ell);
                g.DrawString("CANT", FNegrita, ink, new RectangleF(x + 176, y, 40, 18), center);
                g.DrawString("IMPORTE", FNegrita, ink, new RectangleF(x + 200, y, W - 214, 18), right);
                y = y0 + HeaderH - 6;

                if (Items.Count == 0)
                {
                    g.DrawString("- agregue productos -", FTexto, soft, new RectangleF(x, y + 2, W, LH), center);
                    y += LH;
                }
                else
                {
                    int n = Math.Min(Items.Count, MaxItems);
                    foreach (var it in Items.Skip(Items.Count - n))
                    {
                        float a = Math.Min(1f, it.Alpha);
                        float ox = (1f - a) * 24f;
                        int al = (int)(255 * a);
                        using (var ib = new SolidBrush(Color.FromArgb(al, Theme.Tinta)))
                        using (var cb = new SolidBrush(Color.FromArgb(al, it.Color)))
                        using (var bp = new Pen(Color.FromArgb(al, Theme.TintaSuave)))
                        {
                            g.FillEllipse(cb, x + 14 + ox, y + 5, 11, 11);
                            g.DrawEllipse(bp, x + 14 + ox, y + 5, 11, 11);
                            g.DrawString(it.Producto, FTexto, ib, new RectangleF(x + 30 + ox, y + 2, 140, LH), ell);
                            g.DrawString(it.Cantidad.ToString(), FTexto, ib, new RectangleF(x + 176 + ox, y + 2, 40, LH), center);
                            g.DrawString(it.Subtotal.ToString("C2", MX), FTexto, ib, new RectangleF(x + 200 + ox, y + 2, W - 214, LH), right);
                        }
                        y += LH;
                    }
                }

                g.DrawLine(dash, x + 14, y + 6, x + W - 14, y + 6); y += 16;
                g.DrawString("Subtotal:", FTexto, ink, new RectangleF(x + 14, y, 140, 18));
                g.DrawString(Money(dSub), FTexto, ink, new RectangleF(x + 14, y, W - 28, 18), right); y += 18;
                if (Descuento > 0m)
                {
                    using (var gb = new SolidBrush(Theme.ExitoOscuro))
                    {
                        g.DrawString("Descuento (" + Descuento.ToString("0.##") + "%):", FTexto, gb, new RectangleF(x + 14, y, 180, 18));
                        g.DrawString("-" + Money(dDesc), FTexto, gb, new RectangleF(x + 14, y, W - 28, 18), right);
                    }
                    y += 18;
                }
                g.DrawString("IVA (16%):", FTexto, ink, new RectangleF(x + 14, y, 140, 18));
                g.DrawString(Money(dIva), FTexto, ink, new RectangleF(x + 14, y, W - 28, 18), right); y += 22;

                // total destacado: jerarquía visual (azul tinta + amarillo de marca)
                var tb = new RectangleF(x + 14, y, W - 28, 34);
                using (var tp = Theme.Rounded(tb, 12))
                using (var tf = new SolidBrush(Theme.Fondo))
                using (var tl = new SolidBrush(Theme.Texto2))
                using (var ta = new SolidBrush(Theme.Acento))
                {
                    g.FillPath(tf, tp);
                    g.DrawString("TOTAL", FNegrita, tl, new RectangleF(x + 26, y + 9, 80, 20));
                    g.DrawString(Money(dTot), FTotal, ta, new RectangleF(x + 14, y + 6, W - 28 - 12, 26), right);
                }
                y += 42;

                if (Recibido > 0m)
                {
                    g.DrawString("Recibido:", FTexto, ink, new RectangleF(x + 14, y, 140, 18));
                    g.DrawString(Money(dRec), FTexto, ink, new RectangleF(x + 14, y, W - 28, 18), right); y += 16;
                    g.DrawString("Cambio:", FNegrita, ink, new RectangleF(x + 14, y, 140, 18));
                    g.DrawString(Money(dCam), FNegrita, ink, new RectangleF(x + 14, y, W - 28, 18), right); y += 24;
                }

                g.DrawString("¡Gracias por su compra!", FTexto, ink, new RectangleF(x, y, W, 18), center); y += 22;

                // código de barras decorativo
                var rnd = new Random(Items.Count * 7 + Folio);
                float bx = x + 40;
                while (bx < x + W - 40)
                {
                    int bw = rnd.Next(1, 4);
                    g.FillRectangle(ink, bx, y, bw, 28);
                    bx += bw + rnd.Next(1, 4);
                }

                // sello PAGADO
                if (stampT > 0f)
                {
                    float t = Math.Min(1f, stampT);
                    float ease = 1f - (float)Math.Pow(1f - t, 3);
                    float sc = 1f + (1f - ease) * 1.6f;
                    int al = (int)(235 * Math.Min(1f, t * 2.2f));
                    var st = g.Save();
                    g.TranslateTransform(x + W / 2f, y0 + paperH / 2f);
                    g.RotateTransform(-14f);
                    g.ScaleTransform(sc, sc);
                    using (var sp = Theme.Rounded(new RectangleF(-88, -28, 176, 56), 16))
                    using (var spen = new Pen(Color.FromArgb(al, Theme.ExitoOscuro), 4f))
                    using (var sb = new SolidBrush(Color.FromArgb(al, Theme.ExitoOscuro)))
                    using (var bgb = new SolidBrush(Color.FromArgb((int)(al * 0.35f), Theme.Papel)))
                    {
                        g.FillPath(bgb, sp);
                        g.DrawPath(spen, sp);
                        g.DrawString("PAGADO", FSello, sb, new RectangleF(-88, -23, 176, 48), center);
                    }
                    g.Restore(st);
                }
            }
        }

        void DrawPrinter(Graphics g, float x)
        {
            var r = new RectangleF(x - 8, 8, W + 16, 26);
            using (var path = Theme.Rounded(r, 20))
            using (var lg = new LinearGradientBrush(r, Theme.Elevado, Theme.FondoProfundo, 90f))
            using (var pen = new Pen(Theme.Borde))
            {
                g.FillPath(lg, path);
                g.DrawPath(pen, path);
            }
            g.FillRectangle(Brushes.Black, x - 4, 29, W + 8, 5);

            // LED: verde = listo, amarillo parpadeante = imprimiendo
            Color led = paying
                ? ((Environment.TickCount / 150) % 2 == 0 ? Theme.Acento : Theme.Elevado)
                : Theme.Exito;
            using (var lb = new SolidBrush(led))
                g.FillEllipse(lb, x + 6, 15, 9, 9);
            using (var sf = new StringFormat { Alignment = StringAlignment.Center })
            using (var tb = new SolidBrush(Theme.Texto2))
                g.DrawString("PYMASA  ·  CAJA 01", FImpresora, tb, new RectangleF(x, 14, W, 14), sf);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) timer.Dispose();
            base.Dispose(disposing);
        }
    }
}
