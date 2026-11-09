using System.Diagnostics;
using System.Drawing;

namespace SEC2_IG1;

// DateTimePicker, ToolTip, LinkLabel
public class FormFechas : Form
{
    private readonly DateTimePicker dtpNacimiento;
    private readonly Label lblResultado;
    private readonly ToolTip toolTip = new ToolTip();

    public FormFechas()
    {
        Text = "Fechas y enlaces";
        ClientSize = new Size(460, 300);
        StartPosition = FormStartPosition.CenterParent;

        var lblIndicacion = new Label
        {
            Text = "Elige tu fecha de nacimiento:",
            Location = new Point(30, 25),
            AutoSize = true
        };

        dtpNacimiento = new DateTimePicker
        {
            Location = new Point(30, 55),
            Width = 220,
            Format = DateTimePickerFormat.Long,
            MaxDate = DateTime.Today,
            Value = new DateTime(2008, 1, 1)
        };

        var btnCalcular = new Button { Text = "Calcular edad", Location = new Point(270, 52), Size = new Size(140, 30) };

        lblResultado = new Label
        {
            Text = "",
            Location = new Point(30, 110),
            Size = new Size(400, 80),
            Font = new Font("Segoe UI", 11, FontStyle.Bold)
        };

        var lnkAyuda = new LinkLabel
        {
            Text = "Documentación de Windows Forms",
            Location = new Point(30, 220),
            AutoSize = true
        };
        lnkAyuda.LinkClicked += (s, e) =>
        {
            lnkAyuda.LinkVisited = true;
            Process.Start(new ProcessStartInfo("https://learn.microsoft.com/dotnet/desktop/winforms/")
            {
                UseShellExecute = true
            });
        };

        Controls.AddRange(new Control[] { lblIndicacion, dtpNacimiento, btnCalcular, lblResultado, lnkAyuda });

        toolTip.SetToolTip(dtpNacimiento, "Haz clic para elegir la fecha");
        toolTip.SetToolTip(btnCalcular, "Calcula tu edad y los días vividos");
        toolTip.SetToolTip(lnkAyuda, "Abre la página en tu navegador");

        btnCalcular.Click += (s, e) =>
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
        };
    }
}
