namespace Temas_Semana_9_13;

// Tema 10 - Control GroupBox
// Los RadioButton dentro del GroupBox son independientes de los que están fuera de él
public partial class FormGroupBox : Form
{
    public FormGroupBox()
    {
        InitializeComponent();
    }

    private void Seleccion(object sender, EventArgs e)
    {
        var rb = (RadioButton)sender;
        if (!rb.Checked)
        {
            return;
        }

        if (rb.Parent == grupo)
        {
            lblDentro.Text = "Dentro del GroupBox: " + rb.Text;
        }
        else
        {
            lblFuera.Text = "Fuera del GroupBox: " + rb.Text;
        }
    }
}
