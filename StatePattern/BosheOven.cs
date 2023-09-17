using StatePattern.State;

namespace StatePattern
{
    public class BosheOven : Oven
    {
        public BosheOven()
        {
            state = new ColdState(0, this);
        }

        public override void Bake()
        {
            Console.WriteLine(state.IsReadyForBaking
                ? $"The temp {state.CurrentTemp} is stably for baking. State : {state.GetType().Name}."
                : $"The temp {state.CurrentTemp} is bad for baking. State : {state.GetType().Name}.");
        }

        public override void IncreaseTemp(int temp)
        {
            state.IncreaseTemp(temp);
        }

        public override void DecreaseTemp(int temp)
        {
            state.DecreaseTemp(temp);
        }
    }
}
