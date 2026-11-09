namespace TemasSemana
{
    // Clase Producto: la usan todos los temas (22, 24 y 25 la muestran en un DataGridView).
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        // Propiedad calculada (solo lectura): precio por cantidad.
        public decimal Importe
        {
            get { return Precio * Cantidad; }
        }

        public Producto()
        {
        }

        public Producto(int id, string nombre, string categoria, decimal precio, int cantidad)
        {
            Id = id;
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
            Cantidad = cantidad;
        }

        // Es el texto que muestra el ListBox del tema 21.
        public override string ToString()
        {
            return Nombre + "  -  " + Precio.ToString("C2", UI.Cultura) + "  x " + Cantidad;
        }
    }
}
