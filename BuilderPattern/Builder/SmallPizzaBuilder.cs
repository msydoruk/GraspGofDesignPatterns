namespace BuilderPattern.Builder
{
    public class SmallPizzaBuilder : IPizzaBuilder
    {
        private readonly Pizza pizza = new();

        public void AddCheeseIngredient()
        {
            pizza.AddIngredient(new Ingredient(IngredientType.Cheese, 10));
        }

        public void AddBaconIngredient()
        {
            pizza.AddIngredient(new Ingredient(IngredientType.Bacon, 5));
        }

        public void AddPineapplesIngredient()
        {
            pizza.AddIngredient(new Ingredient(IngredientType.Pineapples, 6));
        }

        public void AddMushroomsIngredient()
        {
            pizza.AddIngredient(new Ingredient(IngredientType.Mushrooms, 10));
        }

        public void AddSeafoodIngredient()
        {
            pizza.AddIngredient(new Ingredient(IngredientType.Seafood, 45));
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
    }
}
