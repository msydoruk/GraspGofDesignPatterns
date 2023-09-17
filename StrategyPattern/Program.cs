using StrategyPattern;
using StrategyPattern.Strategy;

Assets assets = new Assets(new BubbleSortAlgorithm());

assets.AddUpc(30);
assets.AddUpc(10);
assets.AddUpc(5);
assets.AddUpc(50);
assets.AddUpc(45);

assets.Sort();
assets.PrintAllPasses();

assets.SetSortAlgorithm(new QuickSortAlgorithm());
assets.Sort();
assets.PrintAllPasses();