namespace Temas_semana_9___13
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panelRojo.SuspendLayout();
            panel1.SuspendLayout();
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
            label1.Text = "Paneles - Ofertas de la semana";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 93, 170);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(113, 95);
            button1.Name = "button1";
            button1.Size = new Size(220, 70);
            button1.TabIndex = 1;
            button1.Text = "Ver ofertas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(227, 24, 55);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(545, 95);
            button2.Name = "button2";
            button2.Size = new Size(220, 70);
            button2.TabIndex = 2;
            button2.Text = "Quitar ofertas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(113, 195);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 320);
            panel1.TabIndex = 3;
            panel1.Visible = false;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(0, 93, 170);
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 25);
            label2.Name = "label2";
            label2.Size = new Size(280, 120);
            label2.TabIndex = 0;
            label2.Text = "Pollo rostizado\n$99.00";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(227, 24, 55);
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(340, 25);
            label3.Name = "label3";
            label3.Size = new Size(280, 120);
            label3.TabIndex = 1;
            label3.Text = "Pañales Kirkland\n$549.00";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(227, 24, 55);
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 170);
            label4.Name = "label4";
            label4.Size = new Size(280, 120);
            label4.TabIndex = 2;
            label4.Text = "Agua 40 pzas\n$129.00";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(0, 93, 170);
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(340, 170);
            label5.Name = "label5";
            label5.Size = new Size(280, 120);
            label5.TabIndex = 3;
            label5.Text = "Pantalla 55\"\n$8,999.00";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 558);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panelRojo);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Costco Wholesale - Paneles";
            panelRojo.ResumeLayout(false);
            panelRojo.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRojo;
        private Label label1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
