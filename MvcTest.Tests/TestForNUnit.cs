using MvcTest.Controllers;
using NUnit.Framework;

namespace MvcTest.Tests
{
    [TestFixture]
    public class TestForNUnit
    {
        [Test]
        public void TestNUnitHome()
        {
            var h = new HomeController();
            h.ToString();
        }

        [Test]
        public void TestNUnitHome2()
        {
            Assert.IsTrue(false);
        }
    }
}
