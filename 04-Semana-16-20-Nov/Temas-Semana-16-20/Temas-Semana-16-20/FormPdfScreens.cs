using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace TemasSemana1620
{
    /// <summary>Tema 12: captura con Control.DrawToBitmap y guarda como imagen y como PDF.</summary>
    public class FormPdfScreens : Form
    {
        private Panel _pnlMuestra;
        private Panel _pnlGrafica;
        private TextBox _txtNombre;
        private ComboBox _cmbGrupo;
        private CheckBox _chkActivo;
        private PictureBox _pbCaptura;
        private Label _lblEstado;
        private Bitmap _captura;

        public FormPdfScreens()
        {
            Panel p = Ayudas.Preparar(this, "Tema 12 - Genera PDF de screens (DrawToBitmap)");

            // Área de muestra: lo que se va a capturar
            _pnlMuestra = new Panel();
            _pnlMuestra.Location = new Point(12, 12);
            _pnlMuestra.Size = new Size(400, 330);
            _pnlMuestra.BorderStyle = BorderStyle.FixedSingle;
            _pnlMuestra.BackColor = Color.FromArgb(250, 250, 245);
            p.Controls.Add(_pnlMuestra);

            Label lblMuestra = Ayudas.Etiqueta(_pnlMuestra, "Área de muestra (se puede capturar)", 10, 10);
            lblMuestra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            Ayudas.Etiqueta(_pnlMuestra, "Nombre:", 10, 44);
            _txtNombre = Ayudas.Texto(_pnlMuestra, 90, 40, 280);
            _txtNombre.Text = "Alumno del CBTis 224";

            Ayudas.Etiqueta(_pnlMuestra, "Grupo:", 10, 78);
            _cmbGrupo = new ComboBox();
            _cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            _cmbGrupo.Items.AddRange(new object[] { "5° A", "5° B", "6° A", "6° B" });
            _cmbGrupo.SelectedIndex = 0;
            _cmbGrupo.Location = new Point(90, 74);
            _cmbGrupo.Width = 120;
            _pnlMuestra.Controls.Add(_cmbGrupo);

            _chkActivo = new CheckBox();
            _chkActivo.Text = "Alumno activo";
            _chkActivo.Checked = true;
            _chkActivo.AutoSize = true;
            _chkActivo.Location = new Point(240, 78);
            _pnlMuestra.Controls.Add(_chkActivo);

            _pnlGrafica = new Panel();
            _pnlGrafica.Location = new Point(10, 114);
            _pnlGrafica.Size = new Size(372, 200);
            _pnlGrafica.BackColor = Color.White;
            _pnlGrafica.BorderStyle = BorderStyle.FixedSingle;
            _pnlGrafica.Paint += PnlGrafica_Paint;
            _pnlMuestra.Controls.Add(_pnlGrafica);

            // Vista previa de la captura
            _pbCaptura = new PictureBox();
            _pbCaptura.Location = new Point(430, 12);
            _pbCaptura.Size = new Size(440, 330);
            _pbCaptura.BorderStyle = BorderStyle.FixedSingle;
            _pbCaptura.SizeMode = PictureBoxSizeMode.Zoom;
            _pbCaptura.BackColor = Color.WhiteSmoke;
            p.Controls.Add(_pbCaptura);

            Button btnForm = Ayudas.Boton(p, "Capturar formulario completo", 12, 360, 260, 40);
            btnForm.Click += BtnCapturarFormulario_Click;

            Button btnArea = Ayudas.Boton(p, "Capturar solo el área de muestra", 282, 360, 280, 40);
            btnArea.Click += BtnCapturarArea_Click;

            Button btnPng = Ayudas.Boton(p, "Guardar como imagen (PNG)", 12, 410, 260, 40);
            btnPng.Click += BtnGuardarPng_Click;

            Button btnPdf = Ayudas.Boton(p, "Guardar como PDF", 282, 410, 200, 40);
            btnPdf.Click += BtnGuardarPdf_Click;

            _lblEstado = Ayudas.Etiqueta(p, "Aún no hay captura. Presiona uno de los botones de captura.", 12, 466);

            FormClosed += FormPdfScreens_FormClosed;
        }

        private void FormPdfScreens_FormClosed(object sender, FormClosedEventArgs e)
        {
            _pbCaptura.Image = null;
            if (_captura != null)
            {
                _captura.Dispose();
                _captura = null;
            }
        }

        private void PnlGrafica_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int[] valores = { 40, 75, 55, 90, 65 };
            Color[] colores = { Color.SteelBlue, Color.Orange, Color.SeaGreen, Color.Crimson, Color.MediumPurple };
            int baseY = _pnlGrafica.ClientSize.Height - 24;
            int anchoBarra = 40;
            int separacion = (_pnlGrafica.ClientSize.Width - anchoBarra * valores.Length) / (valores.Length + 1);

            using (Font fuente = new Font("Segoe UI", 9F))
            {
                g.DrawString("Calificaciones de ejemplo", fuente, Brushes.Black, 8, 4);
                for (int i = 0; i < valores.Length; i++)
                {
                    int alto = valores[i] * (baseY - 30) / 100;
                    int x = separacion + i * (anchoBarra + separacion);
                    using (SolidBrush pincel = new SolidBrush(colores[i]))
                    {
                        g.FillRectangle(pincel, x, baseY - alto, anchoBarra, alto);
                    }
                    g.DrawString(valores[i].ToString(), fuente, Brushes.Black, x + 8, baseY - alto - 18);
                    g.DrawString("P" + (i + 1), fuente, Brushes.Black, x + 10, baseY + 4);
                }
            }
            g.DrawLine(Pens.Black, 4, baseY, _pnlGrafica.ClientSize.Width - 4, baseY);
        }

        private void BtnCapturarFormulario_Click(object sender, EventArgs e)
        {
            Capturar(this, "formulario completo");
        }

        private void BtnCapturarArea_Click(object sender, EventArgs e)
        {
            Capturar(_pnlMuestra, "área de muestra");
        }

        private void Capturar(Control origen, string descripcion)
        {
            try
            {
                if (origen.Width <= 0 || origen.Height <= 0)
                {
                    throw new InvalidOperationException("El control no tiene tamaño para capturar.");
                }

                Bitmap nueva = new Bitmap(origen.Width, origen.Height);
                origen.DrawToBitmap(nueva, new Rectangle(0, 0, origen.Width, origen.Height));

                _pbCaptura.Image = null;
                if (_captura != null)
                {
                    _captura.Dispose();
                }
                _captura = nueva;
                _pbCaptura.Image = _captura;
                _lblEstado.Text = "Captura de " + descripcion + ": " + _captura.Width + " x " + _captura.Height + " px.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No se pudo hacer la captura:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool HayCaptura()
        {
            if (_captura == null)
            {
                MessageBox.Show(this, "Primero haz una captura.", "Sin captura",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void BtnGuardarPng_Click(object sender, EventArgs e)
        {
            if (!HayCaptura())
            {
                return;
            }

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Imagen PNG (*.png)|*.png";
                dlg.DefaultExt = "png";
                dlg.OverwritePrompt = true;
                dlg.FileName = "Captura_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
                if (dlg.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    _captura.Save(dlg.FileName, ImageFormat.Png);
                    MessageBox.Show(this, "Imagen guardada en:\n" + dlg.FileName, "Listo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "No se pudo guardar la imagen:\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnGuardarPdf_Click(object sender, EventArgs e)
        {
            if (!HayCaptura() || !PdfUtil.ValidarImpresora(this))
            {
                return;
            }

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Documento PDF (*.pdf)|*.pdf";
                dlg.DefaultExt = "pdf";
                dlg.OverwritePrompt = true;
                dlg.FileName = "Captura_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";
                if (dlg.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    using (PrintDocument doc = new PrintDocument())
                    {
                        doc.DocumentName = "Captura de pantalla";
                        doc.PrintPage += Doc_PrintPage;
                        PdfUtil.ImprimirAPdf(doc, dlg.FileName, _captura.Width > _captura.Height);
                        doc.PrintPage -= Doc_PrintPage;
                    }
                    PdfUtil.PreguntarAbrir(this, dlg.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "No se pudo generar el PDF:\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle area = e.MarginBounds;
            float escala = Math.Min((float)area.Width / _captura.Width, (float)area.Height / _captura.Height);
            int ancho = (int)(_captura.Width * escala);
            int alto = (int)(_captura.Height * escala);
            e.Graphics.DrawImage(_captura, area.Left, area.Top, ancho, alto);
            e.HasMorePages = false;
        }
    }
}
