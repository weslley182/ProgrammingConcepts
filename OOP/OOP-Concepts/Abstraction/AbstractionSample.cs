using OOP_Concepts.Abstraction.Payments;
using OOP_Concepts.Abstraction.Payments.Interface;
using OOP_Concepts.Abstraction.Services;
using OOP_Concepts.Models.General;

namespace OOP_Concepts.Abstraction;

public class AbstractionSample
{
    public void Execute()
    {
        var order = new Order();
        order.AddProduct(new Product("Latte", 6.00m));
        order.AddProduct(new Product("Croissant", 4.00m));

        IPaymentMethod payment = new CreditCardPayment();
        var checkout = new CheckoutService();
        checkout.Checkout(order, payment);
    }
}
