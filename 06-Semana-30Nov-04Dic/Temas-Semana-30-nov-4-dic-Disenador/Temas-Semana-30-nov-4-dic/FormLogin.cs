namespace Temas_Semana_30_nov_4_dic
{
    // Tema 26 (parte 1): login con usuario y contrasena
    public partial class FormLogin : FormBase
    {
        private const string UsuarioOk = "Alumno1";
        private const string ClaveOk = "Cbtis224";

        private Form menu;
        private int intentos = 0;

        public FormLogin(Form menuPrincipal) : base("Pymasa - Inicio de sesion", 440, 540)
        {
            InitializeComponent();
            menu = menuPrincipal;

            // Imagen dibujada en codigo y color de resalte de los botones
            picLogo.Image = Estilo.Logo(200);
            AplicarHover(btnEntrar, btnRegresar);
        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void ChkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = !chkMostrar.Checked;
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Error! \n tienes que teclear usuario y contraseña!! \n intentalo de nuevo!!",
                    "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrWhiteSpace(txtUsuario.Text)) txtUsuario.Focus(); else txtClave.Focus();
                return;
            }

            if (txtUsuario.Text.Trim() == UsuarioOk && txtClave.Text == ClaveOk)
            {
                Venta.Usuario = txtUsuario.Text.Trim();
                Venta.Limpiar();

                FormVenta venta = new FormVenta(menu);
                venta.Show();
                navegando = true;
                this.Close();
            }
            else
            {
                intentos++;
                txtClave.Text = "";

                if (intentos >= 3)
                {
                    MessageBox.Show("Demasiados intentos fallidos!! \n regresando al menu principal.",
                        "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    menu.Show();
                    navegando = true;
                    this.Close();
                    return;
                }

                MessageBox.Show("Usuario o contraseña incorrectos!! \n Intento " + intentos + " de 3.",
                    "Pymasa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Focus();
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            menu.Show();
            navegando = true;
            this.Close();
        }
    }
}
