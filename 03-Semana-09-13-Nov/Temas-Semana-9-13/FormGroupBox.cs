using System.Drawing;

namespace Temas_Semana_9_13;

// Tema 10 - Control GroupBox
// Los RadioButton dentro del GroupBox son independientes de los que están fuera de él
public class FormGroupBox : Form
{
    private readonly GroupBox grupo;
    private readonly Label lblDentro;
    private readonly Label lblFuera;

    public FormGroupBox()
    {
        Text = "GroupBox";
        StartPosition = FormStartPosition.CenterParent;
        ClientSize = new Size(600, 320);

        string[] estados = { "Chihuahua", "Sinaloa", "Puebla", "Querétaro" };

        // GroupBox con título "Estado:" y color de fondo propio
        grupo = new GroupBox
        {
            Text = "Estado:",
            BackColor = Color.Tomato,
            ForeColor = Color.White,
            Location = new Point(30, 30),
            Size = new Size(220, 170)
        };
        for (int i = 0; i < estados.Length; i++)
        {
            var rb = new RadioButton
            {
                Text = estados[i],
                Location = new Point(20, 30 + i * 32),
                AutoSize = true
            };
            rb.CheckedChanged += Seleccion;
            grupo.Controls.Add(rb);
        }

        // RadioButton sueltos en el formulario (otro grupo distinto)
        for (int i = 0; i < estados.Length; i++)
        {
            var rb = new RadioButton
            {
                Text = estados[i],
                Location = new Point(320, 55 + i * 32),
                AutoSize = true
            };
            rb.CheckedChanged += Seleccion;
            Controls.Add(rb);
        }

        var lblFueraTitulo = new Label { Text = "Fuera del GroupBox:", Location = new Point(320, 30), AutoSize = true };

        lblDentro = new Label
        {
            Text = "Dentro del GroupBox: (ninguno)",
            Location = new Point(30, 230),
            AutoSize = true,
            Font = new Font("Segoe UI", 10, FontStyle.Bold)
        };
        lblFuera = new Label
        {
            Text = "Fuera del GroupBox: (ninguno)",
            Location = new Point(30, 260),
            AutoSize = true,
            Font = new Font("Segoe UI", 10, FontStyle.Bold)
        };

        Controls.AddRange(new Control[] { grupo, lblFueraTitulo, lblDentro, lblFuera });
    }

    private void Seleccion(object sender, EventArgs e)
    {
        var rb = (RadioButton)sender;
        if (!rb.Checked)
        {
            return;
        }

        if (rb.Parent == grupo)
        {
            lblDentro.Text = "Dentro del GroupBox: " + rb.Text;
        }
        else
        {
            lblFuera.Text = "Fuera del GroupBox: " + rb.Text;
        }
    }
}
