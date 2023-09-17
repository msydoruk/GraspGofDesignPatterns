namespace BridgePattern.Abstraction
{
    public class FirstDish : Dish
    {
        protected override void StartDish(string nameDish)
        {
           Cooker.CookDish(nameDish);
        }
    }
}
