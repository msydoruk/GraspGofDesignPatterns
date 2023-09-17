
using GofDesignPatterns.Tasks.AbstractFactoryPattern.KitchenTypeFactory;

var kitchenType = Console.ReadLine();
var kitchenTypeFactory = KitchenTypeFactory.GetKitchenType(kitchenType);
kitchenTypeFactory?.CreateSalad();
kitchenTypeFactory?.CreateSoup();
kitchenTypeFactory?.CreateSecondCourse();
kitchenTypeFactory?.CreateDrink();
