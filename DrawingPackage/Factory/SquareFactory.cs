using DrawingPackage.Widget;

namespace DrawingPackage.Factory
{
    public class SquareFactory : IWidgetFactory
    {
        public Shape CreateWidget(WidgetParam wParam)
        {
            return Square.Create(wParam.X.Value, wParam.Y.Value, wParam.Side.Value);
        }
    }
}
