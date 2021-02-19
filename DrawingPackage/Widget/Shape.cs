namespace DrawingPackage.Widget
{
    public abstract class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public abstract string Name { get; protected set; }

        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string GetLocation()
        {
            return $"({X},{Y})";
        }

        public abstract string GetWidgetDescription();
    }
}
