namespace BridgePattern.Abstraction
{
    public class ThirdDish : Dish
    {
        protected override void StartDish(string nameDish)
        {
            Cooker.CookDish(nameDish);
        }
    }
}
