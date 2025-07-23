using OOP_Concepts.Abstraction.Payments.Interface;

namespace OOP_Concepts.Abstraction.Payments;

public class CashPayment : IPaymentMethod
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount:C} in cash.");
    }
}

