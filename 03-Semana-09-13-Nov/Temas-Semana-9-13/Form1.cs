using System.Drawing;

namespace Temas_Semana_9_13;

// Menú principal: un botón por cada tema de la semana
public class Form1 : Form
{
    public Form1()
    {
        Text = "Temas de la semana 9 - 13 de noviembre";
        ClientSize = new Size(480, 640);
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;

        var opciones = new (string Texto, Func<Form> Crear)[]
        {
            ("5a - Panel (Panel-Datos)", () => new FormPanelDatos()),
            ("5 - TabControl y Panel", () => new FormTabControlPanel()),
            ("6 - Control Panel (CheckBox en un Panel)", () => new FormControlPanel()),
            ("7 - TableLayoutPanel", () => new FormTableLayout()),
            ("8 - RoundButton", () => new FormRoundButton()),
            ("10 - Control GroupBox", () => new FormGroupBox()),
            ("13 - MouseEnter en Panel", () => new FormMouseEnter()),
            ("18 - Usuario y contraseña (Punto de venta)", () => new FormLoginPymasa()),
            ("19 - Usuario y contraseña (varios usuarios)", () => new FormLoginAloha()),
        };

        var titulo = new Label
        {
            Text = "Temas de la semana",
            Dock = DockStyle.Top,
            Height = 50,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 16, FontStyle.Bold)
        };

        int y = 70;
        foreach (var opcion in opciones)
        {
            var crear = opcion.Crear;
            var btn = new Button
            {
                Text = opcion.Texto,
                Location = new Point(60, y),
                Size = new Size(360, 42),
                Font = new Font("Segoe UI", 10)
            };
            btn.Click += (s, e) =>
            {
                using (var f = crear())
                {
                    f.ShowDialog(this);
                }
            };
            Controls.Add(btn);
            y += 52;
        }

        var btnSalir = new Button
        {
            Text = "Salir",
            Location = new Point(60, y + 5),
            Size = new Size(360, 36),
            BackColor = Color.Firebrick,
            ForeColor = Color.White
        };
        btnSalir.Click += (s, e) => Close();
        Controls.Add(btnSalir);
        Controls.Add(titulo);
    }
}
