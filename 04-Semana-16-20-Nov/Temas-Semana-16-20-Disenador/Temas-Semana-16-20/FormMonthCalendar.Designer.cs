namespace TemasSemana1620
{
    partial class FormMonthCalendar
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
            this.flujo = new System.Windows.Forms.FlowLayoutPanel();
            this._calendario = new System.Windows.Forms.MonthCalendar();
            this._lblResultado = new System.Windows.Forms.Label();
            this.botones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHoy = new System.Windows.Forms.Button();
            this.btnSemana = new System.Windows.Forms.Button();
            this.chkSemanas = new System.Windows.Forms.CheckBox();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenido.SuspendLayout();
            this.flujo.SuspendLayout();
            this.botones.SuspendLayout();
            this.pnlPie.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Controls.Add(this.flujo);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.TabIndex = 0;
            // 
            // flujo
            // 
            this.flujo.AutoScroll = true;
            this.flujo.Controls.Add(this._calendario);
            this.flujo.Controls.Add(this._lblResultado);
            this.flujo.Controls.Add(this.botones);
            this.flujo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flujo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flujo.Name = "flujo";
            this.flujo.TabIndex = 0;
            this.flujo.WrapContents = false;
            // 
            // _calendario
            // 
            this._calendario.CalendarDimensions = new System.Drawing.Size(2, 1);
            this._calendario.Margin = new System.Windows.Forms.Padding(8);
            this._calendario.MaxSelectionCount = 31;
            this._calendario.Name = "_calendario";
            this._calendario.ShowWeekNumbers = false;
            this._calendario.TabIndex = 0;
            this._calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // _lblResultado
            // 
            this._lblResultado.AutoSize = false;
            this._lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._lblResultado.Margin = new System.Windows.Forms.Padding(8);
            this._lblResultado.Name = "_lblResultado";
            this._lblResultado.Padding = new System.Windows.Forms.Padding(10);
            this._lblResultado.Size = new System.Drawing.Size(840, 120);
            this._lblResultado.TabIndex = 1;
            this._lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // botones
            // 
            this.botones.AutoSize = true;
            this.botones.Controls.Add(this.btnHoy);
            this.botones.Controls.Add(this.btnSemana);
            this.botones.Controls.Add(this.chkSemanas);
            this.botones.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.botones.Margin = new System.Windows.Forms.Padding(8);
            this.botones.Name = "botones";
            this.botones.TabIndex = 2;
            // 
            // btnHoy
            // 
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(130, 36);
            this.btnHoy.TabIndex = 0;
            this.btnHoy.Text = "Ir a hoy";
            this.btnHoy.Click += new System.EventHandler(this.BtnHoy_Click);
            // 
            // btnSemana
            // 
            this.btnSemana.Name = "btnSemana";
            this.btnSemana.Size = new System.Drawing.Size(210, 36);
            this.btnSemana.TabIndex = 1;
            this.btnSemana.Text = "Seleccionar esta semana";
            this.btnSemana.Click += new System.EventHandler(this.BtnSemana_Click);
            // 
            // chkSemanas
            // 
            this.chkSemanas.AutoSize = true;
            this.chkSemanas.Margin = new System.Windows.Forms.Padding(16, 8, 3, 3);
            this.chkSemanas.Name = "chkSemanas";
            this.chkSemanas.TabIndex = 2;
            this.chkSemanas.Text = "Mostrar número de semana";
            this.chkSemanas.CheckedChanged += new System.EventHandler(this.ChkSemanas_CheckedChanged);
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
            this.lblTitulo.Text = "Tema 15 - MonthCalendar";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMonthCalendar
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
            this.Name = "FormMonthCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tema 15 - MonthCalendar";
            this.pnlContenido.ResumeLayout(false);
            this.flujo.ResumeLayout(false);
            this.flujo.PerformLayout();
            this.botones.ResumeLayout(false);
            this.botones.PerformLayout();
            this.pnlPie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.FlowLayoutPanel flujo;
        private System.Windows.Forms.MonthCalendar _calendario;
        private System.Windows.Forms.Label _lblResultado;
        private System.Windows.Forms.FlowLayoutPanel botones;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.Button btnSemana;
        private System.Windows.Forms.CheckBox chkSemanas;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTitulo;
    }
}
