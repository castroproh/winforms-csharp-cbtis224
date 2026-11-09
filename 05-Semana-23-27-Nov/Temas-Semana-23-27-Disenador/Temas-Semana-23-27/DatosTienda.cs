using System.Collections.Generic;

namespace TemasSemana
{
    // Datos de ejemplo de una tienda de abarrotes.
    public static class DatosTienda
    {
        public static readonly string[] Categorias =
        {
            "Lácteos", "Abarrotes", "Bebidas", "Botanas", "Limpieza", "Panadería"
        };

        // Devuelve una lista nueva cada vez, para que cada formulario trabaje con su propia copia.
        public static List<Producto> ObtenerProductos()
        {
            return new List<Producto>
            {
                new Producto(1, "Leche entera 1 L", "Lácteos", 28.50m, 24),
                new Producto(2, "Huevo blanco 12 pzas", "Abarrotes", 45.00m, 15),
                new Producto(3, "Arroz 1 kg", "Abarrotes", 32.00m, 30),
                new Producto(4, "Frijol negro 1 kg", "Abarrotes", 38.50m, 22),
                new Producto(5, "Aceite vegetal 1 L", "Abarrotes", 54.90m, 18),
                new Producto(6, "Refresco de cola 600 ml", "Bebidas", 18.00m, 48),
                new Producto(7, "Agua natural 1 L", "Bebidas", 12.50m, 60),
                new Producto(8, "Jugo de naranja 1 L", "Bebidas", 29.00m, 20),
                new Producto(9, "Papas fritas 45 g", "Botanas", 19.50m, 36),
                new Producto(10, "Galletas surtidas", "Botanas", 26.00m, 28),
                new Producto(11, "Detergente en polvo 1 kg", "Limpieza", 42.00m, 14),
                new Producto(12, "Pan de caja blanco", "Panadería", 41.50m, 12)
            };
        }

        public static int SiguienteId(IEnumerable<Producto> productos)
        {
            int maximo = 0;
            foreach (Producto producto in productos)
            {
                if (producto.Id > maximo)
                {
                    maximo = producto.Id;
                }
            }
            return maximo + 1;
        }
    }
}
