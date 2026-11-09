namespace Temas_semana_9___13
{
    partial class Form4
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
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
            label1.Text = "TableLayoutPanel - Ticket de compra";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            tableLayoutPanel1.Location = new Point(60, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.7F));
            tableLayoutPanel1.Size = new Size(758, 360);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 93, 170);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(370, 485);
            button1.Name = "button1";
            button1.Size = new Size(140, 45);
            button1.TabIndex = 2;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 558);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelRojo);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Costco Wholesale - TableLayoutPanel";
            panelRojo.ResumeLayout(false);
            panelRojo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRojo;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
    }
}
