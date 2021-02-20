using System;

namespace DrawingPackage.Widget
{
    public class Square : Shape
    {
        public int Side { get; private set; }
        public override string Name { get; protected set; }

        private Square(Location location, int side) : base(location)
        {
            Side = side;
            Name = typeof(Square).Name;
        }

        public override string GetWidgetDescription()
        {
            return $"{base.GetLocation()} size={Side}";
        }

        public override Shape Move(Location location)
        {
            return new Square(location, Side);
        }

        public static Square Create(Location location, int side)
        {
            if (side < 0)
            {
                throw new ArgumentException("The parameters can not be negative");
            }
            return new Square(location, side);
        }
    }
}
