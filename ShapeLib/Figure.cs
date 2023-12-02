using ShapeLib.ShapeHelpers;
using ShapeLib.ShapeIdentifier;
using ShapeLib.Shapes;

namespace ShapeLib
{
    /// <summary>
    /// Публичный класс для работы с фигурами
    /// </summary>
    public class Figure
    {
        /// <summary>
        /// Метод определения типа треугольника
        /// </summary>
        /// <param name="a">Сторона А</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        /// <returns>Тип фигуры</returns>
        public static ShapeType IdentifyTriangle(double a, double b, double c)
        {
            Triangle triangle = new Triangle { A = a, B = b, C = c };
            TriangleTypeIdentifier identifier = new TriangleTypeIdentifier();
            var helper = new TriangleHelper(triangle, identifier);
            return helper.Identify();
        }
    }
}
