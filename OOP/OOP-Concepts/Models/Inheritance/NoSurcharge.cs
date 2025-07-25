using OOP_Concepts.Polymorphism.Interface;

namespace OOP_Concepts.Models.Inheritance;

public class NoSurcharge : IPriceCalculator
{
    public decimal Calculate(decimal basePrice) => basePrice;
}

