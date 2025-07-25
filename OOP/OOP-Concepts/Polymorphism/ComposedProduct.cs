using OOP_Concepts.Polymorphism.Interface;

namespace OOP_Concepts.Polymorphism;

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
