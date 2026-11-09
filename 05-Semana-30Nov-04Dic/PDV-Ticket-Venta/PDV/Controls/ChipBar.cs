using System.ComponentModel;
using Timer = System.Windows.Forms.Timer;

namespace PDV
{
    /// <summary>
    /// Fila/rejilla de chips. Selectable = true: queda marcado el elegido (descuentos).
    /// Selectable = false: cada clic es momentáneo (efectivo rápido).
    /// </summary>
    public class ChipBar : Control
    {
        public event EventHandler<int> ChipClicked;

        static readonly Font FChip = new Font("Segoe UI", 9f, FontStyle.Bold);
        const int Gap = 6;

        string[] options = new string[0];
        float[] hov = new float[0];
        int columns = 3;
        int selected = -1;
        int hoverIdx = -1;
        readonly Timer timer = new Timer { Interval = 16 };

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string[] Options
        {
            get { return options; }
            set { options = value ?? new string[0]; hov = new float[options.Length]; Invalidate(); }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Columns
        {
            get { return columns; }
            set { columns = Math.Max(1, value); Invalidate(); }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Selectable { get; set; } = true;

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return selected; }
            set { selected = value; Invalidate(); }
        }

        public ChipBar()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            timer.Tick += (s, e) =>
            {
                bool dirty = false;
                for (int i = 0; i < hov.Length; i++)
                {
                    float t = i == hoverIdx ? 1f : 0f;
                    float d = t - hov[i];
                    if (Math.Abs(d) > 0.01f) { hov[i] += d * 0.3f; dirty = true; }
                    else if (hov[i] != t) { hov[i] = t; dirty = true; }
                }
                if (dirty) Invalidate();
            };
            timer.Start();
        }

        RectangleF ChipRect(int i)
        {
            int rows = (options.Length + columns - 1) / columns;
            float w = (Width - (columns - 1) * Gap) / (float)columns;
            float h = (Height - (rows - 1) * Gap) / (float)Math.Max(1, rows);
            int r = i / columns, c = i % columns;
            return new RectangleF(c * (w + Gap), r * (h + Gap), w, h);
        }

        int HitTest(Point p)
        {
            for (int i = 0; i < options.Length; i++)
                if (ChipRect(i).Contains(p)) return i;
            return -1;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int i = HitTest(e.Location);
            if (i != hoverIdx)
            {
                hoverIdx = i;
                Cursor = i >= 0 ? Cursors.Hand : Cursors.Default;
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            hoverIdx = -1;
            Cursor = Cursors.Default;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            int i = HitTest(e.Location);
            if (i < 0) return;
            if (Selectable) selected = i;
            Invalidate();
            var h = ChipClicked;
            if (h != null) h(this, i);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Parent != null ? Parent.BackColor : Theme.Fondo);
            for (int i = 0; i < options.Length; i++)
            {
                var r = ChipRect(i);
                bool sel = Selectable && i == selected;
                float k = hov[i];
                Color fill = sel ? Theme.Acento : Theme.Lerp(Theme.Elevado, Theme.Borde, k);
                Color fore = sel ? Theme.TextOn(Theme.Acento) : Theme.Lerp(Theme.Texto, Theme.Acento, k);
                using (var p = Theme.Rounded(new RectangleF(r.X + 0.5f, r.Y + 0.5f, r.Width - 1f, r.Height - 1f), 16))
                using (var b = new SolidBrush(fill))
                using (var pen = new Pen(sel ? Theme.Acento : Theme.Lerp(Theme.Borde, Theme.Acento, k)))
                {
                    g.FillPath(b, p);
                    g.DrawPath(pen, p);
                }
                TextRenderer.DrawText(g, options[i], FChip, Rectangle.Round(r), fore,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) timer.Dispose();
            base.Dispose(disposing);
        }
    }
}
