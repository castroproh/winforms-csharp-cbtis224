namespace SEC1_PANELES
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(136, 9);
            label1.Name = "label1";
            label1.Size = new Size(573, 25);
            label1.TabIndex = 0;
            label1.Text = "Centro de Bachillerato Tecnológico Industrial y de Servicios 224";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(154, 160);
            label2.Name = "label2";
            label2.Size = new Size(555, 25);
            label2.TabIndex = 1;
            label2.Text = "EMPLEA FRAMEWORKS PARA EL DESARROLLO DE SOFTWARE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(199, 185);
            label3.Name = "label3";
            label3.Size = new Size(447, 21);
            label3.TabIndex = 2;
            label3.Text = "PROFERSORA/DOCENTE: ELMA CRISTINA CAMACHO PAEZ";
            label3.Click += label3_Click;
            label3.MouseLeave += label3_MouseLeave;
            label3.MouseHover += label3_MouseHover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Purple;
            label4.Location = new Point(237, 218);
            label4.Name = "label4";
            label4.Size = new Size(364, 21);
            label4.TabIndex = 3;
            label4.Text = "ALUMNO: LUIS ANGEL CARDENAS VELAZQUEZ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(314, 249);
            label5.Name = "label5";
            label5.Size = new Size(208, 25);
            label5.TabIndex = 4;
            label5.Text = "EJEMPLO DE PANELES";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Yellow;
            label6.Location = new Point(27, 415);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_CBTIS_224;
            pictureBox1.Location = new Point(328, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 101);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(328, 298);
            label7.Name = "label7";
            label7.Size = new Size(192, 25);
            label7.TabIndex = 7;
            label7.Text = "LA MEJOR MAESTRA";
            label7.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 64);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(595, 282);
            button1.Name = "button1";
            button1.Size = new Size(114, 63);
            button1.TabIndex = 8;
            button1.Text = "ENTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 0, 64);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(136, 282);
            button2.Name = "button2";
            button2.Size = new Size(114, 63);
            button2.TabIndex = 9;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "luis angel cardenas velazquez";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private Button button1;
        private Button button2;
    }
}
