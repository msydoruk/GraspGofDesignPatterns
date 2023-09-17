using BridgePattern.BusinessLogic;

namespace BridgePattern.Abstraction
{
    public abstract class Dish
    {
        public ICooker Cooker { set; get; }

        protected abstract void StartDish(string name);
    }
}
