using FactoryMethodPattern.Interferes;

namespace FactoryMethodPattern.Implementation
{
    public static class DishFactory
    {
        public static IDishRecipe GetDishRecipe(string name)
        {
            return name switch
            {
                "bread" => new BreadRecipe(),
                "fish" => new FishRecipe(),
                "sausage" => new SausageRecipe(),
                _ => throw new ArgumentOutOfRangeException(nameof(name), name, null)
            };
        }
    }
}
