using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class Form2 : Form
    {
        // Referencia al Form1 original para poder regresar a él sin crear uno nuevo
        private Form1 principal;

        // Nombre del alumno que viene desde Form1
        private string nombre;

        // Acumulador del total de todos los pedidos
        private double total = 0;

        // Vector (arreglo de una dimensión) con los platillos de la cafetería
        private string[] platillos = { "Torta de jamón", "Burrito", "Quesadillas", "Ensalada", "Hot dog" };

        // Constructor: recibe el Form1 original y el nombre del alumno
        public Form2(Form1 principal, string nombre)
        {
            InitializeComponent();
            this.principal = principal;
            this.nombre = nombre;

            // Propiedades del Form
            this.Text = "Cafetería Escolar - Hacer pedido";
            this.BackColor = Color.LightYellow;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Load: saluda al alumno y llena el ComboBox con el vector
        private void Form2_Load(object sender, EventArgs e)
        {
            lblSaludo.Text = "Hola, " + nombre + ". ¿Qué vas a pedir?";

            // for: recorremos el vector y agregamos cada platillo al ComboBox
            for (int i = 0; i < platillos.Length; i++)
            {
                cmbPlatillo.Items.Add(platillos[i]);
            }

            cmbPlatillo.SelectedIndex = 0;   // Seleccionamos el primer platillo
            rbChico.Checked = true;          // Tamaño chico por defecto
            lblTotal.Visible = false;        // El total se oculta hasta que haya un pedido
        }

        // Botón Enviar: calcula el precio y agrega el pedido al ListBox
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            double precio = 0;

            // switch: según el platillo elegido en el ComboBox asignamos su precio
            switch (cmbPlatillo.SelectedIndex)
            {
                case 0: precio = 35; break;   // Torta de jamón
                case 1: precio = 40; break;   // Burrito
                case 2: precio = 30; break;   // Quesadillas
                case 3: precio = 45; break;   // Ensalada
                case 4: precio = 25; break;   // Hot dog
                default:
                    MessageBox.Show("Elige un platillo.");
                    return;
            }

            // if: revisamos qué RadioButton está marcado para sumar el costo del tamaño
            string tamano;
            if (rbChico.Checked)
            {
                tamano = "Chico";
            }
            else if (rbMediano.Checked)
            {
                tamano = "Mediano";
                precio = precio + 10;
            }
            else
            {
                tamano = "Grande";
                precio = precio + 20;
            }

            // CheckBox: los extras se pueden elegir los dos, uno o ninguno
            string extras = "";
            if (chkAgua.Checked)
            {
                precio = precio + 15;
                extras = extras + " + Agua";
            }
            if (chkPostre.Checked)
            {
                precio = precio + 20;
                extras = extras + " + Postre";
            }

            // Agregamos el pedido al ListBox con la hora del sistema
            lstPedido.Items.Add(DateTime.Now.ToString("hh:mm tt") + " - " + cmbPlatillo.Text +
                                " (" + tamano + ")" + extras + " = $" + precio);

            // Sumamos al total y lo mostramos
            total = total + precio;
            lblTotal.Text = "Total a pagar: $" + total;
            lblTotal.Visible = true;
        }

        // Botón Limpiar: borra el pedido y deja todo como al inicio
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstPedido.Items.Clear();
            total = 0;
            lblTotal.Visible = false;
            chkAgua.Checked = false;
            chkPostre.Checked = false;
            rbChico.Checked = true;
            cmbPlatillo.SelectedIndex = 0;
            cmbPlatillo.Focus();   // Regresamos el cursor al ComboBox
        }

        // Botón Regresar: cierra (destruye) este Form
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // FormClosed: se ejecuta al cerrar con Regresar o con la X.
        // Volvemos a mostrar el MISMO Form1 que estaba oculto (no creamos otro).
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Show();
        }
    }
}