using OOP_Concepts.Models.Polymorphism.Interface;

namespace OOP_Concepts.Models.Polymorphism;

public class LoyaltyDiscount : IDiscountStrategy
{
    const decimal PercentValue = 0.85m;
    public decimal Apply(decimal basePrice) =>
        basePrice * PercentValue;
}