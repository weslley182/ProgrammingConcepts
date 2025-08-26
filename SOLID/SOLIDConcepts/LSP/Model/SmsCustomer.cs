using SOLIDConcepts.LSP.Interface;

namespace SOLIDConcepts.LSP.Model;

public class SmsCustomer : INotifiable
{
    private readonly string _phone;

    public SmsCustomer(string phone)
    {
        _phone = phone;
    }
    public void Notify()
    {
        Console.WriteLine($"Sending SMS to: {_phone}");
    }
}
