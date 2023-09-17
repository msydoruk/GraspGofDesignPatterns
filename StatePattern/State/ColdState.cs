namespace StatePattern.State
{
    public class ColdState : OvenState
    {
        public ColdState(OvenState state) : this(state.CurrentTemp, state.oven)
        {
        }

        public ColdState(int currentTemp, Oven oven)
        {
            lowerTemp = 0;
            upperTemp = 29;
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
            if (CurrentTemp > upperTemp)
                oven.state = new ReadyState(this);
        }
    }
}
