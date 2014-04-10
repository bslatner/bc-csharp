using NUnit.Core;

namespace Org.BouncyCastle
{
    static class TestSuiteExtensions
    {
        public static TestResult Run(this TestSuite suite, EventListener listener)
        {
            return suite.Run(listener, null);
        }
    }
}