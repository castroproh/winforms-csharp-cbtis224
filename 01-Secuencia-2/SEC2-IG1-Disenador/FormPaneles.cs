using System.Drawing;
using System.Drawing.Drawing2D;

namespace SEC2_IG1;

// Panel, PictureBox, TextBox, Button y la propiedad Visible
public partial class FormPaneles : Form
{
    public FormPaneles()
    {
        InitializeComponent();

        // La imagen se dibuja en código, por eso se asigna aquí y no en el Diseñador
        pic.Image = CrearImagen(476, 276);
    }

    private void btnImagen_Click(object sender, EventArgs e)
    {
        pnlSuma.Visible = false;
        pnlImagen.Visible = true;
    }

    private void btnSuma_Click(object sender, EventArgs e)
    {
        pnlImagen.Visible = false;
        pnlSuma.Visible = true;
        txtA.Focus();
    }

    private void btnOcultar_Click(object sender, EventArgs e)
    {
        pnlImagen.Visible = false;
        pnlSuma.Visible = false;
    }

    private void Sumar(object sender, EventArgs e)
    {
        try
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            lblResultado.Text = "Resultado: " + (a + b);
        }
        catch (FormatException)
        {
            MessageBox.Show("Escribe solo números en los dos cuadros.", "Dato no válido",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtA.Focus();
        }
    }

    // La imagen se dibuja en código para no depender de archivos externos
    private static Bitmap CrearImagen(int ancho, int alto)
    {
        var bmp = new Bitmap(ancho, alto);
        using (var g = Graphics.FromImage(bmp))
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var fondo = new LinearGradientBrush(new Rectangle(0, 0, ancho, alto),
                       Color.FromArgb(56, 189, 248), Color.FromArgb(30, 64, 175), 90f))
            {
                g.FillRectangle(fondo, 0, 0, ancho, alto);
            }
            g.FillEllipse(Brushes.Gold, ancho - 130, 30, 80, 80);
            g.FillRectangle(Brushes.ForestGreen, 0, alto - 60, ancho, 60);
            using (var fuente = new Font("Segoe UI", 20, FontStyle.Bold))
            {
                g.DrawString("¡Panel con PictureBox!", fuente, Brushes.White, 30, 90);
            }
        }
        return bmp;
    }
}
