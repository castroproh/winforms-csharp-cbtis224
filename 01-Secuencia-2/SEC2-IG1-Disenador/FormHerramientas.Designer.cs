namespace SEC2_IG1;

partial class FormHerramientas
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
        System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Secuencia 1", System.Windows.Forms.HorizontalAlignment.Left);
        System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Secuencia 2", System.Windows.Forms.HorizontalAlignment.Left);
        System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
        "Panel + Visible",
        "Mostrar y ocultar zonas del formulario",
        "Paneles"}, -1);
        System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
        "PictureBox",
        "Mostrar una imagen",
        "Paneles / Rectángulo"}, -1);
        System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
        "TextBox + Button",
        "Capturar datos y ejecutar acciones",
        "Paneles / Rectángulo"}, -1);
        System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
        "try / catch + MessageBox",
        "Validar datos y avisar errores",
        "Rectángulo / Calculadora"}, -1);
        System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
        "DateTime.Now",
        "Fecha y hora actual",
        "Rectángulo"}, -1);
        System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
        "Focus",
        "Mover el cursor a un control",
        "Rectángulo / Calculadora"}, -1);
        System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
        "Convert.ToDouble",
        "Convertir texto a número",
        "Calculadora"}, -1);
        System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
        "MouseHover / MouseLeave",
        "Reaccionar al paso del mouse",
        "Calculadora"}, -1);
        System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
        "Timer",
        "Pantalla de inicio y reloj",
        "Inicio / Herramientas"}, -1);
        System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
        "DateTimePicker",
        "Elegir una fecha",
        "Fechas y enlaces"}, -1);
        System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
        "ToolTip",
        "Mensajes de ayuda al pasar el mouse",
        "Menú / Fechas"}, -1);
        System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
        "LinkLabel",
        "Enlace a una página web",
        "Fechas y enlaces"}, -1);
        System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
        "ListView con grupos",
        "Listas con columnas y grupos",
        "Herramientas vistas"}, -1);
        System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
        "MenuStrip",
        "Menú principal",
        "Menú principal"}, -1);
        System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
        "ComboBox / ListBox",
        "Elegir y listar opciones",
        "Controles de selección"}, -1);
        System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
        "GroupBox + RadioButton",
        "Una sola opción dentro de un grupo",
        "Controles de selección"}, -1);
        System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
        "CheckBox / NumericUpDown",
        "Opciones múltiples y números con flechas",
        "Controles de selección"}, -1);
        this.lblReloj = new System.Windows.Forms.Label();
        this.lista = new System.Windows.Forms.ListView();
        this.colHerramienta = new System.Windows.Forms.ColumnHeader();
        this.colUso = new System.Windows.Forms.ColumnHeader();
        this.colFormulario = new System.Windows.Forms.ColumnHeader();
        this.relojTimer = new System.Windows.Forms.Timer(this.components);
        this.toolTip = new System.Windows.Forms.ToolTip(this.components);
        this.SuspendLayout();
        listViewItem1.Group = listViewGroup1;
        listViewItem2.Group = listViewGroup1;
        listViewItem3.Group = listViewGroup1;
        listViewItem4.Group = listViewGroup1;
        listViewItem5.Group = listViewGroup1;
        listViewItem6.Group = listViewGroup1;
        listViewItem7.Group = listViewGroup1;
        listViewItem8.Group = listViewGroup1;
        listViewItem9.Group = listViewGroup2;
        listViewItem10.Group = listViewGroup2;
        listViewItem11.Group = listViewGroup2;
        listViewItem12.Group = listViewGroup2;
        listViewItem13.Group = listViewGroup2;
        listViewItem14.Group = listViewGroup2;
        listViewItem15.Group = listViewGroup2;
        listViewItem16.Group = listViewGroup2;
        listViewItem17.Group = listViewGroup2;
        //
        // lblReloj
        //
        this.lblReloj.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblReloj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.lblReloj.Location = new System.Drawing.Point(0, 0);
        this.lblReloj.Name = "lblReloj";
        this.lblReloj.Size = new System.Drawing.Size(720, 36);
        this.lblReloj.TabIndex = 0;
        this.lblReloj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // lista
        //
        this.lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        this.colHerramienta,
        this.colUso,
        this.colFormulario});
        this.lista.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lista.FullRowSelect = true;
        this.lista.GridLines = true;
        this.lista.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
        listViewGroup1,
        listViewGroup2});
        this.lista.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
        listViewItem1,
        listViewItem2,
        listViewItem3,
        listViewItem4,
        listViewItem5,
        listViewItem6,
        listViewItem7,
        listViewItem8,
        listViewItem9,
        listViewItem10,
        listViewItem11,
        listViewItem12,
        listViewItem13,
        listViewItem14,
        listViewItem15,
        listViewItem16,
        listViewItem17});
        this.lista.Location = new System.Drawing.Point(0, 36);
        this.lista.Name = "lista";
        this.lista.Size = new System.Drawing.Size(720, 394);
        this.lista.TabIndex = 1;
        this.toolTip.SetToolTip(this.lista, "Herramientas de Windows Forms vistas en clase");
        this.lista.UseCompatibleStateImageBehavior = false;
        this.lista.View = System.Windows.Forms.View.Details;
        this.lista.DoubleClick += new System.EventHandler(this.lista_DoubleClick);
        //
        // colHerramienta
        //
        this.colHerramienta.Text = "Herramienta";
        this.colHerramienta.Width = 170;
        //
        // colUso
        //
        this.colUso.Text = "Para qué sirve";
        this.colUso.Width = 360;
        //
        // colFormulario
        //
        this.colFormulario.Text = "Formulario";
        this.colFormulario.Width = 160;
        //
        // relojTimer
        //
        this.relojTimer.Enabled = true;
        this.relojTimer.Interval = 1000;
        this.relojTimer.Tick += new System.EventHandler(this.relojTimer_Tick);
        //
        // FormHerramientas
        //
        this.ClientSize = new System.Drawing.Size(720, 430);
        this.Controls.Add(this.lista);
        this.Controls.Add(this.lblReloj);
        this.Name = "FormHerramientas";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Herramientas vistas";
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblReloj;
    private System.Windows.Forms.ListView lista;
    private System.Windows.Forms.ColumnHeader colHerramienta;
    private System.Windows.Forms.ColumnHeader colUso;
    private System.Windows.Forms.ColumnHeader colFormulario;
    private System.Windows.Forms.Timer relojTimer;
    private System.Windows.Forms.ToolTip toolTip;
}
