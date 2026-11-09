using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;

namespace TemasSemana1620
{
    /// <summary>Tema 11: imprime un ticket a PDF con PrintDocument.</summary>
    public class FormGenerarPdf : Form
    {
        private sealed class Articulo
        {
            public string Producto;
            public int Cantidad;
            public decimal Precio;
            public decimal Subtotal { get { return Cantidad * Precio; } }
        }

        private readonly List<Articulo> _articulos = new List<Articulo>();
        private readonly PrintDocument _doc;

        private TextBox _txtCliente;
        private TextBox _txtProducto;
        private TextBox _txtCantidad;
        private TextBox _txtPrecio;
        private ListBox _lstArticulos;
        private Label _lblTotal;

        // Estado de la impresión
        private int _indice;
        private int _pagina;
        private string _clienteImpreso = "";

        public FormGenerarPdf()
        {
            Panel p = Ayudas.Preparar(this, "Tema 11 - Genera PDF (PrintDocument)");

            Ayudas.Etiqueta(p, "Cliente:", 12, 16);
            _txtCliente = Ayudas.Texto(p, 120, 12, 320);

            Ayudas.Etiqueta(p, "Producto:", 12, 56);
            _txtProducto = Ayudas.Texto(p, 120, 52, 320);

            Ayudas.Etiqueta(p, "Cantidad:", 12, 96);
            _txtCantidad = Ayudas.Texto(p, 120, 92, 90);
            _txtCantidad.Text = "1";

            Ayudas.Etiqueta(p, "Precio:", 240, 96);
            _txtPrecio = Ayudas.Texto(p, 310, 92, 130);

            Button btnAgregar = Ayudas.Boton(p, "Agregar artículo", 120, 132, 170, 36);
            btnAgregar.Click += BtnAgregar_Click;

            Button btnQuitar = Ayudas.Boton(p, "Quitar seleccionado", 300, 132, 180, 36);
            btnQuitar.Click += BtnQuitar_Click;

            _lstArticulos = new ListBox();
            _lstArticulos.Location = new Point(12, 184);
            _lstArticulos.Size = new Size(860, 220);
            _lstArticulos.Font = new Font("Consolas", 10F);
            p.Controls.Add(_lstArticulos);

            _lblTotal = Ayudas.Etiqueta(p, "Total: $0.00", 12, 414);
            _lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            Button btnVista = Ayudas.Boton(p, "Vista previa", 12, 456, 170, 40);
            btnVista.Click += BtnVistaPrevia_Click;

            Button btnPdf = Ayudas.Boton(p, "Generar PDF", 192, 456, 200, 40);
            btnPdf.Click += BtnGenerarPdf_Click;

            Button btnLimpiar = Ayudas.Boton(p, "Limpiar todo", 402, 456, 150, 40);
            btnLimpiar.Click += BtnLimpiar_Click;

            _doc = new PrintDocument();
            _doc.DocumentName = "Ticket de venta";
            _doc.BeginPrint += Doc_BeginPrint;
            _doc.PrintPage += Doc_PrintPage;

            FormClosed += FormGenerarPdf_FormClosed;
        }

        private void FormGenerarPdf_FormClosed(object sender, FormClosedEventArgs e)
        {
            _doc.Dispose();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string producto = _txtProducto.Text.Trim();
            if (producto.Length == 0)
            {
                MessageBox.Show(this, "Escribe el nombre del producto.", "Dato faltante",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txtProducto.Focus();
                return;
            }

            int cantidad;
            if (!int.TryParse(_txtCantidad.Text.Trim(), out cantidad) || cantidad <= 0)
            {
                MessageBox.Show(this, "La cantidad debe ser un número entero mayor que 0.", "Cantidad no válida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txtCantidad.Focus();
                _txtCantidad.SelectAll();
                return;
            }

            decimal precio;
            if (!decimal.TryParse(_txtPrecio.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out precio) || precio < 0)
            {
                MessageBox.Show(this, "El precio debe ser un número mayor o igual a 0 (ejemplo: 12.50).", "Precio no válido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txtPrecio.Focus();
                _txtPrecio.SelectAll();
                return;
            }

            Articulo nuevo = new Articulo();
            nuevo.Producto = producto;
            nuevo.Cantidad = cantidad;
            nuevo.Precio = precio;
            _articulos.Add(nuevo);

            _txtProducto.Clear();
            _txtCantidad.Text = "1";
            _txtPrecio.Clear();
            _txtProducto.Focus();
            RefrescarLista();
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            int i = _lstArticulos.SelectedIndex;
            if (i < 0 || i >= _articulos.Count)
            {
                MessageBox.Show(this, "Selecciona un artículo de la lista.", "Quitar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _articulos.RemoveAt(i);
            RefrescarLista();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            _articulos.Clear();
            _txtCliente.Clear();
            _txtProducto.Clear();
            _txtCantidad.Text = "1";
            _txtPrecio.Clear();
            RefrescarLista();
        }

        private void RefrescarLista()
        {
            _lstArticulos.Items.Clear();
            decimal total = 0;
            foreach (Articulo a in _articulos)
            {
                _lstArticulos.Items.Add(string.Format("{0,4} x {1,-28} {2,12:C2} {3,14:C2}",
                    a.Cantidad, a.Producto, a.Precio, a.Subtotal));
                total += a.Subtotal;
            }
            _lblTotal.Text = "Total: " + total.ToString("C2");
        }

        private bool ValidarParaImprimir()
        {
            if (_txtCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show(this, "Escribe el nombre del cliente.", "Dato faltante",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txtCliente.Focus();
                return false;
            }
            if (_articulos.Count == 0)
            {
                MessageBox.Show(this, "Agrega al menos un artículo al ticket.", "Ticket vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void BtnVistaPrevia_Click(object sender, EventArgs e)
        {
            if (!ValidarParaImprimir())
            {
                return;
            }
            try
            {
                using (PrintPreviewDialog vista = new PrintPreviewDialog())
                {
                    vista.Document = _doc;
                    vista.Width = 900;
                    vista.Height = 700;
                    vista.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "No se pudo mostrar la vista previa:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGenerarPdf_Click(object sender, EventArgs e)
        {
            if (!ValidarParaImprimir() || !PdfUtil.ValidarImpresora(this))
            {
                return;
            }

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Documento PDF (*.pdf)|*.pdf";
                dlg.DefaultExt = "pdf";
                dlg.OverwritePrompt = true;
                dlg.FileName = "Ticket_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";
                if (dlg.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    PdfUtil.ImprimirAPdf(_doc, dlg.FileName, false);
                    PdfUtil.PreguntarAbrir(this, dlg.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "No se pudo generar el PDF:\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Doc_BeginPrint(object sender, PrintEventArgs e)
        {
            _indice = 0;
            _pagina = 1;
            _clienteImpreso = _txtCliente.Text.Trim();
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float izq = e.MarginBounds.Left;
            float ancho = e.MarginBounds.Width;
            float y = e.MarginBounds.Top;

            using (Font fTitulo = new Font("Segoe UI", 20F, FontStyle.Bold))
            using (Font fNormal = new Font("Segoe UI", 11F))
            using (Font fNegrita = new Font("Segoe UI", 11F, FontStyle.Bold))
            using (Pen lapiz = new Pen(Color.Black, 1.5F))
            using (StringFormat derecha = new StringFormat())
            {
                derecha.Alignment = StringAlignment.Far;
                float alto = fNormal.GetHeight(g) + 6;

                g.DrawString("TICKET DE VENTA", fTitulo, Brushes.Black, izq, y);
                y += fTitulo.GetHeight(g) + 4;
                g.DrawString("CBTis 224 - Clase de C#", fNormal, Brushes.DimGray, izq, y);
                y += alto;
                g.DrawString("Cliente: " + _clienteImpreso, fNormal, Brushes.Black, izq, y);
                y += alto;
                g.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "     Página " + _pagina,
                    fNormal, Brushes.Black, izq, y);
                y += alto + 4;

                g.DrawLine(lapiz, izq, y, izq + ancho, y);
                y += 6;

                float colProducto = izq + 70;
                float anchoProducto = ancho - 70 - 300;
                g.DrawString("Cant.", fNegrita, Brushes.Black, izq, y);
                g.DrawString("Producto", fNegrita, Brushes.Black, colProducto, y);
                g.DrawString("Precio", fNegrita, Brushes.Black, new RectangleF(izq + ancho - 300, y, 150, alto), derecha);
                g.DrawString("Subtotal", fNegrita, Brushes.Black, new RectangleF(izq + ancho - 150, y, 150, alto), derecha);
                y += alto;
                g.DrawLine(Pens.Gray, izq, y, izq + ancho, y);
                y += 4;

                while (_indice < _articulos.Count)
                {
                    if (y + alto * 3 > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        _pagina++;
                        return;
                    }

                    Articulo a = _articulos[_indice];
                    g.DrawString(a.Cantidad.ToString(), fNormal, Brushes.Black, izq, y);
                    g.DrawString(a.Producto, fNormal, Brushes.Black, new RectangleF(colProducto, y, anchoProducto, alto));
                    g.DrawString(a.Precio.ToString("C2"), fNormal, Brushes.Black,
                        new RectangleF(izq + ancho - 300, y, 150, alto), derecha);
                    g.DrawString(a.Subtotal.ToString("C2"), fNormal, Brushes.Black,
                        new RectangleF(izq + ancho - 150, y, 150, alto), derecha);
                    y += alto;
                    _indice++;
                }

                decimal total = 0;
                foreach (Articulo a in _articulos)
                {
                    total += a.Subtotal;
                }

                y += 4;
                g.DrawLine(lapiz, izq, y, izq + ancho, y);
                y += 6;
                g.DrawString("TOTAL: " + total.ToString("C2"), fNegrita, Brushes.Black,
                    new RectangleF(izq, y, ancho, alto), derecha);
                y += alto * 2;
                g.DrawString("¡Gracias por su compra!", fNormal, Brushes.DimGray, izq, y);
            }

            e.HasMorePages = false;
        }
    }
}
