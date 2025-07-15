using StrategyPatternShippingCost.Interfaces;

namespace StrategyPatternShippingCost.Costs;
public class ExpressShippingStrategy : IShippingStrategy
{
    const decimal FixedTax = 30.00m;
    const decimal PercentCost = 0.15m;
    public decimal CalculateShippingCost(decimal orderValue)
    {
        return FixedTax + (orderValue * PercentCost);
    }
}
