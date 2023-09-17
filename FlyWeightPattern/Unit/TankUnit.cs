using FlyWeightPattern.Base;

namespace FlyWeightPattern.Unit
{
    public class TankUnit : UnitBase
    {
        public static SharedUnitInformation SharedInformation { get; set; }

        public TankUnit(double x, double y) : base(x, y)
        {
        }

        public override string GetUnitInformation()
        {
            return
                $"Tank - Texture: {SharedInformation.Texture}," +
                $"Sound: {SharedInformation.Sound}," +
                $"X: {coordinate.X}," +
                $"Y: {coordinate.Y}";
        }
    }
}
