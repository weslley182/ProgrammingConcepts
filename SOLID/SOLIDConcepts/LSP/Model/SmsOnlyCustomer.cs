using OOP_Concepts.Models.General;

namespace SOLIDConcepts.LSP.Model;

public class SmsOnlyCustomer : Customer
{
    private readonly string _phone;
    public SmsOnlyCustomer(string phone)
    {
        _phone = phone;
    }
}
