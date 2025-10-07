using AdapterPattern.Interface;

namespace AdapterPattern.Service;

public static class Demo
{
    public static void Run()
    {
        INotifier notifier = new SmsAdapter(new LegacySmsClient());
        notifier.Send("5511999990000", "Deployed done,");
    }
}
