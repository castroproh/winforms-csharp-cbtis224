namespace Temas_Semana_9_13;

// Tema 7 - TableLayoutPanel
// Actividad 1: tabla de 2 x 2 con cuatro botones
// Actividad 2: tabla de 1 fila y 2 columnas (Saludar / Despedir)
public partial class FormTableLayout : Form
{
    public FormTableLayout()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hiciste clic en el Botón 1");
    }

    private void button2_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hiciste clic en el Botón 2");
    }

    private void button3_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hiciste clic en el Botón 3");
    }

    private void button4_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hiciste clic en el Botón 4");
    }

    private void btnSaludar_Click(object sender, EventArgs e)
    {
        MessageBox.Show("¡Hola!");
    }

    private void btnDespedir_Click(object sender, EventArgs e)
    {
        MessageBox.Show("¡Adiós!");
    }
}
