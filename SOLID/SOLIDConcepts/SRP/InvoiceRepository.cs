using OOP_Concepts.Models.General;

namespace SOLIDConcepts.SRP;

public class InvoiceRepository
{
    public void SaveToDatabase(Order order, decimal total)
    {
        Console.WriteLine("Saving on Database...");
        Console.WriteLine($"Client: {order.CustomerEmail}, Total: R${total:F2}");
    }
}
