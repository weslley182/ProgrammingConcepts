using StrategyPatternExample.Interfaces;

namespace StrategyPatternExample.Classes;
public class AdditionStrategy : IOperationStrategy
{
    public int? Execute(int firstValue, int secondValue)
    {
        Console.WriteLine("Executing addition strategy.");
        return firstValue + secondValue;
    }
}
