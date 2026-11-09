namespace Cafeteria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuSemana = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDescanso = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVerde = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOriginal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpciones,
            this.mnuColor,
            this.mnuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuOpciones
            // 
            this.mnuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPedido,
            this.mnuMenuSemana,
            this.mnuDescanso});
            this.mnuOpciones.Name = "mnuOpciones";
            this.mnuOpciones.Size = new System.Drawing.Size(85, 24);
            this.mnuOpciones.Text = "Opciones";
            // 
            // mnuPedido
            // 
            this.mnuPedido.Name = "mnuPedido";
            this.mnuPedido.Size = new System.Drawing.Size(224, 26);
            this.mnuPedido.Text = "Hacer pedido";
            this.mnuPedido.Click += new System.EventHandler(this.mnuPedido_Click);
            // 
            // mnuMenuSemana
            // 
            this.mnuMenuSemana.Name = "mnuMenuSemana";
            this.mnuMenuSemana.Size = new System.Drawing.Size(224, 26);
            this.mnuMenuSemana.Text = "Menú de la semana";
            this.mnuMenuSemana.Click += new System.EventHandler(this.mnuMenuSemana_Click);
            // 
            // mnuDescanso
            // 
            this.mnuDescanso.Name = "mnuDescanso";
            this.mnuDescanso.Size = new System.Drawing.Size(224, 26);
            this.mnuDescanso.Text = "Zona de descanso";
            this.mnuDescanso.Click += new System.EventHandler(this.mnuDescanso_Click);
            // 
            // mnuColor
            // 
            this.mnuColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAzul,
            this.mnuVerde,
            this.mnuOriginal});
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Size = new System.Drawing.Size(59, 24);
            this.mnuColor.Text = "Color";
            // 
            // mnuAzul
            // 
            this.mnuAzul.Name = "mnuAzul";
            this.mnuAzul.Size = new System.Drawing.Size(224, 26);
            this.mnuAzul.Text = "Azul";
            this.mnuAzul.Click += new System.EventHandler(this.mnuAzul_Click);
            // 
            // mnuVerde
            // 
            this.mnuVerde.Name = "mnuVerde";
            this.mnuVerde.Size = new System.Drawing.Size(224, 26);
            this.mnuVerde.Text = "Verde";
            this.mnuVerde.Click += new System.EventHandler(this.mnuVerde_Click);
            // 
            // mnuOriginal
            // 
            this.mnuOriginal.Name = "mnuOriginal";
            this.mnuOriginal.Size = new System.Drawing.Size(224, 26);
            this.mnuOriginal.Text = "Original";
            this.mnuOriginal.Click += new System.EventHandler(this.mnuOriginal_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(52, 24);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 53);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(401, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Bienvenido a la Cafeteria Escolar";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(14, 356);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 16);
            this.lblFecha.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(51, 176);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(151, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Escribe tu nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(55, 213);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(55, 242);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(99, 16);
            this.lblAviso.TabIndex = 4;
            this.lblAviso.Text = "Falta tu nombre";
            this.lblAviso.Visible = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnEntrar.Location = new System.Drawing.Point(438, 167);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(103, 40);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            this.btnEntrar.MouseLeave += new System.EventHandler(this.btnEntrar_MouseLeave);
            this.btnEntrar.MouseHover += new System.EventHandler(this.btnEntrar_MouseHover);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(438, 230);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 391);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cafeteria Escolar - Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuOpciones;
        private System.Windows.Forms.ToolStripMenuItem mnuPedido;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuSemana;
        private System.Windows.Forms.ToolStripMenuItem mnuDescanso;
        private System.Windows.Forms.ToolStripMenuItem mnuColor;
        private System.Windows.Forms.ToolStripMenuItem mnuAzul;
        private System.Windows.Forms.ToolStripMenuItem mnuVerde;
        private System.Windows.Forms.ToolStripMenuItem mnuOriginal;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSalir;
    }
}

