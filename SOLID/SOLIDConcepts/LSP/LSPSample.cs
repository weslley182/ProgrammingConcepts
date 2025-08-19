using OOP_Concepts.Models.General;
using SOLIDConcepts.LSP.Model;
using SOLIDConcepts.LSP.Service;

namespace SOLIDConcepts.LSP;

public class LSPSample
{
    public void Execute()
    {
        ExecuteWithoutLSP();

        Console.WriteLine();

        ExecuteWithLSP();
    }

    private void ExecuteWithoutLSP()
    {
        Console.WriteLine("=== No LSP Sample ===");
        var customerSMS = new SmsOnlyCustomer { PhoneNumber = "+55 11 123-456-7890" };
        var customerEmail = new Customer { Email = "send@email.com" };


        var notify = new NotificationServiceNoLSP();
        notify.Notify(customerEmail);
        notify.Notify(customerSMS);
    }

    private void ExecuteWithLSP()
    {
        Console.WriteLine("=== LSP Sample ===");
    }
}
