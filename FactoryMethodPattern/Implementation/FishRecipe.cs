using FactoryMethodPattern.Interferes;

namespace FactoryMethodPattern.Implementation
{
    public class FishRecipe : IDishRecipe
    {
        public string GetRecipeParameters()
        {
            throw new NotImplementedException();
        }
    }
}
