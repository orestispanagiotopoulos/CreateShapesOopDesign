﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingPackage.Widget
{
    public class Rectangle : Shape
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public override string Name { get; protected set; }

        private Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
            Name = typeof(Rectangle).Name;
        }

        public override string GetWidgetDescription()
        {
            return $"{base.GetLocation()} width={Width} height={Height}";
        }

        public static Rectangle Create(int x, int y, int width, int height)
        {
            if(width<0 || height<0)
            {
                throw new ArgumentException("The parameters can not be negative");
            }
            return new Rectangle(x, y, width, height);
        }
    }
}
