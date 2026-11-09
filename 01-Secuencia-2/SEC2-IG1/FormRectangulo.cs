using System.Drawing;

namespace SEC2_IG1;

// Área y perímetro de un rectángulo con lados de 1 a 50
// TextBox, PictureBox, try/catch, MessageBox, DateTime.Now, Focus
public class FormRectangulo : Form
{
    private readonly TextBox txtBase;
    private readonly TextBox txtAltura;
    private readonly Label lblArea;
    private readonly Label lblPerimetro;
    private readonly Label lblFecha;
    private readonly PictureBox picRectangulo;

    public FormRectangulo()
    {
        Text = "Rectángulo";
        ClientSize = new Size(560, 330);
        StartPosition = FormStartPosition.CenterParent;

        var lblBase = new Label { Text = "Base (1 a 50):", Location = new Point(20, 25), AutoSize = true };
        txtBase = new TextBox { Location = new Point(130, 21), Width = 100, MaxLength = 2 };
        var lblAltura = new Label { Text = "Altura (1 a 50):", Location = new Point(20, 65), AutoSize = true };
        txtAltura = new TextBox { Location = new Point(130, 61), Width = 100, MaxLength = 2 };
        var btnCalcular = new Button { Text = "Calcular", Location = new Point(20, 105), Size = new Size(100, 32) };
        var btnLimpiar = new Button { Text = "Limpiar", Location = new Point(130, 105), Size = new Size(100, 32) };

        lblArea = new Label { Text = "Área: ", Location = new Point(20, 165), AutoSize = true, Font = new Font("Segoe UI", 11, FontStyle.Bold) };
        lblPerimetro = new Label { Text = "Perímetro: ", Location = new Point(20, 200), AutoSize = true, Font = new Font("Segoe UI", 11, FontStyle.Bold) };
        lblFecha = new Label { Text = "", Location = new Point(20, 250), AutoSize = true, ForeColor = Color.DimGray };

        picRectangulo = new PictureBox
        {
            Location = new Point(280, 20),
            Size = new Size(260, 290),
            BorderStyle = BorderStyle.FixedSingle,
            SizeMode = PictureBoxSizeMode.CenterImage
        };

        Controls.AddRange(new Control[]
        {
            lblBase, txtBase, lblAltura, txtAltura, btnCalcular, btnLimpiar,
            lblArea, lblPerimetro, lblFecha, picRectangulo
        });

        btnCalcular.Click += Calcular;
        btnLimpiar.Click += Limpiar;
        Shown += (s, e) => txtBase.Focus();
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
