namespace OOP_Concepts.Encapsulation;

public class ProceduralSample
{
    public void Execute()
    {
        Console.WriteLine("Presenting Procedural example");

        var products = new List<(string name, decimal price)>
        {
            ("Coffee", 5.00m),
            ("Sandwich", 8.50m)
        };

        var orderItems = new List<(string name, decimal price)>();

        foreach (var product in products)
        {
            orderItems.Add(product);
        }

        var total = 0m;
        foreach (var item in orderItems)
        {
            total += item.price;
            Console.WriteLine($"{item.name}: {item.price:C}");
        }

        Console.WriteLine($"Total: {total:C}");

    }
}
