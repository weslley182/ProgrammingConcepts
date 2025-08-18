using SOLIDConcepts.OCP.Interface;

namespace SOLIDConcepts.OCP.Services;

public class EUShipping : IShippingRule
{
    public decimal Calulate(decimal weight)
    {
        return weight * 2.0m;
    }

    public bool IsMath(string region)
    {
        return region == "EU";
    }
}
