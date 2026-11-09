using System;
using System.Windows.Forms;

namespace TemasSemana
{
    // Menú principal: un botón por tema.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Las imágenes se dibujan con GDI+ (Dibujo.cs), por eso se asignan aquí y no en el Designer.
            picBanner.Image = Dibujo.Banner(560, 150);
            btnKeyDown.Image = Dibujo.IconoTeclado(36);
            btnClaseDgv.Image = Dibujo.IconoTabla(36);
            btnCatalogo.Image = Dibujo.IconoLupa(36);
            btnEdicion.Image = Dibujo.IconoLapiz(36);
        }

        private void AbrirTema(Func<Form> crearFormulario)
        {
            Form tema = null;
            try
            {
                tema = crearFormulario();
                tema.ShowDialog(this);
            }
            catch (Exception ex)
            {
                UI.MostrarError("No se pudo abrir el formulario: " + ex.Message);
            }
            finally
            {
                if (tema != null)
                {
                    tema.Dispose();
                }
            }
        }

        private void BtnKeyDown_Click(object sender, EventArgs e)
        {
            AbrirTema(() => new FormKeyDown());
        }

        private void BtnClaseDgv_Click(object sender, EventArgs e)
        {
            AbrirTema(() => new DataGridView_1());
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            AbrirTema(() => new FormCatalogo());
        }

        private void BtnEdicion_Click(object sender, EventArgs e)
        {
            AbrirTema(() => new FormEdicion());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
