using FactoryPatternExample.Interfaces;

namespace FactoryPatternExample.Factory;
public abstract class Logistics
{
    public abstract ITransport CreateTransport();

    public void PlanDelivery()
    {
        var transport = CreateTransport();
        transport.Deliver();
    }
}
