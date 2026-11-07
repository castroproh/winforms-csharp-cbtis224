using System.Drawing;

namespace Temas_Semana_9_13;

// Tema 6 - Control Panel: cuatro CheckBox dentro de un Panel y un Button fuera de él.
// El botón recorre los controles del panel con foreach para saber si hay alguno seleccionado.
public class FormControlPanel : Form
{
    private readonly Panel panel1;

    public FormControlPanel()
    {
        Text = "Control Panel";
        StartPosition = FormStartPosition.CenterParent;
        ClientSize = new Size(560, 300);

        panel1 = new Panel
        {
            Location = new Point(30, 30),
            Size = new Size(300, 230),
            BorderStyle = BorderStyle.FixedSingle,
            BackColor = Color.WhiteSmoke
        };
        for (int i = 1; i <= 4; i++)
        {
            panel1.Controls.Add(new CheckBox
            {
                Text = "checkBox" + i,
                Location = new Point(50, 25 + (i - 1) * 50),
                AutoSize = true
            });
        }

        var button1 = new Button
        {
            Text = "Buscar",
            Location = new Point(380, 70),
            Size = new Size(130, 130)
        };
        button1.Click += BuscarSeleccionados;

        Controls.Add(panel1);
        Controls.Add(button1);
    }

    private void BuscarSeleccionados(object sender, EventArgs e)
    {
        bool algunCheckBoxSeleccionado = false;

        foreach (Control control in panel1.Controls)
        {
            if (control is CheckBox checkBox && checkBox.Checked)
            {
                algunCheckBoxSeleccionado = true;
                break;
            }
        }

        if (algunCheckBoxSeleccionado)
        {
            MessageBox.Show("Al menos un CheckBox está seleccionado.");
        }
        else
        {
            MessageBox.Show("Ningún CheckBox está seleccionado.");
        }
    }
}
