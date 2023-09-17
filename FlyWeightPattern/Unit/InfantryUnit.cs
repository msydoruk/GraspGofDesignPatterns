using FlyWeightPattern.Base;

namespace FlyWeightPattern.Unit
{
    public class InfantryUnit : UnitBase
    {
        public static SharedUnitInformation SharedInformation { get; set; }

        public InfantryUnit(double x, double y) : base(x, y)
        {
        }

        public override string GetUnitInformation()
        {
            return
                $"Infantry - Texture: {SharedInformation.Texture}," +
                $"Sound: {SharedInformation.Sound}," +
                $"X: {coordinate.X}," +
                $"Y: {coordinate.Y}";
        }
    }
}
