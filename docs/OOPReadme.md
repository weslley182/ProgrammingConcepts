# CoffeeShop – Object-Oriented Programming in Practice ☕

This repository is part of a content series on YouTube, Blog, and LinkedIn focused on teaching the 4 pillars of Object-Oriented Programming (OOP) using a real-world project.

## 🎯 Objective
Demonstrate **Encapsulation**, **Abstraction**, **Inheritance**, and **Polymorphism** through a simplified coffee shop system written in C#.

## 📚 Modules

### ✅ Module 0 – Why OOP Matters + Encapsulation
- Introduction to OOP and when it makes sense
- Procedural vs OOP example
- Encapsulation with a protected `Order` class
- 🎥 [Watch video](https://youtu.be/SflyTIaQBvc) | 📝 [Read blog](https://wesleydevcamp.wordpress.com/2025/07/17/oop-encapsulation/)

### 📦 Upcoming:
- Abstraction with `IPaymentMethod`
- Inheritance with product hierarchy
- Polymorphism with flexible discount strategies

## 🧱 Structure
### /Models
- Product.cs
- Order.cs
- Customer.cs

### /Services
- CheckoutService.cs

### /Payments
- IPaymentMethod.cs
- CreditCardPayment.cs

### /Promotions
- Promotion.cs
- PercentagePromotion.cs
- FixedDiscountPromotion.cs

### Tests/
- OrderTests.cs

## 🎥 Related Video
- [OOP Encapsulation Explanation](https://youtu.be/SflyTIaQBvc)

## 🌐 Blog
- https://wesleydevcamp.wordpress.com/2025/07/15/strategy-pattern/