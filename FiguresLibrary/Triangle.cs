using FiguresLibrary.Exceptions;

namespace FiguresLibrary
{
    public class Triangle : Figure
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;

        /// <summary>
        /// Создаёт треугольник по трём сторонам
        /// </summary>
        /// <param name="a">Сторона А</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона С</param>
        public Triangle(double a, double b, double c)
        {
            ValidateSides(a, b, c);
            sideA = a;
            sideB = b;
            sideC = c;
        }

        /// <summary>
        /// Нахождение площади треугольника по трём сторонам
        /// </summary>
        /// <returns>Возвращает площадь с округлением до 6 чисел после запятой</returns>
        public override double GetArea()
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return Math.Round(area, 6);
        }

        /// <summary>
        /// Проверка является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightAngle
        {                                                                 
            get 
            { 
                return sideA * sideA + sideB * sideB == sideC * sideC || sideA * sideA + sideC * sideC == sideB * sideB
                    || sideB * sideB + sideC * sideC == sideA * sideA;
            } 
        }

        private void ValidateSides(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0) 
                throw new TriangeCreateException("One side or several have negative value. Triangle can't be created.");

            if (a + b < c || b + c < a || a + c < b)
                throw new TriangeCreateException("Sum of two sides less than last one. Triangle can't be created");
        }
    }
}
