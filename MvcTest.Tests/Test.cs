using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcTest.Controllers;

namespace MvcTest.Tests
{
    [TestClass]
    public class HomeTests
    {
        [TestMethod]
        public void TestHome()
        {
            var h = new HomeController();
            h.ToString();
        }

        [TestMethod]
        public void TestHomeFail()
        {
            Assert.Fail("This fails");
        }
    }
}
