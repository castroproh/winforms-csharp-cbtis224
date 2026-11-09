namespace TemasSemana1620
{
    partial class FormStatusStrip
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this._txtNotas = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this._txtMensaje = new System.Windows.Forms.TextBox();
            this.btnMensaje = new System.Windows.Forms.Button();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this._barra = new System.Windows.Forms.StatusStrip();
            this._lblAccion = new System.Windows.Forms.ToolStripStatusLabel();
            this._progreso = new System.Windows.Forms.ToolStripProgressBar();
            this._lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this._lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this._tmrReloj = new System.Windows.Forms.Timer(this.components);
            this._tmrProgreso = new System.Windows.Forms.Timer(this.components);
            this.pnlContenido.SuspendLayout();
            this.pnlPie.SuspendLayout();
            this._barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Controls.Add(this.lblInstruccion);
            this.pnlContenido.Controls.Add(this._txtNotas);
            this.pnlContenido.Controls.Add(this.btnNuevo);
            this.pnlContenido.Controls.Add(this.btnGuardar);
            this.pnlContenido.Controls.Add(this.btnProcesar);
            this.pnlContenido.Controls.Add(this.lblMensaje);
            this.pnlContenido.Controls.Add(this._txtMensaje);
            this.pnlContenido.Controls.Add(this.btnMensaje);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.TabIndex = 0;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(12, 12);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.TabIndex = 0;
            this.lblInstruccion.Text = "Escribe en el cuadro o usa los botones: la barra de abajo muestra la acción actual.";
            // 
            // _txtNotas
            // 
            this._txtNotas.Location = new System.Drawing.Point(12, 44);
            this._txtNotas.Multiline = true;
            this._txtNotas.Name = "_txtNotas";
            this._txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtNotas.Size = new System.Drawing.Size(860, 250);
            this._txtNotas.TabIndex = 1;
            this._txtNotas.TextChanged += new System.EventHandler(this.TxtNotas_TextChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 310);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(140, 38);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(162, 310);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 38);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar...";
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(312, 310);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(140, 38);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.Click += new System.EventHandler(this.BtnProcesar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(12, 374);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "Mensaje:";
            // 
            // _txtMensaje
            // 
            this._txtMensaje.Location = new System.Drawing.Point(100, 370);
            this._txtMensaje.Name = "_txtMensaje";
            this._txtMensaje.TabIndex = 6;
            this._txtMensaje.Width = 400;
            // 
            // btnMensaje
            // 
            this.btnMensaje.Location = new System.Drawing.Point(510, 368);
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(180, 36);
            this.btnMensaje.TabIndex = 7;
            this.btnMensaje.Text = "Mostrar en la barra";
            this.btnMensaje.Click += new System.EventHandler(this.BtnMensaje_Click);
            // 
            // pnlPie
            // 
            this.pnlPie.BackColor = System.Drawing.Color.FromArgb(240, 242, 247);
            this.pnlPie.Controls.Add(this.btnVolver);
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(900, 56);
            this.pnlPie.TabIndex = 1;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 10);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 36);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(900, 56);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Tema 17 - StatusStrip";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _barra
            // 
            this._barra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._lblAccion,
            this._progreso,
            this._lblFecha,
            this._lblHora});
            this._barra.Name = "_barra";
            this._barra.SizingGrip = false;
            this._barra.TabIndex = 3;
            // 
            // _lblAccion
            // 
            this._lblAccion.Name = "_lblAccion";
            this._lblAccion.Spring = true;
            this._lblAccion.Text = "Listo";
            this._lblAccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _progreso
            // 
            this._progreso.Maximum = 100;
            this._progreso.Minimum = 0;
            this._progreso.Name = "_progreso";
            this._progreso.Visible = false;
            this._progreso.Width = 120;
            // 
            // _lblFecha
            // 
            this._lblFecha.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this._lblFecha.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this._lblFecha.Name = "_lblFecha";
            // 
            // _lblHora
            // 
            this._lblHora.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this._lblHora.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this._lblHora.Name = "_lblHora";
            // 
            // _tmrReloj
            // 
            this._tmrReloj.Interval = 1000;
            this._tmrReloj.Tick += new System.EventHandler(this.TmrReloj_Tick);
            // 
            // _tmrProgreso
            // 
            this._tmrProgreso.Interval = 150;
            this._tmrProgreso.Tick += new System.EventHandler(this.TmrProgreso_Tick);
            // 
            // FormStatusStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this._barra);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStatusStrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tema 17 - StatusStrip";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStatusStrip_FormClosed);
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.pnlPie.ResumeLayout(false);
            this._barra.ResumeLayout(false);
            this._barra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.TextBox _txtNotas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox _txtMensaje;
        private System.Windows.Forms.Button btnMensaje;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.StatusStrip _barra;
        private System.Windows.Forms.ToolStripStatusLabel _lblAccion;
        private System.Windows.Forms.ToolStripProgressBar _progreso;
        private System.Windows.Forms.ToolStripStatusLabel _lblFecha;
        private System.Windows.Forms.ToolStripStatusLabel _lblHora;
        private System.Windows.Forms.Timer _tmrReloj;
        private System.Windows.Forms.Timer _tmrProgreso;
    }
}
