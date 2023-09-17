using FacadePattern;
using ProxyPattern;

ICalculator calculator = new CachedCalculator(new Calculator());

var addResult1 = calculator.Add(10, 5);
Console.WriteLine(addResult1);

var addResult2 = calculator.Add(10, 5);
Console.WriteLine(addResult2);

var addResult3 = calculator.Add(11, 5);
Console.WriteLine(addResult3);

var addResult4 = calculator.Add(11, 5);
Console.WriteLine(addResult4);