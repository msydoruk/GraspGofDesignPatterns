using CommandPattern;

var pizza = new PizzaOrder();
var waiterTouchTablet = new WaiterTouchTablet();

waiterTouchTablet.AddCommand(new AddIngredientCommand(pizza, Ingredient.Bacon));
waiterTouchTablet.AddCommand(new AddIngredientCommand(pizza, Ingredient.Mushroom));
waiterTouchTablet.AddCommand(new AddIngredientCommand(pizza, Ingredient.Sire));
waiterTouchTablet.AddCommand(new AddIngredientCommand(pizza, Ingredient.Seafood));
waiterTouchTablet.AddCommand(new AddIngredientCommand(pizza, Ingredient.Pineapple));

waiterTouchTablet.ExecuteCommands();