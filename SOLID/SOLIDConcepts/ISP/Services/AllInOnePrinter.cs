using SOLIDConcepts.ISP.Interface;

namespace SOLIDConcepts.ISP.Services;

public class AllInOnePrinter : IMultiFunctionDevice
{
    public void Print() { Console.WriteLine("Printing..."); }
    public void Scan() { Console.WriteLine("Scanning..."); }
    public void Fax() { Console.WriteLine("Faxing..."); }
}
