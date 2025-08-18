namespace SOLIDConcepts.SRP.Service;

public class EmailService
{
    public void SendEmail(string email, decimal total)
    {
        Console.WriteLine($"Sending e-mail to {email} total of US${total:F2}");
    }
}
