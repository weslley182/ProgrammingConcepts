using AdapterPatternReal.Interface;

namespace AdapterPatternReal.Services;

// Adaptee 1: Stripe SDK (shape differs from your target)
public sealed class StripeClient : IStripeClient
{
    // Retorna tupla (ok, id, err) para simular um SDK diferente do seu contrato
    public Task<(bool ok, string id, string err)> PayAsync(string cust, long cents, string curr, CancellationToken ct)
    {
        Console.WriteLine($"[Stripe SDK] Charging {cents} cents {curr} for {cust}...");
        return Task.FromResult<(bool, string, string)>((true, "stripe_" + Guid.NewGuid(), ""));
    }
}
