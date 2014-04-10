using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
    public class FileInfo
    {
        public static IFileSystem FileSystem { get; set; }

        public string FullName { get; private set; }
        public string Name { get; private set; }

        public FileInfo(string fullName, string name)
        {
            FullName = fullName;
            Name = name;
        }

        public Stream OpenRead()
        {
            return FileSystemHelper.FileSystem.OpenRead(FullName);
        }
    }
}
