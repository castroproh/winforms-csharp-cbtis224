namespace SEC2_IG1;

// Pantalla de inicio: Timer de 3 segundos, Label
public partial class FormInicio : Form
{
    public FormInicio()
    {
        InitializeComponent();
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        timer.Stop();
        Close();
    }

    private void FormInicio_Shown(object sender, EventArgs e)
    {
        timer.Start();
    }
}
