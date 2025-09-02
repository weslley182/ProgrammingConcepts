
using SOLIDConcepts.ISP.Services;

namespace SOLIDConcepts.ISP;

public class ISPSample
{
    public void Execute()
    {
        ExecuteWithoutISP();

        Console.WriteLine();

        ExecuteWithISP();
    }

    private void ExecuteWithoutISP()
    {
        Console.WriteLine("=== No ISP Sample ===");

        Console.WriteLine("=== Multi Printer ===");
        var multiPrinter = new AllInOnePrinter();
        multiPrinter.Print();
        multiPrinter.Scan();
        multiPrinter.Fax();

        Console.WriteLine("=== Basic Printer ===");
        var basicPrinter = new BasicPrinter();
        basicPrinter.Print();

        //nothing
        basicPrinter.Scan();
        //error
        //basicPrinter.Fax();
    }

    private void ExecuteWithISP()
    {
        Console.WriteLine("=== ISP Sample ===");

        Console.WriteLine("=== Simple Printer ===");
        var simplePrint = new SimplePrinter();
        simplePrint.Print();

        Console.WriteLine("=== Office Printer ===");
        var officePrint = new OfficePrinter();
        officePrint.Print();
        officePrint.Scan();
        officePrint.Fax();
    }
}
