using SOLIDConcepts.DIP.Services;

namespace SOLIDConcepts.DIP;

public class DIPSample
{
    public void Execute()
    {
        ExecuteWithoutDIP();
        Console.WriteLine();
        ExecuteWithDIP();
    }

    private void ExecuteWithoutDIP()
    {
        Console.WriteLine("=== No DIP Sample ===");

        var notify = new NotificationManagerNoDIP();
        notify.Notify("I hope this email finds you well... ");
    }

    private void ExecuteWithDIP()
    {
        Console.WriteLine("=== DIP Sample ===");
        var mailService = new EmailService();
        var smsService = new SmsService();

        var notify = new NotificationService(mailService);
        notify.Notify("This is a message from an Email.");

        var notifySms = new NotificationService(smsService);
        notifySms.Notify("This is a message from a SMS.");
    }
}
