using FiguresLibrary.Exceptions;

namespace FiguresLibrary
{
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        private readonly int radius;

        public Circle(int r) 
        {
            Validate(r);
            radius = r;
        }

        /// <summary>
        /// Находит площадь круга по радиусу
        /// </summary>
        /// <returns>Возращает площадь с округлением 4 чисел после запятой</returns>
        public override double GetArea()
        {
            double area = radius * radius * Math.PI;
            return Math.Round(area, 4); 
        }

        /// <summary>
        /// Валидирует значение радиуса
        /// </summary>
        /// <exception cref="CircleCreateException">Исключение создания круга</exception>
        private void Validate(int r)
        {
            if (r <= 0)
            {
                throw new CircleCreateException("Radius less or equal zero. Circle can't be created.");
            }
        }
    }
}
