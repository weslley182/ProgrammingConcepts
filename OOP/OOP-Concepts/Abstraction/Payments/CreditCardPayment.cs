using OOP_Concepts.Abstraction.Payments.Interface;

namespace OOP_Concepts.Abstraction.Payments;

public class CreditCardPayment : IPaymentMethod
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount:C} using credit card.");
    }
}

