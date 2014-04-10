using System;
#if PORTABLE
using FileInfo = Org.BouncyCastle.Utilities.IO.FileInfo;
#else
using FileInfo = System.IO.FileInfo;
#endif

namespace Org.BouncyCastle.Utilities.IO
{
    public static class FileSystemHelper
    {
#if PORTABLE

        public static IFileSystem FileSystem { get; set; }

        static FileSystemHelper()
        {
            FileSystem = new PortableFileSystem();
        }

        public static FileInfo GetFileInfo(string fileName)
        {
            return FileSystem.GetFileInfo(fileName);
        }

        public static long GetFileLength(FileInfo fileInfo)
        {
            return FileSystem.GetFileLength(fileInfo);
        }

        public static DateTime GetFileLastWriteTime(FileInfo fileInfo)
        {
            return DateTime.Now;
        }

        private static void EnsureFileSystem()
        {
            if (FileSystem == null)
            {
                throw new System.InvalidOperationException("FileSystemHelper.FileSystem requires initialization");
            }
        }

#else

        public static FileInfo GetFileInfo(string fileName)
        {
            return new FileInfo(fileName);
        }

        public static long GetFileLength(FileInfo fileInfo)
        {
            return fileInfo.Length;
        }

        public static DateTime GetFileLastWriteTime(FileInfo fileInfo)
        {
            return fileInfo.LastWriteTime;
        }


#endif
    }
}