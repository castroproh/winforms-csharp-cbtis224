using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TemasSemana1620
{
    /// <summary>Iconos de 24x24 dibujados por código con GDI+ (no se usan archivos de imagen).</summary>
    internal static class IconosCodigo
    {
        public static Bitmap Crear(string tipo)
        {
            Bitmap bmp = new Bitmap(24, 24);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                switch (tipo)
                {
                    case "nuevo":
                        g.FillRectangle(Brushes.White, 5, 2, 14, 20);
                        g.DrawRectangle(Pens.DimGray, 5, 2, 14, 20);
                        g.DrawLine(Pens.Gray, 8, 8, 16, 8);
                        g.DrawLine(Pens.Gray, 8, 12, 16, 12);
                        g.DrawLine(Pens.Gray, 8, 16, 16, 16);
                        break;

                    case "abrir":
                        g.FillRectangle(Brushes.Gold, 2, 5, 9, 4);
                        g.FillRectangle(Brushes.Goldenrod, 2, 8, 20, 13);
                        g.DrawRectangle(Pens.DarkGoldenrod, 2, 8, 20, 13);
                        break;

                    case "guardar":
                        g.FillRectangle(Brushes.SteelBlue, 3, 3, 18, 18);
                        g.FillRectangle(Brushes.White, 7, 3, 10, 7);
                        g.FillRectangle(Brushes.LightGray, 7, 14, 10, 7);
                        break;

                    case "cortar":
                        using (Pen rojo = new Pen(Color.Crimson, 2F))
                        {
                            g.DrawLine(rojo, 6, 3, 16, 15);
                            g.DrawLine(rojo, 18, 3, 8, 15);
                            g.DrawEllipse(rojo, 3, 15, 6, 6);
                            g.DrawEllipse(rojo, 15, 15, 6, 6);
                        }
                        break;

                    case "copiar":
                        g.FillRectangle(Brushes.White, 3, 3, 11, 14);
                        g.DrawRectangle(Pens.DimGray, 3, 3, 11, 14);
                        g.FillRectangle(Brushes.LightSkyBlue, 9, 7, 11, 14);
                        g.DrawRectangle(Pens.SteelBlue, 9, 7, 11, 14);
                        break;

                    case "pegar":
                        g.FillRectangle(Brushes.Peru, 4, 4, 16, 18);
                        g.FillRectangle(Brushes.White, 7, 8, 10, 12);
                        g.FillRectangle(Brushes.DimGray, 8, 2, 8, 5);
                        break;

                    case "negrita":
                        DibujarLetra(g, "B", FontStyle.Bold, false);
                        break;

                    case "cursiva":
                        DibujarLetra(g, "I", FontStyle.Italic, false);
                        break;

                    case "subrayado":
                        DibujarLetra(g, "U", FontStyle.Regular, true);
                        break;

                    case "color":
                        g.FillPie(Brushes.Red, 3, 3, 18, 18, 0, 90);
                        g.FillPie(Brushes.Gold, 3, 3, 18, 18, 90, 90);
                        g.FillPie(Brushes.SeaGreen, 3, 3, 18, 18, 180, 90);
                        g.FillPie(Brushes.RoyalBlue, 3, 3, 18, 18, 270, 90);
                        break;

                    default:
                        g.FillRectangle(Brushes.Gray, 4, 4, 16, 16);
                        break;
                }
            }
            return bmp;
        }

        private static void DibujarLetra(Graphics g, string letra, FontStyle estilo, bool subrayar)
        {
            using (Font fuente = new Font("Times New Roman", 13F, estilo, GraphicsUnit.Pixel))
            {
                g.DrawString(letra, fuente, Brushes.Black, 5F, 3F);
            }
            if (subrayar)
            {
                g.DrawLine(Pens.Black, 5, 21, 19, 21);
            }
        }
    }
}
