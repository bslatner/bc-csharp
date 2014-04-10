using System.IO;

namespace Org.BouncyCastle
{
    public class SystemConsole : IConsole
    {
        public TextWriter Out { get { return System.Console.Out; } }
        public TextWriter Error { get { return System.Console.Error; }}

        public void WriteLine()
        {
            System.Console.WriteLine();
        }

        public void WriteLine(object value)
        {
            System.Console.WriteLine(value);
        }

        public void WriteLine(string value)
        {
            System.Console.WriteLine(value);
        }

        public void WriteLine(string format, params object[] args)
        {
            System.Console.WriteLine(format, args);
        }
    }
}