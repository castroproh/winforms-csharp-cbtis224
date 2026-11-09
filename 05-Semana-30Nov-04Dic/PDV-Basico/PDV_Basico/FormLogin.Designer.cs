namespace PDV
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.TBUSUARIO = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.TBCONTRA = new System.Windows.Forms.TextBox();
            this.BINICIARS = new System.Windows.Forms.Button();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Name = "panelTop";
            this.panelTop.BackColor = System.Drawing.Color.Black;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Size = new System.Drawing.Size(420, 80);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 22);
            this.lblTitulo.Text = "Pymasa  -  Inicio de sesión";
            this.lblTitulo.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(40, 110);
            this.lblUsuario.Text = "Nombre de usuario";
            this.lblUsuario.TabIndex = 2;
            // 
            // TBUSUARIO
            // 
            this.TBUSUARIO.Name = "TBUSUARIO";
            this.TBUSUARIO.Location = new System.Drawing.Point(40, 136);
            this.TBUSUARIO.Size = new System.Drawing.Size(340, 23);
            this.TBUSUARIO.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBUSUARIO.TabIndex = 3;
            // 
            // lblContra
            // 
            this.lblContra.Name = "lblContra";
            this.lblContra.AutoSize = true;
            this.lblContra.BackColor = System.Drawing.Color.Transparent;
            this.lblContra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContra.ForeColor = System.Drawing.Color.Black;
            this.lblContra.Location = new System.Drawing.Point(40, 186);
            this.lblContra.Text = "Contraseña";
            this.lblContra.TabIndex = 4;
            // 
            // TBCONTRA
            // 
            this.TBCONTRA.Name = "TBCONTRA";
            this.TBCONTRA.Location = new System.Drawing.Point(40, 212);
            this.TBCONTRA.Size = new System.Drawing.Size(340, 23);
            this.TBCONTRA.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBCONTRA.UseSystemPasswordChar = true;
            this.TBCONTRA.TabIndex = 5;
            // 
            // BINICIARS
            // 
            this.BINICIARS.Name = "BINICIARS";
            this.BINICIARS.BackColor = System.Drawing.Color.Black;
            this.BINICIARS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BINICIARS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BINICIARS.ForeColor = System.Drawing.Color.Yellow;
            this.BINICIARS.Location = new System.Drawing.Point(40, 270);
            this.BINICIARS.Size = new System.Drawing.Size(340, 46);
            this.BINICIARS.Text = "Iniciar sesión";
            this.BINICIARS.UseVisualStyleBackColor = false;
            this.BINICIARS.TabIndex = 6;
            this.BINICIARS.Click += new System.EventHandler(this.BINICIARS_Click);
            // 
            // lblAyuda
            // 
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.BackColor = System.Drawing.Color.Transparent;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAyuda.ForeColor = System.Drawing.Color.Black;
            this.lblAyuda.Location = new System.Drawing.Point(40, 332);
            this.lblAyuda.Text = "Usuario: Alumno1     Contraseña: Cbtis224";
            this.lblAyuda.TabIndex = 7;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AcceptButton = this.BINICIARS;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(420, 380);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.Controls.Add(this.panelTop);
            this.panelTop.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.TBUSUARIO);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.TBCONTRA);
            this.Controls.Add(this.BINICIARS);
            this.Controls.Add(this.lblAyuda);
            this.Name = "FormLogin";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox TBUSUARIO;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox TBCONTRA;
        private System.Windows.Forms.Button BINICIARS;
        private System.Windows.Forms.Label lblAyuda;
    }
}
