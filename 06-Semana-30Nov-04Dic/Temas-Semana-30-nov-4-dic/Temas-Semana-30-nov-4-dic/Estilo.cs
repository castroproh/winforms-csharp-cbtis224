using System.Drawing.Drawing2D;

namespace Temas_Semana_30_nov_4_dic
{
    // Colores, imagenes dibujadas en codigo y fabricas de controles
    public static class Estilo
    {
        public static readonly Color Fondo = Color.FromArgb(236, 239, 241);
        public static readonly Color Principal = Color.FromArgb(0, 121, 107);
        public static readonly Color Oscuro = Color.FromArgb(38, 50, 56);
        public static readonly Color Acento = Color.FromArgb(239, 108, 0);
        public static readonly Color Rojo = Color.FromArgb(198, 40, 40);
        public static readonly Color Verde = Color.FromArgb(46, 125, 50);
        public static readonly Color Azul = Color.FromArgb(21, 101, 192);

        // Logo redondo con una "P" (imagen dibujada, sin archivos)
        public static Bitmap Logo(int tam)
        {
            Bitmap bmp = new Bitmap(tam, tam);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                Rectangle r = new Rectangle(1, 1, tam - 3, tam - 3);
                using (LinearGradientBrush br = new LinearGradientBrush(r, Color.FromArgb(0, 150, 136), Color.FromArgb(0, 77, 64), 45f))
                {
                    g.FillEllipse(br, r);
                }
                using (Pen p = new Pen(Color.White, Math.Max(2f, tam / 28f)))
                {
                    g.DrawEllipse(p, tam * 0.09f, tam * 0.09f, tam * 0.82f, tam * 0.82f);
                }
                using (StringFormat sf = new StringFormat())
                using (Font f = new Font("Segoe UI", tam * 0.5f, FontStyle.Bold, GraphicsUnit.Pixel))
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    g.DrawString("P", f, Brushes.White, new RectangleF(0, 0, tam, tam), sf);
                }
            }
            return bmp;
        }

        // Banner del menu principal: degradado, circulos, logo y carrito
        public static Bitmap Banner(int ancho, int alto)
        {
            Bitmap bmp = new Bitmap(ancho, alto);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                using (LinearGradientBrush br = new LinearGradientBrush(new Rectangle(0, 0, ancho, alto), Color.FromArgb(0, 121, 107), Color.FromArgb(38, 50, 56), 20f))
                {
                    g.FillRectangle(br, 0, 0, ancho, alto);
                }

                using (SolidBrush suave = new SolidBrush(Color.FromArgb(28, 255, 255, 255)))
                {
                    g.FillEllipse(suave, ancho - 130, -50, 190, 190);
                    g.FillEllipse(suave, ancho - 70, 70, 120, 120);
                    g.FillEllipse(suave, 170, -70, 110, 110);
                }

                using (Bitmap logo = Logo(88))
                {
                    g.DrawImage(logo, 26, (alto - 88) / 2);
                }

                using (Font f1 = new Font("Segoe UI", 32f, FontStyle.Bold, GraphicsUnit.Pixel))
                {
                    g.DrawString("PYMASA", f1, Brushes.White, 126, alto / 2f - 42);
                }
                using (Font f2 = new Font("Segoe UI", 16f, FontStyle.Regular, GraphicsUnit.Pixel))
                using (SolidBrush claro = new SolidBrush(Color.FromArgb(225, 255, 255, 255)))
                {
                    g.DrawString("Punto de venta", f2, claro, 129, alto / 2f + 6);
                }

                // Carrito de compras dibujado con lineas y circulos
                float x = ancho - 112;
                float y = alto / 2f - 26;
                using (Pen p = new Pen(Color.White, 4f))
                {
                    p.StartCap = LineCap.Round;
                    p.EndCap = LineCap.Round;
                    p.LineJoin = LineJoin.Round;
                    g.DrawLines(p, new PointF[]
                    {
                        new PointF(x, y), new PointF(x + 12, y), new PointF(x + 26, y + 38),
                        new PointF(x + 68, y + 38), new PointF(x + 78, y + 12), new PointF(x + 16, y + 12)
                    });
                }
                g.FillEllipse(Brushes.White, x + 26, y + 48, 12, 12);
                g.FillEllipse(Brushes.White, x + 56, y + 48, 12, 12);
            }
            return bmp;
        }

        // Barra superior con logo y titulo
        public static Panel Encabezado(string titulo, int ancho)
        {
            Panel pnl = new Panel();
            pnl.SetBounds(0, 0, ancho, 70);
            pnl.BackColor = Oscuro;

            PictureBox pic = new PictureBox();
            pic.SetBounds(16, 11, 48, 48);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Image = Logo(96);
            pnl.Controls.Add(pic);

            Label lbl = new Label();
            lbl.SetBounds(76, 16, ancho - 96, 38);
            lbl.Text = titulo;
            lbl.ForeColor = Color.White;
            lbl.Font = new Font("Segoe UI", 16f, FontStyle.Bold);
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            pnl.Controls.Add(lbl);

            return pnl;
        }

        public static Button Boton(string texto, int x, int y, int ancho, int alto, Color fondo)
        {
            Button b = new Button();
            b.Text = texto;
            b.SetBounds(x, y, ancho, alto);
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = ControlPaint.Light(fondo, 0.25f);
            b.UseVisualStyleBackColor = false;
            b.BackColor = fondo;
            b.ForeColor = Color.White;
            b.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            b.Cursor = Cursors.Hand;
            return b;
        }

        public static Label Etiqueta(string texto, int x, int y, int ancho, int alto, float tam, bool negrita, ContentAlignment alineacion)
        {
            Label l = new Label();
            l.Text = texto;
            l.SetBounds(x, y, ancho, alto);
            l.AutoSize = false;
            l.TextAlign = alineacion;
            l.Font = new Font("Segoe UI", tam, negrita ? FontStyle.Bold : FontStyle.Regular);
            return l;
        }

        public static void EstiloGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 34;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Principal;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Principal;
            dgv.RowTemplate.Height = 28;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 250);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
    }
}
