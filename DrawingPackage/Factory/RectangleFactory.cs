﻿using DrawingPackage.Widget;

namespace DrawingPackage.Factory
{
    public class RectangleFactory : IWidgetFactory
    {
        public Shape CreateWidget(WidgetParam wParam)
        {
            return Rectangle.Create(wParam.X.Value, wParam.Y.Value, wParam.Width.Value, wParam.Height.Value);
        }
    }
}
