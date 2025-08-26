using SOLIDConcepts.LSP.Interface;

namespace SOLIDConcepts.LSP.Model;

public class EmailCustomer : INotifiable
{
    private readonly string _email;
    public EmailCustomer(string email)
    {
        _email = email;
    }

    public void Notify()
    {
        Console.WriteLine($"Sending email to: {_email}");
    }
}
