namespace Temas_Semana_9_13;

// Formulario que se abre cuando el usuario y la contraseña son correctos
public partial class FormBienvenida : Form
{
    public FormBienvenida(string sistema, string usuario)
    {
        InitializeComponent();

        // Textos que dependen del sistema y del usuario que inició sesión
        Text = sistema;
        lblTitulo.Text = sistema.ToUpper();
        lblUsuario.Text = "Acceso concedido.\nBienvenido, " + usuario + ".";
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
        Close();
    }
}
