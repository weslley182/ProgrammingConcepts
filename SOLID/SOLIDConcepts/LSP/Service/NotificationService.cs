using SOLIDConcepts.LSP.Interface;

namespace SOLIDConcepts.LSP.Service;

public class NotificationService
{
    public void Send(INotifiable customer)
    {
        customer.Notify();
    }
}
