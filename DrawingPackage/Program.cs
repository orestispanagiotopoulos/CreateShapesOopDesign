using DrawingPackage.Decorator;
using DrawingPackage.Enumeration;
using DrawingPackage.Factory;
using DrawingPackage.Widget;
using System;
using System.Collections.Generic;

namespace DrawingPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hard-coded set of widget parameters 
            var widgetParams = new List<WidgetParam>()
            {
                new WidgetParam() {WidgetType = WidgetType.Rectangle, X = 10, Y = 10, Width = 30, Height = 40 },
                new WidgetParam() {WidgetType = WidgetType.Square, X = 15, Y = 30, Side = 35 },
                new WidgetParam() {WidgetType = WidgetType.Ellipse, X = 100, Y = 150, DiameterH = 300, DiameterV = 200 },
                new WidgetParam() {WidgetType = WidgetType.Circle, X = 1, Y = 1, Diameter = 300 },
                new WidgetParam() {WidgetType = WidgetType.Textbox, X = 5, Y = 5, Width = 200, Height = 100, Text = "sample text" },
            };

            var widgets = CreateWidgets(widgetParams);

            PrintWidgets(widgets);

            Console.ReadKey();
        }

        private static List<Shape> CreateWidgets(List<WidgetParam> widgetParams)
        {
            var widgets = new List<Shape>();
            var factoryProvider = new WidgetProviderFactory();

            foreach (var wParam in widgetParams)
            {
                // Create appropriate factory for each widget
                IWidgetFactory widgetFactory = factoryProvider.CreateFactoryFor(wParam.WidgetType);

                // Create widget
                var shape = widgetFactory.CreateWidget(wParam);

                // Add to the list
                widgets.Add(shape);
            }
            return widgets;
        }

        private static void PrintWidgets(List<Shape> widgets)
        {
            foreach (var widget in widgets)
            {
                Console.WriteLine($"{widget.Name} {widget.GetWidgetDescription()}");
            }
        }
    }
}
