using System.ComponentModel;
using System.Drawing.Drawing2D;
using Timer = System.Windows.Forms.Timer;

namespace PDV
{
    public enum ButtonVariant { Primary, Success, Danger, Info, Ghost }

    /// <summary>
    /// Botón redondeado dibujado a mano. El color comunica la acción:
    /// Primary = amarillo de marca, Success = cobrar, Danger = eliminar, Info = editar.
    /// Al pasar el mouse se aclara y se "levanta"; al presionar se hunde.
    /// </summary>
    public class AnimButton : Button
    {
        ButtonVariant variant = ButtonVariant.Primary;
        int radius = 12;
        float hoverT, pressT;
        bool over, down;
        readonly Timer timer = new Timer { Interval = 15 };

        [DefaultValue(ButtonVariant.Primary)]
        public ButtonVariant Variant
        {
            get { return variant; }
            set { variant = value; Invalidate(); }
        }

        [DefaultValue(12)]
        public int Radius
        {
            get { return radius; }
            set { radius = value; Invalidate(); }
        }

        public AnimButton()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 10.5f, FontStyle.Bold);
            timer.Tick += (s, e) =>
            {
                float th = over ? 1f : 0f, tp = down ? 1f : 0f;
                hoverT += (th - hoverT) * 0.25f;
                pressT += (tp - pressT) * 0.4f;
                if (Math.Abs(th - hoverT) < 0.01f) hoverT = th;
                if (Math.Abs(tp - pressT) < 0.01f) pressT = tp;
                Invalidate();
                if (hoverT == th && pressT == tp) timer.Stop();
            };
        }

        Color BaseColor()
        {
            switch (variant)
            {
                case ButtonVariant.Success: return Theme.Exito;
                case ButtonVariant.Danger: return Theme.Peligro;
                case ButtonVariant.Info: return Theme.Info;
                case ButtonVariant.Ghost: return Theme.Superficie;
                default: return Theme.Acento;
            }
        }

        protected override void OnMouseEnter(EventArgs e) { base.OnMouseEnter(e); over = true; timer.Start(); }
        protected override void OnMouseLeave(EventArgs e) { base.OnMouseLeave(e); over = false; down = false; timer.Start(); }
        protected override void OnMouseDown(MouseEventArgs e) { base.OnMouseDown(e); down = true; timer.Start(); }
        protected override void OnMouseUp(MouseEventArgs e) { base.OnMouseUp(e); down = false; timer.Start(); }
        protected override void OnEnabledChanged(EventArgs e) { base.OnEnabledChanged(e); Invalidate(); }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Parent != null ? Parent.BackColor : Theme.Fondo);
            if (Width < 8 || Height < 10) return;

            bool ghost = variant == ButtonVariant.Ghost;
            Color baseC = BaseColor();
            float dy = pressT * 2f - hoverT * 1f;
            var body = new RectangleF(0.5f, 1.5f + dy, Width - 1f, Height - 5f);

            Color fill, fore;
            if (!Enabled)
            {
                fill = Color.FromArgb(52, 60, 94);
                fore = Theme.Texto2;
            }
            else if (ghost)
            {
                fill = Theme.Lerp(Theme.Superficie, Theme.Elevado, hoverT);
                fore = Theme.Lerp(Theme.Texto, Theme.Acento, hoverT);
            }
            else
            {
                fill = Theme.Lerp(Theme.Lerp(baseC, Color.White, hoverT * 0.18f), Color.Black, pressT * 0.18f);
                fore = Theme.TextOn(baseC);
            }

            // sombra
            if (Enabled && !ghost)
            {
                var sh = new RectangleF(body.X, body.Y + 3f - pressT * 2f, body.Width, body.Height);
                using (var sp = Theme.Rounded(sh, radius * 2))
                using (var sb = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
                    g.FillPath(sb, sp);
            }

            using (var path = Theme.Rounded(body, radius * 2))
            using (var fb = new SolidBrush(fill))
            {
                g.FillPath(fb, path);
                if (ghost)
                {
                    using (var pen = new Pen(Theme.Lerp(Theme.Borde, Theme.Acento, hoverT), 1.5f))
                        g.DrawPath(pen, path);
                }
            }

            TextRenderer.DrawText(g, Text, Font, Rectangle.Round(body), fore,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter |
                TextFormatFlags.EndEllipsis | TextFormatFlags.SingleLine | TextFormatFlags.NoPadding);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) timer.Dispose();
            base.Dispose(disposing);
        }
    }
}
