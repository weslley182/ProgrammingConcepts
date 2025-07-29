using OOP_Concepts.Models.Inheritance.Interface;

namespace OOP_Concepts.Models.Composition;

public class BeverageSurcharge : IPriceCalculator
{
    private readonly bool _isCold;
    public BeverageSurcharge(bool isCold) => _isCold = isCold;

    public decimal Calculate(decimal basePrice) =>
        basePrice + (_isCold ? 1.00m : 0.00m);
}
