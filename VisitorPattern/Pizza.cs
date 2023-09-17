using VisitorPattern.Ingredients;
using VisitorPattern.Visitors;

namespace VisitorPattern
{
    public class Pizza
    {
        private readonly List<Ingredient> ingredients = new();

        public void Add(Ingredient ingredient)
        {
            ingredients.Add(ingredient);
        }

        public void Remove(Ingredient ingredient)
        {
            ingredients.Remove(ingredient);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.Accept(visitor);
            }
        }
    }
}
