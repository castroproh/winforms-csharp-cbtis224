namespace Cafeteria
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
            this.lblPlatillo = new System.Windows.Forms.Label();
            this.cmbPlatillo = new System.Windows.Forms.ComboBox();
            this.grpTamano = new System.Windows.Forms.GroupBox();
            this.rbMediano = new System.Windows.Forms.RadioButton();
            this.rbChico = new System.Windows.Forms.RadioButton();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.chkAgua = new System.Windows.Forms.CheckBox();
            this.chkPostre = new System.Windows.Forms.CheckBox();
            this.lstPedido = new System.Windows.Forms.ListBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpTamano.SuspendLayout();
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
            // lblPlatillo
            // 
            this.lblPlatillo.AutoSize = true;
            this.lblPlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatillo.Location = new System.Drawing.Point(31, 68);
            this.lblPlatillo.Name = "lblPlatillo";
            this.lblPlatillo.Size = new System.Drawing.Size(68, 22);
            this.lblPlatillo.TabIndex = 1;
            this.lblPlatillo.Text = "Platillo:";
            // 
            // cmbPlatillo
            // 
            this.cmbPlatillo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlatillo.FormattingEnabled = true;
            this.cmbPlatillo.Location = new System.Drawing.Point(35, 108);
            this.cmbPlatillo.Name = "cmbPlatillo";
            this.cmbPlatillo.Size = new System.Drawing.Size(140, 24);
            this.cmbPlatillo.TabIndex = 2;
            // 
            // grpTamano
            // 
            this.grpTamano.Controls.Add(this.rbMediano);
            this.grpTamano.Controls.Add(this.rbChico);
            this.grpTamano.Controls.Add(this.rbGrande);
            this.grpTamano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTamano.Location = new System.Drawing.Point(206, 108);
            this.grpTamano.Name = "grpTamano";
            this.grpTamano.Size = new System.Drawing.Size(164, 153);
            this.grpTamano.TabIndex = 3;
            this.grpTamano.TabStop = false;
            this.grpTamano.Text = "Tamaño:";
            // 
            // rbMediano
            // 
            this.rbMediano.AutoSize = true;
            this.rbMediano.Location = new System.Drawing.Point(16, 77);
            this.rbMediano.Name = "rbMediano";
            this.rbMediano.Size = new System.Drawing.Size(133, 22);
            this.rbMediano.TabIndex = 1;
            this.rbMediano.TabStop = true;
            this.rbMediano.Text = "Mediano (+$10)";
            this.rbMediano.UseVisualStyleBackColor = true;
            // 
            // rbChico
            // 
            this.rbChico.AutoSize = true;
            this.rbChico.Location = new System.Drawing.Point(16, 36);
            this.rbChico.Name = "rbChico";
            this.rbChico.Size = new System.Drawing.Size(107, 22);
            this.rbChico.TabIndex = 0;
            this.rbChico.TabStop = true;
            this.rbChico.Text = "Chico (+$0)";
            this.rbChico.UseVisualStyleBackColor = true;
            // 
            // rbGrande
            // 
            this.rbGrande.AutoSize = true;
            this.rbGrande.Location = new System.Drawing.Point(16, 119);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.Size = new System.Drawing.Size(125, 22);
            this.rbGrande.TabIndex = 2;
            this.rbGrande.TabStop = true;
            this.rbGrande.Text = "Grande (+$20)";
            this.rbGrande.UseVisualStyleBackColor = true;
            // 
            // chkAgua
            // 
            this.chkAgua.AutoSize = true;
            this.chkAgua.Location = new System.Drawing.Point(35, 188);
            this.chkAgua.Name = "chkAgua";
            this.chkAgua.Size = new System.Drawing.Size(140, 20);
            this.chkAgua.TabIndex = 4;
            this.chkAgua.Text = "Agua fresca (+$15)";
            this.chkAgua.UseVisualStyleBackColor = true;
            // 
            // chkPostre
            // 
            this.chkPostre.AutoSize = true;
            this.chkPostre.Location = new System.Drawing.Point(35, 228);
            this.chkPostre.Name = "chkPostre";
            this.chkPostre.Size = new System.Drawing.Size(107, 20);
            this.chkPostre.TabIndex = 5;
            this.chkPostre.Text = "Postre (+$20)";
            this.chkPostre.UseVisualStyleBackColor = true;
            // 
            // lstPedido
            // 
            this.lstPedido.FormattingEnabled = true;
            this.lstPedido.ItemHeight = 16;
            this.lstPedido.Location = new System.Drawing.Point(23, 311);
            this.lstPedido.Name = "lstPedido";
            this.lstPedido.Size = new System.Drawing.Size(400, 84);
            this.lstPedido.TabIndex = 6;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.LightGreen;
            this.btnEnviar.Location = new System.Drawing.Point(444, 126);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(90, 40);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(444, 184);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 39);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(444, 245);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(90, 38);
            this.btnRegresar.TabIndex = 9;
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
            this.lblTotal.TabIndex = 10;
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
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lstPedido);
            this.Controls.Add(this.chkPostre);
            this.Controls.Add(this.chkAgua);
            this.Controls.Add(this.grpTamano);
            this.Controls.Add(this.cmbPlatillo);
            this.Controls.Add(this.lblPlatillo);
            this.Controls.Add(this.lblSaludo);
            this.Name = "Form2";
            this.Text = "Hacer pedido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpTamano.ResumeLayout(false);
            this.grpTamano.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblPlatillo;
        private System.Windows.Forms.ComboBox cmbPlatillo;
        private System.Windows.Forms.GroupBox grpTamano;
        private System.Windows.Forms.RadioButton rbMediano;
        private System.Windows.Forms.RadioButton rbChico;
        private System.Windows.Forms.RadioButton rbGrande;
        private System.Windows.Forms.CheckBox chkAgua;
        private System.Windows.Forms.CheckBox chkPostre;
        private System.Windows.Forms.ListBox lstPedido;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblTotal;
    }
}