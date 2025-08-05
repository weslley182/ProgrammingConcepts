namespace SOLIDConcepts.OCP.Services;

public class ShippingCalculatorNoOCP
{
    public decimal Calculate(string region, decimal weight)
    {
        if (region == "US")
        {
            return weight * 1.5m;
        }
        else if (region == "EU")
        {
            return weight * 2.0m;
        }
        else if (region == "ASIA")
        {
            return weight * 2.5m;
        }
        else
        {
            throw new Exception("Unknown region");
        }
    }
}

