using System.Drawing;
using System.Drawing.Drawing2D;

namespace Temas_Semana_9_13;

// Tema 8 - RoundButton: botón que hereda de Button y se dibuja como una elipse
public class RoundButton : Button
{
    protected override void OnPaint(PaintEventArgs pevent)
    {
        using (var grpath = new GraphicsPath())
        {
            grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grpath);
        }
        base.OnPaint(pevent);
    }
}
