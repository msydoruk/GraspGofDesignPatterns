using BuilderPattern;
using BuilderPattern.Builder;

var smallPizzaBuilder = new SmallPizzaBuilder();
smallPizzaBuilder.AddBaconIngredient();
smallPizzaBuilder.AddCheeseIngredient();
smallPizzaBuilder.AddPineapplesIngredient();
DisplayResults(smallPizzaBuilder.GetPizza());

var mediumPizzaBuilder = new MediumPizzaBuilder();
mediumPizzaBuilder.AddSeafoodIngredient();
mediumPizzaBuilder.AddCheeseIngredient();
mediumPizzaBuilder.AddPineapplesIngredient();
mediumPizzaBuilder.AddBaconIngredient();
DisplayResults(mediumPizzaBuilder.GetPizza());

var bigPizzaBuilder = new BigPizzaBuilder();
bigPizzaBuilder.AddBaconIngredient();
bigPizzaBuilder.AddCheeseIngredient();
DisplayResults(bigPizzaBuilder.GetPizza());


void DisplayResults(Pizza pizza)
{
    Console.WriteLine();
    foreach (var ingredient in pizza.GetIngredients())
    {
        Console.WriteLine($"Name: {ingredient.Type}, Amount: {ingredient.Amount}");
    }
}