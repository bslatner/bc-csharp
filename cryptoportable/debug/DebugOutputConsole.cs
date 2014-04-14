using System.IO;

namespace Org.BouncyCastle
{
    public class DebugOutputConsole : IConsole
    {
        private TextWriter output = new DebugTextWriter();
        private TextWriter error = new DebugTextWriter();

        public TextWriter Out
        {
            get { return output; }
        }

        public TextWriter Error
        {
            get { return error; }
        }

        public void SetOut(TextWriter writer)
        {
            output = writer;
        }

        public void SetError(TextWriter writer)
        {
            error = writer;
        }

        public void WriteLine()
        {
            System.Diagnostics.Debug.WriteLine("");
        }

        public void WriteLine(object value)
        {
            System.Diagnostics.Debug.WriteLine(value);
        }

        public void WriteLine(string value)
        {
            System.Diagnostics.Debug.WriteLine(value);
        }

        public void WriteLine(string format, params object[] args)
        {
            System.Diagnostics.Debug.WriteLine(format, args);
        }
    }
}