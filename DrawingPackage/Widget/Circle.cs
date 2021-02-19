using System;

namespace DrawingPackage.Widget
{
    public class Circle : Shape
    {
        public int Diameter { get; private set; }
        public override string Name { get; protected set; }

        private Circle(int x, int y, int diameter) : base(x, y)
        {
            Diameter = diameter;
            Name = typeof(Circle).Name;
        }

        public override string GetWidgetDescription()
        {
            return $"{base.GetLocation()} size={Diameter}";
        }

        public static Circle Create(int x, int y, int diameter)
        {
            if (diameter < 0)
            {
                throw new ArgumentException("The parameters can not be negative");
            }
            return new Circle(x, y, diameter);
        }
    }
}
