using AdapterPatternReal.Interface;

namespace AdapterPatternReal.Services;

// Adaptee 2: PayPal SDK (another shape)
public sealed class PaypalClient : IPaypalClient
{
    public Task<string> MakePaymentAsync(decimal amount, string user, string currency, CancellationToken ct)
    {
        Console.WriteLine($"[PayPal SDK] Charging {amount} {currency} for {user}...");
        return Task.FromResult("paypal_" + Guid.NewGuid());
    }
}
