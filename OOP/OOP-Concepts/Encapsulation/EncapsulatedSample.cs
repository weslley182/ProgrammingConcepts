using OOP_Concepts.Models;

namespace OOP_Concepts.Encapsulation;

public class EncapsulatedSample
{
    public void Execute()
    {
        Console.WriteLine("Presenting Encapsulation example");

        var coffee = new Product("Coffee", 5.00m);
        var sandwich = new Product("Sandwich", 8.50m);

        var order = new Order();
        order.AddProduct(coffee);
        order.AddProduct(sandwich);

        order.PrintProductList();
        Console.WriteLine($"Total: {order.GetTotalPrice():C}");
    }
}
