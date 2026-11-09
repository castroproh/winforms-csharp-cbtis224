using System.Drawing;

namespace SEC2_IG1;

// Mini calculadora: Convert.ToDouble, MouseHover y MouseLeave en botones
public partial class FormCalculadora : Form
{
    // Mismos colores que usan los botones en el Diseñador (BackColor inicial = ColorNormal)
    private static readonly Color ColorNormal = Color.FromArgb(225, 225, 225);
    private static readonly Color ColorEncima = Color.FromArgb(125, 211, 252);

    public FormCalculadora()
    {
        InitializeComponent();
    }

    private void FormCalculadora_Shown(object sender, EventArgs e)
    {
        txtNum1.Focus();
    }

    // Los cuatro botones de operación comparten estos dos eventos
    private void Boton_MouseHover(object sender, EventArgs e)
    {
        ((Button)sender).BackColor = ColorEncima;
    }

    private void Boton_MouseLeave(object sender, EventArgs e)
    {
        ((Button)sender).BackColor = ColorNormal;
    }

    private void Operar(object sender, EventArgs e)
    {
        string op = (string)((Button)sender).Tag;
        try
        {
            double a = Convert.ToDouble(txtNum1.Text);
            double b = Convert.ToDouble(txtNum2.Text);
            double r = 0;

            switch (op)
            {
                case "+": r = a + b; break;
                case "-": r = a - b; break;
                case "*": r = a * b; break;
                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNum2.Focus();
                        txtNum2.SelectAll();
                        return;
                    }
                    r = a / b;
                    break;
            }

            lblResultado.Text = "Resultado: " + r;
        }
        catch (FormatException)
        {
            MessageBox.Show("Escribe solo números en los dos cuadros.", "Dato no válido",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNum1.Focus();
            txtNum1.SelectAll();
        }
    }
}
