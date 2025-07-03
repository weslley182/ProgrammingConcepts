using FactoryPatternExample.Classes.Transportation;
using FactoryPatternExample.Factory;

public class Program
{
    public static void Main()
    {
        Logistics logistics;

        logistics = new RoadLogistics();
        logistics.PlanDelivery();

        logistics = new SeaLogistics();
        logistics.PlanDelivery();

        logistics = new AirLogistics();
        logistics.PlanDelivery();
    }
}