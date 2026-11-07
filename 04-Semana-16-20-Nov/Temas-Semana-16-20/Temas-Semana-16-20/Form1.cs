using System;
using System.Drawing;
using System.Windows.Forms;

namespace TemasSemana1620
{
    /// <summary>Menú principal: un botón por tema.</summary>
    public class Form1 : Form
    {
        private readonly FlowLayoutPanel _panelBotones;

        public Form1()
        {
            Text = "Temas Semana 16-20 - Menú principal";
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(680, 640);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Font = new Font("Segoe UI", 10F);
            BackColor = Color.White;

            _panelBotones = new FlowLayoutPanel();
            _panelBotones.Dock = DockStyle.Fill;
            _panelBotones.FlowDirection = FlowDirection.TopDown;
            _panelBotones.WrapContents = false;
            _panelBotones.Padding = new Padding(50, 20, 0, 0);

            Label lblTitulo = new Label();
            lblTitulo.Text = "Temas Semana 16 al 20\nWindows Forms - C# - CBTis 224";
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Height = 100;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.BackColor = Ayudas.ColorTitulo;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // Primero el que llena, después el del borde superior.
            Controls.Add(_panelBotones);
            Controls.Add(lblTitulo);

            AgregarBoton("11 - Genera PDF (PrintDocument)", () => new FormGenerarPdf());
            AgregarBoton("12 - Genera PDF de screens (DrawToBitmap)", () => new FormPdfScreens());
            AgregarBoton("14 - GIF animado (PictureBox)", () => new FormGif());
            AgregarBoton("15 - MonthCalendar", () => new FormMonthCalendar());
            AgregarBoton("16 - Calendar (DateTimePicker y días entre fechas)", () => new FormCalendario());
            AgregarBoton("17 - StatusStrip", () => new FormStatusStrip());
            AgregarBoton("20 - ToolStrip y ToolStripContainer", () => new FormToolStrip());

            Button btnSalir = new Button();
            btnSalir.Text = "Salir";
            btnSalir.Size = new Size(560, 46);
            btnSalir.Margin = new Padding(6, 18, 6, 6);
            btnSalir.Click += BtnSalir_Click;
            _panelBotones.Controls.Add(btnSalir);
        }

        private void AgregarBoton(string texto, Func<Form> crearFormulario)
        {
            Button boton = new Button();
            boton.Text = texto;
            boton.Size = new Size(560, 46);
            boton.Margin = new Padding(6);
            boton.Click += (sender, e) => AbrirTema(crearFormulario);
            _panelBotones.Controls.Add(boton);
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
