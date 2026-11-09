namespace Temas_Semana_30_nov_4_dic
{
    // Menu principal: un boton por tema
    public partial class Form1 : FormBase
    {
        public Form1() : base("Temas semana 30 nov - 4 dic | Pymasa", 480, 520)
        {
            InitializeComponent();

            // Imagen dibujada en codigo y color de resalte de los botones
            picBanner.Image = Estilo.Banner(480, 140);
            AplicarHover(btn26, btn27, btnSalir);
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
