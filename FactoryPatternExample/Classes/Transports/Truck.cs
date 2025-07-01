using FactoryPatternExample.Interfaces;

namespace FactoryPatternExample.Classes.Transports;

public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by land in a truck.");
    }
}
