using System;

namespace DrawingPackage.Widget
{
    public class Circle : Shape
    {
        public int Diameter { get; private set; }
        public override string Name { get; protected set; }

        private Circle(Location location, int diameter) : base(location)
        {
            Diameter = diameter;
            Name = typeof(Circle).Name;
        }

        public override string GetWidgetDescription()
        {
            return $"{base.GetLocation()} size={Diameter}";
        }

        public override Shape Move(Location location)
        {
            return new Circle(location, Diameter);
        }

        public static Circle Create(Location location, int diameter)
        {
            if (diameter < 0)
            {
                throw new ArgumentException("The parameters can not be negative");
            }
            return new Circle(location, diameter);
        }
    }
}
