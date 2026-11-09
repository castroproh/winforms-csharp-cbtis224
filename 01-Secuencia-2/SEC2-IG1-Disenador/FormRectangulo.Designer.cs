namespace SEC2_IG1;

partial class FormRectangulo
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
        this.lblBase = new System.Windows.Forms.Label();
        this.txtBase = new System.Windows.Forms.TextBox();
        this.lblAltura = new System.Windows.Forms.Label();
        this.txtAltura = new System.Windows.Forms.TextBox();
        this.btnCalcular = new System.Windows.Forms.Button();
        this.btnLimpiar = new System.Windows.Forms.Button();
        this.lblArea = new System.Windows.Forms.Label();
        this.lblPerimetro = new System.Windows.Forms.Label();
        this.lblFecha = new System.Windows.Forms.Label();
        this.picRectangulo = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.picRectangulo)).BeginInit();
        this.SuspendLayout();
        //
        // lblBase
        //
        this.lblBase.AutoSize = true;
        this.lblBase.Location = new System.Drawing.Point(20, 25);
        this.lblBase.Name = "lblBase";
        this.lblBase.TabIndex = 0;
        this.lblBase.Text = "Base (1 a 50):";
        //
        // txtBase
        //
        this.txtBase.Location = new System.Drawing.Point(130, 21);
        this.txtBase.MaxLength = 2;
        this.txtBase.Name = "txtBase";
        this.txtBase.Size = new System.Drawing.Size(100, 23);
        this.txtBase.TabIndex = 1;
        //
        // lblAltura
        //
        this.lblAltura.AutoSize = true;
        this.lblAltura.Location = new System.Drawing.Point(20, 65);
        this.lblAltura.Name = "lblAltura";
        this.lblAltura.TabIndex = 2;
        this.lblAltura.Text = "Altura (1 a 50):";
        //
        // txtAltura
        //
        this.txtAltura.Location = new System.Drawing.Point(130, 61);
        this.txtAltura.MaxLength = 2;
        this.txtAltura.Name = "txtAltura";
        this.txtAltura.Size = new System.Drawing.Size(100, 23);
        this.txtAltura.TabIndex = 3;
        //
        // btnCalcular
        //
        this.btnCalcular.Location = new System.Drawing.Point(20, 105);
        this.btnCalcular.Name = "btnCalcular";
        this.btnCalcular.Size = new System.Drawing.Size(100, 32);
        this.btnCalcular.TabIndex = 4;
        this.btnCalcular.Text = "Calcular";
        this.btnCalcular.UseVisualStyleBackColor = true;
        this.btnCalcular.Click += new System.EventHandler(this.Calcular);
        //
        // btnLimpiar
        //
        this.btnLimpiar.Location = new System.Drawing.Point(130, 105);
        this.btnLimpiar.Name = "btnLimpiar";
        this.btnLimpiar.Size = new System.Drawing.Size(100, 32);
        this.btnLimpiar.TabIndex = 5;
        this.btnLimpiar.Text = "Limpiar";
        this.btnLimpiar.UseVisualStyleBackColor = true;
        this.btnLimpiar.Click += new System.EventHandler(this.Limpiar);
        //
        // lblArea
        //
        this.lblArea.AutoSize = true;
        this.lblArea.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblArea.Location = new System.Drawing.Point(20, 165);
        this.lblArea.Name = "lblArea";
        this.lblArea.TabIndex = 6;
        this.lblArea.Text = "Área: ";
        //
        // lblPerimetro
        //
        this.lblPerimetro.AutoSize = true;
        this.lblPerimetro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblPerimetro.Location = new System.Drawing.Point(20, 200);
        this.lblPerimetro.Name = "lblPerimetro";
        this.lblPerimetro.TabIndex = 7;
        this.lblPerimetro.Text = "Perímetro: ";
        //
        // lblFecha
        //
        this.lblFecha.AutoSize = true;
        this.lblFecha.ForeColor = System.Drawing.Color.DimGray;
        this.lblFecha.Location = new System.Drawing.Point(20, 250);
        this.lblFecha.Name = "lblFecha";
        this.lblFecha.TabIndex = 8;
        //
        // picRectangulo
        //
        this.picRectangulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.picRectangulo.Location = new System.Drawing.Point(280, 20);
        this.picRectangulo.Name = "picRectangulo";
        this.picRectangulo.Size = new System.Drawing.Size(260, 290);
        this.picRectangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        this.picRectangulo.TabIndex = 9;
        this.picRectangulo.TabStop = false;
        //
        // FormRectangulo
        //
        this.ClientSize = new System.Drawing.Size(560, 330);
        this.Controls.Add(this.lblBase);
        this.Controls.Add(this.txtBase);
        this.Controls.Add(this.lblAltura);
        this.Controls.Add(this.txtAltura);
        this.Controls.Add(this.btnCalcular);
        this.Controls.Add(this.btnLimpiar);
        this.Controls.Add(this.lblArea);
        this.Controls.Add(this.lblPerimetro);
        this.Controls.Add(this.lblFecha);
        this.Controls.Add(this.picRectangulo);
        this.Name = "FormRectangulo";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Rectángulo";
        this.Shown += new System.EventHandler(this.FormRectangulo_Shown);
        ((System.ComponentModel.ISupportInitialize)(this.picRectangulo)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblBase;
    private System.Windows.Forms.TextBox txtBase;
    private System.Windows.Forms.Label lblAltura;
    private System.Windows.Forms.TextBox txtAltura;
    private System.Windows.Forms.Button btnCalcular;
    private System.Windows.Forms.Button btnLimpiar;
    private System.Windows.Forms.Label lblArea;
    private System.Windows.Forms.Label lblPerimetro;
    private System.Windows.Forms.Label lblFecha;
    private System.Windows.Forms.PictureBox picRectangulo;
}
