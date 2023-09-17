namespace BuilderPattern.Builder
{
    public class MediumPizzaBuilder : IPizzaBuilder
    {
        private readonly Pizza pizza = new();

        public void AddCheeseIngredient()
        {
            pizza.AddIngredient(new Ingredient(IngredientType.Cheese, 100));
        }

        public void AddBaconIngredient()
        {
            pizza.AddIngredient(new Ingredient(IngredientType.Bacon, 50));
        }

        public void AddPineapplesIngredient()
        {
            pizza.AddIngredient(new Ingredient(IngredientType.Pineapples, 60));
        }

        public void AddMushroomsIngredient()
        {
            pizza.AddIngredient(new Ingredient(IngredientType.Mushrooms, 100));
        }

        public void AddSeafoodIngredient()
        {
            pizza.AddIngredient(new Ingredient(IngredientType.Seafood, 63));
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
    }
}
