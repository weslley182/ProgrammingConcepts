using StrategyPatternShippingCost.Interfaces;

namespace StrategyPatternShippingCost.Service;
public class ShippingService
{
    private IShippingStrategy _strategy;

    public void SetStrategy(IShippingStrategy strategy)
    {
        _strategy = strategy;
    }

    public decimal GetShippingCost(decimal orderValue)
    {
        return _strategy.CalculateShippingCost(orderValue);
    }
}

