namespace SEC2_IG1;

partial class FormFechas
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
        this.components = new System.ComponentModel.Container();
        this.lblIndicacion = new System.Windows.Forms.Label();
        this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
        this.btnCalcular = new System.Windows.Forms.Button();
        this.lblResultado = new System.Windows.Forms.Label();
        this.lnkAyuda = new System.Windows.Forms.LinkLabel();
        this.toolTip = new System.Windows.Forms.ToolTip(this.components);
        this.SuspendLayout();
        //
        // lblIndicacion
        //
        this.lblIndicacion.AutoSize = true;
        this.lblIndicacion.Location = new System.Drawing.Point(30, 25);
        this.lblIndicacion.Name = "lblIndicacion";
        this.lblIndicacion.TabIndex = 0;
        this.lblIndicacion.Text = "Elige tu fecha de nacimiento:";
        //
        // dtpNacimiento
        //
        this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Long;
        this.dtpNacimiento.Location = new System.Drawing.Point(30, 55);
        this.dtpNacimiento.Name = "dtpNacimiento";
        this.dtpNacimiento.Size = new System.Drawing.Size(220, 23);
        this.dtpNacimiento.TabIndex = 1;
        this.dtpNacimiento.Value = new System.DateTime(2008, 1, 1, 0, 0, 0, 0);
        this.toolTip.SetToolTip(this.dtpNacimiento, "Haz clic para elegir la fecha");
        //
        // btnCalcular
        //
        this.btnCalcular.Location = new System.Drawing.Point(270, 52);
        this.btnCalcular.Name = "btnCalcular";
        this.btnCalcular.Size = new System.Drawing.Size(140, 30);
        this.btnCalcular.TabIndex = 2;
        this.btnCalcular.Text = "Calcular edad";
        this.toolTip.SetToolTip(this.btnCalcular, "Calcula tu edad y los días vividos");
        this.btnCalcular.UseVisualStyleBackColor = true;
        this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
        //
        // lblResultado
        //
        this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblResultado.Location = new System.Drawing.Point(30, 110);
        this.lblResultado.Name = "lblResultado";
        this.lblResultado.Size = new System.Drawing.Size(400, 80);
        this.lblResultado.TabIndex = 3;
        //
        // lnkAyuda
        //
        this.lnkAyuda.AutoSize = true;
        this.lnkAyuda.Location = new System.Drawing.Point(30, 220);
        this.lnkAyuda.Name = "lnkAyuda";
        this.lnkAyuda.TabIndex = 4;
        this.lnkAyuda.TabStop = true;
        this.lnkAyuda.Text = "Documentación de Windows Forms";
        this.toolTip.SetToolTip(this.lnkAyuda, "Abre la página en tu navegador");
        this.lnkAyuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAyuda_LinkClicked);
        //
        // FormFechas
        //
        this.ClientSize = new System.Drawing.Size(460, 300);
        this.Controls.Add(this.lblIndicacion);
        this.Controls.Add(this.dtpNacimiento);
        this.Controls.Add(this.btnCalcular);
        this.Controls.Add(this.lblResultado);
        this.Controls.Add(this.lnkAyuda);
        this.Name = "FormFechas";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Fechas y enlaces";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblIndicacion;
    private System.Windows.Forms.DateTimePicker dtpNacimiento;
    private System.Windows.Forms.Button btnCalcular;
    private System.Windows.Forms.Label lblResultado;
    private System.Windows.Forms.LinkLabel lnkAyuda;
    private System.Windows.Forms.ToolTip toolTip;
}
