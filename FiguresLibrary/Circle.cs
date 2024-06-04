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
        /// <returns>Возращает площадь с округлением 6 чисел после запятой</returns>
        public override double GetArea()
        {
            return Math.Round(radius * 2 * Math.PI, 6); 
        }

        /// <summary>
        /// Валидирует значение радиуса
        /// </summary>
        /// <exception cref="CircleCreateException">Исключение создания круга</exception>
        private void Validate()
        {
            if (radius < 0)
            {
                throw new CircleCreateException("Radius less or equal zero. Circle can't be created.");
            }
        }
    }
}
