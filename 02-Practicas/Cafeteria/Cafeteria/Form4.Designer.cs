namespace Cafeteria
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.lblMusica = new System.Windows.Forms.Label();
            this.axWmpMusica = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.lblJuego = new System.Windows.Forms.Label();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblInvertido = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWmpMusica)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusica
            // 
            this.lblMusica.AutoSize = true;
            this.lblMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusica.Location = new System.Drawing.Point(12, 34);
            this.lblMusica.Name = "lblMusica";
            this.lblMusica.Size = new System.Drawing.Size(172, 20);
            this.lblMusica.TabIndex = 0;
            this.lblMusica.Text = "Música para el recreo";
            // 
            // axWmpMusica
            // 
            this.axWmpMusica.Enabled = true;
            this.axWmpMusica.Location = new System.Drawing.Point(16, 74);
            this.axWmpMusica.Name = "axWmpMusica";
            this.axWmpMusica.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWmpMusica.OcxState")));
            this.axWmpMusica.Size = new System.Drawing.Size(300, 47);
            this.axWmpMusica.TabIndex = 1;
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(187, 177);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(110, 42);
            this.btnDetener.TabIndex = 2;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnReproducir
            // 
            this.btnReproducir.Location = new System.Drawing.Point(41, 177);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(110, 42);
            this.btnReproducir.TabIndex = 3;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.UseVisualStyleBackColor = true;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // lblJuego
            // 
            this.lblJuego.AutoSize = true;
            this.lblJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuego.Location = new System.Drawing.Point(18, 243);
            this.lblJuego.Name = "lblJuego";
            this.lblJuego.Size = new System.Drawing.Size(304, 20);
            this.lblJuego.TabIndex = 5;
            this.lblJuego.Text = "Escribe una palabra (¿es palíndromo?):";
            this.lblJuego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(22, 302);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(300, 22);
            this.txtPalabra.TabIndex = 6;
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(41, 360);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(110, 42);
            this.btnInvertir.TabIndex = 7;
            this.btnInvertir.Text = "Invertir";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(187, 360);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 42);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(421, 221);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 42);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblInvertido
            // 
            this.lblInvertido.AutoSize = true;
            this.lblInvertido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvertido.Location = new System.Drawing.Point(40, 428);
            this.lblInvertido.Name = "lblInvertido";
            this.lblInvertido.Size = new System.Drawing.Size(0, 20);
            this.lblInvertido.TabIndex = 11;
            this.lblInvertido.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(37, 477);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 20);
            this.lblResultado.TabIndex = 12;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 525);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblInvertido);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.lblJuego);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.axWmpMusica);
            this.Controls.Add(this.lblMusica);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWmpMusica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusica;
        private AxWMPLib.AxWindowsMediaPlayer axWmpMusica;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblInvertido;
        private System.Windows.Forms.Label lblResultado;
    }
}