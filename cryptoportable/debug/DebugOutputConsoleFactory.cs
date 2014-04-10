namespace Org.BouncyCastle
{
    public class DebugOutputConsoleFactory : IConsoleFactory
    {
        public IConsole CreateInstance()
        {
            return new DebugOutputConsole();
        }
    }
}