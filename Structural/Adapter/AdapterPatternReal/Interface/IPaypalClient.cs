namespace AdapterPatternReal.Interface;

public interface IPaypalClient
{
    Task<string> MakePaymentAsync(decimal amount, string user, string currency, CancellationToken ct);
}
