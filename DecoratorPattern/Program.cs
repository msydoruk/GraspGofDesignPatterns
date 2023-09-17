using DecoratorPattern;
using DecoratorPattern.Decorator;


var pizza = new MushroomDecorator(new CheeseDecorator(new BaconDecorator(new Pizza())));
Console.WriteLine(pizza.GetIngredients());

var pizza2 = new BaconDecorator(new SeafoodDecorator(new PineappleDecorator(new Pizza())));
Console.WriteLine(pizza2.GetIngredients());

var pizza3 = new MushroomDecorator(new Pizza());
Console.WriteLine(pizza3.GetIngredients());