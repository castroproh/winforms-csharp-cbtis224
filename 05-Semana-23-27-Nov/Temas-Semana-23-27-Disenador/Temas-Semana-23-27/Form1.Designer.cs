namespace TemasSemana
{
    partial class Form1
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
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.btnKeyDown = new System.Windows.Forms.Button();
            this.btnClaseDgv = new System.Windows.Forms.Button();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.btnEdicion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Controls.Add(this.picBanner, 0, 0);
            this.layout.Controls.Add(this.btnKeyDown, 0, 1);
            this.layout.Controls.Add(this.btnClaseDgv, 0, 2);
            this.layout.Controls.Add(this.btnCatalogo, 0, 3);
            this.layout.Controls.Add(this.btnEdicion, 0, 4);
            this.layout.Controls.Add(this.btnSalir, 0, 5);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 7;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Size = new System.Drawing.Size(560, 500);
            this.layout.TabIndex = 0;
            // 
            // picBanner
            // 
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Margin = new System.Windows.Forms.Padding(0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(560, 150);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 0;
            this.picBanner.TabStop = false;
            // 
            // btnKeyDown
            // 
            this.btnKeyDown.BackColor = System.Drawing.Color.White;
            this.btnKeyDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeyDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKeyDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnKeyDown.FlatAppearance.BorderSize = 1;
            this.btnKeyDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyDown.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnKeyDown.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnKeyDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeyDown.Location = new System.Drawing.Point(40, 156);
            this.btnKeyDown.Margin = new System.Windows.Forms.Padding(40, 6, 40, 6);
            this.btnKeyDown.Name = "btnKeyDown";
            this.btnKeyDown.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnKeyDown.Size = new System.Drawing.Size(480, 50);
            this.btnKeyDown.TabIndex = 1;
            this.btnKeyDown.Text = "21   KeyDown - atajos de teclado";
            this.btnKeyDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeyDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKeyDown.UseVisualStyleBackColor = false;
            this.btnKeyDown.Click += new System.EventHandler(this.BtnKeyDown_Click);
            // 
            // btnClaseDgv
            // 
            this.btnClaseDgv.BackColor = System.Drawing.Color.White;
            this.btnClaseDgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClaseDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClaseDgv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnClaseDgv.FlatAppearance.BorderSize = 1;
            this.btnClaseDgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClaseDgv.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnClaseDgv.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnClaseDgv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClaseDgv.Location = new System.Drawing.Point(40, 218);
            this.btnClaseDgv.Margin = new System.Windows.Forms.Padding(40, 6, 40, 6);
            this.btnClaseDgv.Name = "btnClaseDgv";
            this.btnClaseDgv.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClaseDgv.Size = new System.Drawing.Size(480, 50);
            this.btnClaseDgv.TabIndex = 2;
            this.btnClaseDgv.Text = "22   Clase DataGridView_1";
            this.btnClaseDgv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClaseDgv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClaseDgv.UseVisualStyleBackColor = false;
            this.btnClaseDgv.Click += new System.EventHandler(this.BtnClaseDgv_Click);
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.BackColor = System.Drawing.Color.White;
            this.btnCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCatalogo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnCatalogo.FlatAppearance.BorderSize = 1;
            this.btnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnCatalogo.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogo.Location = new System.Drawing.Point(40, 280);
            this.btnCatalogo.Margin = new System.Windows.Forms.Padding(40, 6, 40, 6);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCatalogo.Size = new System.Drawing.Size(480, 50);
            this.btnCatalogo.TabIndex = 3;
            this.btnCatalogo.Text = "24   DataGridView - catálogo y búsqueda";
            this.btnCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCatalogo.UseVisualStyleBackColor = false;
            this.btnCatalogo.Click += new System.EventHandler(this.BtnCatalogo_Click);
            // 
            // btnEdicion
            // 
            this.btnEdicion.BackColor = System.Drawing.Color.White;
            this.btnEdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdicion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnEdicion.FlatAppearance.BorderSize = 1;
            this.btnEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdicion.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnEdicion.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnEdicion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdicion.Location = new System.Drawing.Point(40, 342);
            this.btnEdicion.Margin = new System.Windows.Forms.Padding(40, 6, 40, 6);
            this.btnEdicion.Name = "btnEdicion";
            this.btnEdicion.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEdicion.Size = new System.Drawing.Size(480, 50);
            this.btnEdicion.TabIndex = 4;
            this.btnEdicion.Text = "25   DataGridView - edición y totales";
            this.btnEdicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdicion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdicion.UseVisualStyleBackColor = false;
            this.btnEdicion.Click += new System.EventHandler(this.BtnEdicion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(40, 404);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(40, 10, 40, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(480, 38);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(560, 500);
            this.Controls.Add(this.layout);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temas Semana 23-27 - Menú principal";
            this.layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Button btnKeyDown;
        private System.Windows.Forms.Button btnClaseDgv;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Button btnEdicion;
        private System.Windows.Forms.Button btnSalir;
    }
}
