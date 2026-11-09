namespace Temas_Semana_30_nov_4_dic
{
    partial class Form1
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
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btn26 = new System.Windows.Forms.Button();
            this.btn27 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // picBanner
            // 
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(480, 140);
            this.picBanner.TabStop = false;
            this.picBanner.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(38, 50, 56);
            this.lblTitulo.Location = new System.Drawing.Point(20, 158);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(440, 34);
            this.lblTitulo.Text = "Temas de la semana 30 nov - 4 dic";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.TabIndex = 1;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = false;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(20, 192);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(440, 26);
            this.lblSubtitulo.Text = "Selecciona un tema para abrirlo";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubtitulo.TabIndex = 2;
            // 
            // btn26
            // 
            this.btn26.BackColor = System.Drawing.Color.FromArgb(0, 121, 107);
            this.btn26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn26.FlatAppearance.BorderSize = 0;
            this.btn26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn26.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btn26.ForeColor = System.Drawing.Color.White;
            this.btn26.Location = new System.Drawing.Point(70, 240);
            this.btn26.Name = "btn26";
            this.btn26.Size = new System.Drawing.Size(340, 56);
            this.btn26.Text = "26  Ticket de venta";
            this.btn26.UseVisualStyleBackColor = false;
            this.btn26.TabIndex = 3;
            this.btn26.Click += new System.EventHandler(this.Btn26_Click);
            // 
            // btn27
            // 
            this.btn27.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btn27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn27.FlatAppearance.BorderSize = 0;
            this.btn27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn27.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btn27.ForeColor = System.Drawing.Color.White;
            this.btn27.Location = new System.Drawing.Point(70, 316);
            this.btn27.Name = "btn27";
            this.btn27.Size = new System.Drawing.Size(340, 56);
            this.btn27.Text = "27  Ticket (pagar e imprimir)";
            this.btn27.UseVisualStyleBackColor = false;
            this.btn27.TabIndex = 4;
            this.btn27.Click += new System.EventHandler(this.Btn27_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(70, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(340, 44);
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = false;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.DimGray;
            this.lblFecha.Location = new System.Drawing.Point(20, 470);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(440, 26);
            this.lblFecha.Text = "";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha.TabIndex = 6;
            // 
            // Form1
            // 
            this.Controls.Add(this.picBanner);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.btn26);
            this.Controls.Add(this.btn27);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblFecha);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btn26;
        private System.Windows.Forms.Button btn27;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblFecha;
    }
}
