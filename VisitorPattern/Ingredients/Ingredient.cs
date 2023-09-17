using VisitorPattern.Visitors;

namespace VisitorPattern.Ingredients
{
    public abstract class Ingredient
    {
        public abstract IngredientType Type { get; set; }

        public abstract int Amount { get; set; }

        public abstract void Accept(IVisitor visitor);
    }
}
