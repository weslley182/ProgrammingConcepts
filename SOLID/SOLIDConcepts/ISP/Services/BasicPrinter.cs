using SOLIDConcepts.ISP.Interface;

namespace SOLIDConcepts.ISP.Services;

public class BasicPrinter : IMultiFunctionDevice
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }
    public void Scan()
    {
        Console.WriteLine("Do Nothing.");
    }
    public void Fax() => throw new NotSupportedException();
}
