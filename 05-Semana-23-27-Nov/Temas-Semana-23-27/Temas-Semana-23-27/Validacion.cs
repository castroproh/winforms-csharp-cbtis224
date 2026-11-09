using System.Globalization;

namespace TemasSemana
{
    // Datos ya validados de un producto.
    internal sealed class DatosProducto
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
    }

    internal static class Validacion
    {
        // Indican qué campo falló, para poder poner el cursor ahí.
        public const int CampoNombre = 0;
        public const int CampoCategoria = 1;
        public const int CampoPrecio = 2;
        public const int CampoCantidad = 3;

        public static bool TryLeerProducto(string nombre, string categoria, string precioTexto, string cantidadTexto,
            out DatosProducto datos, out string error, out int campoInvalido)
        {
            datos = null;
            error = null;
            campoInvalido = -1;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                error = "El nombre del producto no puede estar vacío.";
                campoInvalido = CampoNombre;
                return false;
            }
            nombre = nombre.Trim();
            if (nombre.Length > 40)
            {
                error = "El nombre del producto no puede tener más de 40 caracteres.";
                campoInvalido = CampoNombre;
                return false;
            }

            if (string.IsNullOrWhiteSpace(categoria))
            {
                error = "Selecciona una categoría.";
                campoInvalido = CampoCategoria;
                return false;
            }

            if (string.IsNullOrWhiteSpace(precioTexto))
            {
                error = "El precio no puede estar vacío.";
                campoInvalido = CampoPrecio;
                return false;
            }
            decimal precio;
            if (!TryLeerDecimal(precioTexto, out precio))
            {
                error = "El precio debe ser un número válido, por ejemplo 25.50.";
                campoInvalido = CampoPrecio;
                return false;
            }
            if (precio <= 0m || precio > 1000000m)
            {
                error = "El precio debe ser mayor que 0 y no pasar de 1,000,000.";
                campoInvalido = CampoPrecio;
                return false;
            }

            if (string.IsNullOrWhiteSpace(cantidadTexto))
            {
                error = "La cantidad no puede estar vacía.";
                campoInvalido = CampoCantidad;
                return false;
            }
            int cantidad;
            if (!int.TryParse(cantidadTexto.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out cantidad))
            {
                error = "La cantidad debe ser un número entero, por ejemplo 12.";
                campoInvalido = CampoCantidad;
                return false;
            }
            if (cantidad < 1 || cantidad > 100000)
            {
                error = "La cantidad debe estar entre 1 y 100,000.";
                campoInvalido = CampoCantidad;
                return false;
            }

            datos = new DatosProducto
            {
                Nombre = nombre,
                Categoria = categoria.Trim(),
                Precio = precio,
                Cantidad = cantidad
            };
            return true;
        }

        // Acepta "25.50" aunque la computadora use coma decimal, y viceversa.
        private static bool TryLeerDecimal(string texto, out decimal valor)
        {
            texto = texto.Trim().TrimStart('$');
            if (decimal.TryParse(texto, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out valor))
            {
                return true;
            }
            return decimal.TryParse(texto, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out valor);
        }
    }
}
