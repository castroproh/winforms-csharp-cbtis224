using System.Globalization;

namespace Temas_Semana_30_nov_4_dic
{
    // Un renglon del ticket: producto, precio, cantidad y subtotal
    public class ItemVenta
    {
        public string Producto;
        public decimal Precio;
        public int Cantidad;

        public decimal Subtotal
        {
            get { return Precio * Cantidad; }
        }
    }

    // Datos compartidos entre los formularios (tema 26 y tema 27)
    public static class Venta
    {
        public const decimal TasaIva = 0.16m;      // IVA 16%
        public const int MaxPorProducto = 99;

        public static string Usuario = "Alumno1";
        public static int Folio = 1;

        // Catalogo de productos de la tienda Pymasa
        public static readonly string[] Nombres =
        {
            "Refresco 600 ml", "Agua 1 L", "Papas fritas", "Galletas", "Pan de caja",
            "Leche 1 L", "Huevo (kg)", "Arroz (kg)", "Aceite 1 L", "Jabon de barra"
        };

        public static readonly decimal[] Precios =
        {
            18.50m, 12.00m, 19.00m, 15.00m, 38.00m,
            27.50m, 42.00m, 24.00m, 39.90m, 16.50m
        };

        public static List<ItemVenta> Carrito = new List<ItemVenta>();

        // Agrega un producto; si ya esta en la lista suma la cantidad
        public static bool Agregar(int indice, int cantidad)
        {
            if (indice < 0 || indice >= Nombres.Length) return false;

            foreach (ItemVenta it in Carrito)
            {
                if (it.Producto == Nombres[indice])
                {
                    if (it.Cantidad + cantidad > MaxPorProducto) return false;
                    it.Cantidad += cantidad;
                    return true;
                }
            }

            if (cantidad > MaxPorProducto) return false;
            ItemVenta nuevo = new ItemVenta();
            nuevo.Producto = Nombres[indice];
            nuevo.Precio = Precios[indice];
            nuevo.Cantidad = cantidad;
            Carrito.Add(nuevo);
            return true;
        }

        public static void Limpiar()
        {
            Carrito.Clear();
        }

        public static decimal Subtotal()
        {
            decimal suma = 0m;
            foreach (ItemVenta it in Carrito) suma += it.Subtotal;
            return suma;
        }

        public static int Articulos()
        {
            int n = 0;
            foreach (ItemVenta it in Carrito) n += it.Cantidad;
            return n;
        }

        // IVA sobre una base gravable
        public static decimal Iva(decimal baseGravable)
        {
            return Math.Round(baseGravable * TasaIva, 2, MidpointRounding.AwayFromZero);
        }

        public static string Dinero(decimal valor)
        {
            return "$" + valor.ToString("N2", CultureInfo.CurrentCulture);
        }

        // Convierte el texto de una caja a dinero; false si no es un numero valido
        public static bool TryDinero(string texto, out decimal valor)
        {
            string limpio = (texto ?? "").Replace("$", "").Trim();
            return decimal.TryParse(limpio, NumberStyles.Number, CultureInfo.CurrentCulture, out valor);
        }
    }
}
