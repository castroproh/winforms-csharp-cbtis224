using System.Drawing;

namespace SEC2_IG1;

// Pantalla de inicio: Timer de 3 segundos, Label
public class FormInicio : Form
{
    private readonly System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

    public FormInicio()
    {
        FormBorderStyle = FormBorderStyle.None;
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(480, 240);
        BackColor = Color.FromArgb(30, 41, 59);

        var lblTitulo = new Label
        {
            Text = "SEC2-IG1",
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 32, FontStyle.Bold),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Top,
            Height = 130
        };

        var lblSub = new Label
        {
            Text = "Windows Forms C# - Secuencia 1 y Secuencia 2",
            ForeColor = Color.FromArgb(203, 213, 225),
            Font = new Font("Segoe UI", 11),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Top,
            Height = 40
        };

        var lblCargando = new Label
        {
            Text = "Cargando...",
            ForeColor = Color.FromArgb(148, 163, 184),
            Font = new Font("Segoe UI", 10, FontStyle.Italic),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Bottom,
            Height = 40
        };

        Controls.Add(lblSub);
        Controls.Add(lblTitulo);
        Controls.Add(lblCargando);

        timer.Interval = 3000; // 3 segundos
        timer.Tick += (s, e) =>
        {
            timer.Stop();
            Close();
        };
        Shown += (s, e) => timer.Start();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            timer.Dispose();
        }
        base.Dispose(disposing);
    }
}
