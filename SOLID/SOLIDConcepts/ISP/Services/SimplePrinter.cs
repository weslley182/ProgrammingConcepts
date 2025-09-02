using SOLIDConcepts.ISP.Interface;

namespace SOLIDConcepts.ISP.Services;

public class SimplePrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }
}
