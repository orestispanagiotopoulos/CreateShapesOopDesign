namespace DrawingPackage
{
    public class Location
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string GetCoordinates()
        {
            return $"({X},{Y})";
        }

        public Location Update(int x, int y)
        {
            return new Location(x, y);
        }
    }
}
