# 🧱 SOLID Principles in C# (.NET)

This repository contains clear and practical examples of the **SOLID design principles**, implemented in **C#**, to help you write cleaner, more maintainable, and testable code in real .NET applications.

> ✅ Each example starts with a code that **violates** the principle, then shows a **refactored** version using clean architecture practices.

---

## 📦 Why SOLID?

SOLID is a set of five object-oriented principles that help developers:

- Reduce coupling between modules
- Improve code readability and flexibility
- Simplify testing and maintenance
- Enable scalable architecture

These principles are widely adopted in enterprise-grade systems and are foundational in modern **.NET development**.

---

## 🔠 Overview

| Principle | Name                             | Summary |
|----------:|:----------------------------------|:--------|
| 🟥 S      | **Single Responsibility**         | A class should have one reason to change |
| 🟦 O      | **Open/Closed**                   | Open for extension, closed for modification |
| 🟨 L      | **Liskov Substitution**           | Subtypes must be substitutable |
| 🟩 I      | **Interface Segregation**         | Don’t force classes to implement unused methods |
| 🟪 D      | **Dependency Inversion**          | Depend on abstractions, not implementations |

---

## 🟥 S: Single Responsibility Principle (SRP)

> **“A class should have only one reason to change.”**

SRP ensures that a class focuses on a single task or responsibility, making it easier to maintain and understand.

### 🔴 Violates SRP

```csharp
public class InvoiceServiceNoSRP
{
    public void GenerateInvoice(Order order)
    {
        var total = order.Items.Sum(i => i.Price * i.Quantity);
        SaveToDatabase(order, total);
        SendEmail(order.CustomerEmail, total);
    }
}
```

### ✅ Refactored with SRP

We extract each responsibility into its own class:

- `InvoiceCalculator`
- `InvoiceRepository`
- `EmailSender`

Each class has its own clear purpose, making the code modular and testable.

### 🎥 [Watch video S](https://youtu.be/dPRt6Y2HzAs)

---

## 🟦 O: Open/Closed Principle (OCP)

> **“Software entities should be open for extension, but closed for modification.”**

This principle promotes extending behavior via new code — not by changing existing code.

### 🔴 Violates OCP

```csharp
public class ShippingCalculator
{
    public decimal Calculate(string region, decimal weight)
    {
        if (region == "US") return weight * 1.5m;
        else if (region == "EU") return weight * 2.0m;
        else if (region == "ASIA") return weight * 2.5m;
        else throw new Exception("Unknown region");
    }
}
```

### ✅ Refactored with OCP

Introduce a strategy pattern via interfaces:

```csharp
public interface IShippingStrategy
{
    decimal Calculate(decimal weight);
}
```

Each region has its own strategy class. The calculator uses polymorphism to apply the correct one.

> ⚠ Strategy is a tool.  
> ✅ OCP is a **goal** — to allow extension without changing working code.

### 🎥 [Watch video O](https://youtu.be/1igDwUZkWSE)

---

## 🟨 L: Liskov Substitution Principle (LSP)

> **“Subtypes must be substitutable for their base types.”**

If a subclass breaks the behavior expected by its parent, it violates LSP — even if it compiles!

### 🔴 Violates LSP

```csharp
public class Customer
{
    public virtual string Email { get; set; }
}

public class AnonymousCustomer : Customer
{
    public override string Email => throw new Exception("No email available");
}
```

### ✅ Refactored with LSP

We separate responsibilities using interfaces:

- `IEmailRecipient`
- `Customer`
- `AnonymousCustomer` doesn't implement `IEmailRecipient`

This ensures that only valid objects expose email behavior.

### 🎥 [Watch video L](https://youtu.be/2zQ7qNjQEWk)

---

## 🟩 I: Interface Segregation Principle (ISP)

> **“Clients should not be forced to depend on methods they do not use.”**

Avoid creating "fat interfaces" that force classes to implement irrelevant methods.

### 🔴 Violates ISP

```csharp
public interface IMultiFunctionDevice
{
    void Print();
    void Scan();
    void Fax();
}

public class BasicPrinter : IMultiFunctionDevice
{
    public void Print() => Console.WriteLine("Printing");
    public void Scan() => throw new NotSupportedException();
    public void Fax() => throw new NotSupportedException();
}
```

### ✅ Refactored with ISP

Split into focused interfaces:

```csharp
public interface IPrinter { void Print(); }
public interface IScanner { void Scan(); }
public interface IFax { void Fax(); }
```

Now each class only implements what it actually supports.

### 🎥 [Watch video I](https://youtu.be/bU18V10VSbw)

---

## 🟪 D: Dependency Inversion Principle (DIP)

> **“High-level modules should not depend on low-level modules. Both should depend on abstractions.”**

Instead of directly creating concrete classes, depend on interfaces.

### 🔴 Violates DIP

```csharp
public class NotificationManager
{
    private readonly EmailService _emailService = new EmailService();

    public void Notify(string message)
    {
        _emailService.Send(message);
    }
}
```

### ✅ Refactored with DIP

```csharp
public interface INotificationService
{
    void Send(string message);
}

public class NotificationManager
{
    private readonly INotificationService _notificationService;

    public NotificationManager(INotificationService service)
    {
        _notificationService = service;
    }

    public void Notify(string message)
    {
        _notificationService.Send(message);
    }
}
```

This enables cleaner architecture and dependency injection in .NET apps.

### 🎥 [Watch video D](https://youtu.be/6S4OSZm6QyE)

---

## 📁 Project Structure

```bash
SOLIDConcepts/
│
├── SRP/         # Single Responsibility Principle
├── OCP/         # Open/Closed Principle
├── LSP/         # Liskov Substitution Principle
├── ISP/         # Interface Segregation Principle
├── DIP/         # Dependency Inversion Principle
│
└── Models/      # Shared domain classes (e.g. Order, Customer)
```

---

## 🙌 Let’s Connect

💬 Want to learn more about clean code, .NET, and architecture?  
📺 Check out the full [YouTube Playlist](https://youtube.com/your-playlist-link)  
🔗 Follow me on [LinkedIn](https://www.linkedin.com/in/dev-wesley-machado )  
🌟 Star the repo if this helped you!

---

## 🔖 Tags

`#CSharp` `#DotNet` `#SOLID` `#CleanCode`  
`#SoftwareDesign` `#ObjectOrientedProgramming` `#MicrosoftDeveloper`  
`#CodeQuality` `#DevBestPractices`
