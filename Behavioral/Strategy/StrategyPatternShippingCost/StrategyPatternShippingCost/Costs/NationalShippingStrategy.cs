using StrategyPatternShippingCost.Interfaces;

namespace StrategyPatternShippingCost.Costs;
public class NationalShippingStrategy : IShippingStrategy
{
    const decimal PercentCost = 0.05m;
    public decimal CalculateShippingCost(decimal orderValue)
    {
        return orderValue * PercentCost;
    }
}
