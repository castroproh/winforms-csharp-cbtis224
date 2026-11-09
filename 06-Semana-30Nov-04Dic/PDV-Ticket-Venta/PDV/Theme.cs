using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace PDV
{
    /// <summary>
    /// Sistema de color del Punto de Venta.
    ///
    /// REGLA 60-30-10
    ///   60 %  Fondo / Fondo profundo : azul tinta (confianza, seguridad al manejar dinero,
    ///                                   descansa la vista en pantallas oscuras).
    ///   30 %  Superficie / Elevado   : azul-violeta más claro para tarjetas y campos.
    ///   10 %  Acento                 : amarillo Pymasa (optimismo, atención). El amarillo es el
    ///                                   COMPLEMENTARIO del azul-violeta: máximo contraste y
    ///                                   lectura inmediata del botón principal.
    ///
    /// COLORES SEMÁNTICOS (cada uno comunica una acción)
    ///   Verde  = cobrar / listo / éxito   (señal universal de "adelante")
    ///   Coral  = eliminar / peligro       (rojo suavizado: alerta sin agredir)
    ///   Azul   = editar / información     (neutral, confiable)
    ///   Papel  = crema cálido para el ticket (menos deslumbrante que el blanco puro)
    /// </summary>
    public static class Theme
    {
        public static readonly Color Fondo = Color.FromArgb(21, 26, 46);
        public static readonly Color FondoProfundo = Color.FromArgb(14, 17, 34);
        public static readonly Color Superficie = Color.FromArgb(30, 37, 64);
        public static readonly Color Elevado = Color.FromArgb(42, 51, 86);
        public static readonly Color Borde = Color.FromArgb(58, 68, 108);
        public static readonly Color Input = Color.FromArgb(36, 44, 76);

        public static readonly Color Texto = Color.FromArgb(244, 241, 232);
        public static readonly Color Texto2 = Color.FromArgb(154, 163, 199);

        public static readonly Color Acento = Color.FromArgb(255, 214, 10);
        public static readonly Color Exito = Color.FromArgb(52, 211, 153);
        public static readonly Color ExitoOscuro = Color.FromArgb(18, 140, 92);
        public static readonly Color Peligro = Color.FromArgb(255, 92, 108);
        public static readonly Color Info = Color.FromArgb(91, 141, 239);

        public static readonly Color Papel = Color.FromArgb(251, 247, 236);
        public static readonly Color Tinta = Color.FromArgb(43, 42, 51);
        public static readonly Color TintaSuave = Color.FromArgb(112, 110, 128);

        // Paleta rápida: colores de pintura reales, ordenados como un abanico de muestras.
        public static readonly Color[] Paleta =
        {
            Color.FromArgb(243, 238, 221), // Blanco hueso
            Color.FromArgb(255, 214, 10),  // Amarillo sol
            Color.FromArgb(224, 122, 63),  // Naranja terracota
            Color.FromArgb(200, 64, 59),   // Rojo teja
            Color.FromArgb(242, 181, 196), // Rosa palo
            Color.FromArgb(169, 146, 240), // Lavanda
            Color.FromArgb(31, 58, 104),   // Azul marino
            Color.FromArgb(115, 182, 238), // Azul cielo
            Color.FromArgb(46, 196, 182),  // Turquesa
            Color.FromArgb(143, 176, 140), // Verde salvia
            Color.FromArgb(138, 90, 59),   // Café tierra
            Color.FromArgb(154, 160, 168)  // Gris cemento
        };

        public static readonly string[] PaletaNombres =
        {
            "Blanco hueso", "Amarillo sol", "Naranja terracota", "Rojo teja",
            "Rosa palo", "Lavanda", "Azul marino", "Azul cielo",
            "Turquesa", "Verde salvia", "Café tierra", "Gris cemento"
        };

        // ---------- utilidades ----------
        public static Color Lerp(Color a, Color b, float k)
        {
            k = Math.Max(0f, Math.Min(1f, k));
            return Color.FromArgb(
                (int)(a.R + (b.R - a.R) * k),
                (int)(a.G + (b.G - a.G) * k),
                (int)(a.B + (b.B - a.B) * k));
        }

        public static GraphicsPath Rounded(RectangleF r, float d)
        {
            float dd = Math.Max(1f, Math.Min(d, Math.Min(r.Width, r.Height)));
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, dd, dd, 180, 90);
            p.AddArc(r.Right - dd, r.Y, dd, dd, 270, 90);
            p.AddArc(r.Right - dd, r.Bottom - dd, dd, dd, 0, 90);
            p.AddArc(r.X, r.Bottom - dd, dd, dd, 90, 90);
            p.CloseFigure();
            return p;
        }

        // ---------- accesibilidad: contraste WCAG ----------
        public static float Luminance(Color c)
        {
            Func<int, float> f = v =>
            {
                float x = v / 255f;
                return x <= 0.03928f ? x / 12.92f : (float)Math.Pow((x + 0.055f) / 1.055f, 2.4f);
            };
            return 0.2126f * f(c.R) + 0.7152f * f(c.G) + 0.0722f * f(c.B);
        }

        public static float Contrast(Color a, Color b)
        {
            float l1 = Luminance(a), l2 = Luminance(b);
            if (l1 < l2) { float t = l1; l1 = l2; l2 = t; }
            return (l1 + 0.05f) / (l2 + 0.05f);
        }

        /// <summary>Elige texto oscuro o claro según cuál tenga más contraste con el fondo.</summary>
        public static Color TextOn(Color bg)
        {
            return Contrast(bg, FondoProfundo) >= Contrast(bg, Texto) ? FondoProfundo : Texto;
        }

        // ---------- HEX ----------
        public static bool TryColor(string s, out Color c)
        {
            c = Color.White;
            s = (s ?? "").Trim();
            if (s.Length == 0) return false;
            if (!s.StartsWith("#")) s = "#" + s;
            if (!Regex.IsMatch(s, "^#([0-9a-fA-F]{3}|[0-9a-fA-F]{6})$")) return false;
            try { c = ColorTranslator.FromHtml(s); return true; }
            catch { return false; }
        }

        public static string ToHex(Color c)
        {
            return string.Format("#{0:X2}{1:X2}{2:X2}", c.R, c.G, c.B);
        }

        // ---------- rueda de color (HSL) ----------
        public static void ToHsl(Color c, out float h, out float s, out float l)
        {
            float r = c.R / 255f, g = c.G / 255f, b = c.B / 255f;
            float max = Math.Max(r, Math.Max(g, b));
            float min = Math.Min(r, Math.Min(g, b));
            l = (max + min) / 2f;
            float d = max - min;
            if (d < 1e-6f) { h = 0f; s = 0f; return; }
            s = l > 0.5f ? d / (2f - max - min) : d / (max + min);
            if (max == r) h = (g - b) / d + (g < b ? 6f : 0f);
            else if (max == g) h = (b - r) / d + 2f;
            else h = (r - g) / d + 4f;
            h *= 60f;
        }

        static int To255(float v)
        {
            return Math.Max(0, Math.Min(255, (int)Math.Round(v * 255f)));
        }

        public static Color FromHsl(float h, float s, float l)
        {
            h = ((h % 360f) + 360f) % 360f;
            float c = (1f - Math.Abs(2f * l - 1f)) * s;
            float x = c * (1f - Math.Abs((h / 60f) % 2f - 1f));
            float m = l - c / 2f;
            float r = 0, g = 0, b = 0;
            if (h < 60) { r = c; g = x; }
            else if (h < 120) { r = x; g = c; }
            else if (h < 180) { g = c; b = x; }
            else if (h < 240) { g = x; b = c; }
            else if (h < 300) { r = x; b = c; }
            else { r = c; b = x; }
            return Color.FromArgb(To255(r + m), To255(g + m), To255(b + m));
        }

        // ---------- psicología del color ----------
        /// <summary>Devuelve el nombre de la familia del color y lo que comunica.</summary>
        public static string Describir(Color c, out string texto)
        {
            float h, s, l;
            ToHsl(c, out h, out s, out l);

            if (l > 0.88f)
            {
                texto = "Limpieza, luz y amplitud. Hace ver los espacios más grandes y combina con todo.";
                return "Blanco / hueso";
            }
            if (l < 0.12f)
            {
                texto = "Elegancia y fuerza. Úsalo en acentos: da contraste y sofisticación.";
                return "Negro / grafito";
            }
            if (s < 0.12f)
            {
                texto = "Neutralidad y equilibrio. Base perfecta para resaltar colores vivos y muebles.";
                return l < 0.2f ? "Gris grafito" : "Gris neutro";
            }
            if (h >= 15f && h < 50f && l < 0.4f && s > 0.2f)
            {
                texto = "Estabilidad y calidez natural. Da sensación de refugio; combina con verdes y cremas.";
                return "Café / tierra";
            }

            string nombre;
            if (h >= 345f || h < 15f)
            {
                nombre = "Rojo";
                texto = "Energía y pasión. Abre el apetito y llama la atención; mejor en detalles y acentos.";
            }
            else if (h < 45f)
            {
                nombre = "Naranja";
                texto = "Calidez y entusiasmo. Invita a convivir; ideal para cocinas, comedores y áreas sociales.";
            }
            else if (h < 70f)
            {
                nombre = "Amarillo";
                texto = "Optimismo y luz. Alegra y estimula; en exceso cansa la vista, úsalo con medida.";
            }
            else if (h < 160f)
            {
                nombre = "Verde";
                texto = "Equilibrio y naturaleza. Relaja y renueva; excelente para recámaras y estudio.";
            }
            else if (h < 200f)
            {
                nombre = "Turquesa";
                texto = "Frescura y claridad. Calma con energía; funciona muy bien en baños y áreas de trabajo.";
            }
            else if (h < 248f)
            {
                nombre = "Azul";
                texto = "Confianza y calma. Reduce el estrés y da sensación de amplitud; ideal para descansar.";
            }
            else if (h < 290f)
            {
                nombre = "Violeta";
                texto = "Creatividad y elegancia. Aporta profundidad y misterio; mejor en paredes de acento.";
            }
            else
            {
                nombre = "Magenta / rosa";
                texto = "Cariño y ternura. Los tonos suaves dan serenidad; los vivos, diversión y energía.";
            }

            if (l > 0.78f) nombre += " pastel";
            else if (l < 0.25f) nombre += " profundo";
            return nombre;
        }
    }
}
