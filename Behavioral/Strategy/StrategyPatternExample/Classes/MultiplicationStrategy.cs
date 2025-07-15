using StrategyPatternExample.Interfaces;

namespace StrategyPatternExample.Classes;
public class MultiplicationStrategy : IOperationStrategy
{
    public int? Execute(int value, int multiplier)
    {
        Console.WriteLine("Executing multiplication strategy.");
        return value * multiplier;
    }
}
