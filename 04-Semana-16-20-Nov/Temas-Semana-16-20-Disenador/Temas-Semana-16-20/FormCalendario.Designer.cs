namespace TemasSemana1620
{
    partial class FormCalendario
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
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this._dtpInicio = new System.Windows.Forms.DateTimePicker();
            this._lblDiaInicio = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this._dtpFin = new System.Windows.Forms.DateTimePicker();
            this._lblDiaFin = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnHoy = new System.Windows.Forms.Button();
            this.btnIntercambiar = new System.Windows.Forms.Button();
            this._lblResultado = new System.Windows.Forms.Label();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenido.SuspendLayout();
            this.pnlPie.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Controls.Add(this.lblInstruccion);
            this.pnlContenido.Controls.Add(this.lblFechaInicial);
            this.pnlContenido.Controls.Add(this._dtpInicio);
            this.pnlContenido.Controls.Add(this._lblDiaInicio);
            this.pnlContenido.Controls.Add(this.lblFechaFinal);
            this.pnlContenido.Controls.Add(this._dtpFin);
            this.pnlContenido.Controls.Add(this._lblDiaFin);
            this.pnlContenido.Controls.Add(this.btnCalcular);
            this.pnlContenido.Controls.Add(this.btnHoy);
            this.pnlContenido.Controls.Add(this.btnIntercambiar);
            this.pnlContenido.Controls.Add(this._lblResultado);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.TabIndex = 0;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInstruccion.Location = new System.Drawing.Point(12, 16);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.TabIndex = 0;
            this.lblInstruccion.Text = "Despliega el calendario de cada selector y elige las fechas.";
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Location = new System.Drawing.Point(12, 66);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.TabIndex = 1;
            this.lblFechaInicial.Text = "Fecha inicial:";
            // 
            // _dtpInicio
            // 
            this._dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this._dtpInicio.Location = new System.Drawing.Point(150, 62);
            this._dtpInicio.Name = "_dtpInicio";
            this._dtpInicio.TabIndex = 2;
            this._dtpInicio.Width = 390;
            this._dtpInicio.ValueChanged += new System.EventHandler(this.Selector_ValueChanged);
            // 
            // _lblDiaInicio
            // 
            this._lblDiaInicio.AutoSize = true;
            this._lblDiaInicio.Location = new System.Drawing.Point(560, 66);
            this._lblDiaInicio.Name = "_lblDiaInicio";
            this._lblDiaInicio.TabIndex = 3;
            this._lblDiaInicio.Text = "";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Location = new System.Drawing.Point(12, 116);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.TabIndex = 4;
            this.lblFechaFinal.Text = "Fecha final:";
            // 
            // _dtpFin
            // 
            this._dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this._dtpFin.Location = new System.Drawing.Point(150, 112);
            this._dtpFin.Name = "_dtpFin";
            this._dtpFin.TabIndex = 5;
            this._dtpFin.Width = 390;
            this._dtpFin.ValueChanged += new System.EventHandler(this.Selector_ValueChanged);
            // 
            // _lblDiaFin
            // 
            this._lblDiaFin.AutoSize = true;
            this._lblDiaFin.Location = new System.Drawing.Point(560, 116);
            this._lblDiaFin.Name = "_lblDiaFin";
            this._lblDiaFin.TabIndex = 6;
            this._lblDiaFin.Text = "";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 170);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(230, 40);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular días entre fechas";
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnHoy
            // 
            this.btnHoy.Location = new System.Drawing.Point(252, 170);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(190, 40);
            this.btnHoy.TabIndex = 8;
            this.btnHoy.Text = "Poner hoy en ambas";
            this.btnHoy.Click += new System.EventHandler(this.BtnHoy_Click);
            // 
            // btnIntercambiar
            // 
            this.btnIntercambiar.Location = new System.Drawing.Point(452, 170);
            this.btnIntercambiar.Name = "btnIntercambiar";
            this.btnIntercambiar.Size = new System.Drawing.Size(190, 40);
            this.btnIntercambiar.TabIndex = 9;
            this.btnIntercambiar.Text = "Intercambiar fechas";
            this.btnIntercambiar.Click += new System.EventHandler(this.BtnIntercambiar_Click);
            // 
            // _lblResultado
            // 
            this._lblResultado.AutoSize = false;
            this._lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._lblResultado.Location = new System.Drawing.Point(12, 230);
            this._lblResultado.Name = "_lblResultado";
            this._lblResultado.Padding = new System.Windows.Forms.Padding(10);
            this._lblResultado.Size = new System.Drawing.Size(860, 200);
            this._lblResultado.TabIndex = 10;
            this._lblResultado.Text = "Elige dos fechas y presiona \"Calcular\".";
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
            this.lblTitulo.Text = "Tema 16 - Calendar (DateTimePicker)";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tema 16 - Calendar (DateTimePicker)";
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.pnlPie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.DateTimePicker _dtpInicio;
        private System.Windows.Forms.Label _lblDiaInicio;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.DateTimePicker _dtpFin;
        private System.Windows.Forms.Label _lblDiaFin;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.Button btnIntercambiar;
        private System.Windows.Forms.Label _lblResultado;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTitulo;
    }
}
