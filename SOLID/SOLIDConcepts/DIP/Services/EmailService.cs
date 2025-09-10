using SOLIDConcepts.DIP.Interface;

namespace SOLIDConcepts.DIP.Services;

public class EmailService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending email: {message} ...");
    }
}
