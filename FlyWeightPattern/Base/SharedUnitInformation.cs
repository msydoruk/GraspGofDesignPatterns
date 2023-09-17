namespace FlyWeightPattern.Base
{
    public class SharedUnitInformation
    {
        public SharedUnitInformation(int texture, int sound)
        {
            Texture = texture;
            Sound = sound;
        }

        public int Texture { get; set; }
        public int Sound { get; set; }
    }
}
