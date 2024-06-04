
namespace FiguresLibrary
{
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Raduis {  get; set; }

        public Circle(double raduis) 
        {
            Raduis = raduis;
        }

        /// <summary>
        /// Находит площадь круга по радиусу
        /// </summary>
        /// <returns></returns>
        public override double GetSquare()
        {
            return Raduis * 2 * Math.PI; 
        }
    }
}
