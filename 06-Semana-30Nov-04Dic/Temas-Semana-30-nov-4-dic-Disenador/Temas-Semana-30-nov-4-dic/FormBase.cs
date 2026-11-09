namespace Temas_Semana_30_nov_4_dic
{
    // Formulario base: mismo tamano fijo, fuente y color en todas las pantallas.
    // Si el alumno cierra una pantalla con la X (sin usar un boton de regresar),
    // se cierra todo el programa para que no quede abierto sin ventanas.
    public class FormBase : Form
    {
        protected bool navegando = false;

        // Constructor sin parametros: lo necesita el Diseñador de Visual Studio para abrir
        // los formularios que heredan de FormBase (en ejecucion no se usa).
        public FormBase() : this("", 480, 520)
        {
        }

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

        // Los botones planos de Estilo.Boton aclaran su color al pasar el mouse;
        // ese color se calcula en codigo (ControlPaint.Light), por eso se aplica aqui.
        protected static void AplicarHover(params Button[] botones)
        {
            foreach (Button b in botones)
            {
                b.FlatAppearance.MouseOverBackColor = ControlPaint.Light(b.BackColor, 0.25f);
            }
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
