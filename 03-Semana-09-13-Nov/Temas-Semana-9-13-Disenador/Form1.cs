namespace Temas_Semana_9_13;

// Menú principal: un botón por cada tema de la semana
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    // Abre el formulario de un tema como cuadro de diálogo y lo libera al cerrarlo
    private void AbrirFormulario(Form formulario)
    {
        using (formulario)
        {
            formulario.ShowDialog(this);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        AbrirFormulario(new FormPanelDatos());
    }

    private void button2_Click(object sender, EventArgs e)
    {
        AbrirFormulario(new FormTabControlPanel());
    }

    private void button3_Click(object sender, EventArgs e)
    {
        AbrirFormulario(new FormControlPanel());
    }

    private void button4_Click(object sender, EventArgs e)
    {
        AbrirFormulario(new FormTableLayout());
    }

    private void button5_Click(object sender, EventArgs e)
    {
        AbrirFormulario(new FormRoundButton());
    }

    private void button6_Click(object sender, EventArgs e)
    {
        AbrirFormulario(new FormGroupBox());
    }

    private void button7_Click(object sender, EventArgs e)
    {
        AbrirFormulario(new FormMouseEnter());
    }

    private void button8_Click(object sender, EventArgs e)
    {
        AbrirFormulario(new FormLoginPymasa());
    }

    private void button9_Click(object sender, EventArgs e)
    {
        AbrirFormulario(new FormLoginAloha());
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        Close();
    }
}
