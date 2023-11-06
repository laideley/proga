namespace labor_exchange
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Welcome());
        }
        internal class Acc
        {
            public static string access = "Гость";
            public static string name = "Гость";
        }
    }
}