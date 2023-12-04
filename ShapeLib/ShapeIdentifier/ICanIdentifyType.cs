namespace ShapeLib.ShapeIdentifier
{
    /// <summary>
    /// Интерфейс для определения типа фигуры
    /// </summary>
    /// <typeparam name="TShape"></typeparam>
    internal interface ICanIdentifyType<TShape>
    {
        string Identify(TShape figure);
    }
}
