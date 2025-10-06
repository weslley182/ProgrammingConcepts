namespace AdapterPatternReal.Interface;

public interface IStripeClient
{
    Task<(bool ok, string id, string err)> PayAsync(string cust, long cents, string curr, CancellationToken ct);
}
