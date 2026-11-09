namespace SEC1_PANELES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime FA = DateTime.Now;
            label6.Text = Convert.ToString(FA);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
