using OOP_Concepts.Models.Polymorphism;

namespace OOP_Concepts.Polymorphism;

// Polymorphism is demonstrated by applying different Promotion strategies
// through a shared base class, allowing dynamic behavior at runtime.

public class PolymorphismSample
{
    public void Execute()
    {
        Console.WriteLine("=== Polymorphism Inheritance ===");
        var basePrice = 20.00m;

        List<Promotion> promotions = new()
        {
            new PercentagePromotion(0.1m),     // 10% off
            new FixedDiscountPromotion(5.00m)  // $5 off
        };

        foreach (var promo in promotions)
        {
            var finalPrice = promo.Apply(basePrice);
            Console.WriteLine($"{promo.GetType().Name}: Final price = {finalPrice:C}");
        }

        Console.WriteLine("=== Polymorphism Interface ===");
        var strategy = new LoyaltyDiscount();
        Console.WriteLine(strategy.Apply(basePrice));
    }
}

