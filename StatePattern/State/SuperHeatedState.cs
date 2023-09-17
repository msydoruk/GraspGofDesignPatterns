namespace StatePattern.State
{
    public class SuperHeatedState : OvenState
    {
        public SuperHeatedState(OvenState state) : this(state.CurrentTemp, state.oven)
        {
        }

        public SuperHeatedState(int currentTemp, Oven oven)
        {
            lowerTemp = 70;
            upperTemp = 100;
            IsReadyForBaking = false;
            CurrentTemp = currentTemp;
            this.oven = oven;
        }

        public override void IncreaseTemp(int temp)
        {
            CurrentTemp += temp;
            CheckTemp();
        }

        public override void DecreaseTemp(int temp)
        {
            CurrentTemp -= temp;
            CheckTemp();
        }

        protected override void CheckTemp()
        {
            if (CurrentTemp < lowerTemp)
                oven.state = new ReadyState(this);
        }
    }
}
