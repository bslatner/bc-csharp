using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
    public interface IFileSystem
    {
        FileInfo GetFileInfo(string fileName);
        Stream OpenRead(string fileName);
        long GetFileLength(FileInfo fileInfo);
    }
}