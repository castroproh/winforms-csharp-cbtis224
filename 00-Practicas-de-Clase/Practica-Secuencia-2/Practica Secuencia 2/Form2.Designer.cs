namespace Practica_Secuencia_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(260, 91);
            listView1.Name = "listView1";
            listView1.Size = new Size(440, 190);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(128, 255, 255);
            label4.Location = new Point(412, 22);
            label4.Name = "label4";
            label4.Size = new Size(131, 40);
            label4.TabIndex = 10;
            label4.Text = "ListView";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(380, 342);
            button1.Name = "button1";
            button1.Size = new Size(191, 112);
            button1.TabIndex = 11;
            button1.Text = "Regresar ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(896, 534);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(listView1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label4;
        private Button button1;
    }
}