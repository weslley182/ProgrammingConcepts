# 🛡 SOLID Principles in C# - Clean Architecture with Real Examples

This repository showcases **practical and educational examples** of each principle in the **SOLID** design principles, implemented in **C#** using real-world inspired scenarios.

Whether you're learning SOLID for the first time or brushing up for professional practice, these examples aim to demonstrate:

* How each principle improves maintainability
* What a violation looks like in the real world
* How to refactor step-by-step

---

## 🌤 What is SOLID?

**SOLID** is an acronym representing five key design principles in object-oriented programming, introduced by Robert C. Martin (Uncle Bob). Together, they help you write code that is:

* Easier to read
* More testable
* Open to change, without breaking existing logic

> "Bad code works. But good code evolves."

---

## 🔴 S — Single Responsibility Principle (SRP)

> **"A class should have only one reason to change."**

### ❌ Problem

A class that performs too many responsibilities becomes hard to maintain and test.

### 💡 Example: `InvoiceService`

Responsible for:

* Calculating total amount
* Saving to database
* Sending email

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

Split responsibilities into:

* `InvoiceCalculator`
* `InvoiceRepository`
* `EmailService`

---

## 🔵 O — Open/Closed Principle (OCP)

> **"Software entities should be open for extension, but closed for modification."**

### ❌ Problem

Every new case added to a `switch` or `if` forces us to edit and risk breaking existing code.

### 💡 Example: `ShippingCalculator` by region

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

Use polymorphism and interface composition:

* `IShippingRule`
* `USShipping`, `EUShipping`, etc.
* Inject rules into a flexible calculator

### ⚖️ OCP vs Strategy

This design resembles the Strategy Pattern — and that’s intentional:

* Strategy is a **tool**
* OCP is a **goal**

---

## 🔺 L — Liskov Substitution Principle (LSP)

> **"Subtypes must be substitutable for their base types without breaking behavior."**

### ❌ Problem

Subclass throws exception when base behavior is expected:

```csharp
public class SmsOnlyCustomer : Customer
{
    public override string Email => throw new NotSupportedException();
}
```

Used like:

```csharp
public void Notify(Customer c) => Console.WriteLine(c.Email);
```

💥 This breaks at runtime — violation of LSP.

### ✅ Refactored with Interfaces

Create specific abstractions like:

* `INotifiable`
* `EmailCustomer`, `SmsCustomer`

Each implementation handles its notification logic safely.

---

## 🟩 I — Interface Segregation Principle (ISP)

> **"Clients should not be forced to depend on interfaces they do not use."**

### ❌ Problem

Large interfaces force implementing classes to support methods that don't apply to them.

### 💡 Example: `IMultiFunctionDevice`

```csharp
public interface IMultiFunctionDevice
{
    void Print();
    void Scan();
    void Fax();
}

public class BasicPrinter : IMultiFunctionDevice
{
    public void Print() => Console.WriteLine("🖨 Printing...");
    public void Scan() => throw new NotSupportedException();
    public void Fax() => throw new NotSupportedException();
}
```

The `BasicPrinter` is forced to implement features it doesn't support.

### ✅ Refactored with ISP

Split into small, focused interfaces:

```csharp
public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public interface IFax
{
    void Fax();
}
```

Now classes implement only what they need:

```csharp
public class SimplePrinter : IPrinter
{
    public void Print() => Console.WriteLine("🖨 Printing...");
}

public class OfficePrinter : IPrinter, IScanner, IFax
{
    public void Print() => Console.WriteLine("🖨 Printing...");
    public void Scan() => Console.WriteLine("📠 Scanning...");
    public void Fax() => Console.WriteLine("📠 Faxing...");
}
```

---

## ▶️ Watch the Videos

Each principle is also explained with hands-on refactoring in video:

* 🎥 [SRP — Single Responsibility Principle](https://youtu.be/dPRt6Y2HzAs)
* 🎥 [OCP — Open/Closed Principle](https://youtu.be/1igDwUZkWSE)
* 🎥 [LSP — Liskov Substitution Principle](https://youtu.be/2zQ7qNjQEWk)

Coming soon:

* 🔺 Dependency Inversion Principle

---

## 🧠 Why Learn SOLID?

Applying SOLID in C# and .NET leads to:

* Lower coupling
* Higher cohesion
* Easier testing with abstractions
* Real scalability for enterprise projects

All examples here use **Microsoft stack** technologies — and align with best practices for building modern, maintainable .NET systems.

> “Good architecture maximizes the number of decisions not made.”

---

## 🏷️ Tags

`#CSharp` `#DotNet` `#SOLID` `#CleanCode` `#SoftwareDesign` `#MicrosoftDeveloper`
