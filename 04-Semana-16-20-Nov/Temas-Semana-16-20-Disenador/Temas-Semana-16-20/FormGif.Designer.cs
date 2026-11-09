namespace TemasSemana1620
{
    partial class FormGif
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
            this.pnlContenido = new System.Windows.Forms.Panel();
            this._pbGif = new System.Windows.Forms.PictureBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnElegir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this._lblInfo = new System.Windows.Forms.Label();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbGif)).BeginInit();
            this.pnlPie.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlContenido
            //
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Controls.Add(this._pbGif);
            this.pnlContenido.Controls.Add(this.btnGenerar);
            this.pnlContenido.Controls.Add(this.btnElegir);
            this.pnlContenido.Controls.Add(this.btnGuardar);
            this.pnlContenido.Controls.Add(this._lblInfo);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 56);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(900, 528);
            this.pnlContenido.TabIndex = 0;
            //
            // _pbGif
            //
            this._pbGif.BackColor = System.Drawing.Color.FromArgb(20, 24, 48);
            this._pbGif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pbGif.Location = new System.Drawing.Point(12, 12);
            this._pbGif.Name = "_pbGif";
            this._pbGif.Size = new System.Drawing.Size(520, 440);
            this._pbGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pbGif.TabIndex = 0;
            this._pbGif.TabStop = false;
            //
            // btnGenerar
            //
            this.btnGenerar.Location = new System.Drawing.Point(550, 12);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(322, 44);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar GIF por código";
            this.btnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            //
            // btnElegir
            //
            this.btnElegir.Location = new System.Drawing.Point(550, 66);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(322, 44);
            this.btnElegir.TabIndex = 2;
            this.btnElegir.Text = "Elegir un GIF (OpenFileDialog)";
            this.btnElegir.Click += new System.EventHandler(this.BtnElegir_Click);
            //
            // btnGuardar
            //
            this.btnGuardar.Location = new System.Drawing.Point(550, 120);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(322, 44);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar el GIF generado";
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            //
            // _lblInfo
            //
            this._lblInfo.Location = new System.Drawing.Point(550, 180);
            this._lblInfo.Name = "_lblInfo";
            this._lblInfo.Size = new System.Drawing.Size(322, 140);
            this._lblInfo.TabIndex = 4;
            this._lblInfo.Text = "Aún no hay un GIF cargado.\nGenera uno por código o elige un archivo .gif.";
            //
            // pnlPie
            //
            this.pnlPie.BackColor = System.Drawing.Color.FromArgb(240, 242, 247);
            this.pnlPie.Controls.Add(this.btnVolver);
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPie.Location = new System.Drawing.Point(0, 584);
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
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            //
            // lblTitulo
            //
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(900, 56);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Tema 14 - GIF animado (PictureBox)";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // FormGif
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
            this.Name = "FormGif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tema 14 - GIF animado (PictureBox)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGif_FormClosed);
            this.pnlContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pbGif)).EndInit();
            this.pnlPie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.PictureBox _pbGif;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label _lblInfo;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardar_;
        private System.Windows.Forms.Label lblTitulo;
    }
}
