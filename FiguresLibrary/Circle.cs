using FiguresLibrary.Exceptions;

namespace FiguresLibrary
{
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        private readonly double radius;

        public Circle(double r) 
        {
            Validate();
            radius = r;
        }

        /// <summary>
        /// Находит площадь круга по радиусу
        /// </summary>
        public override double GetSquare()
        {
            return radius * 2 * Math.PI; 
        }

        /// <summary>
        /// Валидирует значение радиуса
        /// </summary>
        /// <exception cref="CircleCreateException"></exception>
        private void Validate()
        {
            if (radius < 0)
            {
                throw new CircleCreateException("Radius less or equal zero. Circle can't be created.");
            }
        }
    }
}
