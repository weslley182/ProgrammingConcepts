namespace OOP_Concepts.Models.Polymorphism;

public class PercentagePromotion : Promotion
{
    public decimal Percentage { get; }

    public PercentagePromotion(decimal percentage)
    {
        Percentage = percentage;
    }

    public override decimal Apply(decimal basePrice) =>
        basePrice * (1 - Percentage);
}

