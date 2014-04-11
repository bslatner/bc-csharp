using System.IO;
using FileInfo = Org.BouncyCastle.Utilities.IO.FileInfo;
using IFileSystem = Org.BouncyCastle.Utilities.IO.IFileSystem;

namespace Org.BouncyCastle
{
    public class SystemIOFileSystem : IFileSystem
    {
        public FileInfo GetFileInfo(string fileName)
        {
            var ioinfo = new System.IO.FileInfo(fileName);
            return new FileInfo(ioinfo.FullName, ioinfo.Name);
        }

        public Stream OpenRead(string fileName)
        {
            return File.OpenRead(fileName);
        }

        public long GetFileLength(FileInfo fileInfo)
        {
            var ioinfo = new System.IO.FileInfo(fileInfo.FullName);
            return ioinfo.Length;
        }
    }
}