using StrategyPatternExample.Interfaces;

namespace StrategyPatternExample.Service;
public class Calculator
{
    private IOperationStrategy _strategy;

    public Calculator(IOperationStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IOperationStrategy strategy)
    {
        _strategy = strategy;
    }

    public int? Compute(int firstValue, int secondValue)
    {
        return _strategy.Execute(firstValue, secondValue);
    }
}

