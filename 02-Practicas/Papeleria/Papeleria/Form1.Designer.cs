using System.Drawing;
using System.Windows.Forms;

namespace Papeleria
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuOpciones;
        private ToolStripMenuItem mnuPedido;
        private ToolStripMenuItem mnuCatalogo;
        private ToolStripMenuItem mnuDescanso;
        private ToolStripMenuItem mnuColor;
        private ToolStripMenuItem mnuAzul;
        private ToolStripMenuItem mnuVerde;
        private ToolStripMenuItem mnuOriginal;
        private ToolStripMenuItem mnuSalir;
        private Label lblTitulo;
        private Label lblFecha;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblAviso;
        private Button btnEntrar;
        private Button btnSalir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new MenuStrip();
            this.mnuOpciones = new ToolStripMenuItem();
            this.mnuPedido = new ToolStripMenuItem();
            this.mnuCatalogo = new ToolStripMenuItem();
            this.mnuDescanso = new ToolStripMenuItem();
            this.mnuColor = new ToolStripMenuItem();
            this.mnuAzul = new ToolStripMenuItem();
            this.mnuVerde = new ToolStripMenuItem();
            this.mnuOriginal = new ToolStripMenuItem();
            this.mnuSalir = new ToolStripMenuItem();
            this.lblTitulo = new Label();
            this.lblFecha = new Label();
            this.lblNombre = new Label();
            this.txtNombre = new TextBox();
            this.lblAviso = new Label();
            this.btnEntrar = new Button();
            this.btnSalir = new Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.mnuOpciones, this.mnuColor, this.mnuSalir });
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // mnuOpciones
            this.mnuOpciones.DropDownItems.AddRange(new ToolStripItem[] { this.mnuPedido, this.mnuCatalogo, this.mnuDescanso });
            this.mnuOpciones.Name = "mnuOpciones";
            this.mnuOpciones.Text = "Opciones";

            // mnuPedido
            this.mnuPedido.Name = "mnuPedido";
            this.mnuPedido.Text = "Hacer pedido";
            this.mnuPedido.Click += new System.EventHandler(this.mnuPedido_Click);

            // mnuCatalogo
            this.mnuCatalogo.Name = "mnuCatalogo";
            this.mnuCatalogo.Text = "Catálogo de productos";
            this.mnuCatalogo.Click += new System.EventHandler(this.mnuCatalogo_Click);

            // mnuDescanso
            this.mnuDescanso.Name = "mnuDescanso";
            this.mnuDescanso.Text = "Zona de descanso";
            this.mnuDescanso.Click += new System.EventHandler(this.mnuDescanso_Click);

            // mnuColor
            this.mnuColor.DropDownItems.AddRange(new ToolStripItem[] { this.mnuAzul, this.mnuVerde, this.mnuOriginal });
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Text = "Color";

            // mnuAzul
            this.mnuAzul.Name = "mnuAzul";
            this.mnuAzul.Text = "Azul";
            this.mnuAzul.Click += new System.EventHandler(this.mnuAzul_Click);

            // mnuVerde
            this.mnuVerde.Name = "mnuVerde";
            this.mnuVerde.Text = "Verde";
            this.mnuVerde.Click += new System.EventHandler(this.mnuVerde_Click);

            // mnuOriginal
            this.mnuOriginal.Name = "mnuOriginal";
            this.mnuOriginal.Text = "Original";
            this.mnuOriginal.Click += new System.EventHandler(this.mnuOriginal_Click);

            // mnuSalir
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitulo.Location = new Point(20, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Bienvenido a la Papelería Escolar";

            // lblFecha
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new Point(22, 92);
            this.lblFecha.Name = "lblFecha";

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new Point(22, 130);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Text = "Nombre del alumno:";

            // txtNombre
            this.txtNombre.Location = new Point(22, 155);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new Size(300, 23);

            // lblAviso
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = Color.Red;
            this.lblAviso.Location = new Point(22, 185);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Text = "Escribe tu nombre para continuar.";
            this.lblAviso.Visible = false;

            // btnEntrar
            this.btnEntrar.BackColor = Color.LightGreen;
            this.btnEntrar.FlatStyle = FlatStyle.Flat;
            this.btnEntrar.Location = new Point(22, 215);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new Size(160, 40);
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            this.btnEntrar.MouseHover += new System.EventHandler(this.btnEntrar_MouseHover);
            this.btnEntrar.MouseLeave += new System.EventHandler(this.btnEntrar_MouseLeave);

            // btnSalir
            this.btnSalir.FlatStyle = FlatStyle.Flat;
            this.btnSalir.Location = new Point(200, 215);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new Size(120, 40);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // Form1
            this.ClientSize = new Size(560, 380);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
