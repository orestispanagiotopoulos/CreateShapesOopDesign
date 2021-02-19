using DrawingPackage.Widget;

namespace DrawingPackage.Factory
{
    public class EllipseFactory : IWidgetFactory
    {
        public Shape CreateWidget(WidgetParam wParam)
        {
            return Ellipse.Create(wParam.X.Value, wParam.Y.Value, wParam.DiameterH.Value, wParam.DiameterV.Value);
        }
    }
}
