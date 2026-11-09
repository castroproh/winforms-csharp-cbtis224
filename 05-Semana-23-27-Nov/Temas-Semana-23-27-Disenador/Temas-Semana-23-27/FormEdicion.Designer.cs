namespace TemasSemana
{
    partial class FormEdicion
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
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.picEncabezado = new System.Windows.Forms.PictureBox();
            this.lblEncabezadoTitulo = new System.Windows.Forms.Label();
            this.lblEncabezadoSubtitulo = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.lblCampoNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCampoCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCampoPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCampoCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.botones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnLimpiarFilas = new System.Windows.Forms.Button();
            this.totales = new System.Windows.Forms.TableLayoutPanel();
            this.lblArticulos = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picEncabezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.layout.SuspendLayout();
            this.panelEncabezado.SuspendLayout();
            this.panelCampos.SuspendLayout();
            this.botones.SuspendLayout();
            this.totales.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.Controls.Add(this.panelEncabezado, 0, 0);
            this.layout.Controls.Add(this.dgvProductos, 0, 1);
            this.layout.Controls.Add(this.panelCampos, 1, 1);
            this.layout.Controls.Add(this.totales, 0, 2);
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 3;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.layout.SetColumnSpan(this.panelEncabezado, 2);
            this.layout.SetColumnSpan(this.totales, 2);
            this.layout.Size = new System.Drawing.Size(1000, 640);
            this.layout.TabIndex = 0;
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.Controls.Add(this.picEncabezado);
            this.panelEncabezado.Controls.Add(this.lblEncabezadoTitulo);
            this.panelEncabezado.Controls.Add(this.lblEncabezadoSubtitulo);
            this.panelEncabezado.BackColor = System.Drawing.Color.FromArgb(222, 235, 247);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Margin = new System.Windows.Forms.Padding(0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(1000, 72);
            this.panelEncabezado.TabIndex = 0;
            // 
            // picEncabezado
            // 
            this.picEncabezado.Location = new System.Drawing.Point(12, 8);
            this.picEncabezado.Name = "picEncabezado";
            this.picEncabezado.Size = new System.Drawing.Size(56, 56);
            this.picEncabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEncabezado.TabIndex = 0;
            this.picEncabezado.TabStop = false;
            // 
            // lblEncabezadoTitulo
            // 
            this.lblEncabezadoTitulo.AutoSize = true;
            this.lblEncabezadoTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblEncabezadoTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lblEncabezadoTitulo.Location = new System.Drawing.Point(76, 6);
            this.lblEncabezadoTitulo.Name = "lblEncabezadoTitulo";
            this.lblEncabezadoTitulo.Size = new System.Drawing.Size(100, 30);
            this.lblEncabezadoTitulo.TabIndex = 1;
            this.lblEncabezadoTitulo.Text = "Edición de productos";
            // 
            // lblEncabezadoSubtitulo
            // 
            this.lblEncabezadoSubtitulo.AutoSize = true;
            this.lblEncabezadoSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEncabezadoSubtitulo.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblEncabezadoSubtitulo.Location = new System.Drawing.Point(79, 42);
            this.lblEncabezadoSubtitulo.Name = "lblEncabezadoSubtitulo";
            this.lblEncabezadoSubtitulo.Size = new System.Drawing.Size(100, 19);
            this.lblEncabezadoSubtitulo.TabIndex = 2;
            this.lblEncabezadoSubtitulo.Text = "Agregar, editar, eliminar y limpiar filas";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 246, 252);
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.dgvProductos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersHeight = 34;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colCategoria,
            this.colPrecio,
            this.colCantidad,
            this.colImporte});
            this.dgvProductos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.dgvProductos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvProductos.Location = new System.Drawing.Point(0, 0);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(660, 484);
            this.dgvProductos.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 50;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Nombre";
            this.colNombre.HeaderText = "Producto";
            this.colNombre.Name = "colNombre";
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.MinimumWidth = 150;
            // 
            // colCategoria
            // 
            this.colCategoria.DataPropertyName = "Categoria";
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Width = 110;
            // 
            // colPrecio
            // 
            this.colPrecio.DataPropertyName = "Precio";
            this.colPrecio.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrecio.DefaultCellStyle.Format = "C2";
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Width = 90;
            // 
            // colCantidad
            // 
            this.colCantidad.DataPropertyName = "Cantidad";
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCantidad.Width = 80;
            // 
            // colImporte
            // 
            this.colImporte.DataPropertyName = "Importe";
            this.colImporte.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colImporte.DefaultCellStyle.Format = "C2";
            this.colImporte.HeaderText = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.Width = 100;
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.lblCampoNombre);
            this.panelCampos.Controls.Add(this.txtNombre);
            this.panelCampos.Controls.Add(this.lblCampoCategoria);
            this.panelCampos.Controls.Add(this.cmbCategoria);
            this.panelCampos.Controls.Add(this.lblCampoPrecio);
            this.panelCampos.Controls.Add(this.txtPrecio);
            this.panelCampos.Controls.Add(this.lblCampoCantidad);
            this.panelCampos.Controls.Add(this.txtCantidad);
            this.panelCampos.Controls.Add(this.botones);
            this.panelCampos.AutoScroll = true;
            this.panelCampos.BackColor = System.Drawing.Color.White;
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCampos.Location = new System.Drawing.Point(670, 83);
            this.panelCampos.Margin = new System.Windows.Forms.Padding(10);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(200, 100);
            this.panelCampos.TabIndex = 2;
            // 
            // lblCampoNombre
            // 
            this.lblCampoNombre.AutoSize = true;
            this.lblCampoNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCampoNombre.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblCampoNombre.Location = new System.Drawing.Point(12, 8);
            this.lblCampoNombre.Name = "lblCampoNombre";
            this.lblCampoNombre.Size = new System.Drawing.Size(100, 19);
            this.lblCampoNombre.TabIndex = 0;
            this.lblCampoNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(12, 32);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 25);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCampoCategoria
            // 
            this.lblCampoCategoria.AutoSize = true;
            this.lblCampoCategoria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCampoCategoria.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblCampoCategoria.Location = new System.Drawing.Point(12, 72);
            this.lblCampoCategoria.Name = "lblCampoCategoria";
            this.lblCampoCategoria.Size = new System.Drawing.Size(100, 19);
            this.lblCampoCategoria.TabIndex = 2;
            this.lblCampoCategoria.Text = "Categoría";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoria.Location = new System.Drawing.Point(12, 96);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(176, 25);
            this.cmbCategoria.TabIndex = 3;
            // 
            // lblCampoPrecio
            // 
            this.lblCampoPrecio.AutoSize = true;
            this.lblCampoPrecio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCampoPrecio.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblCampoPrecio.Location = new System.Drawing.Point(12, 136);
            this.lblCampoPrecio.Name = "lblCampoPrecio";
            this.lblCampoPrecio.Size = new System.Drawing.Size(100, 19);
            this.lblCampoPrecio.TabIndex = 4;
            this.lblCampoPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrecio.Location = new System.Drawing.Point(12, 160);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(176, 25);
            this.txtPrecio.TabIndex = 5;
            // 
            // lblCampoCantidad
            // 
            this.lblCampoCantidad.AutoSize = true;
            this.lblCampoCantidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCampoCantidad.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblCampoCantidad.Location = new System.Drawing.Point(12, 200);
            this.lblCampoCantidad.Name = "lblCampoCantidad";
            this.lblCampoCantidad.Size = new System.Drawing.Size(100, 19);
            this.lblCampoCantidad.TabIndex = 6;
            this.lblCampoCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCantidad.Location = new System.Drawing.Point(12, 224);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(176, 25);
            this.txtCantidad.TabIndex = 7;
            // 
            // botones
            // 
            this.botones.Controls.Add(this.btnAgregar);
            this.botones.Controls.Add(this.btnEditar);
            this.botones.Controls.Add(this.btnEliminar);
            this.botones.Controls.Add(this.btnLimpiarCampos);
            this.botones.Controls.Add(this.btnLimpiarFilas);
            this.botones.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.botones.Location = new System.Drawing.Point(8, 264);
            this.botones.Name = "botones";
            this.botones.Size = new System.Drawing.Size(296, 132);
            this.botones.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(4, 4);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 34);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(150, 4);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(138, 34);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(176, 52, 52);
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(4, 46);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 34);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.btnLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(150, 46);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(138, 34);
            this.btnLimpiarCampos.TabIndex = 3;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.BtnLimpiarCampos_Click);
            // 
            // btnLimpiarFilas
            // 
            this.btnLimpiarFilas.BackColor = System.Drawing.Color.FromArgb(176, 52, 52);
            this.btnLimpiarFilas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarFilas.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFilas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFilas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarFilas.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFilas.Location = new System.Drawing.Point(4, 88);
            this.btnLimpiarFilas.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarFilas.Name = "btnLimpiarFilas";
            this.btnLimpiarFilas.Size = new System.Drawing.Size(138, 34);
            this.btnLimpiarFilas.TabIndex = 4;
            this.btnLimpiarFilas.Text = "Limpiar filas";
            this.btnLimpiarFilas.UseVisualStyleBackColor = false;
            this.btnLimpiarFilas.Click += new System.EventHandler(this.BtnLimpiarFilas_Click);
            // 
            // totales
            // 
            this.totales.Controls.Add(this.lblArticulos, 0, 0);
            this.totales.Controls.Add(this.lblSubtotal, 1, 0);
            this.totales.Controls.Add(this.lblIva, 2, 0);
            this.totales.Controls.Add(this.lblTotal, 3, 0);
            this.totales.BackColor = System.Drawing.Color.FromArgb(222, 235, 247);
            this.totales.ColumnCount = 4;
            this.totales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.totales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.totales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.totales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.totales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totales.Location = new System.Drawing.Point(0, 576);
            this.totales.Margin = new System.Windows.Forms.Padding(0);
            this.totales.Name = "totales";
            this.totales.RowCount = 1;
            this.totales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.totales.Size = new System.Drawing.Size(1000, 64);
            this.totales.TabIndex = 3;
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = false;
            this.lblArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArticulos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblArticulos.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lblArticulos.Location = new System.Drawing.Point(3, 3);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(194, 58);
            this.lblArticulos.TabIndex = 0;
            this.lblArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = false;
            this.lblSubtotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lblSubtotal.Location = new System.Drawing.Point(3, 3);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(194, 58);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = false;
            this.lblIva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIva.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblIva.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lblIva.Location = new System.Drawing.Point(3, 3);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(194, 58);
            this.lblIva.TabIndex = 2;
            this.lblIva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = false;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(150, 30, 30);
            this.lblTotal.Location = new System.Drawing.Point(3, 3);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(194, 58);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tema 25 - DataGridView (edición y totales)";
            this.Controls.Add(this.layout);
            this.Shown += new System.EventHandler(this.FormEdicion_Shown);
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.botones.ResumeLayout(false);
            this.botones.PerformLayout();
            this.totales.ResumeLayout(false);
            this.totales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEncabezado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.PictureBox picEncabezado;
        private System.Windows.Forms.Label lblEncabezadoTitulo;
        private System.Windows.Forms.Label lblEncabezadoSubtitulo;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.Label lblCampoNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCampoCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCampoPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCampoCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.FlowLayoutPanel botones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnLimpiarFilas;
        private System.Windows.Forms.TableLayoutPanel totales;
        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblTotal;
    }
}
