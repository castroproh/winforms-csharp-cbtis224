using System;
using System.Drawing;
using System.Windows.Forms;

namespace TemasSemana1620
{
    /// <summary>Tema 20: ToolStrip con botones dentro de un ToolStripContainer.</summary>
    public class FormToolStrip : Form
    {
        private RichTextBox _rtb;
        private ToolStrip _barra;
        private ToolStripButton _btnNegrita;
        private ToolStripButton _btnCursiva;
        private ToolStripButton _btnSubrayado;
        private ToolStripComboBox _cmbTamano;

        public FormToolStrip()
        {
            Panel p = Ayudas.Preparar(this, "Tema 20 - ToolStrip y ToolStripContainer");
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;

            _rtb = new RichTextBox();
            _rtb.Dock = DockStyle.Fill;
            _rtb.Font = new Font("Segoe UI", 12F);
            _rtb.Text = "Escribe aquí. Selecciona texto y usa los botones de la barra de herramientas.";
            _rtb.SelectionChanged += Rtb_SelectionChanged;

            _barra = new ToolStrip();
            _barra.ImageScalingSize = new Size(24, 24);
            _barra.GripStyle = ToolStripGripStyle.Visible;

            ToolStripButton btnNuevo = CrearBoton("Nuevo", "nuevo", "Documento nuevo");
            btnNuevo.Click += BtnNuevo_Click;
            ToolStripButton btnAbrir = CrearBoton("Abrir", "abrir", "Abrir un archivo de texto");
            btnAbrir.Click += BtnAbrir_Click;
            ToolStripButton btnGuardar = CrearBoton("Guardar", "guardar", "Guardar como texto");
            btnGuardar.Click += BtnGuardar_Click;

            ToolStripButton btnCortar = CrearBoton("Cortar", "cortar", "Cortar la selección");
            btnCortar.Click += BtnCortar_Click;
            ToolStripButton btnCopiar = CrearBoton("Copiar", "copiar", "Copiar la selección");
            btnCopiar.Click += BtnCopiar_Click;
            ToolStripButton btnPegar = CrearBoton("Pegar", "pegar", "Pegar del portapapeles");
            btnPegar.Click += BtnPegar_Click;

            _btnNegrita = CrearBoton("", "negrita", "Negrita");
            _btnNegrita.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _btnNegrita.CheckOnClick = true;
            _btnNegrita.Click += BtnNegrita_Click;

            _btnCursiva = CrearBoton("", "cursiva", "Cursiva");
            _btnCursiva.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _btnCursiva.CheckOnClick = true;
            _btnCursiva.Click += BtnCursiva_Click;

            _btnSubrayado = CrearBoton("", "subrayado", "Subrayado");
            _btnSubrayado.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _btnSubrayado.CheckOnClick = true;
            _btnSubrayado.Click += BtnSubrayado_Click;

            ToolStripButton btnColor = CrearBoton("Color", "color", "Color del texto seleccionado");
            btnColor.Click += BtnColor_Click;

            _cmbTamano = new ToolStripComboBox();
            _cmbTamano.DropDownStyle = ComboBoxStyle.DropDownList;
            _cmbTamano.Items.AddRange(new object[] { "8", "10", "12", "14", "18", "24", "36" });
            _cmbTamano.Width = 60;
            _cmbTamano.ToolTipText = "Tamaño de letra";
            _cmbTamano.SelectedIndex = 2;
            _cmbTamano.SelectedIndexChanged += CmbTamano_SelectedIndexChanged;

            _barra.Items.AddRange(new ToolStripItem[]
            {
                btnNuevo, btnAbrir, btnGuardar,
                new ToolStripSeparator(),
                btnCortar, btnCopiar, btnPegar,
                new ToolStripSeparator(),
                _btnNegrita, _btnCursiva, _btnSubrayado,
                new ToolStripSeparator(),
                btnColor,
                new ToolStripLabel("Tamaño:"),
                _cmbTamano
            });

            ToolStripContainer contenedor = new ToolStripContainer();
            contenedor.Dock = DockStyle.Fill;
            contenedor.TopToolStripPanel.Controls.Add(_barra);
            contenedor.ContentPanel.Controls.Add(_rtb);
            p.Controls.Add(contenedor);
        }

        private ToolStripButton CrearBoton(string texto, string icono, string ayuda)
        {
            ToolStripButton boton = new ToolStripButton(texto, IconosCodigo.Crear(icono));
            boton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            boton.TextImageRelation = TextImageRelation.ImageAboveText;
            boton.ToolTipText = ayuda;
            return boton;
        }

        private void Rtb_SelectionChanged(object sender, EventArgs e)
        {
            Font f = _rtb.SelectionFont;
            if (f == null || _btnNegrita == null || _btnCursiva == null || _btnSubrayado == null)
            {
                return; // selección con formatos mezclados o barra aún sin crear
            }
            _btnNegrita.Checked = f.Bold;
            _btnCursiva.Checked = f.Italic;
            _btnSubrayado.Checked = f.Underline;
        }

        private void CambiarEstilo(FontStyle estilo, bool activar)
        {
            Font actual = _rtb.SelectionFont;
            if (actual == null)
            {
                actual = _rtb.Font;
            }
            FontStyle nuevo = activar ? (actual.Style | estilo) : (actual.Style & ~estilo);
            _rtb.SelectionFont = new Font(actual, nuevo);
            _rtb.Focus();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (_rtb.TextLength > 0)
            {
                DialogResult r = MessageBox.Show(this, "¿Borrar el texto actual y empezar un documento nuevo?",
                    "Nuevo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r != DialogResult.Yes)
                {
                    return;
                }
            }
            _rtb.Clear();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                if (dlg.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }
                try
                {
                    _rtb.LoadFile(dlg.FileName, RichTextBoxStreamType.PlainText);
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
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Texto (*.txt)|*.txt";
                dlg.DefaultExt = "txt";
                dlg.OverwritePrompt = true;
                if (dlg.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }
                try
                {
                    _rtb.SaveFile(dlg.FileName, RichTextBoxStreamType.PlainText);
                    MessageBox.Show(this, "Archivo guardado.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "No se pudo guardar el archivo:\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool HaySeleccion()
        {
            if (_rtb.SelectionLength == 0)
            {
                MessageBox.Show(this, "Primero selecciona un texto.", "Sin selección",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void BtnCortar_Click(object sender, EventArgs e)
        {
            if (HaySeleccion())
            {
                _rtb.Cut();
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (HaySeleccion())
            {
                _rtb.Copy();
            }
        }

        private void BtnPegar_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsText())
            {
                MessageBox.Show(this, "El portapapeles no tiene texto.", "Pegar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _rtb.Paste();
        }

        private void BtnNegrita_Click(object sender, EventArgs e)
        {
            CambiarEstilo(FontStyle.Bold, _btnNegrita.Checked);
        }

        private void BtnCursiva_Click(object sender, EventArgs e)
        {
            CambiarEstilo(FontStyle.Italic, _btnCursiva.Checked);
        }

        private void BtnSubrayado_Click(object sender, EventArgs e)
        {
            CambiarEstilo(FontStyle.Underline, _btnSubrayado.Checked);
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    _rtb.SelectionColor = dlg.Color;
                    _rtb.Focus();
                }
            }
        }

        private void CmbTamano_SelectedIndexChanged(object sender, EventArgs e)
        {
            float tamano;
            if (!float.TryParse(_cmbTamano.Text, out tamano) || tamano < 6 || tamano > 72)
            {
                MessageBox.Show(this, "El tamaño debe estar entre 6 y 72.", "Tamaño no válido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Font actual = _rtb.SelectionFont;
            if (actual == null)
            {
                actual = _rtb.Font;
            }
            _rtb.SelectionFont = new Font(actual.FontFamily, tamano, actual.Style);
            _rtb.Focus();
        }
    }
}
