using System;
using System.Drawing;
using System.Windows.Forms;

namespace TemasSemana
{
    // Menú principal: un botón por tema.
    public class Form1 : Form
    {
        private PictureBox picBanner;
        private Button btnKeyDown;
        private Button btnClaseDgv;
        private Button btnCatalogo;
        private Button btnEdicion;
        private Button btnSalir;

        public Form1()
        {
            UI.ConfigurarFormulario(this, "Temas Semana 23-27 - Menú principal", 560, 500);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ConstruirInterfaz();
        }

        private void ConstruirInterfaz()
        {
            TableLayoutPanel layout = new TableLayoutPanel();
            layout.Dock = DockStyle.Fill;
            layout.ColumnCount = 1;
            layout.RowCount = 7;
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            picBanner = new PictureBox();
            picBanner.Dock = DockStyle.Fill;
            picBanner.Margin = new Padding(0);
            picBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            picBanner.Image = Dibujo.Banner(560, 150);

            btnKeyDown = CrearBotonMenu("21   KeyDown - atajos de teclado", Dibujo.IconoTeclado(36), BtnKeyDown_Click);
            btnClaseDgv = CrearBotonMenu("22   Clase DataGridView_1", Dibujo.IconoTabla(36), BtnClaseDgv_Click);
            btnCatalogo = CrearBotonMenu("24   DataGridView - catálogo y búsqueda", Dibujo.IconoLupa(36), BtnCatalogo_Click);
            btnEdicion = CrearBotonMenu("25   DataGridView - edición y totales", Dibujo.IconoLapiz(36), BtnEdicion_Click);

            btnSalir = UI.CrearBoton("Salir", 120, BtnSalir_Click);
            btnSalir.Dock = DockStyle.Fill;
            btnSalir.Margin = new Padding(40, 10, 40, 10);
            btnSalir.BackColor = Color.FromArgb(120, 120, 120);

            layout.Controls.Add(picBanner, 0, 0);
            layout.Controls.Add(btnKeyDown, 0, 1);
            layout.Controls.Add(btnClaseDgv, 0, 2);
            layout.Controls.Add(btnCatalogo, 0, 3);
            layout.Controls.Add(btnEdicion, 0, 4);
            layout.Controls.Add(btnSalir, 0, 5);

            Controls.Add(layout);
        }

        private static Button CrearBotonMenu(string texto, Bitmap icono, EventHandler alHacerClic)
        {
            Button boton = new Button();
            boton.Text = texto;
            boton.Image = icono;
            boton.ImageAlign = ContentAlignment.MiddleLeft;
            boton.TextAlign = ContentAlignment.MiddleLeft;
            boton.TextImageRelation = TextImageRelation.ImageBeforeText;
            boton.Padding = new Padding(20, 0, 0, 0);
            boton.Dock = DockStyle.Fill;
            boton.Margin = new Padding(40, 6, 40, 6);
            boton.Font = UI.Grande;
            boton.ForeColor = UI.Azul;
            boton.BackColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderColor = UI.Azul;
            boton.FlatAppearance.BorderSize = 1;
            boton.Cursor = Cursors.Hand;
            boton.UseVisualStyleBackColor = false;
            boton.Click += alHacerClic;
            return boton;
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
