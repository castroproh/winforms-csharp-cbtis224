using System;
using System.Drawing;
using System.Windows.Forms;

namespace TemasSemana1620
{
    /// <summary>Tema 20: ToolStrip con botones dentro de un ToolStripContainer.</summary>
    public partial class FormToolStrip : Form
    {
        public FormToolStrip()
        {
            InitializeComponent();

            CargarIconos();
        }

        /// <summary>Los iconos se dibujan por código (GDI+), por eso se asignan aquí y no en el Designer.</summary>
        private void CargarIconos()
        {
            btnNuevo.Image = IconosCodigo.Crear("nuevo");
            btnAbrir.Image = IconosCodigo.Crear("abrir");
            btnGuardar.Image = IconosCodigo.Crear("guardar");
            btnCortar.Image = IconosCodigo.Crear("cortar");
            btnCopiar.Image = IconosCodigo.Crear("copiar");
            btnPegar.Image = IconosCodigo.Crear("pegar");
            _btnNegrita.Image = IconosCodigo.Crear("negrita");
            _btnCursiva.Image = IconosCodigo.Crear("cursiva");
            _btnSubrayado.Image = IconosCodigo.Crear("subrayado");
            btnColor.Image = IconosCodigo.Crear("color");
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
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
