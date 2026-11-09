namespace SEC1_IG2
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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(137, 4);
            label1.Name = "label1";
            label1.Size = new Size(575, 25);
            label1.TabIndex = 0;
            label1.Text = "Centro de Bachillerato Tecnológico Industrial y de Servicios 224";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(194, 183);
            label2.Name = "label2";
            label2.Size = new Size(456, 25);
            label2.TabIndex = 1;
            label2.Text = "Emplea frameworks para el desarrollo de software";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_CBTIS_224;
            pictureBox1.Location = new Point(333, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(364, 208);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 3;
            label3.Text = "IG1-RECTANG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(203, 233);
            label4.Name = "label4";
            label4.Size = new Size(437, 21);
            label4.TabIndex = 4;
            label4.Text = "PROFESORA/DOCENTE: ELMA CRISTINA CAMACHO PAEZ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(247, 254);
            label5.Name = "label5";
            label5.Size = new Size(364, 21);
            label5.TabIndex = 5;
            label5.Text = "ALUMNO: CARDENAS VELAZQUEZ LUIS ANGEL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(25, 411);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(578, 322);
            button1.Name = "button1";
            button1.Size = new Size(134, 59);
            button1.TabIndex = 7;
            button1.Text = "ENTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(87, 322);
            button2.Name = "button2";
            button2.Size = new Size(134, 59);
            button2.TabIndex = 8;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LUIS ANGEL CARDENAS VELAZQUEZ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}
