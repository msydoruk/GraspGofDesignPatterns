namespace BridgePattern.Abstraction
{
    public class SecondDish : Dish
    {
        protected override void StartDish(string nameDish)
        {
            Cooker.CookDish(nameDish);
        }
    }
}
