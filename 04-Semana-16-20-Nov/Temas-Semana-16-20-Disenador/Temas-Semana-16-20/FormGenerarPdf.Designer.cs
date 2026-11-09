namespace TemasSemana1620
{
    partial class FormGenerarPdf
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
            this.lblCliente = new System.Windows.Forms.Label();
            this._txtCliente = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this._txtProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this._txtCantidad = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this._txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this._lstArticulos = new System.Windows.Forms.ListBox();
            this._lblTotal = new System.Windows.Forms.Label();
            this.btnVista = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this._doc = new System.Drawing.Printing.PrintDocument();
            this.pnlContenido.SuspendLayout();
            this.pnlPie.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlContenido
            //
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Controls.Add(this.lblCliente);
            this.pnlContenido.Controls.Add(this._txtCliente);
            this.pnlContenido.Controls.Add(this.lblProducto);
            this.pnlContenido.Controls.Add(this._txtProducto);
            this.pnlContenido.Controls.Add(this.lblCantidad);
            this.pnlContenido.Controls.Add(this._txtCantidad);
            this.pnlContenido.Controls.Add(this.lblPrecio);
            this.pnlContenido.Controls.Add(this._txtPrecio);
            this.pnlContenido.Controls.Add(this.btnAgregar);
            this.pnlContenido.Controls.Add(this.btnQuitar);
            this.pnlContenido.Controls.Add(this._lstArticulos);
            this.pnlContenido.Controls.Add(this._lblTotal);
            this.pnlContenido.Controls.Add(this.btnVista);
            this.pnlContenido.Controls.Add(this.btnPdf);
            this.pnlContenido.Controls.Add(this.btnLimpiar);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 56);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(900, 528);
            this.pnlContenido.TabIndex = 0;
            //
            // lblCliente
            //
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 16);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 19);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            //
            // _txtCliente
            //
            this._txtCliente.Location = new System.Drawing.Point(120, 12);
            this._txtCliente.Name = "_txtCliente";
            this._txtCliente.Size = new System.Drawing.Size(320, 25);
            this._txtCliente.TabIndex = 1;
            //
            // lblProducto
            //
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(12, 56);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(67, 19);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto:";
            //
            // _txtProducto
            //
            this._txtProducto.Location = new System.Drawing.Point(120, 52);
            this._txtProducto.Name = "_txtProducto";
            this._txtProducto.Size = new System.Drawing.Size(320, 25);
            this._txtProducto.TabIndex = 3;
            //
            // lblCantidad
            //
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 96);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(67, 19);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            //
            // _txtCantidad
            //
            this._txtCantidad.Location = new System.Drawing.Point(120, 92);
            this._txtCantidad.Name = "_txtCantidad";
            this._txtCantidad.Size = new System.Drawing.Size(90, 25);
            this._txtCantidad.TabIndex = 5;
            this._txtCantidad.Text = "1";
            //
            // lblPrecio
            //
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(240, 96);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(51, 19);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            //
            // _txtPrecio
            //
            this._txtPrecio.Location = new System.Drawing.Point(310, 92);
            this._txtPrecio.Name = "_txtPrecio";
            this._txtPrecio.Size = new System.Drawing.Size(130, 25);
            this._txtPrecio.TabIndex = 7;
            //
            // btnAgregar
            //
            this.btnAgregar.Location = new System.Drawing.Point(120, 132);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(170, 36);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar artículo";
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            //
            // btnQuitar
            //
            this.btnQuitar.Location = new System.Drawing.Point(300, 132);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(180, 36);
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.Text = "Quitar seleccionado";
            this.btnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            //
            // _lstArticulos
            //
            this._lstArticulos.Font = new System.Drawing.Font("Consolas", 10F);
            this._lstArticulos.Location = new System.Drawing.Point(12, 184);
            this._lstArticulos.Name = "_lstArticulos";
            this._lstArticulos.Size = new System.Drawing.Size(860, 220);
            this._lstArticulos.TabIndex = 10;
            //
            // _lblTotal
            //
            this._lblTotal.AutoSize = true;
            this._lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this._lblTotal.Location = new System.Drawing.Point(12, 414);
            this._lblTotal.Name = "_lblTotal";
            this._lblTotal.Size = new System.Drawing.Size(98, 21);
            this._lblTotal.TabIndex = 11;
            this._lblTotal.Text = "Total: $0.00";
            //
            // btnVista
            //
            this.btnVista.Location = new System.Drawing.Point(12, 456);
            this.btnVista.Name = "btnVista";
            this.btnVista.Size = new System.Drawing.Size(170, 40);
            this.btnVista.TabIndex = 12;
            this.btnVista.Text = "Vista previa";
            this.btnVista.Click += new System.EventHandler(this.BtnVistaPrevia_Click);
            //
            // btnPdf
            //
            this.btnPdf.Location = new System.Drawing.Point(192, 456);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(200, 40);
            this.btnPdf.TabIndex = 13;
            this.btnPdf.Text = "Generar PDF";
            this.btnPdf.Click += new System.EventHandler(this.BtnGenerarPdf_Click);
            //
            // btnLimpiar
            //
            this.btnLimpiar.Location = new System.Drawing.Point(402, 456);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar todo";
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
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
            this.lblTitulo.Text = "Tema 11 - Genera PDF (PrintDocument)";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // _doc
            //
            this._doc.DocumentName = "Ticket de venta";
            this._doc.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.Doc_BeginPrint);
            this._doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Doc_PrintPage);
            //
            // FormGenerarPdf
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
            this.Name = "FormGenerarPdf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tema 11 - Genera PDF (PrintDocument)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGenerarPdf_FormClosed);
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.pnlPie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox _txtCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox _txtProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox _txtCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox _txtPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ListBox _lstArticulos;
        private System.Windows.Forms.Label _lblTotal;
        private System.Windows.Forms.Button btnVista;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTitulo;
        private System.Drawing.Printing.PrintDocument _doc;
    }
}
