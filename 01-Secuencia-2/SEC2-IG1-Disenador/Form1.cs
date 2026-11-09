namespace SEC2_IG1;

// Menú principal: MenuStrip + un botón por cada tema
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        // La fecha de hoy se calcula al abrir el formulario
        lblFecha.Text = "Hoy es " + DateTime.Now.ToString("dddd d 'de' MMMM 'de' yyyy");
    }

    // Abre el formulario como ventana modal y lo libera al cerrarse
    private void AbrirFormulario(Form formulario)
    {
        using (formulario)
        {
            formulario.ShowDialog(this);
        }
    }

    // Cada opción la comparten el botón y el elemento del menú Temas
    private void AbrirPaneles(object sender, EventArgs e)
    {
        AbrirFormulario(new FormPaneles());
    }

    private void AbrirRectangulo(object sender, EventArgs e)
    {
        AbrirFormulario(new FormRectangulo());
    }

    private void AbrirCalculadora(object sender, EventArgs e)
    {
        AbrirFormulario(new FormCalculadora());
    }

    private void AbrirFechas(object sender, EventArgs e)
    {
        AbrirFormulario(new FormFechas());
    }

    private void AbrirControles(object sender, EventArgs e)
    {
        AbrirFormulario(new FormControles());
    }

    private void AbrirHerramientas(object sender, EventArgs e)
    {
        AbrirFormulario(new FormHerramientas());
    }

    private void mnuSalir_Click(object sender, EventArgs e)
    {
        Close();
    }
}
