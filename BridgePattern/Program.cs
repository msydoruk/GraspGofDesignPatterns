using BridgePattern.Abstraction;
using BridgePattern.BusinessLogic;

Dish chiniseDish= new FirstDish { Cooker = new ChiniseCooker() };
chiniseDish = new SecondDish { Cooker = new ChiniseCooker() };
chiniseDish = new ThirdDish { Cooker = new ChiniseCooker() };
chiniseDish = new DessertDish { Cooker = new ChiniseCooker() };

Dish italianDish = new FirstDish { Cooker = new ItalianCooker() };
italianDish = new SecondDish { Cooker = new ItalianCooker() };
italianDish = new ThirdDish { Cooker = new ItalianCooker() };
italianDish = new DessertDish { Cooker = new ItalianCooker() };

Dish ukrainianDish = new FirstDish { Cooker = new UkrainianCooker() };
ukrainianDish = new SecondDish { Cooker = new UkrainianCooker() };
ukrainianDish = new ThirdDish { Cooker = new UkrainianCooker() };
ukrainianDish = new DessertDish { Cooker = new ChiniseCooker() };