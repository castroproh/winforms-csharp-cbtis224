using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cine
{
    public partial class Form2 : Form
    {
        // Referencia al Form1 original para poder regresar a él sin crear uno nuevo
        private Form1 principal;

        // Nombre del cliente que viene desde Form1
        private string nombre;

        // Acumulador del total de todas las compras
        private double total = 0;

        // Vector (arreglo de una dimensión) con las películas en cartelera
        private string[] peliculas = { "Aventura en la selva", "Misterio en el museo", "Robots del futuro", "Comedia de verano", "Terror en la cabaña" };

        // Constructor: recibe el Form1 original y el nombre del cliente
        public Form2(Form1 principal, string nombre)
        {
            InitializeComponent();
            this.principal = principal;
            this.nombre = nombre;

            // Propiedades del Form
            this.Text = "Cine Estrella - Comprar boletos";
            this.BackColor = Color.LightCyan;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Load: saluda al cliente y llena el ComboBox con el vector
        private void Form2_Load(object sender, EventArgs e)
        {
            lblSaludo.Text = "Hola, " + nombre + ". ¿Qué película quieres ver?";

            // for: recorremos el vector y agregamos cada película al ComboBox
            for (int i = 0; i < peliculas.Length; i++)
            {
                cmbPelicula.Items.Add(peliculas[i]);
            }

            cmbPelicula.SelectedIndex = 0;   // Seleccionamos la primera película
            rbNormal.Checked = true;         // Sala normal por defecto
            lblTotal.Visible = false;        // El total se oculta hasta que haya una compra
        }

        // Botón Comprar: calcula el precio y agrega la compra al ListBox
        private void btnComprar_Click(object sender, EventArgs e)
        {
            double precio = 0;

            // switch: según la película elegida en el ComboBox asignamos su precio de boleto
            switch (cmbPelicula.SelectedIndex)
            {
                case 0: precio = 60; break;   // Aventura en la selva
                case 1: precio = 65; break;   // Misterio en el museo
                case 2: precio = 70; break;   // Robots del futuro
                case 3: precio = 55; break;   // Comedia de verano
                case 4: precio = 65; break;   // Terror en la cabaña
                default:
                    MessageBox.Show("Elige una película.");
                    return;
            }

            // if: revisamos qué RadioButton está marcado para sumar el costo de la sala
            string sala;
            if (rbNormal.Checked)
            {
                sala = "Normal";
            }
            else if (rb3D.Checked)
            {
                sala = "3D";
                precio = precio + 20;
            }
            else
            {
                sala = "VIP";
                precio = precio + 40;
            }

            // CheckBox: los extras se pueden elegir los dos, uno o ninguno (se cobran por boleto)
            string extras = "";
            if (chkPalomitas.Checked)
            {
                precio = precio + 50;
                extras = extras + " + Palomitas";
            }
            if (chkRefresco.Checked)
            {
                precio = precio + 30;
                extras = extras + " + Refresco";
            }

            // NumericUpDown: cantidad de boletos (Value es decimal, lo pasamos a int)
            int cantidad = (int)numBoletos.Value;
            double subtotal = precio * cantidad;

            // if: descuento de 10% si compran 4 boletos o más
            string descuento = "";
            if (cantidad >= 4)
            {
                subtotal = subtotal * 0.90;
                descuento = " (-10%)";
            }

            // Agregamos la compra al ListBox con la hora del sistema
            lstPedido.Items.Add(DateTime.Now.ToString("hh:mm tt") + " - " + cmbPelicula.Text +
                                " (" + sala + ") x" + cantidad + extras + descuento +
                                " = $" + subtotal.ToString("F2"));

            // Sumamos al total y lo mostramos
            total = total + subtotal;
            lblTotal.Text = "Total a pagar: $" + total.ToString("F2");
            lblTotal.Visible = true;
        }

        // Botón Limpiar: borra las compras y deja todo como al inicio
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstPedido.Items.Clear();
            total = 0;
            lblTotal.Visible = false;
            chkPalomitas.Checked = false;
            chkRefresco.Checked = false;
            rbNormal.Checked = true;
            numBoletos.Value = 1;
            cmbPelicula.SelectedIndex = 0;
            cmbPelicula.Focus();   // Regresamos el cursor al ComboBox
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
