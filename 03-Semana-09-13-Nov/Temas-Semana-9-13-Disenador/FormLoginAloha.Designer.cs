namespace Temas_Semana_9_13;

partial class FormLoginAloha
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
        this.lblTitulo = new System.Windows.Forms.Label();
        this.imagen = new System.Windows.Forms.PictureBox();
        this.lblUsuario = new System.Windows.Forms.Label();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.lblClave = new System.Windows.Forms.Label();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.btnIngresar = new System.Windows.Forms.Button();
        this.btnVolver = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
        this.SuspendLayout();
        // 
        // lblTitulo
        // 
        this.lblTitulo.AutoSize = false;
        this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTitulo.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
        this.lblTitulo.ForeColor = System.Drawing.Color.White;
        this.lblTitulo.Size = new System.Drawing.Size(600, 60);
        this.lblTitulo.Text = "Bienvenido al sistema de Aloha agencia";
        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.TabIndex = 0;
        // 
        // imagen
        // 
        this.imagen.Location = new System.Drawing.Point(245, 70);
        this.imagen.Size = new System.Drawing.Size(110, 110);
        this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        this.imagen.Name = "imagen";
        this.imagen.TabIndex = 1;
        // 
        // lblUsuario
        // 
        this.lblUsuario.AutoSize = false;
        this.lblUsuario.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
        this.lblUsuario.ForeColor = System.Drawing.Color.White;
        this.lblUsuario.Location = new System.Drawing.Point(200, 205);
        this.lblUsuario.Size = new System.Drawing.Size(200, 22);
        this.lblUsuario.Text = "USUARIO";
        this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.lblUsuario.Name = "lblUsuario";
        this.lblUsuario.TabIndex = 2;
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(200, 230);
        this.textBox1.Size = new System.Drawing.Size(200, 23);
        this.textBox1.Name = "textBox1";
        this.textBox1.TabIndex = 3;
        // 
        // lblClave
        // 
        this.lblClave.AutoSize = false;
        this.lblClave.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
        this.lblClave.ForeColor = System.Drawing.Color.White;
        this.lblClave.Location = new System.Drawing.Point(200, 270);
        this.lblClave.Size = new System.Drawing.Size(200, 22);
        this.lblClave.Text = "CONTRASEÑA";
        this.lblClave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.lblClave.Name = "lblClave";
        this.lblClave.TabIndex = 4;
        // 
        // textBox2
        // 
        this.textBox2.Location = new System.Drawing.Point(200, 295);
        this.textBox2.Size = new System.Drawing.Size(200, 23);
        this.textBox2.UseSystemPasswordChar = true;
        this.textBox2.Name = "textBox2";
        this.textBox2.TabIndex = 5;
        // 
        // btnIngresar
        // 
        this.btnIngresar.BackColor = System.Drawing.Color.White;
        this.btnIngresar.Location = new System.Drawing.Point(150, 355);
        this.btnIngresar.Size = new System.Drawing.Size(130, 34);
        this.btnIngresar.Text = "INGRESAR";
        this.btnIngresar.Name = "btnIngresar";
        this.btnIngresar.TabIndex = 6;
        this.btnIngresar.Click += new System.EventHandler(this.Ingresar);
        // 
        // btnVolver
        // 
        this.btnVolver.BackColor = System.Drawing.Color.White;
        this.btnVolver.Location = new System.Drawing.Point(320, 355);
        this.btnVolver.Size = new System.Drawing.Size(130, 34);
        this.btnVolver.Text = "VOLVER";
        this.btnVolver.Name = "btnVolver";
        this.btnVolver.TabIndex = 7;
        this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
        // 
        // FormLoginAloha
        // 
        this.AcceptButton = this.btnIngresar;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.ClientSize = new System.Drawing.Size(600, 440);
        this.Controls.Add(this.lblTitulo);
        this.Controls.Add(this.imagen);
        this.Controls.Add(this.lblUsuario);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.lblClave);
        this.Controls.Add(this.textBox2);
        this.Controls.Add(this.btnIngresar);
        this.Controls.Add(this.btnVolver);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Aloha agencia - Usuario y contraseña";
        this.Name = "FormLoginAloha";
        this.Shown += new System.EventHandler(this.FormLoginAloha_Shown);
        ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.PictureBox imagen;
    private System.Windows.Forms.Label lblUsuario;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label lblClave;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button btnIngresar;
    private System.Windows.Forms.Button btnVolver;
}
