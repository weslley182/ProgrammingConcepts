using SOLIDConcepts.OCP.Services;

namespace SOLIDConcepts.OCP;

public class OCPSample
{
    public void Execute()
    {
        ExecuteWithoutOCP();
        Console.WriteLine();
        ExecuteWithOCP();
    }

    private static void ExecuteWithoutOCP()
    {
        Console.WriteLine("=== No OCP Sample ===");

        var calculator = new ShippingCalculatorNoOCP();
        Console.WriteLine(calculator.Calculate("EU", 10));
        Console.WriteLine(calculator.Calculate("US", 10));
        Console.WriteLine(calculator.Calculate("ASIA", 10));
    }

    private static void ExecuteWithOCP()
    {
        Console.WriteLine("=== OCP Sample ===");
    }
}