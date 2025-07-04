using StrategyPatternExample.Interfaces;

namespace StrategyPatternExample.Classes;
public class DivisionStrategy : IOperationStrategy
{
    public int? Execute(int value, int divider)
    {
        Console.WriteLine("Executing division strategy.");

        if (divider == 0)
        {

            Console.WriteLine("Cannot divide by zero.");
            return null;
        }
        return value * divider;
    }
}

