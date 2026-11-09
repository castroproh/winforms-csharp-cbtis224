using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TemasSemana1620
{
    /// <summary>Tema 15: MonthCalendar, elegir una fecha o un rango y mostrarlo en un Label.</summary>
    public partial class FormMonthCalendar : Form
    {
        private static readonly CultureInfo Cultura = new CultureInfo("es-MX");

        public FormMonthCalendar()
        {
            InitializeComponent();

            ActualizarTexto(_calendario.SelectionStart, _calendario.SelectionEnd);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            ActualizarTexto(e.Start, e.End);
        }

        private void BtnHoy_Click(object sender, EventArgs e)
        {
            try
            {
                _calendario.SetDate(DateTime.Today);
                ActualizarTexto(_calendario.SelectionStart, _calendario.SelectionEnd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No se pudo seleccionar la fecha:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSemana_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime hoy = DateTime.Today;
                int desfase = ((int)hoy.DayOfWeek + 6) % 7; // lunes = 0
                DateTime lunes = hoy.AddDays(-desfase);
                _calendario.SetSelectionRange(lunes, lunes.AddDays(6));
                ActualizarTexto(_calendario.SelectionStart, _calendario.SelectionEnd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No se pudo seleccionar el rango:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChkSemanas_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            _calendario.ShowWeekNumbers = chk.Checked;
        }

        private void ActualizarTexto(DateTime inicio, DateTime fin)
        {
            const string formato = "dddd d 'de' MMMM 'de' yyyy";
            if (inicio.Date == fin.Date)
            {
                _lblResultado.Text = "Fecha elegida:\n" + inicio.ToString(formato, Cultura);
            }
            else
            {
                int dias = (fin.Date - inicio.Date).Days + 1;
                _lblResultado.Text = "Rango elegido:\nDel " + inicio.ToString(formato, Cultura) +
                    "\nal " + fin.ToString(formato, Cultura) +
                    "\nTotal: " + dias + " día(s)";
            }
        }
    }
}
