namespace OOP_Concepts.Models.Inheritance;

public class Beverage : NewProduct
{
    public bool IsHot { get; }

    public Beverage(string name, decimal basePrice, bool isHot)
        : base(name, basePrice)
    {
        IsHot = isHot;
    }

    public override decimal GetFinalPrice() => BasePrice + (IsHot ? 0.50m : 0.30m);
}

