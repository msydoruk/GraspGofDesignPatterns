using VisitorPattern.Visitors;

namespace VisitorPattern.Ingredients
{
    public class BaconIngredient : Ingredient
    {
        public BaconIngredient()
        {
            Type = IngredientType.Bacon;
            Amount = 14;
        }

        public sealed override IngredientType Type { get; set; }

        public sealed override int Amount { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
