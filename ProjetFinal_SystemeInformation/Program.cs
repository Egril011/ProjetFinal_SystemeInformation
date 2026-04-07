namespace ProjetFinal_SystemeInformation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            SQLitePCL.Batteries.Init();

            AppServices appServices = new AppServices();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(appServices));
        }
    }
}