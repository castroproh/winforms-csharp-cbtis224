using System.Globalization;
using System.Text;

namespace PDV
{
    public class SaleRecord
    {
        public int Folio;
        public DateTime Fecha;
        public string Cliente;
        public string Cajero;
        public string Detalle;
        public int Articulos;
        public decimal Subtotal, DescPct, Descuento, Iva, Total, Recibido, Cambio;
    }

    /// <summary>Ventas de la sesión (para el corte de caja). Se exportan a CSV en Documentos\PDV.</summary>
    public static class SalesLog
    {
        public static readonly List<SaleRecord> Ventas = new List<SaleRecord>();

        static string Q(string s)
        {
            return "\"" + (s ?? "").Replace("\"", "\"\"") + "\"";
        }

        public static string Exportar()
        {
            var inv = CultureInfo.InvariantCulture;
            string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PDV");
            Directory.CreateDirectory(dir);
            string path = Path.Combine(dir, "corte_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv");

            var sb = new StringBuilder();
            sb.AppendLine("Folio,Fecha,Cliente,Cajero,Articulos,Subtotal,DescuentoPct,Descuento,IVA,Total,Recibido,Cambio,Detalle");
            foreach (var v in Ventas)
            {
                sb.AppendLine(string.Join(",", new[]
                {
                    v.Folio.ToString("0000"),
                    Q(v.Fecha.ToString("yyyy-MM-dd HH:mm:ss")),
                    Q(v.Cliente),
                    Q(v.Cajero),
                    v.Articulos.ToString(),
                    v.Subtotal.ToString("0.00", inv),
                    v.DescPct.ToString("0.##", inv),
                    v.Descuento.ToString("0.00", inv),
                    v.Iva.ToString("0.00", inv),
                    v.Total.ToString("0.00", inv),
                    v.Recibido.ToString("0.00", inv),
                    v.Cambio.ToString("0.00", inv),
                    Q(v.Detalle)
                }));
            }
            File.WriteAllText(path, sb.ToString(), new UTF8Encoding(true));
            return path;
        }
    }
}
