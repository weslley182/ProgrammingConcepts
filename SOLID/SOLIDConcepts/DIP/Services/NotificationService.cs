using SOLIDConcepts.DIP.Interface;

namespace SOLIDConcepts.DIP.Services;

public class NotificationService
{
    private readonly INotificationService _notificationService;
    public NotificationService(INotificationService service)
    {
        _notificationService = service;
    }

    public void Notify(string message)
    {
        _notificationService.Send(message);
    }
}
