namespace TemasSemana1620
{
    partial class FormToolStrip
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
            this.contenedor = new System.Windows.Forms.ToolStripContainer();
            this._rtb = new System.Windows.Forms.RichTextBox();
            this._barra = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnAbrir = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCortar = new System.Windows.Forms.ToolStripButton();
            this.btnCopiar = new System.Windows.Forms.ToolStripButton();
            this.btnPegar = new System.Windows.Forms.ToolStripButton();
            this._btnNegrita = new System.Windows.Forms.ToolStripButton();
            this._btnCursiva = new System.Windows.Forms.ToolStripButton();
            this._btnSubrayado = new System.Windows.Forms.ToolStripButton();
            this.btnColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTamano = new System.Windows.Forms.ToolStripLabel();
            this._cmbTamano = new System.Windows.Forms.ToolStripComboBox();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenido.SuspendLayout();
            this.contenedor.ContentPanel.SuspendLayout();
            this.contenedor.TopToolStripPanel.SuspendLayout();
            this.contenedor.SuspendLayout();
            this._barra.SuspendLayout();
            this.pnlPie.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Controls.Add(this.contenedor);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.TabIndex = 0;
            // 
            // contenedor
            // 
            this.contenedor.ContentPanel.Controls.Add(this._rtb);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Name = "contenedor";
            this.contenedor.TabIndex = 0;
            this.contenedor.TopToolStripPanel.Controls.Add(this._barra);
            // 
            // _rtb
            // 
            this._rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtb.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._rtb.Name = "_rtb";
            this._rtb.TabIndex = 0;
            this._rtb.Text = "Escribe aquí. Selecciona texto y usa los botones de la barra de herramientas.";
            this._rtb.SelectionChanged += new System.EventHandler(this.Rtb_SelectionChanged);
            // 
            // _barra
            // 
            this._barra.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this._barra.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnAbrir,
            this.btnGuardar,
            this.toolStripSeparator1,
            this.btnCortar,
            this.btnCopiar,
            this.btnPegar,
            this.toolStripSeparator2,
            this._btnNegrita,
            this._btnCursiva,
            this._btnSubrayado,
            this.toolStripSeparator3,
            this.btnColor,
            this.lblTamano,
            this._cmbTamano});
            this._barra.Name = "_barra";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.ToolTipText = "Documento nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrir.ToolTipText = "Abrir un archivo de texto";
            this.btnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.ToolTipText = "Guardar como texto";
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCortar
            // 
            this.btnCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Text = "Cortar";
            this.btnCortar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCortar.ToolTipText = "Cortar la selección";
            this.btnCortar.Click += new System.EventHandler(this.BtnCortar_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCopiar.ToolTipText = "Copiar la selección";
            this.btnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // btnPegar
            // 
            this.btnPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnPegar.Name = "btnPegar";
            this.btnPegar.Text = "Pegar";
            this.btnPegar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPegar.ToolTipText = "Pegar del portapapeles";
            this.btnPegar.Click += new System.EventHandler(this.BtnPegar_Click);
            // 
            // _btnNegrita
            // 
            this._btnNegrita.CheckOnClick = true;
            this._btnNegrita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnNegrita.Name = "_btnNegrita";
            this._btnNegrita.Text = "";
            this._btnNegrita.ToolTipText = "Negrita";
            this._btnNegrita.Click += new System.EventHandler(this.BtnNegrita_Click);
            // 
            // _btnCursiva
            // 
            this._btnCursiva.CheckOnClick = true;
            this._btnCursiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnCursiva.Name = "_btnCursiva";
            this._btnCursiva.Text = "";
            this._btnCursiva.ToolTipText = "Cursiva";
            this._btnCursiva.Click += new System.EventHandler(this.BtnCursiva_Click);
            // 
            // _btnSubrayado
            // 
            this._btnSubrayado.CheckOnClick = true;
            this._btnSubrayado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnSubrayado.Name = "_btnSubrayado";
            this._btnSubrayado.Text = "";
            this._btnSubrayado.ToolTipText = "Subrayado";
            this._btnSubrayado.Click += new System.EventHandler(this.BtnSubrayado_Click);
            // 
            // btnColor
            // 
            this.btnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnColor.Name = "btnColor";
            this.btnColor.Text = "Color";
            this.btnColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnColor.ToolTipText = "Color del texto seleccionado";
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // lblTamano
            // 
            this.lblTamano.Name = "lblTamano";
            this.lblTamano.Text = "Tamaño:";
            // 
            // _cmbTamano
            // 
            this._cmbTamano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbTamano.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "18",
            "24",
            "36"});
            this._cmbTamano.Name = "_cmbTamano";
            this._cmbTamano.Width = 60;
            this._cmbTamano.ToolTipText = "Tamaño de letra";
            this._cmbTamano.SelectedIndex = 2;
            this._cmbTamano.SelectedIndexChanged += new System.EventHandler(this.CmbTamano_SelectedIndexChanged);
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
            this.lblTitulo.Text = "Tema 20 - ToolStrip y ToolStripContainer";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormToolStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = false;
            this.Name = "FormToolStrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tema 20 - ToolStrip y ToolStripContainer";
            this.pnlContenido.ResumeLayout(false);
            this.contenedor.ContentPanel.ResumeLayout(false);
            this.contenedor.TopToolStripPanel.ResumeLayout(false);
            this.contenedor.TopToolStripPanel.PerformLayout();
            this.contenedor.ResumeLayout(false);
            this.contenedor.PerformLayout();
            this._barra.ResumeLayout(false);
            this._barra.PerformLayout();
            this.pnlPie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.ToolStripContainer contenedor;
        private System.Windows.Forms.RichTextBox _rtb;
        private System.Windows.Forms.ToolStrip _barra;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnAbrir;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCortar;
        private System.Windows.Forms.ToolStripButton btnCopiar;
        private System.Windows.Forms.ToolStripButton btnPegar;
        private System.Windows.Forms.ToolStripButton _btnNegrita;
        private System.Windows.Forms.ToolStripButton _btnCursiva;
        private System.Windows.Forms.ToolStripButton _btnSubrayado;
        private System.Windows.Forms.ToolStripButton btnColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblTamano;
        private System.Windows.Forms.ToolStripComboBox _cmbTamano;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTitulo;
    }
}
