using ShapeLib.ShapeIdentifier;
using ShapeLib.Shapes;

namespace ShapeLib.ShapeHelpers
{
    internal class QuadrilateralHelper : BaseHelper<Quadrilateral>
    {
        public QuadrilateralHelper(Quadrilateral shape, ICanIdentifyType<Quadrilateral> typeIdentifier) : base(shape, typeIdentifier)
        {

        }
    }
}
