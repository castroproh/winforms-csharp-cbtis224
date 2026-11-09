namespace PDV
{
    public partial class FormLogin : Form
    {
        // Usuario y contraseña correctos
        string alumnocbtis = "Alumno1";
        string contraalumno = "Cbtis224";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void BINICIARS_Click(object sender, EventArgs e)
        {
            string usuario = TBUSUARIO.Text;
            string contra = TBCONTRA.Text;

            if (usuario == alumnocbtis && contra == contraalumno)
            {
                MessageBox.Show("Bienvenido al sistema de venta");
                FormVenta F = new FormVenta();
                F.FormClosed += FormVenta_FormClosed;   // al cerrar la venta, se cierra todo
                F.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void FormVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
