using DrawingPackage.Decorator;
using DrawingPackage.Widget;

namespace DrawingPackage.Factory
{
    public class TextboxFactory : IWidgetFactory
    {
        public Shape CreateWidget(WidgetParam wParam)
        {
            return new TextDecorator(
                Rectangle.Create(new Location(wParam.X.Value, wParam.Y.Value), wParam.Width.Value, wParam.Height.Value), 
                    wParam.Text, wParam.WidgetType.ToString());
        }
    }
}
