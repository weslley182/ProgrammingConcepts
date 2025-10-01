using DecoratorPatternExample.Interface;

namespace DecoratorPatternExample.Services;

public class SlackNotifier : NotifierDecorator
{
    public SlackNotifier(INotifier notifier) : base(notifier)
    {
    }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Sending SLACK Notification: {message}");
    }
}
