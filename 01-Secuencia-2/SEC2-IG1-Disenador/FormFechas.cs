using System.Diagnostics;
using System.Drawing;

namespace SEC2_IG1;

// DateTimePicker, ToolTip, LinkLabel
public partial class FormFechas : Form
{
    public FormFechas()
    {
        InitializeComponent();

        // La fecha máxima depende del día en que se abre el formulario
        dtpNacimiento.MaxDate = DateTime.Today;
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        DateTime hoy = DateTime.Today;
        DateTime nac = dtpNacimiento.Value.Date;

        int edad = hoy.Year - nac.Year;
        if (nac > hoy.AddYears(-edad))
        {
            edad--;
        }
        int dias = (hoy - nac).Days;

        lblResultado.Text = "Tienes " + edad + " años.\nHas vivido " + dias.ToString("N0") + " días.";
    }

    private void lnkAyuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        lnkAyuda.LinkVisited = true;
        Process.Start(new ProcessStartInfo("https://learn.microsoft.com/dotnet/desktop/winforms/")
        {
            UseShellExecute = true
        });
    }
}
