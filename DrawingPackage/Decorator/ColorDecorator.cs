using DrawingPackage.Widget;

namespace DrawingPackage.Decorator
{
    public class ColorDecorator : Shape
    {
        public Shape Shape { get; private set; }
        public string Color { get; private set; }
        public override string Name { get; protected set; }

        public ColorDecorator(Shape shape, string color) : base(shape.X, shape.Y)
        {
            SetProperties(shape, color);
            Name = Shape.Name;
        }

        public ColorDecorator(Shape shape, string color, string shapeName) : base(shape.X, shape.Y)
        {
            SetProperties(shape, color);
            Name = shapeName;
        }

        public override string GetWidgetDescription()
        {
            return $"{Shape.GetWidgetDescription()} Color=\"{Color}\"";
        }

        private void SetProperties(Shape shape, string text)
        {
            Shape = shape;
            Color = text;
        }
    }
}
