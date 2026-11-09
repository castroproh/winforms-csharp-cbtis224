using System.Drawing;
using System.Windows.Forms;

namespace Papeleria
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblSaludo;
        private Label lblProducto;
        private ComboBox cmbProducto;
        private Label lblEmpaque;
        private RadioButton rbSuelto;
        private RadioButton rbPaquete;
        private RadioButton rbCaja;
        private CheckBox chkForro;
        private CheckBox chkRegalo;
        private Button btnEnviar;
        private Button btnLimpiar;
        private ListBox lstPedido;
        private Label lblTotal;
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
            this.lblSaludo = new Label();
            this.lblProducto = new Label();
            this.cmbProducto = new ComboBox();
            this.lblEmpaque = new Label();
            this.rbSuelto = new RadioButton();
            this.rbPaquete = new RadioButton();
            this.rbCaja = new RadioButton();
            this.chkForro = new CheckBox();
            this.chkRegalo = new CheckBox();
            this.btnEnviar = new Button();
            this.btnLimpiar = new Button();
            this.lstPedido = new ListBox();
            this.lblTotal = new Label();
            this.btnRegresar = new Button();
            this.SuspendLayout();

            // lblSaludo
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblSaludo.Location = new Point(20, 15);
            this.lblSaludo.Name = "lblSaludo";

            // lblProducto
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new Point(20, 55);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Text = "Producto:";

            // cmbProducto
            this.cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbProducto.Location = new Point(20, 78);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new Size(300, 23);

            // lblEmpaque
            this.lblEmpaque.AutoSize = true;
            this.lblEmpaque.Location = new Point(20, 118);
            this.lblEmpaque.Name = "lblEmpaque";
            this.lblEmpaque.Text = "Empaque:";

            // rbSuelto
            this.rbSuelto.AutoSize = true;
            this.rbSuelto.Location = new Point(20, 142);
            this.rbSuelto.Name = "rbSuelto";
            this.rbSuelto.Text = "Suelto (+$0)";

            // rbPaquete
            this.rbPaquete.AutoSize = true;
            this.rbPaquete.Location = new Point(150, 142);
            this.rbPaquete.Name = "rbPaquete";
            this.rbPaquete.Text = "Paquete de 3 (+$10)";

            // rbCaja
            this.rbCaja.AutoSize = true;
            this.rbCaja.Location = new Point(320, 142);
            this.rbCaja.Name = "rbCaja";
            this.rbCaja.Text = "Caja (+$20)";

            // chkForro
            this.chkForro.AutoSize = true;
            this.chkForro.Location = new Point(20, 176);
            this.chkForro.Name = "chkForro";
            this.chkForro.Text = "Forro de plástico (+$15)";

            // chkRegalo
            this.chkRegalo.AutoSize = true;
            this.chkRegalo.Location = new Point(20, 202);
            this.chkRegalo.Name = "chkRegalo";
            this.chkRegalo.Text = "Envoltura de regalo (+$20)";

            // btnEnviar
            this.btnEnviar.FlatStyle = FlatStyle.Flat;
            this.btnEnviar.Location = new Point(20, 240);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new Size(200, 34);
            this.btnEnviar.Text = "Agregar al pedido";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);

            // btnLimpiar
            this.btnLimpiar.FlatStyle = FlatStyle.Flat;
            this.btnLimpiar.Location = new Point(235, 240);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new Size(120, 34);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // lstPedido
            this.lstPedido.FormattingEnabled = true;
            this.lstPedido.ItemHeight = 15;
            this.lstPedido.Location = new Point(20, 288);
            this.lstPedido.Name = "lstPedido";
            this.lstPedido.Size = new Size(510, 169);

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblTotal.Location = new Point(20, 472);
            this.lblTotal.Name = "lblTotal";

            // btnRegresar
            this.btnRegresar.FlatStyle = FlatStyle.Flat;
            this.btnRegresar.Location = new Point(400, 466);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new Size(130, 34);
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);

            // Form2
            this.ClientSize = new Size(560, 515);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstPedido);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.chkRegalo);
            this.Controls.Add(this.chkForro);
            this.Controls.Add(this.rbCaja);
            this.Controls.Add(this.rbPaquete);
            this.Controls.Add(this.rbSuelto);
            this.Controls.Add(this.lblEmpaque);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblSaludo);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.FormClosed += new FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
