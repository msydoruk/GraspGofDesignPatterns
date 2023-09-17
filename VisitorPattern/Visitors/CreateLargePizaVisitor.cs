using VisitorPattern.Ingredients;

namespace VisitorPattern.Visitors
{
    public class CreateLargePizzaVisitor : IVisitor
    {
        public void Visit(Ingredient ingredient)
        {
            Console.WriteLine($"Mix using the formula for Large pizza: {ingredient.Type}, Amount: {ingredient.Amount}");
        }
    }
}
