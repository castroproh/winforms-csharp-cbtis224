namespace Temas_Semana_9_13;

partial class FormLoginPymasa
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
        this.panelDer = new System.Windows.Forms.Panel();
        this.lblInicioSesion = new System.Windows.Forms.Label();
        this.lblNombreUsuario = new System.Windows.Forms.Label();
        this.TBUSUARIO = new System.Windows.Forms.TextBox();
        this.lblContra = new System.Windows.Forms.Label();
        this.TBCONTRA = new System.Windows.Forms.TextBox();
        this.BINICIARS = new System.Windows.Forms.Button();
        this.panelIzq = new System.Windows.Forms.Panel();
        this.lblPymasa = new System.Windows.Forms.Label();
        this.lblSistema = new System.Windows.Forms.Label();
        this.lblCiudad = new System.Windows.Forms.Label();
        this.panelDer.SuspendLayout();
        this.panelIzq.SuspendLayout();
        this.SuspendLayout();
        // 
        // panelDer
        // 
        this.panelDer.Controls.Add(this.lblInicioSesion);
        this.panelDer.Controls.Add(this.lblNombreUsuario);
        this.panelDer.Controls.Add(this.TBUSUARIO);
        this.panelDer.Controls.Add(this.lblContra);
        this.panelDer.Controls.Add(this.TBCONTRA);
        this.panelDer.Controls.Add(this.BINICIARS);
        this.panelDer.BackColor = System.Drawing.Color.Yellow;
        this.panelDer.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panelDer.Size = new System.Drawing.Size(340, 380);
        this.panelDer.Name = "panelDer";
        this.panelDer.TabIndex = 0;
        // 
        // lblInicioSesion
        // 
        this.lblInicioSesion.AutoSize = false;
        this.lblInicioSesion.Font = new System.Drawing.Font("Segoe UI", 16F);
        this.lblInicioSesion.Location = new System.Drawing.Point(0, 40);
        this.lblInicioSesion.Size = new System.Drawing.Size(340, 40);
        this.lblInicioSesion.Text = "Inicio de sesión";
        this.lblInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.lblInicioSesion.Name = "lblInicioSesion";
        this.lblInicioSesion.TabIndex = 0;
        // 
        // lblNombreUsuario
        // 
        this.lblNombreUsuario.AutoSize = true;
        this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblNombreUsuario.Location = new System.Drawing.Point(80, 110);
        this.lblNombreUsuario.Text = "Nombre de usuario";
        this.lblNombreUsuario.Name = "lblNombreUsuario";
        this.lblNombreUsuario.TabIndex = 1;
        // 
        // TBUSUARIO
        // 
        this.TBUSUARIO.Location = new System.Drawing.Point(80, 133);
        this.TBUSUARIO.Size = new System.Drawing.Size(180, 23);
        this.TBUSUARIO.Name = "TBUSUARIO";
        this.TBUSUARIO.TabIndex = 2;
        // 
        // lblContra
        // 
        this.lblContra.AutoSize = true;
        this.lblContra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblContra.Location = new System.Drawing.Point(80, 175);
        this.lblContra.Text = "Contraseña";
        this.lblContra.Name = "lblContra";
        this.lblContra.TabIndex = 3;
        // 
        // TBCONTRA
        // 
        this.TBCONTRA.Location = new System.Drawing.Point(80, 198);
        this.TBCONTRA.Size = new System.Drawing.Size(180, 23);
        this.TBCONTRA.UseSystemPasswordChar = true;
        this.TBCONTRA.Name = "TBCONTRA";
        this.TBCONTRA.TabIndex = 4;
        // 
        // BINICIARS
        // 
        this.BINICIARS.BackColor = System.Drawing.Color.White;
        this.BINICIARS.Location = new System.Drawing.Point(80, 260);
        this.BINICIARS.Size = new System.Drawing.Size(180, 36);
        this.BINICIARS.Text = "Iniciar sesión";
        this.BINICIARS.Name = "BINICIARS";
        this.BINICIARS.TabIndex = 5;
        this.BINICIARS.Click += new System.EventHandler(this.BINICIARS_Click);
        // 
        // panelIzq
        // 
        this.panelIzq.Controls.Add(this.lblPymasa);
        this.panelIzq.Controls.Add(this.lblSistema);
        this.panelIzq.Controls.Add(this.lblCiudad);
        this.panelIzq.BackColor = System.Drawing.Color.Black;
        this.panelIzq.Dock = System.Windows.Forms.DockStyle.Left;
        this.panelIzq.Size = new System.Drawing.Size(300, 380);
        this.panelIzq.Name = "panelIzq";
        this.panelIzq.TabIndex = 1;
        // 
        // lblPymasa
        // 
        this.lblPymasa.AutoSize = false;
        this.lblPymasa.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
        this.lblPymasa.ForeColor = System.Drawing.Color.Red;
        this.lblPymasa.Location = new System.Drawing.Point(0, 60);
        this.lblPymasa.Size = new System.Drawing.Size(300, 60);
        this.lblPymasa.Text = "Pymasa";
        this.lblPymasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.lblPymasa.Name = "lblPymasa";
        this.lblPymasa.TabIndex = 0;
        // 
        // lblSistema
        // 
        this.lblSistema.AutoSize = false;
        this.lblSistema.Font = new System.Drawing.Font("Segoe UI", 15F);
        this.lblSistema.ForeColor = System.Drawing.Color.White;
        this.lblSistema.Location = new System.Drawing.Point(0, 150);
        this.lblSistema.Size = new System.Drawing.Size(300, 40);
        this.lblSistema.Text = "Sistema Punto de Venta";
        this.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.lblSistema.Name = "lblSistema";
        this.lblSistema.TabIndex = 1;
        // 
        // lblCiudad
        // 
        this.lblCiudad.AutoSize = false;
        this.lblCiudad.ForeColor = System.Drawing.Color.White;
        this.lblCiudad.Location = new System.Drawing.Point(0, 200);
        this.lblCiudad.Size = new System.Drawing.Size(300, 25);
        this.lblCiudad.Text = "Culiacán, Sinaloa, México";
        this.lblCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.lblCiudad.Name = "lblCiudad";
        this.lblCiudad.TabIndex = 2;
        // 
        // FormLoginPymasa
        // 
        this.AcceptButton = this.BINICIARS;
        this.ClientSize = new System.Drawing.Size(640, 380);
        this.Controls.Add(this.panelDer);
        this.Controls.Add(this.panelIzq);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Inicio de sesión";
        this.Name = "FormLoginPymasa";
        this.Shown += new System.EventHandler(this.FormLoginPymasa_Shown);
        this.panelIzq.ResumeLayout(false);
        this.panelIzq.PerformLayout();
        this.panelDer.ResumeLayout(false);
        this.panelDer.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Panel panelDer;
    private System.Windows.Forms.Label lblInicioSesion;
    private System.Windows.Forms.Label lblNombreUsuario;
    private System.Windows.Forms.TextBox TBUSUARIO;
    private System.Windows.Forms.Label lblContra;
    private System.Windows.Forms.TextBox TBCONTRA;
    private System.Windows.Forms.Button BINICIARS;
    private System.Windows.Forms.Panel panelIzq;
    private System.Windows.Forms.Label lblPymasa;
    private System.Windows.Forms.Label lblSistema;
    private System.Windows.Forms.Label lblCiudad;
}
