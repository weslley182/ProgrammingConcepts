using OOP_Concepts.Models.Inheritance.Interface;

namespace OOP_Concepts.Models.Composition;

public class NoSurcharge : IPriceCalculator
{
    public decimal Calculate(decimal basePrice) => basePrice;
}

