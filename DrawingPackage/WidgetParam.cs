using DrawingPackage.Enumeration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingPackage
{
    public class WidgetParam
    {
        public WidgetType WidgetType;
        public int? X { get; set; } // position
        public int? Y { get; set; } // position
        public int? Width { get; set; }
        public int? Height { get; set; }
        public int? Side { get; set; }
        public int? DiameterH { get; set; }
        public int? DiameterV { get; set; }
        public int? Diameter { get; set; }
        public string Text { get; set; }
    }
}
