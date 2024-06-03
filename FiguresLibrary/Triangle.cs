
namespace FiguresLibrary
{
    public class Triangle : Figure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double a, double b, double c) 
        { 
            sideA = a;
            sideB = b;
            sideC = c;
        }

        public override double GetSquare()
        {
            throw new NotImplementedException();
        }
    }
}
