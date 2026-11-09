using System.Drawing;

namespace SEC2_IG1;

// ListView con grupos, Timer (reloj), ToolTip
public partial class FormHerramientas : Form
{
    public FormHerramientas()
    {
        InitializeComponent();

        ActualizarReloj();
    }

    private void lista_DoubleClick(object sender, EventArgs e)
    {
        if (lista.SelectedItems.Count > 0)
        {
            var item = lista.SelectedItems[0];
            MessageBox.Show(item.SubItems[1].Text + "\n\nEjemplo en: " + item.SubItems[2].Text,
                item.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void relojTimer_Tick(object sender, EventArgs e)
    {
        ActualizarReloj();
    }

    private void ActualizarReloj()
    {
        lblReloj.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss");
    }
}
