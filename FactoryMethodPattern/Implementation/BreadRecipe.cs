using FactoryMethodPattern.Interferes;

namespace FactoryMethodPattern.Implementation
{
    public class BreadRecipe : IDishRecipe
    {
        public string GetRecipeParameters()
        {
            throw new NotImplementedException();
        }
    }
}
