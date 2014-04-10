using NUnit.Framework;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle
{
    [SetUpFixture]
    public class AllFixtureSetup
    {
        [SetUp]
        public void SetUp()
        {
            Console.ConsoleFactory = new SystemConsoleFactory();
            FileSystemHelper.FileSystem = new PortableFileSystem();
        }
    }
}
