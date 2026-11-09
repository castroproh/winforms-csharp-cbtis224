namespace Temas_Semana_9_13;

// Tema 18 - Usuario y contraseña (Sistema Punto de Venta)
// Un solo usuario guardado en variables, contraseña oculta y máximo de 3 intentos
public partial class FormLoginPymasa : Form
{
    // Variables usuario del alumno cbtis
    private readonly string alumnocbtis = "Alumno1";
    private readonly string contraalumno = "Cbtis224";

    private const int MaxIntentos = 3;
    private int intentos = 0;

    public FormLoginPymasa()
    {
        InitializeComponent();
    }

    private void FormLoginPymasa_Shown(object sender, EventArgs e)
    {
        TBUSUARIO.Focus();
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
