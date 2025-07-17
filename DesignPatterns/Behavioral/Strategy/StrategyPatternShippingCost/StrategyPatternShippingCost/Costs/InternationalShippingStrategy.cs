using StrategyPatternShippingCost.Interfaces;

namespace StrategyPatternShippingCost.Costs;
public class InternationalShippingStrategy : IShippingStrategy
{
    const decimal FixedTax = 15.00m;
    const decimal PercentCost = 0.10m;
    public decimal CalculateShippingCost(decimal orderValue)
    {
        return FixedTax + (orderValue * PercentCost); // Fixed Tax + 10%
    }
}
