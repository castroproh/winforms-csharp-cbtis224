using System.Drawing.Drawing2D;
using Timer = System.Windows.Forms.Timer;

namespace PDV
{
    public enum ToastKind { Exito, Aviso, Error, Info }

    /// <summary>
    /// Notificación que sube desde abajo, se queda unos segundos y baja sola.
    /// Reemplaza los MessageBox: no interrumpe al cajero. Clic para cerrarla.
    /// </summary>
    public class ToastNotice : Control
    {
        struct Msg { public string Text; public ToastKind Kind; }

        const int W = 380, H = 60, Margen = 18;
        static readonly Font FTexto = new Font("Segoe UI", 10f, FontStyle.Bold);
        static readonly Font FIcono = new Font("Segoe UI Symbol", 13f, FontStyle.Bold);

        readonly Queue<Msg> cola = new Queue<Msg>();
        readonly Timer timer = new Timer { Interval = 16 };
        string text = "";
        ToastKind kind;
        int state;          // 0 oculto, 1 entra, 2 espera, 3 sale
        float t;
        int hold;

        /// <summary>Espacio libre debajo del toast (barra de estado + margen).</summary>
        public int BottomOffset = 46;

        public ToastNotice()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
            Size = new Size(W, H);
            Visible = false;
            Cursor = Cursors.Hand;
            using (var gp = Theme.Rounded(new RectangleF(0, 0, W, H), 24))
                Region = new Region(gp);
            timer.Tick += Step;
        }

        public void Mostrar(string mensaje, ToastKind tipo)
        {
            cola.Enqueue(new Msg { Text = mensaje, Kind = tipo });
            if (state == 0) Siguiente();
        }

        void Siguiente()
        {
            if (cola.Count == 0)
            {
                state = 0;
                Visible = false;
                timer.Stop();
                return;
            }
            var m = cola.Dequeue();
            text = m.Text;
            kind = m.Kind;
            state = 1;
            t = 0f;
            hold = 0;
            Reposicionar();
            Visible = true;
            BringToFront();
            Invalidate();
            timer.Start();
        }

        void Step(object s, EventArgs e)
        {
            if (state == 1) { t += 0.07f; if (t >= 1f) { t = 1f; state = 2; } }
            else if (state == 2) { if (++hold > 150) state = 3; }
            else if (state == 3) { t -= 0.08f; if (t <= 0f) { Siguiente(); return; } }
            Reposicionar();
        }

        void Reposicionar()
        {
            if (Parent == null) return;
            float ease = 1f - (float)Math.Pow(1f - t, 3);
            int x = Parent.ClientSize.Width - W - Margen;
            int baseY = Parent.ClientSize.Height - BottomOffset - H;
            Location = new Point(x, baseY + (int)((1f - ease) * (H + BottomOffset)));
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (state == 1 || state == 2) state = 3;
        }

        Color Acento()
        {
            switch (kind)
            {
                case ToastKind.Exito: return Theme.Exito;
                case ToastKind.Error: return Theme.Peligro;
                case ToastKind.Aviso: return Theme.Acento;
                default: return Theme.Info;
            }
        }

        string Icono()
        {
            switch (kind)
            {
                case ToastKind.Exito: return "✔";
                case ToastKind.Error: return "✕";
                case ToastKind.Aviso: return "!";
                default: return "i";
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            g.Clear(Theme.Elevado);

            Color c = Acento();
            using (var bar = new SolidBrush(c))
                g.FillRectangle(bar, 0, 0, 6, H);

            // icono en círculo
            var circ = new RectangleF(20, (H - 30) / 2f, 30, 30);
            using (var cb = new SolidBrush(c))
                g.FillEllipse(cb, circ);
            TextRenderer.DrawText(g, Icono(), FIcono, Rectangle.Round(circ), Theme.TextOn(c),
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);

            TextRenderer.DrawText(g, text, FTexto, new Rectangle(62, 6, W - 62 - 14, H - 12), Theme.Texto,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak | TextFormatFlags.EndEllipsis);

            using (var pen = new Pen(Theme.Borde))
                g.DrawRectangle(pen, 0, 0, W - 1, H - 1);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) timer.Dispose();
            base.Dispose(disposing);
        }
    }
}
