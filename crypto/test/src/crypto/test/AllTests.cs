using System;

#if !__MOBILE__
using NUnit.Core;
#endif
using NUnit.Framework;

using Org.BouncyCastle.Utilities.Test;

namespace Org.BouncyCastle.Crypto.Tests
{
	[TestFixture]
	public class AllTests
	{
#if !__MOBILE__
		[Suite]
		public static TestSuite Suite
		{
			get
			{
				TestSuite suite = new TestSuite("Lightweight Crypto Tests");
				suite.Add(new AllTests());
		        suite.Add(new GcmReorderTest());
				return suite;
			}
		}
#endif

		[Test]
		public void TestCrypto()
		{
			foreach (Org.BouncyCastle.Utilities.Test.ITest test in RegressionTest.tests)
			{
				SimpleTestResult result = (SimpleTestResult)test.Perform();

				if (!result.IsSuccessful())
				{
					Assert.Fail(result.ToString());
				}
			}
		}

#if !__MOBILE__
        public static void Main(
			string[] args)
        {
            //junit.textui.TestRunner.run(suite());
            EventListener el = new NullListener();
            Suite.Run(el);
        }
#endif
	}
}
