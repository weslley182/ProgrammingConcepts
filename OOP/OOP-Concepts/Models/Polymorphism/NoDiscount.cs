using OOP_Concepts.Models.Polymorphism.Interface;

namespace OOP_Concepts.Models.Polymorphism;

public class NoDiscount : IDiscountStrategy
{
    public decimal Apply(decimal basePrice) => basePrice;
}

