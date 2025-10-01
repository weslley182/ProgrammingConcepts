using DecoratorPatternExample.Interface;

namespace DecoratorPatternExample.Services;

public abstract class NotifierDecorator : INotifier
{
    protected readonly INotifier _wrapped;

    protected NotifierDecorator(INotifier notifier)
    {
        _wrapped = notifier;
    }

    public virtual void Send(string message)
    {
        _wrapped.Send(message);
    }
}
