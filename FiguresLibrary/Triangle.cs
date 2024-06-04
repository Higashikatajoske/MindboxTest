using FiguresLibrary.Exceptions;

namespace FiguresLibrary
{
    public class Triangle : Figure
    {
        private readonly int sideA;
        private readonly int sideB;
        private readonly int sideC;

        /// <summary>
        /// Создаёт треугольник по трём сторонам
        /// </summary>
        /// <param name="a">Сторона А</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона С</param>
        public Triangle(int a, int b, int c)
        {
            ValidateSides(a, b, c);
            sideA = a;
            sideB = b;
            sideC = c;
        }

        /// <summary>
        /// Нахождение площади треугольника по трём сторонам
        /// </summary>
        /// <returns>Возвращает площадь с округлением до 4 чисел после запятой</returns>
        public override double GetArea()
        {
            double semiPerimeter = (double)(sideA + sideB + sideC) / 2;
            double x = semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC);
            double area = Math.Sqrt(x);
            return Math.Round(area, 4);
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

        private void ValidateSides(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0) 
                throw new TriangeCreateException("One side or several have negative value. Triangle can't be created.");

            if (a + b <= c || b + c <= a || a + c <= b)
                throw new TriangeCreateException("Sum of two sides less than last one. Triangle can't be created");
        }
    }
}
