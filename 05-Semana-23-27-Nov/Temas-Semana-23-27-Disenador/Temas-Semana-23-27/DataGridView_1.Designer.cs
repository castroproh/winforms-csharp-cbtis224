namespace TemasSemana
{
    partial class DataGridView_1
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.botones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblConteo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picEncabezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.layout.SuspendLayout();
            this.panelEncabezado.SuspendLayout();
            this.botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.Controls.Add(this.panelEncabezado, 0, 0);
            this.layout.Controls.Add(this.lblInfo, 0, 1);
            this.layout.Controls.Add(this.botones, 0, 2);
            this.layout.Controls.Add(this.dataGridView1, 0, 3);
            this.layout.Controls.Add(this.lblConteo, 0, 4);
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 5;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
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
            this.lblEncabezadoTitulo.Text = "DataGridView_1";
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
            this.lblEncabezadoSubtitulo.Text = "Clase Producto y una lista mostrada en el DataGridView";
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(3, 75);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblInfo.Size = new System.Drawing.Size(854, 56);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Se define la clase Producto, se llena una List<Producto> con los datos de la tienda " +
            "y se muestra asignándola a dataGridView1.DataSource.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // botones
            // 
            this.botones.Controls.Add(this.btnCargar);
            this.botones.Controls.Add(this.btnVaciar);
            this.botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botones.Location = new System.Drawing.Point(3, 134);
            this.botones.Name = "botones";
            this.botones.Padding = new System.Windows.Forms.Padding(6, 4, 0, 0);
            this.botones.Size = new System.Drawing.Size(854, 48);
            this.botones.TabIndex = 2;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(10, 8);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(150, 34);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar lista";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnVaciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciar.FlatAppearance.BorderSize = 0;
            this.btnVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVaciar.ForeColor = System.Drawing.Color.White;
            this.btnVaciar.Location = new System.Drawing.Point(168, 8);
            this.btnVaciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(150, 34);
            this.btnVaciar.TabIndex = 1;
            this.btnVaciar.Text = "Vaciar lista";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.BtnVaciar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 246, 252);
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colCategoria,
            this.colPrecio,
            this.colCantidad,
            this.colImporte});
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(854, 383);
            this.dataGridView1.TabIndex = 3;
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
            // lblConteo
            // 
            this.lblConteo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConteo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConteo.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lblConteo.Location = new System.Drawing.Point(3, 527);
            this.lblConteo.Name = "lblConteo";
            this.lblConteo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblConteo.Size = new System.Drawing.Size(854, 36);
            this.lblConteo.TabIndex = 4;
            this.lblConteo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataGridView_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(860, 560);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "DataGridView_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tema 22 - Clase DataGridView_1 (Producto y lista)";
            this.Controls.Add(this.layout);
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.botones.ResumeLayout(false);
            this.botones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEncabezado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.PictureBox picEncabezado;
        private System.Windows.Forms.Label lblEncabezadoTitulo;
        private System.Windows.Forms.Label lblEncabezadoSubtitulo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.FlowLayoutPanel botones;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.Label lblConteo;
    }
}
