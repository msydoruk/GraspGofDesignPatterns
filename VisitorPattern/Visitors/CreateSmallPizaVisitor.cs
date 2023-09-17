using VisitorPattern.Ingredients;

namespace VisitorPattern.Visitors
{
    public class CreateSmallPizzaVisitor : IVisitor
    {
        public void Visit(Ingredient ingredient)
        {
            Console.WriteLine($"Mix using the formula for Small pizza: {ingredient.Type}, Amount: {ingredient.Amount} * 2");
        }
    }
}
