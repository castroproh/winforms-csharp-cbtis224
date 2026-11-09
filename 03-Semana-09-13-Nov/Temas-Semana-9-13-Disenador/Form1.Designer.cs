namespace Temas_Semana_9_13;

partial class Form1
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
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.button3 = new System.Windows.Forms.Button();
        this.button4 = new System.Windows.Forms.Button();
        this.button5 = new System.Windows.Forms.Button();
        this.button6 = new System.Windows.Forms.Button();
        this.button7 = new System.Windows.Forms.Button();
        this.button8 = new System.Windows.Forms.Button();
        this.button9 = new System.Windows.Forms.Button();
        this.btnSalir = new System.Windows.Forms.Button();
        this.titulo = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.button1.Location = new System.Drawing.Point(60, 70);
        this.button1.Size = new System.Drawing.Size(360, 42);
        this.button1.Text = "5a - Panel (Panel-Datos)";
        this.button1.Name = "button1";
        this.button1.TabIndex = 0;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.button2.Location = new System.Drawing.Point(60, 122);
        this.button2.Size = new System.Drawing.Size(360, 42);
        this.button2.Text = "5 - TabControl y Panel";
        this.button2.Name = "button2";
        this.button2.TabIndex = 1;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // button3
        // 
        this.button3.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.button3.Location = new System.Drawing.Point(60, 174);
        this.button3.Size = new System.Drawing.Size(360, 42);
        this.button3.Text = "6 - Control Panel (CheckBox en un Panel)";
        this.button3.Name = "button3";
        this.button3.TabIndex = 2;
        this.button3.Click += new System.EventHandler(this.button3_Click);
        // 
        // button4
        // 
        this.button4.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.button4.Location = new System.Drawing.Point(60, 226);
        this.button4.Size = new System.Drawing.Size(360, 42);
        this.button4.Text = "7 - TableLayoutPanel";
        this.button4.Name = "button4";
        this.button4.TabIndex = 3;
        this.button4.Click += new System.EventHandler(this.button4_Click);
        // 
        // button5
        // 
        this.button5.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.button5.Location = new System.Drawing.Point(60, 278);
        this.button5.Size = new System.Drawing.Size(360, 42);
        this.button5.Text = "8 - RoundButton";
        this.button5.Name = "button5";
        this.button5.TabIndex = 4;
        this.button5.Click += new System.EventHandler(this.button5_Click);
        // 
        // button6
        // 
        this.button6.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.button6.Location = new System.Drawing.Point(60, 330);
        this.button6.Size = new System.Drawing.Size(360, 42);
        this.button6.Text = "10 - Control GroupBox";
        this.button6.Name = "button6";
        this.button6.TabIndex = 5;
        this.button6.Click += new System.EventHandler(this.button6_Click);
        // 
        // button7
        // 
        this.button7.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.button7.Location = new System.Drawing.Point(60, 382);
        this.button7.Size = new System.Drawing.Size(360, 42);
        this.button7.Text = "13 - MouseEnter en Panel";
        this.button7.Name = "button7";
        this.button7.TabIndex = 6;
        this.button7.Click += new System.EventHandler(this.button7_Click);
        // 
        // button8
        // 
        this.button8.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.button8.Location = new System.Drawing.Point(60, 434);
        this.button8.Size = new System.Drawing.Size(360, 42);
        this.button8.Text = "18 - Usuario y contraseña (Punto de venta)";
        this.button8.Name = "button8";
        this.button8.TabIndex = 7;
        this.button8.Click += new System.EventHandler(this.button8_Click);
        // 
        // button9
        // 
        this.button9.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.button9.Location = new System.Drawing.Point(60, 486);
        this.button9.Size = new System.Drawing.Size(360, 42);
        this.button9.Text = "19 - Usuario y contraseña (varios usuarios)";
        this.button9.Name = "button9";
        this.button9.TabIndex = 8;
        this.button9.Click += new System.EventHandler(this.button9_Click);
        // 
        // btnSalir
        // 
        this.btnSalir.BackColor = System.Drawing.Color.Firebrick;
        this.btnSalir.ForeColor = System.Drawing.Color.White;
        this.btnSalir.Location = new System.Drawing.Point(60, 543);
        this.btnSalir.Size = new System.Drawing.Size(360, 36);
        this.btnSalir.Text = "Salir";
        this.btnSalir.Name = "btnSalir";
        this.btnSalir.TabIndex = 9;
        this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
        // 
        // titulo
        // 
        this.titulo.Dock = System.Windows.Forms.DockStyle.Top;
        this.titulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.titulo.Size = new System.Drawing.Size(480, 50);
        this.titulo.Text = "Temas de la semana";
        this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.titulo.Name = "titulo";
        this.titulo.TabIndex = 10;
        // 
        // Form1
        // 
        this.ClientSize = new System.Drawing.Size(480, 640);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button3);
        this.Controls.Add(this.button4);
        this.Controls.Add(this.button5);
        this.Controls.Add(this.button6);
        this.Controls.Add(this.button7);
        this.Controls.Add(this.button8);
        this.Controls.Add(this.button9);
        this.Controls.Add(this.btnSalir);
        this.Controls.Add(this.titulo);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Temas de la semana 9 - 13 de noviembre";
        this.Name = "Form1";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Button btnSalir;
    private System.Windows.Forms.Label titulo;
}
