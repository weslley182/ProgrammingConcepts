using SOLIDConcepts.OCP.Interface;

namespace SOLIDConcepts.OCP.Services;

public class USShipping : IShippingRule
{
    public decimal Calulate(decimal weight)
    {
        return weight * 1.5m;
    }

    public bool IsMath(string region)
    {
        return region == "US";
    }
}
