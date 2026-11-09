namespace Temas_semana_9___13
{
    partial class Form3
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listBox1 = new ListBox();
            tabPage2 = new TabPage();
            listBox2 = new ListBox();
            tabPage3 = new TabPage();
            listBox3 = new ListBox();
            lblSeleccion = new Label();
            button1 = new Button();
            panelRojo.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
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
            label1.Text = "TabControl - Departamentos";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(30, 95);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(815, 340);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(listBox1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(807, 304);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Alimentos";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.FromArgb(0, 93, 170);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Pollo rostizado", "Pizza familiar", "Pastel de chocolate", "Carne molida 2 kg", "Agua 40 pzas" });
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(807, 304);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(listBox2);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(807, 304);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Electrónica";
            // 
            // listBox2
            // 
            listBox2.Dock = DockStyle.Fill;
            listBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox2.ForeColor = Color.FromArgb(227, 24, 55);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Items.AddRange(new object[] { "Pantalla 55\"", "Laptop", "Audífonos inalámbricos", "Consola de videojuegos", "Bocina bluetooth" });
            listBox2.Location = new Point(0, 0);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(807, 304);
            listBox2.TabIndex = 0;
            listBox2.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(listBox3);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(807, 304);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Hogar";
            // 
            // listBox3
            // 
            listBox3.Dock = DockStyle.Fill;
            listBox3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox3.ForeColor = Color.FromArgb(0, 93, 170);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Items.AddRange(new object[] { "Colchón matrimonial", "Sábanas", "Aspiradora", "Set de sartenes", "Papel de baño 40 rollos" });
            listBox3.Location = new Point(0, 0);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(807, 304);
            listBox3.TabIndex = 0;
            listBox3.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSeleccion.ForeColor = Color.FromArgb(0, 93, 170);
            lblSeleccion.Location = new Point(30, 455);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(300, 25);
            lblSeleccion.TabIndex = 2;
            lblSeleccion.Text = "Selecciona un producto de la lista";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(227, 24, 55);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(705, 495);
            button1.Name = "button1";
            button1.Size = new Size(140, 45);
            button1.TabIndex = 3;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 558);
            Controls.Add(button1);
            Controls.Add(lblSeleccion);
            Controls.Add(tabControl1);
            Controls.Add(panelRojo);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Costco Wholesale - TabControl";
            panelRojo.ResumeLayout(false);
            panelRojo.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelRojo;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox listBox1;
        private TabPage tabPage2;
        private ListBox listBox2;
        private TabPage tabPage3;
        private ListBox listBox3;
        private Label lblSeleccion;
        private Button button1;
    }
}
