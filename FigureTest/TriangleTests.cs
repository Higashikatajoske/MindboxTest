using Xunit;
using FiguresLibrary;
using FiguresLibrary.Exceptions;

namespace FigureTest
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(6, 8, 10, 24)]
        [InlineData(6, 6, 6, 15.5885)]
        [InlineData(5, 5, 9, 9.8075)]
        [InlineData(12, 7, 8, 26.9061)]
        public void RightTests(int sideA, int sideB, int sideC, double expectedArea)
        {
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Equal(expectedArea, triangle.GetArea());
        }

        [Theory]
        [InlineData(-2, -3, -4)]
        [InlineData(5, 5, -4)]
        [InlineData(-2, 5, 5)]
        [InlineData(5, 0, 5)]
        [InlineData(1, 6, 7)]
        [InlineData(10, 5, 15)]
        public void ExceptionTests(int sideA, int sideB, int sideC)
        {
            Assert.Throws<TriangeCreateException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(6, 8, 10, true)]
        [InlineData(6, 6, 6, false)]
        [InlineData(5, 5, 9, false)]
        [InlineData(12, 7, 8, false)]
        public void IsRightAngleTest(int sideA, int sideB, int sideC, bool expected)
        {
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Equal(expected, triangle.IsRightAngle);
        }
    }
}
