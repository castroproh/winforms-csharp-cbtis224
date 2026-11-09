namespace TemasSemana
{
    partial class FormCatalogo
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
            this.barra = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picEncabezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.layout.SuspendLayout();
            this.panelEncabezado.SuspendLayout();
            this.barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.Controls.Add(this.panelEncabezado, 0, 0);
            this.layout.Controls.Add(this.barra, 0, 1);
            this.layout.Controls.Add(this.dgvCatalogo, 0, 2);
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 3;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Size = new System.Drawing.Size(860, 560);
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
            this.panelEncabezado.Size = new System.Drawing.Size(860, 72);
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
            this.lblEncabezadoTitulo.Text = "Catálogo de productos";
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
            this.lblEncabezadoSubtitulo.Text = "Escribe para filtrar por nombre";
            // 
            // barra
            // 
            this.barra.Controls.Add(this.lblBuscar);
            this.barra.Controls.Add(this.txtBuscar);
            this.barra.Controls.Add(this.btnLimpiarBusqueda);
            this.barra.Controls.Add(this.lblResultados);
            this.barra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barra.Location = new System.Drawing.Point(3, 75);
            this.barra.Name = "barra";
            this.barra.Padding = new System.Windows.Forms.Padding(6, 4, 0, 0);
            this.barra.Size = new System.Drawing.Size(854, 42);
            this.barra.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblBuscar.Location = new System.Drawing.Point(10, 12);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(137, 19);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar por nombre:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(155, 9);
            this.txtBuscar.MaxLength = 40;
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(260, 25);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnLimpiarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBusqueda.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(423, 8);
            this.btnLimpiarBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(100, 34);
            this.btnLimpiarBusqueda.TabIndex = 2;
            this.btnLimpiarBusqueda.Text = "Limpiar";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.BtnLimpiarBusqueda_Click);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResultados.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblResultados.Location = new System.Drawing.Point(543, 12);
            this.lblResultados.Margin = new System.Windows.Forms.Padding(16, 8, 0, 0);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 19);
            this.lblResultados.TabIndex = 3;
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.AllowUserToAddRows = false;
            this.dgvCatalogo.AllowUserToDeleteRows = false;
            this.dgvCatalogo.AllowUserToResizeRows = false;
            this.dgvCatalogo.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 246, 252);
            this.dgvCatalogo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatalogo.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.dgvCatalogo.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCatalogo.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCatalogo.ColumnHeadersHeight = 34;
            this.dgvCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colCategoria,
            this.colPrecio,
            this.colCantidad,
            this.colImporte});
            this.dgvCatalogo.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.dgvCatalogo.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCatalogo.EnableHeadersVisualStyles = false;
            this.dgvCatalogo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvCatalogo.Location = new System.Drawing.Point(0, 0);
            this.dgvCatalogo.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCatalogo.MultiSelect = false;
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.ReadOnly = true;
            this.dgvCatalogo.RowHeadersVisible = false;
            this.dgvCatalogo.RowTemplate.Height = 28;
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(854, 437);
            this.dgvCatalogo.TabIndex = 2;
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
            // FormCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(860, 560);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tema 24 - DataGridView (catálogo)";
            this.Controls.Add(this.layout);
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEncabezado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.PictureBox picEncabezado;
        private System.Windows.Forms.Label lblEncabezadoTitulo;
        private System.Windows.Forms.Label lblEncabezadoSubtitulo;
        private System.Windows.Forms.FlowLayoutPanel barra;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
    }
}
