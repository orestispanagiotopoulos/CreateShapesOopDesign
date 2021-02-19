using System;

namespace DrawingPackage.Widget
{
    public class Square : Shape
    {
        public int Side { get; private set; }
        public override string Name { get; protected set; }

        private Square(int x, int y, int side) : base(x, y)
        {
            Side = side;
            Name = typeof(Square).Name;
        }

        public override string GetWidgetDescription()
        {
            return $"{base.GetLocation()} size={Side}";
        }

        public static Square Create(int x, int y, int side)
        {
            if (side < 0)
            {
                throw new ArgumentException("The parameters can not be negative");
            }
            return new Square(x, y, side);
        }
    }
}
