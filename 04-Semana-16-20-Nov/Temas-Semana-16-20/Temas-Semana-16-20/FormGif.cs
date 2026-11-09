using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace TemasSemana1620
{
    /// <summary>Tema 14: PictureBox con un GIF animado (generado por código o elegido con OpenFileDialog).</summary>
    public class FormGif : Form
    {
        private PictureBox _pbGif;
        private Label _lblInfo;
        private MemoryStream _flujo;
        private Image _imagen;
        private byte[] _ultimoGif;

        public FormGif()
        {
            Panel p = Ayudas.Preparar(this, "Tema 14 - GIF animado (PictureBox)");

            _pbGif = new PictureBox();
            _pbGif.Location = new Point(12, 12);
            _pbGif.Size = new Size(520, 440);
            _pbGif.BorderStyle = BorderStyle.FixedSingle;
            _pbGif.SizeMode = PictureBoxSizeMode.Zoom;
            _pbGif.BackColor = Color.FromArgb(20, 24, 48);
            p.Controls.Add(_pbGif);

            Button btnGenerar = Ayudas.Boton(p, "Generar GIF por código", 550, 12, 322, 44);
            btnGenerar.Click += BtnGenerar_Click;

            Button btnElegir = Ayudas.Boton(p, "Elegir un GIF (OpenFileDialog)", 550, 66, 322, 44);
            btnElegir.Click += BtnElegir_Click;

            Button btnGuardar = Ayudas.Boton(p, "Guardar el GIF generado", 550, 120, 322, 44);
            btnGuardar.Click += BtnGuardar_Click;

            _lblInfo = new Label();
            _lblInfo.AutoSize = false;
            _lblInfo.Location = new Point(550, 180);
            _lblInfo.Size = new Size(322, 140);
            _lblInfo.Text = "Aún no hay un GIF cargado.\nGenera uno por código o elige un archivo .gif.";
            p.Controls.Add(_lblInfo);

            FormClosed += FormGif_FormClosed;
        }

        private void FormGif_FormClosed(object sender, FormClosedEventArgs e)
        {
            LiberarImagen();
        }

        private void LiberarImagen()
        {
            _pbGif.Image = null;
            if (_imagen != null)
            {
                _imagen.Dispose();
                _imagen = null;
            }
            if (_flujo != null)
            {
                _flujo.Dispose();
                _flujo = null;
            }
        }

        private static int ObtenerCuadros(Image imagen)
        {
            try
            {
                return imagen.GetFrameCount(FrameDimension.Time);
            }
            catch (Exception)
            {
                return 1;
            }
        }

        private void MostrarGif(byte[] datos, string origen)
        {
            MemoryStream flujo = new MemoryStream(datos);
            Image imagen;
            try
            {
                imagen = Image.FromStream(flujo);
            }
            catch
            {
                flujo.Dispose();
                throw;
            }

            LiberarImagen();
            _flujo = flujo; // el flujo debe seguir abierto mientras exista la imagen
            _imagen = imagen;
            _pbGif.Image = _imagen;

            int cuadros = ObtenerCuadros(_imagen);
            _lblInfo.Text = origen + "\n" + _imagen.Width + " x " + _imagen.Height + " px, " + cuadros + " cuadro(s)." +
                (cuadros > 1 ? "\nEl PictureBox lo anima automáticamente." : "\nEste archivo no tiene animación.");
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            try
            {
                byte[] datos = GifBuilder.CrearSpinner(160, 12, 8);
                MostrarGif(datos, "GIF generado por código.");
                _ultimoGif = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No se pudo generar el GIF:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        private void BtnElegir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Archivos GIF (*.gif)|*.gif|Todos los archivos (*.*)|*.*";
                dlg.Title = "Elige un GIF animado";
                if (dlg.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    byte[] datos = File.ReadAllBytes(dlg.FileName);
                    MostrarGif(datos, "Archivo: " + Path.GetFileName(dlg.FileName));
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(this, "El archivo no es una imagen válida.", "Archivo no válido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "No se pudo abrir el archivo:\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (_ultimoGif == null)
            {
                MessageBox.Show(this, "Primero genera un GIF por código.", "Sin GIF",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Archivos GIF (*.gif)|*.gif";
                dlg.DefaultExt = "gif";
                dlg.OverwritePrompt = true;
                dlg.FileName = "spinner.gif";
                if (dlg.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    File.WriteAllBytes(dlg.FileName, _ultimoGif);
                    MessageBox.Show(this, "GIF guardado en:\n" + dlg.FileName, "Listo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "No se pudo guardar el GIF:\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
