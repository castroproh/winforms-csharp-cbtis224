using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TemasSemana
{
    // Ayudas para crear controles por código (el proyecto no usa archivos Designer).
    internal static class UI
    {
        public const decimal TasaIva = 0.16m;

        public static readonly CultureInfo Cultura = CrearCultura();

        public static readonly Color Azul = Color.FromArgb(31, 78, 121);
        public static readonly Color AzulClaro = Color.FromArgb(222, 235, 247);
        public static readonly Color Fondo = Color.FromArgb(245, 247, 250);

        public static readonly Font Normal = new Font("Segoe UI", 10F);
        public static readonly Font Negrita = new Font("Segoe UI", 10F, FontStyle.Bold);
        public static readonly Font Grande = new Font("Segoe UI", 13F, FontStyle.Bold);
        public static readonly Font Titulo = new Font("Segoe UI", 16F, FontStyle.Bold);

        private static CultureInfo CrearCultura()
        {
            try
            {
                return new CultureInfo("es-MX");
            }
            catch (CultureNotFoundException)
            {
                return CultureInfo.InvariantCulture;
            }
        }

        public static string Dinero(decimal valor)
        {
            return valor.ToString("C2", Cultura);
        }

        // Búsqueda que ignora mayúsculas y acentos ("limon" encuentra "Limón").
        public static bool Contiene(string texto, string fragmento)
        {
            if (string.IsNullOrEmpty(fragmento))
            {
                return true;
            }
            if (texto == null)
            {
                return false;
            }
            return CultureInfo.CurrentCulture.CompareInfo.IndexOf(
                texto, fragmento, CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) >= 0;
        }

        // ---------- Mensajes ----------

        public static void Aviso(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Informar(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool Confirmar(string mensaje)
        {
            DialogResult respuesta = MessageBox.Show(mensaje, "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return respuesta == DialogResult.Yes;
        }

        // ---------- Controles ----------

        public static void ConfigurarFormulario(Form formulario, string titulo, int ancho, int alto)
        {
            formulario.AutoScaleDimensions = new SizeF(96F, 96F);
            formulario.AutoScaleMode = AutoScaleMode.Dpi;
            formulario.Text = titulo;
            formulario.ClientSize = new Size(ancho, alto);
            formulario.StartPosition = FormStartPosition.CenterParent;
            formulario.Font = Normal;
            formulario.BackColor = Fondo;
        }

        public static Panel CrearEncabezado(string titulo, string subtitulo, Bitmap icono)
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.BackColor = AzulClaro;
            panel.Margin = new Padding(0);

            PictureBox imagen = new PictureBox();
            imagen.Image = icono;
            imagen.SizeMode = PictureBoxSizeMode.CenterImage;
            imagen.Location = new Point(12, 8);
            imagen.Size = new Size(56, 56);

            Label lblTitulo = new Label();
            lblTitulo.Text = titulo;
            lblTitulo.Font = Titulo;
            lblTitulo.ForeColor = Azul;
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(76, 6);

            Label lblSubtitulo = new Label();
            lblSubtitulo.Text = subtitulo;
            lblSubtitulo.Font = Normal;
            lblSubtitulo.ForeColor = Color.FromArgb(70, 70, 70);
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(79, 42);

            panel.Controls.Add(imagen);
            panel.Controls.Add(lblTitulo);
            panel.Controls.Add(lblSubtitulo);
            return panel;
        }

        public static Label CrearEtiqueta(string texto, bool negrita)
        {
            Label etiqueta = new Label();
            etiqueta.Text = texto;
            etiqueta.AutoSize = true;
            etiqueta.Font = negrita ? Negrita : Normal;
            etiqueta.ForeColor = Color.FromArgb(40, 40, 40);
            return etiqueta;
        }

        public static Button CrearBoton(string texto, int ancho, EventHandler alHacerClic)
        {
            Button boton = new Button();
            boton.Text = texto;
            boton.Size = new Size(ancho, 34);
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = Azul;
            boton.ForeColor = Color.White;
            boton.Font = Negrita;
            boton.Cursor = Cursors.Hand;
            boton.Margin = new Padding(4);
            boton.UseVisualStyleBackColor = false;
            if (alHacerClic != null)
            {
                boton.Click += alHacerClic;
            }
            return boton;
        }

        // Pone una etiqueta con su caja de texto (o ComboBox) debajo y avanza la posición vertical.
        public static void AgregarCampo(Control contenedor, string etiqueta, Control caja, ref int y)
        {
            Label lblCampo = CrearEtiqueta(etiqueta, true);
            lblCampo.Location = new Point(12, y);

            caja.Location = new Point(12, y + 24);
            caja.Width = Math.Max(120, contenedor.Width - 24);
            caja.Font = Normal;
            caja.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            contenedor.Controls.Add(lblCampo);
            contenedor.Controls.Add(caja);
            y += 64;
        }

        // DataGridView de solo lectura con las columnas de Producto, creadas por código.
        public static DataGridView CrearGridProductos()
        {
            DataGridView grid = new DataGridView();
            grid.Dock = DockStyle.Fill;
            grid.AutoGenerateColumns = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.RowHeadersVisible = false;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.EnableHeadersVisualStyles = false;
            grid.Font = Normal;
            grid.Margin = new Padding(0);

            grid.ColumnHeadersDefaultCellStyle.BackColor = Azul;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = Negrita;
            grid.ColumnHeadersHeight = 34;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 246, 252);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 117, 182);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.RowTemplate.Height = 28;

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "colId";
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Width = 50;

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "colNombre";
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Producto";
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.MinimumWidth = 150;

            DataGridViewTextBoxColumn colCategoria = new DataGridViewTextBoxColumn();
            colCategoria.Name = "colCategoria";
            colCategoria.DataPropertyName = "Categoria";
            colCategoria.HeaderText = "Categoría";
            colCategoria.Width = 110;

            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.Name = "colPrecio";
            colPrecio.DataPropertyName = "Precio";
            colPrecio.HeaderText = "Precio";
            colPrecio.Width = 90;
            colPrecio.DefaultCellStyle = new DataGridViewCellStyle();
            colPrecio.DefaultCellStyle.Format = "C2";
            colPrecio.DefaultCellStyle.FormatProvider = Cultura;
            colPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.Name = "colCantidad";
            colCantidad.DataPropertyName = "Cantidad";
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Width = 80;
            colCantidad.DefaultCellStyle = new DataGridViewCellStyle();
            colCantidad.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewTextBoxColumn colImporte = new DataGridViewTextBoxColumn();
            colImporte.Name = "colImporte";
            colImporte.DataPropertyName = "Importe";
            colImporte.HeaderText = "Importe";
            colImporte.Width = 100;
            colImporte.DefaultCellStyle = new DataGridViewCellStyle();
            colImporte.DefaultCellStyle.Format = "C2";
            colImporte.DefaultCellStyle.FormatProvider = Cultura;
            colImporte.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            grid.Columns.AddRange(colId, colNombre, colCategoria, colPrecio, colCantidad, colImporte);
            return grid;
        }
    }
}
