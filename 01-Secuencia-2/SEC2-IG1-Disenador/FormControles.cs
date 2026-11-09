using System.Drawing;

namespace SEC2_IG1;

// ComboBox, GroupBox con RadioButton, CheckBox, NumericUpDown y ListBox
public partial class FormControles : Form
{
    public FormControles()
    {
        InitializeComponent();
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        string turno = rbMatutino.Checked ? "Matutino" : "Vespertino";
        string extras = "";
        if (chkLaptop.Checked) extras += " +Laptop";
        if (chkInternet.Checked) extras += " +Internet";

        lstRegistros.Items.Add(cmbCarrera.Text + " | " + nudSemestre.Value + "° | " + turno + extras);
    }

    private void btnQuitar_Click(object sender, EventArgs e)
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
    }
}
