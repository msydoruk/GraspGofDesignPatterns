namespace StatePattern
{
    public abstract class Oven
    {
        public OvenState state;

        public abstract void Bake();

        public abstract void IncreaseTemp(int temp);

        public abstract void DecreaseTemp(int temp);
    }
}
