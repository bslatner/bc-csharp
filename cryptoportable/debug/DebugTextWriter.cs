using System.IO;
using System.Text;

namespace Org.BouncyCastle
{
    public class DebugTextWriter : TextWriter
    {
        private string output = string.Empty;

        public override void Write(char value)
        {
            output += value;
        }

        public override void WriteLine()
        {
            System.Diagnostics.Debug.WriteLine(output);
            output = string.Empty;
        }

        public override void WriteLine(string value)
        {
            output += value;
            WriteLine();
        }

        public override void WriteLine(object value)
        {
            output += value.ToString();
            WriteLine();
        }

        public override void WriteLine(string format, params object[] arg)
        {
            output += string.Format(format, arg);
            WriteLine();
        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}