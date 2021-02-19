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

        public Ellipse(int x, int y, int diameterH, int diameterV) : base(x, y)
        {
            DiameterH = diameterH;
            DiameterV = diameterV;
            Name = typeof(Ellipse).Name;
        }

        public override string GetWidgetDescription()
        {
            return $"{base.GetLocation()} diameterH = {DiameterH} diameterV = {DiameterV}";
        }

        public static Ellipse Create(int x, int y, int diameterH, int diameterV)
        {
            if (diameterH < 0 || diameterV < 0)
            {
                throw new ArgumentException("The parameters can not be negative");
            }
            return new Ellipse(x, y, diameterH, diameterV);
        }
    }
}
