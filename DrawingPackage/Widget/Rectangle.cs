using System;

namespace DrawingPackage.Widget
{
    public class Rectangle : Shape
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public override string Name { get; protected set; }

        private Rectangle(Location location, int width, int height) : base(location)
        {
            Width = width;
            Height = height;
            Name = typeof(Rectangle).Name;
        }

        public override string GetWidgetDescription()
        {
            return $"{base.GetLocation()} width={Width} height={Height}";
        }

        public override Shape Move(Location location)
        {
            return new Rectangle(location, Width, Height);
        }

        public static Rectangle Create(Location location, int width, int height)
        {
            if(width<0 || height<0)
            {
                throw new ArgumentException("The parameters can not be negative");
            }
            return new Rectangle(location, width, height);
        }
    }
}
