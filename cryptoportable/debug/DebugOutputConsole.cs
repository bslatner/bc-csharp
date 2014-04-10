using System;
using System.IO;

namespace Org.BouncyCastle
{
    public class DebugOutputConsole : IConsole
    {
        public TextWriter Out
        {
            get { throw new NotImplementedException(); }
        }

        public TextWriter Error
        {
            get { throw new NotImplementedException(); }
        }

        public void SetOut(TextWriter writer)
        {
            throw new NotImplementedException();
        }

        public void SetError(TextWriter writer)
        {
            throw new NotImplementedException();
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