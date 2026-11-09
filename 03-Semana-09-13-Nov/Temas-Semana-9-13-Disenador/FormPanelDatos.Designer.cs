namespace Temas_Semana_9_13;

partial class FormPanelDatos
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
        this.panel1 = new System.Windows.Forms.Panel();
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.button3 = new System.Windows.Forms.Button();
        this.button4 = new System.Windows.Forms.Button();
        this.panel2 = new System.Windows.Forms.Panel();
        this.lblNombre = new System.Windows.Forms.Label();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.lblCorreo = new System.Windows.Forms.Label();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.lblTitulo = new System.Windows.Forms.Label();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.button1);
        this.panel1.Controls.Add(this.button2);
        this.panel1.Controls.Add(this.button3);
        this.panel1.Controls.Add(this.button4);
        this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.panel1.Location = new System.Drawing.Point(360, 90);
        this.panel1.Size = new System.Drawing.Size(210, 280);
        this.panel1.Name = "panel1";
        this.panel1.TabIndex = 0;
        // 
        // button1
        // 
        this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
        this.button1.ForeColor = System.Drawing.Color.Black;
        this.button1.Location = new System.Drawing.Point(35, 25);
        this.button1.Size = new System.Drawing.Size(135, 42);
        this.button1.Text = "OCULTAR DATOS";
        this.button1.Name = "button1";
        this.button1.TabIndex = 0;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.button2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
        this.button2.ForeColor = System.Drawing.Color.Black;
        this.button2.Location = new System.Drawing.Point(35, 85);
        this.button2.Size = new System.Drawing.Size(135, 42);
        this.button2.Text = "MOSTRAR DATOS";
        this.button2.Name = "button2";
        this.button2.TabIndex = 1;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // button3
        // 
        this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.button3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
        this.button3.ForeColor = System.Drawing.Color.Black;
        this.button3.Location = new System.Drawing.Point(35, 145);
        this.button3.Size = new System.Drawing.Size(135, 42);
        this.button3.Text = "LIMPIAR";
        this.button3.Name = "button3";
        this.button3.TabIndex = 2;
        this.button3.Click += new System.EventHandler(this.button3_Click);
        // 
        // button4
        // 
        this.button4.BackColor = System.Drawing.Color.Red;
        this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.button4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold);
        this.button4.ForeColor = System.Drawing.Color.White;
        this.button4.Location = new System.Drawing.Point(35, 205);
        this.button4.Size = new System.Drawing.Size(135, 42);
        this.button4.Text = "SALIR";
        this.button4.Name = "button4";
        this.button4.TabIndex = 3;
        this.button4.Click += new System.EventHandler(this.button4_Click);
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.lblNombre);
        this.panel2.Controls.Add(this.textBox1);
        this.panel2.Controls.Add(this.lblCorreo);
        this.panel2.Controls.Add(this.textBox2);
        this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
        this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panel2.Location = new System.Drawing.Point(60, 90);
        this.panel2.Size = new System.Drawing.Size(210, 280);
        this.panel2.Name = "panel2";
        this.panel2.TabIndex = 1;
        // 
        // lblNombre
        // 
        this.lblNombre.AutoSize = true;
        this.lblNombre.Font = new System.Drawing.Font("Georgia", 12F);
        this.lblNombre.Location = new System.Drawing.Point(25, 35);
        this.lblNombre.Text = "NOMBRE:";
        this.lblNombre.Name = "lblNombre";
        this.lblNombre.TabIndex = 0;
        // 
        // textBox1
        // 
        this.textBox1.Font = new System.Drawing.Font("Georgia", 11F);
        this.textBox1.Location = new System.Drawing.Point(25, 70);
        this.textBox1.Size = new System.Drawing.Size(160, 25);
        this.textBox1.Name = "textBox1";
        this.textBox1.TabIndex = 1;
        // 
        // lblCorreo
        // 
        this.lblCorreo.AutoSize = true;
        this.lblCorreo.Font = new System.Drawing.Font("Georgia", 12F);
        this.lblCorreo.Location = new System.Drawing.Point(25, 140);
        this.lblCorreo.Text = "CORREO:";
        this.lblCorreo.Name = "lblCorreo";
        this.lblCorreo.TabIndex = 2;
        // 
        // textBox2
        // 
        this.textBox2.Font = new System.Drawing.Font("Georgia", 11F);
        this.textBox2.Location = new System.Drawing.Point(25, 175);
        this.textBox2.Size = new System.Drawing.Size(160, 25);
        this.textBox2.Name = "textBox2";
        this.textBox2.TabIndex = 3;
        // 
        // lblTitulo
        // 
        this.lblTitulo.AutoSize = false;
        this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTitulo.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
        this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
        this.lblTitulo.Size = new System.Drawing.Size(640, 70);
        this.lblTitulo.Text = "INGRESA LOS SIGUIENTES DATOS";
        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.TabIndex = 2;
        // 
        // FormPanelDatos
        // 
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        this.ClientSize = new System.Drawing.Size(640, 420);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.lblTitulo);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "PANEL-DATOS - Escribe aquí tu nombre";
        this.Name = "FormPanelDatos";
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label lblCorreo;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label lblTitulo;
}
