using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace TemasSemana1620
{
    /// <summary>Tema 17: StatusStrip con fecha, hora (Timer) y mensaje de la acción actual.</summary>
    public partial class FormStatusStrip : Form
    {
        private static readonly CultureInfo Cultura = new CultureInfo("es-MX");

        public FormStatusStrip()
        {
            InitializeComponent();

            ActualizarReloj();
            _tmrReloj.Start();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
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
