using OOP_Concepts.Models.General;

namespace SOLIDConcepts.LSP.Service;

public class NotificationServiceNoLSP
{
    public void Notify(Customer customer)
    {
        if (customer.Email != null)
        {
            SendEmail(customer.Email);
        }
        else
        {
            Console.WriteLine("Nothing happens.");
        }
    }

    private void SendEmail(string email)
    {
        Console.WriteLine($"Sending email to: {email}");
    }
}
