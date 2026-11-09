using System.Drawing;
using System.Drawing.Drawing2D;

namespace Temas_Semana_9_13;

// Imágenes dibujadas en código, para que el proyecto no dependa de archivos externos
internal static class Imagenes
{
    public static Bitmap Icono(string letra, Color color, int tam)
    {
        var bmp = new Bitmap(tam, tam);
        using (var g = Graphics.FromImage(bmp))
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            using (var pincel = new SolidBrush(color))
            {
                g.FillEllipse(pincel, 6, 6, tam - 12, tam - 12);
            }
            using (var fuente = new Font("Segoe UI", tam / 3f, FontStyle.Bold))
            using (var formato = new StringFormat())
            {
                formato.Alignment = StringAlignment.Center;
                formato.LineAlignment = StringAlignment.Center;
                g.DrawString(letra, fuente, Brushes.White, new RectangleF(0, 0, tam, tam), formato);
            }
        }
        return bmp;
    }

    public static Bitmap IconoUsuario(int tam, Color fondo, Color figura)
    {
        var bmp = new Bitmap(tam, tam);
        using (var g = Graphics.FromImage(bmp))
        using (var pincel = new SolidBrush(figura))
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(fondo);
            g.FillEllipse(pincel, tam * 0.30f, tam * 0.08f, tam * 0.40f, tam * 0.40f);
            g.FillEllipse(pincel, tam * 0.10f, tam * 0.55f, tam * 0.80f, tam * 0.80f);
        }
        return bmp;
    }
}
