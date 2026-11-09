using System.Drawing;

namespace SEC2_IG1;

// ComboBox, GroupBox con RadioButton, CheckBox, NumericUpDown y ListBox
public class FormControles : Form
{
    private readonly ComboBox cmbCarrera;
    private readonly RadioButton rbMatutino;
    private readonly RadioButton rbVespertino;
    private readonly CheckBox chkLaptop;
    private readonly CheckBox chkInternet;
    private readonly NumericUpDown nudSemestre;
    private readonly ListBox lstRegistros;

    public FormControles()
    {
        Text = "Controles de selección";
        ClientSize = new Size(560, 360);
        StartPosition = FormStartPosition.CenterParent;

        var lblCarrera = new Label { Text = "Carrera:", Location = new Point(20, 25), AutoSize = true };
        cmbCarrera = new ComboBox
        {
            Location = new Point(100, 21),
            Width = 200,
            DropDownStyle = ComboBoxStyle.DropDownList
        };
        cmbCarrera.Items.AddRange(new object[] { "Programación", "Contabilidad", "Electrónica", "Ofimática" });
        cmbCarrera.SelectedIndex = 0;

        var lblSemestre = new Label { Text = "Semestre:", Location = new Point(20, 65), AutoSize = true };
        nudSemestre = new NumericUpDown { Location = new Point(100, 61), Width = 80, Minimum = 1, Maximum = 6, Value = 1 };

        var grpTurno = new GroupBox { Text = "Turno", Location = new Point(20, 105), Size = new Size(280, 60) };
        rbMatutino = new RadioButton { Text = "Matutino", Location = new Point(20, 25), AutoSize = true, Checked = true };
        rbVespertino = new RadioButton { Text = "Vespertino", Location = new Point(140, 25), AutoSize = true };
        grpTurno.Controls.Add(rbMatutino);
        grpTurno.Controls.Add(rbVespertino);

        var grpExtras = new GroupBox { Text = "Cuenta con", Location = new Point(20, 180), Size = new Size(280, 60) };
        chkLaptop = new CheckBox { Text = "Laptop", Location = new Point(20, 25), AutoSize = true };
        chkInternet = new CheckBox { Text = "Internet en casa", Location = new Point(110, 25), AutoSize = true };
        grpExtras.Controls.Add(chkLaptop);
        grpExtras.Controls.Add(chkInternet);

        var btnAgregar = new Button { Text = "Agregar", Location = new Point(20, 260), Size = new Size(130, 34) };
        var btnQuitar = new Button { Text = "Quitar seleccionado", Location = new Point(160, 260), Size = new Size(140, 34) };

        lstRegistros = new ListBox { Location = new Point(320, 21), Size = new Size(220, 320) };

        Controls.AddRange(new Control[]
        {
            lblCarrera, cmbCarrera, lblSemestre, nudSemestre, grpTurno, grpExtras,
            btnAgregar, btnQuitar, lstRegistros
        });

        btnAgregar.Click += (s, e) =>
        {
            string turno = rbMatutino.Checked ? "Matutino" : "Vespertino";
            string extras = "";
            if (chkLaptop.Checked) extras += " +Laptop";
            if (chkInternet.Checked) extras += " +Internet";

            lstRegistros.Items.Add(cmbCarrera.Text + " | " + nudSemestre.Value + "° | " + turno + extras);
        };

        btnQuitar.Click += (s, e) =>
        {
            if (lstRegistros.SelectedIndex >= 0)
            {
                lstRegistros.Items.RemoveAt(lstRegistros.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecciona un registro de la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        };
    }
}
