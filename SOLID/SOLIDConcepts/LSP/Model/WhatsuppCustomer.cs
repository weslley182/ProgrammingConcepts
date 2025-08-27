using SOLIDConcepts.LSP.Interface;

namespace SOLIDConcepts.LSP.Model;

public class WhatsuppCustomer : INotifiable
{
    private readonly string _phone;

    public WhatsuppCustomer(string phone)
    {
        _phone = phone;
    }
    public void Notify()
    {
        Console.WriteLine($"Sending WhatsApp message to: {_phone}");
    }
}
