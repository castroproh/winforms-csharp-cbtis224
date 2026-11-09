namespace TemasSemana1620
{
    partial class FormPdfScreens
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
            this._pnlMuestra = new System.Windows.Forms.Panel();
            this.lblMuestra = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this._cmbGrupo = new System.Windows.Forms.ComboBox();
            this._chkActivo = new System.Windows.Forms.CheckBox();
            this._pnlGrafica = new System.Windows.Forms.Panel();
            this._pbCaptura = new System.Windows.Forms.PictureBox();
            this.btnForm = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnPng = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this._lblEstado = new System.Windows.Forms.Label();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenido.SuspendLayout();
            this._pnlMuestra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbCaptura)).BeginInit();
            this.pnlPie.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlContenido
            //
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Controls.Add(this._pnlMuestra);
            this.pnlContenido.Controls.Add(this._pbCaptura);
            this.pnlContenido.Controls.Add(this.btnForm);
            this.pnlContenido.Controls.Add(this.btnArea);
            this.pnlContenido.Controls.Add(this.btnPng);
            this.pnlContenido.Controls.Add(this.btnPdf);
            this.pnlContenido.Controls.Add(this._lblEstado);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 56);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(900, 528);
            this.pnlContenido.TabIndex = 0;
            //
            // _pnlMuestra
            //
            this._pnlMuestra.BackColor = System.Drawing.Color.FromArgb(250, 250, 245);
            this._pnlMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlMuestra.Controls.Add(this.lblMuestra);
            this._pnlMuestra.Controls.Add(this.lblNombre);
            this._pnlMuestra.Controls.Add(this._txtNombre);
            this._pnlMuestra.Controls.Add(this.lblGrupo);
            this._pnlMuestra.Controls.Add(this._cmbGrupo);
            this._pnlMuestra.Controls.Add(this._chkActivo);
            this._pnlMuestra.Controls.Add(this._pnlGrafica);
            this._pnlMuestra.Location = new System.Drawing.Point(12, 12);
            this._pnlMuestra.Name = "_pnlMuestra";
            this._pnlMuestra.Size = new System.Drawing.Size(400, 330);
            this._pnlMuestra.TabIndex = 0;
            //
            // lblMuestra
            //
            this.lblMuestra.AutoSize = true;
            this.lblMuestra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMuestra.Location = new System.Drawing.Point(10, 10);
            this.lblMuestra.Name = "lblMuestra";
            this.lblMuestra.Size = new System.Drawing.Size(232, 19);
            this.lblMuestra.TabIndex = 0;
            this.lblMuestra.Text = "Área de muestra (se puede capturar)";
            //
            // lblNombre
            //
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 19);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            //
            // _txtNombre
            //
            this._txtNombre.Location = new System.Drawing.Point(90, 40);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(280, 25);
            this._txtNombre.TabIndex = 2;
            this._txtNombre.Text = "Alumno del CBTis 224";
            //
            // lblGrupo
            //
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(10, 78);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(52, 19);
            this.lblGrupo.TabIndex = 3;
            this.lblGrupo.Text = "Grupo:";
            //
            // _cmbGrupo
            //
            this._cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbGrupo.Items.AddRange(new object[] {
            "5° A",
            "5° B",
            "6° A",
            "6° B"});
            this._cmbGrupo.Location = new System.Drawing.Point(90, 74);
            this._cmbGrupo.Name = "_cmbGrupo";
            this._cmbGrupo.Size = new System.Drawing.Size(120, 25);
            this._cmbGrupo.TabIndex = 4;
            //
            // _chkActivo
            //
            this._chkActivo.AutoSize = true;
            this._chkActivo.Checked = true;
            this._chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkActivo.Location = new System.Drawing.Point(240, 78);
            this._chkActivo.Name = "_chkActivo";
            this._chkActivo.Size = new System.Drawing.Size(113, 23);
            this._chkActivo.TabIndex = 5;
            this._chkActivo.Text = "Alumno activo";
            //
            // _pnlGrafica
            //
            this._pnlGrafica.BackColor = System.Drawing.Color.White;
            this._pnlGrafica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlGrafica.Location = new System.Drawing.Point(10, 114);
            this._pnlGrafica.Name = "_pnlGrafica";
            this._pnlGrafica.Size = new System.Drawing.Size(372, 200);
            this._pnlGrafica.TabIndex = 6;
            this._pnlGrafica.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGrafica_Paint);
            //
            // _pbCaptura
            //
            this._pbCaptura.BackColor = System.Drawing.Color.WhiteSmoke;
            this._pbCaptura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pbCaptura.Location = new System.Drawing.Point(430, 12);
            this._pbCaptura.Name = "_pbCaptura";
            this._pbCaptura.Size = new System.Drawing.Size(440, 330);
            this._pbCaptura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pbCaptura.TabIndex = 1;
            this._pbCaptura.TabStop = false;
            //
            // btnForm
            //
            this.btnForm.Location = new System.Drawing.Point(12, 360);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(260, 40);
            this.btnForm.TabIndex = 2;
            this.btnForm.Text = "Capturar formulario completo";
            this.btnForm.Click += new System.EventHandler(this.BtnCapturarFormulario_Click);
            //
            // btnArea
            //
            this.btnArea.Location = new System.Drawing.Point(282, 360);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(280, 40);
            this.btnArea.TabIndex = 3;
            this.btnArea.Text = "Capturar solo el área de muestra";
            this.btnArea.Click += new System.EventHandler(this.BtnCapturarArea_Click);
            //
            // btnPng
            //
            this.btnPng.Location = new System.Drawing.Point(12, 410);
            this.btnPng.Name = "btnPng";
            this.btnPng.Size = new System.Drawing.Size(260, 40);
            this.btnPng.TabIndex = 4;
            this.btnPng.Text = "Guardar como imagen (PNG)";
            this.btnPng.Click += new System.EventHandler(this.BtnGuardarPng_Click);
            //
            // btnPdf
            //
            this.btnPdf.Location = new System.Drawing.Point(282, 410);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(200, 40);
            this.btnPdf.TabIndex = 5;
            this.btnPdf.Text = "Guardar como PDF";
            this.btnPdf.Click += new System.EventHandler(this.BtnGuardarPdf_Click);
            //
            // _lblEstado
            //
            this._lblEstado.AutoSize = true;
            this._lblEstado.Location = new System.Drawing.Point(12, 466);
            this._lblEstado.Name = "_lblEstado";
            this._lblEstado.Size = new System.Drawing.Size(398, 19);
            this._lblEstado.TabIndex = 6;
            this._lblEstado.Text = "Aún no hay captura. Presiona uno de los botones de captura.";
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
            this.lblTitulo.Text = "Tema 12 - Genera PDF de screens (DrawToBitmap)";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // FormPdfScreens
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
            this.Name = "FormPdfScreens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tema 12 - Genera PDF de screens (DrawToBitmap)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPdfScreens_FormClosed);
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this._pnlMuestra.ResumeLayout(false);
            this._pnlMuestra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbCaptura)).EndInit();
            this.pnlPie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel _pnlMuestra;
        private System.Windows.Forms.Label lblMuestra;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox _cmbGrupo;
        private System.Windows.Forms.CheckBox _chkActivo;
        private System.Windows.Forms.Panel _pnlGrafica;
        private System.Windows.Forms.PictureBox _pbCaptura;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnPng;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Label _lblEstado;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTitulo;
    }
}
