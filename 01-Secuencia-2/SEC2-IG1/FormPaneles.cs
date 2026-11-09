using System.Drawing;
using System.Drawing.Drawing2D;

namespace SEC2_IG1;

// Panel, PictureBox, TextBox, Button y la propiedad Visible
public class FormPaneles : Form
{
    private readonly Panel pnlImagen;
    private readonly Panel pnlSuma;
    private readonly TextBox txtA;
    private readonly TextBox txtB;
    private readonly Label lblResultado;

    public FormPaneles()
    {
        Text = "Paneles";
        ClientSize = new Size(520, 360);
        StartPosition = FormStartPosition.CenterParent;

        var btnImagen = new Button { Text = "Mostrar imagen", Location = new Point(20, 14), Size = new Size(150, 32) };
        var btnSuma = new Button { Text = "Mostrar suma", Location = new Point(180, 14), Size = new Size(150, 32) };
        var btnOcultar = new Button { Text = "Ocultar todo", Location = new Point(340, 14), Size = new Size(150, 32) };

        // Panel 1: imagen
        pnlImagen = new Panel
        {
            Location = new Point(20, 60),
            Size = new Size(480, 280),
            BorderStyle = BorderStyle.FixedSingle,
            Visible = false
        };
        var pic = new PictureBox
        {
            Dock = DockStyle.Fill,
            SizeMode = PictureBoxSizeMode.StretchImage,
            Image = CrearImagen(476, 276)
        };
        pnlImagen.Controls.Add(pic);

        // Panel 2: suma de dos números
        pnlSuma = new Panel
        {
            Location = new Point(20, 60),
            Size = new Size(480, 280),
            BorderStyle = BorderStyle.FixedSingle,
            Visible = false
        };
        var lblA = new Label { Text = "Número 1:", Location = new Point(40, 40), AutoSize = true };
        txtA = new TextBox { Location = new Point(130, 36), Width = 120 };
        var lblB = new Label { Text = "Número 2:", Location = new Point(40, 85), AutoSize = true };
        txtB = new TextBox { Location = new Point(130, 81), Width = 120 };
        var btnSumar = new Button { Text = "Sumar", Location = new Point(130, 130), Size = new Size(120, 32) };
        lblResultado = new Label
        {
            Text = "Resultado: ",
            Location = new Point(40, 190),
            AutoSize = true,
            Font = new Font("Segoe UI", 12, FontStyle.Bold)
        };
        pnlSuma.Controls.AddRange(new Control[] { lblA, txtA, lblB, txtB, btnSumar, lblResultado });

        Controls.AddRange(new Control[] { btnImagen, btnSuma, btnOcultar, pnlImagen, pnlSuma });

        btnImagen.Click += (s, e) =>
        {
            pnlSuma.Visible = false;
            pnlImagen.Visible = true;
        };
        btnSuma.Click += (s, e) =>
        {
            pnlImagen.Visible = false;
            pnlSuma.Visible = true;
            txtA.Focus();
        };
        btnOcultar.Click += (s, e) =>
        {
            pnlImagen.Visible = false;
            pnlSuma.Visible = false;
        };
        btnSumar.Click += Sumar;
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
