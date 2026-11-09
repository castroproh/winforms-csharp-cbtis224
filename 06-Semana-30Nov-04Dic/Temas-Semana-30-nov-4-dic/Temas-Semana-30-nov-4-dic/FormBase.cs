using System.ComponentModel;

namespace Temas_Semana_30_nov_4_dic
{
    // Formulario base: mismo tamano fijo, fuente y color en todas las pantallas.
    // Si el alumno cierra una pantalla con la X (sin usar un boton de regresar),
    // se cierra todo el programa para que no quede abierto sin ventanas.
    [DesignerCategory("Code")]
    public class FormBase : Form
    {
        protected bool navegando = false;

        public FormBase(string titulo, int ancho, int alto)
        {
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Text = titulo;
            ClientSize = new Size(ancho, alto);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            BackColor = Estilo.Fondo;
            Font = new Font("Segoe UI", 10f);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!navegando)
            {
                Application.Exit();
            }
        }
    }
}
