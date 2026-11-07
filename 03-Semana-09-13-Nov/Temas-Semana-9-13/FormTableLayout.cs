using System.Drawing;

namespace Temas_Semana_9_13;

// Tema 7 - TableLayoutPanel
// Actividad 1: tabla de 2 x 2 con cuatro botones
// Actividad 2: tabla de 1 fila y 2 columnas (Saludar / Despedir)
public class FormTableLayout : Form
{
    public FormTableLayout()
    {
        Text = "TableLayoutPanel";
        StartPosition = FormStartPosition.CenterParent;
        ClientSize = new Size(640, 440);
        BackColor = Color.DimGray;

        var lbl1 = new Label
        {
            Text = "Actividad 1: tabla con cuatro botones (2 filas x 2 columnas)",
            ForeColor = Color.White,
            Location = new Point(20, 15),
            AutoSize = true
        };

        var tabla1 = new TableLayoutPanel
        {
            ColumnCount = 2,
            RowCount = 2,
            Location = new Point(170, 45),
            Size = new Size(300, 160)
        };
        tabla1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
        tabla1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
        tabla1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
        tabla1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));

        for (int i = 0; i < 4; i++)
        {
            int numero = i + 1;
            var boton = new Button
            {
                Text = "button" + numero,
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            boton.Click += (s, e) => MessageBox.Show("Hiciste clic en el Botón " + numero);
            tabla1.Controls.Add(boton, i % 2, i / 2);
        }

        var lbl2 = new Label
        {
            Text = "Actividad 2: dos botones en un TableLayoutPanel (1 fila x 2 columnas)",
            ForeColor = Color.White,
            Location = new Point(20, 235),
            AutoSize = true
        };

        var tabla2 = new TableLayoutPanel
        {
            ColumnCount = 2,
            RowCount = 1,
            Location = new Point(170, 265),
            Size = new Size(300, 150)
        };
        tabla2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
        tabla2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
        tabla2.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));

        var btnSaludar = new Button
        {
            Text = "Saludar",
            Dock = DockStyle.Fill,
            BackColor = Color.FromArgb(192, 255, 192),
            Font = new Font("Segoe UI", 12)
        };
        btnSaludar.Click += (s, e) => MessageBox.Show("¡Hola!");

        var btnDespedir = new Button
        {
            Text = "Despedir",
            Dock = DockStyle.Fill,
            BackColor = Color.FromArgb(255, 192, 192),
            Font = new Font("Segoe UI", 12)
        };
        btnDespedir.Click += (s, e) => MessageBox.Show("¡Adiós!");

        tabla2.Controls.Add(btnSaludar, 0, 0);
        tabla2.Controls.Add(btnDespedir, 1, 0);

        Controls.AddRange(new Control[] { lbl1, tabla1, lbl2, tabla2 });
    }
}
