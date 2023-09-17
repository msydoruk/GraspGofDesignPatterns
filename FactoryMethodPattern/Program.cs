using FactoryMethodPattern.Implementation;

var dishName = Console.ReadLine();
var oven = new ExpertOven();
oven.Start(dishName);
oven.Stop();

