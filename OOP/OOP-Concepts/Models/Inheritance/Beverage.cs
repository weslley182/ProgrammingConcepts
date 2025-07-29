namespace OOP_Concepts.Models.Inheritance;

public class Beverage : NewProduct
{
    const decimal ColdBeveragePrice = 1.00m;
    public bool IsCold { get; }

    public Beverage(string name, decimal basePrice, bool isCold)
        : base(name, basePrice)
    {
        IsCold = isCold;
    }

    public override decimal GetFinalPrice() => BasePrice + (IsCold ? ColdBeveragePrice : 0.00m);
}

