using Xunit;
using FiguresLibrary;
using FiguresLibrary.Exceptions;

namespace FigureTest
{
    public class CircleTests
    {
        [Theory]
        [InlineData(2, 12.5664)]
        [InlineData(5, 78.5398)]
        [InlineData(9, 254.4690)]
        [InlineData(10, 314.1593)]
        public void RightTests(int r, double expectedArea)
        {
            Circle circle = new Circle(r);
            Assert.Equal(expectedArea, circle.GetArea());
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(-8)]
        public void ExceptionTest(int r)
        {
            Assert.Throws<CircleCreateException>(() => new Circle(r));
        }
    }
}