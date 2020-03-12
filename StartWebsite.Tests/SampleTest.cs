using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StartWebsite.Tests
{
    [TestClass]
    public class SampleTest
    {
        [TestMethod]
        public void TestTrue()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestFalse()
        {
            Assert.AreNotEqual(1, 2);
        }
    }
}
