namespace Temas_semana_9___13
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Un solo evento para las tres listas (una por cada pestaña)
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lista = (ListBox)sender;

            if (lista.SelectedItem != null)
            {
                lblSeleccion.Text = "Departamento: " + tabControl1.SelectedTab?.Text +
                                    "   |   Producto: " + lista.SelectedItem;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
