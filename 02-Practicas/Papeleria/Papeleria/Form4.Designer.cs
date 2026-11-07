using System.Drawing;
using System.Windows.Forms;

namespace Papeleria
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTituloDescanso;
        private Button btnReproducir;
        private Button btnDetener;
        private Label lblCredito;
        private Label lblJuego;
        private TextBox txtPalabra;
        private Button btnInvertir;
        private Button btnLimpiar;
        private Label lblInvertido;
        private Label lblResultado;
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
            this.lblTituloDescanso = new Label();
            this.btnReproducir = new Button();
            this.btnDetener = new Button();
            this.lblCredito = new Label();
            this.lblJuego = new Label();
            this.txtPalabra = new TextBox();
            this.btnInvertir = new Button();
            this.btnLimpiar = new Button();
            this.lblInvertido = new Label();
            this.lblResultado = new Label();
            this.btnRegresar = new Button();
            this.SuspendLayout();

            // lblTituloDescanso
            this.lblTituloDescanso.AutoSize = true;
            this.lblTituloDescanso.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTituloDescanso.Location = new Point(20, 15);
            this.lblTituloDescanso.Name = "lblTituloDescanso";
            this.lblTituloDescanso.Text = "Zona de descanso";

            // btnReproducir
            this.btnReproducir.FlatStyle = FlatStyle.Flat;
            this.btnReproducir.Location = new Point(20, 50);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new Size(160, 36);
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);

            // btnDetener
            this.btnDetener.FlatStyle = FlatStyle.Flat;
            this.btnDetener.Location = new Point(195, 50);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new Size(160, 36);
            this.btnDetener.Text = "Detener";
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);

            // lblCredito
            this.lblCredito.AutoSize = false;
            this.lblCredito.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            this.lblCredito.Location = new Point(20, 95);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new Size(510, 36);
            this.lblCredito.Text = "Música: \"Motivator\" de Kevin MacLeod (incompetech.com). Licencia Creative Commons Attribution 4.0 (CC BY 4.0).";

            // lblJuego
            this.lblJuego.AutoSize = true;
            this.lblJuego.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblJuego.Location = new Point(20, 148);
            this.lblJuego.Name = "lblJuego";
            this.lblJuego.Text = "Juego: ¿Es palíndromo?";

            // txtPalabra
            this.txtPalabra.Location = new Point(20, 176);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new Size(300, 23);

            // btnInvertir
            this.btnInvertir.FlatStyle = FlatStyle.Flat;
            this.btnInvertir.Location = new Point(20, 212);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new Size(160, 36);
            this.btnInvertir.Text = "Invertir";
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);

            // btnLimpiar
            this.btnLimpiar.FlatStyle = FlatStyle.Flat;
            this.btnLimpiar.Location = new Point(195, 212);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new Size(160, 36);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // lblInvertido
            this.lblInvertido.AutoSize = true;
            this.lblInvertido.Font = new Font("Segoe UI", 10F);
            this.lblInvertido.Location = new Point(20, 265);
            this.lblInvertido.Name = "lblInvertido";

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblResultado.Location = new Point(20, 295);
            this.lblResultado.Name = "lblResultado";

            // btnRegresar
            this.btnRegresar.FlatStyle = FlatStyle.Flat;
            this.btnRegresar.Location = new Point(400, 400);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new Size(130, 36);
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);

            // Form4
            this.ClientSize = new Size(560, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblInvertido);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.lblJuego);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.lblTituloDescanso);
            this.Name = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.FormClosed += new FormClosedEventHandler(this.Form4_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
