namespace Temas_Semana_30_nov_4_dic
{
    partial class FormVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.picLogoEncabezado = new System.Windows.Forms.PictureBox();
            this.lblTituloEncabezado = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gbAgregar = new System.Windows.Forms.GroupBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.lblArticulos = new System.Windows.Forms.Label();
            this.gbTotales = new System.Windows.Forms.GroupBox();
            this.lblSubtotalTxt = new System.Windows.Forms.Label();
            this.lblSubtotalValor = new System.Windows.Forms.Label();
            this.lblIvaTxt = new System.Windows.Forms.Label();
            this.lblIvaValor = new System.Windows.Forms.Label();
            this.lblTotalTxt = new System.Windows.Forms.Label();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.gbAgregar.SuspendLayout();
            this.gbTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.picLogoEncabezado);
            this.pnlEncabezado.Controls.Add(this.lblTituloEncabezado);
            this.pnlEncabezado.Controls.Add(this.lblUsuario);
            this.pnlEncabezado.Controls.Add(this.lblFecha);
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(38, 50, 56);
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(960, 70);
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
            this.lblTituloEncabezado.Text = "PYMASA - Punto de venta";
            this.lblTituloEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloEncabezado.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = false;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(640, 10);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(300, 26);
            this.lblUsuario.Text = "Cajero: Alumno1";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUsuario.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = false;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFecha.Location = new System.Drawing.Point(640, 36);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(300, 24);
            this.lblFecha.Text = "";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFecha.TabIndex = 3;
            // 
            // gbAgregar
            // 
            this.gbAgregar.Controls.Add(this.lblProducto);
            this.gbAgregar.Controls.Add(this.cmbProducto);
            this.gbAgregar.Controls.Add(this.lblPrecio);
            this.gbAgregar.Controls.Add(this.txtPrecio);
            this.gbAgregar.Controls.Add(this.lblCantidad);
            this.gbAgregar.Controls.Add(this.txtCantidad);
            this.gbAgregar.Controls.Add(this.btnAgregar);
            this.gbAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbAgregar.Location = new System.Drawing.Point(20, 85);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(920, 78);
            this.gbAgregar.TabStop = false;
            this.gbAgregar.Text = "Agregar producto";
            this.gbAgregar.TabIndex = 1;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = false;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProducto.Location = new System.Drawing.Point(15, 32);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(70, 26);
            this.lblProducto.Text = "Producto:";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProducto.TabIndex = 0;
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProducto.Location = new System.Drawing.Point(90, 31);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(230, 28);
            this.cmbProducto.TabIndex = 1;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.CmbProducto_SelectedIndexChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = false;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrecio.Location = new System.Drawing.Point(340, 32);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 26);
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrecio.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrecio.Location = new System.Drawing.Point(398, 31);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(90, 28);
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = false;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCantidad.Location = new System.Drawing.Point(510, 32);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 26);
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCantidad.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCantidad.Location = new System.Drawing.Point(585, 31);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(60, 28);
            this.txtCantidad.Text = "1";
            this.txtCantidad.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(0, 121, 107);
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(670, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 34);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.AllowUserToDeleteRows = false;
            this.dgvVenta.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(245, 248, 250);
            this.dgvVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgvVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(0, 121, 107);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(0, 121, 107);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVenta.ColumnHeadersHeight = 34;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colProducto,
                        this.colPrecio,
                        this.colCantidad,
                        this.colSubtotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVenta.EnableHeadersVisualStyles = false;
            this.dgvVenta.Location = new System.Drawing.Point(20, 180);
            this.dgvVenta.MultiSelect = false;
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.RowHeadersVisible = false;
            this.dgvVenta.RowTemplate.Height = 28;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.Size = new System.Drawing.Size(620, 330);
            this.dgvVenta.TabIndex = 2;
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 190F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            // 
            // colPrecio
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrecio.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            // 
            // colCantidad
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCantidad.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colSubtotal
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSubtotal.DefaultCellStyle = dataGridViewCellStyle7;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = false;
            this.lblArticulos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblArticulos.ForeColor = System.Drawing.Color.FromArgb(38, 50, 56);
            this.lblArticulos.Location = new System.Drawing.Point(20, 518);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(300, 26);
            this.lblArticulos.Text = "Articulos: 0";
            this.lblArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblArticulos.TabIndex = 3;
            // 
            // gbTotales
            // 
            this.gbTotales.Controls.Add(this.lblSubtotalTxt);
            this.gbTotales.Controls.Add(this.lblSubtotalValor);
            this.gbTotales.Controls.Add(this.lblIvaTxt);
            this.gbTotales.Controls.Add(this.lblIvaValor);
            this.gbTotales.Controls.Add(this.lblTotalTxt);
            this.gbTotales.Controls.Add(this.lblTotalValor);
            this.gbTotales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbTotales.Location = new System.Drawing.Point(660, 180);
            this.gbTotales.Name = "gbTotales";
            this.gbTotales.Size = new System.Drawing.Size(280, 195);
            this.gbTotales.TabStop = false;
            this.gbTotales.Text = "Totales";
            this.gbTotales.TabIndex = 4;
            // 
            // lblSubtotalTxt
            // 
            this.lblSubtotalTxt.AutoSize = false;
            this.lblSubtotalTxt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtotalTxt.Location = new System.Drawing.Point(15, 32);
            this.lblSubtotalTxt.Name = "lblSubtotalTxt";
            this.lblSubtotalTxt.Size = new System.Drawing.Size(110, 28);
            this.lblSubtotalTxt.Text = "Subtotal:";
            this.lblSubtotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSubtotalTxt.TabIndex = 0;
            // 
            // lblSubtotalValor
            // 
            this.lblSubtotalValor.AutoSize = false;
            this.lblSubtotalValor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalValor.Location = new System.Drawing.Point(125, 32);
            this.lblSubtotalValor.Name = "lblSubtotalValor";
            this.lblSubtotalValor.Size = new System.Drawing.Size(140, 28);
            this.lblSubtotalValor.Text = "$0.00";
            this.lblSubtotalValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSubtotalValor.TabIndex = 1;
            // 
            // lblIvaTxt
            // 
            this.lblIvaTxt.AutoSize = false;
            this.lblIvaTxt.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblIvaTxt.Location = new System.Drawing.Point(15, 72);
            this.lblIvaTxt.Name = "lblIvaTxt";
            this.lblIvaTxt.Size = new System.Drawing.Size(110, 28);
            this.lblIvaTxt.Text = "IVA 16%:";
            this.lblIvaTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIvaTxt.TabIndex = 2;
            // 
            // lblIvaValor
            // 
            this.lblIvaValor.AutoSize = false;
            this.lblIvaValor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblIvaValor.Location = new System.Drawing.Point(125, 72);
            this.lblIvaValor.Name = "lblIvaValor";
            this.lblIvaValor.Size = new System.Drawing.Size(140, 28);
            this.lblIvaValor.Text = "$0.00";
            this.lblIvaValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIvaValor.TabIndex = 3;
            // 
            // lblTotalTxt
            // 
            this.lblTotalTxt.AutoSize = false;
            this.lblTotalTxt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalTxt.ForeColor = System.Drawing.Color.FromArgb(0, 121, 107);
            this.lblTotalTxt.Location = new System.Drawing.Point(15, 128);
            this.lblTotalTxt.Name = "lblTotalTxt";
            this.lblTotalTxt.Size = new System.Drawing.Size(100, 40);
            this.lblTotalTxt.Text = "TOTAL:";
            this.lblTotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalTxt.TabIndex = 4;
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.AutoSize = false;
            this.lblTotalValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalValor.ForeColor = System.Drawing.Color.FromArgb(0, 121, 107);
            this.lblTotalValor.Location = new System.Drawing.Point(105, 128);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(160, 40);
            this.lblTotalValor.Text = "$0.00";
            this.lblTotalValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalValor.TabIndex = 5;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(239, 108, 0);
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Location = new System.Drawing.Point(660, 392);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(134, 40);
            this.btnQuitar.Text = "Quitar producto";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(806, 392);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(134, 40);
            this.btnLimpiar.Text = "Limpiar venta";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(660, 446);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(280, 54);
            this.btnPagar.Text = "Pagar  (tema 27)";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.TabIndex = 7;
            this.btnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(38, 50, 56);
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(760, 530);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(180, 38);
            this.btnRegresar.Text = "Regresar al menu";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // FormVenta
            // 
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.gbAgregar);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.lblArticulos);
            this.Controls.Add(this.gbTotales);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnRegresar);
            this.AcceptButton = this.btnAgregar;
            this.Name = "FormVenta";
            this.VisibleChanged += new System.EventHandler(this.FormVenta_VisibleChanged);
            this.Shown += new System.EventHandler(this.FormVenta_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.gbAgregar.ResumeLayout(false);
            this.gbTotales.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.PictureBox picLogoEncabezado;
        private System.Windows.Forms.Label lblTituloEncabezado;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox gbAgregar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.GroupBox gbTotales;
        private System.Windows.Forms.Label lblSubtotalTxt;
        private System.Windows.Forms.Label lblSubtotalValor;
        private System.Windows.Forms.Label lblIvaTxt;
        private System.Windows.Forms.Label lblIvaValor;
        private System.Windows.Forms.Label lblTotalTxt;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    }
}
