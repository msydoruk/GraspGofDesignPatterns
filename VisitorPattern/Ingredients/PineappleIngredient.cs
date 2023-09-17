using VisitorPattern.Visitors;

namespace VisitorPattern.Ingredients
{
    public class PineappleIngredient : Ingredient
    {
        public PineappleIngredient()
        {
            Type = IngredientType.Pineapple;
            Amount = 16;
        }

        public sealed override IngredientType Type { get; set; }

        public sealed override int Amount { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
