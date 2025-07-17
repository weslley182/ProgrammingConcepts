namespace StrategyPatternExample.Interfaces;

public interface IOperationStrategy
{
    int? Execute(int firstValue, int secondValue);
}