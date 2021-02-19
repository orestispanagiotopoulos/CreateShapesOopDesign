using DrawingPackage.Enumeration;
using DrawingPackage.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DrawingPackage
{
    public class WidgetProviderFactory
    {
        private IEnumerable<Type> factories;

        public WidgetProviderFactory()
        {
            factories = Assembly.GetAssembly(typeof(WidgetProviderFactory))
                .GetTypes()
                .Where(t => typeof(IWidgetFactory)
                .IsAssignableFrom(t));
        }

        public IWidgetFactory CreateFactoryFor(WidgetType wType)
        {
            var fctoryName = $"{wType.ToString()}Factory";

            Type factory = factories
                .Single(x => x.Name.ToLowerInvariant()
                .Contains(fctoryName.ToLowerInvariant()));

            IWidgetFactory instance =
                (IWidgetFactory)Activator
                .CreateInstance(factory);

            return instance;
        }
    }
}
