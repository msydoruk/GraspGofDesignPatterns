namespace BridgePattern.Abstraction
{
    public class DessertDish : Dish
    {
        protected override void StartDish(string nameDish)
        {
            Cooker.CookDish(nameDish);
        }
    }
}
