namespace SEC2_IG1;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // Pantalla de inicio de 3 segundos (Timer) y después el menú principal
        using (var inicio = new FormInicio())
        {
            inicio.ShowDialog();
        }

        Application.Run(new Form1());
    }
}
