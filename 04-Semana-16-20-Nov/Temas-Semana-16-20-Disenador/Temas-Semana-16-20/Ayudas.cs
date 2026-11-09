using System;
using System.Drawing;
using System.Windows.Forms;

namespace TemasSemana1620
{
    /// <summary>
    /// Métodos de apoyo para crear controles por código (sin Designer)
    /// y armar la estructura común de cada formulario: título arriba,
    /// contenido al centro y botón Volver abajo.
    /// </summary>
    internal static class Ayudas
    {
        public static readonly Color ColorTitulo = Color.FromArgb(31, 78, 121);

        /// <summary>Prepara el formulario y devuelve el panel donde va el contenido.</summary>
        public static Panel Preparar(Form f, string titulo)
        {
            f.Text = titulo;
            f.AutoScaleDimensions = new SizeF(96F, 96F);
            f.AutoScaleMode = AutoScaleMode.Dpi;
            f.ClientSize = new Size(900, 640);
            f.StartPosition = FormStartPosition.CenterParent;
            f.FormBorderStyle = FormBorderStyle.FixedDialog;
            f.MaximizeBox = false;
            f.MinimizeBox = false;
            f.Font = new Font("Segoe UI", 10F);
            f.BackColor = Color.White;

            Panel contenido = new Panel();
            contenido.Dock = DockStyle.Fill;
            contenido.BackColor = Color.White;

            Panel pie = new Panel();
            pie.Dock = DockStyle.Bottom;
            pie.Height = 56;
            pie.BackColor = Color.FromArgb(240, 242, 247);

            Button volver = new Button();
            volver.Text = "Volver";
            volver.Size = new Size(120, 36);
            volver.Location = new Point(12, 10);
            volver.Click += (sender, e) => f.Close();
            pie.Controls.Add(volver);

            Label lblTitulo = new Label();
            lblTitulo.Text = titulo;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Height = 56;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.BackColor = ColorTitulo;
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            lblTitulo.Padding = new Padding(16, 0, 0, 0);

            // Orden importante: primero el que llena (Fill), luego los de los bordes.
            f.Controls.Add(contenido);
            f.Controls.Add(pie);
            f.Controls.Add(lblTitulo);
            return contenido;
        }

        public static Label Etiqueta(Control padre, string texto, int x, int y)
        {
            Label l = new Label();
            l.Text = texto;
            l.AutoSize = true;
            l.Location = new Point(x, y);
            padre.Controls.Add(l);
            return l;
        }

        public static TextBox Texto(Control padre, int x, int y, int ancho)
        {
            TextBox t = new TextBox();
            t.Location = new Point(x, y);
            t.Width = ancho;
            padre.Controls.Add(t);
            return t;
        }

        public static Button Boton(Control padre, string texto, int x, int y, int ancho, int alto)
        {
            Button b = new Button();
            b.Text = texto;
            b.Location = new Point(x, y);
            b.Size = new Size(ancho, alto);
            padre.Controls.Add(b);
            return b;
        }
    }
}
