namespace FlyWeightPattern.Base
{
    public abstract class UnitBase
    {
        protected readonly Coordinate coordinate;

        protected UnitBase(double x, double y)
        {
            this.coordinate = new Coordinate(x, y);
        }

        public void MoveUnit(double x, double y)
        {
            this.coordinate.X = x;
            this.coordinate.Y = y;
        }

        public abstract string GetUnitInformation();
    }
}
