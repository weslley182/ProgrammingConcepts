using SOLIDConcepts.OCP.Interface;

namespace SOLIDConcepts.OCP.Services;

public class JapanShipping : IShippingRule
{
    public decimal Calulate(decimal weight)
    {
        return weight * 3.5m;
    }

    public bool IsMath(string region)
    {
        return region == "JP";
    }
}
