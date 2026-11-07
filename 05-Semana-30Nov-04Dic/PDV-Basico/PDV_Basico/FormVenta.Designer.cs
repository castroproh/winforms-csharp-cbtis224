namespace PDV
{
    partial class FormVenta
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.TBCLIENTE = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.TBTELEFONO = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.TBBUSCAR = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.CBPRODUCTOS = new System.Windows.Forms.ComboBox();
            this.lblPrecioCap = new System.Windows.Forms.Label();
            this.LPRECIO = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.TBCOLOR = new System.Windows.Forms.TextBox();
            this.PCOLOR = new System.Windows.Forms.Panel();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.TBCANTIDAD = new System.Windows.Forms.TextBox();
            this.BAGREGAR = new System.Windows.Forms.Button();
            this.BEDITAR = new System.Windows.Forms.Button();
            this.BELIMINAR = new System.Windows.Forms.Button();
            this.BLIMPIAR = new System.Windows.Forms.Button();
            this.DGVVENTA = new System.Windows.Forms.DataGridView();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.CBDESCUENTO = new System.Windows.Forms.ComboBox();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.TBEFECTIVO = new System.Windows.Forms.TextBox();
            this.lblCambioCap = new System.Windows.Forms.Label();
            this.LCAMBIO = new System.Windows.Forms.Label();
            this.BPAGAR = new System.Windows.Forms.Button();
            this.lblSubtotalCap = new System.Windows.Forms.Label();
            this.LSUBTOTAL = new System.Windows.Forms.Label();
            this.lblDescuentoCap = new System.Windows.Forms.Label();
            this.LDESCUENTO = new System.Windows.Forms.Label();
            this.lblIvaCap = new System.Windows.Forms.Label();
            this.LIVA = new System.Windows.Forms.Label();
            this.lblTotalCap = new System.Windows.Forms.Label();
            this.LTOTAL = new System.Windows.Forms.Label();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.PCOLOR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVENTA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Name = "panelTop";
            this.panelTop.BackColor = System.Drawing.Color.Black;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Size = new System.Drawing.Size(1000, 70);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 18);
            this.lblTitulo.Text = "Pymasa  -  PUNTO DE VENTA";
            this.lblTitulo.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.ForeColor = System.Drawing.Color.Black;
            this.lblCliente.Location = new System.Drawing.Point(20, 88);
            this.lblCliente.Text = "Cliente";
            this.lblCliente.TabIndex = 2;
            // 
            // TBCLIENTE
            // 
            this.TBCLIENTE.Name = "TBCLIENTE";
            this.TBCLIENTE.Location = new System.Drawing.Point(20, 110);
            this.TBCLIENTE.Size = new System.Drawing.Size(180, 23);
            this.TBCLIENTE.TabIndex = 3;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.ForeColor = System.Drawing.Color.Black;
            this.lblTelefono.Location = new System.Drawing.Point(220, 88);
            this.lblTelefono.Text = "Teléfono";
            this.lblTelefono.TabIndex = 4;
            // 
            // TBTELEFONO
            // 
            this.TBTELEFONO.Name = "TBTELEFONO";
            this.TBTELEFONO.Location = new System.Drawing.Point(220, 110);
            this.TBTELEFONO.Size = new System.Drawing.Size(130, 23);
            this.TBTELEFONO.TabIndex = 5;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(370, 88);
            this.lblBuscar.Text = "Buscar producto";
            this.lblBuscar.TabIndex = 6;
            // 
            // TBBUSCAR
            // 
            this.TBBUSCAR.Name = "TBBUSCAR";
            this.TBBUSCAR.Location = new System.Drawing.Point(370, 110);
            this.TBBUSCAR.Size = new System.Drawing.Size(160, 23);
            this.TBBUSCAR.TabIndex = 7;
            this.TBBUSCAR.TextChanged += new System.EventHandler(this.TBBUSCAR_TextChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProducto.ForeColor = System.Drawing.Color.Black;
            this.lblProducto.Location = new System.Drawing.Point(20, 148);
            this.lblProducto.Text = "Producto";
            this.lblProducto.TabIndex = 8;
            // 
            // CBPRODUCTOS
            // 
            this.CBPRODUCTOS.Name = "CBPRODUCTOS";
            this.CBPRODUCTOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPRODUCTOS.FormattingEnabled = true;
            this.CBPRODUCTOS.Location = new System.Drawing.Point(20, 170);
            this.CBPRODUCTOS.Size = new System.Drawing.Size(330, 23);
            this.CBPRODUCTOS.TabIndex = 9;
            this.CBPRODUCTOS.SelectedIndexChanged += new System.EventHandler(this.CBPRODUCTOS_SelectedIndexChanged);
            // 
            // lblPrecioCap
            // 
            this.lblPrecioCap.Name = "lblPrecioCap";
            this.lblPrecioCap.AutoSize = true;
            this.lblPrecioCap.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioCap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioCap.ForeColor = System.Drawing.Color.Black;
            this.lblPrecioCap.Location = new System.Drawing.Point(370, 148);
            this.lblPrecioCap.Text = "Precio";
            this.lblPrecioCap.TabIndex = 10;
            // 
            // LPRECIO
            // 
            this.LPRECIO.Name = "LPRECIO";
            this.LPRECIO.AutoSize = true;
            this.LPRECIO.BackColor = System.Drawing.Color.Transparent;
            this.LPRECIO.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LPRECIO.ForeColor = System.Drawing.Color.Black;
            this.LPRECIO.Location = new System.Drawing.Point(370, 172);
            this.LPRECIO.Text = "$0.00";
            this.LPRECIO.TabIndex = 11;
            // 
            // lblColor
            // 
            this.lblColor.Name = "lblColor";
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColor.ForeColor = System.Drawing.Color.Black;
            this.lblColor.Location = new System.Drawing.Point(460, 148);
            this.lblColor.Text = "Color #HEX";
            this.lblColor.TabIndex = 12;
            // 
            // TBCOLOR
            // 
            this.TBCOLOR.Name = "TBCOLOR";
            this.TBCOLOR.Location = new System.Drawing.Point(460, 170);
            this.TBCOLOR.Size = new System.Drawing.Size(90, 23);
            this.TBCOLOR.TabIndex = 13;
            this.TBCOLOR.TextChanged += new System.EventHandler(this.TBCOLOR_TextChanged);
            // 
            // PCOLOR
            // 
            this.PCOLOR.Name = "PCOLOR";
            this.PCOLOR.BackColor = System.Drawing.Color.White;
            this.PCOLOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCOLOR.Location = new System.Drawing.Point(560, 166);
            this.PCOLOR.Size = new System.Drawing.Size(36, 30);
            this.PCOLOR.TabIndex = 14;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.ForeColor = System.Drawing.Color.Black;
            this.lblCantidad.Location = new System.Drawing.Point(610, 148);
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.TabIndex = 15;
            // 
            // TBCANTIDAD
            // 
            this.TBCANTIDAD.Name = "TBCANTIDAD";
            this.TBCANTIDAD.Location = new System.Drawing.Point(610, 170);
            this.TBCANTIDAD.Size = new System.Drawing.Size(70, 23);
            this.TBCANTIDAD.TabIndex = 16;
            this.TBCANTIDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCANTIDAD_KeyPress);
            // 
            // BAGREGAR
            // 
            this.BAGREGAR.Name = "BAGREGAR";
            this.BAGREGAR.BackColor = System.Drawing.Color.Black;
            this.BAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAGREGAR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BAGREGAR.ForeColor = System.Drawing.Color.Yellow;
            this.BAGREGAR.Location = new System.Drawing.Point(710, 90);
            this.BAGREGAR.Size = new System.Drawing.Size(130, 44);
            this.BAGREGAR.Text = "Agregar";
            this.BAGREGAR.UseVisualStyleBackColor = false;
            this.BAGREGAR.TabIndex = 17;
            this.BAGREGAR.Click += new System.EventHandler(this.BAGREGAR_Click);
            // 
            // BEDITAR
            // 
            this.BEDITAR.Name = "BEDITAR";
            this.BEDITAR.BackColor = System.Drawing.Color.Black;
            this.BEDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEDITAR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BEDITAR.ForeColor = System.Drawing.Color.Yellow;
            this.BEDITAR.Location = new System.Drawing.Point(850, 90);
            this.BEDITAR.Size = new System.Drawing.Size(130, 44);
            this.BEDITAR.Text = "Editar";
            this.BEDITAR.UseVisualStyleBackColor = false;
            this.BEDITAR.TabIndex = 18;
            this.BEDITAR.Click += new System.EventHandler(this.BEDITAR_Click);
            // 
            // BELIMINAR
            // 
            this.BELIMINAR.Name = "BELIMINAR";
            this.BELIMINAR.BackColor = System.Drawing.Color.Black;
            this.BELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BELIMINAR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BELIMINAR.ForeColor = System.Drawing.Color.Yellow;
            this.BELIMINAR.Location = new System.Drawing.Point(710, 146);
            this.BELIMINAR.Size = new System.Drawing.Size(130, 44);
            this.BELIMINAR.Text = "Eliminar";
            this.BELIMINAR.UseVisualStyleBackColor = false;
            this.BELIMINAR.TabIndex = 19;
            this.BELIMINAR.Click += new System.EventHandler(this.BELIMINAR_Click);
            // 
            // BLIMPIAR
            // 
            this.BLIMPIAR.Name = "BLIMPIAR";
            this.BLIMPIAR.BackColor = System.Drawing.Color.Black;
            this.BLIMPIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLIMPIAR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BLIMPIAR.ForeColor = System.Drawing.Color.Yellow;
            this.BLIMPIAR.Location = new System.Drawing.Point(850, 146);
            this.BLIMPIAR.Size = new System.Drawing.Size(130, 44);
            this.BLIMPIAR.Text = "Limpiar";
            this.BLIMPIAR.UseVisualStyleBackColor = false;
            this.BLIMPIAR.TabIndex = 20;
            this.BLIMPIAR.Click += new System.EventHandler(this.BLIMPIAR_Click);
            // 
            // DGVVENTA
            // 
            this.DGVVENTA.Name = "DGVVENTA";
            this.DGVVENTA.AllowUserToAddRows = false;
            this.DGVVENTA.AllowUserToDeleteRows = false;
            this.DGVVENTA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVVENTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVENTA.Location = new System.Drawing.Point(20, 215);
            this.DGVVENTA.MultiSelect = false;
            this.DGVVENTA.ReadOnly = true;
            this.DGVVENTA.RowHeadersVisible = false;
            this.DGVVENTA.RowHeadersWidth = 51;
            this.DGVVENTA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVVENTA.Size = new System.Drawing.Size(960, 230);
            this.DGVVENTA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colCliente,
            this.colProducto,
            this.colColor,
            this.colPrecio,
            this.colCantidad,
            this.colSubtotal});
            this.DGVVENTA.TabIndex = 21;
            // 
            // lblDescuento
            // 
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.BackColor = System.Drawing.Color.Transparent;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescuento.ForeColor = System.Drawing.Color.Black;
            this.lblDescuento.Location = new System.Drawing.Point(20, 460);
            this.lblDescuento.Text = "Descuento (%)";
            this.lblDescuento.TabIndex = 22;
            // 
            // CBDESCUENTO
            // 
            this.CBDESCUENTO.Name = "CBDESCUENTO";
            this.CBDESCUENTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDESCUENTO.FormattingEnabled = true;
            this.CBDESCUENTO.Items.AddRange(new object[] { "0", "5", "10", "15", "20", "25" });
            this.CBDESCUENTO.Location = new System.Drawing.Point(20, 482);
            this.CBDESCUENTO.Size = new System.Drawing.Size(100, 23);
            this.CBDESCUENTO.TabIndex = 23;
            this.CBDESCUENTO.SelectedIndexChanged += new System.EventHandler(this.CBDESCUENTO_SelectedIndexChanged);
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.BackColor = System.Drawing.Color.Transparent;
            this.lblEfectivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEfectivo.ForeColor = System.Drawing.Color.Black;
            this.lblEfectivo.Location = new System.Drawing.Point(150, 460);
            this.lblEfectivo.Text = "Efectivo recibido";
            this.lblEfectivo.TabIndex = 24;
            // 
            // TBEFECTIVO
            // 
            this.TBEFECTIVO.Name = "TBEFECTIVO";
            this.TBEFECTIVO.Location = new System.Drawing.Point(150, 482);
            this.TBEFECTIVO.Size = new System.Drawing.Size(120, 23);
            this.TBEFECTIVO.TabIndex = 25;
            this.TBEFECTIVO.TextChanged += new System.EventHandler(this.TBEFECTIVO_TextChanged);
            this.TBEFECTIVO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBEFECTIVO_KeyPress);
            // 
            // lblCambioCap
            // 
            this.lblCambioCap.Name = "lblCambioCap";
            this.lblCambioCap.AutoSize = true;
            this.lblCambioCap.BackColor = System.Drawing.Color.Transparent;
            this.lblCambioCap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCambioCap.ForeColor = System.Drawing.Color.Black;
            this.lblCambioCap.Location = new System.Drawing.Point(300, 460);
            this.lblCambioCap.Text = "Cambio";
            this.lblCambioCap.TabIndex = 26;
            // 
            // LCAMBIO
            // 
            this.LCAMBIO.Name = "LCAMBIO";
            this.LCAMBIO.AutoSize = true;
            this.LCAMBIO.BackColor = System.Drawing.Color.Transparent;
            this.LCAMBIO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LCAMBIO.ForeColor = System.Drawing.Color.Black;
            this.LCAMBIO.Location = new System.Drawing.Point(300, 484);
            this.LCAMBIO.Text = "$0.00";
            this.LCAMBIO.TabIndex = 27;
            // 
            // BPAGAR
            // 
            this.BPAGAR.Name = "BPAGAR";
            this.BPAGAR.BackColor = System.Drawing.Color.Black;
            this.BPAGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPAGAR.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BPAGAR.ForeColor = System.Drawing.Color.Yellow;
            this.BPAGAR.Location = new System.Drawing.Point(20, 540);
            this.BPAGAR.Size = new System.Drawing.Size(330, 56);
            this.BPAGAR.Text = "PAGAR E IMPRIMIR";
            this.BPAGAR.UseVisualStyleBackColor = false;
            this.BPAGAR.TabIndex = 28;
            this.BPAGAR.Click += new System.EventHandler(this.BPAGAR_Click);
            // 
            // lblSubtotalCap
            // 
            this.lblSubtotalCap.Name = "lblSubtotalCap";
            this.lblSubtotalCap.AutoSize = true;
            this.lblSubtotalCap.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotalCap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubtotalCap.ForeColor = System.Drawing.Color.Black;
            this.lblSubtotalCap.Location = new System.Drawing.Point(620, 462);
            this.lblSubtotalCap.Text = "Subtotal:";
            this.lblSubtotalCap.TabIndex = 29;
            // 
            // LSUBTOTAL
            // 
            this.LSUBTOTAL.Name = "LSUBTOTAL";
            this.LSUBTOTAL.AutoSize = true;
            this.LSUBTOTAL.BackColor = System.Drawing.Color.Transparent;
            this.LSUBTOTAL.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LSUBTOTAL.ForeColor = System.Drawing.Color.Black;
            this.LSUBTOTAL.Location = new System.Drawing.Point(780, 462);
            this.LSUBTOTAL.Text = "$0.00";
            this.LSUBTOTAL.TabIndex = 30;
            // 
            // lblDescuentoCap
            // 
            this.lblDescuentoCap.Name = "lblDescuentoCap";
            this.lblDescuentoCap.AutoSize = true;
            this.lblDescuentoCap.BackColor = System.Drawing.Color.Transparent;
            this.lblDescuentoCap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescuentoCap.ForeColor = System.Drawing.Color.Black;
            this.lblDescuentoCap.Location = new System.Drawing.Point(620, 492);
            this.lblDescuentoCap.Text = "Descuento:";
            this.lblDescuentoCap.TabIndex = 31;
            // 
            // LDESCUENTO
            // 
            this.LDESCUENTO.Name = "LDESCUENTO";
            this.LDESCUENTO.AutoSize = true;
            this.LDESCUENTO.BackColor = System.Drawing.Color.Transparent;
            this.LDESCUENTO.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LDESCUENTO.ForeColor = System.Drawing.Color.Black;
            this.LDESCUENTO.Location = new System.Drawing.Point(780, 492);
            this.LDESCUENTO.Text = "-$0.00";
            this.LDESCUENTO.TabIndex = 32;
            // 
            // lblIvaCap
            // 
            this.lblIvaCap.Name = "lblIvaCap";
            this.lblIvaCap.AutoSize = true;
            this.lblIvaCap.BackColor = System.Drawing.Color.Transparent;
            this.lblIvaCap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIvaCap.ForeColor = System.Drawing.Color.Black;
            this.lblIvaCap.Location = new System.Drawing.Point(620, 522);
            this.lblIvaCap.Text = "IVA (16%):";
            this.lblIvaCap.TabIndex = 33;
            // 
            // LIVA
            // 
            this.LIVA.Name = "LIVA";
            this.LIVA.AutoSize = true;
            this.LIVA.BackColor = System.Drawing.Color.Transparent;
            this.LIVA.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LIVA.ForeColor = System.Drawing.Color.Black;
            this.LIVA.Location = new System.Drawing.Point(780, 522);
            this.LIVA.Text = "$0.00";
            this.LIVA.TabIndex = 34;
            // 
            // lblTotalCap
            // 
            this.lblTotalCap.Name = "lblTotalCap";
            this.lblTotalCap.AutoSize = true;
            this.lblTotalCap.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCap.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCap.ForeColor = System.Drawing.Color.Black;
            this.lblTotalCap.Location = new System.Drawing.Point(620, 556);
            this.lblTotalCap.Text = "TOTAL:";
            this.lblTotalCap.TabIndex = 35;
            // 
            // LTOTAL
            // 
            this.LTOTAL.Name = "LTOTAL";
            this.LTOTAL.AutoSize = true;
            this.LTOTAL.BackColor = System.Drawing.Color.Transparent;
            this.LTOTAL.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LTOTAL.ForeColor = System.Drawing.Color.Black;
            this.LTOTAL.Location = new System.Drawing.Point(770, 556);
            this.LTOTAL.Text = "$0.00";
            this.LTOTAL.TabIndex = 36;
            // 
            // colNum
            // 
            this.colNum.FillWeight = 30F;
            this.colNum.HeaderText = "#";
            this.colNum.Name = "Num";
            // 
            // colCliente
            // 
            this.colCliente.FillWeight = 90F;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "Cliente";
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 190F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "Producto";
            // 
            // colColor
            // 
            this.colColor.FillWeight = 70F;
            this.colColor.HeaderText = "Color";
            this.colColor.Name = "CodigoColor";
            // 
            // colPrecio
            // 
            this.colPrecio.FillWeight = 75F;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "Precio";
            // 
            // colCantidad
            // 
            this.colCantidad.FillWeight = 60F;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "Cantidad";
            // 
            // colSubtotal
            // 
            this.colSubtotal.FillWeight = 85F;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "Subtotal";
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pymasa - Punto de venta";
            this.Controls.Add(this.panelTop);
            this.panelTop.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.TBCLIENTE);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.TBTELEFONO);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.TBBUSCAR);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.CBPRODUCTOS);
            this.Controls.Add(this.lblPrecioCap);
            this.Controls.Add(this.LPRECIO);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.TBCOLOR);
            this.Controls.Add(this.PCOLOR);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.TBCANTIDAD);
            this.Controls.Add(this.BAGREGAR);
            this.Controls.Add(this.BEDITAR);
            this.Controls.Add(this.BELIMINAR);
            this.Controls.Add(this.BLIMPIAR);
            this.Controls.Add(this.DGVVENTA);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.CBDESCUENTO);
            this.Controls.Add(this.lblEfectivo);
            this.Controls.Add(this.TBEFECTIVO);
            this.Controls.Add(this.lblCambioCap);
            this.Controls.Add(this.LCAMBIO);
            this.Controls.Add(this.BPAGAR);
            this.Controls.Add(this.lblSubtotalCap);
            this.Controls.Add(this.LSUBTOTAL);
            this.Controls.Add(this.lblDescuentoCap);
            this.Controls.Add(this.LDESCUENTO);
            this.Controls.Add(this.lblIvaCap);
            this.Controls.Add(this.LIVA);
            this.Controls.Add(this.lblTotalCap);
            this.Controls.Add(this.LTOTAL);
            this.Name = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.PCOLOR.ResumeLayout(false);
            this.PCOLOR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVENTA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox TBCLIENTE;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox TBTELEFONO;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox TBBUSCAR;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox CBPRODUCTOS;
        private System.Windows.Forms.Label lblPrecioCap;
        private System.Windows.Forms.Label LPRECIO;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox TBCOLOR;
        private System.Windows.Forms.Panel PCOLOR;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox TBCANTIDAD;
        private System.Windows.Forms.Button BAGREGAR;
        private System.Windows.Forms.Button BEDITAR;
        private System.Windows.Forms.Button BELIMINAR;
        private System.Windows.Forms.Button BLIMPIAR;
        private System.Windows.Forms.DataGridView DGVVENTA;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.ComboBox CBDESCUENTO;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.TextBox TBEFECTIVO;
        private System.Windows.Forms.Label lblCambioCap;
        private System.Windows.Forms.Label LCAMBIO;
        private System.Windows.Forms.Button BPAGAR;
        private System.Windows.Forms.Label lblSubtotalCap;
        private System.Windows.Forms.Label LSUBTOTAL;
        private System.Windows.Forms.Label lblDescuentoCap;
        private System.Windows.Forms.Label LDESCUENTO;
        private System.Windows.Forms.Label lblIvaCap;
        private System.Windows.Forms.Label LIVA;
        private System.Windows.Forms.Label lblTotalCap;
        private System.Windows.Forms.Label LTOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    }
}
