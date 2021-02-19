using DrawingPackage.Widget;

namespace DrawingPackage.Factory
{
    public interface IWidgetFactory
    {
        Shape CreateWidget(WidgetParam wParam);
    }
}
