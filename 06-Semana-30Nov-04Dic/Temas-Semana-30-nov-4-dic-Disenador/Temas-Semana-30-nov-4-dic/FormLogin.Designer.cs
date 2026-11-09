namespace Temas_Semana_30_nov_4_dic
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTarjeta = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.chkMostrar = new System.Windows.Forms.CheckBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblPista = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pnlTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(170, 24);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabStop = false;
            this.picLogo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(38, 50, 56);
            this.lblTitulo.Location = new System.Drawing.Point(20, 130);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 36);
            this.lblTitulo.Text = "Inicio de sesion";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.TabIndex = 1;
            // 
            // pnlTarjeta
            // 
            this.pnlTarjeta.Controls.Add(this.lblUsuario);
            this.pnlTarjeta.Controls.Add(this.txtUsuario);
            this.pnlTarjeta.Controls.Add(this.lblClave);
            this.pnlTarjeta.Controls.Add(this.txtClave);
            this.pnlTarjeta.Controls.Add(this.chkMostrar);
            this.pnlTarjeta.Controls.Add(this.btnEntrar);
            this.pnlTarjeta.BackColor = System.Drawing.Color.White;
            this.pnlTarjeta.Location = new System.Drawing.Point(40, 180);
            this.pnlTarjeta.Name = "pnlTarjeta";
            this.pnlTarjeta.Size = new System.Drawing.Size(360, 250);
            this.pnlTarjeta.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = false;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(24, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(300, 24);
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.TabIndex = 0;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsuario.Location = new System.Drawing.Point(24, 42);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(312, 30);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = false;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblClave.Location = new System.Drawing.Point(24, 84);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(300, 24);
            this.lblClave.Text = "Contraseña:";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClave.TabIndex = 2;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtClave.Location = new System.Drawing.Point(24, 110);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(312, 30);
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.TabIndex = 3;
            // 
            // chkMostrar
            // 
            this.chkMostrar.Location = new System.Drawing.Point(24, 148);
            this.chkMostrar.Name = "chkMostrar";
            this.chkMostrar.Size = new System.Drawing.Size(220, 24);
            this.chkMostrar.Text = "Mostrar contraseña";
            this.chkMostrar.TabIndex = 4;
            this.chkMostrar.CheckedChanged += new System.EventHandler(this.ChkMostrar_CheckedChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(0, 121, 107);
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(24, 186);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(312, 44);
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // lblPista
            // 
            this.lblPista.AutoSize = false;
            this.lblPista.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPista.ForeColor = System.Drawing.Color.DimGray;
            this.lblPista.Location = new System.Drawing.Point(20, 440);
            this.lblPista.Name = "lblPista";
            this.lblPista.Size = new System.Drawing.Size(400, 24);
            this.lblPista.Text = "Usuario: Alumno1    Contraseña: Cbtis224";
            this.lblPista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPista.TabIndex = 3;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(38, 50, 56);
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(120, 476);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(200, 38);
            this.btnRegresar.Text = "Regresar al menu";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // FormLogin
            // 
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlTarjeta);
            this.Controls.Add(this.lblPista);
            this.Controls.Add(this.btnRegresar);
            this.AcceptButton = this.btnEntrar;
            this.Name = "FormLogin";
            this.Shown += new System.EventHandler(this.FormLogin_Shown);
            this.pnlTarjeta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTarjeta;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.CheckBox chkMostrar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblPista;
        private System.Windows.Forms.Button btnRegresar;
    }
}
