using VisitorPattern.Visitors;

namespace VisitorPattern.Ingredients
{
    public class MushroomIngredient : Ingredient
    {
        public MushroomIngredient()
        {
            Type = IngredientType.Mushroom;
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
