using DecoratorPatternExample.Interface;

namespace DecoratorPatternExample.Services;

public class SmsNotifier : NotifierDecorator
{
    public SmsNotifier(INotifier notifier) : base(notifier)
    {
    }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Sending SMS Notification: {message}");
    }
}
