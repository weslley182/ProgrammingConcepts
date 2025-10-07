using AdapterPatternReal.Dto;
using AdapterPatternReal.Interface;
using System.Diagnostics;

namespace AdapterPatternReal.Services;

// Stripe Adapter
public sealed class StripeAdapter : IPaymentGateway
{
    private readonly IStripeClient _client;
    public StripeAdapter(IStripeClient client) => _client = client;

    public async Task<PaymentResult> ChargeAsync(PaymentRequest req, CancellationToken ct = default)
    {
        var cents = (long)(req.Amount * 100m);
        var sw = Stopwatch.StartNew();

        var (ok, id, err) = await _client.PayAsync(req.CustomerId, cents, req.Currency, ct);

        Console.WriteLine($"[StripeAdapter] ok={ok}, tx={id}, err='{err}', elapsed={sw.ElapsedMilliseconds}ms");
        return new PaymentResult(ok, id, err);
    }
}
