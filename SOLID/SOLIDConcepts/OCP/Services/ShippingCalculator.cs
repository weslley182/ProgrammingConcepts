using SOLIDConcepts.OCP.Interface;

namespace SOLIDConcepts.OCP.Services;

public class ShippingCalculator
{
    private readonly List<IShippingRule> _rules;

    public ShippingCalculator(List<IShippingRule> rules)
    {
        _rules = rules;
    }
    public decimal Calculate(string region, decimal weight)
    {
        var rule = _rules.FirstOrDefault(r => r.IsMath(region));
        if (rule == null)
        {
            throw new Exception("Unknown region");
        }

        return rule.Calulate(weight);
    }
}
