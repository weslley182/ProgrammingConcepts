using DecoratorPatternExample.Interface;

namespace DecoratorPatternExample.Services;

public class EmailNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending EMAIL Notification: {message}");
    }
}
