using System.Drawing;

namespace Temas_Semana_9_13;

// Tema 18 - Usuario y contraseña (Sistema Punto de Venta)
// Un solo usuario guardado en variables, contraseña oculta y máximo de 3 intentos
public class FormLoginPymasa : Form
{
    // Variables usuario del alumno cbtis
    private readonly string alumnocbtis = "Alumno1";
    private readonly string contraalumno = "Cbtis224";

    private const int MaxIntentos = 3;
    private int intentos = 0;

    private readonly TextBox TBUSUARIO;
    private readonly TextBox TBCONTRA;
    private readonly Button BINICIARS;

    public FormLoginPymasa()
    {
        Text = "Inicio de sesión";
        StartPosition = FormStartPosition.CenterParent;
        ClientSize = new Size(640, 380);

        // Lado izquierdo: información del sistema
        var panelIzq = new Panel { BackColor = Color.Black, Dock = DockStyle.Left, Width = 300 };
        panelIzq.Controls.Add(new Label
        {
            Text = "Pymasa",
            ForeColor = Color.Red,
            Font = new Font("Segoe UI", 28, FontStyle.Bold | FontStyle.Italic),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(0, 60),
            Size = new Size(300, 60)
        });
        panelIzq.Controls.Add(new Label
        {
            Text = "Sistema Punto de Venta",
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 15),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(0, 150),
            Size = new Size(300, 40)
        });
        panelIzq.Controls.Add(new Label
        {
            Text = "Culiacán, Sinaloa, México",
            ForeColor = Color.White,
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(0, 200),
            Size = new Size(300, 25)
        });

        // Lado derecho: inicio de sesión
        var panelDer = new Panel { BackColor = Color.Yellow, Dock = DockStyle.Fill };
        panelDer.Controls.Add(new Label
        {
            Text = "Inicio de sesión",
            Font = new Font("Segoe UI", 16),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(0, 40),
            Size = new Size(340, 40)
        });
        panelDer.Controls.Add(new Label
        {
            Text = "Nombre de usuario",
            Font = new Font("Segoe UI", 9, FontStyle.Bold),
            Location = new Point(80, 110),
            AutoSize = true
        });
        TBUSUARIO = new TextBox { Location = new Point(80, 133), Width = 180 };
        panelDer.Controls.Add(TBUSUARIO);

        panelDer.Controls.Add(new Label
        {
            Text = "Contraseña",
            Font = new Font("Segoe UI", 9, FontStyle.Bold),
            Location = new Point(80, 175),
            AutoSize = true
        });
        // Contraseña oculta con puntos
        TBCONTRA = new TextBox { Location = new Point(80, 198), Width = 180, UseSystemPasswordChar = true };
        panelDer.Controls.Add(TBCONTRA);

        BINICIARS = new Button
        {
            Text = "Iniciar sesión",
            BackColor = Color.White,
            Location = new Point(80, 260),
            Size = new Size(180, 36)
        };
        BINICIARS.Click += BINICIARS_Click;
        panelDer.Controls.Add(BINICIARS);

        Controls.Add(panelDer);
        Controls.Add(panelIzq);

        AcceptButton = BINICIARS;
        Shown += (s, e) => TBUSUARIO.Focus();
    }

    private void BINICIARS_Click(object sender, EventArgs e)
    {
        string usuario = TBUSUARIO.Text;
        string contra = TBCONTRA.Text;

        if (usuario == alumnocbtis && contra == contraalumno)
        {
            MessageBox.Show("Bienvenido al sistema de venta");
            using (var bienvenida = new FormBienvenida("Sistema Punto de Venta", usuario))
            {
                bienvenida.ShowDialog(this);
            }
            Close();
            return;
        }

        intentos++;
        if (intentos >= MaxIntentos)
        {
            MessageBox.Show("Superaste los " + MaxIntentos + " intentos. El inicio de sesión se bloqueó.",
                "Acceso bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BINICIARS.Enabled = false;
            TBUSUARIO.Enabled = false;
            TBCONTRA.Enabled = false;
        }
        else
        {
            MessageBox.Show("Usuario o contraseña incorrectos. Intento " + intentos + " de " + MaxIntentos + ".");
            TBCONTRA.Clear();
            TBCONTRA.Focus();
        }
    }
}
