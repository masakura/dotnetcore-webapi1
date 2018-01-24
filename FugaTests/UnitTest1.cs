using Xunit;

namespace FugaTests
{
    public class UnitTest1
    {
        [Fact]
        public void Fail()
        {
            Assert.Equal(1, 2);
        }

        [Fact]
        public void Success()
        {
            Assert.Equal(1, 1);
        }
    }
}