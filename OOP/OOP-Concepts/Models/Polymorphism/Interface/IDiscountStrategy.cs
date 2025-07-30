namespace OOP_Concepts.Models.Polymorphism.Interface;

public interface IDiscountStrategy
{
    decimal Apply(decimal basePrice);
}
