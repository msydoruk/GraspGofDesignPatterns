using VisitorPattern.Ingredients;

namespace VisitorPattern.Visitors
{
    public class CreateMediumPizzaVisitor : IVisitor
    {
        public void Visit(Ingredient ingredient)
        {
            Console.WriteLine($"Mix using the formula for Medium pizza: {ingredient.Type}, Amount: {ingredient.Amount} * 3");
        }
    }
}
