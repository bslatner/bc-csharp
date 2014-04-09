namespace Org.BouncyCastle
{
    public class DebugOutputConsole : IConsole
    {
        public void WriteLine(string value)
        {
            System.Diagnostics.Debug.WriteLine(value);
        }
    }
}