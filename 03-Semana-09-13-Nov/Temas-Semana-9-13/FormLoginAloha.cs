using System.Drawing;

namespace Temas_Semana_9_13;

// Tema 19 - Usuario y contraseña con varios usuarios válidos
// Botones INGRESAR y VOLVER, contraseña oculta y máximo de 3 intentos
public class FormLoginAloha : Form
{
    private readonly Dictionary<string, string> usuariosValidos = new Dictionary<string, string>
    {
        { "Aloha1", "1234" },
        { "Administrador", "admin" },
        { "Empleado", "0000" }
    };

    private const int MaxIntentos = 3;
    private int intentos = 0;

    private readonly TextBox textBox1;
    private readonly TextBox textBox2;
    private readonly Button btnIngresar;

    public FormLoginAloha()
    {
        Text = "Aloha agencia - Usuario y contraseña";
        StartPosition = FormStartPosition.CenterParent;
        ClientSize = new Size(600, 440);
        BackColor = Color.FromArgb(0, 64, 64);

        var lblTitulo = new Label
        {
            Text = "Bienvenido al sistema de Aloha agencia",
            ForeColor = Color.White,
            Font = new Font("Georgia", 16, FontStyle.Bold | FontStyle.Italic),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Top,
            Height = 60
        };

        var imagen = new PictureBox
        {
            Image = Imagenes.IconoUsuario(110, Color.FromArgb(0, 64, 64), Color.Black),
            SizeMode = PictureBoxSizeMode.CenterImage,
            Location = new Point(245, 70),
            Size = new Size(110, 110)
        };

        var lblUsuario = new Label
        {
            Text = "USUARIO",
            ForeColor = Color.White,
            Font = new Font("Georgia", 9, FontStyle.Bold | FontStyle.Italic),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(200, 205),
            Size = new Size(200, 22)
        };
        textBox1 = new TextBox { Location = new Point(200, 230), Width = 200 };

        var lblClave = new Label
        {
            Text = "CONTRASEÑA",
            ForeColor = Color.White,
            Font = new Font("Georgia", 9, FontStyle.Bold | FontStyle.Italic),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(200, 270),
            Size = new Size(200, 22)
        };
        // Contraseña oculta
        textBox2 = new TextBox { Location = new Point(200, 295), Width = 200, UseSystemPasswordChar = true };

        btnIngresar = new Button
        {
            Text = "INGRESAR",
            BackColor = Color.White,
            Location = new Point(150, 355),
            Size = new Size(130, 34)
        };
        btnIngresar.Click += Ingresar;

        var btnVolver = new Button
        {
            Text = "VOLVER",
            BackColor = Color.White,
            Location = new Point(320, 355),
            Size = new Size(130, 34)
        };
        btnVolver.Click += (s, e) => Close();

        Controls.AddRange(new Control[]
        {
            lblTitulo, imagen, lblUsuario, textBox1, lblClave, textBox2, btnIngresar, btnVolver
        });

        AcceptButton = btnIngresar;
        Shown += (s, e) => textBox1.Focus();
    }

    private void Ingresar(object sender, EventArgs e)
    {
        string usuario = textBox1.Text;
        string clave = textBox2.Text;

        if (usuariosValidos.TryGetValue(usuario, out string claveCorrecta) && clave == claveCorrecta)
        {
            MessageBox.Show("Acceso concedido. Bienvenido al sistema.");
            using (var proyecto = new FormBienvenida("Aloha agencia", usuario))
            {
                proyecto.ShowDialog(this);
            }
            Close();
            return;
        }

        intentos++;
        if (intentos >= MaxIntentos)
        {
            MessageBox.Show("Superaste los " + MaxIntentos + " intentos. El acceso se bloqueó.",
                "Acceso bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnIngresar.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }
        else
        {
            MessageBox.Show("Usuario o contraseña incorrectos. Intento " + intentos + " de " + MaxIntentos + ".");
            textBox2.Clear();
            textBox2.Focus();
        }
    }
}
