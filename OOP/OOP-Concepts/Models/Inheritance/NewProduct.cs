namespace OOP_Concepts.Models.Inheritance;

public class NewProduct
{
    public string Name { get; }
    public decimal BasePrice { get; }

    public NewProduct(string name, decimal basePrice)
    {
        Name = name;
        BasePrice = basePrice;
    }

    public virtual decimal GetFinalPrice() => BasePrice;
}
