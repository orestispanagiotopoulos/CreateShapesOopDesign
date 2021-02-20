using DrawingPackage.Widget;

namespace DrawingPackage.Decorator
{
    public class TextDecorator : Shape
    {
        public Shape Shape { get; private set; }
        public string Text { get; private set; }
        public override string Name { get; protected set; }

        public TextDecorator(Shape shape, string text, string shapeName = null) : base(shape.Location)
        {
            Shape = shape;
            Text = text;
            Name = shapeName ?? Shape.Name;
        }

        public override Shape Move(Location location)
        {
            return new TextDecorator(Shape.Move(location), Text, Name);
        }

        public override string GetWidgetDescription()
        {
            return $"{Shape.GetWidgetDescription()} Text=\"{Text}\"";
        }
    }
}
