using System.IO;
using FileAccess = PCLStorage.FileAccess;
using FileInfo = Org.BouncyCastle.Utilities.IO.FileInfo;
using IFileSystem = Org.BouncyCastle.Utilities.IO.IFileSystem;

namespace cryptoportable_testios
{
    public class PortableFileSystem : IFileSystem
    {
        public FileInfo GetFileInfo(string fileName)
        {
            var fileTask = PCLStorage.FileSystem.Current.GetFileFromPathAsync(fileName);
            fileTask.Wait();
            return new FileInfo(fileTask.Result.Path, fileTask.Result.Name);
        }

        public Stream OpenRead(string fileName)
        {
            var fileTask = PCLStorage.FileSystem.Current.GetFileFromPathAsync(fileName);
            fileTask.Wait();
            var openTask = fileTask.Result.OpenAsync(FileAccess.Read);
            openTask.Wait();
            return openTask.Result;
        }

        public long GetFileLength(FileInfo fileInfo)
        {
            using (var file = OpenRead(fileInfo.FullName))
            {
                return file.Length;
            }
        }
    }
}