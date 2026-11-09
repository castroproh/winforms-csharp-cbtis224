namespace SEC2_IG1;

partial class Form1
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
        this.btnPaneles = new System.Windows.Forms.Button();
        this.btnRectangulo = new System.Windows.Forms.Button();
        this.btnCalculadora = new System.Windows.Forms.Button();
        this.btnFechas = new System.Windows.Forms.Button();
        this.btnControles = new System.Windows.Forms.Button();
        this.btnHerramientas = new System.Windows.Forms.Button();
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.mnuTemas = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuPaneles = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuRectangulo = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuCalculadora = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuFechas = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuControles = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuHerramientas = new System.Windows.Forms.ToolStripMenuItem();
        this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
        this.lblFecha = new System.Windows.Forms.Label();
        this.toolTip = new System.Windows.Forms.ToolTip(this.components);
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();
        //
        // btnPaneles
        //
        this.btnPaneles.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnPaneles.Location = new System.Drawing.Point(80, 50);
        this.btnPaneles.Name = "btnPaneles";
        this.btnPaneles.Size = new System.Drawing.Size(300, 42);
        this.btnPaneles.TabIndex = 0;
        this.btnPaneles.Text = "Paneles";
        this.toolTip.SetToolTip(this.btnPaneles, "Mostrar y ocultar paneles (Visible, PictureBox)");
        this.btnPaneles.UseVisualStyleBackColor = true;
        this.btnPaneles.Click += new System.EventHandler(this.AbrirPaneles);
        //
        // btnRectangulo
        //
        this.btnRectangulo.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnRectangulo.Location = new System.Drawing.Point(80, 102);
        this.btnRectangulo.Name = "btnRectangulo";
        this.btnRectangulo.Size = new System.Drawing.Size(300, 42);
        this.btnRectangulo.TabIndex = 1;
        this.btnRectangulo.Text = "Rectángulo";
        this.toolTip.SetToolTip(this.btnRectangulo, "Área y perímetro con TextBox, try/catch y MessageBox");
        this.btnRectangulo.UseVisualStyleBackColor = true;
        this.btnRectangulo.Click += new System.EventHandler(this.AbrirRectangulo);
        //
        // btnCalculadora
        //
        this.btnCalculadora.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnCalculadora.Location = new System.Drawing.Point(80, 154);
        this.btnCalculadora.Name = "btnCalculadora";
        this.btnCalculadora.Size = new System.Drawing.Size(300, 42);
        this.btnCalculadora.TabIndex = 2;
        this.btnCalculadora.Text = "Calculadora";
        this.toolTip.SetToolTip(this.btnCalculadora, "Convert.ToDouble, MouseHover y MouseLeave");
        this.btnCalculadora.UseVisualStyleBackColor = true;
        this.btnCalculadora.Click += new System.EventHandler(this.AbrirCalculadora);
        //
        // btnFechas
        //
        this.btnFechas.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnFechas.Location = new System.Drawing.Point(80, 206);
        this.btnFechas.Name = "btnFechas";
        this.btnFechas.Size = new System.Drawing.Size(300, 42);
        this.btnFechas.TabIndex = 3;
        this.btnFechas.Text = "Fechas y enlaces";
        this.toolTip.SetToolTip(this.btnFechas, "DateTimePicker, ToolTip y LinkLabel");
        this.btnFechas.UseVisualStyleBackColor = true;
        this.btnFechas.Click += new System.EventHandler(this.AbrirFechas);
        //
        // btnControles
        //
        this.btnControles.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnControles.Location = new System.Drawing.Point(80, 258);
        this.btnControles.Name = "btnControles";
        this.btnControles.Size = new System.Drawing.Size(300, 42);
        this.btnControles.TabIndex = 4;
        this.btnControles.Text = "Controles de selección";
        this.toolTip.SetToolTip(this.btnControles, "ComboBox, RadioButton, GroupBox, CheckBox, NumericUpDown, ListBox");
        this.btnControles.UseVisualStyleBackColor = true;
        this.btnControles.Click += new System.EventHandler(this.AbrirControles);
        //
        // btnHerramientas
        //
        this.btnHerramientas.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnHerramientas.Location = new System.Drawing.Point(80, 310);
        this.btnHerramientas.Name = "btnHerramientas";
        this.btnHerramientas.Size = new System.Drawing.Size(300, 42);
        this.btnHerramientas.TabIndex = 5;
        this.btnHerramientas.Text = "Herramientas vistas";
        this.toolTip.SetToolTip(this.btnHerramientas, "ListView con grupos y Timer");
        this.btnHerramientas.UseVisualStyleBackColor = true;
        this.btnHerramientas.Click += new System.EventHandler(this.AbrirHerramientas);
        //
        // menuStrip1
        //
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.mnuTemas,
        this.mnuSalir});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(460, 24);
        this.menuStrip1.TabIndex = 6;
        //
        // mnuTemas
        //
        this.mnuTemas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.mnuPaneles,
        this.mnuRectangulo,
        this.mnuCalculadora,
        this.mnuFechas,
        this.mnuControles,
        this.mnuHerramientas});
        this.mnuTemas.Name = "mnuTemas";
        this.mnuTemas.Text = "Temas";
        //
        // mnuPaneles
        //
        this.mnuPaneles.Name = "mnuPaneles";
        this.mnuPaneles.Text = "Paneles";
        this.mnuPaneles.Click += new System.EventHandler(this.AbrirPaneles);
        //
        // mnuRectangulo
        //
        this.mnuRectangulo.Name = "mnuRectangulo";
        this.mnuRectangulo.Text = "Rectángulo";
        this.mnuRectangulo.Click += new System.EventHandler(this.AbrirRectangulo);
        //
        // mnuCalculadora
        //
        this.mnuCalculadora.Name = "mnuCalculadora";
        this.mnuCalculadora.Text = "Calculadora";
        this.mnuCalculadora.Click += new System.EventHandler(this.AbrirCalculadora);
        //
        // mnuFechas
        //
        this.mnuFechas.Name = "mnuFechas";
        this.mnuFechas.Text = "Fechas y enlaces";
        this.mnuFechas.Click += new System.EventHandler(this.AbrirFechas);
        //
        // mnuControles
        //
        this.mnuControles.Name = "mnuControles";
        this.mnuControles.Text = "Controles de selección";
        this.mnuControles.Click += new System.EventHandler(this.AbrirControles);
        //
        // mnuHerramientas
        //
        this.mnuHerramientas.Name = "mnuHerramientas";
        this.mnuHerramientas.Text = "Herramientas vistas";
        this.mnuHerramientas.Click += new System.EventHandler(this.AbrirHerramientas);
        //
        // mnuSalir
        //
        this.mnuSalir.Name = "mnuSalir";
        this.mnuSalir.Text = "Salir";
        this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
        //
        // lblFecha
        //
        this.lblFecha.AutoSize = false;
        this.lblFecha.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.lblFecha.Location = new System.Drawing.Point(0, 404);
        this.lblFecha.Name = "lblFecha";
        this.lblFecha.Size = new System.Drawing.Size(460, 36);
        this.lblFecha.TabIndex = 7;
        this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // Form1
        //
        this.ClientSize = new System.Drawing.Size(460, 440);
        this.Controls.Add(this.btnPaneles);
        this.Controls.Add(this.btnRectangulo);
        this.Controls.Add(this.btnCalculadora);
        this.Controls.Add(this.btnFechas);
        this.Controls.Add(this.btnControles);
        this.Controls.Add(this.btnHerramientas);
        this.Controls.Add(this.menuStrip1);
        this.Controls.Add(this.lblFecha);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MainMenuStrip = this.menuStrip1;
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "SEC2-IG1 - Menú principal";
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnPaneles;
    private System.Windows.Forms.Button btnRectangulo;
    private System.Windows.Forms.Button btnCalculadora;
    private System.Windows.Forms.Button btnFechas;
    private System.Windows.Forms.Button btnControles;
    private System.Windows.Forms.Button btnHerramientas;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuTemas;
    private System.Windows.Forms.ToolStripMenuItem mnuPaneles;
    private System.Windows.Forms.ToolStripMenuItem mnuRectangulo;
    private System.Windows.Forms.ToolStripMenuItem mnuCalculadora;
    private System.Windows.Forms.ToolStripMenuItem mnuFechas;
    private System.Windows.Forms.ToolStripMenuItem mnuControles;
    private System.Windows.Forms.ToolStripMenuItem mnuHerramientas;
    private System.Windows.Forms.ToolStripMenuItem mnuSalir;
    private System.Windows.Forms.Label lblFecha;
    private System.Windows.Forms.ToolTip toolTip;
}
