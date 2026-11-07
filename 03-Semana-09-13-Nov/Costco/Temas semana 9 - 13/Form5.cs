namespace Temas_semana_9___13
{
    public partial class Form5 : Form
    {
        int articulos = 0;

        public Form5()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            articulos++;
            lblCarrito.Text = "Artículos en el carrito: " + articulos;
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            articulos = 0;
            lblCarrito.Text = "Artículos en el carrito: " + articulos;
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            if (articulos == 0)
            {
                MessageBox.Show("Tu carrito está vacío.", "Costco Wholesale");
                return;
            }

            MessageBox.Show("Pagaste " + articulos + " artículo(s). ¡Gracias por tu compra!", "Costco Wholesale");
            articulos = 0;
            lblCarrito.Text = "Artículos en el carrito: " + articulos;
        }
    }
}
