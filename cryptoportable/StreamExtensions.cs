using System.IO;

namespace Org.BouncyCastle
{
    static class StreamExtensions
    {
        public static void Close(this Stream stream)
        {
            stream.Dispose();
        }

        public static void Close(this TextWriter writer)
        {
            writer.Dispose();
        }

        public static byte[] GetBuffer(this MemoryStream stream)
        {
            return stream.ToArray();
        }
    }
}
