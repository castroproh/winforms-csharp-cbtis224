namespace SEC2_IG1;

partial class FormControles
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
        this.lblCarrera = new System.Windows.Forms.Label();
        this.cmbCarrera = new System.Windows.Forms.ComboBox();
        this.lblSemestre = new System.Windows.Forms.Label();
        this.nudSemestre = new System.Windows.Forms.NumericUpDown();
        this.grpTurno = new System.Windows.Forms.GroupBox();
        this.rbMatutino = new System.Windows.Forms.RadioButton();
        this.rbVespertino = new System.Windows.Forms.RadioButton();
        this.grpExtras = new System.Windows.Forms.GroupBox();
        this.chkLaptop = new System.Windows.Forms.CheckBox();
        this.chkInternet = new System.Windows.Forms.CheckBox();
        this.btnAgregar = new System.Windows.Forms.Button();
        this.btnQuitar = new System.Windows.Forms.Button();
        this.lstRegistros = new System.Windows.Forms.ListBox();
        ((System.ComponentModel.ISupportInitialize)(this.nudSemestre)).BeginInit();
        this.grpTurno.SuspendLayout();
        this.grpExtras.SuspendLayout();
        this.SuspendLayout();
        //
        // lblCarrera
        //
        this.lblCarrera.AutoSize = true;
        this.lblCarrera.Location = new System.Drawing.Point(20, 25);
        this.lblCarrera.Name = "lblCarrera";
        this.lblCarrera.TabIndex = 0;
        this.lblCarrera.Text = "Carrera:";
        //
        // cmbCarrera
        //
        this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbCarrera.Items.AddRange(new object[] {
        "Programación",
        "Contabilidad",
        "Electrónica",
        "Ofimática"});
        this.cmbCarrera.Location = new System.Drawing.Point(100, 21);
        this.cmbCarrera.Name = "cmbCarrera";
        this.cmbCarrera.SelectedIndex = 0;
        this.cmbCarrera.Size = new System.Drawing.Size(200, 23);
        this.cmbCarrera.TabIndex = 1;
        //
        // lblSemestre
        //
        this.lblSemestre.AutoSize = true;
        this.lblSemestre.Location = new System.Drawing.Point(20, 65);
        this.lblSemestre.Name = "lblSemestre";
        this.lblSemestre.TabIndex = 2;
        this.lblSemestre.Text = "Semestre:";
        //
        // nudSemestre
        //
        this.nudSemestre.Location = new System.Drawing.Point(100, 61);
        this.nudSemestre.Maximum = new decimal(new int[] {
        6,
        0,
        0,
        0});
        this.nudSemestre.Minimum = new decimal(new int[] {
        1,
        0,
        0,
        0});
        this.nudSemestre.Name = "nudSemestre";
        this.nudSemestre.Size = new System.Drawing.Size(80, 23);
        this.nudSemestre.TabIndex = 3;
        this.nudSemestre.Value = new decimal(new int[] {
        1,
        0,
        0,
        0});
        //
        // grpTurno
        //
        this.grpTurno.Controls.Add(this.rbMatutino);
        this.grpTurno.Controls.Add(this.rbVespertino);
        this.grpTurno.Location = new System.Drawing.Point(20, 105);
        this.grpTurno.Name = "grpTurno";
        this.grpTurno.Size = new System.Drawing.Size(280, 60);
        this.grpTurno.TabIndex = 4;
        this.grpTurno.TabStop = false;
        this.grpTurno.Text = "Turno";
        //
        // rbMatutino
        //
        this.rbMatutino.AutoSize = true;
        this.rbMatutino.Checked = true;
        this.rbMatutino.Location = new System.Drawing.Point(20, 25);
        this.rbMatutino.Name = "rbMatutino";
        this.rbMatutino.TabIndex = 0;
        this.rbMatutino.TabStop = true;
        this.rbMatutino.Text = "Matutino";
        this.rbMatutino.UseVisualStyleBackColor = true;
        //
        // rbVespertino
        //
        this.rbVespertino.AutoSize = true;
        this.rbVespertino.Location = new System.Drawing.Point(140, 25);
        this.rbVespertino.Name = "rbVespertino";
        this.rbVespertino.TabIndex = 1;
        this.rbVespertino.Text = "Vespertino";
        this.rbVespertino.UseVisualStyleBackColor = true;
        //
        // grpExtras
        //
        this.grpExtras.Controls.Add(this.chkLaptop);
        this.grpExtras.Controls.Add(this.chkInternet);
        this.grpExtras.Location = new System.Drawing.Point(20, 180);
        this.grpExtras.Name = "grpExtras";
        this.grpExtras.Size = new System.Drawing.Size(280, 60);
        this.grpExtras.TabIndex = 5;
        this.grpExtras.TabStop = false;
        this.grpExtras.Text = "Cuenta con";
        //
        // chkLaptop
        //
        this.chkLaptop.AutoSize = true;
        this.chkLaptop.Location = new System.Drawing.Point(20, 25);
        this.chkLaptop.Name = "chkLaptop";
        this.chkLaptop.TabIndex = 0;
        this.chkLaptop.Text = "Laptop";
        this.chkLaptop.UseVisualStyleBackColor = true;
        //
        // chkInternet
        //
        this.chkInternet.AutoSize = true;
        this.chkInternet.Location = new System.Drawing.Point(110, 25);
        this.chkInternet.Name = "chkInternet";
        this.chkInternet.TabIndex = 1;
        this.chkInternet.Text = "Internet en casa";
        this.chkInternet.UseVisualStyleBackColor = true;
        //
        // btnAgregar
        //
        this.btnAgregar.Location = new System.Drawing.Point(20, 260);
        this.btnAgregar.Name = "btnAgregar";
        this.btnAgregar.Size = new System.Drawing.Size(130, 34);
        this.btnAgregar.TabIndex = 6;
        this.btnAgregar.Text = "Agregar";
        this.btnAgregar.UseVisualStyleBackColor = true;
        this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
        //
        // btnQuitar
        //
        this.btnQuitar.Location = new System.Drawing.Point(160, 260);
        this.btnQuitar.Name = "btnQuitar";
        this.btnQuitar.Size = new System.Drawing.Size(140, 34);
        this.btnQuitar.TabIndex = 7;
        this.btnQuitar.Text = "Quitar seleccionado";
        this.btnQuitar.UseVisualStyleBackColor = true;
        this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
        //
        // lstRegistros
        //
        this.lstRegistros.FormattingEnabled = true;
        this.lstRegistros.Location = new System.Drawing.Point(320, 21);
        this.lstRegistros.Name = "lstRegistros";
        this.lstRegistros.Size = new System.Drawing.Size(220, 320);
        this.lstRegistros.TabIndex = 8;
        //
        // FormControles
        //
        this.ClientSize = new System.Drawing.Size(560, 360);
        this.Controls.Add(this.lblCarrera);
        this.Controls.Add(this.cmbCarrera);
        this.Controls.Add(this.lblSemestre);
        this.Controls.Add(this.nudSemestre);
        this.Controls.Add(this.grpTurno);
        this.Controls.Add(this.grpExtras);
        this.Controls.Add(this.btnAgregar);
        this.Controls.Add(this.btnQuitar);
        this.Controls.Add(this.lstRegistros);
        this.Name = "FormControles";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Controles de selección";
        ((System.ComponentModel.ISupportInitialize)(this.nudSemestre)).EndInit();
        this.grpTurno.ResumeLayout(false);
        this.grpTurno.PerformLayout();
        this.grpExtras.ResumeLayout(false);
        this.grpExtras.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblCarrera;
    private System.Windows.Forms.ComboBox cmbCarrera;
    private System.Windows.Forms.Label lblSemestre;
    private System.Windows.Forms.NumericUpDown nudSemestre;
    private System.Windows.Forms.GroupBox grpTurno;
    private System.Windows.Forms.RadioButton rbMatutino;
    private System.Windows.Forms.RadioButton rbVespertino;
    private System.Windows.Forms.GroupBox grpExtras;
    private System.Windows.Forms.CheckBox chkLaptop;
    private System.Windows.Forms.CheckBox chkInternet;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Button btnQuitar;
    private System.Windows.Forms.ListBox lstRegistros;
}
