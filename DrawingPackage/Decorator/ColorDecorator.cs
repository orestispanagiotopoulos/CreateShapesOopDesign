using DrawingPackage.Widget;

namespace DrawingPackage.Decorator
{
    public class ColorDecorator : Shape
    {
        public Shape Shape { get; private set; }
        public string Color { get; private set; }
        public override string Name { get; protected set; }

        public ColorDecorator(Shape shape, string color, string shapeName = null) : base(shape.Location)
        {
            Shape = shape;
            Color = color;
            Name = shapeName ?? Shape.Name;
        }

        public override Shape Move(Location location)
        {
            return new ColorDecorator(Shape.Move(location), Color, Name);
        }

        public override string GetWidgetDescription()
        {
            return $"{Shape.GetWidgetDescription()} Color=\"{Color}\"";
        }
    }
}
