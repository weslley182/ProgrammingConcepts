using ObserverPatternExample.Interface;

namespace ObserverPatternExample.Services;

public class TemperatureDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine($"Display: Temperature is now {temperature}°C");
    }
}
