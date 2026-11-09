using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;

namespace PDV
{
    /// <summary>
    /// Inicio de sesión (sin Diseñador, todo en código).
    /// Usuario: Alumno1   Contraseña: Cbtis224
    /// Izquierda: marca con gotas de pintura flotando. Derecha: formulario.
    /// Si los datos fallan, la tarjeta "tiembla"; si son correctos, se desvanece y abre la caja.
    /// </summary>
    public class FormLogin : Form
    {
        const string UsuarioOk = "Alumno1";
        const string ClaveOk = "Cbtis224";
        const int LeftW = 420;
        const int FormW = 900, FormH = 540;

        public string Usuario { get; private set; }

        class Burbuja { public float X, Y, R, V, Fase; public Color C; }

        readonly List<Burbuja> burbujas = new List<Burbuja>();
        readonly Random rnd = new Random();
        readonly Timer timer = new Timer { Interval = 16 };

        BufPanel card;
        TextBox txtUser, txtPass;
        AnimButton btnEntrar;
        Label lblError, lblCerrar;
        float phase, shake;
        bool saliendo;
        int salidaT;

        static readonly Font FMarca = new Font("Segoe UI", 54f, FontStyle.Bold | FontStyle.Italic);
        static readonly Font FTag = new Font("Segoe UI", 11f, FontStyle.Bold);
        static readonly Font FSub = new Font("Segoe UI", 12f);
        static readonly Font FPie = new Font("Segoe UI", 9f);

        [DllImport("user32.dll")] static extern bool ReleaseCapture();
        [DllImport("user32.dll")] static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        public FormLogin()
        {
            Text = "PDV - Inicio de sesión";
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(FormW, FormH);
            BackColor = Theme.Fondo;
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10f);
            using (var gp = Theme.Rounded(new RectangleF(0, 0, FormW, FormH), 36))
                Region = new Region(gp);

            for (int i = 0; i < 16; i++)
            {
                burbujas.Add(new Burbuja
                {
                    X = rnd.Next(30, LeftW - 30),
                    Y = rnd.Next(0, FormH),
                    R = rnd.Next(14, 46),
                    V = 0.3f + (float)rnd.NextDouble() * 0.8f,
                    Fase = (float)(rnd.NextDouble() * 6.28),
                    C = Theme.Paleta[i % Theme.Paleta.Length]
                });
            }

            Construir();
            MouseDown += Arrastrar;

            timer.Tick += Tick;
            timer.Start();
            Shown += (s, e) => txtUser.Focus();
        }

        // ---------- construcción ----------
        Label Etiqueta(Control parent, string text, int x, int y, float size, Color color, FontStyle style = FontStyle.Bold)
        {
            var l = new Label
            {
                Text = text, AutoSize = true, BackColor = Color.Transparent, ForeColor = color,
                Font = new Font("Segoe UI", size, style), Location = new Point(x, y)
            };
            parent.Controls.Add(l);
            return l;
        }

        TextBox Campo(Control parent, int x, int y, int w, bool clave)
        {
            var t = new TextBox
            {
                Location = new Point(x, y), Width = w, BorderStyle = BorderStyle.None,
                BackColor = Theme.Input, ForeColor = Theme.Texto, Font = new Font("Segoe UI", 12f),
                UseSystemPasswordChar = clave
            };
            parent.Controls.Add(t);
            return t;
        }

        void Construir()
        {
            card = new BufPanel { Location = new Point(LeftW, 0), Size = new Size(FormW - LeftW, FormH), BackColor = Theme.Fondo };
            Controls.Add(card);

            Etiqueta(card, "Inicio de sesión", 50, 84, 24f, Theme.Texto);
            Etiqueta(card, "Ingresa para abrir la caja", 52, 134, 10f, Theme.Texto2, FontStyle.Regular);

            Etiqueta(card, "USUARIO", 50, 190, 8f, Theme.Texto2);
            txtUser = Campo(card, 62, 218, 336, false);

            Etiqueta(card, "CONTRASEÑA", 50, 272, 8f, Theme.Texto2);
            txtPass = Campo(card, 62, 300, 336, true);

            lblError = Etiqueta(card, "", 50, 352, 9f, Theme.Peligro);

            btnEntrar = new AnimButton
            {
                Text = "Iniciar sesión", Location = new Point(50, 384), Size = new Size(360, 50),
                Variant = ButtonVariant.Primary, Font = new Font("Segoe UI", 12f, FontStyle.Bold)
            };
            btnEntrar.Click += (s, e) => Entrar();
            card.Controls.Add(btnEntrar);
            AcceptButton = btnEntrar;

            Etiqueta(card, "Demo: Alumno1  ·  Cbtis224", 52, 452, 8.5f, Theme.Texto2, FontStyle.Regular);

            lblCerrar = new Label
            {
                Text = "✕", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(36, 36), Location = new Point(card.Width - 48, 10),
                Font = new Font("Segoe UI Symbol", 12f, FontStyle.Bold), ForeColor = Theme.Texto2,
                BackColor = Color.Transparent, Cursor = Cursors.Hand
            };
            lblCerrar.MouseEnter += (s, e) => lblCerrar.ForeColor = Theme.Peligro;
            lblCerrar.MouseLeave += (s, e) => lblCerrar.ForeColor = Theme.Texto2;
            lblCerrar.Click += (s, e) => { DialogResult = DialogResult.Cancel; };
            card.Controls.Add(lblCerrar);

            card.Paint += Card_Paint;
            card.MouseDown += Arrastrar;
            txtUser.GotFocus += (s, e) => card.Invalidate();
            txtUser.LostFocus += (s, e) => card.Invalidate();
            txtPass.GotFocus += (s, e) => card.Invalidate();
            txtPass.LostFocus += (s, e) => card.Invalidate();
        }

        void Arrastrar(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, 0xA1, (IntPtr)2, IntPtr.Zero);   // WM_NCLBUTTONDOWN, HTCAPTION
        }

        // ---------- lógica ----------
        void Entrar()
        {
            if (saliendo) return;
            if (txtUser.Text.Trim() == UsuarioOk && txtPass.Text == ClaveOk)
            {
                Usuario = txtUser.Text.Trim();
                saliendo = true;
                lblError.ForeColor = Theme.Exito;
                lblError.Text = "✔  Bienvenido, " + Usuario;
            }
            else
            {
                lblError.ForeColor = Theme.Peligro;
                lblError.Text = "Usuario o contraseña incorrectos.";
                shake = 1f;
                txtPass.Clear();
                txtPass.Focus();
            }
        }

        void Tick(object s, EventArgs e)
        {
            phase += 0.03f;
            foreach (var b in burbujas)
            {
                b.Y -= b.V;
                b.X += (float)Math.Sin(phase + b.Fase) * 0.35f;
                if (b.Y + b.R < 0)
                {
                    b.Y = FormH + b.R;
                    b.X = rnd.Next(30, LeftW - 30);
                }
            }
            Invalidate(new Rectangle(0, 0, LeftW, FormH));

            if (shake > 0f)
            {
                shake -= 0.045f;
                card.Left = shake <= 0f ? LeftW : LeftW + (int)(Math.Sin(shake * 40f) * 12f * shake);
            }

            if (saliendo)
            {
                salidaT++;
                if (salidaT > 28)
                {
                    Opacity = Math.Max(0, Opacity - 0.07);
                    if (Opacity <= 0.02)
                    {
                        timer.Stop();
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        // ---------- dibujo ----------
        static void DibujarCampo(Graphics g, Control c, bool foco)
        {
            var r = new RectangleF(c.Left - 12 + 0.5f, c.Top - 8 + 0.5f, c.Width + 24, c.Height + 16);
            using (var p = Theme.Rounded(r, 18))
            using (var b = new SolidBrush(Theme.Input))
            using (var pen = new Pen(foco ? Theme.Acento : Theme.Borde, foco ? 1.5f : 1f))
            {
                g.FillPath(b, p);
                g.DrawPath(pen, p);
            }
        }

        void Card_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            DibujarCampo(e.Graphics, txtUser, txtUser.Focused);
            DibujarCampo(e.Graphics, txtPass, txtPass.Focused);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            var left = new Rectangle(0, 0, LeftW, FormH);
            using (var lg = new LinearGradientBrush(left, Theme.FondoProfundo, Theme.Elevado, 60f))
                g.FillRectangle(lg, left);

            // gotas de pintura flotando
            foreach (var b in burbujas)
            {
                var r = new RectangleF(b.X - b.R, b.Y - b.R, b.R * 2, b.R * 2);
                using (var br = new SolidBrush(Color.FromArgb(120, b.C)))
                    g.FillEllipse(br, r);
                using (var hl = new SolidBrush(Color.FromArgb(70, 255, 255, 255)))
                    g.FillEllipse(hl, b.X - b.R * 0.55f, b.Y - b.R * 0.6f, b.R * 0.5f, b.R * 0.35f);
            }

            // marca
            using (var tb = new SolidBrush(Theme.Texto))
            using (var ab = new SolidBrush(Theme.Acento))
            using (var sb = new SolidBrush(Theme.Texto2))
            {
                g.DrawString("Pymasa", FMarca, tb, 36, 170);
                g.DrawString("PINTURAS PARA PROFESIONALES", FTag, ab, 46, 262);
                g.DrawString("Sistema Punto de Venta", FSub, sb, 46, 292);
                g.DrawString("Culiacán, Sinaloa, México  ·  +52 667 217 7576", FPie, sb, 46, 488);
            }

            // franja de muestras de pintura
            float w = LeftW / (float)Theme.Paleta.Length;
            for (int i = 0; i < Theme.Paleta.Length; i++)
                using (var cb = new SolidBrush(Theme.Paleta[i]))
                    g.FillRectangle(cb, i * w, FormH - 10, w + 0.6f, 10);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) timer.Dispose();
            base.Dispose(disposing);
        }
    }
}
