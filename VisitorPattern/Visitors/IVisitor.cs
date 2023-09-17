using VisitorPattern.Ingredients;

namespace VisitorPattern.Visitors
{
    public interface IVisitor
    {
        void Visit(Ingredient ingredient);
    }
}
