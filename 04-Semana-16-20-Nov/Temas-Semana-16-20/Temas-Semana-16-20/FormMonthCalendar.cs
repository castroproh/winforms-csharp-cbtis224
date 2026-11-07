using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TemasSemana1620
{
    /// <summary>Tema 15: MonthCalendar, elegir una fecha o un rango y mostrarlo en un Label.</summary>
    public class FormMonthCalendar : Form
    {
        private static readonly CultureInfo Cultura = new CultureInfo("es-MX");

        private MonthCalendar _calendario;
        private Label _lblResultado;

        public FormMonthCalendar()
        {
            Panel p = Ayudas.Preparar(this, "Tema 15 - MonthCalendar");

            FlowLayoutPanel flujo = new FlowLayoutPanel();
            flujo.Dock = DockStyle.Fill;
            flujo.FlowDirection = FlowDirection.TopDown;
            flujo.WrapContents = false;
            flujo.AutoScroll = true;
            p.Controls.Add(flujo);

            _calendario = new MonthCalendar();
            _calendario.CalendarDimensions = new Size(2, 1);
            _calendario.MaxSelectionCount = 31;
            _calendario.ShowWeekNumbers = false;
            _calendario.Margin = new Padding(8);
            _calendario.DateChanged += Calendario_DateChanged;
            flujo.Controls.Add(_calendario);

            _lblResultado = new Label();
            _lblResultado.AutoSize = false;
            _lblResultado.Size = new Size(840, 120);
            _lblResultado.Margin = new Padding(8);
            _lblResultado.Padding = new Padding(10);
            _lblResultado.BorderStyle = BorderStyle.FixedSingle;
            _lblResultado.Font = new Font("Segoe UI", 12F);
            _lblResultado.TextAlign = ContentAlignment.MiddleLeft;
            flujo.Controls.Add(_lblResultado);

            FlowLayoutPanel botones = new FlowLayoutPanel();
            botones.AutoSize = true;
            botones.FlowDirection = FlowDirection.LeftToRight;
            botones.Margin = new Padding(8);
            flujo.Controls.Add(botones);

            Button btnHoy = new Button();
            btnHoy.Text = "Ir a hoy";
            btnHoy.Size = new Size(130, 36);
            btnHoy.Click += BtnHoy_Click;
            botones.Controls.Add(btnHoy);

            Button btnSemana = new Button();
            btnSemana.Text = "Seleccionar esta semana";
            btnSemana.Size = new Size(210, 36);
            btnSemana.Click += BtnSemana_Click;
            botones.Controls.Add(btnSemana);

            CheckBox chkSemanas = new CheckBox();
            chkSemanas.Text = "Mostrar número de semana";
            chkSemanas.AutoSize = true;
            chkSemanas.Margin = new Padding(16, 8, 3, 3);
            chkSemanas.CheckedChanged += ChkSemanas_CheckedChanged;
            botones.Controls.Add(chkSemanas);

            ActualizarTexto(_calendario.SelectionStart, _calendario.SelectionEnd);
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
