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
            public static string access = "�����";
            public static string name = "�����";
        }
    }
}