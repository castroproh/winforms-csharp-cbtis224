namespace Temas_Semana_9_13;

partial class FormBienvenida
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
        this.btnCerrar = new System.Windows.Forms.Button();
        this.lblUsuario = new System.Windows.Forms.Label();
        this.lblTitulo = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // btnCerrar
        // 
        this.btnCerrar.BackColor = System.Drawing.Color.Yellow;
        this.btnCerrar.Location = new System.Drawing.Point(180, 210);
        this.btnCerrar.Size = new System.Drawing.Size(160, 40);
        this.btnCerrar.Text = "Cerrar sesión";
        this.btnCerrar.Name = "btnCerrar";
        this.btnCerrar.TabIndex = 0;
        this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
        // 
        // lblUsuario
        // 
        this.lblUsuario.AutoSize = false;
        this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 13F);
        this.lblUsuario.ForeColor = System.Drawing.Color.Yellow;
        this.lblUsuario.Size = new System.Drawing.Size(520, 90);
        this.lblUsuario.Text = "lblUsuario";
        this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.lblUsuario.Name = "lblUsuario";
        this.lblUsuario.TabIndex = 1;
        // 
        // lblTitulo
        // 
        this.lblTitulo.AutoSize = false;
        this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        this.lblTitulo.ForeColor = System.Drawing.Color.White;
        this.lblTitulo.Size = new System.Drawing.Size(520, 90);
        this.lblTitulo.Text = "lblTitulo";
        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.TabIndex = 2;
        // 
        // FormBienvenida
        // 
        this.BackColor = System.Drawing.Color.Black;
        this.ClientSize = new System.Drawing.Size(520, 280);
        this.Controls.Add(this.btnCerrar);
        this.Controls.Add(this.lblUsuario);
        this.Controls.Add(this.lblTitulo);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "FormBienvenida";
        this.Name = "FormBienvenida";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Button btnCerrar;
    private System.Windows.Forms.Label lblUsuario;
    private System.Windows.Forms.Label lblTitulo;
}
