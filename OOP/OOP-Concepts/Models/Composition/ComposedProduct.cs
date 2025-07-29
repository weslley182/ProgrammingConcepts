using OOP_Concepts.Models.Inheritance.Interface;

namespace OOP_Concepts.Models.Composition;

public class ComposedProduct
{
    public string Name { get; }
    public decimal BasePrice { get; }

    private readonly IPriceCalculator _calculator;

    public ComposedProduct(string name, decimal basePrice, IPriceCalculator calculator)
    {
        Name = name;
        BasePrice = basePrice;
        _calculator = calculator;
    }

    public decimal GetFinalPrice() => _calculator.Calculate(BasePrice);
}
