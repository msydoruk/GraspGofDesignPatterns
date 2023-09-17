using VisitorPattern.Visitors;

namespace VisitorPattern.Ingredients
{
    public class CheeseIngredient : Ingredient
    {
        public CheeseIngredient()
        {
            Type = IngredientType.Cheese;
            Amount = 9;
        }

        public sealed override IngredientType Type { get; set; }

        public sealed override int Amount { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
