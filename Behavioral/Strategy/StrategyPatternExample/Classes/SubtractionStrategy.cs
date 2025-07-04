using StrategyPatternExample.Interfaces;

namespace StrategyPatternExample.Classes;
public class SubtractionStrategy : IOperationStrategy
{
    public int? Execute(int firstValue, int secondValue)
    {
        Console.WriteLine("Executing subtraction strategy.");
        return firstValue - secondValue;
    }
}
