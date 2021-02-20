using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingPackage.Widget
{
    public class Ellipse : Shape
    {
        public int DiameterH { get; private set; }
        public int DiameterV { get; private set; }

        public override string Name { get; protected set; }

        public Ellipse(Location location, int diameterH, int diameterV) : base(location)
        {
            DiameterH = diameterH;
            DiameterV = diameterV;
            Name = typeof(Ellipse).Name;
        }

        public override string GetWidgetDescription()
        {
            return $"{base.GetLocation()} diameterH = {DiameterH} diameterV = {DiameterV}";
        }

        public override Shape Move(Location location)
        {
            return new Ellipse(location, DiameterH, DiameterV);
        }

        public static Ellipse Create(Location location, int diameterH, int diameterV)
        {
            if (diameterH < 0 || diameterV < 0)
            {
                throw new ArgumentException("The parameters can not be negative");
            }
            return new Ellipse(location, diameterH, diameterV);
        }
    }
}
