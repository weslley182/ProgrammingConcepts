using OOP_Concepts.Models.Inheritance;

namespace OOP_Concepts.Inheritance;

public class InheritanceSample
{
    public void Execute()
    {
        const bool isCold = true;

        var products = new List<NewProduct>
        {
            new Beverage("Coffee", 5.00m, !isCold),
            new Snack("Cookie", 3.00m),
            new Beverage("Iced Tea", 4.00m, isCold)
        };

        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name}: {product.GetFinalPrice():C}");
        }
    }
}
