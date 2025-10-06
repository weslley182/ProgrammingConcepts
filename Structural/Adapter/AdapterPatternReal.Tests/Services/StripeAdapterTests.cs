using AdapterPatternReal.Dto;
using AdapterPatternReal.Interface;
using AdapterPatternReal.Services;
using Bogus;
using NSubstitute;

namespace AdapterPatternReal.Tests.Services;
public class StripeAdapterTests
{
    private readonly Faker _faker = new();

    [Fact]
    public async Task ChargeAsync_whenOk_shouldReturnSuccessAndTransaction()
    {
        // arrange
        var req = new PaymentRequest(
            _faker.Random.AlphaNumeric(10),
            _faker.Finance.Amount(10, 200),
            "USD");

        var stripe = Substitute.For<IStripeClient>();
        stripe.PayAsync(req.CustomerId, Arg.Any<long>(), req.Currency, Arg.Any<CancellationToken>())
              .Returns((true, "tx123", ""));

        var sut = new StripeAdapter(stripe);

        // act
        var result = await sut.ChargeAsync(req);

        // assert
        Assert.True(result.Success);
        Assert.Equal("tx123", result.TransactionId);
        Assert.Equal("", result.Error);
    }

    [Fact]
    public async Task ChargeAsync_whenGatewayFails_shouldReturnError()
    {
        var req = new PaymentRequest("cust", 99.90m, "USD");

        var stripe = Substitute.For<IStripeClient>();
        stripe.PayAsync(req.CustomerId, Arg.Any<long>(), req.Currency, Arg.Any<CancellationToken>())
              .Returns((false, "", "DECLINED"));

        var sut = new StripeAdapter(stripe);

        var result = await sut.ChargeAsync(req);

        Assert.False(result.Success);
        Assert.Equal("", result.TransactionId);
        Assert.Equal("DECLINED", result.Error);
    }
}