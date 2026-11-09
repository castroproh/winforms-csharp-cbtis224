namespace PDV
{
    partial class FormTicket
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

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle hdrStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle defStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.header = new PDV.BufPanel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblReloj = new System.Windows.Forms.Label();
            this.btnCorte = new PDV.AnimButton();
            this.left = new PDV.BufPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblPrecioCap = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.studio = new PDV.ColorStudio();
            this.btnAgregar = new PDV.AnimButton();
            this.btnEditar = new PDV.AnimButton();
            this.btnEliminar = new PDV.AnimButton();
            this.btnLimpiar = new PDV.AnimButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pay = new PDV.BufPanel();
            this.lblCobro = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.chipDesc = new PDV.ChipBar();
            this.lblTotalCap = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblRecCap = new System.Windows.Forms.Label();
            this.txtRecibido = new System.Windows.Forms.TextBox();
            this.chipCash = new PDV.ChipBar();
            this.lblCambioCap = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblCambioNota = new System.Windows.Forms.Label();
            this.btnPagar = new PDV.AnimButton();
            this.status = new PDV.BufPanel();
            this.ticket = new PDV.TicketPaper();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fadeTimer = new System.Windows.Forms.Timer(this.components);
            this.headerTimer = new System.Windows.Forms.Timer(this.components);
            this.header.SuspendLayout();
            this.left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Name = "header";
            this.header.BackColor = System.Drawing.Color.FromArgb(14, 17, 34);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Size = new System.Drawing.Size(1280, 68);
            this.header.TabIndex = 0;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            // 
            // lblLogo
            // 
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(244, 241, 232);
            this.lblLogo.Location = new System.Drawing.Point(22, 10);
            this.lblLogo.Text = "Pymasa";
            this.lblLogo.TabIndex = 1;
            // 
            // lblTag
            // 
            this.lblTag.Name = "lblTag";
            this.lblTag.AutoSize = true;
            this.lblTag.BackColor = System.Drawing.Color.Transparent;
            this.lblTag.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTag.ForeColor = System.Drawing.Color.FromArgb(255, 214, 10);
            this.lblTag.Location = new System.Drawing.Point(176, 14);
            this.lblTag.Text = "PUNTO DE VENTA";
            this.lblTag.TabIndex = 2;
            // 
            // lblSub
            // 
            this.lblSub.Name = "lblSub";
            this.lblSub.AutoSize = true;
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(154, 163, 199);
            this.lblSub.Location = new System.Drawing.Point(179, 38);
            this.lblSub.Text = "Pinturas para profesionales  ·  Culiacán, Sinaloa";
            this.lblSub.TabIndex = 3;
            // 
            // lblReloj
            // 
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReloj.BackColor = System.Drawing.Color.Transparent;
            this.lblReloj.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReloj.ForeColor = System.Drawing.Color.FromArgb(244, 241, 232);
            this.lblReloj.Location = new System.Drawing.Point(1098, 12);
            this.lblReloj.Size = new System.Drawing.Size(160, 44);
            this.lblReloj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblReloj.Text = "00:00";
            this.lblReloj.TabIndex = 4;
            // 
            // btnCorte
            // 
            this.btnCorte.Name = "btnCorte";
            this.btnCorte.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCorte.Location = new System.Drawing.Point(650, 16);
            this.btnCorte.Size = new System.Drawing.Size(150, 36);
            this.btnCorte.Text = "Corte de caja";
            this.btnCorte.Variant = PDV.ButtonVariant.Ghost;
            this.btnCorte.TabIndex = 5;
            this.btnCorte.Click += new System.EventHandler(this.btnCorte_Click);
            // 
            // left
            // 
            this.left.Name = "left";
            this.left.BackColor = System.Drawing.Color.FromArgb(21, 26, 46);
            this.left.Dock = System.Windows.Forms.DockStyle.Left;
            this.left.Location = new System.Drawing.Point(0, 68);
            this.left.Size = new System.Drawing.Size(760, 624);
            this.left.TabIndex = 6;
            this.left.Paint += new System.Windows.Forms.PaintEventHandler(this.left_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 214, 10);
            this.lblTitulo.Location = new System.Drawing.Point(40, 14);
            this.lblTitulo.Text = "DATOS DE LA VENTA";
            this.lblTitulo.TabIndex = 7;
            // 
            // lblCliente
            // 
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(154, 163, 199);
            this.lblCliente.Location = new System.Drawing.Point(40, 34);
            this.lblCliente.Text = "CLIENTE";
            this.lblCliente.TabIndex = 8;
            // 
            // txtCliente
            // 
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(36, 44, 76);
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliente.ForeColor = System.Drawing.Color.FromArgb(244, 241, 232);
            this.txtCliente.Location = new System.Drawing.Point(48, 56);
            this.txtCliente.Size = new System.Drawing.Size(300, 23);
            this.txtCliente.TabIndex = 9;
            // 
            // lblTel
            // 
            this.lblTel.Name = "lblTel";
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTel.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTel.ForeColor = System.Drawing.Color.FromArgb(154, 163, 199);
            this.lblTel.Location = new System.Drawing.Point(372, 34);
            this.lblTel.Text = "TELÉFONO";
            this.lblTel.TabIndex = 10;
            // 
            // txtTel
            // 
            this.txtTel.Name = "txtTel";
            this.txtTel.BackColor = System.Drawing.Color.FromArgb(36, 44, 76);
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTel.ForeColor = System.Drawing.Color.FromArgb(244, 241, 232);
            this.txtTel.Location = new System.Drawing.Point(380, 56);
            this.txtTel.Size = new System.Drawing.Size(180, 23);
            this.txtTel.TabIndex = 11;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(154, 163, 199);
            this.lblBuscar.Location = new System.Drawing.Point(584, 34);
            this.lblBuscar.Text = "BUSCAR PRODUCTO";
            this.lblBuscar.TabIndex = 12;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(36, 44, 76);
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(244, 241, 232);
            this.txtBuscar.Location = new System.Drawing.Point(592, 56);
            this.txtBuscar.Size = new System.Drawing.Size(112, 23);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // lblProducto
            // 
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProducto.ForeColor = System.Drawing.Color.FromArgb(154, 163, 199);
            this.lblProducto.Location = new System.Drawing.Point(40, 92);
            this.lblProducto.Text = "PRODUCTO";
            this.lblProducto.TabIndex = 14;
            // 
            // cmbProd
            // 
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.BackColor = System.Drawing.Color.FromArgb(36, 44, 76);
            this.cmbProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbProd.ForeColor = System.Drawing.Color.FromArgb(244, 241, 232);
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(40, 116);
            this.cmbProd.Size = new System.Drawing.Size(400, 28);
            this.cmbProd.TabIndex = 15;
            this.cmbProd.SelectedIndexChanged += new System.EventHandler(this.cmbProd_SelectedIndexChanged);
            // 
            // lblCant
            // 
            this.lblCant.Name = "lblCant";
            this.lblCant.AutoSize = true;
            this.lblCant.BackColor = System.Drawing.Color.Transparent;
            this.lblCant.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCant.ForeColor = System.Drawing.Color.FromArgb(154, 163, 199);
            this.lblCant.Location = new System.Drawing.Point(456, 92);
            this.lblCant.Text = "CANTIDAD";
            this.lblCant.TabIndex = 16;
            // 
            // txtCant
            // 
            this.txtCant.Name = "txtCant";
            this.txtCant.BackColor = System.Drawing.Color.FromArgb(36, 44, 76);
            this.txtCant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCant.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCant.ForeColor = System.Drawing.Color.FromArgb(244, 241, 232);
            this.txtCant.Location = new System.Drawing.Point(464, 118);
            this.txtCant.Size = new System.Drawing.Size(70, 23);
            this.txtCant.TabIndex = 17;
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            // 
            // lblPrecioCap
            // 
            this.lblPrecioCap.Name = "lblPrecioCap";
            this.lblPrecioCap.AutoSize = true;
            this.lblPrecioCap.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioCap.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioCap.ForeColor = System.Drawing.Color.FromArgb(154, 163, 199);
            this.lblPrecioCap.Location = new System.Drawing.Point(566, 92);
            this.lblPrecioCap.Text = "PRECIO UNITARIO";
            this.lblPrecioCap.TabIndex = 18;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(255, 214, 10);
            this.lblPrecio.Location = new System.Drawing.Point(566, 112);
            this.lblPrecio.Text = "$0.00";
            this.lblPrecio.TabIndex = 19;
            // 
            // txtColor
            // 
            this.txtColor.Name = "txtColor";
            this.txtColor.BackColor = System.Drawing.Color.FromArgb(36, 44, 76);
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtColor.ForeColor = System.Drawing.Color.FromArgb(244, 241, 232);
            this.txtColor.Location = new System.Drawing.Point(48, 216);
            this.txtColor.Size = new System.Drawing.Size(112, 23);
            this.txtColor.TabIndex = 20;
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            // 
            // studio
            // 
            this.studio.Name = "studio";
            this.studio.Location = new System.Drawing.Point(24, 164);
            this.studio.Size = new System.Drawing.Size(712, 176);
            this.studio.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Location = new System.Drawing.Point(24, 348);
            this.btnAgregar.Size = new System.Drawing.Size(200, 38);
            this.btnAgregar.Text = "+  Agregar";
            this.btnAgregar.Variant = PDV.ButtonVariant.Primary;
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Location = new System.Drawing.Point(236, 348);
            this.btnEditar.Size = new System.Drawing.Size(160, 38);
            this.btnEditar.Text = "✎  Editar";
            this.btnEditar.Variant = PDV.ButtonVariant.Info;
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Location = new System.Drawing.Point(408, 348);
            this.btnEliminar.Size = new System.Drawing.Size(160, 38);
            this.btnEliminar.Text = "✕  Eliminar";
            this.btnEliminar.Variant = PDV.ButtonVariant.Danger;
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Location = new System.Drawing.Point(580, 348);
            this.btnLimpiar.Size = new System.Drawing.Size(156, 38);
            this.btnLimpiar.Text = "↺  Limpiar";
            this.btnLimpiar.Variant = PDV.ButtonVariant.Ghost;
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            altStyle.BackColor = System.Drawing.Color.FromArgb(34, 42, 72);
            this.dgv.AlternatingRowsDefaultCellStyle = altStyle;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(30, 37, 64);
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            hdrStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            hdrStyle.BackColor = System.Drawing.Color.FromArgb(42, 51, 86);
            hdrStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            hdrStyle.ForeColor = System.Drawing.Color.FromArgb(154, 163, 199);
            hdrStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            hdrStyle.SelectionBackColor = System.Drawing.Color.FromArgb(42, 51, 86);
            hdrStyle.SelectionForeColor = System.Drawing.Color.FromArgb(154, 163, 199);
            hdrStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersDefaultCellStyle = hdrStyle;
            this.dgv.ColumnHeadersHeight = 32;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colCliente,
            this.colProducto,
            this.colColor,
            this.colPrecio,
            this.colCantidad,
            this.colSubtotal});
            defStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            defStyle.BackColor = System.Drawing.Color.FromArgb(30, 37, 64);
            defStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            defStyle.ForeColor = System.Drawing.Color.FromArgb(244, 241, 232);
            defStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            defStyle.SelectionBackColor = System.Drawing.Color.FromArgb(58, 68, 108);
            defStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 214, 10);
            defStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = defStyle;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(58, 68, 108);
            this.dgv.Location = new System.Drawing.Point(24, 394);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(712, 214);
            this.dgv.TabIndex = 26;
            this.dgv.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            // 
            // pay
            // 
            this.pay.Name = "pay";
            this.pay.BackColor = System.Drawing.Color.FromArgb(21, 26, 46);
            this.pay.Dock = System.Windows.Forms.DockStyle.Right;
            this.pay.Location = new System.Drawing.Point(1080, 68);
            this.pay.Size = new System.Drawing.Size(200, 624);
            this.pay.TabIndex = 27;
            this.pay.Paint += new System.Windows.Forms.PaintEventHandler(this.pay_Paint);
            // 
            // lblCobro
            // 
            this.lblCobro.Name = "lblCobro";
            this.lblCobro.AutoSize = true;
            this.lblCobro.BackColor = System.Drawing.Color.Transparent;
            this.lblCobro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCobro.ForeColor = System.Drawing.Color.FromArgb(255, 214, 10);
            this.lblCobro.Location = new System.Drawing.Point(16, 16);
            this.lblCobro.Text = "COBRO";
            this.lblCobro.TabIndex = 28;
            // 
            // lblDesc
            // 
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(154, 163, 199);
            this.lblDesc.Location = new System.Drawing.Point(16, 46);
            this.lblDesc.Text = "DESCUENTO";
            this.lblDesc.TabIndex = 29;
            // 
            // chipDesc
            // 
            this.chipDesc.Name = "chipDesc";
            this.chipDesc.Location = new System.Drawing.Point(16, 66);
            this.chipDesc.Size = new System.Drawing.Size(168, 66);
            this.chipDesc.TabIndex = 30;
            // 
            // lblTotalCap
            // 
            this.lblTotalCap.Name = "lblTotalCap";
            this.lblTotalCap.AutoSize = true;
            this.lblTotalCap.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCap.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCap.ForeColor = System.Drawing.Color.FromArgb(154, 163, 199);
            this.lblTotalCap.Location = new System.Drawing.Point(16, 150);
            this.lblTotalCap.Text = "TOTAL A PAGAR";
            this.lblTotalCap.TabIndex = 31;
            // 
            // lblTotal
            // 
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(255, 214, 10);
            this.lblTotal.Location = new System.Drawing.Point(16, 168);
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TabIndex = 32;
            // 
            // lblRecCap
            // 
            this.lblRecCap.Name = "lblRecCap";
            this.lblRecCap.AutoSize = true;
            this.lblRecCap.BackColor = System.Drawing.Color.Transparent;
            this.lblRecCap.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecCap.ForeColor = System.Drawing.Color.FromArgb(154, 163, 199);
            this.lblRecCap.Location = new System.Drawing.Point(16, 232);
            this.lblRecCap.Text = "EFECTIVO RECIBIDO";
            this.lblRecCap.TabIndex = 33;
            // 
            // txtRecibido
            // 
            this.txtRecibido.Name = "txtRecibido";
            this.txtRecibido.BackColor = System.Drawing.Color.FromArgb(36, 44, 76);
            this.txtRecibido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecibido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecibido.ForeColor = System.Drawing.Color.FromArgb(244, 241, 232);
            this.txtRecibido.Location = new System.Drawing.Point(24, 258);
            this.txtRecibido.Size = new System.Drawing.Size(152, 23);
            this.txtRecibido.TabIndex = 34;
            this.txtRecibido.TextChanged += new System.EventHandler(this.txtRecibido_TextChanged);
            this.txtRecibido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecibido_KeyPress);
            // 
            // chipCash
            // 
            this.chipCash.Name = "chipCash";
            this.chipCash.Location = new System.Drawing.Point(16, 298);
            this.chipCash.Size = new System.Drawing.Size(168, 66);
            this.chipCash.TabIndex = 35;
            // 
            // lblCambioCap
            // 
            this.lblCambioCap.Name = "lblCambioCap";
            this.lblCambioCap.AutoSize = true;
            this.lblCambioCap.BackColor = System.Drawing.Color.Transparent;
            this.lblCambioCap.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCambioCap.ForeColor = System.Drawing.Color.FromArgb(154, 163, 199);
            this.lblCambioCap.Location = new System.Drawing.Point(16, 384);
            this.lblCambioCap.Text = "CAMBIO";
            this.lblCambioCap.TabIndex = 36;
            // 
            // lblCambio
            // 
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.AutoSize = true;
            this.lblCambio.BackColor = System.Drawing.Color.Transparent;
            this.lblCambio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCambio.ForeColor = System.Drawing.Color.FromArgb(154, 163, 199);
            this.lblCambio.Location = new System.Drawing.Point(16, 402);
            this.lblCambio.Text = "—";
            this.lblCambio.TabIndex = 37;
            // 
            // lblCambioNota
            // 
            this.lblCambioNota.Name = "lblCambioNota";
            this.lblCambioNota.AutoSize = true;
            this.lblCambioNota.BackColor = System.Drawing.Color.Transparent;
            this.lblCambioNota.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCambioNota.ForeColor = System.Drawing.Color.FromArgb(154, 163, 199);
            this.lblCambioNota.Location = new System.Drawing.Point(16, 440);
            this.lblCambioNota.Text = "Ingresa el efectivo recibido";
            this.lblCambioNota.TabIndex = 38;
            // 
            // btnPagar
            // 
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPagar.Location = new System.Drawing.Point(16, 548);
            this.btnPagar.Size = new System.Drawing.Size(168, 56);
            this.btnPagar.Text = "✔  COBRAR";
            this.btnPagar.Variant = PDV.ButtonVariant.Success;
            this.btnPagar.TabIndex = 39;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.BackColor = System.Drawing.Color.FromArgb(14, 17, 34);
            this.status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status.Location = new System.Drawing.Point(0, 692);
            this.status.Size = new System.Drawing.Size(1280, 28);
            this.status.TabIndex = 40;
            this.status.Paint += new System.Windows.Forms.PaintEventHandler(this.status_Paint);
            // 
            // ticket
            // 
            this.ticket.Name = "ticket";
            this.ticket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticket.Location = new System.Drawing.Point(760, 68);
            this.ticket.Size = new System.Drawing.Size(320, 624);
            this.ticket.TabIndex = 41;
            // 
            // columnas del DataGridView
            // 
            this.colNum.FillWeight = 20F;
            this.colNum.HeaderText = "#";
            this.colNum.MinimumWidth = 6;
            this.colNum.Name = "Num";
            this.colNum.ReadOnly = true;
            this.colCliente.FillWeight = 60F;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 6;
            this.colCliente.Name = "Cliente";
            this.colCliente.ReadOnly = true;
            this.colProducto.FillWeight = 150F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 6;
            this.colProducto.Name = "Producto";
            this.colProducto.ReadOnly = true;
            this.colColor.FillWeight = 70F;
            this.colColor.HeaderText = "Color";
            this.colColor.MinimumWidth = 6;
            this.colColor.Name = "Codigo Color";
            this.colColor.ReadOnly = true;
            this.colPrecio.FillWeight = 60F;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "Precio";
            this.colPrecio.ReadOnly = true;
            this.colCantidad.FillWeight = 35F;
            this.colCantidad.HeaderText = "Cant.";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "Cantidad";
            this.colCantidad.ReadOnly = true;
            this.colSubtotal.FillWeight = 65F;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MinimumWidth = 6;
            this.colSubtotal.Name = "Subtotal";
            this.colSubtotal.ReadOnly = true;
            // 
            // temporizadores
            // 
            this.fadeTimer.Interval = 15;
            this.fadeTimer.Tick += new System.EventHandler(this.fadeTimer_Tick);
            this.headerTimer.Interval = 20;
            this.headerTimer.Tick += new System.EventHandler(this.headerTimer_Tick);
            // 
            // jerarquía de controles
            // 
            this.header.Controls.Add(this.lblLogo);
            this.header.Controls.Add(this.lblTag);
            this.header.Controls.Add(this.lblSub);
            this.header.Controls.Add(this.lblReloj);
            this.header.Controls.Add(this.btnCorte);
            this.left.Controls.Add(this.lblTitulo);
            this.left.Controls.Add(this.lblCliente);
            this.left.Controls.Add(this.txtCliente);
            this.left.Controls.Add(this.lblTel);
            this.left.Controls.Add(this.txtTel);
            this.left.Controls.Add(this.lblBuscar);
            this.left.Controls.Add(this.txtBuscar);
            this.left.Controls.Add(this.lblProducto);
            this.left.Controls.Add(this.cmbProd);
            this.left.Controls.Add(this.lblCant);
            this.left.Controls.Add(this.txtCant);
            this.left.Controls.Add(this.lblPrecioCap);
            this.left.Controls.Add(this.lblPrecio);
            this.left.Controls.Add(this.txtColor);
            this.left.Controls.Add(this.studio);
            this.left.Controls.Add(this.btnAgregar);
            this.left.Controls.Add(this.btnEditar);
            this.left.Controls.Add(this.btnEliminar);
            this.left.Controls.Add(this.btnLimpiar);
            this.left.Controls.Add(this.dgv);
            this.pay.Controls.Add(this.lblCobro);
            this.pay.Controls.Add(this.lblDesc);
            this.pay.Controls.Add(this.chipDesc);
            this.pay.Controls.Add(this.lblTotalCap);
            this.pay.Controls.Add(this.lblTotal);
            this.pay.Controls.Add(this.lblRecCap);
            this.pay.Controls.Add(this.txtRecibido);
            this.pay.Controls.Add(this.chipCash);
            this.pay.Controls.Add(this.lblCambioCap);
            this.pay.Controls.Add(this.lblCambio);
            this.pay.Controls.Add(this.lblCambioNota);
            this.pay.Controls.Add(this.btnPagar);
            // 
            // FormTicket
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(21, 26, 46);
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.ticket);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.left);
            this.Controls.Add(this.status);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1280, 690);
            this.Name = "FormTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV - Pymasa - Ticket de venta";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.left.ResumeLayout(false);
            this.left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private PDV.BufPanel header;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblReloj;
        private PDV.AnimButton btnCorte;
        private PDV.BufPanel left;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblPrecioCap;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtColor;
        private PDV.ColorStudio studio;
        private PDV.AnimButton btnAgregar;
        private PDV.AnimButton btnEditar;
        private PDV.AnimButton btnEliminar;
        private PDV.AnimButton btnLimpiar;
        private System.Windows.Forms.DataGridView dgv;
        private PDV.BufPanel pay;
        private System.Windows.Forms.Label lblCobro;
        private System.Windows.Forms.Label lblDesc;
        private PDV.ChipBar chipDesc;
        private System.Windows.Forms.Label lblTotalCap;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRecCap;
        private System.Windows.Forms.TextBox txtRecibido;
        private PDV.ChipBar chipCash;
        private System.Windows.Forms.Label lblCambioCap;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblCambioNota;
        private PDV.AnimButton btnPagar;
        private PDV.BufPanel status;
        private PDV.TicketPaper ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Timer fadeTimer;
        private System.Windows.Forms.Timer headerTimer;
    }
}
