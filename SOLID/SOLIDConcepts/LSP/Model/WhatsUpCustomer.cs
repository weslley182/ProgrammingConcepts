using SOLIDConcepts.LSP.Interface;

namespace SOLIDConcepts.LSP.Model;

public class WhatsUpCustomer : INotifiable
{
    private readonly string _phone;
    public WhatsUpCustomer(string phone)
    {
        _phone = phone;
    }

    public void Notify()
    {
        Console.WriteLine($"Sending WhatsUp message to: {_phone}");
    }
}
