using SOLIDConcepts.DIP.Interface;

namespace SOLIDConcepts.DIP.Services;

public class SmsService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending SMS: {message} ...");
    }
}
