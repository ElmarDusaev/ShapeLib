using ShapeLib.ShapeIdentifier;
using ShapeLib.Shapes;

namespace ShapeLib.ShapeHelpers
{
    /// <summary>
    /// Класс для работы с треугольником
    /// </summary>
    internal class TriangleHelper : BaseHelper<Triangle>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="shape">Фигура</param>
        /// <param name="typeIdentifier">Обработчик</param>
        public TriangleHelper(Triangle shape, ICanIdentifyType<Triangle> typeIdentifier) : base(shape, typeIdentifier)
        {
            SetSides();
            CheckTriangle();
        }


        /// <summary>
        /// Меняем местами значения параметров согласно правилу c > a > b;
        /// </summary>
        private void SetSides()
        {
            if (Shape.A > Shape.C && Shape.A > Shape.B)
            {
                double temp = Shape.A;
                Shape.A = Shape.C;
                Shape.C = temp;
            }
            else if (Shape.B > Shape.C && Shape.B > Shape.A)
            {
                double temp = Shape.B;
                Shape.B = Shape.C;
                Shape.C = temp;
            }

            if (Shape.A < Shape.B)
            {
                double temp = Shape.A;
                Shape.A = Shape.B;
                Shape.B = temp;
            }
        }

        /// <summary>
        /// Проверка сторон треугольника
        /// </summary>
        /// <exception cref="ArgumentException">Incorrect parameters</exception>
        /// <exception cref="ArithmeticException">Incorrect parameters, data overflow</exception>
        private void CheckTriangle()
        {
            // Проверка на неправильные значения
            if (Shape.A <= 0 || Shape.B <= 0 || Shape.C <= 0)
                throw new ArgumentException("One of the parameters is 0 or less");

            // Проверка сторон треугольника, должны выполняться условия: с < a + b, c > a - b (где c > а > b)
            if (Shape.C > Shape.A + Shape.B || Shape.C < Shape.A - Shape.B)
                throw new ArgumentException("Incorrect parameters for triangle");

            // Проверка на переполнения
            if(
                double.IsInfinity(Math.Pow(Shape.A, 2)) ||
                double.IsInfinity(Math.Pow(Shape.B, 2)) ||
                double.IsInfinity(Math.Pow(Shape.C, 2)) ||
                double.IsInfinity(Math.Pow(Shape.A, 2) + Math.Pow(Shape.B, 2))
                )
                throw new ArithmeticException("Incorrect parameters, data overflow");
        }


    }
}
