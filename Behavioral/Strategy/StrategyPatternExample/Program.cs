using StrategyPatternExample.Classes;
using StrategyPatternExample.Service;

var calculator = new Calculator(new AdditionStrategy());
Console.WriteLine(calculator.Compute(5, 3)); // 8

calculator.SetStrategy(new SubtractionStrategy());
Console.WriteLine(calculator.Compute(5, 3)); // 2

calculator.SetStrategy(new MultiplicationStrategy());
Console.WriteLine(calculator.Compute(5, 3)); // 15

calculator.SetStrategy(new DivisionStrategy());
Console.WriteLine(calculator.Compute(15, 3)); // 5

calculator.SetStrategy(new DivisionStrategy());
Console.WriteLine(calculator.Compute(15, 0)); // Throww
