using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
    public class FileInfo
    {
        public string FullName { get; private set; }
        public string Name { get; private set; }
        public long Length { get; private set; }
        public DateTime LastWriteTime { get; set; }

        public Stream OpenRead()
        {
            throw new NotImplementedException();
        }
    }
}
