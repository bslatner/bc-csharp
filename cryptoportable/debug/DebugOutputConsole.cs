﻿namespace Org.BouncyCastle
{
    public class DebugOutputConsole : IConsole
    {
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
    }
}