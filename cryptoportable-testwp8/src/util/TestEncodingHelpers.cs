using System.Text;

namespace Org.BouncyCastle
{
    static class TestEncodingHelpers
    {
        public static byte[] GetAsciiBytes(string input)
        {
            return Encoding.UTF8.GetBytes(input);
        }

        public static string GetAsciiString(byte[] bytes, int index, int count)
        {
            return Encoding.UTF8.GetString(bytes, index, count);
        }

        public static string GetAsciiString(byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes, 0, bytes.Length);
        }

        public static byte[] GetDefaultEncodingBytes(string input)
        {
            return Encoding.UTF8.GetBytes(input);
        }

        public static string GetDefaultEncodingString(byte[] bytes, int index, int count)
        {
            return Encoding.UTF8.GetString(bytes, index, count);
        }

    }
}
