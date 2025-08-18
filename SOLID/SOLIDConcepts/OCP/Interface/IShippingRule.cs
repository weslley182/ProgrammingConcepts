namespace SOLIDConcepts.OCP.Interface;

public interface IShippingRule
{
    bool IsMath(string region);
    decimal Calulate(decimal weight);
}
