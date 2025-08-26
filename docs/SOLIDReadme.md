# 🧱 SOLID - S: Single Responsibility Principle (SRP) in C#

This repository contains a simple yet effective example of the **Single Responsibility Principle (SRP)** — the first principle in the **SOLID** design principles, implemented in **C#**.

---

## 📌 What is SRP?

> **"A class should have only one reason to change."**

SRP encourages clean architecture by ensuring that each class has one responsibility — and therefore only one reason to change. This makes your codebase easier to maintain, test, and extend.

---

## 💡 Example: Invoice Generation System

We simulate a basic `InvoiceService` class that:
- Calculates the total amount of an order
- Saves the invoice to the database
- Sends an email to the customer

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

---

## 🟦 O: Open/Closed Principle (OCP)

> “Software entities should be open for extension, but closed for modification.”

This principle encourages designing your code in a way that allows new functionality to be added **without changing existing, working code** — reducing the risk of bugs and improving maintainability.

---

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
⚖️ OCP vs Strategy Pattern

This solution may look similar to the Strategy Pattern — and that’s intentional.
👉 Strategy is a tool.
👉 OCP is a goal.

You can use patterns like Strategy, Factory, and Decorator to achieve OCP — but the focus is on making your code resilient to change by avoiding the need to modify working logic.

---

## 🟨 L: Liskov Substitution Principle (LSP)

> “Objects of a superclass should be replaceable with objects of its subclasses without affecting the correctness of the program.”

The Liskov Substitution Principle (LSP) ensures that subclasses remain true to the behavior expected by their base class or interface. If substituting a subclass breaks functionality, the design is flawed.

---

### 🔴 Violates LSP

In this example, we have a base class `Customer` that exposes an `Email` property:

```csharp
public class Customer
{
    public virtual string Email { get; set; }
}
```

🎥 Related Video
- [Watch video S](https://youtu.be/dPRt6Y2HzAs)
- [Watch video O](https://youtu.be/1igDwUZkWSE)
- [Watch video L](https://youtu.be/2zQ7qNjQEWk)
