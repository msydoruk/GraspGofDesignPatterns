namespace BuilderPattern.Builder
{
    public class BigPizzaBuilder : IPizzaBuilder
    {
        private readonly Pizza pizza = new();

        public void AddCheeseIngredient()
        {
            pizza.AddIngredient(new Ingredient(IngredientType.Cheese, 1000));
        }

        public void AddBaconIngredient()
        {
            pizza.AddIngredient(new Ingredient(IngredientType.Bacon, 500));
        }

        public void AddPineapplesIngredient()
        {
            pizza.AddIngredient(new Ingredient(IngredientType.Pineapples, 600));
        }

        public void AddMushroomsIngredient()
        {
            pizza.AddIngredient(new Ingredient(IngredientType.Mushrooms, 1000));
        }

        public void AddSeafoodIngredient()
        {
            pizza.AddIngredient(new Ingredient(IngredientType.Seafood, 603));
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
    }
}
