using System.IO;

namespace Org.BouncyCastle
{
    static class StreamExtensions
    {
        public static void Close(this Stream stream)
        {
            stream.Dispose();
        }
    }
}
