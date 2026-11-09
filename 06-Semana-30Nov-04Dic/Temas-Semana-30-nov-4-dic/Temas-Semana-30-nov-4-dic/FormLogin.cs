using System.ComponentModel;

namespace Temas_Semana_30_nov_4_dic
{
    // Tema 26 (parte 1): login con usuario y contrasena
    [DesignerCategory("Code")]
    public class FormLogin : FormBase
    {
        private const string UsuarioOk = "Alumno1";
        private const string ClaveOk = "Cbtis224";

        private Form menu;
        private int intentos = 0;

        private Panel pnlTarjeta;
        private PictureBox picLogo;
        private Label lblTitulo;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblClave;
        private TextBox txtClave;
        private CheckBox chkMostrar;
        private Button btnEntrar;
        private Button btnRegresar;
        private Label lblPista;

        public FormLogin(Form menuPrincipal) : base("Pymasa - Inicio de sesion", 440, 540)
        {
            menu = menuPrincipal;

            picLogo = new PictureBox();
            picLogo.SetBounds(170, 24, 100, 100);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.Image = Estilo.Logo(200);
            Controls.Add(picLogo);

            lblTitulo = Estilo.Etiqueta("Inicio de sesion", 20, 130, 400, 36, 18f, true, ContentAlignment.MiddleCenter);
            lblTitulo.ForeColor = Estilo.Oscuro;
            Controls.Add(lblTitulo);

            pnlTarjeta = new Panel();
            pnlTarjeta.SetBounds(40, 180, 360, 250);
            pnlTarjeta.BackColor = Color.White;
            Controls.Add(pnlTarjeta);

            lblUsuario = Estilo.Etiqueta("Usuario:", 24, 16, 300, 24, 10f, true, ContentAlignment.MiddleLeft);
            pnlTarjeta.Controls.Add(lblUsuario);

            txtUsuario = new TextBox();
            txtUsuario.SetBounds(24, 42, 312, 30);
            txtUsuario.Font = new Font("Segoe UI", 12f);
            pnlTarjeta.Controls.Add(txtUsuario);

            lblClave = Estilo.Etiqueta("Contraseña:", 24, 84, 300, 24, 10f, true, ContentAlignment.MiddleLeft);
            pnlTarjeta.Controls.Add(lblClave);

            txtClave = new TextBox();
            txtClave.SetBounds(24, 110, 312, 30);
            txtClave.Font = new Font("Segoe UI", 12f);
            txtClave.UseSystemPasswordChar = true;
            pnlTarjeta.Controls.Add(txtClave);

            chkMostrar = new CheckBox();
            chkMostrar.Text = "Mostrar contraseña";
            chkMostrar.SetBounds(24, 148, 220, 24);
            chkMostrar.CheckedChanged += ChkMostrar_CheckedChanged;
            pnlTarjeta.Controls.Add(chkMostrar);

            btnEntrar = Estilo.Boton("Entrar", 24, 186, 312, 44, Estilo.Principal);
            btnEntrar.Click += BtnEntrar_Click;
            pnlTarjeta.Controls.Add(btnEntrar);

            lblPista = Estilo.Etiqueta("Usuario: Alumno1    Contraseña: Cbtis224", 20, 440, 400, 24, 9f, false, ContentAlignment.MiddleCenter);
            lblPista.ForeColor = Color.DimGray;
            Controls.Add(lblPista);

            btnRegresar = Estilo.Boton("Regresar al menu", 120, 476, 200, 38, Estilo.Oscuro);
            btnRegresar.Click += BtnRegresar_Click;
            Controls.Add(btnRegresar);

            AcceptButton = btnEntrar;
            Shown += FormLogin_Shown;
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
