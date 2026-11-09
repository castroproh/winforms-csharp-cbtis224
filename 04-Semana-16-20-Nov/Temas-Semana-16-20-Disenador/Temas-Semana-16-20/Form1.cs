using System;
using System.Windows.Forms;

namespace TemasSemana1620
{
    /// <summary>Menú principal: un botón por tema.</summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTema11_Click(object sender, EventArgs e)
        {
            AbrirTema(() => new FormGenerarPdf());
        }

        private void btnTema12_Click(object sender, EventArgs e)
        {
            AbrirTema(() => new FormPdfScreens());
        }

        private void btnTema14_Click(object sender, EventArgs e)
        {
            AbrirTema(() => new FormGif());
        }

        private void btnTema15_Click(object sender, EventArgs e)
        {
            AbrirTema(() => new FormMonthCalendar());
        }

        private void btnTema16_Click(object sender, EventArgs e)
        {
            AbrirTema(() => new FormCalendario());
        }

        private void btnTema17_Click(object sender, EventArgs e)
        {
            AbrirTema(() => new FormStatusStrip());
        }

        private void btnTema20_Click(object sender, EventArgs e)
        {
            AbrirTema(() => new FormToolStrip());
        }

        private void AbrirTema(Func<Form> crearFormulario)
        {
            try
            {
                using (Form tema = crearFormulario())
                {
                    tema.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No se pudo abrir el tema:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
