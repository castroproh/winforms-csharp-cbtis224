namespace TemasSemana1620
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
            this._panelBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTema11 = new System.Windows.Forms.Button();
            this.btnTema12 = new System.Windows.Forms.Button();
            this.btnTema14 = new System.Windows.Forms.Button();
            this.btnTema15 = new System.Windows.Forms.Button();
            this.btnTema16 = new System.Windows.Forms.Button();
            this.btnTema17 = new System.Windows.Forms.Button();
            this.btnTema20 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this._panelBotones.SuspendLayout();
            this.SuspendLayout();
            //
            // _panelBotones
            //
            this._panelBotones.Controls.Add(this.btnTema11);
            this._panelBotones.Controls.Add(this.btnTema12);
            this._panelBotones.Controls.Add(this.btnTema14);
            this._panelBotones.Controls.Add(this.btnTema15);
            this._panelBotones.Controls.Add(this.btnTema16);
            this._panelBotones.Controls.Add(this.btnTema17);
            this._panelBotones.Controls.Add(this.btnTema20);
            this._panelBotones.Controls.Add(this.btnSalir);
            this._panelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelBotones.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._panelBotones.Location = new System.Drawing.Point(0, 100);
            this._panelBotones.Name = "_panelBotones";
            this._panelBotones.Padding = new System.Windows.Forms.Padding(50, 20, 0, 0);
            this._panelBotones.Size = new System.Drawing.Size(680, 540);
            this._panelBotones.TabIndex = 0;
            this._panelBotones.WrapContents = false;
            //
            // btnTema11
            //
            this.btnTema11.Location = new System.Drawing.Point(56, 26);
            this.btnTema11.Margin = new System.Windows.Forms.Padding(6);
            this.btnTema11.Name = "btnTema11";
            this.btnTema11.Size = new System.Drawing.Size(560, 46);
            this.btnTema11.TabIndex = 0;
            this.btnTema11.Text = "11 - Genera PDF (PrintDocument)";
            this.btnTema11.Click += new System.EventHandler(this.btnTema11_Click);
            //
            // btnTema12
            //
            this.btnTema12.Location = new System.Drawing.Point(56, 84);
            this.btnTema12.Margin = new System.Windows.Forms.Padding(6);
            this.btnTema12.Name = "btnTema12";
            this.btnTema12.Size = new System.Drawing.Size(560, 46);
            this.btnTema12.TabIndex = 1;
            this.btnTema12.Text = "12 - Genera PDF de screens (DrawToBitmap)";
            this.btnTema12.Click += new System.EventHandler(this.btnTema12_Click);
            //
            // btnTema14
            //
            this.btnTema14.Location = new System.Drawing.Point(56, 142);
            this.btnTema14.Margin = new System.Windows.Forms.Padding(6);
            this.btnTema14.Name = "btnTema14";
            this.btnTema14.Size = new System.Drawing.Size(560, 46);
            this.btnTema14.TabIndex = 2;
            this.btnTema14.Text = "14 - GIF animado (PictureBox)";
            this.btnTema14.Click += new System.EventHandler(this.btnTema14_Click);
            //
            // btnTema15
            //
            this.btnTema15.Location = new System.Drawing.Point(56, 200);
            this.btnTema15.Margin = new System.Windows.Forms.Padding(6);
            this.btnTema15.Name = "btnTema15";
            this.btnTema15.Size = new System.Drawing.Size(560, 46);
            this.btnTema15.TabIndex = 3;
            this.btnTema15.Text = "15 - MonthCalendar";
            this.btnTema15.Click += new System.EventHandler(this.btnTema15_Click);
            //
            // btnTema16
            //
            this.btnTema16.Location = new System.Drawing.Point(56, 258);
            this.btnTema16.Margin = new System.Windows.Forms.Padding(6);
            this.btnTema16.Name = "btnTema16";
            this.btnTema16.Size = new System.Drawing.Size(560, 46);
            this.btnTema16.TabIndex = 4;
            this.btnTema16.Text = "16 - Calendar (DateTimePicker y días entre fechas)";
            this.btnTema16.Click += new System.EventHandler(this.btnTema16_Click);
            //
            // btnTema17
            //
            this.btnTema17.Location = new System.Drawing.Point(56, 316);
            this.btnTema17.Margin = new System.Windows.Forms.Padding(6);
            this.btnTema17.Name = "btnTema17";
            this.btnTema17.Size = new System.Drawing.Size(560, 46);
            this.btnTema17.TabIndex = 5;
            this.btnTema17.Text = "17 - StatusStrip";
            this.btnTema17.Click += new System.EventHandler(this.btnTema17_Click);
            //
            // btnTema20
            //
            this.btnTema20.Location = new System.Drawing.Point(56, 374);
            this.btnTema20.Margin = new System.Windows.Forms.Padding(6);
            this.btnTema20.Name = "btnTema20";
            this.btnTema20.Size = new System.Drawing.Size(560, 46);
            this.btnTema20.TabIndex = 6;
            this.btnTema20.Text = "20 - ToolStrip y ToolStripContainer";
            this.btnTema20.Click += new System.EventHandler(this.btnTema20_Click);
            //
            // btnSalir
            //
            this.btnSalir.Location = new System.Drawing.Point(56, 444);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6, 18, 6, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(560, 46);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            //
            // lblTitulo
            //
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(680, 100);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Temas Semana 16 al 20\nWindows Forms - C# - CBTis 224";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 640);
            this.Controls.Add(this._panelBotones);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temas Semana 16-20 - Menú principal";
            this._panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel _panelBotones;
        private System.Windows.Forms.Button btnTema11;
        private System.Windows.Forms.Button btnTema12;
        private System.Windows.Forms.Button btnTema14;
        private System.Windows.Forms.Button btnTema15;
        private System.Windows.Forms.Button btnTema16;
        private System.Windows.Forms.Button btnTema17;
        private System.Windows.Forms.Button btnTema20;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo;
    }
}
