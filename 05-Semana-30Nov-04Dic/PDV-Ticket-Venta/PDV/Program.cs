namespace PDV
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            string cajero;
            using (var login = new FormLogin())
            {
                if (login.ShowDialog() != DialogResult.OK) return;
                cajero = login.Usuario;
            }
            Application.Run(new FormTicket(cajero));
        }
    }
}
