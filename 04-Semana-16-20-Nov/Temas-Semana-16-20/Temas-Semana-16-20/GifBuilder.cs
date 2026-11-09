using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace TemasSemana1620
{
    /// <summary>
    /// Genera un GIF animado completamente por código (sin archivos externos):
    /// dibuja los cuadros con GDI+ y los escribe en formato GIF89a con compresión LZW.
    /// </summary>
    internal static class GifBuilder
    {
        // Paleta global de 16 colores: fondo + degradado de azules.
        private static readonly Color[] Paleta = CrearPaleta();

        private static Color[] CrearPaleta()
        {
            Color[] p = new Color[16];
            p[0] = Color.FromArgb(20, 24, 48);
            for (int i = 1; i < 16; i++)
            {
                float t = (i - 1) / 14f;
                int r = (int)(30 + 200 * t);
                int g = (int)(90 + 150 * t);
                int b = (int)(160 + 95 * t);
                p[i] = Color.FromArgb(r, g, b);
            }
            return p;
        }

        /// <summary>Crea un "spinner" de puntos que gira. retardoCs = centésimas de segundo por cuadro.</summary>
        public static byte[] CrearSpinner(int lado, int puntos, int retardoCs)
        {
            using (MemoryStream ms = new MemoryStream())
            using (BinaryWriter bw = new BinaryWriter(ms))
            {
                bw.Write(Encoding.ASCII.GetBytes("GIF89a"));
                bw.Write((ushort)lado);
                bw.Write((ushort)lado);
                bw.Write((byte)0xF3);   // tabla global, 16 colores
                bw.Write((byte)0);      // color de fondo
                bw.Write((byte)0);      // relación de aspecto

                foreach (Color c in Paleta)
                {
                    bw.Write(c.R);
                    bw.Write(c.G);
                    bw.Write(c.B);
                }

                // Extensión de repetición infinita (NETSCAPE2.0)
                bw.Write(new byte[] { 0x21, 0xFF, 0x0B });
                bw.Write(Encoding.ASCII.GetBytes("NETSCAPE2.0"));
                bw.Write(new byte[] { 0x03, 0x01, 0x00, 0x00, 0x00 });

                for (int cuadro = 0; cuadro < puntos; cuadro++)
                {
                    using (Bitmap bmp = DibujarCuadro(lado, puntos, cuadro))
                    {
                        byte[] indices = ConvertirAIndices(bmp);

                        // Control gráfico: sin transparencia, el retardo va en centésimas
                        bw.Write(new byte[] { 0x21, 0xF9, 0x04, 0x04 });
                        bw.Write((ushort)retardoCs);
                        bw.Write((byte)0);
                        bw.Write((byte)0);

                        // Descriptor de imagen
                        bw.Write((byte)0x2C);
                        bw.Write((ushort)0);
                        bw.Write((ushort)0);
                        bw.Write((ushort)lado);
                        bw.Write((ushort)lado);
                        bw.Write((byte)0);

                        bw.Write((byte)4); // tamaño mínimo de código LZW (16 colores)
                        byte[] comprimido = Lzw(indices, 4);
                        for (int pos = 0; pos < comprimido.Length; pos += 255)
                        {
                            int n = Math.Min(255, comprimido.Length - pos);
                            bw.Write((byte)n);
                            bw.Write(comprimido, pos, n);
                        }
                        bw.Write((byte)0);
                    }
                }

                bw.Write((byte)0x3B); // fin del archivo
                bw.Flush();
                return ms.ToArray();
            }
        }

        private static Bitmap DibujarCuadro(int lado, int puntos, int cuadro)
        {
            Bitmap bmp = new Bitmap(lado, lado, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Paleta[0]);

                float centro = lado / 2f;
                float radioOrbita = lado * 0.34f;
                float radioPunto = lado * 0.075f;

                for (int i = 0; i < puntos; i++)
                {
                    double ang = 2 * Math.PI * i / puntos - Math.PI / 2;
                    float x = centro + (float)(Math.Cos(ang) * radioOrbita);
                    float y = centro + (float)(Math.Sin(ang) * radioOrbita);

                    int edad = (cuadro - i + puntos) % puntos;
                    int indice = 15 - (int)Math.Round(edad * 11.0 / (puntos - 1));

                    using (SolidBrush pincel = new SolidBrush(Paleta[indice]))
                    {
                        g.FillEllipse(pincel, x - radioPunto, y - radioPunto, radioPunto * 2, radioPunto * 2);
                    }
                }
            }
            return bmp;
        }

        private static byte[] ConvertirAIndices(Bitmap bmp)
        {
            int ancho = bmp.Width;
            int alto = bmp.Height;
            byte[] resultado = new byte[ancho * alto];
            Dictionary<int, byte> cache = new Dictionary<int, byte>();

            for (int y = 0; y < alto; y++)
            {
                for (int x = 0; x < ancho; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    int clave = c.ToArgb();
                    byte indice;
                    if (!cache.TryGetValue(clave, out indice))
                    {
                        indice = MasCercano(c);
                        cache[clave] = indice;
                    }
                    resultado[y * ancho + x] = indice;
                }
            }
            return resultado;
        }

        private static byte MasCercano(Color c)
        {
            int mejor = 0;
            int mejorDistancia = int.MaxValue;
            for (int i = 0; i < Paleta.Length; i++)
            {
                int dr = c.R - Paleta[i].R;
                int dg = c.G - Paleta[i].G;
                int db = c.B - Paleta[i].B;
                int d = dr * dr + dg * dg + db * db;
                if (d < mejorDistancia)
                {
                    mejorDistancia = d;
                    mejor = i;
                }
            }
            return (byte)mejor;
        }

        private sealed class EscritorBits
        {
            private readonly List<byte> _bytes = new List<byte>();
            private int _buffer;
            private int _bits;

            public void Escribir(int codigo, int tamano)
            {
                _buffer |= codigo << _bits;
                _bits += tamano;
                while (_bits >= 8)
                {
                    _bytes.Add((byte)(_buffer & 0xFF));
                    _buffer >>= 8;
                    _bits -= 8;
                }
            }

            public byte[] Terminar()
            {
                if (_bits > 0)
                {
                    _bytes.Add((byte)(_buffer & 0xFF));
                    _buffer = 0;
                    _bits = 0;
                }
                return _bytes.ToArray();
            }
        }

        private static byte[] Lzw(byte[] indices, int tamanoMinimo)
        {
            int limpiar = 1 << tamanoMinimo;
            int fin = limpiar + 1;
            int siguiente = fin + 1;
            int tamano = tamanoMinimo + 1;

            Dictionary<int, int> diccionario = new Dictionary<int, int>();
            EscritorBits bits = new EscritorBits();
            bits.Escribir(limpiar, tamano);

            int prefijo = indices[0];
            for (int i = 1; i < indices.Length; i++)
            {
                int k = indices[i];
                int clave = (prefijo << 8) | k;
                int codigo;
                if (diccionario.TryGetValue(clave, out codigo))
                {
                    prefijo = codigo;
                }
                else
                {
                    bits.Escribir(prefijo, tamano);
                    if (siguiente == 4096)
                    {
                        bits.Escribir(limpiar, tamano);
                        diccionario.Clear();
                        siguiente = fin + 1;
                        tamano = tamanoMinimo + 1;
                    }
                    else
                    {
                        if (siguiente >= (1 << tamano) && tamano < 12)
                        {
                            tamano++;
                        }
                        diccionario[clave] = siguiente;
                        siguiente++;
                    }
                    prefijo = k;
                }
            }

            bits.Escribir(prefijo, tamano);
            bits.Escribir(fin, tamano);
            return bits.Terminar();
        }
    }
}
