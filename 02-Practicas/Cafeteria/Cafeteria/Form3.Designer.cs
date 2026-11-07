namespace Cafeteria
{
    partial class Form3
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
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.lblElige = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.grpDia = new System.Windows.Forms.GroupBox();
            this.lblDesayuno = new System.Windows.Forms.Label();
            this.lblComida = new System.Windows.Forms.Label();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.grpDia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo3.Location = new System.Drawing.Point(26, 25);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(223, 29);
            this.lblTitulo3.TabIndex = 2;
            this.lblTitulo3.Text = "Menú de la semana";
            // 
            // lblElige
            // 
            this.lblElige.AutoSize = true;
            this.lblElige.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElige.Location = new System.Drawing.Point(40, 102);
            this.lblElige.Name = "lblElige";
            this.lblElige.Size = new System.Drawing.Size(87, 18);
            this.lblElige.TabIndex = 3;
            this.lblElige.Text = "Elige un día:";
            // 
            // cmbDia
            // 
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(43, 137);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(121, 24);
            this.cmbDia.TabIndex = 4;
            this.cmbDia.SelectedIndexChanged += new System.EventHandler(this.cmbDia_SelectedIndexChanged);
            // 
            // grpDia
            // 
            this.grpDia.Controls.Add(this.lblComida);
            this.grpDia.Controls.Add(this.lblDesayuno);
            this.grpDia.Location = new System.Drawing.Point(199, 102);
            this.grpDia.Name = "grpDia";
            this.grpDia.Size = new System.Drawing.Size(234, 100);
            this.grpDia.TabIndex = 5;
            this.grpDia.TabStop = false;
            this.grpDia.Visible = false;
            // 
            // lblDesayuno
            // 
            this.lblDesayuno.AutoSize = true;
            this.lblDesayuno.Location = new System.Drawing.Point(7, 22);
            this.lblDesayuno.Name = "lblDesayuno";
            this.lblDesayuno.Size = new System.Drawing.Size(0, 16);
            this.lblDesayuno.TabIndex = 0;
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(7, 65);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(0, 16);
            this.lblComida.TabIndex = 1;
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Location = new System.Drawing.Point(111, 263);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(95, 59);
            this.btnVerTodo.TabIndex = 7;
            this.btnVerTodo.Text = "Ver toda la semana";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(264, 263);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(95, 59);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lstMenu
            // 
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.ItemHeight = 16;
            this.lstMenu.Location = new System.Drawing.Point(458, 102);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(242, 324);
            this.lstMenu.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnVerTodo);
            this.Controls.Add(this.grpDia);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.lblElige);
            this.Controls.Add(this.lblTitulo3);
            this.Name = "Form3";
            this.Text = "Menú de la semana";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.grpDia.ResumeLayout(false);
            this.grpDia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.Label lblElige;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.GroupBox grpDia;
        private System.Windows.Forms.Label lblDesayuno;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ListBox lstMenu;
    }
}