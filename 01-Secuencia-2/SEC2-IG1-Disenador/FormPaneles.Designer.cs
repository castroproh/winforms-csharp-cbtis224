namespace SEC2_IG1;

partial class FormPaneles
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
        this.btnImagen = new System.Windows.Forms.Button();
        this.btnSuma = new System.Windows.Forms.Button();
        this.btnOcultar = new System.Windows.Forms.Button();
        this.pnlImagen = new System.Windows.Forms.Panel();
        this.pic = new System.Windows.Forms.PictureBox();
        this.pnlSuma = new System.Windows.Forms.Panel();
        this.lblA = new System.Windows.Forms.Label();
        this.txtA = new System.Windows.Forms.TextBox();
        this.lblB = new System.Windows.Forms.Label();
        this.txtB = new System.Windows.Forms.TextBox();
        this.btnSumar = new System.Windows.Forms.Button();
        this.lblResultado = new System.Windows.Forms.Label();
        this.pnlImagen.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
        this.pnlSuma.SuspendLayout();
        this.SuspendLayout();
        //
        // btnImagen
        //
        this.btnImagen.Location = new System.Drawing.Point(20, 14);
        this.btnImagen.Name = "btnImagen";
        this.btnImagen.Size = new System.Drawing.Size(150, 32);
        this.btnImagen.TabIndex = 0;
        this.btnImagen.Text = "Mostrar imagen";
        this.btnImagen.UseVisualStyleBackColor = true;
        this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
        //
        // btnSuma
        //
        this.btnSuma.Location = new System.Drawing.Point(180, 14);
        this.btnSuma.Name = "btnSuma";
        this.btnSuma.Size = new System.Drawing.Size(150, 32);
        this.btnSuma.TabIndex = 1;
        this.btnSuma.Text = "Mostrar suma";
        this.btnSuma.UseVisualStyleBackColor = true;
        this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
        //
        // btnOcultar
        //
        this.btnOcultar.Location = new System.Drawing.Point(340, 14);
        this.btnOcultar.Name = "btnOcultar";
        this.btnOcultar.Size = new System.Drawing.Size(150, 32);
        this.btnOcultar.TabIndex = 2;
        this.btnOcultar.Text = "Ocultar todo";
        this.btnOcultar.UseVisualStyleBackColor = true;
        this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
        //
        // pnlImagen
        //
        this.pnlImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlImagen.Controls.Add(this.pic);
        this.pnlImagen.Location = new System.Drawing.Point(20, 60);
        this.pnlImagen.Name = "pnlImagen";
        this.pnlImagen.Size = new System.Drawing.Size(480, 280);
        this.pnlImagen.TabIndex = 3;
        this.pnlImagen.Visible = false;
        //
        // pic
        //
        this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pic.Location = new System.Drawing.Point(0, 0);
        this.pic.Name = "pic";
        this.pic.Size = new System.Drawing.Size(478, 278);
        this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pic.TabIndex = 0;
        this.pic.TabStop = false;
        //
        // pnlSuma
        //
        this.pnlSuma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlSuma.Controls.Add(this.lblA);
        this.pnlSuma.Controls.Add(this.txtA);
        this.pnlSuma.Controls.Add(this.lblB);
        this.pnlSuma.Controls.Add(this.txtB);
        this.pnlSuma.Controls.Add(this.btnSumar);
        this.pnlSuma.Controls.Add(this.lblResultado);
        this.pnlSuma.Location = new System.Drawing.Point(20, 60);
        this.pnlSuma.Name = "pnlSuma";
        this.pnlSuma.Size = new System.Drawing.Size(480, 280);
        this.pnlSuma.TabIndex = 4;
        this.pnlSuma.Visible = false;
        //
        // lblA
        //
        this.lblA.AutoSize = true;
        this.lblA.Location = new System.Drawing.Point(40, 40);
        this.lblA.Name = "lblA";
        this.lblA.TabIndex = 0;
        this.lblA.Text = "Número 1:";
        //
        // txtA
        //
        this.txtA.Location = new System.Drawing.Point(130, 36);
        this.txtA.Name = "txtA";
        this.txtA.Size = new System.Drawing.Size(120, 23);
        this.txtA.TabIndex = 1;
        //
        // lblB
        //
        this.lblB.AutoSize = true;
        this.lblB.Location = new System.Drawing.Point(40, 85);
        this.lblB.Name = "lblB";
        this.lblB.TabIndex = 2;
        this.lblB.Text = "Número 2:";
        //
        // txtB
        //
        this.txtB.Location = new System.Drawing.Point(130, 81);
        this.txtB.Name = "txtB";
        this.txtB.Size = new System.Drawing.Size(120, 23);
        this.txtB.TabIndex = 3;
        //
        // btnSumar
        //
        this.btnSumar.Location = new System.Drawing.Point(130, 130);
        this.btnSumar.Name = "btnSumar";
        this.btnSumar.Size = new System.Drawing.Size(120, 32);
        this.btnSumar.TabIndex = 4;
        this.btnSumar.Text = "Sumar";
        this.btnSumar.UseVisualStyleBackColor = true;
        this.btnSumar.Click += new System.EventHandler(this.Sumar);
        //
        // lblResultado
        //
        this.lblResultado.AutoSize = true;
        this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.lblResultado.Location = new System.Drawing.Point(40, 190);
        this.lblResultado.Name = "lblResultado";
        this.lblResultado.TabIndex = 5;
        this.lblResultado.Text = "Resultado: ";
        //
        // FormPaneles
        //
        this.ClientSize = new System.Drawing.Size(520, 360);
        this.Controls.Add(this.btnImagen);
        this.Controls.Add(this.btnSuma);
        this.Controls.Add(this.btnOcultar);
        this.Controls.Add(this.pnlImagen);
        this.Controls.Add(this.pnlSuma);
        this.Name = "FormPaneles";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Paneles";
        this.pnlImagen.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
        this.pnlSuma.ResumeLayout(false);
        this.pnlSuma.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnImagen;
    private System.Windows.Forms.Button btnSuma;
    private System.Windows.Forms.Button btnOcultar;
    private System.Windows.Forms.Panel pnlImagen;
    private System.Windows.Forms.PictureBox pic;
    private System.Windows.Forms.Panel pnlSuma;
    private System.Windows.Forms.Label lblA;
    private System.Windows.Forms.TextBox txtA;
    private System.Windows.Forms.Label lblB;
    private System.Windows.Forms.TextBox txtB;
    private System.Windows.Forms.Button btnSumar;
    private System.Windows.Forms.Label lblResultado;
}
