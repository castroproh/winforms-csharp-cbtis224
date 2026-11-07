using System.Drawing;

namespace SEC2_IG1;

// ListView con grupos, Timer (reloj), ToolTip
public class FormHerramientas : Form
{
    private readonly System.Windows.Forms.Timer relojTimer = new System.Windows.Forms.Timer();
    private readonly Label lblReloj;
    private readonly ToolTip toolTip = new ToolTip();

    public FormHerramientas()
    {
        Text = "Herramientas vistas";
        ClientSize = new Size(720, 430);
        StartPosition = FormStartPosition.CenterParent;

        lblReloj = new Label
        {
            Dock = DockStyle.Top,
            Height = 36,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 12, FontStyle.Bold)
        };

        var lista = new ListView
        {
            Dock = DockStyle.Fill,
            View = View.Details,
            FullRowSelect = true,
            GridLines = true,
            ShowGroups = true
        };
        lista.Columns.Add("Herramienta", 170);
        lista.Columns.Add("Para qué sirve", 360);
        lista.Columns.Add("Formulario", 160);

        var gSec1 = new ListViewGroup("Secuencia 1", HorizontalAlignment.Left);
        var gSec2 = new ListViewGroup("Secuencia 2", HorizontalAlignment.Left);
        lista.Groups.Add(gSec1);
        lista.Groups.Add(gSec2);

        void Agregar(ListViewGroup g, string herramienta, string uso, string form)
        {
            lista.Items.Add(new ListViewItem(new[] { herramienta, uso, form }, g));
        }

        Agregar(gSec1, "Panel + Visible", "Mostrar y ocultar zonas del formulario", "Paneles");
        Agregar(gSec1, "PictureBox", "Mostrar una imagen", "Paneles / Rectángulo");
        Agregar(gSec1, "TextBox + Button", "Capturar datos y ejecutar acciones", "Paneles / Rectángulo");
        Agregar(gSec1, "try / catch + MessageBox", "Validar datos y avisar errores", "Rectángulo / Calculadora");
        Agregar(gSec1, "DateTime.Now", "Fecha y hora actual", "Rectángulo");
        Agregar(gSec1, "Focus", "Mover el cursor a un control", "Rectángulo / Calculadora");
        Agregar(gSec1, "Convert.ToDouble", "Convertir texto a número", "Calculadora");
        Agregar(gSec1, "MouseHover / MouseLeave", "Reaccionar al paso del mouse", "Calculadora");

        Agregar(gSec2, "Timer", "Pantalla de inicio y reloj", "Inicio / Herramientas");
        Agregar(gSec2, "DateTimePicker", "Elegir una fecha", "Fechas y enlaces");
        Agregar(gSec2, "ToolTip", "Mensajes de ayuda al pasar el mouse", "Menú / Fechas");
        Agregar(gSec2, "LinkLabel", "Enlace a una página web", "Fechas y enlaces");
        Agregar(gSec2, "ListView con grupos", "Listas con columnas y grupos", "Herramientas vistas");
        Agregar(gSec2, "MenuStrip", "Menú principal", "Menú principal");
        Agregar(gSec2, "ComboBox / ListBox", "Elegir y listar opciones", "Controles de selección");
        Agregar(gSec2, "GroupBox + RadioButton", "Una sola opción dentro de un grupo", "Controles de selección");
        Agregar(gSec2, "CheckBox / NumericUpDown", "Opciones múltiples y números con flechas", "Controles de selección");

        Controls.Add(lista);
        Controls.Add(lblReloj);

        toolTip.SetToolTip(lista, "Herramientas de Windows Forms vistas en clase");

        lista.DoubleClick += (s, e) =>
        {
            if (lista.SelectedItems.Count > 0)
            {
                var item = lista.SelectedItems[0];
                MessageBox.Show(item.SubItems[1].Text + "\n\nEjemplo en: " + item.SubItems[2].Text,
                    item.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        };

        ActualizarReloj();
        relojTimer.Interval = 1000;
        relojTimer.Tick += (s, e) => ActualizarReloj();
        relojTimer.Start();
    }

    private void ActualizarReloj()
    {
        lblReloj.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss");
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            relojTimer.Dispose();
        }
        base.Dispose(disposing);
    }
}
