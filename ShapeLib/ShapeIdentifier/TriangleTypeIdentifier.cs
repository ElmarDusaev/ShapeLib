using ShapeLib.Shapes;

namespace ShapeLib.ShapeIdentifier
{
    /// <summary>
    /// Класс для опеределения типа треугольника
    /// Треугольники бывают: остроугольные, прямоугольный, тупоугольный
    /// </summary>
    internal class TriangleTypeIdentifier : ICanIdentifyType<Triangle>
    {

        /// <summary>
        /// Метод определения типа треугольника
        /// </summary>
        /// <param name="triangle">Треугольник</param>
        /// <returns>Тип фигуры</returns>
        public ShapeType Identify(Triangle triangle)
        {
            double sumPowSideAB = Math.Pow(triangle.A, 2) + Math.Pow(triangle.B, 2);
            double powSideC = Math.Pow(triangle.C, 2);
            
            ShapeType shapeType = ShapeType.none;

            if (sumPowSideAB == powSideC)
                shapeType = ShapeType.TriangleRight;

            else if (sumPowSideAB < powSideC)
                shapeType = ShapeType.TriangleObtuse;

            else if (sumPowSideAB > powSideC)
                shapeType = ShapeType.TriangleAcute;

            return shapeType;

        }
    }
}
