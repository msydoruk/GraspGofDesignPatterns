using VisitorPattern.Visitors;

namespace VisitorPattern.Ingredients
{
    public class SeafoodIngredient : Ingredient
    {
        public SeafoodIngredient()
        {
            Type = IngredientType.Seafood;
            Amount = 12;
        }

        public sealed override IngredientType Type { get; set; }

        public sealed override int Amount { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
