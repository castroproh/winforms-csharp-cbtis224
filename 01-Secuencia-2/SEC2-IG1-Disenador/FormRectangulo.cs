using System.Drawing;

namespace SEC2_IG1;

// Área y perímetro de un rectángulo con lados de 1 a 50
// TextBox, PictureBox, try/catch, MessageBox, DateTime.Now, Focus
public partial class FormRectangulo : Form
{
    public FormRectangulo()
    {
        InitializeComponent();
    }

    private void FormRectangulo_Shown(object sender, EventArgs e)
    {
        txtBase.Focus();
    }

    private static int LeerLado(TextBox caja)
    {
        int valor = Convert.ToInt32(caja.Text.Trim());
        if (valor < 1 || valor > 50)
        {
            throw new ArgumentOutOfRangeException(nameof(caja), "El lado debe estar entre 1 y 50.");
        }
        return valor;
    }

    private void Calcular(object sender, EventArgs e)
    {
        TextBox actual = txtBase;
        try
        {
            actual = txtBase;
            int b = LeerLado(txtBase);
            actual = txtAltura;
            int h = LeerLado(txtAltura);

            int area = b * h;
            int perimetro = 2 * (b + h);

            lblArea.Text = "Área: " + area;
            lblPerimetro.Text = "Perímetro: " + perimetro;
            lblFecha.Text = "Calculado el " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            Dibujar(b, h);
        }
        catch (Exception ex) when (ex is FormatException || ex is OverflowException)
        {
            MessageBox.Show("Escribe un número entero en el cuadro.", "Dato no válido",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            actual.Focus();
            actual.SelectAll();
        }
        catch (ArgumentOutOfRangeException)
        {
            MessageBox.Show("El lado debe estar entre 1 y 50.", "Fuera de rango",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            actual.Focus();
            actual.SelectAll();
        }
    }

    private void Limpiar(object sender, EventArgs e)
    {
        txtBase.Clear();
        txtAltura.Clear();
        lblArea.Text = "Área: ";
        lblPerimetro.Text = "Perímetro: ";
        lblFecha.Text = "";
        picRectangulo.Image = null;
        txtBase.Focus();
    }

    // Dibuja el rectángulo a escala dentro del PictureBox
    private void Dibujar(int b, int h)
    {
        const int escala = 5; // 50 unidades = 250 px
        var bmp = new Bitmap(picRectangulo.Width - 4, picRectangulo.Height - 4);
        using (var g = Graphics.FromImage(bmp))
        {
            g.Clear(Color.White);
            int ancho = b * escala;
            int alto = h * escala;
            int x = (bmp.Width - ancho) / 2;
            int y = (bmp.Height - alto) / 2;
            g.FillRectangle(Brushes.LightSkyBlue, x, y, ancho, alto);
            g.DrawRectangle(Pens.Navy, x, y, ancho, alto);
        }
        picRectangulo.Image = bmp;
    }
}
