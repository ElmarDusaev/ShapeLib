using ShapeLib.Shapes;

namespace ShapeLib.ShapeIdentifier
{
    internal class QuadrilateralTypeIdentifier : ICanIdentifyType<Quadrilateral>
    {
        public string Identify(Quadrilateral figure)
        {
            return string.Empty;
        }
    }
}
