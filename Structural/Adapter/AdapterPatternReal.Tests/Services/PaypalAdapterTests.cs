using AdapterPatternReal.Dto;
using AdapterPatternReal.Interface;
using AdapterPatternReal.Services;
using Bogus;
using NSubstitute;
using NSubstitute.ExceptionExtensions;

namespace AdapterPatternReal.Tests.Services;

public class PaypalAdapterTests
{
    private readonly Faker _faker = new();

    [Fact]
    public async Task ChargeAsync_whenOk_shouldReturnSuccessAndTransaction()
    {
        var req = new PaymentRequest(
            _faker.Random.AlphaNumeric(10),
            _faker.Finance.Amount(5, 150),
            "EUR");

        var paypal = Substitute.For<IPaypalClient>();
        paypal.MakePaymentAsync(req.Amount, req.CustomerId, req.Currency, Arg.Any<CancellationToken>())
              .Returns("pp_tx_789");

        var sut = new PaypalAdapter(paypal);

        var result = await sut.ChargeAsync(req);

        Assert.True(result.Success);
        Assert.Equal("pp_tx_789", result.TransactionId);
        Assert.Equal("", result.Error);
    }

    [Fact]
    public async Task ChargeAsync_whenThrows_shouldReturnError()
    {
        var req = new PaymentRequest("cust", 49.90m, "USD");

        var paypal = Substitute.For<IPaypalClient>();
        paypal.MakePaymentAsync(req.Amount, req.CustomerId, req.Currency, Arg.Any<CancellationToken>())
              .ThrowsAsync(new Exception("NETWORK_TIMEOUT"));

        var sut = new PaypalAdapter(paypal);

        var result = await sut.ChargeAsync(req);

        Assert.False(result.Success);
        Assert.Equal("", result.TransactionId);
        Assert.Equal("NETWORK_TIMEOUT", result.Error);
    }
}
