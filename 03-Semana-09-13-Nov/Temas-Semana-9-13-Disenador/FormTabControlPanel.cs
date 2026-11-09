namespace Temas_Semana_9_13;

// Tema 5 - TabControl y Panel
// Cuatro fichas: PANEL (con scroll y varias imágenes), BOTONES, LABEL y TEXTBOX
public partial class FormTabControlPanel : Form
{
    public FormTabControlPanel()
    {
        InitializeComponent();

        // Ficha 1: las imágenes se dibujan en código (Imagenes.cs)
        picNumero1.Image = Imagenes.Icono("1", Color.Firebrick, 120);
        picPanel1.Image = Imagenes.Icono("Panel", Color.Teal, 250);
        picNumero2.Image = Imagenes.Icono("2", Color.SteelBlue, 120);
        picPanel2.Image = Imagenes.Icono("Panel", Color.MediumPurple, 250);
        picNumero3.Image = Imagenes.Icono("3", Color.SeaGreen, 120);
        picPanel3.Image = Imagenes.Icono("Panel", Color.DarkOrange, 250);
        picNumero4.Image = Imagenes.Icono("4", Color.DarkOrange, 120);
        picPanel4.Image = Imagenes.Icono("Panel", Color.SeaGreen, 250);
        picNumero5.Image = Imagenes.Icono("5", Color.MediumPurple, 120);
        picPanel5.Image = Imagenes.Icono("Panel", Color.SteelBlue, 250);
        picNumero6.Image = Imagenes.Icono("6", Color.Teal, 120);
        picPanel6.Image = Imagenes.Icono("Panel", Color.Firebrick, 250);
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        Close();
    }
}
