namespace ShapeLib.ShapeIdentifier
{
    /// <summary>
    /// Интерфейс для определения типа фигуры
    /// </summary>
    /// <typeparam name="TShape"></typeparam>
    internal interface ICanIdentifyType<TShape>
    {
        ShapeType Identify(TShape figure);
    }
}
