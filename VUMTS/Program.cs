namespace VUMTS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            FormMain form = new();
            ModelUltibot model = new();
            Controller controller = new(form, model);
        }
    }
}