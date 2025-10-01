# Decorator Pattern

## 🎯 Objective
Add responsibilities or behavior to an object dynamically at runtime without modifying its class or creating deep inheritance trees.

## 📌 Definition
The Decorator Pattern wraps a component with one or more “decorator” objects that implement the same interface and forward calls to the wrapped component, adding behavior before, after, or around the call.

## 🧠 Analogy
Think of a cup of coffee. The coffee itself is the base object. When you add milk, caramel, or whipped cream, you’re decorating the coffee. It’s still coffee, but now with extra features. That’s exactly what the Decorator Pattern does.

## 🚀 When to Use
- When you want to extend the behavior of objects without altering their class.
- To avoid subclass explosion when combining multiple responsibilities.
- When you want to follow the Open/Closed Principle: open for extension, closed for modification.
- To add or remove features dynamically at runtime.

## 💡 Common Use Cases
- Adding logging, caching, or retry logic around services.
- Extending stream functionality (`FileStream`, `BufferedStream`, `CryptoStream` in .NET).
- Middleware pipelines (ASP.NET Core request/response handling).
- UI component decoration (styling, behavior wrapping).

## 🛠 Example Structure
- `INotifier` – component interface.
- `EmailNotifier` – concrete implementation.
- `NotifierDecorator` – base decorator that wraps a notifier.
- `SmsNotifier` and `SlackNotifier` – concrete decorators that extend behavior.

## 📦 Example Code

```csharp
public interface INotifier
{
    void Send(string message);
}

public class EmailNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"EMAIL: {message}");
    }
}

public abstract class NotifierDecorator : INotifier
{
    protected readonly INotifier Inner;
    protected NotifierDecorator(INotifier inner) => Inner = inner;

    public virtual void Send(string message) => Inner.Send(message);
}

public sealed class SmsNotifier : NotifierDecorator
{
    public SmsNotifier(INotifier inner) : base(inner) { }
    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"SMS: {message}");
    }
}

public sealed class SlackNotifier : NotifierDecorator
{
    public SlackNotifier(INotifier inner) : base(inner) { }
    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"SLACK: {message}");
    }
}
```

### ✅ Usage
```csharp
INotifier notifier =
    new SlackNotifier(
        new SmsNotifier(
            new EmailNotifier()));

notifier.Send("Deployment finished");
```

### ▶️ Output
```
EMAIL: Deployment finished
SMS: Deployment finished
SLACK: Deployment finished
```

## 🧠 Decorator vs Observer
At first sight, Decorator may look similar to Observer because both extend functionality without changing the original class. But the key difference is:

- **Observer**: one-to-many. A subject notifies multiple observers, each reacting independently. It’s about broadcasting events.
- **Decorator**: one-to-one. You wrap a single object and layer additional responsibilities. It’s about dynamically enriching behavior.

👉 Observer reacts to events. Decorator extends behavior.

## 📚 References
- [Refactoring Guru – Decorator](https://refactoring.guru/design-patterns/decorator)
- [Microsoft Docs – HttpClient Handlers](https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient-message-handlers)

## 🎥 Related Video

- [Decorator Pattern Explanation](https://youtu.be/S76odcsItOw)

## 🌐 Blog

- https://wesleydevcamp.wordpress.com/2025/10/01/decorator-pattern/
