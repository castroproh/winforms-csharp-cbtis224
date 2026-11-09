namespace Temas_Semana_9_13;

// Tema 13 - MouseEnter en Panel
// Al pasar el mouse por el panel cambia a gris claro y al quitarlo vuelve a blanco
public partial class FormMouseEnter : Form
{
    public FormMouseEnter()
    {
        InitializeComponent();

        // Las imágenes se dibujan en código (Imagenes.cs)
        imagen1.Image = Imagenes.Icono("M", Color.SteelBlue, 140);
        imagen2.Image = Imagenes.Icono("A", Color.SeaGreen, 140);
        imagen3.Image = Imagenes.Icono("C", Color.DarkOrange, 140);
    }

    private void Panel_MouseEnter(object sender, EventArgs e)
    {
        ((Panel)sender).BackColor = Color.LightGray;
    }

    private void Panel_MouseLeave(object sender, EventArgs e)
    {
        var panel = (Panel)sender;

        // Si el mouse sigue dentro del panel (por ejemplo sobre la imagen), no se cambia el color
        if (panel.ClientRectangle.Contains(panel.PointToClient(Cursor.Position)))
        {
            return;
        }

        panel.BackColor = Color.White;
    }
}
