using System.Drawing;

namespace Temas_Semana_9_13;

// Tema 13 - MouseEnter en Panel
// Al pasar el mouse por el panel cambia a gris claro y al quitarlo vuelve a blanco
public class FormMouseEnter : Form
{
    public FormMouseEnter()
    {
        Text = "MouseEnter y Panel - Cambiar el color del panel";
        StartPosition = FormStartPosition.CenterParent;
        ClientSize = new Size(720, 360);
        BackColor = Color.FromArgb(235, 240, 250);

        var lblTitulo = new Label
        {
            Text = "Pasa el mouse por cada panel",
            Font = new Font("Segoe UI", 13, FontStyle.Bold),
            Dock = DockStyle.Top,
            Height = 50,
            TextAlign = ContentAlignment.MiddleCenter
        };
        Controls.Add(lblTitulo);

        string[] textos = { "LISTA DE MAESTROS", "LISTA DE ALUMNOS", "CALIFICACIONES" };
        string[] letras = { "M", "A", "C" };
        Color[] colores = { Color.SteelBlue, Color.SeaGreen, Color.DarkOrange };

        for (int i = 0; i < textos.Length; i++)
        {
            var panel = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(30 + i * 225, 80),
                Size = new Size(200, 240)
            };
            var imagen = new PictureBox
            {
                Image = Imagenes.Icono(letras[i], colores[i], 140),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(30, 20),
                Size = new Size(140, 140)
            };
            var etiqueta = new Label
            {
                Text = textos[i],
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(0, 180),
                Size = new Size(198, 40)
            };
            panel.Controls.Add(imagen);
            panel.Controls.Add(etiqueta);

            panel.MouseEnter += Panel_MouseEnter;
            panel.MouseLeave += Panel_MouseLeave;
            Controls.Add(panel);
        }
    }

    private void Panel_MouseEnter(object sender, EventArgs e)
    {
        ((Panel)sender).BackColor = Color.LightGray;
    }

    private void Panel_MouseLeave(object sender, EventArgs e)
    {
        var panel = (Panel)sender;

        // Si el mouse sigue dentro del panel (por ejemplo sobre la imagen), no se cambia el color
        if (panel.ClientRectangle.Contains(panel.PointToClient(Cursor.Position)))
        {
            return;
        }

        panel.BackColor = Color.White;
    }
}
