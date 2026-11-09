namespace Temas_Semana_9_13;

// Tema 8 - RoundButton: se compara un botón normal con el botón redondo
public partial class FormRoundButton : Form
{
    public FormRoundButton()
    {
        InitializeComponent();
    }

    private void btnNormal_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Este es el botón normal (rectangular).");
    }

    private void roundButton1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Seleccionaste el RoundButton.");
    }

    private void roundButton2_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Un RoundButton con el mismo ancho y alto es un círculo.");
    }
}
