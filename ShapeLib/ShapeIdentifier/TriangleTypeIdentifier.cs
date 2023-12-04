using ShapeLib.Shapes;

namespace ShapeLib.ShapeIdentifier
{
    /// <summary>
    /// Класс для опеределения типа треугольника
    /// Треугольники бывают: остроугольный, прямоугольный, тупоугольный
    /// </summary>
    internal class TriangleTypeIdentifier : ICanIdentifyType<Triangle>
    {

        /// <summary>
        /// Метод определения типа треугольника
        /// </summary>
        /// <param name="triangle">Треугольник</param>
        /// <returns>Тип фигуры</returns>
        public string Identify(Triangle triangle)
        {
            double sumPowSideAB = Math.Pow(triangle.A, 2) + Math.Pow(triangle.B, 2);
            double powSideC = Math.Pow(triangle.C, 2);
            
            string shapeType = string.Empty;

            //прямоугольный
            if (sumPowSideAB == powSideC)
                shapeType = TriangleType.RIGHT_TRIANGLE;
            //тупоугольный
            else if (sumPowSideAB < powSideC)
                shapeType = TriangleType.OBTUSE_TRIANGLE;
            //остроугольные
            else if (sumPowSideAB > powSideC)
                shapeType = TriangleType.ACUTE_TRIANGLE;

            return shapeType;

        }
    }
}
