using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPITest.Core;

namespace Unit.Tests.Tests
{
    [TestClass]
    public class UnitTest1
    {
        // Force a failure for build testing purposes only
        [TestMethod]
        [Ignore]
        public void GenerateFailure()
        {
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void TestMethodWorking()
        {
            Assert.AreEqual(SanityTest.Addition(2, 2), 4);
        }
    }
}
