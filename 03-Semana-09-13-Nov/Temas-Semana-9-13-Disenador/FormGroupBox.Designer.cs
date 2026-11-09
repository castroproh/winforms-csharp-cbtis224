namespace Temas_Semana_9_13;

partial class FormGroupBox
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
        this.rbFueraChihuahua = new System.Windows.Forms.RadioButton();
        this.rbFueraSinaloa = new System.Windows.Forms.RadioButton();
        this.rbFueraPuebla = new System.Windows.Forms.RadioButton();
        this.rbFueraQueretaro = new System.Windows.Forms.RadioButton();
        this.grupo = new System.Windows.Forms.GroupBox();
        this.rbDentroChihuahua = new System.Windows.Forms.RadioButton();
        this.rbDentroSinaloa = new System.Windows.Forms.RadioButton();
        this.rbDentroPuebla = new System.Windows.Forms.RadioButton();
        this.rbDentroQueretaro = new System.Windows.Forms.RadioButton();
        this.lblFueraTitulo = new System.Windows.Forms.Label();
        this.lblDentro = new System.Windows.Forms.Label();
        this.lblFuera = new System.Windows.Forms.Label();
        this.grupo.SuspendLayout();
        this.SuspendLayout();
        // 
        // rbFueraChihuahua
        // 
        this.rbFueraChihuahua.AutoSize = true;
        this.rbFueraChihuahua.Location = new System.Drawing.Point(320, 55);
        this.rbFueraChihuahua.Text = "Chihuahua";
        this.rbFueraChihuahua.Name = "rbFueraChihuahua";
        this.rbFueraChihuahua.TabIndex = 0;
        this.rbFueraChihuahua.CheckedChanged += new System.EventHandler(this.Seleccion);
        // 
        // rbFueraSinaloa
        // 
        this.rbFueraSinaloa.AutoSize = true;
        this.rbFueraSinaloa.Location = new System.Drawing.Point(320, 87);
        this.rbFueraSinaloa.Text = "Sinaloa";
        this.rbFueraSinaloa.Name = "rbFueraSinaloa";
        this.rbFueraSinaloa.TabIndex = 1;
        this.rbFueraSinaloa.CheckedChanged += new System.EventHandler(this.Seleccion);
        // 
        // rbFueraPuebla
        // 
        this.rbFueraPuebla.AutoSize = true;
        this.rbFueraPuebla.Location = new System.Drawing.Point(320, 119);
        this.rbFueraPuebla.Text = "Puebla";
        this.rbFueraPuebla.Name = "rbFueraPuebla";
        this.rbFueraPuebla.TabIndex = 2;
        this.rbFueraPuebla.CheckedChanged += new System.EventHandler(this.Seleccion);
        // 
        // rbFueraQueretaro
        // 
        this.rbFueraQueretaro.AutoSize = true;
        this.rbFueraQueretaro.Location = new System.Drawing.Point(320, 151);
        this.rbFueraQueretaro.Text = "Querétaro";
        this.rbFueraQueretaro.Name = "rbFueraQueretaro";
        this.rbFueraQueretaro.TabIndex = 3;
        this.rbFueraQueretaro.CheckedChanged += new System.EventHandler(this.Seleccion);
        // 
        // grupo
        // 
        this.grupo.Controls.Add(this.rbDentroChihuahua);
        this.grupo.Controls.Add(this.rbDentroSinaloa);
        this.grupo.Controls.Add(this.rbDentroPuebla);
        this.grupo.Controls.Add(this.rbDentroQueretaro);
        this.grupo.BackColor = System.Drawing.Color.Tomato;
        this.grupo.ForeColor = System.Drawing.Color.White;
        this.grupo.Location = new System.Drawing.Point(30, 30);
        this.grupo.Size = new System.Drawing.Size(220, 170);
        this.grupo.Text = "Estado:";
        this.grupo.Name = "grupo";
        this.grupo.TabIndex = 4;
        // 
        // rbDentroChihuahua
        // 
        this.rbDentroChihuahua.AutoSize = true;
        this.rbDentroChihuahua.Location = new System.Drawing.Point(20, 30);
        this.rbDentroChihuahua.Text = "Chihuahua";
        this.rbDentroChihuahua.Name = "rbDentroChihuahua";
        this.rbDentroChihuahua.TabIndex = 0;
        this.rbDentroChihuahua.CheckedChanged += new System.EventHandler(this.Seleccion);
        // 
        // rbDentroSinaloa
        // 
        this.rbDentroSinaloa.AutoSize = true;
        this.rbDentroSinaloa.Location = new System.Drawing.Point(20, 62);
        this.rbDentroSinaloa.Text = "Sinaloa";
        this.rbDentroSinaloa.Name = "rbDentroSinaloa";
        this.rbDentroSinaloa.TabIndex = 1;
        this.rbDentroSinaloa.CheckedChanged += new System.EventHandler(this.Seleccion);
        // 
        // rbDentroPuebla
        // 
        this.rbDentroPuebla.AutoSize = true;
        this.rbDentroPuebla.Location = new System.Drawing.Point(20, 94);
        this.rbDentroPuebla.Text = "Puebla";
        this.rbDentroPuebla.Name = "rbDentroPuebla";
        this.rbDentroPuebla.TabIndex = 2;
        this.rbDentroPuebla.CheckedChanged += new System.EventHandler(this.Seleccion);
        // 
        // rbDentroQueretaro
        // 
        this.rbDentroQueretaro.AutoSize = true;
        this.rbDentroQueretaro.Location = new System.Drawing.Point(20, 126);
        this.rbDentroQueretaro.Text = "Querétaro";
        this.rbDentroQueretaro.Name = "rbDentroQueretaro";
        this.rbDentroQueretaro.TabIndex = 3;
        this.rbDentroQueretaro.CheckedChanged += new System.EventHandler(this.Seleccion);
        // 
        // lblFueraTitulo
        // 
        this.lblFueraTitulo.AutoSize = true;
        this.lblFueraTitulo.Location = new System.Drawing.Point(320, 30);
        this.lblFueraTitulo.Text = "Fuera del GroupBox:";
        this.lblFueraTitulo.Name = "lblFueraTitulo";
        this.lblFueraTitulo.TabIndex = 5;
        // 
        // lblDentro
        // 
        this.lblDentro.AutoSize = true;
        this.lblDentro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblDentro.Location = new System.Drawing.Point(30, 230);
        this.lblDentro.Text = "Dentro del GroupBox: (ninguno)";
        this.lblDentro.Name = "lblDentro";
        this.lblDentro.TabIndex = 6;
        // 
        // lblFuera
        // 
        this.lblFuera.AutoSize = true;
        this.lblFuera.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblFuera.Location = new System.Drawing.Point(30, 260);
        this.lblFuera.Text = "Fuera del GroupBox: (ninguno)";
        this.lblFuera.Name = "lblFuera";
        this.lblFuera.TabIndex = 7;
        // 
        // FormGroupBox
        // 
        this.ClientSize = new System.Drawing.Size(600, 320);
        this.Controls.Add(this.rbFueraChihuahua);
        this.Controls.Add(this.rbFueraSinaloa);
        this.Controls.Add(this.rbFueraPuebla);
        this.Controls.Add(this.rbFueraQueretaro);
        this.Controls.Add(this.grupo);
        this.Controls.Add(this.lblFueraTitulo);
        this.Controls.Add(this.lblDentro);
        this.Controls.Add(this.lblFuera);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "GroupBox";
        this.Name = "FormGroupBox";
        this.grupo.ResumeLayout(false);
        this.grupo.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.RadioButton rbFueraChihuahua;
    private System.Windows.Forms.RadioButton rbFueraSinaloa;
    private System.Windows.Forms.RadioButton rbFueraPuebla;
    private System.Windows.Forms.RadioButton rbFueraQueretaro;
    private System.Windows.Forms.GroupBox grupo;
    private System.Windows.Forms.RadioButton rbDentroChihuahua;
    private System.Windows.Forms.RadioButton rbDentroSinaloa;
    private System.Windows.Forms.RadioButton rbDentroPuebla;
    private System.Windows.Forms.RadioButton rbDentroQueretaro;
    private System.Windows.Forms.Label lblFueraTitulo;
    private System.Windows.Forms.Label lblDentro;
    private System.Windows.Forms.Label lblFuera;
}
