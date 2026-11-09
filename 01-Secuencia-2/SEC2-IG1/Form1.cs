using System.Drawing;

namespace SEC2_IG1;

// Menú principal: MenuStrip + un botón por cada tema
public class Form1 : Form
{
    private readonly ToolTip toolTip = new ToolTip();

    public Form1()
    {
        Text = "SEC2-IG1 - Menú principal";
        ClientSize = new Size(460, 440);
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;

        var opciones = new (string Texto, string Ayuda, Func<Form> Crear)[]
        {
            ("Paneles", "Mostrar y ocultar paneles (Visible, PictureBox)", () => new FormPaneles()),
            ("Rectángulo", "Área y perímetro con TextBox, try/catch y MessageBox", () => new FormRectangulo()),
            ("Calculadora", "Convert.ToDouble, MouseHover y MouseLeave", () => new FormCalculadora()),
            ("Fechas y enlaces", "DateTimePicker, ToolTip y LinkLabel", () => new FormFechas()),
            ("Controles de selección", "ComboBox, RadioButton, GroupBox, CheckBox, NumericUpDown, ListBox", () => new FormControles()),
            ("Herramientas vistas", "ListView con grupos y Timer", () => new FormHerramientas()),
        };

        var menu = new MenuStrip();
        var mnuTemas = new ToolStripMenuItem("Temas");
        var mnuSalir = new ToolStripMenuItem("Salir");
        mnuSalir.Click += (s, e) => Close();

        int y = 50;
        foreach (var opcion in opciones)
        {
            var crear = opcion.Crear;

            void Abrir(object sender, EventArgs e)
            {
                using (var f = crear())
                {
                    f.ShowDialog(this);
                }
            }

            var item = new ToolStripMenuItem(opcion.Texto);
            item.Click += Abrir;
            mnuTemas.DropDownItems.Add(item);

            var btn = new Button
            {
                Text = opcion.Texto,
                Location = new Point(80, y),
                Size = new Size(300, 42),
                Font = new Font("Segoe UI", 10)
            };
            btn.Click += Abrir;
            toolTip.SetToolTip(btn, opcion.Ayuda);
            Controls.Add(btn);

            y += 52;
        }

        menu.Items.Add(mnuTemas);
        menu.Items.Add(mnuSalir);
        MainMenuStrip = menu;
        Controls.Add(menu);

        var lblFecha = new Label
        {
            Text = "Hoy es " + DateTime.Now.ToString("dddd d 'de' MMMM 'de' yyyy"),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Bottom,
            Height = 36
        };
        Controls.Add(lblFecha);
    }
}
