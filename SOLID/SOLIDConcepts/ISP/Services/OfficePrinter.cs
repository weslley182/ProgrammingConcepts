using SOLIDConcepts.ISP.Interface;

namespace SOLIDConcepts.ISP.Services;

public class OfficePrinter : IPrinter, IScanner, IFax
{
    public void Fax()
    {
        Console.WriteLine("Sending Fax...");
    }

    public void Print()
    {
        Console.WriteLine("Printing...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning...");
    }
}
