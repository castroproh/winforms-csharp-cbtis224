using System.Drawing;

namespace SEC2_IG1;

// Mini calculadora: Convert.ToDouble, MouseHover y MouseLeave en botones
public class FormCalculadora : Form
{
    private readonly TextBox txtNum1;
    private readonly TextBox txtNum2;
    private readonly Label lblResultado;

    private static readonly Color ColorNormal = Color.FromArgb(225, 225, 225);
    private static readonly Color ColorEncima = Color.FromArgb(125, 211, 252);

    public FormCalculadora()
    {
        Text = "Calculadora";
        ClientSize = new Size(380, 280);
        StartPosition = FormStartPosition.CenterParent;

        var lbl1 = new Label { Text = "Número 1:", Location = new Point(30, 25), AutoSize = true };
        txtNum1 = new TextBox { Location = new Point(120, 21), Width = 200 };
        var lbl2 = new Label { Text = "Número 2:", Location = new Point(30, 65), AutoSize = true };
        txtNum2 = new TextBox { Location = new Point(120, 61), Width = 200 };

        Controls.AddRange(new Control[] { lbl1, txtNum1, lbl2, txtNum2 });

        string[] operaciones = { "+", "-", "*", "/" };
        int x = 30;
        foreach (string op in operaciones)
        {
            var btn = new Button
            {
                Text = op,
                Tag = op,
                Location = new Point(x, 110),
                Size = new Size(70, 50),
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                BackColor = ColorNormal
            };
            btn.Click += Operar;
            btn.MouseHover += (s, e) => ((Button)s).BackColor = ColorEncima;
            btn.MouseLeave += (s, e) => ((Button)s).BackColor = ColorNormal;
            Controls.Add(btn);
            x += 80;
        }

        lblResultado = new Label
        {
            Text = "Resultado: ",
            Location = new Point(30, 190),
            AutoSize = true,
            Font = new Font("Segoe UI", 14, FontStyle.Bold)
        };
        Controls.Add(lblResultado);

        Shown += (s, e) => txtNum1.Focus();
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
