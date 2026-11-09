using System.Drawing;

namespace Temas_Semana_9_13;

// Tema 5 - TabControl y Panel
// Cuatro fichas: PANEL (con scroll y varias imágenes), BOTONES, LABEL y TEXTBOX
public class FormTabControlPanel : Form
{
    public FormTabControlPanel()
    {
        Text = "Programa con TabControl y Panel";
        StartPosition = FormStartPosition.CenterParent;
        ClientSize = new Size(620, 500);
        BackColor = Color.AliceBlue;

        var lblTitulo = new Label
        {
            Text = "PROGRAMA CON TABCONTROL Y PANEL",
            Font = new Font("Georgia", 14, FontStyle.Bold),
            ForeColor = Color.White,
            BackColor = Color.SteelBlue,
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(70, 15),
            Size = new Size(480, 36)
        };

        var tab = new TabControl
        {
            Location = new Point(20, 65),
            Size = new Size(580, 360),
            Font = new Font("Georgia", 10, FontStyle.Bold)
        };
        var tabPanel = new TabPage("PANEL");
        var tabBotones = new TabPage("BOTONES");
        var tabLabel = new TabPage("LABEL");
        var tabTextBox = new TabPage("TEXTBOX");
        tab.TabPages.Add(tabPanel);
        tab.TabPages.Add(tabBotones);
        tab.TabPages.Add(tabLabel);
        tab.TabPages.Add(tabTextBox);

        // Ficha 1: Panel con AutoScroll y varias PictureBox
        var panel = new Panel
        {
            Dock = DockStyle.Fill,
            AutoScroll = true,
            BackColor = Color.MistyRose
        };
        Color[] colores = { Color.Firebrick, Color.SteelBlue, Color.SeaGreen, Color.DarkOrange, Color.MediumPurple, Color.Teal };
        for (int i = 0; i < colores.Length; i++)
        {
            panel.Controls.Add(new PictureBox
            {
                Image = Imagenes.Icono((i + 1).ToString(), colores[i], 120),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(10, 10 + i * 130),
                Size = new Size(120, 120)
            });
            panel.Controls.Add(new PictureBox
            {
                Image = Imagenes.Icono("Panel", colores[colores.Length - 1 - i], 250),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(150, 10 + i * 130),
                Size = new Size(250, 120)
            });
        }
        tabPanel.Controls.Add(panel);

        // Ficha 2: botones
        tabBotones.BackColor = Color.Thistle;
        Button CrearBoton(string texto, int x, int y)
        {
            return new Button
            {
                Text = texto,
                Location = new Point(x, y),
                Size = new Size(110, 80),
                BackColor = Color.MediumPurple,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
        }
        tabBotones.Controls.Add(CrearBoton("button2", 40, 30));
        tabBotones.Controls.Add(CrearBoton("button3", 400, 30));
        tabBotones.Controls.Add(CrearBoton("button4", 220, 150));

        // Ficha 3: etiquetas
        tabLabel.BackColor = Color.LightYellow;
        void AgregarEtiqueta(string texto, int x, int y)
        {
            tabLabel.Controls.Add(new Label { Text = texto, Location = new Point(x, y), AutoSize = true });
        }
        AgregarEtiqueta("Alumno 1", 50, 40);
        AgregarEtiqueta("Alumno 2", 420, 40);
        AgregarEtiqueta("Alumno 3", 235, 140);
        AgregarEtiqueta("Alumno 4", 50, 240);
        AgregarEtiqueta("Alumno 5", 420, 240);

        // Ficha 4: cuadros de texto
        tabTextBox.BackColor = Color.Honeydew;
        for (int i = 1; i <= 3; i++)
        {
            int y = 20 + (i - 1) * 90;
            tabTextBox.Controls.Add(new Label { Text = "textbox" + i, Location = new Point(220, y), AutoSize = true });
            tabTextBox.Controls.Add(new TextBox { Location = new Point(170, y + 30), Width = 220 });
        }

        var btnSalir = new Button
        {
            Text = "SALIR",
            Font = new Font("Georgia", 10, FontStyle.Bold),
            ForeColor = Color.White,
            BackColor = Color.SteelBlue,
            FlatStyle = FlatStyle.Flat,
            Location = new Point(240, 440),
            Size = new Size(140, 38)
        };
        btnSalir.Click += (s, e) => Close();

        Controls.Add(lblTitulo);
        Controls.Add(tab);
        Controls.Add(btnSalir);
    }
}
