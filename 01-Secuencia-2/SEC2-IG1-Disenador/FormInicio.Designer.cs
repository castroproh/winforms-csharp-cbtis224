namespace SEC2_IG1;

partial class FormInicio
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
        this.components = new System.ComponentModel.Container();
        this.lblSub = new System.Windows.Forms.Label();
        this.lblTitulo = new System.Windows.Forms.Label();
        this.lblCargando = new System.Windows.Forms.Label();
        this.timer = new System.Windows.Forms.Timer(this.components);
        this.SuspendLayout();
        //
        // lblSub
        //
        this.lblSub.AutoSize = false;
        this.lblSub.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblSub.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.lblSub.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
        this.lblSub.Location = new System.Drawing.Point(0, 130);
        this.lblSub.Name = "lblSub";
        this.lblSub.Size = new System.Drawing.Size(480, 40);
        this.lblSub.TabIndex = 0;
        this.lblSub.Text = "Windows Forms C# - Secuencia 1 y Secuencia 2";
        this.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // lblTitulo
        //
        this.lblTitulo.AutoSize = false;
        this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
        this.lblTitulo.ForeColor = System.Drawing.Color.White;
        this.lblTitulo.Location = new System.Drawing.Point(0, 0);
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.Size = new System.Drawing.Size(480, 130);
        this.lblTitulo.TabIndex = 1;
        this.lblTitulo.Text = "SEC2-IG1";
        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // lblCargando
        //
        this.lblCargando.AutoSize = false;
        this.lblCargando.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.lblCargando.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
        this.lblCargando.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
        this.lblCargando.Location = new System.Drawing.Point(0, 200);
        this.lblCargando.Name = "lblCargando";
        this.lblCargando.Size = new System.Drawing.Size(480, 40);
        this.lblCargando.TabIndex = 2;
        this.lblCargando.Text = "Cargando...";
        this.lblCargando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // timer
        //
        this.timer.Interval = 3000;
        this.timer.Tick += new System.EventHandler(this.timer_Tick);
        //
        // FormInicio
        //
        this.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        this.ClientSize = new System.Drawing.Size(480, 240);
        this.Controls.Add(this.lblSub);
        this.Controls.Add(this.lblTitulo);
        this.Controls.Add(this.lblCargando);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "FormInicio";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Shown += new System.EventHandler(this.FormInicio_Shown);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label lblSub;
    private System.Windows.Forms.Label lblCargando;
    private System.Windows.Forms.Timer timer;
}
