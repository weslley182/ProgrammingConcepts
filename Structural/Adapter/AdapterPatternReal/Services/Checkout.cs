using AdapterPatternReal.Dto;
using AdapterPatternReal.Interface;

namespace AdapterPatternReal.Services;

// Client
public static class Checkout
{
    public static async Task RunAsync()
    {
        IPaymentGateway gateway = new StripeAdapter(new StripeClient());
        var res = await gateway.ChargeAsync(new PaymentRequest("cust_123", 49.90m, "USD"));
        if (!res.Success) throw new Exception(res.Error);
    }
}
