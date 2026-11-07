using System.Drawing;

namespace Temas_Semana_9_13;

// Formulario que se abre cuando el usuario y la contraseña son correctos
public class FormBienvenida : Form
{
    public FormBienvenida(string sistema, string usuario)
    {
        Text = sistema;
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(520, 280);
        BackColor = Color.Black;

        var lblTitulo = new Label
        {
            Text = sistema.ToUpper(),
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 18, FontStyle.Bold),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Top,
            Height = 90
        };

        var lblUsuario = new Label
        {
            Text = "Acceso concedido.\nBienvenido, " + usuario + ".",
            ForeColor = Color.Yellow,
            Font = new Font("Segoe UI", 13),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Top,
            Height = 90
        };

        var btnCerrar = new Button
        {
            Text = "Cerrar sesión",
            BackColor = Color.Yellow,
            Location = new Point(180, 210),
            Size = new Size(160, 40)
        };
        btnCerrar.Click += (s, e) => Close();

        Controls.Add(btnCerrar);
        Controls.Add(lblUsuario);
        Controls.Add(lblTitulo);
    }
}
