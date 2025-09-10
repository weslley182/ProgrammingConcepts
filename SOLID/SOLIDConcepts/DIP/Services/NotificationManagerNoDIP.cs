namespace SOLIDConcepts.DIP.Services;

public class NotificationManagerNoDIP
{
    private readonly EmailService _emailService;

    public NotificationManagerNoDIP()
    {
        _emailService = new EmailService(); // Here is the problem
    }

    public void Notify(string message)
    {
        _emailService.Send(message);
    }
}
