using System.Drawing.Drawing2D;

namespace Temas_semana_9___13
{
    // Botón redondo: hereda de Button y recorta su región en forma de elipse.
    // Si el ancho y el alto son iguales, queda un círculo perfecto.
    public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, Width, Height);
            this.Region = new Region(path);
            base.OnPaint(pevent);
        }
    }
}
