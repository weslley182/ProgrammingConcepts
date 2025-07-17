using FactoryPatternExample.Interfaces;

namespace FactoryPatternExample.Classes.Transports;
public class Plane : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by air in a plane.");
    }
}
