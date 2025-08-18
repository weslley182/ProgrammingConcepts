using OOP_Concepts.Models.General;
using SOLIDConcepts.SRP.Service;

namespace SOLIDConcepts.SRP;

public class SRPSample
{
    public void Execute()
    {
        Order order = CreateOrder();

        ExecuteWithoutSRP(order);
        Console.WriteLine();
        ExecuteWithSRP(order);
    }

    private static Order CreateOrder()
    {
        Console.WriteLine("=== Single Responsability ===");

        var order = new Order
        {
            CustomerEmail = "client@example.com"
        };

        order.AddProduct(new Product("Coffee", 10.00m, 2));
        order.AddProduct(new Product("Beer", 10.00m, 2));
        order.AddProduct(new Product("Soda", 5.00m, 1));
        return order;
    }

    private void ExecuteWithoutSRP(Order order)
    {
        Console.WriteLine("=== No SRP Sample ===");

        var invoiceServiceNoSRP = new InvoiceServiceNoSRP();
        invoiceServiceNoSRP.GenerateInvoice(order);
    }

    private void ExecuteWithSRP(Order order)
    {
        Console.WriteLine("=== SRP Sample ===");

        var invCalculator = new InvoiceCalculator();
        var repo = new InvoiceRepository();
        var mail = new EmailService();

        var invoiceService = new InvoiceService(invCalculator, repo, mail);
        invoiceService.GenerateInvoice(order);
    }
}

