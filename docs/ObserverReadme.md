# Observer Pattern

## 🎯 Objective

Establish a one-to-many dependency between objects so that when one object (the subject) changes state, all its dependents (observers) are automatically notified and updated.

## 📌 Definition

The Observer Pattern defines a communication mechanism where one object (subject) notifies multiple observers about changes, without being tightly coupled to them.

## 🧠 Analogy

Think of a weather station. It reports temperature changes. Multiple displays, apps, or loggers can subscribe to it. When the temperature changes, all subscribers are notified automatically.

## 🚀 When to Use

- When multiple objects need to react to a change in one object
- To decouple event publishers from subscribers
- In event-driven systems, UI updates, logging, or notification chains

## 💡 Common Use Cases

- UI data binding (React, Angular, WPF)
- Event listeners in GUI applications
- Notification systems (email, SMS, webhooks)
- Loggers reacting to system state changes
- Pub/sub and message brokers

## 🛠 Example Structure

- `ISubject` – manages subscriptions and notifies observers
- `IObserver` – interface implemented by observers
- `WeatherStation` – subject that triggers notifications
- `TemperatureDisplay` and `TemperatureLogger` – observers that react to updates

## 📦 Real-World Scenario

In this project:
- `WeatherStation` holds the temperature state
- Observers subscribe via `Attach()`
- When the temperature changes, all observers are notified

## 📷 Diagram

See: `diagram.png`

## 📚 References

- [Refactoring Guru](https://refactoring.guru/design-patterns/observer)
- [Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/standard/events/)

## 🎥 Related Video
- [Observer Pattern Explanation](https://youtu.be/_hBZyQTnpvo)

## 🌐 Blog
- https://wesleydevcamp.wordpress.com/2025/09/19/observer-pattern/