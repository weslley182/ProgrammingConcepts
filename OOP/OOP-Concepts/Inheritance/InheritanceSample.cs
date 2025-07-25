using OOP_Concepts.Models.Inheritance;

namespace OOP_Concepts.Inheritance;

public class InheritanceSample
{
    public void Execute()
    {
        var products = new List<NewProduct>
        {
            new Beverage("Coffee", 5.00m, true),
            new Snack("Cookie", 3.00m),
            new Beverage("Iced Tea", 4.00m, false)
        };

        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name}: {product.GetFinalPrice():C}");
        }
    }
}
