using System;
using System.Drawing;
using System.Windows.Forms;

namespace Papeleria
{
    public partial class Form2 : Form
    {
        // Referencia al Form1 original para poder regresar a él sin crear uno nuevo
        private Form1 principal;

        // Nombre del alumno que viene desde Form1
        private string nombre;

        // Acumulador del total de todos los pedidos
        private double total = 0;

        // Vector (arreglo de una dimensión) con los productos de la papelería
        private string[] productos = { "Cuaderno profesional", "Lápiz HB", "Pluma azul", "Goma de borrar", "Juego de geometría" };

        // Constructor: recibe el Form1 original y el nombre del alumno
        public Form2(Form1 principal, string nombre)
        {
            InitializeComponent();
            this.principal = principal;
            this.nombre = nombre;

            // Propiedades del Form
            this.Text = "Papelería Escolar - Hacer pedido";
            this.BackColor = Color.LightYellow;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Load: saluda al alumno y llena el ComboBox con el vector
        private void Form2_Load(object sender, EventArgs e)
        {
            lblSaludo.Text = "Hola, " + nombre + ". ¿Qué vas a comprar?";

            // for: recorremos el vector y agregamos cada producto al ComboBox
            for (int i = 0; i < productos.Length; i++)
            {
                cmbProducto.Items.Add(productos[i]);
            }

            cmbProducto.SelectedIndex = 0;   // Seleccionamos el primer producto
            rbSuelto.Checked = true;         // Empaque suelto por defecto
            lblTotal.Visible = false;        // El total se oculta hasta que haya un pedido
        }

        // Botón Agregar: calcula el precio y agrega el pedido al ListBox
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            double precio = 0;

            // switch: según el producto elegido en el ComboBox asignamos su precio
            switch (cmbProducto.SelectedIndex)
            {
                case 0: precio = 60; break;   // Cuaderno profesional
                case 1: precio = 5;  break;   // Lápiz HB
                case 2: precio = 8;  break;   // Pluma azul
                case 3: precio = 4;  break;   // Goma de borrar
                case 4: precio = 45; break;   // Juego de geometría
                default:
                    MessageBox.Show("Elige un producto.");
                    return;
            }

            // if: revisamos qué RadioButton está marcado para sumar el costo del empaque
            string empaque;
            if (rbSuelto.Checked)
            {
                empaque = "Suelto";
            }
            else if (rbPaquete.Checked)
            {
                empaque = "Paquete de 3";
                precio = precio + 10;
            }
            else
            {
                empaque = "Caja";
                precio = precio + 20;
            }

            // CheckBox: los extras se pueden elegir los dos, uno o ninguno
            string extras = "";
            if (chkForro.Checked)
            {
                precio = precio + 15;
                extras = extras + " + Forro";
            }
            if (chkRegalo.Checked)
            {
                precio = precio + 20;
                extras = extras + " + Envoltura";
            }

            // Agregamos el pedido al ListBox con la hora del sistema
            lstPedido.Items.Add(DateTime.Now.ToString("hh:mm tt") + " - " + cmbProducto.Text +
                                " (" + empaque + ")" + extras + " = $" + precio);

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
            chkForro.Checked = false;
            chkRegalo.Checked = false;
            rbSuelto.Checked = true;
            cmbProducto.SelectedIndex = 0;
            cmbProducto.Focus();   // Regresamos el cursor al ComboBox
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
