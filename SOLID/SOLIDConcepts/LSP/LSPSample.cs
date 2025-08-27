using OOP_Concepts.Models.General;
using SOLIDConcepts.LSP.Interface;
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

        var custList = new List<Customer>
        {
            new Customer { Email = "wesley@email.com" },
            new SmsOnlyCustomer("+55 11 123-456-7890")
        };

        var notify = new NotificationServiceNoLSP();
        custList.ForEach(customer => notify.Notify(customer));
    }

    private void ExecuteWithLSP()
    {
        Console.WriteLine("=== LSP Sample ===");

        var custList = new List<INotifiable>
        {
            new EmailCustomer("wesley@email.com"),
            new SmsCustomer("+55 11 123-456-7890"),
            new WhatsuppCustomer("+55 11 123-456-6666")
        };

        var notify = new NotificationService();
        custList.ForEach(customer => notify.Send(customer));

    }
}
