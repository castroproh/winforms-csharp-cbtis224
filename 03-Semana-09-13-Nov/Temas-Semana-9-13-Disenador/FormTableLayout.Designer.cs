namespace Temas_Semana_9_13;

partial class FormTableLayout
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
        this.lbl1 = new System.Windows.Forms.Label();
        this.tabla1 = new System.Windows.Forms.TableLayoutPanel();
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.button3 = new System.Windows.Forms.Button();
        this.button4 = new System.Windows.Forms.Button();
        this.lbl2 = new System.Windows.Forms.Label();
        this.tabla2 = new System.Windows.Forms.TableLayoutPanel();
        this.btnSaludar = new System.Windows.Forms.Button();
        this.btnDespedir = new System.Windows.Forms.Button();
        this.tabla1.SuspendLayout();
        this.tabla2.SuspendLayout();
        this.SuspendLayout();
        // 
        // lbl1
        // 
        this.lbl1.AutoSize = true;
        this.lbl1.ForeColor = System.Drawing.Color.White;
        this.lbl1.Location = new System.Drawing.Point(20, 15);
        this.lbl1.Text = "Actividad 1: tabla con cuatro botones (2 filas x 2 columnas)";
        this.lbl1.Name = "lbl1";
        this.lbl1.TabIndex = 0;
        // 
        // tabla1
        // 
        this.tabla1.ColumnCount = 2;
        this.tabla1.RowCount = 2;
        this.tabla1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tabla1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tabla1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tabla1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tabla1.Controls.Add(this.button1, 0, 0);
        this.tabla1.Controls.Add(this.button2, 1, 0);
        this.tabla1.Controls.Add(this.button3, 0, 1);
        this.tabla1.Controls.Add(this.button4, 1, 1);
        this.tabla1.Location = new System.Drawing.Point(170, 45);
        this.tabla1.Size = new System.Drawing.Size(300, 160);
        this.tabla1.Name = "tabla1";
        this.tabla1.TabIndex = 1;
        // 
        // button1
        // 
        this.button1.BackColor = System.Drawing.Color.White;
        this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.button1.Size = new System.Drawing.Size(144, 74);
        this.button1.Text = "button1";
        this.button1.Name = "button1";
        this.button1.TabIndex = 0;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.BackColor = System.Drawing.Color.White;
        this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.button2.Size = new System.Drawing.Size(144, 74);
        this.button2.Text = "button2";
        this.button2.Name = "button2";
        this.button2.TabIndex = 1;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // button3
        // 
        this.button3.BackColor = System.Drawing.Color.White;
        this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
        this.button3.Size = new System.Drawing.Size(144, 74);
        this.button3.Text = "button3";
        this.button3.Name = "button3";
        this.button3.TabIndex = 2;
        this.button3.Click += new System.EventHandler(this.button3_Click);
        // 
        // button4
        // 
        this.button4.BackColor = System.Drawing.Color.White;
        this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
        this.button4.Size = new System.Drawing.Size(144, 74);
        this.button4.Text = "button4";
        this.button4.Name = "button4";
        this.button4.TabIndex = 3;
        this.button4.Click += new System.EventHandler(this.button4_Click);
        // 
        // lbl2
        // 
        this.lbl2.AutoSize = true;
        this.lbl2.ForeColor = System.Drawing.Color.White;
        this.lbl2.Location = new System.Drawing.Point(20, 235);
        this.lbl2.Text = "Actividad 2: dos botones en un TableLayoutPanel (1 fila x 2 columnas)";
        this.lbl2.Name = "lbl2";
        this.lbl2.TabIndex = 2;
        // 
        // tabla2
        // 
        this.tabla2.ColumnCount = 2;
        this.tabla2.RowCount = 1;
        this.tabla2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tabla2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tabla2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tabla2.Controls.Add(this.btnSaludar, 0, 0);
        this.tabla2.Controls.Add(this.btnDespedir, 1, 0);
        this.tabla2.Location = new System.Drawing.Point(170, 265);
        this.tabla2.Size = new System.Drawing.Size(300, 150);
        this.tabla2.Name = "tabla2";
        this.tabla2.TabIndex = 3;
        // 
        // btnSaludar
        // 
        this.btnSaludar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        this.btnSaludar.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnSaludar.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.btnSaludar.Size = new System.Drawing.Size(144, 144);
        this.btnSaludar.Text = "Saludar";
        this.btnSaludar.Name = "btnSaludar";
        this.btnSaludar.TabIndex = 0;
        this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
        // 
        // btnDespedir
        // 
        this.btnDespedir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        this.btnDespedir.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnDespedir.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.btnDespedir.Size = new System.Drawing.Size(144, 144);
        this.btnDespedir.Text = "Despedir";
        this.btnDespedir.Name = "btnDespedir";
        this.btnDespedir.TabIndex = 1;
        this.btnDespedir.Click += new System.EventHandler(this.btnDespedir_Click);
        // 
        // FormTableLayout
        // 
        this.BackColor = System.Drawing.Color.DimGray;
        this.ClientSize = new System.Drawing.Size(640, 440);
        this.Controls.Add(this.lbl1);
        this.Controls.Add(this.tabla1);
        this.Controls.Add(this.lbl2);
        this.Controls.Add(this.tabla2);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "TableLayoutPanel";
        this.Name = "FormTableLayout";
        this.tabla2.ResumeLayout(false);
        this.tabla2.PerformLayout();
        this.tabla1.ResumeLayout(false);
        this.tabla1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lbl1;
    private System.Windows.Forms.TableLayoutPanel tabla1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Label lbl2;
    private System.Windows.Forms.TableLayoutPanel tabla2;
    private System.Windows.Forms.Button btnSaludar;
    private System.Windows.Forms.Button btnDespedir;
}
