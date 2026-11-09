namespace Temas_Semana_9_13;

// Tema 19 - Usuario y contraseña con varios usuarios válidos
// Botones INGRESAR y VOLVER, contraseña oculta y máximo de 3 intentos
public partial class FormLoginAloha : Form
{
    private readonly Dictionary<string, string> usuariosValidos = new Dictionary<string, string>
    {
        { "Aloha1", "1234" },
        { "Administrador", "admin" },
        { "Empleado", "0000" }
    };

    private const int MaxIntentos = 3;
    private int intentos = 0;

    public FormLoginAloha()
    {
        InitializeComponent();

        // La imagen del usuario se dibuja en código (Imagenes.cs)
        imagen.Image = Imagenes.IconoUsuario(110, Color.FromArgb(0, 64, 64), Color.Black);
    }

    private void FormLoginAloha_Shown(object sender, EventArgs e)
    {
        textBox1.Focus();
    }

    private void btnVolver_Click(object sender, EventArgs e)
    {
        Close();
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
