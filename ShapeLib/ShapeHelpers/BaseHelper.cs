using ShapeLib.ShapeIdentifier;

namespace ShapeLib.ShapeHelpers
{
    /// <summary>
    /// Абстрактный класс для работы с фигурой
    /// </summary>
    /// <typeparam name="TShape">Фигура</typeparam>
    abstract class BaseHelper<TShape>
    {
        /// <summary>
        /// Фигура
        /// </summary>
        protected TShape Shape;
        protected ICanIdentifyType<TShape> TypeIdentifier { get; set; }

        /// <summary>
        /// Конструктор, принимает фигуру и обработчик для определения типа фигуры
        /// </summary>
        /// <param name="shape">Фигура</param>
        /// <param name="typeIdentifier">Обработчик для определения типа фигуры</param>
        public BaseHelper(TShape shape, ICanIdentifyType<TShape> typeIdentifier)
        {
            Shape = shape;
            TypeIdentifier = typeIdentifier;
        }

        /// <summary>
        /// Метод определения типа фигуры
        /// </summary>
        /// <returns>Тип фигуры</returns>
        public virtual ShapeType Identify()
        {
            return TypeIdentifier.Identify(Shape);
        }
    }
}
