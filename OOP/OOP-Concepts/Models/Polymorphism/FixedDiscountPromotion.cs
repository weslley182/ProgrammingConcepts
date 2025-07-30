namespace OOP_Concepts.Models.Polymorphism;

public class FixedDiscountPromotion : Promotion
{
    public decimal Amount { get; }

    public FixedDiscountPromotion(decimal amount)
    {
        Amount = amount;
    }

    public override decimal Apply(decimal basePrice) =>
        basePrice - Amount;
}

