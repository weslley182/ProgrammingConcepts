using OOP_Concepts.Models.General;

namespace SOLIDConcepts.SRP;

public class InvoiceCalculator
{
    public decimal CalculateTotal(Order order)
    {
        Console.WriteLine("Calculating total amount...");
        return order.Items.Sum(i => i.Price * i.Quantity);
    }
}
