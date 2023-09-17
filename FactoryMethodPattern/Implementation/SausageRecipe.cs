using FactoryMethodPattern.Interferes;

namespace FactoryMethodPattern.Implementation
{
    public class SausageRecipe : IDishRecipe
    {
        public string GetRecipeParameters()
        {
            throw new NotImplementedException();
        }
    }
}
