namespace Temas_Semana_9_13;

partial class FormMouseEnter
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
        this.lblTitulo = new System.Windows.Forms.Label();
        this.panel1 = new System.Windows.Forms.Panel();
        this.imagen1 = new System.Windows.Forms.PictureBox();
        this.etiqueta1 = new System.Windows.Forms.Label();
        this.panel2 = new System.Windows.Forms.Panel();
        this.imagen2 = new System.Windows.Forms.PictureBox();
        this.etiqueta2 = new System.Windows.Forms.Label();
        this.panel3 = new System.Windows.Forms.Panel();
        this.imagen3 = new System.Windows.Forms.PictureBox();
        this.etiqueta3 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.imagen1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.imagen2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.imagen3)).BeginInit();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        this.panel3.SuspendLayout();
        this.SuspendLayout();
        // 
        // lblTitulo
        // 
        this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        this.lblTitulo.Size = new System.Drawing.Size(720, 50);
        this.lblTitulo.Text = "Pasa el mouse por cada panel";
        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.TabIndex = 0;
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.imagen1);
        this.panel1.Controls.Add(this.etiqueta1);
        this.panel1.BackColor = System.Drawing.Color.White;
        this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panel1.Location = new System.Drawing.Point(30, 80);
        this.panel1.Size = new System.Drawing.Size(200, 240);
        this.panel1.Name = "panel1";
        this.panel1.TabIndex = 1;
        this.panel1.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
        this.panel1.MouseLeave += new System.EventHandler(this.Panel_MouseLeave);
        // 
        // imagen1
        // 
        this.imagen1.Location = new System.Drawing.Point(30, 20);
        this.imagen1.Size = new System.Drawing.Size(140, 140);
        this.imagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.imagen1.Name = "imagen1";
        this.imagen1.TabIndex = 0;
        // 
        // etiqueta1
        // 
        this.etiqueta1.AutoSize = false;
        this.etiqueta1.Location = new System.Drawing.Point(0, 180);
        this.etiqueta1.Size = new System.Drawing.Size(198, 40);
        this.etiqueta1.Text = "LISTA DE MAESTROS";
        this.etiqueta1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.etiqueta1.Name = "etiqueta1";
        this.etiqueta1.TabIndex = 1;
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.imagen2);
        this.panel2.Controls.Add(this.etiqueta2);
        this.panel2.BackColor = System.Drawing.Color.White;
        this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panel2.Location = new System.Drawing.Point(255, 80);
        this.panel2.Size = new System.Drawing.Size(200, 240);
        this.panel2.Name = "panel2";
        this.panel2.TabIndex = 2;
        this.panel2.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
        this.panel2.MouseLeave += new System.EventHandler(this.Panel_MouseLeave);
        // 
        // imagen2
        // 
        this.imagen2.Location = new System.Drawing.Point(30, 20);
        this.imagen2.Size = new System.Drawing.Size(140, 140);
        this.imagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.imagen2.Name = "imagen2";
        this.imagen2.TabIndex = 0;
        // 
        // etiqueta2
        // 
        this.etiqueta2.AutoSize = false;
        this.etiqueta2.Location = new System.Drawing.Point(0, 180);
        this.etiqueta2.Size = new System.Drawing.Size(198, 40);
        this.etiqueta2.Text = "LISTA DE ALUMNOS";
        this.etiqueta2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.etiqueta2.Name = "etiqueta2";
        this.etiqueta2.TabIndex = 1;
        // 
        // panel3
        // 
        this.panel3.Controls.Add(this.imagen3);
        this.panel3.Controls.Add(this.etiqueta3);
        this.panel3.BackColor = System.Drawing.Color.White;
        this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panel3.Location = new System.Drawing.Point(480, 80);
        this.panel3.Size = new System.Drawing.Size(200, 240);
        this.panel3.Name = "panel3";
        this.panel3.TabIndex = 3;
        this.panel3.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
        this.panel3.MouseLeave += new System.EventHandler(this.Panel_MouseLeave);
        // 
        // imagen3
        // 
        this.imagen3.Location = new System.Drawing.Point(30, 20);
        this.imagen3.Size = new System.Drawing.Size(140, 140);
        this.imagen3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.imagen3.Name = "imagen3";
        this.imagen3.TabIndex = 0;
        // 
        // etiqueta3
        // 
        this.etiqueta3.AutoSize = false;
        this.etiqueta3.Location = new System.Drawing.Point(0, 180);
        this.etiqueta3.Size = new System.Drawing.Size(198, 40);
        this.etiqueta3.Text = "CALIFICACIONES";
        this.etiqueta3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.etiqueta3.Name = "etiqueta3";
        this.etiqueta3.TabIndex = 1;
        // 
        // FormMouseEnter
        // 
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
        this.ClientSize = new System.Drawing.Size(720, 360);
        this.Controls.Add(this.lblTitulo);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.panel3);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "MouseEnter y Panel - Cambiar el color del panel";
        this.Name = "FormMouseEnter";
        ((System.ComponentModel.ISupportInitialize)(this.imagen1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.imagen2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.imagen3)).EndInit();
        this.panel3.ResumeLayout(false);
        this.panel3.PerformLayout();
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox imagen1;
    private System.Windows.Forms.Label etiqueta1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.PictureBox imagen2;
    private System.Windows.Forms.Label etiqueta2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.PictureBox imagen3;
    private System.Windows.Forms.Label etiqueta3;
}
