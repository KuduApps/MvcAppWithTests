using Xunit;

namespace MvcTest.Tests
{
    public class TestForXUnit
    {
        [Fact]
        public void MyXunitTest()
        {
            Assert.Equal(4, 2 + 2);
        }

        [Fact]
        public void MyXunitTest2()
        {
            Assert.True(true);
        }
    }
}
