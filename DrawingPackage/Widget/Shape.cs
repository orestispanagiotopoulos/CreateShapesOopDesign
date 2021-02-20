namespace DrawingPackage.Widget
{
    public abstract class Shape
    {
        public abstract string Name { get; protected set; }

        public Location Location { get; protected set; }

        public Shape(Location location)
        {
            Location = location;
        }

        public string GetLocation()
        {
            return Location.GetCoordinates();
        }

        public abstract string GetWidgetDescription();

        public abstract Shape Move(Location location);
    }
}
