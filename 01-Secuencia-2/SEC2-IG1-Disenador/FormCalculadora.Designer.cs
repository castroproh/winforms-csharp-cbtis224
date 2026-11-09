namespace SEC2_IG1;

partial class FormCalculadora
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
        this.txtNum1 = new System.Windows.Forms.TextBox();
        this.lbl2 = new System.Windows.Forms.Label();
        this.txtNum2 = new System.Windows.Forms.TextBox();
        this.btnSumar = new System.Windows.Forms.Button();
        this.btnRestar = new System.Windows.Forms.Button();
        this.btnMultiplicar = new System.Windows.Forms.Button();
        this.btnDividir = new System.Windows.Forms.Button();
        this.lblResultado = new System.Windows.Forms.Label();
        this.SuspendLayout();
        //
        // lbl1
        //
        this.lbl1.AutoSize = true;
        this.lbl1.Location = new System.Drawing.Point(30, 25);
        this.lbl1.Name = "lbl1";
        this.lbl1.TabIndex = 0;
        this.lbl1.Text = "Número 1:";
        //
        // txtNum1
        //
        this.txtNum1.Location = new System.Drawing.Point(120, 21);
        this.txtNum1.Name = "txtNum1";
        this.txtNum1.Size = new System.Drawing.Size(200, 23);
        this.txtNum1.TabIndex = 1;
        //
        // lbl2
        //
        this.lbl2.AutoSize = true;
        this.lbl2.Location = new System.Drawing.Point(30, 65);
        this.lbl2.Name = "lbl2";
        this.lbl2.TabIndex = 2;
        this.lbl2.Text = "Número 2:";
        //
        // txtNum2
        //
        this.txtNum2.Location = new System.Drawing.Point(120, 61);
        this.txtNum2.Name = "txtNum2";
        this.txtNum2.Size = new System.Drawing.Size(200, 23);
        this.txtNum2.TabIndex = 3;
        //
        // btnSumar
        //
        this.btnSumar.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
        this.btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSumar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.btnSumar.Location = new System.Drawing.Point(30, 110);
        this.btnSumar.Name = "btnSumar";
        this.btnSumar.Size = new System.Drawing.Size(70, 50);
        this.btnSumar.TabIndex = 4;
        this.btnSumar.Tag = "+";
        this.btnSumar.Text = "+";
        this.btnSumar.UseVisualStyleBackColor = false;
        this.btnSumar.Click += new System.EventHandler(this.Operar);
        this.btnSumar.MouseLeave += new System.EventHandler(this.Boton_MouseLeave);
        this.btnSumar.MouseHover += new System.EventHandler(this.Boton_MouseHover);
        //
        // btnRestar
        //
        this.btnRestar.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
        this.btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRestar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.btnRestar.Location = new System.Drawing.Point(110, 110);
        this.btnRestar.Name = "btnRestar";
        this.btnRestar.Size = new System.Drawing.Size(70, 50);
        this.btnRestar.TabIndex = 5;
        this.btnRestar.Tag = "-";
        this.btnRestar.Text = "-";
        this.btnRestar.UseVisualStyleBackColor = false;
        this.btnRestar.Click += new System.EventHandler(this.Operar);
        this.btnRestar.MouseLeave += new System.EventHandler(this.Boton_MouseLeave);
        this.btnRestar.MouseHover += new System.EventHandler(this.Boton_MouseHover);
        //
        // btnMultiplicar
        //
        this.btnMultiplicar.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
        this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.btnMultiplicar.Location = new System.Drawing.Point(190, 110);
        this.btnMultiplicar.Name = "btnMultiplicar";
        this.btnMultiplicar.Size = new System.Drawing.Size(70, 50);
        this.btnMultiplicar.TabIndex = 6;
        this.btnMultiplicar.Tag = "*";
        this.btnMultiplicar.Text = "*";
        this.btnMultiplicar.UseVisualStyleBackColor = false;
        this.btnMultiplicar.Click += new System.EventHandler(this.Operar);
        this.btnMultiplicar.MouseLeave += new System.EventHandler(this.Boton_MouseLeave);
        this.btnMultiplicar.MouseHover += new System.EventHandler(this.Boton_MouseHover);
        //
        // btnDividir
        //
        this.btnDividir.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
        this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnDividir.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.btnDividir.Location = new System.Drawing.Point(270, 110);
        this.btnDividir.Name = "btnDividir";
        this.btnDividir.Size = new System.Drawing.Size(70, 50);
        this.btnDividir.TabIndex = 7;
        this.btnDividir.Tag = "/";
        this.btnDividir.Text = "/";
        this.btnDividir.UseVisualStyleBackColor = false;
        this.btnDividir.Click += new System.EventHandler(this.Operar);
        this.btnDividir.MouseLeave += new System.EventHandler(this.Boton_MouseLeave);
        this.btnDividir.MouseHover += new System.EventHandler(this.Boton_MouseHover);
        //
        // lblResultado
        //
        this.lblResultado.AutoSize = true;
        this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        this.lblResultado.Location = new System.Drawing.Point(30, 190);
        this.lblResultado.Name = "lblResultado";
        this.lblResultado.TabIndex = 8;
        this.lblResultado.Text = "Resultado: ";
        //
        // FormCalculadora
        //
        this.ClientSize = new System.Drawing.Size(380, 280);
        this.Controls.Add(this.lbl1);
        this.Controls.Add(this.txtNum1);
        this.Controls.Add(this.lbl2);
        this.Controls.Add(this.txtNum2);
        this.Controls.Add(this.btnSumar);
        this.Controls.Add(this.btnRestar);
        this.Controls.Add(this.btnMultiplicar);
        this.Controls.Add(this.btnDividir);
        this.Controls.Add(this.lblResultado);
        this.Name = "FormCalculadora";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Calculadora";
        this.Shown += new System.EventHandler(this.FormCalculadora_Shown);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl1;
    private System.Windows.Forms.TextBox txtNum1;
    private System.Windows.Forms.Label lbl2;
    private System.Windows.Forms.TextBox txtNum2;
    private System.Windows.Forms.Button btnSumar;
    private System.Windows.Forms.Button btnRestar;
    private System.Windows.Forms.Button btnMultiplicar;
    private System.Windows.Forms.Button btnDividir;
    private System.Windows.Forms.Label lblResultado;
}
