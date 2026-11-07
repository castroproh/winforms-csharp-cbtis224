using System.ComponentModel;
using System.Drawing.Drawing2D;
using Timer = System.Windows.Forms.Timer;

namespace PDV
{
    /// <summary>
    /// Estudio de color para la tienda de pinturas:
    ///  - muestra el color actual con su significado psicológico,
    ///  - paleta rápida de 12 colores de pintura,
    ///  - armonías calculadas en la rueda de color (complementario, análogos, tríada).
    /// El cuadro de texto HEX es un TextBox del formulario colocado encima de este control.
    /// </summary>
    public class ColorStudio : Control
    {
        public event EventHandler<Color> ColorPicked;

        const int Chips = 17; // 12 de la paleta + 5 armonías
        static readonly string[] HarmNames =
            { "Complementario", "Análogo -30°", "Análogo +30°", "Tríada +120°", "Tríada +240°" };

        static readonly Font FTitulo = new Font("Segoe UI", 9f, FontStyle.Bold);
        static readonly Font FEtiqueta = new Font("Segoe UI", 7.5f, FontStyle.Bold);
        static readonly Font FNombre = new Font("Segoe UI", 13f, FontStyle.Bold);
        static readonly Font FTexto = new Font("Segoe UI", 9f);
        static readonly Font FPeque = new Font("Segoe UI", 8f);

        Color current = Theme.Paleta[1];
        Color shown = Theme.Paleta[1];
        readonly Color[] harm = new Color[5];
        readonly float[] hov = new float[Chips];
        int hoverIdx = -1;
        bool hexFocused;
        string familia = "", desc = "";
        readonly Timer timer = new Timer { Interval = 16 };

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color Current
        {
            get { return current; }
            set { current = value; Recompute(); Invalidate(); }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool HexFocused
        {
            get { return hexFocused; }
            set { hexFocused = value; Invalidate(); }
        }

        public ColorStudio()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            Recompute();
            timer.Tick += Step;
            timer.Start();
        }

        void Recompute()
        {
            float h, s, l;
            Theme.ToHsl(current, out h, out s, out l);
            harm[0] = Theme.FromHsl(h + 180f, s, l);
            harm[1] = Theme.FromHsl(h - 30f, s, l);
            harm[2] = Theme.FromHsl(h + 30f, s, l);
            harm[3] = Theme.FromHsl(h + 120f, s, l);
            harm[4] = Theme.FromHsl(h + 240f, s, l);
            familia = Theme.Describir(current, out desc);
        }

        Rectangle ChipRect(int i)
        {
            return i < 12 ? new Rectangle(16 + i * 36, 118, 26, 26)
                          : new Rectangle(470 + (i - 12) * 42, 118, 26, 26);
        }

        Color ChipColor(int i) { return i < 12 ? Theme.Paleta[i] : harm[i - 12]; }
        string ChipName(int i) { return i < 12 ? Theme.PaletaNombres[i] : HarmNames[i - 12]; }

        int HitTest(Point p)
        {
            for (int i = 0; i < Chips; i++)
                if (ChipRect(i).Contains(p)) return i;
            return -1;
        }

        void Step(object s, EventArgs e)
        {
            bool dirty = false;
            Color ns = Theme.Lerp(shown, current, 0.22f);
            if (Math.Abs(ns.R - current.R) + Math.Abs(ns.G - current.G) + Math.Abs(ns.B - current.B) < 4) ns = current;
            if (ns.ToArgb() != shown.ToArgb()) { shown = ns; dirty = true; }

            for (int i = 0; i < Chips; i++)
            {
                float target = i == hoverIdx ? 1f : 0f;
                float d = target - hov[i];
                if (Math.Abs(d) > 0.01f) { hov[i] += d * 0.3f; dirty = true; }
                else if (hov[i] != target) { hov[i] = target; dirty = true; }
            }
            if (dirty) Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int i = HitTest(e.Location);
            if (i != hoverIdx)
            {
                hoverIdx = i;
                Cursor = i >= 0 ? Cursors.Hand : Cursors.Default;
                Invalidate();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            hoverIdx = -1;
            Cursor = Cursors.Default;
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            int i = HitTest(e.Location);
            if (i >= 0)
            {
                var h = ColorPicked;
                if (h != null) h(this, ChipColor(i));
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            g.Clear(Parent != null ? Parent.BackColor : Theme.Fondo);
            if (Width < 100 || Height < 100) return;

            using (var card = Theme.Rounded(new RectangleF(0.5f, 0.5f, Width - 1f, Height - 1f), 28))
            using (var cb = new SolidBrush(Theme.Superficie))
            using (var cp = new Pen(Theme.Borde))
            {
                g.FillPath(cb, card);
                g.DrawPath(cp, card);
            }

            using (var acento = new SolidBrush(Theme.Acento))
            using (var sec = new SolidBrush(Theme.Texto2))
            using (var txt = new SolidBrush(Theme.Texto))
            using (var line = new Pen(Theme.Borde))
            {
                g.DrawString("ESTUDIO DE COLOR", FTitulo, acento, 16, 10);
                g.DrawString("CÓDIGO HEX", FEtiqueta, sec, 18, 32);

                // fondo del campo HEX (el TextBox va encima)
                using (var fp = Theme.Rounded(new RectangleF(16.5f, 48.5f, 128, 32), 16))
                using (var fb = new SolidBrush(Theme.Input))
                using (var fpen = new Pen(hexFocused ? Theme.Acento : Theme.Borde, hexFocused ? 1.5f : 1f))
                {
                    g.FillPath(fb, fp);
                    g.DrawPath(fpen, fp);
                }

                // muestra grande del color
                using (var sp = Theme.Rounded(new RectangleF(158.5f, 34.5f, 64, 46), 16))
                using (var sb = new SolidBrush(shown))
                using (var spen = new Pen(Theme.Borde))
                {
                    g.FillPath(sb, sp);
                    g.DrawPath(spen, sp);
                }

                g.DrawString(familia, FNombre, txt, 232, 32);
                g.DrawString(desc, FTexto, sec, new RectangleF(232, 58, Width - 232 - 16, 34));

                g.DrawLine(line, 16, 92, Width - 16, 92);
                g.DrawString("PALETA RÁPIDA", FEtiqueta, sec, 16, 98);
                g.DrawString("ARMONÍAS DEL COLOR", FEtiqueta, sec, 470, 98);

                for (int i = 0; i < Chips; i++)
                {
                    var r = ChipRect(i);
                    float k = hov[i];
                    var rf = new RectangleF(r.X - 3f * k, r.Y - 3f * k, r.Width + 6f * k, r.Height + 6f * k);
                    bool isCurrent = ChipColor(i).ToArgb() == current.ToArgb();
                    using (var p = Theme.Rounded(rf, 16))
                    using (var b = new SolidBrush(ChipColor(i)))
                    using (var pen = new Pen(isCurrent ? Theme.Acento : Theme.Borde, isCurrent ? 2f : 1f))
                    {
                        g.FillPath(b, p);
                        g.DrawPath(pen, p);
                    }
                }

                string cap = hoverIdx >= 0
                    ? ChipName(hoverIdx) + "  " + Theme.ToHex(ChipColor(hoverIdx))
                    : "Pasa el cursor y haz clic en un color";
                g.DrawString(cap, FPeque, sec, 16, 152);
                g.DrawString("Compl.", FPeque, sec, 470, 152);
                g.DrawString("Análogos", FPeque, sec, 512, 152);
                g.DrawString("Tríada", FPeque, sec, 596, 152);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) timer.Dispose();
            base.Dispose(disposing);
        }
    }
}
