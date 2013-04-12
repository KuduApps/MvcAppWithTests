using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcTest.Controllers;

namespace MvcTest.Tests
{
    [TestClass]
    public class TestForMsTest
    {
        [TestMethod]
        public void TestMsTestHome()
        {
            var h = new HomeController();
            h.ToString();
        }

        [TestMethod]
        public void TestMsTestHome2()
        {
            Assert.IsTrue(true);
        }
    }
}
