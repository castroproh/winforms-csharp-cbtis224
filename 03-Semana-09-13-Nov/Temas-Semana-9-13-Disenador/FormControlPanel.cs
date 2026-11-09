namespace Temas_Semana_9_13;

// Tema 6 - Control Panel: cuatro CheckBox dentro de un Panel y un Button fuera de él.
// El botón recorre los controles del panel con foreach para saber si hay alguno seleccionado.
public partial class FormControlPanel : Form
{
    public FormControlPanel()
    {
        InitializeComponent();
    }

    private void BuscarSeleccionados(object sender, EventArgs e)
    {
        bool algunCheckBoxSeleccionado = false;

        foreach (Control control in panel1.Controls)
        {
            if (control is CheckBox checkBox && checkBox.Checked)
            {
                algunCheckBoxSeleccionado = true;
                break;
            }
        }

        if (algunCheckBoxSeleccionado)
        {
            MessageBox.Show("Al menos un CheckBox está seleccionado.");
        }
        else
        {
            MessageBox.Show("Ningún CheckBox está seleccionado.");
        }
    }
}
