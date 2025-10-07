using AdapterPatternReal.Dto;
using AdapterPatternReal.Interface;
using System.Diagnostics;

namespace AdapterPatternReal.Services;

public sealed class PaypalAdapter : IPaymentGateway
{
    private readonly IPaypalClient _client;
    public PaypalAdapter(IPaypalClient client) => _client = client;

    public async Task<PaymentResult> ChargeAsync(PaymentRequest req, CancellationToken ct = default)
    {
        var sw = Stopwatch.StartNew();
        try
        {
            var tx = await _client.MakePaymentAsync(req.Amount, req.CustomerId, req.Currency, ct);
            Console.WriteLine($"[PaypalAdapter] ok=true, tx={tx}, elapsed={sw.ElapsedMilliseconds}ms");
            return new PaymentResult(true, tx);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[PaypalAdapter] ok=false, error='{ex.Message}', elapsed={sw.ElapsedMilliseconds}ms");
            return new PaymentResult(false, "", ex.Message);
        }
    }
}
