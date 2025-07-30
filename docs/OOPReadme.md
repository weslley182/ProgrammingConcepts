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

### ✅ Module 1 – Abstraction with Interfaces

- Difference between Encapsulation and Abstraction
- Creating the IPaymentMethod interface
- Multiple implementations: Credit Card and Cash
- Injecting abstraction in CheckoutService

- 🎥 [Watch video](https://youtu.be/nqUrCaMggpU) | 📝 [Read blog](https://wesleydevcamp.wordpress.com/2025/07/17/oop-abstraction/)

### ✅ Module 2 – Inheritance with Product Hierarchy

- Understanding when inheritance makes sense
- Creating a base Product class with virtual behavior
- Extending it with Beverage and Snack types
- Demonstrating reuse and method overriding
- 🎥 [Watch video](https://youtu.be/azh9D0vOF88) | 📝 [Read blog](https://wesleydevcamp.wordpress.com/2025/07/29/oop-inheritance/)

### ✅ Module 3 – Polymorphism and Strategy Foundations

- Understanding polymorphism: multiple forms through a common contract
- Implementing polymorphism via inheritance and interface
- Applying real-world promotions using dynamic behavior
- How this principle enables the Strategy Pattern
- 🎥 [Watch video](https://youtu.be/Bhq97ZO0diA) | 📝 [Read blog](https://wesleydevcamp.wordpress.com/2025/07/30/oop-polymorphism/)

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