namespace Temas_semana_9___13
{
    partial class Form7
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            lblEstado = new Label();
            lblDemo = new Label();
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
            label1.Text = "Acceso de socios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 93, 170);
            label2.Location = new Point(200, 150);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 93, 170);
            label3.Location = new Point(200, 220);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(350, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 32);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(350, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 32);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(350, 262);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(180, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Mostrar contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(227, 24, 55);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(350, 310);
            button1.Name = "button1";
            button1.Size = new Size(300, 65);
            button1.TabIndex = 6;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.FromArgb(227, 24, 55);
            lblEstado.Location = new Point(200, 410);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(250, 21);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "Intentos restantes: 3";
            // 
            // lblDemo
            // 
            lblDemo.AutoSize = true;
            lblDemo.ForeColor = Color.Gray;
            lblDemo.Location = new Point(200, 500);
            lblDemo.Name = "lblDemo";
            lblDemo.Size = new Size(300, 15);
            lblDemo.TabIndex = 8;
            lblDemo.Text = "Demo: usuario  socio   |   contraseña  costco123";
            // 
            // Form7
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 558);
            Controls.Add(lblDemo);
            Controls.Add(lblEstado);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panelRojo);
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Costco Wholesale - Usuario y Contraseña";
            panelRojo.ResumeLayout(false);
            panelRojo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelRojo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button1;
        private Label lblEstado;
        private Label lblDemo;
    }
}
