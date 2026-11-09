using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace TemasSemana
{
    // Todas las imágenes del proyecto se dibujan aquí con GDI+; no hay archivos de imagen externos.
    internal static class Dibujo
    {
        private static Graphics Preparar(Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            return g;
        }

        private static GraphicsPath Redondeado(float x, float y, float w, float h, float radio)
        {
            float d = radio * 2f;
            GraphicsPath camino = new GraphicsPath();
            camino.AddArc(x, y, d, d, 180, 90);
            camino.AddArc(x + w - d, y, d, d, 270, 90);
            camino.AddArc(x + w - d, y + h - d, d, d, 0, 90);
            camino.AddArc(x, y + h - d, d, d, 90, 90);
            camino.CloseFigure();
            return camino;
        }

        // Letrero de la tienda con toldo de rayas.
        public static Bitmap Banner(int ancho, int alto)
        {
            Bitmap bmp = new Bitmap(ancho, alto);
            using (Graphics g = Preparar(bmp))
            {
                Rectangle area = new Rectangle(0, 0, ancho, alto);
                using (LinearGradientBrush fondo = new LinearGradientBrush(
                    area, Color.FromArgb(21, 52, 84), Color.FromArgb(46, 117, 182), 90f))
                {
                    g.FillRectangle(fondo, area);
                }

                int franjas = 10;
                float anchoFranja = ancho / (float)franjas;
                for (int i = 0; i < franjas; i++)
                {
                    Color color = (i % 2 == 0) ? Color.FromArgb(200, 40, 40) : Color.White;
                    using (SolidBrush pincel = new SolidBrush(color))
                    {
                        g.FillRectangle(pincel, i * anchoFranja, 0f, anchoFranja + 1f, 34f);
                        g.FillPie(pincel, i * anchoFranja, 14f, anchoFranja, 40f, 0f, 180f);
                    }
                }

                using (Font fuenteTitulo = new Font("Segoe UI", 22F, FontStyle.Bold))
                using (Font fuenteSub = new Font("Segoe UI", 11F))
                using (StringFormat centro = new StringFormat())
                {
                    centro.Alignment = StringAlignment.Center;
                    centro.LineAlignment = StringAlignment.Center;
                    g.DrawString("ABARROTES LA ESQUINA", fuenteTitulo, Brushes.White,
                        new RectangleF(0f, 64f, ancho, 46f), centro);
                    g.DrawString("Temas de la semana: 21, 22, 24 y 25", fuenteSub, Brushes.WhiteSmoke,
                        new RectangleF(0f, 110f, ancho, 28f), centro);
                }
            }
            return bmp;
        }

        public static Bitmap IconoTeclado(int s)
        {
            Bitmap bmp = new Bitmap(s, s);
            using (Graphics g = Preparar(bmp))
            {
                float cuerpoY = s * 0.25f;
                using (GraphicsPath cuerpo = Redondeado(2f, cuerpoY, s - 4f, s * 0.5f, 4f))
                using (SolidBrush pincel = new SolidBrush(Color.FromArgb(55, 65, 85)))
                {
                    g.FillPath(pincel, cuerpo);
                }

                float margen = s * 0.12f;
                float hueco = s * 0.05f;
                float altoTecla = s * 0.1f;
                float anchoTecla = (s - 2f * margen - 3f * hueco) / 4f;
                for (int fila = 0; fila < 2; fila++)
                {
                    for (int col = 0; col < 4; col++)
                    {
                        float x = margen + col * (anchoTecla + hueco);
                        float y = cuerpoY + hueco + fila * (altoTecla + hueco);
                        g.FillRectangle(Brushes.White, x, y, anchoTecla, altoTecla);
                    }
                }
                float yEspacio = cuerpoY + hueco + 2f * (altoTecla + hueco);
                g.FillRectangle(Brushes.White, margen + anchoTecla + hueco, yEspacio, anchoTecla * 2f + hueco, altoTecla);
            }
            return bmp;
        }

        public static Bitmap IconoTabla(int s)
        {
            Bitmap bmp = new Bitmap(s, s);
            using (Graphics g = Preparar(bmp))
            using (GraphicsPath marco = Redondeado(2f, 4f, s - 4f, s - 8f, 4f))
            {
                g.FillPath(Brushes.White, marco);
                using (SolidBrush cabecera = new SolidBrush(UI.Azul))
                {
                    g.FillRectangle(cabecera, 3f, 5f, s - 6f, s * 0.22f);
                }
                using (Pen lineas = new Pen(Color.FromArgb(130, 150, 170), 1.5f))
                {
                    g.DrawLine(lineas, 3f, s * 0.5f, s - 3f, s * 0.5f);
                    g.DrawLine(lineas, 3f, s * 0.7f, s - 3f, s * 0.7f);
                    g.DrawLine(lineas, s / 2f, 5f + s * 0.22f, s / 2f, s - 5f);
                }
                using (Pen borde = new Pen(UI.Azul, 2f))
                {
                    g.DrawPath(borde, marco);
                }
            }
            return bmp;
        }

        public static Bitmap IconoLupa(int s)
        {
            Bitmap bmp = new Bitmap(s, s);
            using (Graphics g = Preparar(bmp))
            {
                using (SolidBrush vidrio = new SolidBrush(Color.FromArgb(120, 200, 230, 255)))
                {
                    g.FillEllipse(vidrio, s * 0.12f, s * 0.12f, s * 0.5f, s * 0.5f);
                }
                using (Pen pluma = new Pen(UI.Azul, s * 0.1f))
                {
                    pluma.StartCap = LineCap.Round;
                    pluma.EndCap = LineCap.Round;
                    g.DrawEllipse(pluma, s * 0.12f, s * 0.12f, s * 0.5f, s * 0.5f);
                    g.DrawLine(pluma, s * 0.55f, s * 0.55f, s * 0.88f, s * 0.88f);
                }
            }
            return bmp;
        }

        public static Bitmap IconoLapiz(int s)
        {
            Bitmap bmp = new Bitmap(s, s);
            using (Graphics g = Preparar(bmp))
            {
                g.TranslateTransform(s / 2f, s / 2f);
                g.RotateTransform(45f);

                float ancho = s * 0.16f;
                g.FillRectangle(Brushes.Gold, -ancho / 2f, -s * 0.30f, ancho, s * 0.46f);
                g.FillRectangle(Brushes.HotPink, -ancho / 2f, -s * 0.40f, ancho, s * 0.10f);

                PointF[] madera =
                {
                    new PointF(-ancho / 2f, s * 0.16f),
                    new PointF(ancho / 2f, s * 0.16f),
                    new PointF(0f, s * 0.38f)
                };
                g.FillPolygon(Brushes.BurlyWood, madera);

                PointF[] grafito =
                {
                    new PointF(-ancho * 0.15f, s * 0.31f),
                    new PointF(ancho * 0.15f, s * 0.31f),
                    new PointF(0f, s * 0.38f)
                };
                g.FillPolygon(Brushes.DimGray, grafito);
            }
            return bmp;
        }
    }
}
