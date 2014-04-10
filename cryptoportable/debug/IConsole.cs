using System.IO;

namespace Org.BouncyCastle
{
    public interface IConsole
    {
        TextWriter Out { get; }
        TextWriter Error { get; }
        void SetOut(TextWriter writer);
        void SetError(TextWriter writer);
        void WriteLine();
        void WriteLine(object value);
        void WriteLine(string value);
        void WriteLine(string format, params object[] args);
    }
}