using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TemasSemana1620
{
    /// <summary>Tema 16: DateTimePicker con calendario y cálculo de días entre dos fechas.</summary>
    public class FormCalendario : Form
    {
        private static readonly CultureInfo Cultura = new CultureInfo("es-MX");

        private DateTimePicker _dtpInicio;
        private DateTimePicker _dtpFin;
        private Label _lblDiaInicio;
        private Label _lblDiaFin;
        private Label _lblResultado;

        public FormCalendario()
        {
            Panel p = Ayudas.Preparar(this, "Tema 16 - Calendar (DateTimePicker)");

            Label instruccion = Ayudas.Etiqueta(p, "Despliega el calendario de cada selector y elige las fechas.", 12, 16);
            instruccion.Font = new Font("Segoe UI", 11F);

            Ayudas.Etiqueta(p, "Fecha inicial:", 12, 66);
            _dtpInicio = CrearSelector(p, 150, 62);
            _lblDiaInicio = Ayudas.Etiqueta(p, "", 560, 66);

            Ayudas.Etiqueta(p, "Fecha final:", 12, 116);
            _dtpFin = CrearSelector(p, 150, 112);
            _lblDiaFin = Ayudas.Etiqueta(p, "", 560, 116);
            _dtpFin.Value = DateTime.Today.AddDays(30); // ya existen las etiquetas que usa ValueChanged

            Button btnCalcular = Ayudas.Boton(p, "Calcular días entre fechas", 12, 170, 230, 40);
            btnCalcular.Click += BtnCalcular_Click;

            Button btnHoy = Ayudas.Boton(p, "Poner hoy en ambas", 252, 170, 190, 40);
            btnHoy.Click += BtnHoy_Click;

            Button btnIntercambiar = Ayudas.Boton(p, "Intercambiar fechas", 452, 170, 190, 40);
            btnIntercambiar.Click += BtnIntercambiar_Click;

            _lblResultado = new Label();
            _lblResultado.AutoSize = false;
            _lblResultado.Location = new Point(12, 230);
            _lblResultado.Size = new Size(860, 200);
            _lblResultado.BorderStyle = BorderStyle.FixedSingle;
            _lblResultado.Padding = new Padding(10);
            _lblResultado.Font = new Font("Segoe UI", 12F);
            _lblResultado.Text = "Elige dos fechas y presiona \"Calcular\".";
            p.Controls.Add(_lblResultado);

            ActualizarDias();
        }

        private DateTimePicker CrearSelector(Control padre, int x, int y)
        {
            DateTimePicker dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Long;
            dtp.Location = new Point(x, y);
            dtp.Width = 390;
            dtp.ValueChanged += Selector_ValueChanged;
            padre.Controls.Add(dtp);
            return dtp;
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
