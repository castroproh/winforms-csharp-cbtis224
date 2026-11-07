namespace Temas_semana_9___13
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelRojo = new Panel();
            label1 = new Label();
            lblCarrito = new Label();
            roundButton1 = new RoundButton();
            roundButton2 = new RoundButton();
            roundButton3 = new RoundButton();
            panelRojo.SuspendLayout();
            SuspendLayout();
            // 
            // panelRojo
            // 
            panelRojo.BackColor = Color.FromArgb(227, 24, 55);
            panelRojo.Controls.Add(label1);
            panelRojo.Location = new Point(0, 0);
            panelRojo.Name = "panelRojo";
            panelRojo.Size = new Size(878, 70);
            panelRojo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 14);
            label1.Name = "label1";
            label1.Size = new Size(300, 37);
            label1.TabIndex = 0;
            label1.Text = "RoundButton - Mi carrito";
            // 
            // lblCarrito
            // 
            lblCarrito.AutoSize = true;
            lblCarrito.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCarrito.ForeColor = Color.FromArgb(0, 93, 170);
            lblCarrito.Location = new Point(240, 120);
            lblCarrito.Name = "lblCarrito";
            lblCarrito.Size = new Size(400, 37);
            lblCarrito.TabIndex = 1;
            lblCarrito.Text = "Artículos en el carrito: 0";
            // 
            // roundButton1
            // 
            roundButton1.BackColor = Color.FromArgb(0, 93, 170);
            roundButton1.FlatStyle = FlatStyle.Flat;
            roundButton1.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            roundButton1.ForeColor = Color.White;
            roundButton1.Location = new Point(100, 230);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(170, 170);
            roundButton1.TabIndex = 2;
            roundButton1.Text = "Agregar al carrito";
            roundButton1.UseVisualStyleBackColor = false;
            roundButton1.Click += roundButton1_Click;
            // 
            // roundButton2
            // 
            roundButton2.BackColor = Color.FromArgb(227, 24, 55);
            roundButton2.FlatStyle = FlatStyle.Flat;
            roundButton2.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            roundButton2.ForeColor = Color.White;
            roundButton2.Location = new Point(354, 230);
            roundButton2.Name = "roundButton2";
            roundButton2.Size = new Size(170, 170);
            roundButton2.TabIndex = 3;
            roundButton2.Text = "Vaciar carrito";
            roundButton2.UseVisualStyleBackColor = false;
            roundButton2.Click += roundButton2_Click;
            // 
            // roundButton3
            // 
            roundButton3.BackColor = Color.FromArgb(0, 93, 170);
            roundButton3.FlatStyle = FlatStyle.Flat;
            roundButton3.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            roundButton3.ForeColor = Color.White;
            roundButton3.Location = new Point(608, 230);
            roundButton3.Name = "roundButton3";
            roundButton3.Size = new Size(170, 170);
            roundButton3.TabIndex = 4;
            roundButton3.Text = "Pagar";
            roundButton3.UseVisualStyleBackColor = false;
            roundButton3.Click += roundButton3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 558);
            Controls.Add(roundButton3);
            Controls.Add(roundButton2);
            Controls.Add(roundButton1);
            Controls.Add(lblCarrito);
            Controls.Add(panelRojo);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Costco Wholesale - RoundButton";
            panelRojo.ResumeLayout(false);
            panelRojo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelRojo;
        private Label label1;
        private Label lblCarrito;
        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private RoundButton roundButton3;
    }
}
