namespace StatePattern.State
{
    public class ReadyState : OvenState
    {
        public ReadyState(OvenState state) : this(state.CurrentTemp, state.oven)
        {
        }

        public ReadyState(int currentTemp, Oven oven)
        {
            lowerTemp = 30;
            upperTemp = 69;
            IsReadyForBaking = true;
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
                oven.state = new ColdState(this);
            else if (CurrentTemp > upperTemp)
                oven.state = new SuperHeatedState(this);
        }
    }
}
