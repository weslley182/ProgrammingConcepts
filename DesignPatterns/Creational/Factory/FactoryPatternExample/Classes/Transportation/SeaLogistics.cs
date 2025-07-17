using FactoryPatternExample.Classes.Transports;
using FactoryPatternExample.Factory;
using FactoryPatternExample.Interfaces;

namespace FactoryPatternExample.Classes.Transportation;
public class SeaLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}
