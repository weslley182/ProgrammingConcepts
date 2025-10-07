using AdapterPatternReal.Dto;

namespace AdapterPatternReal.Interface;

// Target interface (what your domain expects)
public interface IPaymentGateway
{
    Task<PaymentResult> ChargeAsync(PaymentRequest request, CancellationToken ct = default);
}
