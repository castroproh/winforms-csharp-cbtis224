using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace TemasSemana1620
{
    /// <summary>Tema 17: StatusStrip con fecha, hora (Timer) y mensaje de la acción actual.</summary>
    public class FormStatusStrip : Form
    {
        private static readonly CultureInfo Cultura = new CultureInfo("es-MX");

        private TextBox _txtNotas;
        private TextBox _txtMensaje;
        private StatusStrip _barra;
        private ToolStripStatusLabel _lblAccion;
        private ToolStripStatusLabel _lblFecha;
        private ToolStripStatusLabel _lblHora;
        private ToolStripProgressBar _progreso;
        private System.Windows.Forms.Timer _tmrReloj;
        private System.Windows.Forms.Timer _tmrProgreso;

        public FormStatusStrip()
        {
            Panel p = Ayudas.Preparar(this, "Tema 17 - StatusStrip");

            Ayudas.Etiqueta(p, "Escribe en el cuadro o usa los botones: la barra de abajo muestra la acción actual.", 12, 12);

            _txtNotas = new TextBox();
            _txtNotas.Multiline = true;
            _txtNotas.ScrollBars = ScrollBars.Vertical;
            _txtNotas.Location = new Point(12, 44);
            _txtNotas.Size = new Size(860, 250);
            _txtNotas.TextChanged += TxtNotas_TextChanged;
            p.Controls.Add(_txtNotas);

            Button btnNuevo = Ayudas.Boton(p, "Nuevo", 12, 310, 140, 38);
            btnNuevo.Click += BtnNuevo_Click;

            Button btnGuardar = Ayudas.Boton(p, "Guardar...", 162, 310, 140, 38);
            btnGuardar.Click += BtnGuardar_Click;

            Button btnProcesar = Ayudas.Boton(p, "Procesar", 312, 310, 140, 38);
            btnProcesar.Click += BtnProcesar_Click;

            Ayudas.Etiqueta(p, "Mensaje:", 12, 374);
            _txtMensaje = Ayudas.Texto(p, 100, 370, 400);
            Button btnMensaje = Ayudas.Boton(p, "Mostrar en la barra", 510, 368, 180, 36);
            btnMensaje.Click += BtnMensaje_Click;

            // Barra de estado (se agrega al final para que quede hasta abajo)
            _barra = new StatusStrip();
            _barra.Dock = DockStyle.Bottom;
            _barra.SizingGrip = false;

            _lblAccion = new ToolStripStatusLabel("Listo");
            _lblAccion.Spring = true;
            _lblAccion.TextAlign = ContentAlignment.MiddleLeft;

            _progreso = new ToolStripProgressBar();
            _progreso.Minimum = 0;
            _progreso.Maximum = 100;
            _progreso.Width = 120;
            _progreso.Visible = false;

            _lblFecha = new ToolStripStatusLabel();
            _lblFecha.BorderSides = ToolStripStatusLabelBorderSides.Left;
            _lblFecha.BorderStyle = Border3DStyle.Etched;

            _lblHora = new ToolStripStatusLabel();
            _lblHora.BorderSides = ToolStripStatusLabelBorderSides.Left;
            _lblHora.BorderStyle = Border3DStyle.Etched;

            _barra.Items.AddRange(new ToolStripItem[] { _lblAccion, _progreso, _lblFecha, _lblHora });
            Controls.Add(_barra);

            _tmrReloj = new System.Windows.Forms.Timer();
            _tmrReloj.Interval = 1000;
            _tmrReloj.Tick += TmrReloj_Tick;

            _tmrProgreso = new System.Windows.Forms.Timer();
            _tmrProgreso.Interval = 150;
            _tmrProgreso.Tick += TmrProgreso_Tick;

            ActualizarReloj();
            _tmrReloj.Start();

            FormClosed += FormStatusStrip_FormClosed;
        }

        private void FormStatusStrip_FormClosed(object sender, FormClosedEventArgs e)
        {
            _tmrReloj.Stop();
            _tmrReloj.Dispose();
            _tmrProgreso.Stop();
            _tmrProgreso.Dispose();
        }

        private void ActualizarReloj()
        {
            DateTime ahora = DateTime.Now;
            _lblFecha.Text = ahora.ToString("dddd d 'de' MMMM 'de' yyyy", Cultura);
            _lblHora.Text = ahora.ToString("HH:mm:ss", Cultura);
        }

        private void TmrReloj_Tick(object sender, EventArgs e)
        {
            ActualizarReloj();
        }

        private void TxtNotas_TextChanged(object sender, EventArgs e)
        {
            _lblAccion.Text = "Escribiendo... " + _txtNotas.TextLength + " carácter(es)";
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            _txtNotas.Clear();
            _lblAccion.Text = "Documento nuevo";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Texto (*.txt)|*.txt";
                dlg.DefaultExt = "txt";
                dlg.OverwritePrompt = true;
                _lblAccion.Text = "Guardando...";
                if (dlg.ShowDialog(this) != DialogResult.OK)
                {
                    _lblAccion.Text = "Guardado cancelado";
                    return;
                }

                try
                {
                    File.WriteAllText(dlg.FileName, _txtNotas.Text);
                    _lblAccion.Text = "Archivo guardado: " + Path.GetFileName(dlg.FileName);
                }
                catch (Exception ex)
                {
                    _lblAccion.Text = "Error al guardar";
                    MessageBox.Show(this, "No se pudo guardar el archivo:\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            if (_tmrProgreso.Enabled)
            {
                return;
            }
            _progreso.Value = 0;
            _progreso.Visible = true;
            _lblAccion.Text = "Procesando...";
            _tmrProgreso.Start();
        }

        private void TmrProgreso_Tick(object sender, EventArgs e)
        {
            int nuevo = Math.Min(100, _progreso.Value + 5);
            _progreso.Value = nuevo;
            if (nuevo >= 100)
            {
                _tmrProgreso.Stop();
                _progreso.Visible = false;
                _lblAccion.Text = "Proceso terminado";
            }
        }

        private void BtnMensaje_Click(object sender, EventArgs e)
        {
            string texto = _txtMensaje.Text.Trim();
            if (texto.Length == 0)
            {
                MessageBox.Show(this, "Escribe un mensaje para mostrarlo en la barra de estado.", "Mensaje vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txtMensaje.Focus();
                return;
            }
            _lblAccion.Text = texto;
        }
    }
}
