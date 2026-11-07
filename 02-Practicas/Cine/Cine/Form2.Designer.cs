namespace Cine
{
    partial class Form2
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
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.cmbPelicula = new System.Windows.Forms.ComboBox();
            this.lblBoletos = new System.Windows.Forms.Label();
            this.numBoletos = new System.Windows.Forms.NumericUpDown();
            this.grpSala = new System.Windows.Forms.GroupBox();
            this.rbVip = new System.Windows.Forms.RadioButton();
            this.rb3D = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.chkPalomitas = new System.Windows.Forms.CheckBox();
            this.chkRefresco = new System.Windows.Forms.CheckBox();
            this.lstPedido = new System.Windows.Forms.ListBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBoletos)).BeginInit();
            this.grpSala.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSaludo.Location = new System.Drawing.Point(38, 9);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(0, 25);
            this.lblSaludo.TabIndex = 0;
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelicula.Location = new System.Drawing.Point(31, 58);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(72, 22);
            this.lblPelicula.TabIndex = 1;
            this.lblPelicula.Text = "Película:";
            // 
            // cmbPelicula
            // 
            this.cmbPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPelicula.FormattingEnabled = true;
            this.cmbPelicula.Location = new System.Drawing.Point(35, 90);
            this.cmbPelicula.Name = "cmbPelicula";
            this.cmbPelicula.Size = new System.Drawing.Size(170, 24);
            this.cmbPelicula.TabIndex = 2;
            // 
            // lblBoletos
            // 
            this.lblBoletos.AutoSize = true;
            this.lblBoletos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoletos.Location = new System.Drawing.Point(31, 135);
            this.lblBoletos.Name = "lblBoletos";
            this.lblBoletos.Size = new System.Drawing.Size(72, 22);
            this.lblBoletos.TabIndex = 3;
            this.lblBoletos.Text = "Boletos:";
            // 
            // numBoletos
            // 
            this.numBoletos.Location = new System.Drawing.Point(35, 165);
            this.numBoletos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBoletos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBoletos.Name = "numBoletos";
            this.numBoletos.Size = new System.Drawing.Size(70, 22);
            this.numBoletos.TabIndex = 4;
            this.numBoletos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpSala
            // 
            this.grpSala.Controls.Add(this.rbVip);
            this.grpSala.Controls.Add(this.rb3D);
            this.grpSala.Controls.Add(this.rbNormal);
            this.grpSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSala.Location = new System.Drawing.Point(240, 90);
            this.grpSala.Name = "grpSala";
            this.grpSala.Size = new System.Drawing.Size(164, 153);
            this.grpSala.TabIndex = 5;
            this.grpSala.TabStop = false;
            this.grpSala.Text = "Tipo de sala:";
            // 
            // rbVip
            // 
            this.rbVip.AutoSize = true;
            this.rbVip.Location = new System.Drawing.Point(16, 119);
            this.rbVip.Name = "rbVip";
            this.rbVip.Size = new System.Drawing.Size(100, 22);
            this.rbVip.TabIndex = 2;
            this.rbVip.TabStop = true;
            this.rbVip.Text = "VIP (+$40)";
            this.rbVip.UseVisualStyleBackColor = true;
            // 
            // rb3D
            // 
            this.rb3D.AutoSize = true;
            this.rb3D.Location = new System.Drawing.Point(16, 77);
            this.rb3D.Name = "rb3D";
            this.rb3D.Size = new System.Drawing.Size(100, 22);
            this.rb3D.TabIndex = 1;
            this.rb3D.TabStop = true;
            this.rb3D.Text = "3D (+$20)";
            this.rb3D.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(16, 36);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(120, 22);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal (+$0)";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // chkPalomitas
            // 
            this.chkPalomitas.AutoSize = true;
            this.chkPalomitas.Location = new System.Drawing.Point(35, 205);
            this.chkPalomitas.Name = "chkPalomitas";
            this.chkPalomitas.Size = new System.Drawing.Size(170, 20);
            this.chkPalomitas.TabIndex = 6;
            this.chkPalomitas.Text = "Palomitas (+$50 c/u)";
            this.chkPalomitas.UseVisualStyleBackColor = true;
            // 
            // chkRefresco
            // 
            this.chkRefresco.AutoSize = true;
            this.chkRefresco.Location = new System.Drawing.Point(35, 240);
            this.chkRefresco.Name = "chkRefresco";
            this.chkRefresco.Size = new System.Drawing.Size(170, 20);
            this.chkRefresco.TabIndex = 7;
            this.chkRefresco.Text = "Refresco (+$30 c/u)";
            this.chkRefresco.UseVisualStyleBackColor = true;
            // 
            // lstPedido
            // 
            this.lstPedido.FormattingEnabled = true;
            this.lstPedido.HorizontalScrollbar = true;
            this.lstPedido.ItemHeight = 16;
            this.lstPedido.Location = new System.Drawing.Point(23, 311);
            this.lstPedido.Name = "lstPedido";
            this.lstPedido.Size = new System.Drawing.Size(550, 84);
            this.lstPedido.TabIndex = 8;
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnComprar.Location = new System.Drawing.Point(450, 100);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(110, 40);
            this.btnComprar.TabIndex = 9;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(450, 160);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 39);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(450, 220);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 38);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(20, 409);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 18);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total: $0";
            this.lblTotal.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 446);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lstPedido);
            this.Controls.Add(this.chkRefresco);
            this.Controls.Add(this.chkPalomitas);
            this.Controls.Add(this.grpSala);
            this.Controls.Add(this.numBoletos);
            this.Controls.Add(this.lblBoletos);
            this.Controls.Add(this.cmbPelicula);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.lblSaludo);
            this.Name = "Form2";
            this.Text = "Comprar boletos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBoletos)).EndInit();
            this.grpSala.ResumeLayout(false);
            this.grpSala.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.ComboBox cmbPelicula;
        private System.Windows.Forms.Label lblBoletos;
        private System.Windows.Forms.NumericUpDown numBoletos;
        private System.Windows.Forms.GroupBox grpSala;
        private System.Windows.Forms.RadioButton rbVip;
        private System.Windows.Forms.RadioButton rb3D;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.CheckBox chkPalomitas;
        private System.Windows.Forms.CheckBox chkRefresco;
        private System.Windows.Forms.ListBox lstPedido;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblTotal;
    }
}
