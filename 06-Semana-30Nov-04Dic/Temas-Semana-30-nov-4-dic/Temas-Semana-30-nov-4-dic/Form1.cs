using System.ComponentModel;

namespace Temas_Semana_30_nov_4_dic
{
    // Menu principal: un boton por tema
    [DesignerCategory("Code")]
    public class Form1 : FormBase
    {
        private PictureBox picBanner;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblFecha;
        private Button btn26;
        private Button btn27;
        private Button btnSalir;

        public Form1() : base("Temas semana 30 nov - 4 dic | Pymasa", 480, 520)
        {
            picBanner = new PictureBox();
            picBanner.SetBounds(0, 0, 480, 140);
            picBanner.Image = Estilo.Banner(480, 140);
            Controls.Add(picBanner);

            lblTitulo = Estilo.Etiqueta("Temas de la semana 30 nov - 4 dic", 20, 158, 440, 34, 16f, true, ContentAlignment.MiddleCenter);
            lblTitulo.ForeColor = Estilo.Oscuro;
            Controls.Add(lblTitulo);

            lblSubtitulo = Estilo.Etiqueta("Selecciona un tema para abrirlo", 20, 192, 440, 26, 10f, false, ContentAlignment.MiddleCenter);
            lblSubtitulo.ForeColor = Color.DimGray;
            Controls.Add(lblSubtitulo);

            btn26 = Estilo.Boton("26  Ticket de venta", 70, 240, 340, 56, Estilo.Principal);
            btn26.Font = new Font("Segoe UI", 13f, FontStyle.Bold);
            btn26.Click += Btn26_Click;
            Controls.Add(btn26);

            btn27 = Estilo.Boton("27  Ticket (pagar e imprimir)", 70, 316, 340, 56, Estilo.Azul);
            btn27.Font = new Font("Segoe UI", 13f, FontStyle.Bold);
            btn27.Click += Btn27_Click;
            Controls.Add(btn27);

            btnSalir = Estilo.Boton("Salir", 70, 400, 340, 44, Estilo.Rojo);
            btnSalir.Click += BtnSalir_Click;
            Controls.Add(btnSalir);

            lblFecha = Estilo.Etiqueta("", 20, 470, 440, 26, 9f, false, ContentAlignment.MiddleCenter);
            lblFecha.ForeColor = Color.DimGray;
            Controls.Add(lblFecha);

            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime FA = DateTime.Now;
            lblFecha.Text = Convert.ToString(FA);
        }

        // Tema 26: primero el login y despues la pantalla de venta
        private void Btn26_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin(this);
            login.Show();
            this.Hide();
        }

        // Tema 27: pantalla del ticket (pago, descuento, cambio y vista previa)
        private void Btn27_Click(object sender, EventArgs e)
        {
            FormTicket ticket = new FormTicket(this);
            ticket.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
