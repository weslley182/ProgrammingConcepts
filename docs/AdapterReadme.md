# Adapter Pattern

## 🎯 Objective
Allow objects with incompatible interfaces to work together by providing a wrapper that translates one interface into another expected by the client.

## 📌 Definition
The Adapter Pattern acts as a **translator** between two classes that otherwise couldn’t communicate.  
It converts the interface of a class into another interface that a client expects, enabling reusability and flexibility without modifying existing code.

## 🧠 Analogy
Imagine a laptop with only USB-C ports, but your flash drive uses USB-A.  
A physical adapter bridges the two — allowing them to connect seamlessly.  
In software, the Adapter Pattern serves the same purpose: it connects two components with incompatible interfaces.

## 🚀 When to Use
- You need to integrate legacy code or third-party libraries with a new system.  
- Two classes should collaborate, but their interfaces don’t match.  
- You want to reuse existing functionality without modifying it.  
- You need to standardize communication across multiple providers or APIs.

## 💡 Common Use Cases
- Integrating external APIs or SDKs (e.g., payment gateways, messaging services).  
- Adapting legacy modules to new architecture.  
- Bridging interfaces between incompatible layers.  
- Standardizing multiple providers under a single interface.

## 🛠 Example Structure
- `INotifier` – Target interface expected by the system.  
- `LegacySmsClient` – Existing or third-party class with an incompatible interface.  
- `SmsAdapter` – Translates the expected interface to the legacy API.  
- Client code – Works only with `INotifier` and stays decoupled.

## 📦 Example Code (Didactic)

```csharp
public interface INotifier
{
    void Send(string to, string message);
}

public sealed class LegacySmsClient
{
    public bool SendSms(string e164Number, string body)
    {
        Console.WriteLine($"[LegacySmsClient] -> SMS to {e164Number}: {body}");
        return true;
    }
}

public sealed class SmsAdapter : INotifier
{
    private readonly LegacySmsClient _sms;
    public SmsAdapter(LegacySmsClient sms) => _sms = sms;

    public void Send(string to, string message)
    {
        var e164 = to.StartsWith('+') ? to : "+" + to;
        var ok = _sms.SendSms(e164, message);
        Console.WriteLine(ok ? "[SmsAdapter] SMS sent successfully." : "[SmsAdapter] SMS failed.");
    }
}

// Usage
var notifier = new SmsAdapter(new LegacySmsClient());
notifier.Send("5511999990000", "Deployment finished ✔");
```

**Output:**
```
[LegacySmsClient] -> SMS to +5511999990000: Deployment finished ✔
[SmsAdapter] SMS sent successfully.
```

## 💼 Real-World Example (Payment Gateways)

```csharp
public interface IPaymentGateway
{
    Task<PaymentResult> ChargeAsync(PaymentRequest request, CancellationToken ct = default);
}

public sealed record PaymentRequest(string CustomerId, decimal Amount, string Currency);
public sealed record PaymentResult(bool Success, string TransactionId, string Error = "");

// Stripe SDK (Adaptee)
public sealed class StripeClient
{
    public Task<(bool ok, string id, string err)> PayAsync(string cust, long cents, string curr, CancellationToken ct)
    {
        Console.WriteLine($"[Stripe SDK] Charging {cents} cents {curr} for {cust}...");
        return Task.FromResult<(bool, string, string)>((true, "stripe_" + Guid.NewGuid(), ""));
    }
}

// Adapter
public sealed class StripeAdapter : IPaymentGateway
{
    private readonly StripeClient _client;
    public StripeAdapter(StripeClient client) => _client = client;

    public async Task<PaymentResult> ChargeAsync(PaymentRequest req, CancellationToken ct = default)
    {
        var cents = (long)(req.Amount * 100m);
        var (ok, id, err) = await _client.PayAsync(req.CustomerId, cents, req.Currency, ct);
        Console.WriteLine($"[StripeAdapter] ok={ok}, tx={id}");
        return new PaymentResult(ok, id, err);
    }
}
```

**Output:**
```
[Stripe SDK] Charging 4990 cents USD for cust_123...
[StripeAdapter] ok=True, tx=stripe_52b4...
```

## 🧪 Tests (xUnit + NSubstitute)

```csharp
[Fact]
public async Task ChargeAsync_WhenOk_ShouldReturnSuccess()
{
    var stripe = Substitute.For<IStripeClient>();
    stripe.PayAsync(Arg.Any<string>(), Arg.Any<long>(), Arg.Any<string>(), Arg.Any<CancellationToken>())
          .Returns((true, "tx123", ""));

    var sut = new StripeAdapter(stripe);
    var result = await sut.ChargeAsync(new PaymentRequest("cust", 10m, "USD"));

    Assert.True(result.Success);
    Assert.Equal("tx123", result.TransactionId);
}
```

## 🧩 Difference Between Adapter and Other Patterns
- **Decorator**: Adds new responsibilities dynamically. Adapter changes interface compatibility.  
- **Observer**: Broadcasts notifications to multiple listeners. Adapter just translates one interface to another.  
- **Bridge**: Separates abstraction from implementation; Adapter focuses on conversion.

## 📚 References
- [Refactoring Guru – Adapter](https://refactoring.guru/design-patterns/adapter)  
- [Microsoft Docs – Dependency Inversion and Abstractions](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/dependency-inversion)

## 🎥 Related Video
- [Adapter Pattern Explanation](https://youtu.be/HTCj4A5EqDg)

## 🌐 Blog
- https://wesleydevcamp.wordpress.com/2025/09/19/observer-pattern/