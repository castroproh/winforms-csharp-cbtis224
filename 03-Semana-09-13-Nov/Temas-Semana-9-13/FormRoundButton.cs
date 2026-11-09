using System.Drawing;

namespace Temas_Semana_9_13;

// Tema 8 - RoundButton: se compara un botón normal con el botón redondo
public class FormRoundButton : Form
{
    public FormRoundButton()
    {
        Text = "ROUNDBUTTON";
        StartPosition = FormStartPosition.CenterParent;
        ClientSize = new Size(560, 380);
        BackColor = Color.FromArgb(0, 120, 215);

        var btnNormal = new Button
        {
            Text = "ROUNDBUTTON",
            BackColor = Color.Red,
            Location = new Point(200, 80),
            Size = new Size(160, 50)
        };

        var roundButton1 = new RoundButton
        {
            Text = "roundButton1",
            BackColor = Color.LightSteelBlue,
            Location = new Point(200, 150),
            Size = new Size(160, 80)
        };

        var roundButton2 = new RoundButton
        {
            Text = "Círculo",
            BackColor = Color.Gold,
            Location = new Point(240, 250),
            Size = new Size(80, 80)
        };

        btnNormal.Click += (s, e) => MessageBox.Show("Este es el botón normal (rectangular).");
        roundButton1.Click += (s, e) => MessageBox.Show("Seleccionaste el RoundButton.");
        roundButton2.Click += (s, e) => MessageBox.Show("Un RoundButton con el mismo ancho y alto es un círculo.");

        Controls.AddRange(new Control[] { btnNormal, roundButton1, roundButton2 });
    }
}
