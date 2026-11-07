using System.Drawing.Drawing2D;
using System.Globalization;
using Timer = System.Windows.Forms.Timer;

namespace PDV
{
    /// <summary>
    /// Corte de caja (sin Diseñador): KPIs que "cuentan", gráfica de barras que crece
    /// con los colores de la paleta y desglose de importes. Exporta a CSV.
    /// </summary>
    public class FormCorte : Form
    {
        static readonly CultureInfo MX = CultureInfo.GetCultureInfo("es-MX");
        static readonly Font FTitulo = new Font("Segoe UI", 15f, FontStyle.Bold);
        static readonly Font FFecha = new Font("Segoe UI", 9.5f);
        static readonly Font FCap = new Font("Segoe UI", 7.5f, FontStyle.Bold);
        static readonly Font FKpi = new Font("Segoe UI", 21f, FontStyle.Bold);
        static readonly Font FTexto = new Font("Segoe UI", 9.5f);
        static readonly Font FNeg = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        static readonly Font FPeque = new Font("Segoe UI", 8f);

        readonly List<SaleRecord> ventas;
        readonly BufPanel canvas;
        readonly Timer timer = new Timer { Interval = 16 };
        float prog;

        public FormCorte(List<SaleRecord> v)
        {
            ventas = v;
            Text = "Corte de caja";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(760, 560);
            BackColor = Theme.Fondo;
            DoubleBuffered = true;

            canvas = new BufPanel { Dock = DockStyle.Fill, BackColor = Theme.Fondo };
            canvas.Paint += Canvas_Paint;
            Controls.Add(canvas);

            var btnCsv = new AnimButton
            {
                Text = "Exportar CSV", Variant = ButtonVariant.Info,
                Location = new Point(24, 500), Size = new Size(200, 44)
            };
            btnCsv.Click += Exportar;
            var btnCerrar = new AnimButton
            {
                Text = "Cerrar", Variant = ButtonVariant.Ghost,
                Location = new Point(536, 500), Size = new Size(200, 44)
            };
            btnCerrar.Click += (s, e) => Close();
            canvas.Controls.Add(btnCsv);
            canvas.Controls.Add(btnCerrar);
            CancelButton = btnCerrar;

            timer.Tick += (s, e) =>
            {
                prog = Math.Min(1f, prog + 0.022f);
                canvas.Invalidate();
                if (prog >= 1f) timer.Stop();
            };
            timer.Start();
        }

        void Exportar(object sender, EventArgs e)
        {
            if (ventas.Count == 0)
            {
                MessageBox.Show("Aún no hay ventas para exportar.", "Corte de caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string path = SalesLog.Exportar();
                MessageBox.Show("Corte guardado en:\n" + path, "Corte de caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try { System.Diagnostics.Process.Start("explorer.exe", "/select,\"" + path + "\""); } catch { }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el archivo:\n" + ex.Message, "Corte de caja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static void Tarjeta(Graphics g, RectangleF r)
        {
            using (var p = Theme.Rounded(r, 28))
            using (var b = new SolidBrush(Theme.Superficie))
            using (var pen = new Pen(Theme.Borde))
            {
                g.FillPath(b, p);
                g.DrawPath(pen, p);
            }
        }

        void Kpi(Graphics g, float x, float y, float w, string cap, string valor, Color color)
        {
            Tarjeta(g, new RectangleF(x + 0.5f, y + 0.5f, w, 86));
            using (var sec = new SolidBrush(Theme.Texto2))
            using (var vb = new SolidBrush(color))
            {
                g.DrawString(cap, FCap, sec, x + 18, y + 14);
                g.DrawString(valor, FKpi, vb, x + 16, y + 34);
            }
        }

        void Linea(Graphics g, float x, float y, float w, string etiqueta, string valor, Color color, bool negrita = false)
        {
            var f = negrita ? FNeg : FTexto;
            using (var sec = new SolidBrush(Theme.Texto2))
            using (var vb = new SolidBrush(color))
            using (var right = new StringFormat { Alignment = StringAlignment.Far })
            {
                g.DrawString(etiqueta, f, sec, x, y);
                g.DrawString(valor, f, vb, new RectangleF(x, y, w, 20), right);
            }
        }

        void Canvas_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            float ease = 1f - (float)Math.Pow(1f - prog, 3);
            decimal k = (decimal)ease;

            int n = ventas.Count;
            decimal total = ventas.Sum(x => x.Total);
            decimal prom = n > 0 ? total / n : 0m;

            using (var ab = new SolidBrush(Theme.Acento))
            using (var sec = new SolidBrush(Theme.Texto2))
            using (var right = new StringFormat { Alignment = StringAlignment.Far })
            {
                g.DrawString("CORTE DE CAJA", FTitulo, ab, 24, 16);
                g.DrawString(DateTime.Now.ToString("dddd dd 'de' MMMM yyyy", MX).ToUpper(), FFecha, sec,
                    new RectangleF(24, 22, 712, 20), right);
            }

            // KPIs
            float kw = (712 - 24) / 3f;
            Kpi(g, 24, 54, kw, "VENTAS DEL DÍA", (total * k).ToString("C2", MX), Theme.Acento);
            Kpi(g, 24 + kw + 12, 54, kw, "TICKETS", ((int)Math.Round(n * ease)).ToString(), Theme.Texto);
            Kpi(g, 24 + 2 * (kw + 12), 54, kw, "TICKET PROMEDIO", (prom * k).ToString("C2", MX), Theme.Exito);

            // gráfica
            var chart = new RectangleF(24.5f, 154.5f, 711, 214);
            Tarjeta(g, chart);
            using (var sec = new SolidBrush(Theme.Texto2))
                g.DrawString("VENTA POR TICKET (últimos 12)", FCap, sec, 42, 168);

            if (n == 0)
            {
                using (var sec = new SolidBrush(Theme.Texto2))
                using (var center = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                    g.DrawString("Aún no hay ventas.\nCobra un ticket para ver el corte.", FTexto, sec,
                        new RectangleF(24, 180, 712, 180), center);
            }
            else
            {
                var ult = ventas.Skip(Math.Max(0, n - 12)).ToList();
                decimal max = ult.Max(x => x.Total);
                if (max <= 0m) max = 1m;
                float areaX = 44, areaW = 672, baseY = 336, areaH = 128;
                float slot = areaW / ult.Count;
                float bw = Math.Min(44f, slot * 0.6f);
                using (var line = new Pen(Theme.Borde))
                    g.DrawLine(line, areaX, baseY, areaX + areaW, baseY);
                using (var sec = new SolidBrush(Theme.Texto2))
                using (var txt = new SolidBrush(Theme.Texto))
                using (var center = new StringFormat { Alignment = StringAlignment.Center })
                {
                    for (int i = 0; i < ult.Count; i++)
                    {
                        float h = (float)(ult[i].Total / max) * areaH * ease;
                        float bx = areaX + i * slot + (slot - bw) / 2f;
                        var br = new RectangleF(bx, baseY - h, bw, Math.Max(2f, h));
                        using (var p = Theme.Rounded(br, 12))
                        using (var fb = new SolidBrush(Theme.Paleta[i % Theme.Paleta.Length]))
                            g.FillPath(fb, p);
                        g.DrawString("#" + ult[i].Folio.ToString("0000"), FPeque, sec,
                            new RectangleF(bx - 10, baseY + 5, bw + 20, 16), center);
                        if (ease > 0.8f)
                            g.DrawString(ult[i].Total.ToString("C0", MX), FPeque, txt,
                                new RectangleF(bx - 16, baseY - h - 17, bw + 32, 16), center);
                    }
                }
            }

            // desglose
            Tarjeta(g, new RectangleF(24.5f, 380.5f, 711, 100));
            decimal sub = ventas.Sum(x => x.Subtotal) * k;
            decimal desc = ventas.Sum(x => x.Descuento) * k;
            decimal iva = ventas.Sum(x => x.Iva) * k;
            decimal rec = ventas.Sum(x => x.Recibido) * k;
            decimal cam = ventas.Sum(x => x.Cambio) * k;
            decimal tot = total * k;
            Linea(g, 44, 396, 310, "Subtotal", sub.ToString("C2", MX), Theme.Texto);
            Linea(g, 44, 420, 310, "Descuentos", "-" + desc.ToString("C2", MX), Theme.Exito);
            Linea(g, 44, 444, 310, "IVA (16%)", iva.ToString("C2", MX), Theme.Texto);
            Linea(g, 396, 396, 320, "Efectivo recibido", rec.ToString("C2", MX), Theme.Texto);
            Linea(g, 396, 420, 320, "Cambio entregado", cam.ToString("C2", MX), Theme.Texto);
            Linea(g, 396, 444, 320, "TOTAL VENDIDO", tot.ToString("C2", MX), Theme.Acento, true);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) timer.Dispose();
            base.Dispose(disposing);
        }
    }
}
