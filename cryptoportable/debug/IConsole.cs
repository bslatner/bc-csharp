namespace Org.BouncyCastle
{
    public interface IConsole
    {
        void WriteLine();
        void WriteLine(object value);
        void WriteLine(string value);
    }
}