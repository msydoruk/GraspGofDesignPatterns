using FacadePattern;

ICalculator calculator = new Calculator();

var addResult = calculator.Add(10, 5);
Console.WriteLine(addResult);

var divideResult = calculator.Divide(10, 5);
Console.WriteLine(divideResult);

var multiplyResult = calculator.Multiply(10, 5);
Console.WriteLine(multiplyResult);

var subtractResult = calculator.Subtract(10, 5);
Console.WriteLine(subtractResult);