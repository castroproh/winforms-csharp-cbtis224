namespace Temas_Semana_9_13;

partial class FormControlPanel
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
        this.panel1 = new System.Windows.Forms.Panel();
        this.checkBox1 = new System.Windows.Forms.CheckBox();
        this.checkBox2 = new System.Windows.Forms.CheckBox();
        this.checkBox3 = new System.Windows.Forms.CheckBox();
        this.checkBox4 = new System.Windows.Forms.CheckBox();
        this.button1 = new System.Windows.Forms.Button();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.checkBox1);
        this.panel1.Controls.Add(this.checkBox2);
        this.panel1.Controls.Add(this.checkBox3);
        this.panel1.Controls.Add(this.checkBox4);
        this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
        this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panel1.Location = new System.Drawing.Point(30, 30);
        this.panel1.Size = new System.Drawing.Size(300, 230);
        this.panel1.Name = "panel1";
        this.panel1.TabIndex = 0;
        // 
        // checkBox1
        // 
        this.checkBox1.AutoSize = true;
        this.checkBox1.Location = new System.Drawing.Point(50, 25);
        this.checkBox1.Text = "checkBox1";
        this.checkBox1.Name = "checkBox1";
        this.checkBox1.TabIndex = 0;
        // 
        // checkBox2
        // 
        this.checkBox2.AutoSize = true;
        this.checkBox2.Location = new System.Drawing.Point(50, 75);
        this.checkBox2.Text = "checkBox2";
        this.checkBox2.Name = "checkBox2";
        this.checkBox2.TabIndex = 1;
        // 
        // checkBox3
        // 
        this.checkBox3.AutoSize = true;
        this.checkBox3.Location = new System.Drawing.Point(50, 125);
        this.checkBox3.Text = "checkBox3";
        this.checkBox3.Name = "checkBox3";
        this.checkBox3.TabIndex = 2;
        // 
        // checkBox4
        // 
        this.checkBox4.AutoSize = true;
        this.checkBox4.Location = new System.Drawing.Point(50, 175);
        this.checkBox4.Text = "checkBox4";
        this.checkBox4.Name = "checkBox4";
        this.checkBox4.TabIndex = 3;
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(380, 70);
        this.button1.Size = new System.Drawing.Size(130, 130);
        this.button1.Text = "Buscar";
        this.button1.Name = "button1";
        this.button1.TabIndex = 1;
        this.button1.Click += new System.EventHandler(this.BuscarSeleccionados);
        // 
        // FormControlPanel
        // 
        this.ClientSize = new System.Drawing.Size(560, 300);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.button1);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Control Panel";
        this.Name = "FormControlPanel";
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.CheckBox checkBox4;
    private System.Windows.Forms.Button button1;
}
