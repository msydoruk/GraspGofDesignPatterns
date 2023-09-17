using VisitorPattern;
using VisitorPattern.Ingredients;
using VisitorPattern.Visitors;

Pizza pizza = new Pizza();

pizza.Add(new CheeseIngredient());
pizza.Add(new BaconIngredient());
pizza.Add(new PineappleIngredient());

IVisitor createSmallPizzaVisitor = new CreateSmallPizzaVisitor();
pizza.Accept(createSmallPizzaVisitor);

IVisitor createMediumPizzaVisitor = new CreateMediumPizzaVisitor();
pizza.Accept(createMediumPizzaVisitor);