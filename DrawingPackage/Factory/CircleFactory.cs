using DrawingPackage.Widget;

namespace DrawingPackage.Factory
{
    public class CircleFactory : IWidgetFactory
    {
        public Shape CreateWidget(WidgetParam wParam)
        {
            return Circle.Create(wParam.X.Value, wParam.Y.Value, wParam.Diameter.Value);
        }
    }
}
