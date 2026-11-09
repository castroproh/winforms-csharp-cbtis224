namespace Temas_Semana_9_13;

// Tema 5a - Panel: PANEL-DATOS
// Panel2 con los datos del usuario y Panel1 con cuatro botones (Ocultar, Mostrar, Limpiar, Salir)
public partial class FormPanelDatos : Form
{
    public FormPanelDatos()
    {
        // La maestra pide ponerle tu nombre al form (propiedad Text) y centrarlo al ejecutar (StartPosition)
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        panel2.Visible = false;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        panel2.Visible = true;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        textBox1.Clear();
        textBox2.Clear();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        Close();
    }
}
