using FactoryMethodPattern.Interferes;

namespace FactoryMethodPattern.Implementation
{
    public class ExpertOven : IOven
    {
        public IDishRecipe dishRecipe;

        public void Start(string recipeName)
        {
            dishRecipe = DishFactory.GetDishRecipe(recipeName);
        }

        public void Stop()
        {
            dishRecipe = null!;
        }
    }
}
