using System;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace TemasSemana1620
{
    /// <summary>
    /// Imprime un PrintDocument a un archivo PDF usando la impresora
    /// "Microsoft Print to PDF" que trae Windows 10/11 (sin instalar paquetes).
    /// </summary>
    internal static class PdfUtil
    {
        public const string NombreImpresora = "Microsoft Print to PDF";

        public static bool ImpresoraDisponible()
        {
            foreach (string nombre in PrinterSettings.InstalledPrinters)
            {
                if (string.Equals(nombre, NombreImpresora, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>Avisa con MessageBox si la impresora PDF no está instalada.</summary>
        public static bool ValidarImpresora(IWin32Window dueno)
        {
            if (ImpresoraDisponible())
            {
                return true;
            }
            MessageBox.Show(dueno,
                "No se encontró la impresora \"" + NombreImpresora + "\".\n\n" +
                "Actívala en: Panel de control > Programas > Activar o desactivar las características de Windows > Microsoft Print to PDF.",
                "Impresora no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public static void ImprimirAPdf(PrintDocument doc, string ruta, bool horizontal)
        {
            doc.PrinterSettings.PrinterName = NombreImpresora;
            doc.PrinterSettings.PrintToFile = true;
            doc.PrinterSettings.PrintFileName = ruta;
            doc.DefaultPageSettings.Landscape = horizontal;
            doc.PrintController = new StandardPrintController(); // sin ventanita de progreso
            doc.Print();
        }

        public static void PreguntarAbrir(IWin32Window dueno, string ruta)
        {
            DialogResult r = MessageBox.Show(dueno,
                "Se envió el documento a PDF:\n" + ruta + "\n\n¿Quieres abrirlo ahora?",
                "PDF generado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r != DialogResult.Yes)
            {
                return;
            }

            // La impresora PDF escribe el archivo de forma asíncrona: esperamos un poco.
            for (int i = 0; i < 20 && !File.Exists(ruta); i++)
            {
                Thread.Sleep(150);
            }

            if (!File.Exists(ruta))
            {
                MessageBox.Show(dueno, "El archivo todavía no aparece en la carpeta. Revísalo en unos segundos:\n" + ruta,
                    "PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Process.Start(new ProcessStartInfo(ruta) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(dueno, "No se pudo abrir el PDF:\n" + ex.Message, "PDF",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
