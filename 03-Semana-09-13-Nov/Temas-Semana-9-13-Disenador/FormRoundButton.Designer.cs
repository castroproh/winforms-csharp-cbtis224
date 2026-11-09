namespace Temas_Semana_9_13;

partial class FormRoundButton
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
        this.btnNormal = new System.Windows.Forms.Button();
        this.roundButton1 = new Temas_Semana_9_13.RoundButton();
        this.roundButton2 = new Temas_Semana_9_13.RoundButton();
        this.SuspendLayout();
        // 
        // btnNormal
        // 
        this.btnNormal.BackColor = System.Drawing.Color.Red;
        this.btnNormal.Location = new System.Drawing.Point(200, 80);
        this.btnNormal.Size = new System.Drawing.Size(160, 50);
        this.btnNormal.Text = "ROUNDBUTTON";
        this.btnNormal.Name = "btnNormal";
        this.btnNormal.TabIndex = 0;
        this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
        // 
        // roundButton1
        // 
        this.roundButton1.BackColor = System.Drawing.Color.LightSteelBlue;
        this.roundButton1.Location = new System.Drawing.Point(200, 150);
        this.roundButton1.Size = new System.Drawing.Size(160, 80);
        this.roundButton1.Text = "roundButton1";
        this.roundButton1.Name = "roundButton1";
        this.roundButton1.TabIndex = 1;
        this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
        // 
        // roundButton2
        // 
        this.roundButton2.BackColor = System.Drawing.Color.Gold;
        this.roundButton2.Location = new System.Drawing.Point(240, 250);
        this.roundButton2.Size = new System.Drawing.Size(80, 80);
        this.roundButton2.Text = "Círculo";
        this.roundButton2.Name = "roundButton2";
        this.roundButton2.TabIndex = 2;
        this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
        // 
        // FormRoundButton
        // 
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
        this.ClientSize = new System.Drawing.Size(560, 380);
        this.Controls.Add(this.btnNormal);
        this.Controls.Add(this.roundButton1);
        this.Controls.Add(this.roundButton2);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "ROUNDBUTTON";
        this.Name = "FormRoundButton";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Button btnNormal;
    private Temas_Semana_9_13.RoundButton roundButton1;
    private Temas_Semana_9_13.RoundButton roundButton2;
}
