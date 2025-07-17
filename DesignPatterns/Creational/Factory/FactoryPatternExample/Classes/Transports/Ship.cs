using FactoryPatternExample.Interfaces;

namespace FactoryPatternExample.Classes.Transports;
public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by sea in a ship.");
    }
}
