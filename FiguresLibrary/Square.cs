
namespace FiguresLibrary
{
    public class Square : Figure
    {
        public double Raduis {  get; set; }
        public Square(double raduis) 
        {
            Raduis = raduis;
        }
        public override double GetSquare()
        {
            return Raduis * 2 * Math.PI; 
        }
    }
}
