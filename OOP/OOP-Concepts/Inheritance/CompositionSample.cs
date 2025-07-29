using OOP_Concepts.Models.Composition;

namespace OOP_Concepts.Inheritance;

// Polymorphism and composition are demonstrated by injecting behavior into a product class
// through a shared IPriceCalculator interface, allowing flexible pricing without inheritance.

public class CompositionSample
{
    public void Execute()
    {
        var products = new List<ComposedProduct>
        {
            new ComposedProduct("Hot Coffee", 5.00m, new BeverageSurcharge(isCold: false)),
            new ComposedProduct("Iced Tea", 4.00m, new BeverageSurcharge(isCold: true)),
            new ComposedProduct("Cookie", 3.00m, new NoSurcharge())
        };

        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name}: {product.GetFinalPrice():C}");
        }
    }
}

