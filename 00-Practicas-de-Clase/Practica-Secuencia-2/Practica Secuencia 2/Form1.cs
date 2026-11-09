namespace Practica_Secuencia_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hora = dateTimePicker1.Value.ToString();
            MessageBox.Show(hora);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 3000;
            t.Tick += t_Tick;
            t.Start();
            toolTip1.SetToolTip(button2, "Limpiar");
            toolTip2.SetToolTip(button3, "Mostrar");
        }
        private void t_Tick(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Timer t)
            {
                t.Stop();
                t.Tick -= t_Tick;
            }
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.BackgroundImage = null;
            this.Text = "Mi Programa";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            linkLabel1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            button1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            label2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkVisited = true;
                string pagina = "https://classroom.google.com";

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = pagina,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la página: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
