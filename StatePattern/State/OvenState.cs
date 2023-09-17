namespace StatePattern
{
    public abstract class OvenState
    {
        public int lowerTemp;

        public int upperTemp;

        public Oven oven;

        public int CurrentTemp { get; set; }

        public bool IsReadyForBaking { get; set; }

        public abstract void IncreaseTemp(int temp);

        public abstract void DecreaseTemp(int temp);

        protected abstract void CheckTemp();
    }
}
