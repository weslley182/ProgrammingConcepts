using OOP_Concepts.Abstraction.Payments.Interface;
using OOP_Concepts.Models;

namespace OOP_Concepts.Abstraction.Services;

public class CheckoutService
{
    public void Checkout(Order order, IPaymentMethod paymentMethod)
    {
        var total = order.GetTotalPrice();
        paymentMethod.Pay(total);
    }
}

