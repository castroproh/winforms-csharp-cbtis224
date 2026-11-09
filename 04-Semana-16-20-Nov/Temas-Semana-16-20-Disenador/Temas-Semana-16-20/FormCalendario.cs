using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TemasSemana1620
{
    /// <summary>Tema 16: DateTimePicker con calendario y cálculo de días entre dos fechas.</summary>
    public partial class FormCalendario : Form
    {
        private static readonly CultureInfo Cultura = new CultureInfo("es-MX");

        public FormCalendario()
        {
            InitializeComponent();

            _dtpFin.Value = DateTime.Today.AddDays(30); // ya existen las etiquetas que usa ValueChanged

            ActualizarDias();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Selector_ValueChanged(object sender, EventArgs e)
        {
            ActualizarDias();
        }

        private void ActualizarDias()
        {
            _lblDiaInicio.Text = _dtpInicio.Value.ToString("dddd", Cultura);
            _lblDiaFin.Text = _dtpFin.Value.ToString("dddd", Cultura);
        }

        private void BtnHoy_Click(object sender, EventArgs e)
        {
            _dtpInicio.Value = DateTime.Today;
            _dtpFin.Value = DateTime.Today;
        }

        private void BtnIntercambiar_Click(object sender, EventArgs e)
        {
            DateTime auxiliar = _dtpInicio.Value;
            _dtpInicio.Value = _dtpFin.Value;
            _dtpFin.Value = auxiliar;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime inicio = _dtpInicio.Value.Date;
                DateTime fin = _dtpFin.Value.Date;

                if (fin < inicio)
                {
                    MessageBox.Show(this, "La fecha final no puede ser anterior a la fecha inicial.",
                        "Fechas no válidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int dias = (fin - inicio).Days;
                int habiles = 0;
                for (DateTime d = inicio; d <= fin; d = d.AddDays(1))
                {
                    if (d.DayOfWeek != DayOfWeek.Saturday && d.DayOfWeek != DayOfWeek.Sunday)
                    {
                        habiles++;
                    }
                }

                _lblResultado.Text =
                    "Entre " + inicio.ToString("dd/MM/yyyy", Cultura) + " y " + fin.ToString("dd/MM/yyyy", Cultura) +
                    " hay " + dias + " día(s).\n\n" +
                    "Contando ambos extremos: " + (dias + 1) + " día(s).\n" +
                    "Equivale a " + (dias / 7) + " semana(s) y " + (dias % 7) + " día(s).\n" +
                    "Días hábiles (lunes a viernes, ambos extremos incluidos): " + habiles + ".";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No se pudo calcular:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
