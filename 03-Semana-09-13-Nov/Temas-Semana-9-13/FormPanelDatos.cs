using System.Drawing;

namespace Temas_Semana_9_13;

// Tema 5a - Panel: PANEL-DATOS
// Panel2 con los datos del usuario y Panel1 con cuatro botones (Ocultar, Mostrar, Limpiar, Salir)
public class FormPanelDatos : Form
{
    public FormPanelDatos()
    {
        // La maestra pide ponerle tu nombre al form y centrarlo al ejecutar
        Text = "PANEL-DATOS - Escribe aquí tu nombre";
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(640, 420);
        BackColor = Color.FromArgb(255, 255, 128);

        var lblTitulo = new Label
        {
            Text = "INGRESA LOS SIGUIENTES DATOS",
            Font = new Font("Georgia", 16, FontStyle.Bold | FontStyle.Italic),
            ForeColor = Color.Navy,
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Top,
            Height = 70
        };

        // Panel 2: datos del usuario (borde sencillo)
        var panel2 = new Panel
        {
            BackColor = Color.FromArgb(192, 192, 255),
            BorderStyle = BorderStyle.FixedSingle,
            Location = new Point(60, 90),
            Size = new Size(210, 280)
        };
        var lblNombre = new Label
        {
            Text = "NOMBRE:",
            Font = new Font("Georgia", 12),
            Location = new Point(25, 35),
            AutoSize = true
        };
        var textBox1 = new TextBox { Location = new Point(25, 70), Width = 160, Font = new Font("Georgia", 11) };
        var lblCorreo = new Label
        {
            Text = "CORREO:",
            Font = new Font("Georgia", 12),
            Location = new Point(25, 140),
            AutoSize = true
        };
        var textBox2 = new TextBox { Location = new Point(25, 175), Width = 160, Font = new Font("Georgia", 11) };
        panel2.Controls.AddRange(new Control[] { lblNombre, textBox1, lblCorreo, textBox2 });

        // Panel 1: botones (borde 3D)
        var panel1 = new Panel
        {
            BackColor = Color.FromArgb(192, 255, 192),
            BorderStyle = BorderStyle.Fixed3D,
            Location = new Point(360, 90),
            Size = new Size(210, 280)
        };

        Button CrearBoton(string texto, int y, Color fondo, Color letra)
        {
            return new Button
            {
                Text = texto,
                Location = new Point(35, y),
                Size = new Size(135, 42),
                BackColor = fondo,
                ForeColor = letra,
                Font = new Font("Georgia", 9, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
        }

        var rosa = Color.FromArgb(255, 192, 192);
        var button1 = CrearBoton("OCULTAR DATOS", 25, rosa, Color.Black);
        var button2 = CrearBoton("MOSTRAR DATOS", 85, rosa, Color.Black);
        var button3 = CrearBoton("LIMPIAR", 145, rosa, Color.Black);
        var button4 = CrearBoton("SALIR", 205, Color.Red, Color.White);
        panel1.Controls.AddRange(new Control[] { button1, button2, button3, button4 });

        Controls.Add(panel1);
        Controls.Add(panel2);
        Controls.Add(lblTitulo);

        button1.Click += (s, e) => panel2.Visible = false;
        button2.Click += (s, e) => panel2.Visible = true;
        button3.Click += (s, e) =>
        {
            textBox1.Clear();
            textBox2.Clear();
        };
        button4.Click += (s, e) => Close();
    }
}
