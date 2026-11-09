namespace Temas_semana_9___13
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LlenarTabla();
        }

        // Crea una celda (Label) con el estilo que se le pida
        private Label CrearCelda(string texto, Color fondo, Color letra, bool negrita)
        {
            Label celda = new Label();
            celda.Text = texto;
            celda.BackColor = fondo;
            celda.ForeColor = letra;
            celda.Dock = DockStyle.Fill;
            celda.TextAlign = ContentAlignment.MiddleCenter;
            celda.Margin = new Padding(0);
            celda.Font = new Font("Segoe UI", 12F, negrita ? FontStyle.Bold : FontStyle.Regular);
            return celda;
        }

        private void LlenarTabla()
        {
            string[] titulos = { "Producto", "Cantidad", "Precio", "Subtotal" };
            string[] productos = { "Pollo rostizado", "Pañales Kirkland", "Agua 40 pzas", "Pantalla 55\"" };
            int[] cantidades = { 2, 1, 3, 1 };
            double[] precios = { 99, 549, 129, 8999 };
            double total = 0;

            Color azul = Color.FromArgb(0, 93, 170);
            Color rojo = Color.FromArgb(227, 24, 55);

            // Fila 0: encabezados
            for (int c = 0; c < titulos.Length; c++)
            {
                tableLayoutPanel1.Controls.Add(CrearCelda(titulos[c], azul, Color.White, true), c, 0);
            }

            // Filas 1 a 4: productos
            for (int i = 0; i < productos.Length; i++)
            {
                double subtotal = cantidades[i] * precios[i];
                total += subtotal;

                Color fondo = (i % 2 == 0) ? Color.White : Color.FromArgb(235, 240, 248);

                tableLayoutPanel1.Controls.Add(CrearCelda(productos[i], fondo, Color.Black, false), 0, i + 1);
                tableLayoutPanel1.Controls.Add(CrearCelda(cantidades[i].ToString(), fondo, Color.Black, false), 1, i + 1);
                tableLayoutPanel1.Controls.Add(CrearCelda(precios[i].ToString("C2"), fondo, Color.Black, false), 2, i + 1);
                tableLayoutPanel1.Controls.Add(CrearCelda(subtotal.ToString("C2"), fondo, Color.Black, false), 3, i + 1);
            }

            // Fila 5: total (la primera celda ocupa 3 columnas)
            Label etiquetaTotal = CrearCelda("TOTAL A PAGAR", rojo, Color.White, true);
            tableLayoutPanel1.Controls.Add(etiquetaTotal, 0, 5);
            tableLayoutPanel1.SetColumnSpan(etiquetaTotal, 3);
            tableLayoutPanel1.Controls.Add(CrearCelda(total.ToString("C2"), rojo, Color.White, true), 3, 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
