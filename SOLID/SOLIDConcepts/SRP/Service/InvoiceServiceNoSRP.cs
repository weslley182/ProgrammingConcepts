using OOP_Concepts.Models.General;

namespace SOLIDConcepts.SRP.Service;

public class InvoiceServiceNoSRP
{
    public void GenerateInvoice(Order order)
    {
        // 1. Calculate total amount
        Console.WriteLine("Calculating total amount...");
        var total = order.Items.Sum(i => i.Price * i.Quantity);

        // 2. Save on Database
        SaveToDatabase(order, total);

        // 3. Send e-mail
        SendEmail(order.CustomerEmail, total);
    }

    private void SaveToDatabase(Order order, decimal total)
    {
        Console.WriteLine("Saving on Database...");
        Console.WriteLine($"Client: {order.CustomerEmail}, Total: R${total:F2}");
    }

    private void SendEmail(string email, decimal total)
    {
        Console.WriteLine($"Sending e-mail to {email} total of US${total:F2}");
    }
}

