namespace OOP_Concepts.Models;

// Order.cs
public class Order
{
    private readonly List<Product> _items = new();

    public IReadOnlyList<Product> Items => _items.AsReadOnly();

    public void AddProduct(Product product)
    {
        if (product is null)
        {
            throw new ArgumentNullException(nameof(product));
        }

        _items.Add(product);
    }

    public decimal GetTotalPrice() => _items.Sum(p => p.Price);

    public void PrintProductList()
    {
        foreach (var item in _items)
        {
            Console.WriteLine($"{item.Name}: {item.Price:C}");
        }
    }
}
