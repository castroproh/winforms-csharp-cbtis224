namespace Temas_Semana_30_nov_4_dic
{
    partial class FormTicket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.picLogoEncabezado = new System.Windows.Forms.PictureBox();
            this.lblTituloEncabezado = new System.Windows.Forms.Label();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.lblArticulos = new System.Windows.Forms.Label();
            this.gbCobro = new System.Windows.Forms.GroupBox();
            this.lblSubtotalTxt = new System.Windows.Forms.Label();
            this.lblSubtotalValor = new System.Windows.Forms.Label();
            this.lblCuponTxt = new System.Windows.Forms.Label();
            this.cmbDescuento = new System.Windows.Forms.ComboBox();
            this.lblDescuentoTxt = new System.Windows.Forms.Label();
            this.lblDescuentoValor = new System.Windows.Forms.Label();
            this.lblIvaTxt = new System.Windows.Forms.Label();
            this.lblIvaValor = new System.Windows.Forms.Label();
            this.lblTotalTxt = new System.Windows.Forms.Label();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.lblPagoTxt = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.lblCambioTxt = new System.Windows.Forms.Label();
            this.lblCambioValor = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.gbCobro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.picLogoEncabezado);
            this.pnlEncabezado.Controls.Add(this.lblTituloEncabezado);
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(38, 50, 56);
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(860, 70);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // picLogoEncabezado
            // 
            this.picLogoEncabezado.Location = new System.Drawing.Point(16, 11);
            this.picLogoEncabezado.Name = "picLogoEncabezado";
            this.picLogoEncabezado.Size = new System.Drawing.Size(48, 48);
            this.picLogoEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoEncabezado.TabStop = false;
            this.picLogoEncabezado.TabIndex = 0;
            // 
            // lblTituloEncabezado
            // 
            this.lblTituloEncabezado.AutoSize = true;
            this.lblTituloEncabezado.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblTituloEncabezado.Location = new System.Drawing.Point(76, 16);
            this.lblTituloEncabezado.Name = "lblTituloEncabezado";
            this.lblTituloEncabezado.Size = new System.Drawing.Size(267, 30);
            this.lblTituloEncabezado.Text = "PYMASA - Pago y ticket";
            this.lblTituloEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloEncabezado.TabIndex = 1;
            // 
            // dgvResumen
            // 
            this.dgvResumen.AllowUserToAddRows = false;
            this.dgvResumen.AllowUserToDeleteRows = false;
            this.dgvResumen.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.dgvResumen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResumen.BackgroundColor = System.Drawing.Color.White;
            this.dgvResumen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(0, 121, 107);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(0, 121, 107);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResumen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResumen.ColumnHeadersHeight = 34;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colProducto,
                        this.colCantidad,
                        this.colImporte});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResumen.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResumen.EnableHeadersVisualStyles = false;
            this.dgvResumen.Location = new System.Drawing.Point(20, 85);
            this.dgvResumen.MultiSelect = false;
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.ReadOnly = true;
            this.dgvResumen.RowHeadersVisible = false;
            this.dgvResumen.RowTemplate.Height = 28;
            this.dgvResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResumen.Size = new System.Drawing.Size(470, 380);
            this.dgvResumen.TabIndex = 1;
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 200F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            // 
            // colCantidad
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCantidad.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCantidad.FillWeight = 60F;
            this.colCantidad.HeaderText = "Cant.";
            this.colCantidad.Name = "colCantidad";
            // 
            // colImporte
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colImporte.DefaultCellStyle = dataGridViewCellStyle6;
            this.colImporte.HeaderText = "Importe";
            this.colImporte.Name = "colImporte";
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = false;
            this.lblArticulos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblArticulos.ForeColor = System.Drawing.Color.FromArgb(38, 50, 56);
            this.lblArticulos.Location = new System.Drawing.Point(20, 472);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(300, 26);
            this.lblArticulos.Text = "Articulos: 0";
            this.lblArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblArticulos.TabIndex = 2;
            // 
            // gbCobro
            // 
            this.gbCobro.Controls.Add(this.lblSubtotalTxt);
            this.gbCobro.Controls.Add(this.lblSubtotalValor);
            this.gbCobro.Controls.Add(this.lblCuponTxt);
            this.gbCobro.Controls.Add(this.cmbDescuento);
            this.gbCobro.Controls.Add(this.lblDescuentoTxt);
            this.gbCobro.Controls.Add(this.lblDescuentoValor);
            this.gbCobro.Controls.Add(this.lblIvaTxt);
            this.gbCobro.Controls.Add(this.lblIvaValor);
            this.gbCobro.Controls.Add(this.lblTotalTxt);
            this.gbCobro.Controls.Add(this.lblTotalValor);
            this.gbCobro.Controls.Add(this.lblPagoTxt);
            this.gbCobro.Controls.Add(this.txtPago);
            this.gbCobro.Controls.Add(this.lblCambioTxt);
            this.gbCobro.Controls.Add(this.lblCambioValor);
            this.gbCobro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbCobro.Location = new System.Drawing.Point(510, 85);
            this.gbCobro.Name = "gbCobro";
            this.gbCobro.Size = new System.Drawing.Size(330, 380);
            this.gbCobro.TabStop = false;
            this.gbCobro.Text = "Cobro";
            this.gbCobro.TabIndex = 3;
            // 
            // lblSubtotalTxt
            // 
            this.lblSubtotalTxt.AutoSize = false;
            this.lblSubtotalTxt.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblSubtotalTxt.Location = new System.Drawing.Point(15, 30);
            this.lblSubtotalTxt.Name = "lblSubtotalTxt";
            this.lblSubtotalTxt.Size = new System.Drawing.Size(140, 28);
            this.lblSubtotalTxt.Text = "Subtotal:";
            this.lblSubtotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSubtotalTxt.TabIndex = 0;
            // 
            // lblSubtotalValor
            // 
            this.lblSubtotalValor.AutoSize = false;
            this.lblSubtotalValor.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalValor.Location = new System.Drawing.Point(165, 30);
            this.lblSubtotalValor.Name = "lblSubtotalValor";
            this.lblSubtotalValor.Size = new System.Drawing.Size(150, 28);
            this.lblSubtotalValor.Text = "$0.00";
            this.lblSubtotalValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSubtotalValor.TabIndex = 1;
            // 
            // lblCuponTxt
            // 
            this.lblCuponTxt.AutoSize = false;
            this.lblCuponTxt.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblCuponTxt.Location = new System.Drawing.Point(15, 68);
            this.lblCuponTxt.Name = "lblCuponTxt";
            this.lblCuponTxt.Size = new System.Drawing.Size(140, 28);
            this.lblCuponTxt.Text = "Descuento:";
            this.lblCuponTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCuponTxt.TabIndex = 2;
            // 
            // cmbDescuento
            // 
            this.cmbDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDescuento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDescuento.Items.AddRange(new object[] {
                "Sin descuento",
                "5%",
                "10%",
                "15%"});
            this.cmbDescuento.Location = new System.Drawing.Point(165, 68);
            this.cmbDescuento.Name = "cmbDescuento";
            this.cmbDescuento.Size = new System.Drawing.Size(150, 28);
            this.cmbDescuento.TabIndex = 3;
            this.cmbDescuento.SelectedIndexChanged += new System.EventHandler(this.CmbDescuento_SelectedIndexChanged);
            // 
            // lblDescuentoTxt
            // 
            this.lblDescuentoTxt.AutoSize = false;
            this.lblDescuentoTxt.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblDescuentoTxt.Location = new System.Drawing.Point(15, 104);
            this.lblDescuentoTxt.Name = "lblDescuentoTxt";
            this.lblDescuentoTxt.Size = new System.Drawing.Size(150, 28);
            this.lblDescuentoTxt.Text = "Menos descuento:";
            this.lblDescuentoTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDescuentoTxt.TabIndex = 4;
            // 
            // lblDescuentoValor
            // 
            this.lblDescuentoValor.AutoSize = false;
            this.lblDescuentoValor.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblDescuentoValor.Location = new System.Drawing.Point(165, 104);
            this.lblDescuentoValor.Name = "lblDescuentoValor";
            this.lblDescuentoValor.Size = new System.Drawing.Size(150, 28);
            this.lblDescuentoValor.Text = "$0.00";
            this.lblDescuentoValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDescuentoValor.TabIndex = 5;
            // 
            // lblIvaTxt
            // 
            this.lblIvaTxt.AutoSize = false;
            this.lblIvaTxt.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblIvaTxt.Location = new System.Drawing.Point(15, 140);
            this.lblIvaTxt.Name = "lblIvaTxt";
            this.lblIvaTxt.Size = new System.Drawing.Size(140, 28);
            this.lblIvaTxt.Text = "IVA 16%:";
            this.lblIvaTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIvaTxt.TabIndex = 6;
            // 
            // lblIvaValor
            // 
            this.lblIvaValor.AutoSize = false;
            this.lblIvaValor.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblIvaValor.Location = new System.Drawing.Point(165, 140);
            this.lblIvaValor.Name = "lblIvaValor";
            this.lblIvaValor.Size = new System.Drawing.Size(150, 28);
            this.lblIvaValor.Text = "$0.00";
            this.lblIvaValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIvaValor.TabIndex = 7;
            // 
            // lblTotalTxt
            // 
            this.lblTotalTxt.AutoSize = false;
            this.lblTotalTxt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalTxt.ForeColor = System.Drawing.Color.FromArgb(0, 121, 107);
            this.lblTotalTxt.Location = new System.Drawing.Point(15, 182);
            this.lblTotalTxt.Name = "lblTotalTxt";
            this.lblTotalTxt.Size = new System.Drawing.Size(100, 40);
            this.lblTotalTxt.Text = "TOTAL:";
            this.lblTotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalTxt.TabIndex = 8;
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.AutoSize = false;
            this.lblTotalValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalValor.ForeColor = System.Drawing.Color.FromArgb(0, 121, 107);
            this.lblTotalValor.Location = new System.Drawing.Point(115, 182);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(200, 40);
            this.lblTotalValor.Text = "$0.00";
            this.lblTotalValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalValor.TabIndex = 9;
            // 
            // lblPagoTxt
            // 
            this.lblPagoTxt.AutoSize = false;
            this.lblPagoTxt.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblPagoTxt.Location = new System.Drawing.Point(15, 246);
            this.lblPagoTxt.Name = "lblPagoTxt";
            this.lblPagoTxt.Size = new System.Drawing.Size(150, 28);
            this.lblPagoTxt.Text = "Efectivo recibido:";
            this.lblPagoTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPagoTxt.TabIndex = 10;
            // 
            // txtPago
            // 
            this.txtPago.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPago.Location = new System.Drawing.Point(165, 246);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(150, 28);
            this.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPago.TabIndex = 11;
            this.txtPago.TextChanged += new System.EventHandler(this.TxtPago_TextChanged);
            // 
            // lblCambioTxt
            // 
            this.lblCambioTxt.AutoSize = false;
            this.lblCambioTxt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCambioTxt.Location = new System.Drawing.Point(15, 292);
            this.lblCambioTxt.Name = "lblCambioTxt";
            this.lblCambioTxt.Size = new System.Drawing.Size(100, 40);
            this.lblCambioTxt.Text = "Cambio:";
            this.lblCambioTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCambioTxt.TabIndex = 12;
            // 
            // lblCambioValor
            // 
            this.lblCambioValor.AutoSize = false;
            this.lblCambioValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCambioValor.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblCambioValor.Location = new System.Drawing.Point(115, 292);
            this.lblCambioValor.Name = "lblCambioValor";
            this.lblCambioValor.Size = new System.Drawing.Size(200, 40);
            this.lblCambioValor.Text = "---";
            this.lblCambioValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCambioValor.TabIndex = 13;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(38, 50, 56);
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(20, 500);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(150, 40);
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(239, 108, 0);
            this.btnPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.Location = new System.Drawing.Point(510, 480);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(160, 52);
            this.btnPdf.Text = "Exportar a PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.TabIndex = 5;
            this.btnPdf.Click += new System.EventHandler(this.BtnPdf_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(680, 480);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(160, 52);
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.TabIndex = 6;
            this.btnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // FormTicket
            // 
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.lblArticulos);
            this.Controls.Add(this.gbCobro);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnPagar);
            this.AcceptButton = this.btnPagar;
            this.Name = "FormTicket";
            this.Shown += new System.EventHandler(this.FormTicket_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.gbCobro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.PictureBox picLogoEncabezado;
        private System.Windows.Forms.Label lblTituloEncabezado;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.GroupBox gbCobro;
        private System.Windows.Forms.Label lblSubtotalTxt;
        private System.Windows.Forms.Label lblSubtotalValor;
        private System.Windows.Forms.Label lblCuponTxt;
        private System.Windows.Forms.ComboBox cmbDescuento;
        private System.Windows.Forms.Label lblDescuentoTxt;
        private System.Windows.Forms.Label lblDescuentoValor;
        private System.Windows.Forms.Label lblIvaTxt;
        private System.Windows.Forms.Label lblIvaValor;
        private System.Windows.Forms.Label lblTotalTxt;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Label lblPagoTxt;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label lblCambioTxt;
        private System.Windows.Forms.Label lblCambioValor;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
    }
}
