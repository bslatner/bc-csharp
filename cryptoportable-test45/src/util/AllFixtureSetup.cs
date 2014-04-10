using NUnit.Framework;

namespace Org.BouncyCastle
{
    [SetUpFixture]
    public class AllFixtureSetup
    {
        [SetUp]
        public void SetUp()
        {
            Console.ConsoleFactory = new SystemConsoleFactory();
        }
    }
}
