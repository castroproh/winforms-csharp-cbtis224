namespace TemasSemana
{
    partial class FormKeyDown
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
            this.lblTecla = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.cuerpo = new System.Windows.Forms.TableLayoutPanel();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.lblCampoBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblCampoNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCampoPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCampoCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblAyuda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picEncabezado)).BeginInit();
            this.layout.SuspendLayout();
            this.panelEncabezado.SuspendLayout();
            this.cuerpo.SuspendLayout();
            this.panelCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.Controls.Add(this.panelEncabezado, 0, 0);
            this.layout.Controls.Add(this.lblTecla, 0, 1);
            this.layout.Controls.Add(this.lblAccion, 0, 2);
            this.layout.Controls.Add(this.cuerpo, 0, 3);
            this.layout.Controls.Add(this.lblAyuda, 0, 4);
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 5;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.layout.Size = new System.Drawing.Size(900, 620);
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
            this.panelEncabezado.Size = new System.Drawing.Size(900, 72);
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
            this.lblEncabezadoTitulo.Text = "KeyDown";
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
            this.lblEncabezadoSubtitulo.Text = "Atajos de teclado con KeyPreview activado";
            // 
            // lblTecla
            // 
            this.lblTecla.BackColor = System.Drawing.Color.White;
            this.lblTecla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTecla.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTecla.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lblTecla.Location = new System.Drawing.Point(10, 78);
            this.lblTecla.Margin = new System.Windows.Forms.Padding(10, 6, 10, 0);
            this.lblTecla.Name = "lblTecla";
            this.lblTecla.Size = new System.Drawing.Size(880, 50);
            this.lblTecla.TabIndex = 1;
            this.lblTecla.Text = "Tecla presionada: (ninguna todavía)";
            this.lblTecla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccion
            // 
            this.lblAccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccion.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblAccion.Location = new System.Drawing.Point(3, 131);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(894, 34);
            this.lblAccion.TabIndex = 2;
            this.lblAccion.Text = "Prueba los atajos de abajo con el teclado.";
            this.lblAccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cuerpo
            // 
            this.cuerpo.Controls.Add(this.lstProductos, 0, 0);
            this.cuerpo.Controls.Add(this.panelCampos, 1, 0);
            this.cuerpo.ColumnCount = 2;
            this.cuerpo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.cuerpo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.cuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuerpo.Location = new System.Drawing.Point(3, 168);
            this.cuerpo.Name = "cuerpo";
            this.cuerpo.RowCount = 1;
            this.cuerpo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cuerpo.Size = new System.Drawing.Size(894, 376);
            this.cuerpo.TabIndex = 3;
            // 
            // lstProductos
            // 
            this.lstProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProductos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstProductos.IntegralHeight = false;
            this.lstProductos.Location = new System.Drawing.Point(10, 10);
            this.lstProductos.Margin = new System.Windows.Forms.Padding(10);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(498, 356);
            this.lstProductos.TabIndex = 0;
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.lblCampoBuscar);
            this.panelCampos.Controls.Add(this.txtBuscar);
            this.panelCampos.Controls.Add(this.lblCampoNombre);
            this.panelCampos.Controls.Add(this.txtNombre);
            this.panelCampos.Controls.Add(this.lblCampoPrecio);
            this.panelCampos.Controls.Add(this.txtPrecio);
            this.panelCampos.Controls.Add(this.lblCampoCantidad);
            this.panelCampos.Controls.Add(this.txtCantidad);
            this.panelCampos.Controls.Add(this.btnGuardar);
            this.panelCampos.BackColor = System.Drawing.Color.White;
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCampos.Location = new System.Drawing.Point(521, 13);
            this.panelCampos.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(200, 100);
            this.panelCampos.TabIndex = 1;
            // 
            // lblCampoBuscar
            // 
            this.lblCampoBuscar.AutoSize = true;
            this.lblCampoBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCampoBuscar.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblCampoBuscar.Location = new System.Drawing.Point(12, 8);
            this.lblCampoBuscar.Name = "lblCampoBuscar";
            this.lblCampoBuscar.Size = new System.Drawing.Size(100, 19);
            this.lblCampoBuscar.TabIndex = 0;
            this.lblCampoBuscar.Text = "Buscar por nombre (F3)";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(12, 32);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(176, 25);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // lblCampoNombre
            // 
            this.lblCampoNombre.AutoSize = true;
            this.lblCampoNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCampoNombre.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblCampoNombre.Location = new System.Drawing.Point(12, 72);
            this.lblCampoNombre.Name = "lblCampoNombre";
            this.lblCampoNombre.Size = new System.Drawing.Size(100, 19);
            this.lblCampoNombre.TabIndex = 2;
            this.lblCampoNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(12, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 25);
            this.txtNombre.TabIndex = 3;
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
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(12, 264);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(240, 34);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar (nuevo o editado)";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblAyuda
            // 
            this.lblAyuda.BackColor = System.Drawing.Color.FromArgb(222, 235, 247);
            this.lblAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAyuda.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lblAyuda.Location = new System.Drawing.Point(0, 550);
            this.lblAyuda.Margin = new System.Windows.Forms.Padding(0);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(900, 70);
            this.lblAyuda.TabIndex = 4;
            this.lblAyuda.Text = "F2 Nuevo   |   F3 Buscar   |   F4 Editar el seleccionado   |   F5 Actualizar lista\r\nSupr Eliminar   |   Ctrl+D Duplicar   |   F9 Cobrar (subtotal, IVA y total)";
            this.lblAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormKeyDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.KeyPreview = true;
            this.Name = "FormKeyDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tema 21 - KeyDown (atajos de teclado)";
            this.Controls.Add(this.layout);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyDown_KeyDown);
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.cuerpo.ResumeLayout(false);
            this.cuerpo.PerformLayout();
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEncabezado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.PictureBox picEncabezado;
        private System.Windows.Forms.Label lblEncabezadoTitulo;
        private System.Windows.Forms.Label lblEncabezadoSubtitulo;
        private System.Windows.Forms.Label lblTecla;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.TableLayoutPanel cuerpo;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.Label lblCampoBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblCampoNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCampoPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCampoCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblAyuda;
    }
}
