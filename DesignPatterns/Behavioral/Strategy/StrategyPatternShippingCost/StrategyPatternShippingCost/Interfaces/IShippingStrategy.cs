namespace StrategyPatternShippingCost.Interfaces;
public interface IShippingStrategy
{
    decimal CalculateShippingCost(decimal orderValue);
}
