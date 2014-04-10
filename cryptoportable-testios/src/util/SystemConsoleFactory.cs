namespace Org.BouncyCastle
{
    public class SystemConsoleFactory : IConsoleFactory
    {
        public IConsole CreateInstance()
        {
            return new SystemConsole();
        }
    }
}