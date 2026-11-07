using System.Drawing;
using System.Windows.Forms;

namespace Papeleria
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private GroupBox grpCategoria;
        private Label lblEconomico;
        private Label lblPremium;
        private Button btnVerTodo;
        private ListBox lstCatalogo;
        private Button btnRegresar;

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
            this.lblTitulo = new Label();
            this.lblCategoria = new Label();
            this.cmbCategoria = new ComboBox();
            this.grpCategoria = new GroupBox();
            this.lblEconomico = new Label();
            this.lblPremium = new Label();
            this.btnVerTodo = new Button();
            this.lstCatalogo = new ListBox();
            this.btnRegresar = new Button();
            this.grpCategoria.SuspendLayout();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitulo.Location = new Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Catálogo de productos";

            // lblCategoria
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new Point(20, 55);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Text = "Elige una categoría:";

            // cmbCategoria
            this.cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCategoria.Location = new Point(20, 78);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new Size(300, 23);
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);

            // grpCategoria
            this.grpCategoria.Controls.Add(this.lblEconomico);
            this.grpCategoria.Controls.Add(this.lblPremium);
            this.grpCategoria.Location = new Point(20, 115);
            this.grpCategoria.Name = "grpCategoria";
            this.grpCategoria.Size = new Size(510, 90);
            this.grpCategoria.Text = "Categoría";
            this.grpCategoria.Visible = false;

            // lblEconomico
            this.lblEconomico.AutoSize = true;
            this.lblEconomico.Location = new Point(15, 30);
            this.lblEconomico.Name = "lblEconomico";

            // lblPremium
            this.lblPremium.AutoSize = true;
            this.lblPremium.Location = new Point(15, 58);
            this.lblPremium.Name = "lblPremium";

            // btnVerTodo
            this.btnVerTodo.FlatStyle = FlatStyle.Flat;
            this.btnVerTodo.Location = new Point(20, 218);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new Size(220, 34);
            this.btnVerTodo.Text = "Ver todo el catálogo";
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);

            // lstCatalogo
            this.lstCatalogo.FormattingEnabled = true;
            this.lstCatalogo.ItemHeight = 15;
            this.lstCatalogo.Location = new Point(20, 262);
            this.lstCatalogo.Name = "lstCatalogo";
            this.lstCatalogo.Size = new Size(510, 124);

            // btnRegresar
            this.btnRegresar.FlatStyle = FlatStyle.Flat;
            this.btnRegresar.Location = new Point(400, 400);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new Size(130, 34);
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);

            // Form3
            this.ClientSize = new Size(560, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lstCatalogo);
            this.Controls.Add(this.btnVerTodo);
            this.Controls.Add(this.grpCategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.FormClosed += new FormClosedEventHandler(this.Form3_FormClosed);
            this.grpCategoria.ResumeLayout(false);
            this.grpCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
