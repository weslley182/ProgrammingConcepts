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



🎥 Related Video
- [Watch video](https://youtu.be/dPRt6Y2HzAs)
