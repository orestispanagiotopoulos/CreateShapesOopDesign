using DrawingPackage.Widget;

namespace DrawingPackage.Decorator
{
    public class TextDecorator : Shape
    {
        public Shape Shape { get; private set; }
        public string Text { get; private set; }
        public override string Name { get; protected set; }

        public TextDecorator(Shape shape, string text) : base(shape.X, shape.Y)
        {
            SetProperties(shape, text);
            Name = Shape.Name;
        }

        public TextDecorator(Shape shape, string text, string shapeName) : base(shape.X, shape.Y)
        {
            SetProperties(shape, text);
            Name = shapeName;
        }

        public override string GetWidgetDescription()
        {
            return $"{Shape.GetWidgetDescription()} Text=\"{Text}\"";
        }

        private void SetProperties(Shape shape, string text)
        {
            Shape = shape;
            Text = text;
        }
    }
}
