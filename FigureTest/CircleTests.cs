using Xunit;

namespace FigureTest
{
    public class CircleTests
    {
        [Theory]
        [InlineData(2, 4)]
        [InlineData(5, 4)]
        [InlineData(9, 4)]
        [InlineData(10, 4)]
        public void RightTests(double r, double expectedArea)
        {

        }
    }
}