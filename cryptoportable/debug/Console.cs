namespace Org.BouncyCastle
{
    public static class Console
    {
        private static IConsoleFactory _ConsoleFactory;
        public static IConsoleFactory ConsoleFactory
        {
            get
            {
                return _ConsoleFactory ?? new DebugOutputConsoleFactory();
            }
            set
            {
                _Output = null;
                _ConsoleFactory = value;
            }
        }

        private static IConsole _Output;
        public static IConsole Output
        {
            get { return _Output ?? (_Output = ConsoleFactory.CreateInstance()); }
        }

        public static void WriteLine(string value)
        {
            throw new System.NotImplementedException();
        }
    }
}
